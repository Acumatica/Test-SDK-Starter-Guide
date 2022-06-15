using Api;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class ShipmentTerms : CS208000_ShipTermsMaint
    {
        public c_shiptermscurrent_form Summary => base.ShipTermsCurrent_form;
        public c_shiptermsdetail_grid Details => base.ShipTermsDetail_grid;

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Create shipment terms: " + Summary.ShipTermsID.Value))
            {
                OpenScreen();
                Insert();
                Summary.ShipTermsID.Type();
                Process();
            }
        }

        public void Update()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Update shipment terms: " + Summary.ShipTermsID.Value))
            {
                OpenScreen();
                Summary.ShipTermsID.Select();
                Process();
            }
        }

        private void Process()
        {
            Summary.Description.Type();
            foreach (c_shiptermsdetail_grid.c_grid_row detail in Details.Rows)
            {
                AddRecord(detail);
            }
            Save();
        }

        private void AddRecord(c_shiptermsdetail_grid.c_grid_row detail)
        {
            Details.New();

            detail.BreakAmount.Type();
            detail.FreightCostPercent.Type();
            detail.InvoiceAmountPercent.Type();
            detail.ShippingHandling.Type();
            detail.LineHandling.Type();
        }
    }
}
