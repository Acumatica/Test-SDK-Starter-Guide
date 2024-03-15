
using GeneratedWrappers.Acumatica;

namespace GeneratedWrappers.SOLUTIONNAME
{
    internal class BasicExampleTests
    {
        public void BasicTest()
        {
            SO301000SOOrderEntry SOOrderEntry = new SO301000SOOrderEntry();
            SOOrderEntry.OpenScreen();
            SOOrderEntry.Insert();
            SOOrderEntry.Document.CustomerID.Type("AACUSTOMER");
            SOOrderEntry.Save();
            string soOrderNumber = SOOrderEntry.Document.OrderNbr.GetValue(); // Save SOOrder generated ID dynamically for later use if needed.

            CA306000CABankTransactions CABankTransactionsMaint = new CA306000CABankTransactions();
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
    }
}
