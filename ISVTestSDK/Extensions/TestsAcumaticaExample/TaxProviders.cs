using GeneratedWrappers.Acumatica;

namespace Core
{
    public class TaxProviders : TX102000_TaxPluginMaint
    {
        public c_plugin_form Summary => base.Plugin_form;
        public c_mapping_pxgridaccounts Mapping => base.Mapping_PXGridAccounts;
        public c_details_pxgridsettings PluginParameters => base.Details_PXGridSettings;

        public override void OpenScreen(bool forceReopen = false)
        {
            base.OpenScreen(forceReopen);
            Cancel();
        }

        public TaxProviders()
        {
            ToolBar.Test.WaitAction = Wait.Wait.WaitForCallbackToComplete;
        } 
    }
}