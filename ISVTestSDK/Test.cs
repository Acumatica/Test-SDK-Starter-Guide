using Controls.CheckBox;
using Core;
using Core.Config;
using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using GeneratedWrappers.Acumatica;
using GeneratedWrappers.ISVNAME;
using PX.QA.Tools;
using System;
using System.Collections.Generic;
using System.IO;

namespace ISVTestSDK
{
    public class Test : Check
    {
        const string physicalSitePath = @"C:\AcumaticaSites\22r202";
        Dictionary<string, int> customizationName = new Dictionary<string, int>() { { "SOLUTIONNAME1[22.200.0145][22r2r11b1]", 1 }, { "SOLUTIONNAME2[22.200.0145][22r2r11b1]", 2 } }; //solution file name(s), in publishing order
        const string customizationURLPath = @"C:\share\Customizations\";
        //const string snapshotName = "ISVSnapshot22r202"; // Not recomended to use snapshots because they are version specific, use below pre config code instead..
        //const string snapshotURLPath = @"C:\share\Snapshots\" + snapshotName + ".zip";

        public const string ValidationSuccessfully = "Validation finished successfully.";
        public const string PublishSuccessfully = "Website updated.";

        //import all screen you will be using here
        //How to Create Extension Files.docx is a very useful guide to create these extensions.
        public SM204505ProjectList CustomizationProjects = new SM204505ProjectList();
        public CS100000FeaturesMaint features = new CS100000FeaturesMaint();
        public GL102000GLSetupMaint setupGl = new GL102000GLSetupMaint();
        public SM203520CompanyMaint Companies = new SM203520CompanyMaint();
        public CA306000CABankTransactions CABankTransactionsMaint = new CA306000CABankTransactions();

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
            //ImportPublishSnapshot(); // not recomended to use snapshots because they are version specific, use below pre config instead..

            using (TestExecution.CreateTestStepGroup("Configure Site for Wrapper Generation."))
            {
                /*
                Before wrapper generation, all screns must be accessable with no manual pre-configuration
                There are a few ways to set up your site before Wrapper generation using automated code.
                1) For existing unmodified acumatica screens:   Using GeneratedWrappers.Acumatica wrappers
                2) For modified acumatica screens:              Using DynamicControl to interact with the new fields before a updated wrapper exists.
                3) For New Custom screens:                      Using Customization Plug-in to configure the data
                                                                https://www.acumatica.com/blog/customization-plugin-packages-configuration/
                                                                https://riptutorial.com/acumatica/example/29435/implementation-of-a-customization-plug-in-to-update-multiple-companies

                 */

                // 1) Use GeneratedWrappers.Acumatica to enter data for UNMODIFIED Acumatica screens
                features.OpenScreen();
                features.Insert();
                features.Summary.SalesQuotes.SetTrue();
                features.Summary.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue(); //enable customization added feature (not found in default wrapper)
                features.RequestValidation();

                // 2) Using DynamicControl to interact with customization added fields before a updated wrapper exists
                setupGl.OpenScreen();
                setupGl.general.DynamicControl<CheckBox>("Generate Consolidated Batches").SetTrue(); //the text is the fields label text
                setupGl.Save();
            }
            //GenerateWrappers();
        }

        public override void Execute()
        {
            Test1 Test1 = new Test1();
            Test1.Execute();
        }

        public override void AfterExecute()
        {
        }
        public void GenerateWrappers()
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string wrapperPath = String.Format(projectPath + @"\Wrappers\");

            ClassGenerator.ClassGenerator WG = new ClassGenerator.ClassGenerator(physicalSitePath, wrapperPath);
            WG.Username = "admin@Company2";
            WG.Namespace = "GeneratedWrappers.ISVNAME";
            WG.Run("SCREENID1, SCREENID2"); // add your customized screens here
            // Replace ISVTEST with your solution name
            // Generate wrappers for all new or modified screens
            // Untouched Acumatica screens do not need wrappers to be generated - Use using GeneratedWrappers.Acumatica;
            // All wrappers will need an extension file created to access the elements of the screens wrapper.
            // The namespace of your Extension.cs files will be "using GeneratedWrappers.Acumatica;" or "using GeneratedWrappers.ISVTEST;"
        }
        public void ImportCustomization()
        {
            CustomizationProjects.Details.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.OpenPackage.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);

            using (TestExecution.CreateTestStepGroup("Upload/replace customization projects."))
            {
                foreach (var cst in customizationName)
                {
                    Log.Information("Upload/replace customization project: ");

                    CustomizationProjects.OpenScreen();
                    CustomizationProjects.Details.Columns.Name.Equals(cst.Key);

                    if (CustomizationProjects.Details.RowsCount() == 0)
                    {
                        CustomizationProjects.Details.Columns.Name.ClearFilter();
                        CustomizationProjects.ActionImport();
                    }
                    else
                    {
                        CustomizationProjects.ActionImportReplace();
                    }

                    CustomizationProjects.OpenPackage.SelectFile(customizationURLPath + cst.Key + ".zip");
                    CustomizationProjects.OpenPackage.Upload();
                    CustomizationProjects.Details.Columns.Name.Equals(cst.Key);
                    CustomizationProjects.Details.RowsCount().VerifyEquals(1);
                    CustomizationProjects.Details.Columns.Name.ClearFilter();
                    CustomizationProjects.Details.Row.Level.Type(cst.Value);
                    CustomizationProjects.Save();
                }
            }
        }
        public void PublishCustomization()
        {

            using (TestExecution.CreateTestStepGroup("Publish customization projects."))
            {
                CustomizationProjects.OpenScreen();
                CustomizationProjects.Details.SetFalse();

                foreach (var cst in customizationName)
                {
                    CustomizationProjects.Details.SelectRow(CustomizationProjects.Details.Columns.Name, cst.Key);
                    CustomizationProjects.Details.Row.IsWorking.SetTrue();
                }

                CustomizationProjects.Save();
                CustomizationProjects.ActionPublishExt();
                CustomizationProjects.PublishToMultipleCompanies.Ok();

                using (new Wait(Wait.LongTimeOut * 2))
                {
                    CustomizationProjects.CompilationPanel.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
                    CustomizationProjects.CompilationPanel.Validate(true, ValidationSuccessfully);
                    CustomizationProjects.CompilationPanel.Buttons.Publish.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 10);
                    CustomizationProjects.CompilationPanel.Publish(true, PublishSuccessfully);
                    CustomizationProjects.CompilationPanel.Close();
                }
            }
        }
        //public void ImportPublishSnapshot()
        //{
        //    using (TestExecution.CreateTestStepGroup("Companies screen (SM203520)"))
        //    {
        //        Companies.cUploadSnapshotPackage.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
        //        Companies.Snapshots.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);

        //        Companies.OpenScreen(true);
        //        Companies.Snapshots.UploadSnapshotCommand();
        //        Companies.cUploadSnapshotPackage.SelectFile(snapshotURLPath);
        //        Companies.cUploadSnapshotPackage.IncludeDataFromCustomColumns.SetFalse();
        //        Companies.cUploadSnapshotPackage.IncludeDataFromCustomColumns.SetTrue();
        //        Companies.cUploadSnapshotPackage.Upload();
        //        Companies.ImportSnapshotCommand();

        //        PxLogin.LoginToDestinationSite(); //login after snapshot restore then republish the newest customization project next.
        //        ImportCustomization(); //republish the customization
        //        PublishCustomization(); //republish the customization
        //    }
        //}
    }


}
