using Controls.CheckBox;
using Core;
using Core.Config;
using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using GeneratedWrappers.Acumatica;
using GeneratedWrappers.SOLUTIONNAME;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace GeneratedWrappers.SOLUTIONNAME
{
    public class Test1 : Check
    {
        CA306000CABankTransactions CABankTransactionsMaint = new CA306000CABankTransactions();
        SO301000SOOrderEntry SOOrderEntry = new SO301000SOOrderEntry();
        public CS100000FeaturesMaint Features = new CS100000FeaturesMaint();
        public override void Execute()
        {
            PxLogin.LoginToDestinationSite();
            using (TestExecution.CreateTestStepGroup("Config site"))
            {
                ConfigWebsiteFromSalesDemo();
                ExcelDataEntryExample();
            }
            using (TestExecution.CreateTestStepGroup("Main Tests"))
            {
                BasicTest();
                GenericInquiryViewExample();
            }
        }

        public void ConfigWebsiteFromSalesDemo()
        {
            //We assume the test starts from a blank salesdemo data + your customization published again.
            //If you had test steps running for wrapper generation, they must be run again here before the test.

            Features.OpenScreen();
            Features.Insert();
            Features.Summary.SalesQuotes.SetTrue();
            Features.Summary.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
            Features.RequestValidation();

            //Use TestSDK code to enter any data required for the following tests to run.
            //eg. Configure numbering sequences, Enableing features, checkboxes on screens, setting up items
            // with newly added attributes.
        }

        public void BasicTest()
        {
            CABankTransactionsMaint.OpenScreen();
            CABankTransactionsMaint.Filter.CashAccountID.Type("10200");
            CABankTransactionsMaint.Filter.CashAccountID.GetValue().VerifyContains("10200").Assert();
            CABankTransactionsMaint.Filter.CashAccountID.Type("10400");
        }

        public void GenericInquiryViewExample()
        {
            //Logic for viewing GenericInquiry and checking if a value exists.
            IN2025PLPXGenericInqGrph IN2025PL = new IN2025PLPXGenericInqGrph();
            IN2025PL.OpenScreen();
            IN2025PL.ResultGrid.Columns.InventoryItem_inventoryCD.Equals("AACOMPUT01");
            IN2025PL.ResultGrid.ResetColumnFilters();
        }

        public void ExcelDataEntryExample()
        {
            // Inside of the "Core" package dependancy, Acumatica has included EPPlus 4.5.3.2,
            // it is free to use without a commercial license, later versions require a license to use.
            // Excel files can be imported with the example below or any other way using EPPlus
            // but you must not add any dependancies outside what is included in Acumatica's
            // TestSDK packages folder.

            //Excel files must be placed in the project's Excels folder and the file imported as below
            //Excel files MUST start with your solutions initials to make them uniquely named.
            string excelsPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Excels\";
            var excel = new ExcelPackage(new FileInfo(excelsPath + "SOLUTIONINITIALSExcelData.xlsx"));
            
            using (TestExecution.CreateTestStepGroup("Import and enter data from excel"))
            {
                SOOrderEntry.OpenScreen();
                {
                    var ExcelHeaderTab = excel.Workbook.Worksheets["Header"];
                    var ExcelDetailsTab = excel.Workbook.Worksheets["Details"];
                    var ExcelShippingTab = excel.Workbook.Worksheets["Shipping"];
                    var ExcelAddressesTab = excel.Workbook.Worksheets["Addresses"];

                    for (int row = ExcelHeaderTab.Dimension.Start.Row + 1; row <= ExcelHeaderTab.Dimension.End.Row; row++)
                    {
                        try
                        {
                            //Header Area data
                            SOOrderEntry.Insert();
                            SOOrderEntry.Document.CustomerID.Type(ExcelHeaderTab.Cells[row, 2].Text);

                            // For each inventoryID to add to order from excel
                            for (int detailsTab = ExcelDetailsTab.Dimension.Start.Row + 1; detailsTab <= ExcelDetailsTab.Dimension.End.Row; detailsTab++)
                            {
                                // Only add lines if the id matches the SalesOrder ID number from the ExcelHeaderTab
                                if (ExcelHeaderTab.Cells[row, 1].Text != ExcelDetailsTab.Cells[detailsTab, 1].Text) continue;
                                else
                                {
                                    //Deatils Tab fill in when ID matches the sales order id number
                                    SOOrderEntry.Transactions.New();
                                    SOOrderEntry.Transactions.Row.InventoryID.Type(ExcelDetailsTab.Cells[detailsTab, 2].Text);
                                    SOOrderEntry.Transactions.Row.OrderQty.Type(ExcelDetailsTab.Cells[detailsTab, 3].Text);
                                }
                            }

                            SOOrderEntry.Shipping.ShipVia.Type(ExcelShippingTab.Cells[row, 2].Text);
                            SOOrderEntry.Addresses.OverrideAddress.Set(true);
                            SOOrderEntry.Addresses.AddressLine1.Type(ExcelAddressesTab.Cells[row, 3].Text);

                            SOOrderEntry.Save();
                        }
                        catch (Exception ex) 
                        {
                            Log.Error(ex.StackTrace.ToString());
                            continue;
                        }
                    }
                }
            }
        }

    }
}
