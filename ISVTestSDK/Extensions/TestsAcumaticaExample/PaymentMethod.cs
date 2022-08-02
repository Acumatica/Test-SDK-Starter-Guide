using Core.Core.Browser;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class PaymentMethod : CA204000_PaymentMethodMaint
    {
        public c_paymentmethod_form Summary => base.PaymentMethod_form;
        public c_cashaccounts_grdcashaccounts CashAccounts => base.CashAccounts_grdCashAccounts;
        public c_paymentmethodcurrent_tab PaymentSettings => base.PaymentMethodCurrent_tab;
        public c_detailsforreceivable_grid IncomingPaymentDetails => base.DetailsForReceivable_grid;
        public c_detailsforvendor_grid OutgoingPaymentDetails => base.DetailsForVendor_grid;
        public c_detailsforcashaccount_grid RemittanceSettings => base.DetailsForCashAccount_grid;
        public c_processingcenters_grdproccenters ProcessingCenters => base.ProcessingCenters_grdProcCenters;

        public PaymentMethod()
        {
            FileName = "Payment Methods";

            QuickImport.DisabledLines = new[]
            {
                "SettingsForUseInARPaymentMethodDetails->PaymentMethod"
            };

            QuickImport.ExcludeFields = new[]
            {
                "SettingsForUseInAPCheckPrintingSettings->LinesPerStub",
                "SettingsForUseInARPaymentMethodDetails->PaymentMethod"
            };

            IncomingPaymentDetails.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            OutgoingPaymentDetails.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            ProcessingCenters.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            CashAccounts.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            RemittanceSettings.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
        }

        public override void ConfigureImportScenario()
        {
            using (TestExecution.TestExecution.CreateGroup("Disable Cash Account reference import"))
            {
                var importScenario = new ImportScenario();
                importScenario.OpenScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);
                importScenario.Save();
                importScenario.Mapping.Adjust();
                importScenario.Mapping.SelectRow(importScenario.Mapping.Columns.Value, "CashAccount");

                for (int i = 0; i < 13; i++)
                {
                    importScenario.Mapping.Row.IsActive.SetFalse();
                    Browser.Actions.SendKeys(OpenQA.Selenium.Keys.ArrowDown).Perform();
                    importScenario.Save();
                }

                importScenario.Save();
            }
        }
    }
}
