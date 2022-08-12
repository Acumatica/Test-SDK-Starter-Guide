using Controls.Button;
using Controls.Dashboard;
using Controls.Editors.Selector;
using Controls.Input;
using Controls.ToolBarButton;
using Core;
using Core.Config;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using System;
using Core.Attributes;
using Core.Core.Browser;
using System.Threading;
//using GeneratedWrappers.ISVTestSDK;
using Core.Log;
using GeneratedWrappers.ISVTEST;
using Controls.CheckBox;
using System.Collections.Generic;

namespace ISVTestSDK
{
    //Follow the readme.txt for instructions to get the project running successfully,
    //Or, follow the How to Start or Upgrade a Test SDK Project to build this project yourself from a new solution


    public class Tests : Check
    {
        Dictionary<string, int> customizationName = new Dictionary<string, int>() { { "SOLUTION_FILE_NAME", 1 } }; //solution file name, publishing order
        const string customizationURLPath = @"C:\share\Customizations\";
        const string snapshotName = "SNAPSHOT_FILE_NAME"; // initial test state snapshot if needed (salesdemo + custom config)
        const string snapshotURLPath = @"C:\share\Snapshots\" + snapshotName + ".zip";

        public ProjectList CustomizationProjects = new ProjectList();
        public CompanyMaint Companies = new CompanyMaint();
        public Features Features = new Features();

        public override void BeforeExecute()
        {
            PxLogin.LoginToDestinationSite();

            //Pre config code goes here, all the setup required for your wrappers to generate and tests to run successfully should be done before the tests start.
            //The start state of the test should be SalesDemo data with your customization freshly published.

            //If you need to do configuration on a custom screen where wrappers required, you should use a sql script to insert the required data into the database.
            //Or use DynamicControl<>

            ImportCustomization(customizationName);
            PublishCustomization(customizationName);
            ImportPublishSnapshot();

            //Sql script to insert config data, allows ISV to pre-configure a screen before the wrapper exists and makes the screen accessable.
            //This is used in the case where a custom screen must be used to "enable" other custom screens. A screen that is not accessable will fail wrapper generation.
            Support.GetSite().RunSqlScript($@"INSERT [dbo].[TABLE] ([CompanyID], [ApiKey], [ApiURL]) VALUES (2, N'8fds867f68sd768f78ds8f', N'https://sandbox.testsite.com/api/v4');");
            
            using (TestExecution.CreateTestStepGroup("Configure Site for Wrapper Generation."))
            {
                Features.OpenScreen();
                Features.Insert();
                Features.Summary.DynamicControl<CheckBox>("Commerce Integration").SetTrue(); // use dynamic control to find Commerce Integration text/checkbox and enable it
                Features.RequestValidation();
            }

            GenerateNewWrappers(); // run this to regenerate Wrappers for new version of acumatica or after changeing your customization project

        }

        public override void Execute()
        {

            Tests1 Tests1 = new Tests1();
            Tests1.Execute();

            // TestsAcumaticaExample TestsAcumaticaExample = new TestsAcumaticaExample();
            // TestsAcumaticaExample.Execute();

        }

        public void GenerateNewWrappers()
        {
            ClassGenerator.ClassGenerator WG = new ClassGenerator.ClassGenerator(@"C:\AcumaticaInstallers\22.109.0023\Acumatica ERP\22r109sales", @"C:\Users\aaron.beehoo\Downloads\ISVTestSDK\ISVTestSDK\ISVTestSDK\CustomWrappers\");
            WG.Namespace = "GeneratedWrappers.ISVTEST";       // Replace ISVTEST with your solution name
            WG.Run("SM203520, SM204505, AP303000, AP301000"); // Generate wrappers for all new or modified screens, use the same namespace as above for your Extension.cs file for these wrappers
                                                              // Untouched Acumatica screen wrappers do not need to be generated, but they still will need an extension file created
                                                              // Acumatica wrappers can be accessed by "using GeneratedWrappers.Acumatica;" inside your Extension.cs file
        }


        public void ImportCustomization(Dictionary<string, int> Customizations)
        {
            CustomizationProjects.Details.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.OpenPackage.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            this.customizationName = Customizations;
            #region Step 4

            using (TestExecution.CreateTestStepGroup("Upload/replace customization projects."))
            {
                foreach (var cst in Customizations)
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

            #endregion
        }

        public void PublishCustomization(Dictionary<string, int> Customizations)
        {
            #region Step 5
            this.customizationName = Customizations;
            using (TestExecution.CreateTestStepGroup("Publish customization projects."))
            {
                CustomizationProjects.OpenScreen();
                CustomizationProjects.Details.SetFalse();

                foreach (var cst in Customizations)
                {
                    CustomizationProjects.Details.SelectRow(CustomizationProjects.Details.Columns.Name, cst.Key);
                    CustomizationProjects.Details.Row.IsWorking.SetTrue();
                }

                CustomizationProjects.Save();
                CustomizationProjects.ActionPublish();
                CustomizationProjects.CompilationPanel.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
                CustomizationProjects.CompilationPanel.CloseCompilationPane.WaitAction = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
                CustomizationProjects.CompilationPanel.Validate(true);
                CustomizationProjects.CompilationPanel.Publish(true);

                try
                {
                    CustomizationProjects.CompilationPanel.Close();
                }
                catch
                {
                    CustomizationProjects.CompilationPanel.CloseCompilationPane.Click();
                }

                CustomizationProjects.Refresh();
            }

            #endregion
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
                ImportCustomization(customizationName); //republish the customization
                PublishCustomization(customizationName); //republish the customization
            }
        }

    }
}