using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class Carrier : CS207700_CarrierPluginMaint
    {
        public c_customeraccounts_pxgridaccounts CustomerAccounts => CustomerAccounts_PXGridAccounts;

        public c_plugin_form Summary => Plugin_form;

        public c_details_pxgridsettings PluginParameters => Details_PXGridSettings;

        public Carrier()
        {
            FileName = "Carriers";
            QuickImport.Skip = true;

            ToolBar.Test.WaitAction = () =>
            {
                Wait.Wait.WaitForCallbackToComplete();
                MessageBox.GetValue().VerifyContains("The connection to the carrier was successful");
            };

        }
    }
}