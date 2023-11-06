using Controls.CheckBox;

namespace GeneratedWrappers.SOLUTIONNAME
{
    internal class ConfigWebsite
    {
        public void ConfigForWrapperGeneration()
        {
            //Before Generating the Wrappers, all screens must be accessable at minimum for success.
            //The starting state of wrapper generation is SalesDemo data + your customization published.
            //Any aditional steps to enable the custom screens or features must be done before Wrapper generation.
            CS100000_FeaturesMaintExtension Features = new CS100000_FeaturesMaintExtension();
            Features.OpenScreen();
            Features.Insert();
            Features.features_form.SalesQuotes.SetTrue();
            Features.features_form.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
            Features.RequestValidation();
        }
        public void ConfigWebsiteFromSalesDemo()
        {
            // We assume the test starts from a blank salesdemo data + your customization published again.
            // If you had test steps running for wrapper generation, they must be run again here before the test.
            CS100000_FeaturesMaintExtension Features = new CS100000_FeaturesMaintExtension();
            Features.OpenScreen();
            Features.Insert();
            Features.features_form.SalesQuotes.SetTrue();
            Features.features_form.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
            Features.RequestValidation();
            // Use TestSDK code to enter any data required for the following tests to run.
            // eg. Configure numbering sequences, Enableing features, checkboxes on screens, setting up items
            // with newly added attributes.
        }
    }
}
