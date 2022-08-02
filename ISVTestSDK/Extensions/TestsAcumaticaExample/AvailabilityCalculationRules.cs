using GeneratedWrappers.Acumatica;
using Api;

namespace Core
{
    public partial class AvailabilityCalculationRules : IN201500_INAvailabilitySchemeMaint
    {
        public IN201500_INAvailabilitySchemeMaint.c_schemes_form GeneralSettings
        {
            get { return base.Schemes_form; }
        }

        public AvailabilityCalculationRules()
        {
            QuickImport.DisabledLines = new[]
            {
                "Schemes->DeductQtyOnServiceOrdersPrepared",
                "Schemes->DeductQtyOnServiceOrders"
            };
        }
    }


}
