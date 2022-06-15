using System;
using Controls.Editors.TreeSelector;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class CurrencyRate : CM301000_CuryRateMaint
    {
        public c_filter_form Summary => base.Filter_form;

        public c_curyraterecordsentry_grid Details => base.CuryRateRecordsEntry_grid;

        public c_curyraterecordseffdate_grideffdate EffectiveRates => base.CuryRateRecordsEffDate_gridEffDate;

        public c_curyraterecordsentry_importxlsxsettings_frmimportxlsxsettings ExcelImportSettings => base.CuryRateRecordsEntry_ImportXLSXSettings_frmImportXLSXSettings;

        public c_curyraterecordsentry_importcsvsettings_frmimportcsvsettings CSVImportSettings => base.CuryRateRecordsEntry_ImportCSVSettings_frmImportCSVSettings;

        public c_curyraterecordsentry_importcolumns_grdimportcolumn ImportColumns => base.CuryRateRecordsEntry_ImportColumns_grdImportColumn;

        public CurrencyRate()
        {
            FileName = "Currency Rates";
            Details.UploadForm.Buttons.Upload.WaitAction = () =>
            {
                Wait.Wait.WaitForCondition(() => ExcelImportSettings.IsVisible() || CSVImportSettings.IsVisible(), Wait.Wait.MediumTimeOut);
                if (ExcelImportSettings.IsVisible()) ExcelImportSettings.Ok();
                else CSVImportSettings.Ok();
                Wait.Wait.WaitForCondition(ImportColumns.IsVisible, Wait.Wait.MediumTimeOut);
                ImportColumns.Ok();
                Wait.Wait.WaitForLongOperationToComplete();
            };
        }

        public void AddRecord(string fromCuryId, string curyRateType, string curyEffDate, decimal curyRate, string curyMultDiv)
        {
            if (Details.ToolBar.New.IsEnabled()) Details.New();
            Details.Row.FromCuryID.Select(fromCuryId);
            Details.Row.CuryRateType.Select(curyRateType);
            Details.Row.CuryEffDate.Type(curyEffDate);
            Details.Row.CuryRate.Type(curyRate);
            Details.Row.CuryMultDiv.Select(curyMultDiv);
        }

        public void AddRecord(string fromCuryId, string curyRateType, DateTime curyEffDate, decimal curyRate, string curyMultDiv)
        {
            Details.New();
            Details.Row.FromCuryID.Select(fromCuryId);
            Details.Row.CuryRateType.Select(curyRateType);
            Details.Row.CuryEffDate.Type(curyEffDate);
            Details.Row.CuryRate.Type(curyRate);
            Details.Row.CuryMultDiv.Select(curyMultDiv);
        }
    }
}
