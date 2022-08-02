using Api;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class TaxZone : TX206000_TaxZoneMaint
    {
        public c_txzone_form Summary => base.TxZone_form;

        public c_details_grid Details => base.Details_grid;
        public c_zip_gridzip ZipCodes => base.Zip_gridZip;

        public c_zip_gridzip Zip => base.Zip_gridZip;

        public TaxZone()
        {
            FileName = "Tax Zones";
            QuickImport.DisabledLines = new[] { "TaxZone->ManualVATEntry" };
        }
        private static bool IsAvalaraActive()
        {
            try
            {
                return ApiFactory.Get<TaxProviders>(ApiConnection.ApiConnection.Destination).ReadOne("AVALARA").Summary.IsActive.Value;
            }
            catch
            {
                return false;
            }
        }

        public override void ConfigureImportScenario()
        {
            const string TaxAgencyFileField = "TaxZone->TaxAgencyID";

            ImportScenario ImportScenario = new ImportScenario();
            ImportScenario.OpenScreen();
            ImportScenario.Summary.Name.Select(ImportScenarioName);

            if (IsAvalaraActive())
            {
                ImportScenario.SourceRestrictions.RemoveAllRows();
                ImportScenario.Mapping.SelectRow(ImportScenario.Mapping.Columns.Value, TaxAgencyFileField);
                ImportScenario.Mapping.RowInsert();
                ImportScenario.Mapping.SelectRow(ImportScenario.Mapping.Columns.FieldName, string.Empty);
                ImportScenario.Mapping.Row.FieldName.Select("Provider ID");
                ImportScenario.Mapping.Row.Value.Select(TaxAgencyFileField);
            }
            else
            {
                ImportScenario.SourceRestrictions.New();
                ImportScenario.SourceRestrictions.Row.FieldName.Select(TaxAgencyFileField);
                ImportScenario.SourceRestrictions.Row.Condition.Select("Does Not Equal");
                ImportScenario.SourceRestrictions.Row.Value.Type("AVALARA");
            }

            ImportScenario.Save();
        }
    }
}
