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

After I updated the older bootstrap file, and created a newer one. I made some changes in the Layout.cshtml file. I made changes inside header> nav with a new code that contained the bootstrap code and would work accordingly.

1503

Then, I updated the site css file, and updated that with the newer css from the theme i chose Flatly. 

1557

I then made some changes in the color section to the header and footer in the Layout.cshtml page. I then committed and pushed all the files to GitHub 
and I am all set for now!


2023-03-24
1549

I am now starting to continue resuming the project where I left at.

First off, I opened the aplication and checked to see if it was still working. After being sure, I went to the solution folder, and added a new class where I named it RaishasBook.Utility, and
created two more files in the same way where I named them, Raishasbook.Models and RaishasBooks.DataAccess respectively. 


Later, I took the main data folder from the solution folder and copied it into the respective classes. After which of course I am checking all of the files and folders if they are correct and
as same as the original one running in order. 

 After which I added I added the additional style sheets and script to the _Layout.cshtml file.
 And then, I went on to add a dropdown to the Navbar.

 I changed 'Dropdown to 'Content Management'.

1620

I added three new projects (.NET Core Class Library ) into the applicastion.
After which I copied the data folder into the application, deleted the original file. 
Went on to install Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages onto the program.

I continued on to delete the Migrations folder. I then installed the NuGet packages. Also,
deleted all of the Class1.cs files from the three individual folders.

1645

I moved the Models into Books.Model where I deleted the original project. I then modified Views/Shared/
Error.cshtml.

I had to then, rename the Models folder to ViewModels, and change the ErrorViewModels.cs namespace and
the .ModelsViewModels file. 

I ran the project to check and see if it was still working.
Thankfully, it was!

I then modified the startup.cs with 'AddContext' with the using statement. 

1655

Into the utility project, I created a static details class, called SD.cs. Moving on to, modifying the 
properties of the class. And then, I added the project reference to the main project. 

And into the DataAccess project I added project references to Models and Utility. 

1720

Later on I went on with adding a "Customers area to Areas. Then, changed the routes in the Startup.cs 
just like the one outlined in the ScaffoldingReadMe.txt file. 

Moving on to, switch the HomeController.cs to the Area>Customer>Controller folder and
delete Data and Models.

1734

I then edited the HomeController.cs file to explicitly define that the controller is in the Customer 
Area. I moved Views into Home and then modified the HomeController namespace. 

I modified the _ViewStart.cshtml to reflect the new path, then ran the application to see if it was 
still working, which it was so I moved on to adding a new ADMIN area in thbe Areas file. 

I added the proper Views file, and the deleted the Data and Models Folder.

I deleted the controllers folder, the updated the GitHub Repository for my new changes in the applpication.

Assignment-2 
	
	Part II

	2023-03-26

1214

First I built the application to see if it was still working, which it was of cource. Then, I created 
the migrations file, modified the database name and saved. 

Using the NuGet Package Manager Console, I added the Migration file. 
20230330215833_AddDefaultIdentityMigrationDesign.cs

Moving on to update the database through the PM Console, then I ran the application.

1223

I added a new table to the DB by creating a Category Model and push it to the DB, then
I added a new class file to the .Models project which I mmodified.

Then, I added the migration file via PM Console, updated the database confirmed
the new Categories table via the SQL SOE and pushed commits. 

1232

After I created the Category.cs file, I added it to the ApplicationDbContext. 
I added a new folder named 'Repository', and added an 'IRepository' folder inside it.

Also added, a folder named IRepository.cs an interface, to the folder itself. After which,
I modifies it because, it can be used on the Category class to do all the CRUD operations.

I got some erros in the following file, so used the using statement View the potential fixes and 
implement interface. 

I modified the code to create the constructors  and de[endency injection (DI).

1253

I then created individual repos for catgory and all potential models top be added in the future. 
The files included: 
	CategporyRepository.cs
	ICategporyRepository.cs


I then modified the CategporyRepository.cs file and the ICategporyRepository.cs interface as well.

Using .NET LINQ  I retrieved the first or default category object, I then passed the id as a generic entity 
which matchesd the category ID. 

JUST A REMINDER THAT I RAN THE PROGRAM TO CHECK AND SEE IF IT WAS STILL WORKING, AND IT WAS!! :)

I then added a new interface in the IRepository folder- ISP_Calls.cs- that extends IDisposable. 
Added a class  named SP_Call.cs in the repository folder. I then, added a connection to the database
and then mupdates the im,plementatiopn of the ISP_Call interface. 

1352

Moving on, I added a new interface (IUnitOfWork) to the IRepository folder, and update the code. 

I then added a class wheree i implemented the interface mentioned above. Then modified the code, 
made it accessible by the project. 

1421

I added a new MVC Controler- Empt inside Areas/Admin which i named as, CategoryController.cs. 
I then modified the code because I needed to access the IunitOfWork from the .DataAccess project and the
IRepository folder. 

I added a new folder in the Areas/Views with the same name as the Controller. I added a new Index view
to the folder. 

Then, in the _Layout.cshtml, I mocved the "Category", link to the Content Management frop-down. 

I had some erros in having to include the icons, so I decided i would work on it later. 


I modified the UpSert.cshtml file, where I added the asp-action to the Index.cshtml page and ran the
application. I then, navigated to the Category> Create New category.

I modified the Uposert.cshtml file title so TITLE now uses the @title variable. Added the @section call 
to Scripts to validate input. 

2023-03-30
		
	 1342

I created an Upsert POST action method in the CategoryController.cs file. I removed some methods in the 
CategoryRepository.cs and moved the _unit OfWork.Save() method with the return. 

Furthermore, I added the API (Application Programming Interface) call for HTTPDelete with a delete method
in category.js to add functionality to the application and call the API. 

I added the delete functionality in category.js with incuding the onclick event to the Delete function.

I added the (Delete)url function code. 

Time to see what the application looks like for the time being :\

Everything else works perfectly fine, but the data entered by the user into the table is not working, 
where the data has been stored but it jusdt does not display the database. 


2022-04-10
4:39

I create Cover Type CRUD with the exact same methods used for Category CRUD
Then Added CoverType.cs in the Model’s folder
and added CoverType Model ID, Name.


2023-04-13

1224

Back to working on the MVC Application, starting up with Assignment II Part 1.

I started off with creating a cover Type Crud with the exact same methods I used for category CRUD. 
I then added CoverType.cs in the Model's folder. CoverType Model, ID and Name. 

1235

Moving on with adding a CoverType to the Repository, CoverTypeRepository Class and, 
ICoverTypeRepository Interface, CoverType to UnitOfWork and IUnitofWork
Then I had to Push CoverType to the Database (Create migration and update the DB)..

Next, I had to Add CoverType to the Repository. And CoverTypeRepository Class,
ICoverTypeRepository Interface, and CoverType to UnitOfWork and IUnitofWork.
Moving on to Pushing the CoverType to the Database (Create migration and update the DB).


1349

After a short lunch break, and looking through what I need to be doing next up in the project 
I am ready to get started on the application. 

Part 3
3.2 

1355

First I Added a new class (Product) in the .Models project. Then, I also added the code to build the
blueprint of this class and make sure it’s “public” and that any errors are resolved.

Next up I am Adding reference to the new Products piece to the database in the ApplicationDbContext.cs file.
And, in the PM Console, I ran the add-migration command for an  ‘addProductToDb’ migration and update-database.


Then I updated the Product class so Title, ISBN and Author are [Required], later created a new migration
(addValidationToProduct) and updated the database.

1432

After this I added Product to the Repository, and added IProductRepository Interface.
Also adding ProductRepository Class.I Then added Product to UnitOfWork and IUnitofWork.


After all this I Built and checked for errors, Thankfully, no errors so I pushed it to GitHub.


1443

Staring up with Part 3
3.2 Product CRUD

Strarting up with adding Product Controller to the Areas > Admin > Controllers in order to perform the CRUD operations.
I then add4d the IWebHostEvironment call and its using statement to the Microsoft.AspNetCore.Hosting.

Then, I Created a ViewModel in the Models project to hold the Product object and selected the list for Category and CoverType.


1645

BACK AFTER A SHORT BREAK! 

I resumed with modifying the ProductVM class so it is public and then, I intalled the Microsoft.AspNetCore.Mvc.ViewFeatures package.

Then I Modified the ProductController so the IActionResult Upsert calls to the ProductVM view model, then included the using statements
to the ViewModels folder and Microsoft.AspNetCore.Mvc.Rendering.

I commented out the Upsert post method for now as for the tutorial. Then, I modified the API call to include the Category and CoverType properites.

Moving on, I added an Index view. Copied the Index.cshtml code from Views/Category and modified to the Product List header,
Created a New Product and added the following properties 
– Title / ISBN / Price / Author / Category and referenced a new product.js file.  
Where, my js file has still not been working yet but decided to fix it as I go through the project so MOVING ON!

1720

I then Copied/Pasted the category.js and renamed the file to product.js.
I also Modified the _Layout.cshtml to added a new link to Product.

I Ran the application to see if it was still working, and it was. 

Pushing and updating everything to GitHub, abd closing up the application for now. 

------------------


2023-04-18

2253

Starting off with creating an upsert.cs for Products file.

Which I modified in the areas> Admin> Views > Product. 

After which, I added a rich textbox to the textarea inside Product, with tiny.cloud I also created an
account, using the API key provided.


Later on, I went on to initialize and add a function to validate input and if empty, displayed  
a SweetAlert. 

I checked to see if the application was running which it was, Thankfully!

I tried to create a new product, which showed on the application, but was not updating on the database, 
so had to fix that error that was showing up.



2023-04-19

1842

Later on, I went on adding a new folder and a sub folder along with it inside the wwwroot > images > products
folder.

Furthermore, inside of the ProductController configure folder the product Upsert Post action method. 
During the events going on I tried running the program, which showed a lot of errors, 

Working on the error trying to figure out the problem. 

1921

Figured out the error, the name category had been showing up in case of ProductType, which is why
the system was throwing up so much errors on me. 

Looking for solutions to figure this!!!

2023

Still working on finding a solution for the error. 

Working on the solution for a while, where I finally figured I could get into the sql database and make 
some changes in there in order to solve the error. 

I changed the name "Categpory" into "ProductType", where all the errors I was facing faded away!!

Tried running the application after this, and is working pretty smooth! 


2122

Almost done with the project, now have to display the ProductList (productindex.cshtml) as the main page 

Whenever the page loads the ProductList needs to be the one that loads as the home page. Trying to 
figure out ways to look through it.

Also, the delete button in the productList is not working, so trying to solve this error as well.

2132

Looking through the files if I can find anything that can help me solve the error, where I found a comment 
on Startup.cs page line 70..

                    //This is the default route pattern that could possibly be updated in the future. 
                    pattern: "{area=Admin}/{controller=Product}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

Where I figured as the comments say " could possibly be updated in the future. " Where I had to change 
Category into Product and the error ws solved!

I ran the projec to check and see if it was working, when I made a confirmation that it was I stopped.

Will come back for Part 5!!




















 














