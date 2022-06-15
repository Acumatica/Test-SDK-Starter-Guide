using System;
using System.IO;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class Subaccount : GL203000_SubAccountMaint
    {
        public c_subrecords_grid1 Details => base.SubRecords_grid1;

        public c_subrecords_importxlsxsettings_frmimportxlsxsettings ExcelImportSettings => base.SubRecords_ImportXLSXSettings_frmImportXLSXSettings;

        public c_subrecords_importcsvsettings_frmimportcsvsettings CsvImportSettings => base.SubRecords_ImportCSVSettings_frmImportCSVSettings;

        public c_subrecords_importcolumns_grdimportcolumn ImportColumns => base.SubRecords_ImportColumns_grdImportColumn;


        public Subaccount()
        {
            FileName = "Subaccounts";
            ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;

            Details.UploadForm.Buttons.Upload.WaitAction = delegate
            {
                Wait.Wait.WaitForCondition(() => !Details.UploadForm.Buttons.Upload.IsVisible(), Wait.Wait.LongTimeOut);
                Wait.Wait.WaitForCallbackToComplete();
            };
            ExcelImportSettings.Buttons.Ok.WaitAction = delegate
            {
                Wait.Wait.WaitForCondition(() => ImportColumns.Buttons.Ok.IsVisible(), Wait.Wait.LongTimeOut);
            };
            ImportColumns.Buttons.Ok.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
        }

        public void LoadRecordsFromFile(string filePath)
        {
            LoadRecordsFromFile(new FileInfo(filePath));
        }

        public void LoadRecordsFromFile(FileInfo File)
        {
            Upload();
            Details.UploadForm.SelectFile(File.FullName);
            Details.UploadForm.Upload();
            if (File.Extension.Equals(".csv", StringComparison.OrdinalIgnoreCase)) CsvImportSettings.Ok();
            else ExcelImportSettings.Ok();
            ImportColumns.Ok();
        }
    }
}