How to use this project for the first time:

PreReq:
1) Install Acumatica website with the correct specific version you want to target - use SalesDemo data during install
2) Download the Test SDK.zip for the same version - extract it to C:\AcumaticaTestSDK
3) Create C:\share
4) Create C:\share\download
5) Create C:\share\logs -> for test results

6) Remove old Dependancies -> Packages
7) Manage Nuget Packages -> Add the packages folder of testSDK download
8) Add all references from the packages folder
9) In test.cs update physicalSitePath to websites install folder
10) In launchsettings.json update the commandLineArgs to use your testSDK download config.xml - This lets you just press run in Visual studio to kick off the test.
11) Configure that config.xml for your site (update chrome location from testSDK download folder, not your personal chrome browser and website url)
12) Generate the wrappers using GenerateWrappers() method.
_______________________________________________________________________________________________________________
How to update a test project to a newer minor or major version:

1) Download and install the version you want to upgrade to.
2) Publish your customization to the site

3) Download and extract the testSDK.zip for the same version
4) Remove old Dependancies -> Packages
5) Manage Nuget Packages -> Add the packages folder of testSDK download
6) Add all references from the packages folder
7) In test.cs update physicalSitePath to websites install folder
8) In launchsettings.json update the commandLineArgs to use your testSDK download config.xml - This lets you just press run in Visual studio to kick off the test.
9) Configure that config.xml for your site (update chrome location from testSDK download folder, not your personal chrome browser and website url)
11) Regenerate the wrappers using GenerateWrappers() method.
12) Existing Extensions should not require any changes unless a field was moved or changed.


Common Errors: 
If you encounter any errors check the C:\share\logs, or your file paths in the previous config steps if a log doesnt exist.

1) Test exited with Error code 0: The test passed successfully. 
2) Test exited with Error code 2: Your test has failed, please check the generated log file we configured in step 11 
3) Test exited with Error code 1: Invalid/missing file, likely incorrect folder mapped in the config files somewhere or a missing wrapper/extension 
4) Acumatica site no longer accessible after generating wrappers or running a test: The Wrapper Generation process ended without resetting and releasing the web.config. 
    a) Wait for the Wrapper generation to finish and self close and it will unlock. Do not manually close the classgenerator.exe window.
    b) Fix it by copying the original saved web.config that was stored in the website folder as “web.config.63b98fa0”  or similar into the web.config file.
