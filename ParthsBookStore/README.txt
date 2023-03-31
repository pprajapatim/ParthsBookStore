2023-03-03
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










