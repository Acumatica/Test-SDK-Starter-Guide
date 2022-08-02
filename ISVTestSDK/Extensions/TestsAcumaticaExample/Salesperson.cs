using GeneratedWrappers.Acumatica;

namespace Core
{
    public class Salesperson : AR205000_SalesPersonMaint
    {
        public c_salesperson_frmheader Summary => base.Salesperson_frmHeader;
        public c_salespersoncurrent_tab Details => base.SalespersonCurrent_tab;
        public c_spcustomers_grdspcustomers Customers => base.SPCustomers_grdSPCustomers;
        public c_commissionshistory_grid CommissionHistory => base.CommissionsHistory_grid;

        public Salesperson()
        {
            QuickImport.SkipContainers = new[]
            {
                "CommissionHistory"
            };

            QuickImport.ExcludeFields = new[]
            {
                "Customers->Default"
            };

            Customers.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            CommissionHistory.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
        }
    }
}
