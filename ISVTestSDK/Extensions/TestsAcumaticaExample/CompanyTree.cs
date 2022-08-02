using Api;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class CompanyTree : EP204061_CompanyTreeMaint
    {
        public CompanyTree()
        {
            Members.Row.EPEmployee__AcctCD.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
        }

        public c_currentworkgroup_form WorkGroupDetails
        {
            get { return base.CurrentWorkGroup_form; }            
        }

        public c_members_gridmembers Members
        {
            get { return base.Members_gridMembers; }           
        }

        public c_companytree Tree
        {
            get { return base.CompanyTree; }
        }

        public c_selectedparentfolders_formmoveworkgroup MoveWorkGroup
        {
            get { return base.SelectedParentFolders_formMoveWorkGroup; }
        }        

        private void AddDefaultWorkGroups()
        {
            using (TestExecution.TestExecution.CreateTestCaseGroup("Setting up Company Tree"))
            {
                OpenScreen();
                AddWorkGroup("Company", "CEO", "EP00000001");
                AddWorkGroup("Company", "CFO", "EP00000002");
                AddWorkGroup("Company", "CTO", "EP00000004");
            }
        }

        private void AddWorkGroup(string rootPath, string wgName, string wgMember)
        {
            using (TestExecution.TestExecution.CreateTestStepGroup(
                string.Format("{0} with one employee {1}", wgName, wgMember)))
            {
                try
                {
                    Tree.CompanyTree.Select(rootPath + "/" + wgName);
                    Log.Log.Information("Group has already been added");
                }
                catch
                {
                    Tree.CompanyTree.Select(rootPath);

                    Tree.AddWorkGroup();

                    WorkGroupDetails.Description.Type(wgName);

                    Members.New();
                    Members.Row.ContactID.Select(wgMember);

                    Save();
                }
            }
        }
    }
}
