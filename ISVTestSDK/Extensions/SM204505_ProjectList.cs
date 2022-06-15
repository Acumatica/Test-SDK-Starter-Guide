using Controls.CompilationPanel;
using Controls.Grid.Upload;


namespace ISVTestSDK.Extensions
{
    public partial class ProjectList : SM204505_ProjectList
    {
        public c_projects_grid Details => Projects_grid;
        public c_grid_upload Opn => OpenPackage;
        public CompilationPanel CplnPanel => CompilationPanel;




    }
}
