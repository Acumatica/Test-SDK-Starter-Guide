using Controls.Button;
using Controls.Dashboard;
using Controls.Editors.Selector;
using Controls.Input;
using Controls.ToolBarButton;
using Core;
using Core.Config;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using System;
using Core.Attributes;
using Core.Core.Browser;
using System.Threading;
using GeneratedWrappers.Acumatica;
using ISVTestSDK.Extensions;

namespace ISVTestSDK
{

    public class Tests1 : Check
    {

        private readonly VendorMaint VendorMaint = new VendorMaint();
        private readonly ReceiptIn ReceiptIn = new ReceiptIn();
        private readonly InventorySummary InventorySummary = new InventorySummary();
        private readonly SetupSo SetupSo = new SetupSo();
        private readonly OrderType OrderType = new OrderType();

        protected const string UPDATING_SALES_ORDER_RECORD_RAISED_ONE_OR_MORE_ERRORS_PLEASE_REVIEW =
           "Updating  'Sales Order' record raised at least one error. Please review the errors.";
        protected const string DOCUMENT_IS_OUT_OF_BALANCE = "The document is out of the balance.";
        private const string InventoryID = "SO00000001";

        private OrderSo OrderSo { get; } = new OrderSo();

        public override void Execute()
        {

            //  PxLogin.LoginToDestinationSite();

            #region TestCase 1 - Basic Test
            using (TestExecution.CreateTestCaseGroup("Test SDK Example"))
            {

                #region Step 1 - Navigate to a vendor and create a contact
                using (TestExecution.CreateTestStepGroup("Create Vendor Contact"))
                {

                    VendorMaint.OpenScreen();
                    VendorMaint.VendorHeader.AcctCD.Type("TestVendor"); // create new vendor or update if exists
                    VendorMaint.VendorHeader.VendorClassID.Type("PRODUCT"); // add/update required field vendor class
                    VendorMaint.GeneralTab.AcctName.Type("TestVendor"); // inserting required field into the general Tab of Vendors screen

                    VendorMaint.ToolBar.CreateContact.WaitActionOverride = () =>
                    {
                        Wait.WaitForCondition(VendorMaint.CreateContactform.FirstName.IsVisible, Wait.LongTimeOut);
                    };

                    VendorMaint.ToolBar.MenuOpener.Click();
                    VendorMaint.ToolBar.CreateContact.Click();

                    VendorMaint.CreateContactform.FirstName.Type("TestSDKContact");
                    VendorMaint.CreateContactform.LastName.Type("TestSDKContact"); // type in required fields on the popup form

                    VendorMaint.CreateContactPopupFormButtons.Create(); // pressing the create button to submit the popup form

                    VendorMaint.DynamicGrid("Activities"); //select financial tab
                    VendorMaint.DynamicControl<Selector>("Currency ID:").Type("CAD");
                    VendorMaint.ToolBar.Save.Click();

                }
                #endregion

            }
            #endregion

            #region TestCase 1 - Basic Test
            using (TestExecution.CreateGroup($"Testing order of type "))
            {
                OrderSo.OpenScreen();
                OrderSo.Insert();
                OrderSo.Note();
                OrderSo.NotePanel.Cancel();

                OrderSo.Summary.OrderType.Type("SO");

                OrderSo.Summary.CustomerID.Select("ABCSTUDIOS");

                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ACCOMODATE");
                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ADMCHARGE");

                OrderSo.Cancel();
                OrderSo.Insert();
                OrderSo.Note();
                OrderSo.NotePanel.Cancel();

                OrderSo.Summary.OrderType.Type("SO");
                OrderSo.Summary.CustomerID.Select("ABARTENDE");

                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ACCOMODATE");
                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ADMCHARGE");

                OrderSo.Cancel();
                OrderSo.Insert();
                OrderSo.Note();
                OrderSo.NotePanel.Cancel();

                OrderSo.Summary.OrderType.Type("SO");
                OrderSo.Summary.CustomerID.Select("ALPHABETLD");

                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ACCOMODATE");
                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ADMCHARGE");

                OrderSo.Cancel();
            }

            #endregion

            #region Test case So1-1: Preparation.

            using (TestExecution.CreateTestCaseGroup("So1-1: Preparation."))
            {
                #region Step 1 Create receipt: 000001

                using (TestExecution.CreateTestStepGroup("Create receipt: 000001"))
                {
                    ReceiptIn.OpenScreen();
                    ReceiptIn.SetBusinessDate(new DateTime(2009, 02, 01));
                    ReceiptIn.Insert();
                    ReceiptIn.Summary.ExtRefNbr.Type("SO001-01-03");
                    ReceiptIn.Summary.TranDesc.Type("SO001-01-03");
                    ReceiptIn.TransactionDetails.New();
                    ReceiptIn.TransactionDetails.Row.InventoryID.Select(InventoryID);
                    ReceiptIn.TransactionDetails.Row.SiteID.Select("WHOLESALE");
                    ReceiptIn.TransactionDetails.Row.LocationID.Select("R01C01L01");
                    ReceiptIn.TransactionDetails.Row.Qty.Type(15);
                    ReceiptIn.TransactionDetails.Row.UnitCost.Type(10);
                    ReceiptIn.ReleaseFromHold();
                    ReceiptIn.Release();
                }

                #endregion

                #region Step 2 Verify inventory summary for the stock item: SO00000001

                using (TestExecution.CreateTestStepGroup("Verify inventory summary for the stock item: SO00000001"))
                {
                    InventorySummary.OpenScreen();
                    InventorySummary.Summary.InventoryID.Select(InventoryID);
                    InventorySummary.Details.SelectRow(1);
                    InventorySummary.Details.Row.SiteID.GetValue().VerifyEquals("WHOLESALE");
                    InventorySummary.Details.Row.LocationID.GetValue().VerifyEquals("R01C01L01");
                    InventorySummary.Details.Row.QtyOnHand.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtyAvail.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtySOBooked.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBackOrdered.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipping.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipped.GetValue().VerifyEquals(0.00m);
                }

                #endregion

                #region Step 3 Setup sales orders preferences

                using (TestExecution.CreateTestStepGroup("Setup sales orders preferences"))
                {
                    SetupSo.OpenScreen();
                    SetupSo.GeneralSettings.HoldShipments.SetTrue();
                    SetupSo.GeneralSettings.RequireShipmentTotal.SetTrue();
                    SetupSo.GeneralSettings.AutoReleaseIN.SetFalse();
                    SetupSo.Save();
                }

                #endregion

                #region Step 4 Setup order type SO - Sales Order

                using (TestExecution.CreateTestStepGroup("Setup order type SO - Sales Order"))
                {
                    OrderType.OpenScreen();
                    OrderType.Summary.OrderType.Select("SO");
                    OrderType.GeneralSettings.OrderNumberingID.Select("SOORDER");
                    OrderType.GeneralSettings.HoldEntry.SetTrue();
                    OrderType.GeneralSettings.CreditHoldEntry.SetTrue();
                    OrderType.GeneralSettings.RequireControlTotal.SetTrue();
                    OrderType.GeneralSettings.BillSeparately.SetTrue();
                    OrderType.Save();
                }

                #endregion
            }

            #endregion

            #region Test case So1-2: Create, release, change, delete sales order.

            using (TestExecution.CreateTestCaseGroup("So1-2: Create, release, change, delete sales order."))
            {
                #region Step 1 Enter sales order #000001

                using (TestExecution.CreateTestStepGroup("Enter sales order #000001"))
                {
                    OrderSo.OpenScreen();
                    OrderSo.SetBusinessDate(new DateTime(2009, 02, 01));
                    OrderSo.Insert();
                    OrderSo.Summary.OrderType.Select("SO");
                    OrderSo.Summary.CustomerID.Select(InventoryID);
                    OrderSo.Summary.CustomerOrderNbr.Type("SO-090201-001");
                    OrderSo.Summary.OrderDesc.Type("SO001-02-01");
                    OrderSo.DocumentDetails.New();
                    OrderSo.DocumentDetails.Row.InventoryID.Select(InventoryID);
                    OrderSo.DocumentDetails.Row.SiteID.Select("WHOLESALE");
                    OrderSo.DocumentDetails.Row.OrderQty.Type(3);
                    OrderSo.DocumentDetails.Row.CuryUnitPrice.Type(20);
                    OrderSo.Save();
                }

                #endregion

                #region Step 2 Verify inventory summary for the stock item: SO00000001

                using (TestExecution.CreateTestStepGroup("Verify inventory summary for the stock item: SO00000001"))
                {
                    InventorySummary.OpenScreen();
                    InventorySummary.Summary.InventoryID.Select(InventoryID);
                    InventorySummary.Details.RowsCount().VerifyEquals(3);
                    InventorySummary.Details.Columns.QtySOPrepared.ShowColumn();
                    InventorySummary.Details.Columns.QtyINIssues.ShowColumn();

                    InventorySummary.Details.SelectRow(1);
                    InventorySummary.Details.Row.SiteID.GetValue().VerifyEquals("WHOLESALE");
                    InventorySummary.Details.Row.LocationID.GetValue().VerifyEquals("<UNASSIGNED>");
                    InventorySummary.Details.Row.QtyOnHand.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyAvail.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOPrepared.GetValue().VerifyEquals(3.00m);
                    InventorySummary.Details.Row.QtySOBooked.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBackOrdered.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipping.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipped.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyINIssues.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.SelectRow(2);
                    InventorySummary.Details.Row.SiteID.GetValue().VerifyEquals("WHOLESALE");
                    InventorySummary.Details.Row.LocationID.GetValue().VerifyEquals("R01C01L01");
                    InventorySummary.Details.Row.QtyOnHand.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtyAvail.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtySOPrepared.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBooked.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBackOrdered.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipping.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipped.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyINIssues.GetValue().VerifyEquals(0.00m);
                }

                #endregion

                #region Step 3 Update sales order #000001

                using (TestExecution.CreateTestStepGroup("Update sales order #000001"))
                {
                    OrderSo.OpenScreen();
                    OrderSo.Summary.OrderNbr.Select("000001");

                    OrderSo.VerifyAlert(OrderSo.ToolBar.ReleaseFromHold.Click, UPDATING_SALES_ORDER_RECORD_RAISED_ONE_OR_MORE_ERRORS_PLEASE_REVIEW);
                    OrderSo.GetErrors().VerifyAnyOfValuesContains(DOCUMENT_IS_OUT_OF_BALANCE);

                    OrderSo.Summary.CuryControlTotal.Type(60.00m);
                    OrderSo.Save();
                }

                #endregion

                #region Step 4 Verify inventory summary for the stock item: SO00000001

                using (TestExecution.CreateTestStepGroup("Verify inventory summary for the stock item: SO00000001"))
                {
                    InventorySummary.OpenScreen();
                    InventorySummary.Summary.InventoryID.Select(InventoryID);
                    InventorySummary.Details.RowsCount().VerifyEquals(3);
                    InventorySummary.Details.SelectRow(1);
                    InventorySummary.Details.Row.SiteID.GetValue().VerifyEquals("WHOLESALE");
                    InventorySummary.Details.Row.LocationID.GetValue().VerifyEquals("<UNASSIGNED>");
                    InventorySummary.Details.Row.QtyOnHand.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyAvail.GetValue().VerifyEquals(-3.00m);
                    InventorySummary.Details.Row.QtySOBooked.GetValue().VerifyEquals(3.00m);
                    InventorySummary.Details.Row.QtySOBackOrdered.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipping.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipped.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyINIssues.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.SelectRow(2);
                    InventorySummary.Details.Row.SiteID.GetValue().VerifyEquals("WHOLESALE");
                    InventorySummary.Details.Row.LocationID.GetValue().VerifyEquals("R01C01L01");
                    InventorySummary.Details.Row.QtyOnHand.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtyAvail.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtySOBooked.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBackOrdered.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipping.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipped.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyINIssues.GetValue().VerifyEquals(0.00m);
                }

                #endregion

                #region Step 5 Update sales order #000001

                using (TestExecution.CreateTestStepGroup("Update sales order #000001"))
                {
                    OrderSo.OpenScreen();
                    OrderSo.Summary.OrderNbr.Select("000001");
                    OrderSo.DocumentDetails.Row.OrderQty.Type(4.00m);
                    OrderSo.Summary.CuryControlTotal.Type(80.00m);
                    OrderSo.Save();
                }

                #endregion

                #region Step 6 Verify inventory summary for the stock item: SO00000001

                using (TestExecution.CreateTestStepGroup("Verify inventory summary for the stock item: SO00000001"))
                {
                    InventorySummary.OpenScreen();

                    InventorySummary.Summary.InventoryID.Select(InventoryID);
                    InventorySummary.Details.RowsCount().VerifyEquals(3);
                    InventorySummary.Details.SelectRow(1);
                    InventorySummary.Details.Row.SiteID.GetValue().VerifyEquals("WHOLESALE");
                    InventorySummary.Details.Row.LocationID.GetValue().VerifyEquals("<UNASSIGNED>");
                    InventorySummary.Details.Row.QtyOnHand.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyAvail.GetValue().VerifyEquals(-4.00m);
                    InventorySummary.Details.Row.QtySOPrepared.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBooked.GetValue().VerifyEquals(4.00m);
                    InventorySummary.Details.Row.QtySOBackOrdered.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipping.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipped.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyINIssues.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.SelectRow(2);
                    InventorySummary.Details.Row.SiteID.GetValue().VerifyEquals("WHOLESALE");
                    InventorySummary.Details.Row.LocationID.GetValue().VerifyEquals("R01C01L01");
                    InventorySummary.Details.Row.QtyOnHand.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtyAvail.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtySOPrepared.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBooked.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBackOrdered.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipping.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipped.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyINIssues.GetValue().VerifyEquals(0.00m);
                }

                #endregion

                #region Step 7 Delete sales order #000001

                using (TestExecution.CreateTestStepGroup("Delete sales order #000001"))
                {
                    OrderSo.OpenScreen();
                    OrderSo.Summary.OrderNbr.Select("000001");
                    OrderSo.Delete();
                }

                #endregion

                #region Step 8 Verify inventory summary for the stock item: SO00000001

                using (TestExecution.CreateTestStepGroup("Verify inventory summary for the stock item: SO00000001"))
                {
                    InventorySummary.OpenScreen();
                    InventorySummary.Summary.InventoryID.Select(InventoryID);
                    InventorySummary.Details.RowsCount().VerifyEquals(2);
                    InventorySummary.Details.SelectRow(1);
                    InventorySummary.Details.Row.SiteID.GetValue().VerifyEquals("WHOLESALE");
                    InventorySummary.Details.Row.LocationID.GetValue().VerifyEquals("R01C01L01");
                    InventorySummary.Details.Row.QtyOnHand.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtyAvail.GetValue().VerifyEquals(15.00m);
                    InventorySummary.Details.Row.QtySOPrepared.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBooked.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOBackOrdered.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipping.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtySOShipped.GetValue().VerifyEquals(0.00m);
                    InventorySummary.Details.Row.QtyINIssues.GetValue().VerifyEquals(0.00m);
                }

                #endregion
            }

            #endregion


        }

    }
}