using Controls.CheckBox;
using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using GeneratedWrappers.Acumatica;
using GeneratedWrappers.ISVSOLUTIONNAME;
using System;
using System.Collections.Generic;
using System.IO;

namespace ISVTestSDK
{
    public class Test : Check
    {
        // Update the below links to your envrionment
        const string physicalSitePath = @"C:\AcumaticaSites\22r202";
        Dictionary<string, int> customizationName = new Dictionary<string, int>() { { "SOLUTIONNAME1[22.200.0145][22r2r11b1]", 1 }, { "SOLUTIONNAME2[22.200.0145][22r2r11b1]", 2 } }; //solution file name(s), in publishing order
        const string customizationURLPath = @"C:\share\Customizations\";

        public const string ValidationSuccessfully = "Validation finished successfully.";
        public const string PublishSuccessfully = "Website updated.";

        // Import all screens you will be using here
        // How to Create Extension Files.docx is a very useful guide to create these extensions.
        public SM204505ProjectList CustomizationProjects = new SM204505ProjectList();
        public CS100000FeaturesMaint Features = new CS100000FeaturesMaint();
        public GL102000GLSetupMaint SetupGl = new GL102000GLSetupMaint();
        public CA306000CABankTransactions CABankTransactionsMaint = new CA306000CABankTransactions();

        public void GenerateWrappers()
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string wrapperPath = String.Format(projectPath + @"\Wrappers\");

            ClassGenerator.ClassGenerator WG = new ClassGenerator.ClassGenerator(physicalSitePath, wrapperPath);
            WG.Username = "admin@Company2";
            WG.Namespace = "GeneratedWrappers.ISVSOLUTIONNAME"; // Replace ISVSOLUTIONNAME with your solution name

            // PL and GI screens are added like this, get the "URL" from the site map screen.
            WG.Screens.Add("IN2025PL", "~/GenericInquiry/GenericInquiry.aspx?id=e4352bbd-a53a-42c4-9b96-e9f0fda070c7");

            WG.Run("SCREENID1, SCREENID2, CA306000, CS100000, GL102000, SM204505, SO301000"); // add all screens here you need to use in your test

            // All wrappers will need an extension file created to access the UI elements of the screen wrapper.
            // The namespace of your Extension.cs files will be "using GeneratedWrappers.ISVSOLUTIONNAME;"
        }
        public override void BeforeExecute()
        {
            //Update the TestSDK folder config.xml and ClassGenerator/classgenerator.exe.config
            //update the Properties->Launchsettings.json to your testSDK folder location

            //If first run on a new minor or major verson, update the packages in Dependencies->Packages to the desired version:
            //Right click on the project and select "Manage NuGet Packages"
            //Add a new source named as the version number (eg 22r101) that links to the testSDK download folder-> packages folder
            //Once added as a source, switch to the added source and add all the packages there. to the project.
            //GeneratedWrappers.Acumatica package in the packages folder sometimes needs to be renamed to  include the build and P###### seen in the nuget manager GeneratedWrappers.Acumatica.21.213.33-P147318 before it can be added successfully.

            PxLogin.LoginToDestinationSite();
            //ImportCustomization();
            //PublishCustomization();

            using (TestExecution.CreateTestStepGroup("Configure Site for Wrapper Generation."))
            {
                /*
                Before wrapper generation, all modified screens must be accessable with no manual pre-configuration
                Automate the configuration via code below to pre config the site.

                There are a few ways to set up your site before Wrapper Generation using automated code.
                1) For existing unmodified acumatica screens:   Using GeneratedWrappers.Acumatica wrappers
                2) For modified acumatica screens:              Using DynamicControl to interact with the new fields before a updated wrapper exists.
                3) For New Custom screens:                      Using Customization Plug-in to configure the data
                                                                https://github.com/Acumatica/Test-SDK-Starter-Guide/blob/master/ISVTestSDK/Customization%20PlugIn%20Guide.docx
                                                                https://riptutorial.com/acumatica/example/29435/implementation-of-a-customization-plug-in-to-update-multiple-companies
                                                                https://www.acumatica.com/blog/customization-plugin-packages-configuration/
                 */

                // 1) Use GeneratedWrappers.Acumatica to enter data for UNMODIFIED Acumatica screens
                Features.OpenScreen();
                Features.Insert();
                Features.Summary.SalesQuotes.SetTrue();
                // Use Dynamic Control to enable a customization added Feature not found in the default wrapper
                Features.Summary.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
                Features.RequestValidation();

                // 2) Using DynamicControl to interact with customization added fields before a updated wrapper exists
                SetupGl.OpenScreen();
                SetupGl.general.DynamicControl<CheckBox>("Generate Consolidated Batches").SetTrue(); //the text is the fields label text
                SetupGl.Save();
            }
            //GenerateWrappers(); // Only needs to be run once after updating the project version or customization project.
            // It takes 5-15 minutes to run, do not close it manually or else you will need to fix your web.config
        }

        public override void Execute()
        {
            Test1 Test1 = new Test1();
            Test1.Execute();
        }

        public override void AfterExecute()
        {
        }
        public void ImportCustomization()
        {
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