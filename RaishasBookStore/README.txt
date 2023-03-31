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





 














