using GeneratedWrappers.Acumatica;
namespace ISVTestSDK.Extensions
{
    public partial class VendorMaint : AP303000_VendorMaint
    {
        public c_currentvendor_tab GeneralTab => CurrentVendor_tab;
        public c_primarycontactcurrent_frmprimarycontact CreateContactPopupForm => PrimaryContactCurrent_frmPrimaryContact;
        public c_baccount_baccount VendorHeader => BAccount_BAccount;
        public c_contactinfo_tabcreatecontact  CreateContactPopupFormButtons => ContactInfo_tabCreateContact;
        public c_contactinfo_formcreatecontact CreateContactform => ContactInfo_formCreateContact;


    }
}
