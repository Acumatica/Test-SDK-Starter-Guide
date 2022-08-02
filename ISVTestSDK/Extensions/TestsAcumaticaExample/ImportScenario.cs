using GeneratedWrappers.Acumatica;

namespace Core
{
    public class ImportScenario : SM206025_SYImportMaint
    {
        public c_mappings_form Summary
        {
            get { return Mappings_form; }
        }

        public c_fieldmappings_gridmapping Mapping
        {
            get { return FieldMappings_gridMapping; }
        }

        public c_conditions_gridconditions SourceRestrictions
        {
            get { return base.Conditions_gridConditions; }
            
        }

        public c_matchingconditions_gridconditions TargetRestrictions
        {
            get { return base.MatchingConditions_gridConditions; }
            
        }

        public c_insertfromfilter_frminsertfrom ChooseScenarioToInsertStepsFrom
        {
            get { return InsertFromFilter_frmInsertFrom; }
        }

        public c_fieldmappings_lv0 FieldMappingEditor
        {
            get { return FieldMappings_lv0; }
        }

        public c_fieldmappings_importxlsxsettings_frmimportxlsxsettings CommonSettings
        {
            get { return FieldMappings_ImportXLSXSettings_frmImportXLSXSettings; }
        }

        public ImportScenario()
        {
            QuickImport.Skip = true;
            Mapping.UploadForm.WaitAction = () => Wait.Wait.WaitForCondition(() => this.CommonSettings.Buttons.Ok.IsVisible(), Wait.Wait.MediumTimeOut * 3);
            ColumnsSettings.Buttons.Ok.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
        }

        public void DeleteSourceRestrictions()
        {
            SourceRestrictions.Adjust();

            if (SourceRestrictions.HasRows())
            {
                SourceRestrictions.SelectAllRecords();
                SourceRestrictions.Delete();

                SourceRestrictions.Refresh();
                Log.Log.Screenshot();

                Save();

                Log.Log.Screenshot();
            }
        }

        /// <summary>
        /// Columns dialog that appears after import excel file with mapping
        /// </summary>
        public c_fieldmappings_importcolumns_grdimportcolumn ColumnsSettings
        {
            get { return FieldMappings_ImportColumns_grdImportColumn; }
        }

        /// <summary>
        /// Import scenario using the command 'Import From XML'
        /// </summary>
        /// <param name="path">Path to the XML file</param>
        public void ImportFromXml(string path)
        {
            ImportXml();
            UploadXml.SelectFile(path);
            UploadXml.Upload();
        }

        public void ImportProvider(Wrapper entityWrapper)
        {
            OpenScreen();
            Summary.Name.Type(entityWrapper.ImportScenarioName);
            if (string.IsNullOrWhiteSpace(Summary.ProviderID.GetValue()) || Summary.ProviderID.HasError())
                ImportFromXml(Support.GetContentFilePath($"{entityWrapper.ScreenId}-{entityWrapper.ImportScenarioName}.xml"));
        }
    }
}
