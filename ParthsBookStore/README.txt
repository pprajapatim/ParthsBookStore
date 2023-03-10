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










