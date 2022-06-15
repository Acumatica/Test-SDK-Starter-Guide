using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class ShipVia : CS207500_CarrierMaint
    {
        public c_carrier_form Summary => base.Carrier_form;

        public c_carriercurrent_tab CarrierDetails => base.CarrierCurrent_tab;

        public c_freightrates_gridfreightrates FreightRates => base.FreightRates_gridFreightRates;

        public c_carrierpackages_gridcarrierpackages CarrierPackages => base.CarrierPackages_gridCarrierPackages;

        public ShipVia()
        {
            FreightRates.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            QuickImport.SkipContainers = new[]
            {
                "Packages"
            };

            QuickImport.DisabledLines = new[]
            {
                "Details->GenerateReturnLabelAutomatically",
                "AdvancedFulfillment->ValidatePackedQuantitiesOnShipmentConfirmation",
                "AdvancedFulfillment->UseExternalShippingApplication"
            };
        }
    }
}
