using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class TaxCategory : TX205500_TaxCategoryMaint
    {
        public c_txcategory_form Summary => base.TxCategory_form;
        public c_details_grid Details => base.Details_grid;

        public TaxCategory()
        {
            FileName = "Tax Categories";

            QuickImport.DisabledLines = new[]
            {
                "TaxCategory->Exempt"
            };

            QuickImport.ExcludeFields = new[]
            {
                "TaxCategory->Exempt"
            };
        }
    }
}
