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
using ISVTestSDK.Extensions;
using Core.Log;

namespace ISVTestSDK
{
    //Use the Check class as a parent for every test.
    //All test cases should not rely on previous tests running successfully, where possible.
    //Test initial state should start from SalesDemo data, or from a restored snapshot from the acumatica tenants screen

    public class Test : Check
    {
        const string customizationName = "SOLUTION-FILE-NAME";
        const string customizationURLPath = @"C:\TestSDKFiles\Customizations\" + customizationName + ".zip";
        const string snapshotName = "SNAPSHOT-FILE-NAME";
        const string snapshotURLPath = @"C:\share\Snapshots\" + snapshotName + ".zip";

        public ProjectList CustomizationProjects = new ProjectList();
        public CompanyMaint Companies = new CompanyMaint();


        public override void BeforeExecute() // run BeforeExecute if you have customization projects and/or a snapshot to restore
        {
            PxLogin.LoginToDestinationSite();

            #region Extend wait operations to allow customization publishing and snapshot restore time to complete.
            CustomizationProjects.Details.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.CplnPanel.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.CplnPanel.CloseCompilationPane.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.Opn.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.CplnPanel.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 2);

            Companies.cUploadSnapshotPackage.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            Companies.Snapshots.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);
            Companies.RestoreSnapshotSettings.WaitActionOverride = () => Wait.WaitForCallbackToComplete(Wait.LongTimeOut * 4);

            CustomizationProjects.Details.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.CplnPanel.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.CplnPanel.CloseCompilationPane.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);
            CustomizationProjects.Opn.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);

            Companies.cUploadSnapshotPackage.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);
            Companies.Snapshots.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);
            Companies.RestoreSnapshotSettings.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 4);
            #endregion

            #region Import and publish customization to the website
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
            #endregion

            #region Import and publish site snapshot backup from "tenants" screen, then republish customization project.
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
            }
            using (TestExecution.CreateTestStepGroup("Upload/replace customization project(s)."))
            {

                // Log.Information("Upload/replace customization project: ");
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
            #endregion
        }

        public override void Execute()
        {
            PxLogin.LoginToDestinationSite();
            Tests1 Tests1 = new Tests1();
            Tests1.Execute();

            // Tests2 Tests2 = new Tests2();
            // Tests2.Execute();



        }

    }
}