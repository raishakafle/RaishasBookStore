
2023-03-02 
1506

Created a new project to work on the assignment 2 on the lab computer. 

Set up the ASP.NET MVC with core 3.1 (Out of Suppoert)

HTTPS enabled, individual account authentication. 

Reviewed the Areas Folder, Model, Views and Controllers. 

1509

Inside Startup.cs I commented out the options part and saved it. 

Tested to see if the application's working, THANKFULLY IT IS!! 

Action Items: 

-Modify the navigation(just like assignment 1)

-Made some changes to the copyright. (from static to dynamic)

1516

Made some changes at the Welcome page, tested it verified it is still working. 

Added a comment line 65 on Startup.cs

2023-03-03 

1514

Back to working on the project..

1523

Went up to bootswatch.com, where I looked up for really cool themed templates for the project. 

I went up with the Theme "Flatly", then I went up to the roots folder > lib > bootstrap > dist > css. 

I updated the original bootstrap file to the name bootstrap_bk.css while I added a new bootstrap file to the folder. 

2023-03-09

1443

After I updated the older bootstrap file, and created a newer one. I made some changes in the Layout.cshtml file. I made changes inside header> nav 
with a new code that contained the bootstrap code and would work accordingly.

1503

Then, I updated the site css file, and updated that with the newer css from the theme i chose Flatly. 

1557

I then made some changes in the color section to the header and footer in the Layout.cshtml page. I then committed and pushed all the files to GitHub 
and I am all set for now!


2023-03-24 1549

I resumed working on my project and began by checking if the application was still functioning properly. After confirming that everything was working,

I navigated to the solution folder and added a new class named RaishasBook.Utility.

I then created two more files, Raishasbook.Models and RaishasBooks.DataAccess, using the same naming convention. Next, I copied the main data folder from the solution 
folder and pasted it into the respective classes.

I meticulously checked all of the files and folders to ensure their accuracy and consistency with the original files. Afterward, I added additional style sheets and 
scripts to the _Layout.cshtml file and added a dropdown to the Navbar. I changed the name of the dropdown from 'Dropdown' to 'Content Management'. 

In addition, I added three new projects (.NET Core Class Library) to the application. Once I added the data folder to the application, I deleted the original file
and installed Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages onto the program.

I then deleted the Migrations folder and installed the necessary NuGet packages. I also deleted all of the Class1.cs files from the three individual folders.


To organize the project, I moved the Models into the Books.Model folder and deleted the original project. I then modified Views/Shared/Error.cshtml.

I renamed the Models folder to ViewModels and changed the ErrorViewModels.cs namespace and the .ModelsViewModels file. I ran the project to check if it was 
still working, which it was. To further develop the utility project, I created a static details class called SD.cs and modified the properties of the class. 


Then, I added the project reference to the main project. In the DataAccess project, I added project references to Models and Utility. Later on, I added a "Customers 
area to Areas and changed the routes in the Startup.cs to match the ScaffoldingReadMe.txt file. I then edited the HomeController.cs file to explicitly define that
the controller is in the Customer Area. I moved Views into Home and modified the HomeController namespace. 


To ensure the application was still functional, I modified the _ViewStart.cshtml to reflect the new path and ran the application. Once I confirmed that everything
was still working, I added a new ADMIN area to the Areas file. I added the proper Views file and deleted the Data and Models Folder.


Lastly, I updated the GitHub Repository for my new changes in the application. Assignment-2 Part II 2023-03-26 I began by building the application to
check if it was still functional, which it was. I then created the migration file and modified the database name, 
saving the changes.



Using the NuGet Package Manager Console, I added the Migration file, "20230330215833_AddDefaultIdentityMigrationDesign.cs". 
I then updated the database through the PM Console and ran the application. I added a new table to the DB by creating a 
Category Model and pushing it to the DB. I also added a new class file to the .Models project, which I modified. 


I then added the migration file via PM Console, updated the database, confirmed the new Categories table via the SQL SOE, and pushed my commits.
After creating the Category.cs file, I added it to the ApplicationDbContext. I also added a new folder named 'Repository' and added an
'IRepository' folder inside it. 


I created an IRepository.cs interface in the folder and modified it to be used on the Category class to perform all the CRUD operations.
I encountered some errors in the file, so I used the using statement to view potential fixes and implement the interface.


I modified the code to create the constructors and dependency injection (DI).


first task was creating a Cover Type CRUD with the same methods used for Category CRUD, followed by adding CoverType.cs to the
Models folder, which included CoverType Model, ID and Name.

Next, a CoverType was added to the Repository, CoverTypeRepository Class and ICoverTypeRepository Interface, and CoverType to
UnitOfWork and IUnitofWork. The CoverType was then pushed to the database, which involved creating migration and updating the DB.

The Product class was added to the .Models project, followed by adding the code to build the blueprint of this class, ensuring it is
public, and resolving any errors. The next step was adding a reference to the new Products piece to the database in the
ApplicationDbContext.cs file. 

In the PM Console, the add-migration command for an 'addProductToDb' migration and update-database were run. The Product
class was then updated so that Title, ISBN and Author are required, followed by creating a new migration
(addValidationToProduct) and updating the database.



After this, Product was added to the Repository and IProductRepository Interface, followed by adding ProductRepository
Class, and adding Product to UnitOfWork and IUnitofWork. Building and checking for errors, which thankfully revealed
no errors, led to the application being pushed to GitHub.



The next task was starting up with Part 3, 3.2 Product CRUD, which involved adding the Product Controller to the
Areas > Admin > Controllers in order to perform CRUD operations. The IWebHostEvironment call and its using statement 
were added to the Microsoft.AspNetCore.Hosting.



A ViewModel was created in the Models project to hold the Product object and selected the list for Category and CoverType.
The ProductVM class was then modified so that it is public, and the Microsoft.AspNetCore.Mvc.ViewFeatures package was installed.


The ProductController was modified so that the IActionResult Upsert calls to the ProductVM view model, and using statements
were included to the ViewModels folder and Microsoft.AspNetCore.Mvc.Rendering. The Upsert post method was commented out for
the time being.

Moving on, the API call was modified to include the Category and CoverType properties. An Index view was added, 
with the Index.cshtml code copied from Views/Category and modified to the Product List header. A new Product was
created, and properties such as Title, ISBN, Price, Author, and Category were added and referenced in a new

product.js file.

The category.js was copied and renamed as product.js. The _Layout.cshtml was modified to add a new link to Product.
The application was run to check if it was still working, and it was.


Finally, everything was pushed and updated to GitHub, and the application was closed for the day.



