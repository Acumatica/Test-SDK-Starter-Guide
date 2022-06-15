using GeneratedWrappers.Acumatica;

namespace Core
{
    public class CurrencyRatesHistory : GI000001_PXGenericInqGrph
    {
        public c_filter_form Summary => base.Filter_form;
        public c_results_grid Details => base.Results_grid;

        protected override void AutoTest() { }
        protected override void DependencyTest() { }
    }
}
