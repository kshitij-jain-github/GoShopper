
🛍️ GoShopper
=============

**E-commerce Platform – Built with ASP.NET Core & Razor Pages**

GoShopper is a full-stack e-commerce web application developed using **ASP.NET Core**, **Entity Framework**, and **Razor Pages**, providing users with a smooth shopping experience and admins with full management control.

This project includes features like secure payments, external logins (Google & Facebook), session management, email notifications, and role-based access control.

🚀 Features
-----------

*   **User Authentication & External Login**
    
    *   Login using custom credentials or via Google and Facebook OAuth.
        
    *   Secure authentication using ASP.NET Identity Framework.
        
*   **Role-Based Access Control**
    
    *   Admin and User roles with different permissions.
        
    *   Admins can manage products, orders, and users.
        
*   **Cart & Checkout System**
    
    *   Add, update, and remove products from cart.
        
    *   Checkout flow integrated with payment and order confirmation.
        
*   **Secure Payment Integration**
    
    *   Payment gateway integrated for real-time transactions.
        
*   **Email Notification System**
    
    *   Sends emails for order confirmation, registration, and other activities using SMTP.
        
*   **Session Management**
    
    *   Cart and login session retained for logged-in users.
        

🧰 Tech Stack
-------------

AreaTechnologyBackendASP.NET Core (.NET 6)FrontendRazor Pages (MVC), HTML, CSSDatabaseSQL ServerORMEntity Framework CoreAuthenticationASP.NET Identity FrameworkExternal LoginsGoogle & Facebook OAuthEmailSMTP using .NET Mail ServicesArchitectureMulti-layered (DataAccess, Models, Utility, UI)

📂 Project Structure
--------------------

Plain textANTLR4BashCC#CSSCoffeeScriptCMakeDartDjangoDockerEJSErlangGitGoGraphQLGroovyHTMLJavaJavaScriptJSONJSXKotlinLaTeXLessLuaMakefileMarkdownMATLABMarkupObjective-CPerlPHPPowerShell.propertiesProtocol BuffersPythonRRubySass (Sass)Sass (Scss)SchemeSQLShellSwiftSVGTSXTypeScriptWebAssemblyYAMLXML`   GoShopper/  ├── GoShopper.DataAccess/   # Entity Framework DbContext & Repositories  ├── GoShopper.Models/       # Data models (Product, User, Order, etc.)  ├── GoShopper.Utility/      # Helpers & utility functions (EmailService, PaymentService)  ├── GoShopper/              # Razor UI (Pages, Views, Controllers)  ├── GoShopper.sln           # Visual Studio Solution file  ├── .gitignore              # Git ignore rules  └── README.md               # Project overview   `

🛠️ Getting Started
-------------------

### 🔧 Prerequisites

*   [.NET 6 SDK or newer](https://dotnet.microsoft.com/download)
    
*   [SQL Server (Express or Developer edition)](https://www.microsoft.com/en-us/sql-server/)
    
*   Visual Studio 2022 or Visual Studio Code
    

### 🚀 Setup Instructions

1.  **Clone the Repository**
    

Plain textANTLR4BashCC#CSSCoffeeScriptCMakeDartDjangoDockerEJSErlangGitGoGraphQLGroovyHTMLJavaJavaScriptJSONJSXKotlinLaTeXLessLuaMakefileMarkdownMATLABMarkupObjective-CPerlPHPPowerShell.propertiesProtocol BuffersPythonRRubySass (Sass)Sass (Scss)SchemeSQLShellSwiftSVGTSXTypeScriptWebAssemblyYAMLXML`   git clone https://github.com/kshitij-jain-github/GoShopper.git  cd GoShopper   `

1.  **Restore Dependencies**
    

Plain textANTLR4BashCC#CSSCoffeeScriptCMakeDartDjangoDockerEJSErlangGitGoGraphQLGroovyHTMLJavaJavaScriptJSONJSXKotlinLaTeXLessLuaMakefileMarkdownMATLABMarkupObjective-CPerlPHPPowerShell.propertiesProtocol BuffersPythonRRubySass (Sass)Sass (Scss)SchemeSQLShellSwiftSVGTSXTypeScriptWebAssemblyYAMLXML`   dotnet restore   `

1.  **Apply Migrations**
    

Plain textANTLR4BashCC#CSSCoffeeScriptCMakeDartDjangoDockerEJSErlangGitGoGraphQLGroovyHTMLJavaJavaScriptJSONJSXKotlinLaTeXLessLuaMakefileMarkdownMATLABMarkupObjective-CPerlPHPPowerShell.propertiesProtocol BuffersPythonRRubySass (Sass)Sass (Scss)SchemeSQLShellSwiftSVGTSXTypeScriptWebAssemblyYAMLXML`   cd GoShopper.DataAccess  dotnet ef database update  cd ..   `

1.  **Run the Application**
    

Plain textANTLR4BashCC#CSSCoffeeScriptCMakeDartDjangoDockerEJSErlangGitGoGraphQLGroovyHTMLJavaJavaScriptJSONJSXKotlinLaTeXLessLuaMakefileMarkdownMATLABMarkupObjective-CPerlPHPPowerShell.propertiesProtocol BuffersPythonRRubySass (Sass)Sass (Scss)SchemeSQLShellSwiftSVGTSXTypeScriptWebAssemblyYAMLXML`   dotnet run --project GoShopper   `

1.  **Access in Browser**
    

Navigate to https://localhost:5001 in your web browser.

📸 Screenshots
--------------

> _(Replace the placeholder links with actual images from your application)_

*   🏠 Home Page
    
*   🛒 Cart Page
    
*   ⚙️ Admin Dashboard
    

🌱 What I Learned
-----------------

Throughout the development of GoShopper, I gained hands-on experience in:

*   Building full-stack applications using **.NET Core** and **Razor Pages**
    
*   Implementing **external login systems** using Google and Facebook
    
*   Managing **user roles and permissions** using ASP.NET Identity
    
*   Designing an **email notification system** using SMTP
    
*   Integrating **payment workflows** and handling session data
    
*   Working with **Entity Framework** to manage database operations and migrations
    

🤝 Contributions
----------------

Contributions are welcome!

To contribute:

1.  Fork this repository
    
2.  Create a new branch (git checkout -b feature/your-feature)
    
3.  Make your changes and commit them
    
4.  Push to your fork (git push origin feature/your-feature)
    
5.  Open a Pull Request for review
    

📬 Contact Me
-------------

If you have any questions, feedback, or suggestions, feel free to reach out:

*   📧 Email: [**work.kshitijjain@gmail.com**](mailto:work.kshitijjain@gmail.com)
    
*   💼 LinkedIn: [Kshitij Jain](https://www.linkedin.com/in/kshitij-jain-bbbab4140)
    
*   🌐 Portfolio: _(Add your portfolio link here if available)_
    

🌐 Live Demo
------------

> _(Optional – Add deployment link here if hosted on Azure, Vercel, etc.)_[Live Demo – Coming Soon](https://chatgpt.com/c/6855125d-912c-8011-b32e-4393d1c4ca96#)

⭐ Support
---------

If you found this project helpful or learned something from it, consider giving it a ⭐ on GitHub to show your support!

Let me know if you'd like:

*   Custom banner design
    
*   GIF-based app demo
    
*   Deployment support for live demo
    

Happy coding! 🚀
