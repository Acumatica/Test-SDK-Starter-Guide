using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class SetupIn : IN101000_INSetupMaint
    {
        public c_setup_tab GeneralSettings => Setup_tab;
        public c_scansetup_formscansetup OperationSettings => ScanSetup_formScanSetup;
    }
}
