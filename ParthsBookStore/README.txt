﻿2023-03-03
1545
Started the Assignment 2 in class on the Lab computer.
set up the ASP.NET MVC w/ core 3.1 (out-of-support)
HTTP enabled, individual account authentication
Reviewed the Areas folder, Controller, Model, View 

1613- n Startup.cs online 33
removed options for default identity:
options => options.SignIn.RequireConfirmedAccount = true

1614
Tested app..ran it good.. Tested links
Action Items:
-Modify the navigation
-update the copyright.. from 'static' to 'dynamic'

1617
Modified the default welcome message tested..
review the rounte pattern in Startup.cs

1619
Confirmed the repo is bulid. Now I want to test it.

1622
Create README.md file in the github and pull it in the Visual Studio.

20203-03-09
1432
Edited bootstrape_bk.css for backup purpose..
selected theme from bootswatch and the theme is Quartz.
added botstrap.min.css to CSS folder

1437
Added code to the bootstrap/css/bootstrap.min.css...
then try to run the app..

1522
change the nav class from navbar-light to navbar-dark and bg-white to bg-primary in _Layout.cshtml in views folder.

1526
Remove text-dark from line 23 in _Layout.cshtml.
Then added aditional properties to the footer class.
Remove text-dark in _LoginPartial.cshtml file and then run the app. 

1533
Added additional stylesheets and scripts from the css_js.txt file in _Layout.cshtml file. 

1543
Added dropdown to the navbar..
Change the dropdown name to Content Management.

1823
Added 3 new .Net core class library projects to the application.
1- ParthsBooks.DataAccess
2- ParthsBooks.Models
3- ParthsBooks.Utility
Then copy the Data folder and paste into the ParthsBooks.DataAccess project and also deleted from the original source.

1835
Install Microsoft.EntityFramework Core.Relational and Core.SqlServer Packages.
And also deleted the Migration folder.

1849
Modify the namespace in ApplicationDbContext.cs
And also Deleted class1.cs file from all projects.

1855
Moved Models folder into ParthsBooks.Models
Added project reference in .DataAccess and .Models project
Rename the Models folder to ViewModels and also change the namespace to .Models.ViewModels

1952
Modify Startup.cs file and run the application to review errors. 
Changed the reference in Error.cshtml to .Models.ViewModels.ErrorViewModels and tested the application.
Getting an error while running the application. 

2023-03-10
1509
Added Identity.Entity nuget package
Thern try to build the projects but got an error that choosen wrong version of 3.1.32 then I updated the version to 3.1.27.
Then rebuild the project without any errors.

1536
Created SD.cs class in the ParthsBooks.Utility.
Thern added project reference of Utility in ParthBooksStore project and project reference of Utility and Models in ParthsBooks.DataAccess project.

2023-03-29
1820
Changed the class to public static class in SD.CS file.

1823
Added Customer to the Areas file.
Also change the routes in ScaffoldingReadMe.txt.

1828
then move the HomeController.cs from controller to area->customer->Controller folder.
After that move the home folder into views folder.
then run the application and got an error.
ERROR:"The constraint reference 'Customer' could not be resolved to a type. Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'."

1848
Copy and paste 2 files _Viewmports.cshtml and _ViewStart.cshtml from views to area->customer folder.

1856
moddify the path in _ViewStart.cshtml file
then run the app and it works perfectly without error.

1910
Added Admin area to Areas
added the view files and deleted the Data, Models and Controllers folder.
and completely finished the Part-1


2023-03-30
PART-2
Build the application and there were no errors.
change the database name in appsettings.json file.

1401
use Nuget Package Manager Console to add migration and also then again added migration after selecting .DataAccess project and it works properly.
file name : 20230330180039_addDefaultIdentityMigration.cs added in the README file.

1407
Then reviewd the file.
After that in the PM console update the database by using update-database.
Review the updated database in the SQL Server Object Explorer then run the application and it work without any error.

1422
Add new class file Catogery.cs into .Models project
then write the given code to Category.cs file and write the command add-migration AddCategoryToDb
in PM console in ParthBooksStore but did not work then
Change the project to .DataAccess and write given command again in PM console and it works.
1430
Updated the ApplicationDbContext.cs file.

1435
Re run the migration command add-migration AddCategoryToDb and got an error (The name 'AddCategoryToDb' is used by an existing migration.)
Again and again got the same error.
then solve the duplication error and also write given migration command in PM consolw and also the command of update-database 
and got the Category table in SQl SOE.
1715
Make Repository folder in .DataAccess project and make new IRepository folder into Repository.
then create and modify the Irepository.cs as said by the given code so that we can do all CRUD operation.

1741
Then write the given code to the IRepository and modified it.
 1745 
 then added (using ParthsBooks.DataAccess.Repository.IRepository;) and implement interface.
 After that modify the code with given code to create constructors and dependency injection. 
 and added (using ParthsBookStore.DataAccess.Data; using Microsoft.EntityFrameworkCore;)

 1820
 Copy and paste the Repository.cs file from Assignment2 folder.
and then also created two file CategoryRepository.cs interface in Repository folder
and ICategoryRepository.cs interface in IRepository.

1838
Then Did the necessary changes in the CategoryRepository.cs.
Then modified ICategoryRepository.cs.

1857
Then Implement the interface to update in  CategoryRepository.cs 
and also modified the CategoryRepository.cs file.
build the app and it works properlly.
then push commits to the github.

1912
Then created ISP_Call.cs interface into the IRepository and also modified ISP_Call.cs.
1930
ISP_Call.cs file is updated.

1935
Added SP_Call.cs file into Repository folder.
then modified SP_Call.cs. 

1955
Write given code into SP_Call.cs and modified it.

2015
Added UnitOfWork.cs interface in Irepository folder.
then modified the UnitOfWork.cs.

2020
Then implemented UnitOfWork into repository folder.
then modified UnitOfWork.cs in Repository folder.

2250
added UnitOfWork and IUnitOfWork in startup.cs file.
commit to the github.
then build the app and work without error

PART-3
2301
Create Controller folder in Area->Admin and also created CategoryController.cs in controller folder.
then modify the  CategoryController.cs with the given code.

2314
Add Category folder into Area->Views.
Then created index.cshtml into Category folder and write the given code from View.txt folder.
then save and run the app.
2330
_Layout.cshtml is updated.
Run the app and work perfectelly as shown.

Then did necesarry changes in dropdown in _Layout.cshtml and run the app again.

2350
Edited the Index.cshtml and run the app.
Added category.js file into wwwroot->js folder.

2023-03-31

in Index.cshtml @section call to the category.js

0014
Upsert action code is wriiten into CategoryController.cs file to activate edit and delete buttons.
0030
make Upsert.cshtml  in Category folder.

0045
created partial view (_CreateAndBackToListButton.cshtml)
created another partial view (_EditAndBackToListButton.cshtml)
0105
Updated Upsert.cshtml file.
also add asp-action to the index.cshtml.
Modify the Upsert.cshtml by using @title and run the app.
then add @section into the Upsert.cshtml.

0130
Added void Save() method to the IUnitOfWork interface.
Remove  _db.SaveChanges() method from CategoryRepository.cs

edited categooryController.cs file.
0216
Added onclick=Delete("/Admin/Category/Delete/${data}") into category.js
Add the delete(url) function code to category.js


13/04/2023

PART-3
1530
Created CoverType.cs file into model.
And also added ID,NAme into CoverType model.

1542
Did migration operation through PM console and 
added CoverTypes just like catagories into ApplicationDbContext.cs.

1600
CoverType find in sql Database table.
Created ICoverTypeRepository in IRepository and CoverTypeRepository in Repositoryfolder.

1615
Updated ICoverTypeRepository and CoverTypeRepository.
This is the name of the migration file (20230413195455_AddCoverTypeToDb.cs).
Also Updated IUnitOfWork.cs and UnitOfWork.cs.

1630
Added CovertypeController.cs into Controller folder in ParthBookStore.
Created CoverType folder into View folder into Area->Admin->Views.
Also created CoverType.js into wwwroot->js.

1655
Run the Application and it works without any error.
The Delete is not working while runnig the App.

1725
Created Product.cs into ParthsBooks.Model.
And Updated this product.cs As given in the pdf.
1738
Added (public DbSet<CoverType> Products { get; set; }) into ApplicationDbContext.cs file.

1745
Did Migration into PM console and also updated the database.
The file created after migration is : (20230413214214_AddProductToDb.cs).

Then Make title ,ISBN and Author required.
Perform migration operation of Add-migration AddValidationToProduct and also updated
the datatbase with update-database operation.

1755
Added ProductRepository class to Repository and IProductRepository interface into IRepository folder.

1900
updated UnitofWork And IUnitOfWork with product.
Then build the application and there were no errors.

1910
Created and updated the ProductController.cs into Area->Admin->Controllers.

1930
Created ProductVM.cs into ViewModels.
Modified the ProductController.cs file.

2001
Commented the Upsert method and CALLS The API CALL.

2015
Updated the product.js file just like  category.js and also updated index.cshtml file of the product.
Modifed the _Layout.cshtml file with product link.

2048
Run the application it works but it gives Exception.

2055
Created the Upsert.cshtml in ParthsBooksStore->Areas->Admin->Product and modified this file with given code.

2010
Created account in tiny.clound
then used my API as suggested.
Then modifies the upsert.cshtml.

2132
Added new folder images into wwwroot and another products folder into images folder.
then uncommented the code into ProductController.cs
Modified the ProductController.cs.
Run the application and still got the exception.


19-04-2023
1516
Update the CSS Color of text in boostrap file so the text are visible. 
Run the application after updating JS file and delete button is working successfully.
After some changes in productController.cs file the app run properlly and the Exception is also solved.

1650
Modified ProductController.cs with upsert post method.
Also modified Upsert.cshtml file in Areas->Admin->Views->Product.

1658
HomeController.cs file is modified by adding the product into the file.
Modifed the Index.cshtml file in home folder, so that we can see the products on the Index Page.

Run the application and got this error. DataTables warning: table id=tblData - Ajax error.
solve the ajax error, then run the app and it work successfully
Then add three products.
these 3 products are visible on page without any errors.