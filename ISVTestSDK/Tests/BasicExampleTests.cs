
namespace GeneratedWrappers.SOLUTIONNAME
{
    internal class BasicExampleTests
    {
        public void BasicTest()
        {
            CA306000_CABankTransactionsMaint CABankTransactionsMaint = new CA306000_CABankTransactionsMaint();
            CABankTransactionsMaint.OpenScreen();
            CABankTransactionsMaint.TranFilter_form.CashAccountID.Type("10200");
            CABankTransactionsMaint.TranFilter_form.CashAccountID.GetValue().VerifyContains("10200").Assert();
            CABankTransactionsMaint.TranFilter_form.CashAccountID.Type("10400");
        }

        public void GenericInquiryViewExample()
        {
            //Logic for viewing GenericInquiry and checking if a value exists.
            IN2025PL_PXGenericInqGrph IN2025PL = new IN2025PL_PXGenericInqGrph();
            IN2025PL.OpenScreen();
            IN2025PL.Results_grid.Columns.InventoryItem_inventoryCD.Equals("AACOMPUT01");
            IN2025PL.Results_grid.ResetColumnFilters();
        }
    }
}
