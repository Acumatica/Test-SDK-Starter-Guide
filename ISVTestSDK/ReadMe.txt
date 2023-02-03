How to use this file for the first time:

PreReq:
1) Install Acumatica website with the correct specific version you want to target - use SalesDemo data during install - or restore an "Initial test state" snapshot from the tenants screen
2) Download the Test SDK.zip for the same version - extract it to C:\AcumaticaTestSDK
3) Create C:\share
4) Create C:\share\download
5) Create C:\share\logs -> for test results
6) Create C:\share\Customizations -> for storing customizations
7) Create C:\share\Snapshots -> for storing snapshots
8) Create C:\share\Out -> for ClassGenerator.exe wrapper file output

1) Configure the config.xml, and classgenerator.exe.config files.(file output locations, website url, website folder location, screens to generate(any screen that has been edited by customization))
2) Generate the wrappers for the screens by double clicking classgenerator.exe (launches with command prompt, admin not required) - untouched Acumatica screens can be referenced from the dependencies set up below.
In Visual Studio:
1) Import the nuget package into the project dependencies. Test SDK download -> packages folder is the location of the packages.
2) Create, or copy the extension files into the extensions folder
3) Update the names and locations of the customization project and snapshot. If no snapshot exists comment out the "Companies" screen snapshot import code in BeforeExecute
4) Create, or copy your test code into the test.cs
5) If your test or wrapper generation requires config of custom screens to generate all wrappers. Use SQL to insert the data - Support.GetSite().RunSqlScript($@"INSERT [dbo].[TABLE] ([CompanyID], [ApiKey], [ApiURL]) VALUES (2, N'8fds86256hh7j8f78ds8f', N'https://sandbox.testsite.com/api/v4');");
5) Update the project's Properties->launchSettings.json file to use the config.xml location - This lets you just press run(f5) in Visual studio to kick off the test.

_______________________________________________________________________________________________________________
How to update a test project to a newer minor or major version:

1) Download and install the version you want to upgrade to.
2) Publish your customization to the site

3) Download and extract the testSDK.zip for the same version
4) Configure the config.xml, and classgenerator.exe.config files.(file output locations, website url, website folder location, screens to generate (any screen that has been edited by customization))
5) In your visual studio test project, go to "Manage Nuget Packages" and create a new package source
6) Name the source with the version number, using the "packages" folder from the TestSDK download folder as the source.
7) Update/Install the project dependancies/references to use the newly added version
8) Update the project Properties->launchSettings.json to the new config.xml location - This lets you just press run in Visual studio to kick off the test.
9) Regenerate the wrappers using classgenerator.exe, after updating the 2 config files described in step 2, paste the new wrappers into the project.
10) Existing Extensions should not require any changes unless a field was moved or changed.

Run the test, fix anything you missed. Congrats you have upgraded your Test SDK Test project.
