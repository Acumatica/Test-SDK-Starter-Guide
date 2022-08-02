using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class UnitConversion : CS203100_INUnitMaint
    {
        public c_unit_grid Details => base.Unit_grid;

        public UnitConversion()
        {
            ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
        }
    }
}