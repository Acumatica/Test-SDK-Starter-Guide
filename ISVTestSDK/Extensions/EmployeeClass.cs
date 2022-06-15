using Api;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class EmployeeClass : EP202000_EmployeeClassMaint
    {
        public c_employeeclass_form Summary => base.EmployeeClass_form;

        public c_curemployeeclassrecord_tab GeneralSettings => base.CurEmployeeClassRecord_tab;

        public c_mapping_grid Attributes => base.Mapping_grid;

        public EmployeeClass()
        {
            QuickImport.ReplaceKey = "EQ";
        }

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE,
                "Create employee class: " + Summary.VendorClassID.Value))
            {
                OpenScreen();
                Insert();
                Summary.VendorClassID.Type(Summary.VendorClassID.Value);
                Process();
            }
        }

        private void Update()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE,
                "Update employee class: " + Summary.VendorClassID.Value))
            {
                OpenScreen();
                Summary.VendorClassID.Select(Summary.VendorClassID.Value);
                Process();
            }
        }

        private void Process()
        {
            var features = new Features();
            features.ReadOne(ApiConnection.ApiConnection.Destination, string.Empty);
            Summary.Descr.Type();
            GeneralSettings.TermsID.Select();
            GeneralSettings.PaymentMethodID.Select();

            if (!string.IsNullOrEmpty(GeneralSettings.PaymentMethodID.Value))
            {
                GeneralSettings.CashAcctID.Select();
            }

            GeneralSettings.APAcctID.Select();
            GeneralSettings.DiscTakenAcctID.Select();
            GeneralSettings.PrepaymentAcctID.Select();
            GeneralSettings.ExpenseAcctID.Select();
            GeneralSettings.SalesAcctID.Select();
            if (features.Summary.SubAccount.Value)
            {
                GeneralSettings.APSubID.Type();
                GeneralSettings.DiscTakenSubID.Type();
                GeneralSettings.PrepaymentSubID.Type();
                GeneralSettings.ExpenseSubID.Type();
                GeneralSettings.SalesSubID.Type();
            }
            else Log.Log.Information("Subaccount feature is disabled.");
            if (features.Summary.Multicurrency.Value)
            {
                GeneralSettings.CuryID.Select();
                GeneralSettings.AllowOverrideCury.Set();
                GeneralSettings.CuryRateTypeID.Select();
                GeneralSettings.AllowOverrideRate.Set();
            }
            else Log.Log.Information("Multi currency feature is disabled.");
            GeneralSettings.CalendarID.Select();
            GeneralSettings.TaxZoneID.Select();
            Save();
        }
    }
}
