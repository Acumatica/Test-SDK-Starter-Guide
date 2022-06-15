using Api;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class FobPoint : CS208500_FOBPointMaint
    {
        public c_fobpoint_grid Details => base.FOBPoint_grid;

        public c_fobpoint_importxlsxsettings_frmimportxlsxsettings ExcelImportSettings => base.FOBPoint_ImportXLSXSettings_frmImportXLSXSettings;

        public c_fobpoint_importcsvsettings_frmimportcsvsettings CsvImportSettings => base.FOBPoint_ImportCSVSettings_frmImportCSVSettings;

        public c_fobpoint_importcolumns_grdimportcolumn ImportColumns => base.FOBPoint_ImportColumns_grdImportColumn;

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Create fob point: " + Details.Rows[0].FOBPointID.Value))
            {
                OpenScreen();
                New();
                Process();
                Save();
            }
        }

        public void Update()
        {          
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Update fob point: " + Details.Rows[0].FOBPointID.Value))
            {
                OpenScreen();
                Details.SelectRow(Details.Columns.FOBPointID, Details.Rows[0].FOBPointID.Value);
                Process();
                Save();
            }
        }

        private void Process()
        {
            Details.Rows[0].FOBPointID.Type();
            Details.Rows[0].Description.Type();
        }
    }
}
