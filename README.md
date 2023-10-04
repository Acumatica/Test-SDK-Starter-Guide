How to use this project for the first time:

Prerequisite steps:
1) Download the AcumaticaERPInstall.msi, rename it to the version build number
2) Extract the .msi with the following command using command prompt "msiexec /a C:\AcumaticaInstallers\23.200.0144.msi /qb targetdir=C:\AcumaticaInstallers\23.200.0144" - then run ac.exe to start the installer
    This allows you to install multiple versions of acumatica at the same time.
3) Install Acumatica website to C:\AcumaticaSites\23r200pre1 for the correct specific version you want to target - use SalesDemo data during install - name the website and database 23r200pre1
4) Download the TestSDK.zip for the same version - extract it to C:\AcumaticaTestSDK
5) Create C:\share
6) Create C:\share\download
7) Create C:\share\logs -> for test results

In Visual Studio open the Test-SDK-Starter-Guide solution - ISVTestSDK.sln

8) Remove all the old Dependancies -> Packages
9) Go to Manage Nuget Packages -> Add a new package source and add the packages folder from C:\AcumaticaTestSDK\TestSDK_23_200_0144_156\packages
10) Add all references from the new source to the project
11) In test.cs update physicalSitePath to the websites install folder location
12) In launchsettings.json update the commandLineArgs to use your testSDK download C:\AcumaticaTestSDK\TestSDK_23_200_0144_156\config.xml  - This lets you just press run in Visual studio to kick off the test.
13) Configure that config.xml from C:\AcumaticaTestSDK\TestSDK_23_200_0144_156 to match your site (use the chrome location from testSDK download folder C:\AcumaticaTestSDK\TestSDK_23_200_0144_156\Chrome\chrome.exe 
    , not your personal chrome browser and website url)
14) Configure and run the GenerateWrappers() method.
_______________________________________________________________________________________________________________
How to update a test project to a newer minor or major version:

Prerequisite steps:
1) Download and install the Acumatica version you want to upgrade to. Install it to C:\AcumaticaSites\23r200pre1 for the correct specific version you want to target - use SalesDemo data during install - 
    name the website and database 23r200pre1
2) Publish your customization to the site
3) Download and extract the testSDK.zip for the same version - extract it to C:\AcumaticaTestSDK

In Visual Studio open the Test-SDK-Starter-Guide solution - ISVTestSDK.sln

4) Remove all the old Dependancies -> Packages
5) Go to Manage Nuget Packages -> Add a new package source and add the packages folder from C:\AcumaticaTestSDK\TestSDK_23_200_0144_156\packages
6) Add all references from the new source to the project
7) In test.cs update physicalSitePath to the websites install folder location
8) In launchsettings.json update the commandLineArgs to use your testSDK download C:\AcumaticaTestSDK\TestSDK_23_200_0144_156\config.xml  - This lets you just press run in Visual studio to kick off the test.
9) Configure that config.xml from C:\AcumaticaTestSDK\TestSDK_23_200_0144_156 to match your site (use the chrome location from testSDK download folder C:\AcumaticaTestSDK\TestSDK_23_200_0144_156\Chrome\chrome.exe
    , not your personal chrome browser and website url)
10) Configure and run the GenerateWrappers() method.
11) Existing Extensions should not require any changes unless a field was moved or changed.
_______________________________________________________________________________________________________________
Certification submission Requirements and best practices:

1) No external dependancies may be used to run the tests
2) Any Excel files must be included in the Excels folder and imported using the sample code
3) All files must have the namespace - exactly "namespace GeneratedWrappers.SOLUTIONNAME" where SOLUTIONNAME is your registered solution name from the ISV Partner Portal in capital letters
4) You must use the GenerateWrappers() Method
5) From the starting state of SalesDemo data + your customization packages published - with no manual configuration - You must make all pages accessable before wrapper generation using a Customization Plug-In 
    or testSDK code or wrapper generation will fail.
6) From the starting state of SalesDemo data + your customization packages published - All setup data must be done via testSDK code or Customization Plug-in to configure the test starting state. Snapshots 
    are not supported.
7) You must execute all tests in order from 1 test.cs file

_______________________________________________________________________________________________________________
Common Errors: 
If you encounter any errors check the C:\share\logs, or your file paths in the previous config steps if a log doesnt exist.

1) Test exited with Error code 0: The test passed successfully. 
2) Test exited with Error code 2: Your test has failed, please check the generated log file we configured in step 11 
3) Test exited with Error code 1: Invalid/missing file, likely incorrect folder mapped in the config files somewhere or a missing wrapper/extension 
4) Acumatica site no longer accessible after generating wrappers or running a test: The Wrapper Generation process ended without resetting and releasing the web.config. 
    a) Wait for the Wrapper generation to finish and self close and it will unlock. Do not manually close the classgenerator.exe window.
    b) Fix it by copying the original saved web.config that was stored in the website folder as “web.config.63b98fa0”  or similar into the web.config file.
