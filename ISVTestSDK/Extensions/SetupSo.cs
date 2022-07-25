using Api;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class SetupSo : SO101000_SOSetupMaint
    {
        public c_sosetup_tab GeneralSettings => base.Sosetup_tab;
        public c_pickpackshipsetup_formscansetup PickPackShip => base.PickPackShipSetup_formScanSetup;
        public c_setupapproval_gridapproval Approval => base.SetupApproval_gridApproval;
        public c_notifications_gridns DefaultSources => base.Notifications_gridNS;
        public c_recipients_gridnr DefaultRecipients => base.Recipients_gridNR;

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Configure SO setup"))
            {
                OpenScreen();
                AddGeneralSettings();
                AddPriceDiscountCalculation();
                AddNotificationSettings();
                Save();
            }
        }

        private void AddGeneralSettings()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Add General GeneralSettings"))
            {
                GeneralSettings.ShipmentNumberingID.Select();
                GeneralSettings.FreightAllocation.Select();
                GeneralSettings.HoldShipments.Set();
                GeneralSettings.RequireShipmentTotal.Set();
                GeneralSettings.AddAllToShipment.Set();
                GeneralSettings.AutoReleaseIN.Set();
                GeneralSettings.UseShipDateForInvoiceDate.Set();
            }
        }

        private void AddPriceDiscountCalculation()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Add Price/Discount Calculation"))
            {
                //GeneralSettings.SalesPriceUpdateUnit.Select();
                //GeneralSettings.DefaultRateTypeID.Select();
                //GeneralSettings.AlwaysFromBaseCury.Set();
                GeneralSettings.FreeItemShipping.Select();
                //GeneralSettings.LineDiscountTarget.Select();
                GeneralSettings.MinGrossProfitValidation.Select();
                //GeneralSettings.ProrateDiscounts.Set();

                //foreach (c_linelevel_detaillevelgrid.c_grid_row row in ItemLevelDiscounts.Rows)
                //{
                //    row.FirstDiscountID.Select();
                //    row.SecondDiscountID.Select();
                //    row.IsCompoundDiscount.Set();
                //}

                //foreach (c_documentlevel_groupdocumentlevel.c_grid_row row in DocumentLevelDiscounts.Rows)
                //{
                //    row.FirstDiscountID.Select();
                //    row.SecondDiscountID.Select();
                //}
            }
        }

        private void AddNotificationSettings()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Add Notification GeneralSettings"))
            {
                if (DefaultSources.RowsCount() != 0)
                {
                    DefaultSources.SelectAllRecords();
                    DefaultSources.Delete();
                    Save();
                }

                foreach (c_notifications_gridns.c_grid_row row in DefaultSources.Rows)
                {
                    DefaultSources.New();
                    row.NotificationCD.Type();
                    row.NotificationID.Select();
                    row.Format.Select();
                    row.Active.Set();
                    row.ReportID.Type();
                }

                if (DefaultRecipients.RowsCount() != 0)
                {
                    DefaultRecipients.SelectAllRecords();
                    DefaultRecipients.Delete();
                    Save();
                }

                foreach (c_recipients_gridnr.c_grid_row row in DefaultRecipients.Rows)
                {
                    DefaultRecipients.New();
                    row.ContactType.Select();
                    row.ContactID.Select();
                    row.Format.Select();
                    row.Active.Set();
                    row.AddTo.Select();
                }
            }
        }
    }
}
