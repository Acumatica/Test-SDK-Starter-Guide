using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using GeneratedWrappers.Acumatica;
using GeneratedWrappers.ISVNAME;
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
        const string snapshotName = "ISVSnapshot22r202"; //  initial test state snapshot if needed (salesdemo + custom config) - Not recomended to use snapshots because they are version specific, use below pre config instead..
        const string snapshotURLPath = @"C:\share\Snapshots\" + snapshotName + ".zip";

        public const string ValidationSuccessfully = "Validation finished successfully.";
        public const string PublishSuccessfully = "Website updated.";

        //add all screen you will be using here
        public SM204505ProjectList CustomizationProjects = new SM204505ProjectList();
        public SM203520CompanyMaint Companies = new SM203520CompanyMaint();
        public CA306000CABankTransactions CABankTransactionsMaint = new CA306000CABankTransactions();

        public override void BeforeExecute()
        {
            //Update the TestSDK folder config.xml and ClassGenerator/classgenerator.exe.config
            //update the Properties->Launchsettings.json to your testSDK folder location

            //If first run on a new minor or major verson, delete the packages in Dependencies->Packages
            //Right click on the project and select "Manage NuGet Packages"
            //Add a new source named as the version number (eg 22r101) that links to the testSDK download folder-> packages folder
            //Once added as a source, switch to the added source and add all the packages there. to the project.
            //GeneratedWrappers.Acumatica package in the packages folder needs to be renamed to GeneratedWrappers.Acumatica.21.213.33-P147318 before it can be added successfully.

            PxLogin.LoginToDestinationSite();
            //ImportCustomization();
            //PublishCustomization();
            //ImportPublishSnapshot(); // not recomended to use snapshots because they are version specific, use below pre config instead..

            //Pre wrapper generation setup - to allow all wrappers to generate successfully based off salesdemo base data

            //use SQL to enter data on customizaed screens
            Support.GetSite().RunSqlScript($@"INSERT [dbo].[TABLE] ([CompanyID], [ApiKey], [ApiURL]) VALUES (2, N'8fds86256hh7j8f78ds8f', N'https://sandbox.testsite.com/api/v4');");
            
            //Use GeneratedWrappers.Acumatica to enter data for unmodified screens
            Features Features = new Features();
            Features.OpenScreen();
            Features.Insert();
            Features.Summary.SalesQuotes.SetTrue();
            Features.Summary.ProjectQuotes.SetTrue();
            Features.Summary.Multicurrency.SetTrue();
            Features.RequestValidation();

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
            // Untouched Acumatica screens do not need wrappers to be generated
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
        public void ImportPublishSnapshot()
        {
            using (TestExecution.CreateTestStepGroup("Companies screen (SM203520)"))
            {
                Companies.cUploadSnapshotPackage.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
                Companies.Snapshots.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);

                Companies.OpenScreen(true);
                Companies.Snapshots.UploadSnapshotCommand();
                Companies.cUploadSnapshotPackage.SelectFile(snapshotURLPath);
                Companies.cUploadSnapshotPackage.IncludeDataFromCustomColumns.SetFalse();
                Companies.cUploadSnapshotPackage.IncludeDataFromCustomColumns.SetTrue();
                Companies.cUploadSnapshotPackage.Upload();
                Companies.ImportSnapshotCommand();

                PxLogin.LoginToDestinationSite(); //login after snapshot restore then republish the newest customization project next.
                ImportCustomization(); //republish the customization
                PublishCustomization(); //republish the customization
            }
        }
    }


}
