using Controls.Alert;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public class ReceiptIn : IN301000_INReceiptEntry
    {
        public c_receipt_form Summary => base.Receipt_form;
        public c_currentdocument_form2 FinancialDetails => base.CurrentDocument_form2;
        public c_transactions_grid TransactionDetails => base.Transactions_grid;
        public c_splits_grid2 BinLotSerialGrid => base.Splits_grid2;
        public c_sitestatusfilter_formsitesstatus InventoryLookupFilter => base.Sitestatusfilter_formsitesstatus;
        public c_sitestatus_gripsitestatus InventoryLookupGrid => base.Sitestatus_gripsitestatus;
        public c_linesplittingextension_lotseroptions_optform Allocations => base.LineSplittingExtension_LotSerOptions_optform;
        public c_transactions_importxlsxsettings_frmimportxlsxsettings ExcelImportSettings => base.Transactions_importxlsxsettings_frmimportxlsxsettings;
        public c_transactions_importcolumns_grdimportcolumn ImportColumns => base.Transactions_importcolumns_grdimportcolumn;
        public c_transactions_importcsvsettings_frmimportcsvsettings CommonSettings => base.Transactions_importcsvsettings_frmimportcsvsettings;
        public c_currentdocument_formam1 ManufacturingTab => base.CurrentDocument_formam1;

        public ReceiptIn()
        {
            ToolBar.Save.WaitAction = Alert.AlertToException;
            ToolBar.Release.ConfirmAction = Alert.AlertToException;
            ToolBar.Release.WaitAction = delegate ()
            {
                Alert.AlertToException();
                Wait.Wait.WaitForLongOperationToComplete();
            };

            ImportColumns.Buttons.Ok.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            Allocations.Buttons.Ok.WaitAction = Wait.Wait.WaitForCallbackToComplete;
            FinancialDetails.BatchNbr.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);

            TransactionDetails.ToolBar.AddItems.WaitAction = delegate
            {
                Wait.Wait.WaitForPageToLoad();
                InventoryLookupGrid.Refresh();
                InventoryLookupGrid.Refresh();
            };

            QuickImport.Key = new[] { "000225" };
            QuickImport.ExcludeFields = new[]
            {
                "DocumentSummary->Status",
                "Financial->BatchNbr",
                "LineDetailsUnassignedQty->QuantityToGenerate",
                "LineDetailsUnassignedQty->StartLotSerialNumber",
                "DocumentSummary->ReferenceNbr",
                "Details->POReceiptNbr",
                "Details->POReceiptType"
            };

            QuickImport.LastRecord = LastRecordMethod.LastModified;
            QuickImport.ReplaceKey = "QI";
            QuickImport.DisabledLines = new string[] { "Details->Subitem" };

        }

        public void AddTransactionDetail(string InventoryID, string WarehouseID, string LocationID, decimal Qty, decimal UnitCost, string subitemID = "")
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION,
                string.Format("Add transaction detail: {0}, {1}", InventoryID, WarehouseID)))
            {
                TransactionDetails.New();
                TransactionDetails.Row.InventoryID.Select(InventoryID);
                if (!string.IsNullOrEmpty(subitemID)) TransactionDetails.Row.SubItemID.Type(subitemID);
                TransactionDetails.Row.SiteID.Select(WarehouseID);
                TransactionDetails.Row.LocationID.Select(LocationID);
                TransactionDetails.Row.Qty.Type(Qty);
                TransactionDetails.Row.UnitCost.Type(UnitCost);
            }
        }

    }
}
