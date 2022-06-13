How to use this file for the first time:

PreReq:
1) Install Acumatica website with the correct specific version you want to target - recommended using SalesDemo data during install - or restore a custom snapshot from the tenants screen
2) Download the Test SDK.zip for the same version - extract it

1) Configure the config.xml, and classgenerator.exe.config files.(file output locations, website url, website folder location, screens to generate)
2) Generate the wrappers for all screens you plan to touch by double clicking classgenerator.exe
In Visual Studio:
1) Import the nuget package into the project dependencies. Test SDK download -> packages folder is the location of the packages.
2) Create, or copy the extensions into the extensions folder
3) Update the names and locations of the customization project and snapshot. If no snapshot exists comment out the "Companies" screen snapshot import code in BeforeExecute
4) Create, or copy the test code into the test.cs
5) Right click the project name, go to properties, go to the debug menu of properties, update the "Application Arguments" to match your testSDK config.xml .\Tests.exe /config "C:\TestSDK_22_105_0031_32\config.xml" - This lets you just press run in Visual studio to kick off the test.

_______________________________________________________________________________________________________________
How to update a test project to a new version:

Initial setup:
*If using a snapshot as your initial test State:
1) First, Import and publish the newest customization to the old/existing site. Second, Restore the snapshot with the initial state data to the old/existing test website. Third, re-import and publish the newest customization again after snapshot resotre.
2) Download the website installer version you want to upgrade to, perform a website upgrade on the old/existing site to update to the new one. (This updates the database AND site files together, If you do a database upgrade only it will cause errors on the site)
3) Create a new updated snapshot from the upgraded version of the website, store it perminently with the version information in the title, then restore it  before each time you run your tests (using step 1 procedure).

**If using SalesDemo or no data as your initial state:
1) Download and install the version you want to upgrade to.
2) Publish your customization to the site

Continued process after initial setup:
1) Download and extract the testSDK.zip for the same version
2) In your visual studio test project, go to "Manage Nuget Packages" and create a new package source
3) Name the source with the version number, using the "packages" folder from the TestSDK download folder as the source.
4) Update/Install the project references to use the newly added version
5) Regenerate the wrappers using classgenerator.exe, after updating the 2 config files described at the top of this readme, paste the new wrappers into the project.
6) Existing Extensions should not require any changes unless a field was moved or changed.

Run the test, fix anything you missed. Congrats you have upgraded your Test SDK Test project.
