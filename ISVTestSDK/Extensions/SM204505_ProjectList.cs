﻿using Controls.CompilationPanel;
using Controls.Grid.Upload;
using GeneratedWrappers.Acumatica;

namespace GeneratedWrappers.ISVTestSDK
{
    public partial class ProjectList : SM204505_ProjectList
    {
        public c_projects_grid Details => Projects_grid;
        public c_grid_upload OpenPackage => base.OpenPackage;
        public CompilationPanel CompilationPanel => base.CompilationPanel;




    }
}
