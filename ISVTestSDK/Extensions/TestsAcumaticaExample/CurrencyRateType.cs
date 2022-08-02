using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class CurrencyRateType : CM201000_CurrencyRateTypeMaint
    {
        public c_curyratetyperecords_grid Details => base.CuryRateTypeRecords_grid;
        public c_curyratetyperecords_importcolumns_grdimportcolumn Columns => base.CuryRateTypeRecords_ImportColumns_grdImportColumn;

        public c_curyratetyperecords_importcsvsettings_frmimportcsvsettings CsvImportSettings => base.CuryRateTypeRecords_ImportCSVSettings_frmImportCSVSettings;

        public CurrencyRateType()
        {
            FileName = "Currency Rate Types";
        }
    }
}