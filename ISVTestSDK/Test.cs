using Controls.CheckBox;
using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using GeneratedWrappers.Acumatica;
using GeneratedWrappers.SOLUTIONNAME;
using System;
using System.Collections.Generic;
using System.IO;

namespace ISVTestSDK
{
    public class Test : Check
    {
        // Update the below links to your envrionment
        const string physicalSitePath = @"C:\AcumaticaSites\23r2001";

        // Import all screens you will be using here
        // How to Create Extension Files.docx is a very useful guide to create these extensions.
        public CS100000FeaturesMaint Features = new CS100000FeaturesMaint();

        public void GenerateWrappers()
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string wrapperPath = String.Format(projectPath + @"\Wrappers\");

            ClassGenerator.ClassGenerator WG = new ClassGenerator.ClassGenerator(physicalSitePath, wrapperPath);
            WG.Username = "admin";
            WG.Namespace = "GeneratedWrappers.SOLUTIONNAME"; // Replace SOLUTIONNAME with your solution name

            // PL and GI screens are added like this, get the "URL" from the site map screen.
            WG.Screens.Add("IN2025PL", "~/GenericInquiry/GenericInquiry.aspx?id=e4352bbd-a53a-42c4-9b96-e9f0fda070c7");

            WG.Run("SCREENID1, SCREENID2, CA306000, CS100000, GL102000, SM204505, SO301000"); // add all screens here you need to use in your test

            // All wrappers will need an extension file created to access the UI elements of the screen wrapper.
            // The namespace of your Extension.cs files will be exactly "using GeneratedWrappers.SOLUTIONNAME;"
        }
        public override void BeforeExecute()
        {
            //Ensure you have updated the TestSDK folder config.xml to point to your website
            //Update the Properties->Launchsettings.json to your testSDK folder location to your site as well

            //If it is the first run on a new verson, update the solution Dependencies->Packages to the desired version packages folder from the TestSDK download:
            //Right click on the project and select "Manage NuGet Packages"
            //Add a new source named as the version number (eg 23r101) that links to the testSDK download folder-> packages folder
            //Once added as a source, Browse the added source and add all the nuget packages inside to the project.

            PxLogin.LoginToDestinationSite();
            using (TestExecution.CreateTestStepGroup("Configure Site for Wrapper Generation."))
            {
                /*
                 * PRECONFIG:
                 * 
                
                You must publish your customization(s) before running and also config 
                the site to make all screen accessable at minimum before wrapper generation.
                
                All Pre config steps after publishing the customization on a salesdemo data instance 
                must be done via test code no manual website pre-configuration is allowed. See how to do 
                so below.

                Automate the configuration via code below to pre config the site:

                There are a few ways to set up your site before Wrapper Generation using automated code.
                1) For existing unmodified acumatica screens:   Use GeneratedWrappers.Acumatica wrappers and make the extension file
                2) For modified acumatica screens:              Use DynamicControl to interact with the new fields before a updated wrapper exists.
                3) For New Custom screens:                      Use Customization Plug-in code to configure the data during customization publishing
                                                                
                 

                
                 1) Use GeneratedWrappers.Acumatica to enter data for UNMODIFIED Acumatica screens

                Features.OpenScreen();
                Features.Insert();
                Features.Summary.SalesQuotes.SetTrue();
                Features.Summary.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
                Features.RequestValidation();

                 2) Using DynamicControl to interact with customization added fields before a updated wrapper exists
                The text is the fields label text.

                SetupGl.OpenScreen();
                SetupGl.general.DynamicControl<CheckBox>("Generate Consolidated Batches").SetTrue();
                SetupGl.Save();

                3) 
                https://github.com/Acumatica/Test-SDK-Starter-Guide/blob/master/ISVTestSDK/Customization%20PlugIn%20Guide.docx
                https://riptutorial.com/acumatica/example/29435/implementation-of-a-customization-plug-in-to-update-multiple-companies
                https://www.acumatica.com/blog/customization-plugin-packages-configuration/
                */
            }
        }

        public override void Execute()
        {
            GenerateWrappers(); // Only needs to be run once after updating the project version or customization project.
                                // It takes 5-15 minutes to run, do not close it manually or else you will need to fix your web.config
            Test1 Test1 = new Test1();
            Test1.Execute();
        }

        public override void AfterExecute()
        {
        }
        
    }
}