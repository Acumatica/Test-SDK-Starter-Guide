using System;
using System.IO;
using System.Linq;
using Api;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class Account : GL202500_AccountMaint
    {
        private const string BaseCurrency = "USD";

        public c_accountrecords_grid Details => base.AccountRecords_grid;

        public c_accountrecords_importxlsxsettings_frmimportxlsxsettings ExcelImportSettings => base.AccountRecords_ImportXLSXSettings_frmImportXLSXSettings;

        public c_accountrecords_importcsvsettings_frmimportcsvsettings CsvImportSettings => base.AccountRecords_ImportCSVSettings_frmImportCSVSettings;

        public c_accountrecords_importcolumns_grdimportcolumn Columns => base.AccountRecords_ImportColumns_grdImportColumn;

        public override void ViewRestrictionGroups()
        {
            base.ViewRestrictionGroups();
            new GroupsByGlAccount().VerifyScreenID();
        }

        public Account()
        {
            FileName = "Accounts";
            ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            ToolBar.ViewRestrictionGroups.WaitAction = Wait.Wait.WaitForPageToLoad;

            Details.UploadForm.Buttons.Upload.WaitAction = () =>
            {
                Wait.Wait.WaitForCondition(() => !Details.UploadForm.Buttons.Upload.IsVisible(), Wait.Wait.LongTimeOut);
                Wait.Wait.WaitForCallbackToComplete();
            };

            ExcelImportSettings.Buttons.Ok.WaitAction = () => Wait.Wait.WaitForCondition(Columns.Buttons.Ok.IsVisible, Wait.Wait.LongTimeOut);
            Columns.Buttons.Ok.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
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
            Columns.Ok();
        }

        public override void ConfigureImportScenario()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Configure import scenario"))
            {
                var importScenario = new ImportScenario();
                importScenario.OpenScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);
                importScenario.Save();
                importScenario.Mapping.Adjust();
                var account = new Account();

                bool updateCurrency = new[] { "GBP", "SGD" }.Select(c => new Currency().ReadOne(ApiConnection.ApiConnection.Destination, c))
                    .Cast<Currency>().Any(c => c.Summary.IsActive.Value);

                importScenario.Mapping.ClickCell(account.Details.Columns.CuryID.ControlName);
                importScenario.Mapping.Row.IsActive.Set(updateCurrency);
                importScenario.Mapping.Row.IsActive.Set(updateCurrency);

                bool updateCurrencyRateType, updateAccountGroup;
                try
                {
                    updateCurrencyRateType = new ExtendedBiObject<CurrencyRateType>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch
                {
                    updateCurrencyRateType = false;
                }

                if (!updateCurrency) updateCurrencyRateType = false;

                try
                {
                    importScenario.Mapping.ClickCell(account.Details.Row.RevalCuryRateTypeId.ControlName);
                }
                catch
                {
                    importScenario.Mapping.ClickCell(account.Details.Row.RevalCuryRateTypeId.ControlName.Replace(" ", string.Empty));
                }
                importScenario.Mapping.Row.IsActive.Set(updateCurrencyRateType);
                importScenario.Mapping.Row.IsActive.Set(updateCurrencyRateType);

                try
                {
                    updateAccountGroup = new ExtendedBiObject<AccountGroup>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch
                {
                    updateAccountGroup = false;
                }

                try
                {
                    importScenario.Mapping.ClickCell(account.Details.Row.AccountGroupID.ControlName);
                }
                catch
                {
                    importScenario.Mapping.ClickCell(account.Details.Row.AccountGroupID.ControlName.Replace(" ", string.Empty));
                }
                importScenario.Mapping.Row.IsActive.Set(updateAccountGroup);
                importScenario.Mapping.Row.IsActive.Set(updateAccountGroup);

                importScenario.Save();
            }
        }
    }
}
