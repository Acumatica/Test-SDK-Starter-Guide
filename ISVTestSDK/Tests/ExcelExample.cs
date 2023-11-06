using Core.Log;
using Core.TestExecution;
using OfficeOpenXml;
using System;
using System.IO;

namespace GeneratedWrappers.SOLUTIONNAME
{
    internal class ExcelExample
    {
        public void ExcelDataEntryExample()
        {
            // Inside of the "Core" package dependancy, Acumatica has included EPPlus 4.5.3.2,
            // it is free to use without a commercial license, later versions require a license to use.
            // Excel files can be imported with the example below or any other way using EPPlus
            // but you must not add any dependancies outside what is included in Acumatica's
            // TestSDK packages folder.

            //Excel files must be placed in the project's Excels folder and the file imported as below
            //Excel files MUST start with your registered SOLUTIONNAME to make them uniquely named.
            string excelsPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Excels\";
            var excel = new ExcelPackage(new FileInfo(excelsPath + "SOLUTIONNAMEExcelData.xlsx"));

            using (TestExecution.CreateTestStepGroup("Import and enter data from excel"))
            {
                SO301000_SOOrderEntryExtension SOOrderEntry = new SO301000_SOOrderEntryExtension();
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
                            SOOrderEntry.document_form.CustomerID.Type(ExcelHeaderTab.Cells[row, 2].Text);

                            // For each inventoryID to add to order from excel
                            for (int detailsTab = ExcelDetailsTab.Dimension.Start.Row + 1; detailsTab <= ExcelDetailsTab.Dimension.End.Row; detailsTab++)
                            {
                                // Only add lines if the id matches the SalesOrder ID number from the ExcelHeaderTab
                                if (ExcelHeaderTab.Cells[row, 1].Text != ExcelDetailsTab.Cells[detailsTab, 1].Text) continue;
                                else
                                {
                                    //Deatils Tab fill in when ID matches the sales order id number
                                    SOOrderEntry.transactions_grid.New();
                                    SOOrderEntry.transactions_grid.Row.InventoryID.Type(ExcelDetailsTab.Cells[detailsTab, 2].Text);
                                    SOOrderEntry.transactions_grid.Row.OrderQty.Type(ExcelDetailsTab.Cells[detailsTab, 3].Text);
                                }
                            }
                            SOOrderEntry.currentDocument_formDeliverySettings.ShipVia.Type(ExcelShippingTab.Cells[row, 2].Text);
                            SOOrderEntry.shipping_Address_formB.OverrideAddress.Set(true);
                            SOOrderEntry.shipping_Address_formB.AddressLine1.Type(ExcelAddressesTab.Cells[row, 3].Text);
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
