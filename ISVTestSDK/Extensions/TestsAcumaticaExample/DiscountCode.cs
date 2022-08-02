using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class DiscountCode : AR209000_ARDiscountMaint
    {
        public c_document_grid Details => base.Document_grid;

        public DiscountCode()
        {
            FileName = "Discount Code";
        }
    }
}
