How to use this project for the first time:

PreReq:
1) Install Acumatica website with the correct specific version you want to target - use SalesDemo data during install
2) Download the Test SDK.zip for the same version - extract it to C:\AcumaticaTestSDK
3) Create C:\share
4) Create C:\share\download
5) Create C:\share\logs -> for test results
6) Create C:\share\Customizations -> for storing customizations

1) Configure the config.xml, and test.cs Wrapper Generation variables.(physicalSitePath, username, Namespace, GI's, screens)
2) Generate the wrappers for the screens by using the GenerateWrappers() method in Test.cs (launches with command prompt - let it process for 5+ mins, do not close this windown manually)
In Visual Studio:
1) Import the nuget package into the project dependencies. Test SDK download -> packages folder is the location of the packages.
2) Create, or copy the extension files into the extensions folder
3) Update the names and locations of the customization project in the test.cs and launchSettings.json
4) Create, or copy your test code into the test.cs
5) If your screens require pre configuration to become accessible: Use Customization plug-In to enter the required data
5) Update the project's Properties->launchSettings.json file to use the config.xml location - This lets you just press run(f5) in Visual studio to kick off the test.

_______________________________________________________________________________________________________________
How to update a test project to a newer minor or major version:

1) Download and install the version you want to upgrade to.
2) Publish your customization to the site

3) Download and extract the testSDK.zip for the same version
4) Configure the config.xml, and test.cs Wrapper Generation variables.(physicalSitePath, username, Namespace, GI's, screens)
5) In your visual studio test project, go to "Manage Nuget Packages" and create a new package source
6) Name the source with the version number, using the "packages" folder from the TestSDK download folder as the source.
7) Update/Install the project dependancies/references to use the newly added version
8) Update the project Properties->launchSettings.json to the new config.xml location - This lets you just press run in Visual studio to kick off the test.
9) Regenerate the wrappers using GenerateWrappers() method, after updating the 2 config files described in step 2, paste the new wrappers into the project.
10) Existing Extensions should not require any changes unless a field was moved or changed.

Run the test, fix anything you missed. Congrats you have upgraded your Test SDK Test project.
