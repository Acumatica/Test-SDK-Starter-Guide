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
        const string physicalSitePath = @"C:\AcumaticaSites\23r106";
        Dictionary<string, int> customizationName = new Dictionary<string, int>() { { "SOLUTIONNAME1[22.200.0145][22r2r11b1]", 1 }, { "SOLUTIONNAME2[22.200.0145][22r2r11b1]", 2 } }; //solution file name(s), in publishing order
        const string customizationURLPath = @"C:\share\Customizations\";

        public const string ValidationSuccessfully = "Validation finished successfully.";
        public const string PublishSuccessfully = "Website updated.";

        // Import all screens you will be using here
        // How to Create Extension Files.docx is a very useful guide to create these extensions.
        public SM204505ProjectList CustomizationProjects = new SM204505ProjectList();
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
            // The namespace of your Extension.cs files will be "using GeneratedWrappers.SOLUTIONNAME;"
        }
        public override void BeforeExecute()
        {
            //Ensure you have updated the TestSDK folder config.xml to point to your website
            //Update the Properties->Launchsettings.json to your testSDK folder location to your site as well

            //If it is the first run on a new verson, update the solution Dependencies->Packages to the desired version packages folder from the TestSDK download:
            //Right click on the project and select "Manage NuGet Packages"
            //Add a new source named as the version number (eg 22r101) that links to the testSDK download folder-> packages folder
            //Once added as a source, switch to the added source and add all the packages there. to the project.

            PxLogin.LoginToDestinationSite();
            using (TestExecution.CreateTestStepGroup("Configure Site for Wrapper Generation."))
            {
                /*
                 * PRECONFIG:
                 * 
                
                //ImportCustomization();
                //PublishCustomization();

                Before wrapper generation, all modified screens must be accessable with no manual pre-configuration
                Automate the configuration via code below to pre config the site.

                There are a few ways to set up your site before Wrapper Generation using automated code.
                1) For existing unmodified acumatica screens:   Use GeneratedWrappers.Acumatica wrappers
                2) For modified acumatica screens:              Use DynamicControl to interact with the new fields before a updated wrapper exists.
                3) For New Custom screens:                      Use Customization Plug-in to configure the data
                                                                https://github.com/Acumatica/Test-SDK-Starter-Guide/blob/master/ISVTestSDK/Customization%20PlugIn%20Guide.docx
                                                                https://riptutorial.com/acumatica/example/29435/implementation-of-a-customization-plug-in-to-update-multiple-companies
                                                                https://www.acumatica.com/blog/customization-plugin-packages-configuration/
                 

                
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
        public void ImportCustomization()
        {
            //It's easier to publish the customization on the test site manually.
            CustomizationProjects.Details.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.OpenPackage.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);

            using (TestExecution.CreateTestStepGroup("Upload customization projects."))
            {
                foreach (var cst in customizationName)
                {
                    Log.Information("Uploading customization project: " + cst.Key);
                    CustomizationProjects.OpenScreen();
                    CustomizationProjects.ActionImport();
                    CustomizationProjects.OpenPackage.SelectFile(customizationURLPath + cst.Key + ".zip");
                    CustomizationProjects.OpenPackage.Upload();
                    CustomizationProjects.Details.SelectRow(CustomizationProjects.Details.Columns.Name, cst.Key);
                    CustomizationProjects.Details.Row.Level.Type(cst.Value);
                    CustomizationProjects.Details.Row.IsWorking.SetTrue();
                    CustomizationProjects.Save();
                }
            }
        }
        public void PublishCustomization()
        {
            //It's easier to publish the customization on the test site manually.
            CustomizationProjects.CompilationPanel.WaitAction = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.ToolBar.ActionPublish.WaitAction = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);
            using (TestExecution.CreateTestStepGroup("Publish customization projects."))
            {
                CustomizationProjects.OpenScreen();
                CustomizationProjects.ActionPublish();
                CustomizationProjects.CompilationPanel.Validate(true, ValidationSuccessfully);
                CustomizationProjects.CompilationPanel.Publish(true, PublishSuccessfully);
                CustomizationProjects.RefreshScreen(true);
            }
        }
    }
}