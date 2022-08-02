using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class CustomerLocation : AR303020_CustomerLocationMaint
    {
        public c_location_frmheader Summary => base.Location_frmHeader;
        public c_locationcurrent_tab Details => base.LocationCurrent_tab;
        public c_contact_contact Contact => base.Contact_Contact;
        public c_address_address Address => base.Address_Address;
        public c_locationcurrent_tab Accounts => base.LocationCurrent_tab;
        public c_araccountsublocation_araccountsublocation ARAccounts => base.ARAccountSubLocation_ARAccountSubLocation;
        public c_araccountsublocation_araccountsublocation1 AccountsRetainage => ARAccountSubLocation_ARAccountSubLocation1;

        protected override void AutoTest()
        {
            using (TestExecution.TestExecution.CreateGroup(ScreenId, GetType().Name))
            {
                OpenScreen();
                Summary.BAccountID.Select("ABARTENDE");
                base.AutoTest();
            }
        }

        public void Activate()
        {
            Summary.Status.Select("Active");
            Save();
        }

        public void Deactivate()
        {
            Summary.Status.Select("Inactive");
            Save();
        }
    }
}
