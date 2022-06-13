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



            using (TestExecution.CreateGroup($"Testing order of type "))
            {
                OrderSo.OpenScreen();
                OrderSo.Insert();
                OrderSo.Note();
                OrderSo.NotePanel.Cancel(); // PATCH: to remove the tooltip of the Insert Button

                // OrderSo.Summary.OrderType.Select("SO");
                OrderSo.Summary.OrderType.Type("SO");              // Bug Acumatica.  Use Type instead of Select because of the custom order type

                OrderSo.Summary.CustomerID.Select("ABCSTUDIOS");

                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ACCOMODATE");
                //OrderSo.DocumentDetails.Row.TranDesc.GetValue().VerifyEquals(ACCOMODATE_EN);
                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ADMCHARGE");
                //OrderSo.DocumentDetails.Row.TranDesc.GetValue().VerifyEquals(ADMCHARGE_EN);

                OrderSo.Cancel();
                OrderSo.Insert();
                OrderSo.Note();
                OrderSo.NotePanel.Cancel(); // PATCH: to remove the tooltip of the Insert Button

                // OrderSo.Summary.OrderType.Select("SO");
                OrderSo.Summary.OrderType.Type("SO");              // Bug Acumatica.  Use Type instead of Select because of the custom order type
                OrderSo.Summary.CustomerID.Select("ABARTENDE");

                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ACCOMODATE");
                //OrderSo.DocumentDetails.Row.TranDesc.GetValue().VerifyEquals(ACCOMODATE_FR);
                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ADMCHARGE");
                //OrderSo.DocumentDetails.Row.TranDesc.GetValue().VerifyEquals(ADMCHARGE_FR);

                OrderSo.Cancel();
                OrderSo.Insert();
                OrderSo.Note();
                OrderSo.NotePanel.Cancel(); // PATCH: to remove the tooltip of the Insert Button

                // OrderSo.Summary.OrderType.Select("SO");
                OrderSo.Summary.OrderType.Type("SO");              // Bug Acumatica.  Use Type instead of Select because of the custom order type
                OrderSo.Summary.CustomerID.Select("ALPHABETLD");

                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ACCOMODATE");
                //OrderSo.DocumentDetails.Row.TranDesc.GetValue().VerifyEquals(ACCOMODATE_EN);
                OrderSo.DocumentDetails.New();
                OrderSo.DocumentDetails.Row.InventoryID.Select("ADMCHARGE");
                //OrderSo.DocumentDetails.Row.TranDesc.GetValue().VerifyEquals(ADMCHARGE_EN);

                OrderSo.Cancel();
            }

            #endregion
        }
       
    }
}