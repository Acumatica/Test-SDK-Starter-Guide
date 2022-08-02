using System;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class GenericInquiry : SM208000_GenericInquiryDesigner
    {
        public c_recorddefaults_grdrecorddefaults RecordDefaults => base.RecordDefaults_grdRecordDefaults;

        public c_massactions_grdmassactions MassActions => base.MassActions_grdMassActions;

        public c_massupdatefields_grdmassupdfields MassUpdateFields => base.MassUpdateFields_grdMassUpdFields;

        public c_currentdesign_tab EntryPoint => base.CurrentDesign_tab;

        public c_navigationparameters_grdnavparams NavigationParameters => base.NavigationParameters_grdNavParams;

        public c_navigationscreens_grdnavscreens NavigationScreens => base.NavigationScreens_grdNavScreens;
        public c_navigationconditions_grdnavigationconditions VisibilityConditions => NavigationConditions_grdNavigationConditions;

        public c_navigationscreens_frmnavwindowmode WindowForm => base.NavigationScreens_frmNavWindowMode;

        public c_recorddefaults_grdrecorddefaults NewRecordDefaults => base.RecordDefaults_grdRecordDefaults;

        public c_designs_form Summary => base.Designs_form;

        public c_tables_grdtables Tables => Tables_grdTables;

        public c_relations_grdjoins TableRelations => base.Relations_grdJoins;

        public c_joinconditions_grdons FieldRelations => base.JoinConditions_grdOns;

        public c_parameters_grdfilter GenericInquiryParameters => base.Parameters_grdFilter;

        public c_wheres_grdwheres Conditions => base.Wheres_grdWheres;

        public c_groupby_grdgroupby Grouping => base.GroupBy_grdGroupBy;

        public c_sortings_grdsorts SortOrder => base.Sortings_grdSorts;

        public c_results_grdresults ResultsGrid => base.Results_grdResults;

        public c_valueslabels_gridcombos ComboBoxValues => base.ValuesLabels_gridCombos;

        public c_currentdesign_frmrowstyle RowStyle => base.CurrentDesign_frmRowStyle;

        protected new c_parameters Parameters => base.Parameters;

        public c_changescreeniddialog_formchangescreenid SpecifyNewScreenID => ChangeScreenIDDialog_formChangeScreenID;

        public c_relatedtables_formrelations RelatedTables => RelatedTables_formRelations;

        public c_tablesinformation_gridtables RelatedTablesDetails => TablesInformation_gridTables;

        public c_changeiddialog_formchangeid ChangeInquiryTitle => ChangeIDDialog_formChangeID;

        public GenericInquiry()
        {
            FileName = "Generic Inquiries";
            ToolBar.ViewInquiry.WaitAction = Wait.Wait.WaitForNewWindowToOpen;

            QuickImport.ExcludeFields = new[]
            {
                "InquirySummary->ScreenID",
                "ResultsGrid->DataField"
            };

            QuickImport.SkipContainers = new[]
            {
                "RelatedTables",
                "RelatedTablesName"
            };

            QuickImport.LastRecord = LastRecordMethod.LastModified;
            QuickImport.Key = new[] { "BI-Dates" };

            Tables.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            TableRelations.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            GenericInquiryParameters.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Conditions.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Grouping.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            SortOrder.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            ResultsGrid.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            ToolBar.ChangeScreenID.WaitAction = Wait.Wait.WaitForPageToLoad;
            SpecifyNewScreenID.Buttons.Ok.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            RelatedTablesDetails.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            FieldRelations.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
        }

        public void ImportGIFromXml(String path)
        {
            ImportXml();
            UploadXml.SelectFile(path);
            UploadXml.Upload();
        }
    }
}
