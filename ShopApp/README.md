
# ShopApp
ShopApp is a demo project of an eCommerce ASP.NET MVC Web Application

## Development Process
Below is a tried and tested "Divide and Conquer" approach to implementing a web application.

### 1) Develop project idea/concept

### 2) Create sketches and wireframes

### 3) Setup Git repo

### 4) Build out HTML and CSS

### 5) Design initial database structure

### 6) Create the initial Visual Studio solution: 
- Project type: ASP.NET Core Web Application
- Architecture: MVC

Push the solution to your GitHub repository.
Remove the default markup in the _Layout.cshtml file, and any other bootstrap markup you don't need.
Once you've cleaned out the initial solution, push it to GitHub a second time.

### 7) Merge your HTML/CSS into the ASP.NET MVC solution
1) First begin by creating a seperate Controller (empty) for each page in your designs.
2) Create a views sub directory inside the Views folder for each controller. E.g. ProductsController should have it's views inside the folder at: `/Views/Products/`. Start by creating the initial `Index.cshtml` view within each view sub directory.
3) Replace the markeup in the `/Views/Shared/_Layout.cshtml` view with your own. Ensure that the `@RenderBody()` method call remains there as a placeholder for your view content. Also ensure your references to CSS and JavaScript files are maintained.
4) Next, update the `Index.cshtml` view files with the page specific markup for each of the pages.

At the end of this process the idea is to have a static website that you can navigate. However there will be no form posts or data being retreived from a database.

### 8) Implement data model
1) Create classes for each model (see Product.cs, Cart.cs and CartItem.cs)
2) Add NuGet packages for the EF library:  https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio#add-nuget-packages.
3) Create a database context class: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio#create-a-database-context-class
4) Register the database context: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio#create-a-database-context-class
5) Add a database connection string: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio#add-a-database-connection-string
6) Add the database model relationships (see OnModelCreating method in ShopAppContext.cs)
7) Initial migration: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio#initial-migration

### 9) Build the Controller endpoints
* See IndexController.cs and Index.cshtml



