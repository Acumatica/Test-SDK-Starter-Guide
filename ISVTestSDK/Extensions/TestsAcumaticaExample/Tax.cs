using GeneratedWrappers.Acumatica;
using System.Linq;

namespace Core
{
    public partial class Tax : TX205000_SalesTaxMaint
    {
        public c_categories_grid2 Categories => base.Categories_grid2;
        public c_zones_grid3 Zones => base.Zones_grid3;
        public c_taxrevisions_grid1 Details => base.TaxRevisions_grid1;
        public c_tax_tab Settings => base.Tax_tab;
        public c_currenttax_glaccountslocation Accounts => base.CurrentTax_GLAccountsLocation;
        public c_taxforprintingparameterstab_edprintingparameters PrintingParameters =>
            base.TaxForPrintingParametersTab_edPrintingParameters; 

        public Tax()
        {
            FileName = "Taxes";
        }

        public void DeleteCorrectlyAndVerify()
        {
            string TaxToDelete = Settings.TaxID.GetValue();

            using (TestExecution.TestExecution.CreateGroup("Delete tax: " + TaxToDelete))
            {
                if (Zones.HasRows())
                {
                    Zones.SelectAllRecords();
                    Zones.Delete();
                }

                if (Categories.HasRows())
                {
                    Categories.SelectAllRecords();
                    Categories.Delete();
                }

                base.Delete();
                RefreshScreen();
                Settings.TaxID.Open();
                Settings.TaxID.Grid.Columns
                    .DynamicControl<Controls.Editors.Selector.SelectorColumnFilter>(Settings.TaxID.ControlName)
                    .GetValues()
                    .VerifyNoneOfValuesContains(TaxToDelete.Split().First());
            }
        }
    }
}
