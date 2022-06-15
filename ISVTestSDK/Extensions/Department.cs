using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class Department : EP201500_DepartmentMaint
    {
        public c_epdepartment_grid Details => base.EPDepartment_grid;

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Create department: " + Details.Rows[0].DepartmentID.Value))
            {
                OpenScreen();
                New();
                Details.Row.DepartmentID.Type(EPDepartment_grid.Rows[0].DepartmentID.Value);
                Details.Row.Description.Type(EPDepartment_grid.Rows[0].Description.Value);
                Save();
            }
        }
    }
}
