using Ecommerce.DataAccess.Repository;
using Ecommerce.DataAccess.Repository.IRepository;
using Ecommerce.Model;
using Ecommerce.Model.ViewModel;
using Ecommerce.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Security.Claims;


namespace Ecommerce.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;

        }

        public IActionResult Index()
        {

            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            ViewBag.Categories = _unitOfWork.Category.GetAll().ToList();

            return View(productList);
        }
        public IActionResult Details(int productId)
        {
            ShoppingCart cartObj = new()
            {
                Count = 1,
                ProductId = productId,
                Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == productId, includeProperties: "Category"),
            };

            return View(cartObj);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            shoppingCart.ApplicationUserId = claim.Value;

            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.GetFirstOrDefault(
                u => u.ApplicationUserId == claim.Value && u.ProductId == shoppingCart.ProductId);

            if (cartFromDb != null)
            {
                cartFromDb.Count += shoppingCart.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb); // Update the existing cart item
            }
            else
            {
                _unitOfWork.ShoppingCart.Add(new ShoppingCart
                {
                    ProductId = shoppingCart.ProductId,
                    ApplicationUserId = shoppingCart.ApplicationUserId,
                    Count = shoppingCart.Count
                });
            }

            _unitOfWork.Save();
            TempData["success"] = "Cart Updated SuccessFully";
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Products(string search, int? category, string brand, string sort, double? minPrice, double? maxPrice)
        {
            // Retrieve all products with Category details.
            IEnumerable<Product> products = _unitOfWork.Product.GetAll(includeProperties: "Category");

            // Convert to IQueryable for LINQ filtering.
            var query = products.AsQueryable();

            // Apply search filter by product name (case-insensitive).
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Product_Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Filter by category.
            if (category.HasValue)
            {
                query = query.Where(p => p.Category.Id == category.Value);
            }

            // Filter by brand.
            if (!string.IsNullOrEmpty(brand))
            {
                query = query.Where(p => p.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase));
            }

            // Apply price filters.
            if (minPrice.HasValue)
            {
                query = query.Where(p => p.Price >= minPrice.Value);
            }
            if (maxPrice.HasValue)
            {
                query = query.Where(p => p.Price <= maxPrice.Value);
            }

            // Sorting logic.
            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        query = query.OrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        query = query.OrderByDescending(p => p.Price);
                        break;
                    case "nameAsc":
                        query = query.OrderBy(p => p.Product_Name);
                        break;
                    case "nameDesc":
                        query = query.OrderByDescending(p => p.Product_Name);
                        break;
                    default:
                        query = query.OrderBy(p => p.Product_Name);
                        break;
                }
            }
            else
            {
                // Default sort order.
                query = query.OrderBy(p => p.Product_Name);
            }

            // Populate ViewBag for dropdown filters and current selections.
            ViewBag.Categories = _unitOfWork.Category.GetAll().ToList();
            ViewBag.Brands = _unitOfWork.Product.GetAll().Select(p => p.Brand).Distinct().ToList();
            ViewBag.Search = search;
            ViewBag.SelectedCategory = category;
            ViewBag.SelectedBrand = brand;
            ViewBag.Sort = sort;
            ViewBag.MinPrice = minPrice;
            ViewBag.MaxPrice = maxPrice;

            return View(query.ToList());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
