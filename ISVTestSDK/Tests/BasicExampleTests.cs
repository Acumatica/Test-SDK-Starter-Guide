
namespace GeneratedWrappers.SOLUTIONNAME
{
    internal class BasicExampleTests
    {
        public void BasicTest()
        {
            CA306000_CABankTransactionsMaintExtension CABankTransactionsMaint = new CA306000_CABankTransactionsMaintExtension();
            CABankTransactionsMaint.OpenScreen();
            CABankTransactionsMaint.tranFilter_form.CashAccountID.Type("10200");
            CABankTransactionsMaint.tranFilter_form.CashAccountID.GetValue().VerifyContains("10200").Assert();
            CABankTransactionsMaint.tranFilter_form.CashAccountID.Type("10400");
        }

        public void GenericInquiryViewExample()
        {
            //Logic for viewing GenericInquiry and checking if a value exists.
            IN2025PL_PXGenericInqGrphExtension IN2025PL = new IN2025PL_PXGenericInqGrphExtension();
            IN2025PL.OpenScreen();
            IN2025PL.results_grid.Columns.InventoryItem_inventoryCD.Equals("AACOMPUT01");
            IN2025PL.results_grid.ResetColumnFilters();
        }
    }
}
