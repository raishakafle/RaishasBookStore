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


Then I update the Product class so Title, ISBN and Author are [Required], later created a new migration
(addValidationToProduct) and updated the database.




























