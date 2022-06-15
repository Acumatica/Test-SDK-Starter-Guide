using System;
using Controls.Input;
using Controls.SmartPanel;
using Controls.Uploader;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public class ImportByScenario : SM206036_SYImportProcessSingle
    {
        public c_mappingssingle_form Summary => base.MappingsSingle_form;
        public c_mappingssingledetails_detailsform Details => base.MappingsSingleDetails_DetailsForm;
        public c_mappingssimple_mapping Mapping => base.MappingsSimple_mapping;
        public c_prepareddata_gridprepareddata PreparedData => base.PreparedData_gridPreparedData;
        public c_history_grhistory History => base.History_grHistory;
        public c_operation_operationform ErrorProcessing => base.Operation_OperationForm;
        public c_newscenarioproperties_frmnewscenariocreation ProvideNewScenarioProperties => base.NewScenarioProperties_frmNewScenarioCreation;
        public new c_screen_upload SelectFileForImport => base.SelectFileForImport;
        public c_substitutioninfo_gridsubstitutioninfo Substitution => base.SubstitutionInfo_GridSubstitutionInfo;

        public c_replacementproperties_formreplacementproperties Replace => base.ReplacementProperties_FormReplacementProperties;

        public ImportByScenario()
        {
            ToolBar.Rollback.WaitAction = MessageBox.Yes;
            ToolBar.PrepareImport.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            ToolBar.Prepare.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            ToolBar.Import.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            ToolBar.GetLatestFile.WaitAction = Wait.Wait.WaitForFileDownloadComplete;

            SelectFileForImport.Buttons.Upload.WaitAction = () =>
            {
                Wait.Wait.WaitForCondition(() => !SelectFileForImport.Buttons.Upload.IsVisible(), Wait.Wait.LongTimeOut);
                Wait.Wait.WaitForCallbackToComplete();
                Wait.Wait.WaitForCondition(() => ProvideNewScenarioProperties.ScreenID.IsVisible(), Wait.Wait.MediumTimeOut);
            };

            ToolBar.Save.WaitAction = () =>
            {
                if (MessageBox.Buttons.No.IsVisible()) MessageBox.No();
                Wait.Wait.WaitForPageToLoad();
            };
        }

        public void Prepare(TimeSpan timeOut)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Prepare import"))
            {
                using (new Wait.Wait((int)timeOut.TotalMilliseconds))
                {
                    base.Prepare();
                }

                Log.Log.Screenshot();
            }
        }

        public void Import(TimeSpan timeOut)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Run import"))
            {
                using (new Wait.Wait((int)timeOut.TotalMilliseconds))
                {
                    base.Import();
                }

                Log.Log.Screenshot();
            }
        }

        public void ImportWithExpectedErrors(TimeSpan timeOut, string message = null)
        {
            ToolBar.Import.WaitActionOverride = () => Wait.Wait.WaitForLongOperationToComplete(false, message);
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Run import"))
            {
                using (new Wait.Wait((int)timeOut.TotalMilliseconds))
                {
                    base.Import();
                }

                Log.Log.Screenshot();
            }
        }

        public void PrepareWithExpectedErrors(TimeSpan timeOut, string message = null)
        {
            ToolBar.Prepare.WaitActionOverride = () => Wait.Wait.WaitForLongOperationToComplete(false, message);
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Prepare"))
            {
                using (new Wait.Wait((int)timeOut.TotalMilliseconds))
                {
                    base.Prepare();
                }

                Log.Log.Screenshot();
            }
        }

        public void PrepareImport(TimeSpan timeOut)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Prepare and run import"))
            {
                using (new Wait.Wait((int)timeOut.TotalMilliseconds))
                {
                    base.PrepareImport();
                }

                Log.Log.Screenshot();
            }
        }

        public void UploadFileVersion(string file, string comment = null)
        {
            ShowUploadPanel();
            UploadNewRevision.SelectFile(file);
            if (!string.IsNullOrEmpty(comment))
                UploadNewRevision.Comment.Type(comment);
            UploadNewRevision.Upload();
        }

        /// <summary>
        /// Import data from file using import scenrio specified in specified wrapper
        /// </summary>
        /// <param name="entityWrapper">Wrapper object. ImportScenarioName and ConfigureImportScenario will be used.</param>
        /// <param name="fileName">Content file name to search and upload  </param>
        /// <param name="recordsCountToExpect">number of records to expect (lines count in a file)</param>
        public void ImportEntities(Wrapper entityWrapper, string fileName, int recordsCountToExpect)
        {
            new ImportScenario().ImportProvider(entityWrapper);

            entityWrapper.ConfigureImportScenario();

            OpenScreen();
            Summary.Name.Select(entityWrapper.ImportScenarioName);
            UploadFileVersion(@"C:\Users\aaron.beehoo\Downloads\ISVTestSDK\ISVTestSDK\ISVTestSDK\Configuration\Data\" + fileName);
            PrepareImport();
            PreparedData.AllPagesRowsCount().VerifyEquals(recordsCountToExpect);
            Summary.NbrRecords.GetValue().VerifyEquals(recordsCountToExpect);
        }

        public void ClearProccesCheckBox()
        {
            PreparedData.Columns.IsProcessed.Equals(true);
            int rowsCount = PreparedData.RowsCount();
            for (int i = 1; i <= rowsCount; i++)
            {
                PreparedData.SelectRow(i);
                PreparedData.Row.IsProcessed.SetFalse();
            }
            PreparedData.Columns.IsProcessed.ClearFilter();
        }
    }
}
