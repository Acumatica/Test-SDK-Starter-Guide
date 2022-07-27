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
using GeneratedWrappers.Acumatica;
using System;
using Core.Attributes;
using Core.Core.Browser;
using System.Threading;
using GeneratedWrappers.ISVTestSDK;
using Core.Log;

namespace ISVTestSDK
{
    //Follow the readme.txt for instructions to get the project running successfully,
    //Or, Follow "1 - Starting a new Test SDK Project.pdf" for a step by step on how to recreate this project from nothing

    //Use the Check class as a parent for every test.
    //All test cases should not rely on previous tests running successfully, where possible.
    //
    //Test initial state should start from blank Acumatica, SalesDemo data, using TestSDK code to pre-configure the website,
    //or from a restored data snapshot from the Acumatica "Tenants" screen

    public class Test : Check
    {
        const string customizationName = "SOLUTION_FILE_NAME"; // ISV Customization project
        const string customizationURLPath = @"C:\share\Customizations\" + customizationName + ".zip";
        const string snapshotName = "SNAPSHOT_FILE_NAME"; //initial test state snapshot (salesdemo + custom config)
        const string snapshotURLPath = @"C:\share\Snapshots\" + snapshotName + ".zip";

        public ProjectList CustomizationProjects = new ProjectList();
        public CompanyMaint Companies = new CompanyMaint();

        public override void BeforeExecute()
        {
            PxLogin.LoginToDestinationSite();
            #region Allow extra wait time for customization publishing and snapshot restore to complete.

            CustomizationProjects.Details.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.CplnPanel.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.CplnPanel.CloseCompilationPane.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.Opn.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);

            Companies.cUploadSnapshotPackage.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            Companies.Snapshots.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            Companies.RestoreSnapshotSettings.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            #endregion

            //ImportCustomization();
            //PublishCustomization();
            //ImportPublishSnapshot();
        }

        public override void Execute()
        {

            Tests1 Tests1 = new Tests1();
            Tests1.Execute();

            // TestsAcumaticaExample TestsAcumaticaExample = new TestsAcumaticaExample();
            // TestsAcumaticaExample.Execute();

        }

        public void ImportCustomization()
        {
            using (TestExecution.CreateTestStepGroup("Upload/replace customization project(s)."))
            {
                Log.Information("Upload/replace customization project: ");
                CustomizationProjects.OpenScreen();
                CustomizationProjects.Details.Columns.Name.Equals(customizationName);

                if (CustomizationProjects.Details.RowsCount() == 0)
                {
                    CustomizationProjects.Details.Columns.Name.ClearFilter();
                    CustomizationProjects.ActionImport();
                }
                else
                {
                    CustomizationProjects.ActionImportReplace();
                }

                CustomizationProjects.Opn.SelectFile(customizationURLPath);
                CustomizationProjects.Opn.Upload();
                CustomizationProjects.Details.Columns.Name.Equals(customizationName);
                CustomizationProjects.Details.RowsCount().VerifyEquals(1);
                CustomizationProjects.Details.Columns.Name.ClearFilter();
                CustomizationProjects.Details.Row.Level.Type("1"); // set publishing level
                CustomizationProjects.Save();
            }

        }
        public void PublishCustomization()
        {
            using (TestExecution.CreateTestStepGroup("Publish customization projects."))
            {

                CustomizationProjects.OpenScreen();
                CustomizationProjects.Details.SetFalse();

                CustomizationProjects.Details.SelectRow(CustomizationProjects.Details.Columns.Name, customizationName);
                CustomizationProjects.Details.Row.IsWorking.SetTrue();


                CustomizationProjects.Save();
                CustomizationProjects.ActionPublish();
                CustomizationProjects.CplnPanel.Validate(true);

                CustomizationProjects.CplnPanel.Publish(true);


                try
                {
                    CustomizationProjects.CplnPanel.Close();
                }
                catch
                {
                    CustomizationProjects.CplnPanel.CloseCompilationPane.Click();
                }
                CustomizationProjects.Refresh();
            }
        }
        public void ImportPublishSnapshot()
        {
            using (TestExecution.CreateTestStepGroup("Companies screen (SM203520)"))
            {
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