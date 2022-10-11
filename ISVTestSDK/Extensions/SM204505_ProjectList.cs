using Controls.CompilationPanel;
using Controls.Grid.Upload;
using GeneratedWrappers.Acumatica;

namespace GeneratedWrappers.ISVTEST
{
    public partial class ProjectList : SM204505_ProjectList
    {
        public c_projects_grid Details => Projects_grid;
        public new c_grid_upload OpenPackage => base.OpenPackage;
        public new CompilationPanel CompilationPanel => base.CompilationPanel;
        public c_viewpublishoptions_viewpublishoptions PublishToMultipleCompanies => base.ViewPublishOptions_ViewPublishOptions;


    }
}
