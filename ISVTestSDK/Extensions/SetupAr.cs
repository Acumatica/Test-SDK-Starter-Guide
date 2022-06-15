using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class SetupAr : AR101000_ARSetupMaint
    {
        public c_arsetuprecord_tab GeneralSettings => base.ARSetupRecord_tab;
        public c_notifications_gridns Notifications => base.Notifications_gridNS;
        public c_recipients_gridnr Recipients => base.Recipients_gridNR;
        public c_dunningsetup_gridns DunningSettings => base.DunningSetup_gridNS;
        public c_setupapproval_gridapproval ApprovalGrid => base.SetupApproval_gridApproval;
    }
}