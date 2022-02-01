using Controls.Dashboard;
using Core;
using Core.Config;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using ISVTestSDK.Extensions;
namespace ISVTestSDK
{

    
    //Use the Check class as a parent for every test.
    //All test cases must be self contained. Starting from SalesDemo Example data and rely on no previous tests.
    //All test cases must perform the pre-config steps if required before performing the test action.

    public class Tests : Check
    {
        
        private readonly VendorMaint VendorMaint = new VendorMaint();

        public override void Execute()
        {
          
            #region TestCase 1 - Basic Test
            using (TestExecution.CreateTestCaseGroup("Test SDK Example"))
            {
                PxLogin.LoginToDestinationSite();
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
                    
                }
                #endregion
             
            }
            #endregion
        }
       
    }
}