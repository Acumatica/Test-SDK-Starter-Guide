# Acumatica Test SDK Starter Guide

Welcome to the Acumatica Test SDK Starter Guide! This guide is designed to help developers set up and run tests using the Acumatica Test Software Development Kit (SDK). Whether you're just starting out or looking to upgrade an existing project, follow the steps below to ensure a smooth testing experience with Acumatica.

## Table of Contents
- [Setting up a New Test Project](#setting-up-a-new-test-project)
- [Upgrading to a Newer Version](#upgrading-to-a-newer-version)
- [Certification Submission Requirements](#certification-submission-requirements)
- [Common Errors and Troubleshooting](#common-errors-and-troubleshooting)

## Setting up a New Test Project

### Prerequisites
1. Create directories:
    - `C:\AcumaticaTestSDK`
    - `C:\AcumaticaInstallers`
    - `C:\AcumaticaSites`
    - `C:\share`
    - `C:\share\download`
    - `C:\share\logs` (for test results)
2. Download the [AcumaticaERPInstall.msi](https://builds.acumatica.com/index.html?prefix=builds/23.2/23.201.0092/AcumaticaERP/AcumaticaERPInstall.msi) and rename it to the version build number eg. 23.201.0092.msi then place it into the 'C:\AcumaticaInstallers' folder.
3. Download and extract the `TestSDK.zip` for the matching version from [this link](https://builds.acumatica.com/index.html?prefix=builds/23.2/23.201.0092/TestSDK/) to `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93`.

### Installation and Configuration
1. Extract the .msi using this command, this command allows you to install multiple versions of Acumatica on the same machine.:
    ```cmd
    msiexec /a C:\AcumaticaInstallers\23.201.0092.msi /qb targetdir=C:\AcumaticaInstallers\23.201.0092
    ```
   Run `ac.exe` from the extracted folder to start the Acumatica installer.
2. Install Acumatica website to `C:\AcumaticaSites\23r201` for the specific version. Use the `SalesDemo` data during install and name the website and database `23r201`.
3. Login to the new website at `localhost/23r201` with initial credentials: 
- **Username:** `admin`
- **Password:** `setup`
- **Suggested new password:** `123` for local testing 
4. In Visual Studio, open the `Test-SDK-Starter-Guide` solution (`ISVTestSDK.sln`).
5. Remove all old Dependencies -> Packages.
6. Navigate to Manage NuGet Packages, add a new package source, and include the packages folder from `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93\packages`.
7. Add all references from the new NuGet source to the project.
8. In `test.cs`, update `physicalSitePath` to the website's install folder location`C:\AcumaticaSites\23r201`.
9. In `launchsettings.json`, update the `commandLineArgs` to point to `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93\config.xml`.
10. Configure `config.xml` from `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93` to match your site. Use the Chrome version from `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93\Chrome\chrome.exe`.
11. Configure and run the `GenerateWrappers()` method.

## Upgrading to a Newer Version

### Prerequisites
1. Download and install the Acumatica version you want to upgrade to at `C:\AcumaticaSites\23r201`. Use `SalesDemo` data during install and name the website and database `23r201`.
2. Publish your customization to the site.
3. Download and extract `testSDK.zip` for the corresponding version to `C:\AcumaticaTestSDK`.

### Visual Studio Configuration
1. Open the `Test-SDK-Starter-Guide` solution (`ISVTestSDK.sln`).
2. Remove all old Dependencies -> Packages.
3. Navigate to Manage NuGet Packages, add a new package source, and include the packages folder from `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93\packages`.
4. Add all references from the new NuGet source to the project.
5. In `test.cs`, update `physicalSitePath` to the website's install folder location.
6. In `launchsettings.json`, update the `commandLineArgs` to point to `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93\config.xml`.
7. Configure `config.xml` from `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93` to match your site. Use the Chrome version from `C:\AcumaticaTestSDK\TestSDK_23_201_0092_93\Chrome\chrome.exe`.
8. Configure and run the `GenerateWrappers()` method.

## Certification Submission Requirements
- Submit the following folders and file inside a .zip `Excels, Extensions, Helpers,Tests, Wrappers, Test.cs`.
- You must use the exact folder structure and place files in their respective places, Helpers folder is for uncategorized items.
- No external dependencies may be used to run the tests.
- Any Excel files must be named starting with SOLUTONNAMEFileName.xlsx and Imported using the sample code with excelsPath and new ExcelPackage(new FileInfo(...));
- **All files** should have the exact namespace: "namespace GeneratedWrappers.SOLUTIONNAME" where `SOLUTIONNAME` is your registered solution name from the ISV Partner Portal in uppercase.
- Use the Test.cs to kick off the StartTests.cs and also use the `GenerateWrappers()` method.
- From the starting state of SalesDemo data + your customization packages published - with no manual configuration - You must make all pages accessable before wrapper generation using a Customization Plug-In or testSDK code or wrapper generation will fail.
- From the starting state of SalesDemo data + your customization packages published - All setup data must be done via testSDK code or Customization Plug-in to configure the test starting state. Snapshots are not supported.

## Common Errors and Troubleshooting
- **Error Codes**:
  - `0`: Test passed successfully.
  - `2`: Test failed. Check the generated log at `C:\share\logs`.
  - `1`: Invalid/missing file or folder mapping error.
- **Site Inaccessible after Generating Wrappers**: The Wrapper Generation cmd window was closed manually and didnt reset the `web.config` back to the prognal. You must wait for the Wrapper generation to complete and self-close. To restore the website you must copy the original web.config - now named `web.config.63b98fa0` and paste the contects back into the web.config file.
