using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class SetupAp : AP101000_APSetupMaint
    {
        public c_setup_tab GeneralSettings => base.Setup_tab;

        public c_setup_discountparameters Print1099 => base.Setup_DiscountParameters;

        public c_boxes1099_grid Settings1099 => base.Boxes1099_grid;

        public c_setupapproval_gridapproval ApprovalGrid => base.SetupApproval_gridApproval;

        public c_notifications_gridns Notifications => base.Notifications_gridNS;

        public c_recipients_gridnr Recipients => base.Recipients_gridNR;
    }
}
