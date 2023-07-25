using Core;
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
        public override void Execute()
        {
            ExcelDataEntryExample();
            using (TestExecution.CreateTestStepGroup("Test 1 - Open Screen"))
            {
                CABankTransactionsMaint.OpenScreen();
                CABankTransactionsMaint.Filter.CashAccountID.Type("10200");
                CABankTransactionsMaint.Filter.CashAccountID.GetValue().VerifyContains("10200").Assert();
                CABankTransactionsMaint.Filter.CashAccountID.Type("10400");
            }
        }


        public void ExcelDataEntryExample()
        {
            string excelsPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Excels\";

            //Excel Data Import Example
            using (TestExecution.CreateTestStepGroup("Test 2 - Import and enter data from excel"))
            {
                SOOrderEntry.OpenScreen();
                var excel = new ExcelPackage(new FileInfo(excelsPath + "SOLUTIONINITIALSExcelData.xlsx"));
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
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
        }

    }
}
