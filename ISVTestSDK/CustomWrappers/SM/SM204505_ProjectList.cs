using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.CompilationPanel;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.RichTextEdit;
using Controls.ToolBarButton;
using Controls.Uploader;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.ISVTEST
{
    
    
    public class SM204505_ProjectList : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_projects_grid Projects_grid { get; } = new c_projects_grid("ctl00_phL_grid", "Projects_grid");
        protected c_projects_lv0 Projects_lv0 { get; } = new c_projects_lv0("ctl00_phL_grid_lv0", "Projects_lv0");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_profilerinfoview_formprofiler ProfilerInfoView_formProfiler { get; } = new c_profilerinfoview_formprofiler("ctl00_usrCaption_pnlProfiler_formProfiler", "ProfilerInfoView_formProfiler");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_projectschooser_gridchooser ProjectsChooser_gridChooser { get; } = new c_projectschooser_gridchooser("ctl00_phL_PanelChooseProjects_gridChooser", "ProjectsChooser_gridChooser");
        protected c_projectschooser_lv0 ProjectsChooser_lv0 { get; } = new c_projectschooser_lv0("ctl00_phL_PanelChooseProjects_gridChooser_lv0", "ProjectsChooser_lv0");
        protected c_viewpublishoptions_viewpublishoptions ViewPublishOptions_ViewPublishOptions { get; } = new c_viewpublishoptions_viewpublishoptions("ctl00_phL_PanelPublishExt_ViewPublishOptions", "ViewPublishOptions_ViewPublishOptions");
        protected c_viewcompanylist_gridcompanylist ViewCompanyList_GridCompanyList { get; } = new c_viewcompanylist_gridcompanylist("ctl00_phL_PanelPublishExt_GridCompanyList", "ViewCompanyList_GridCompanyList");
        protected c_viewcompanylist_lv0 ViewCompanyList_lv0 { get; } = new c_viewcompanylist_lv0("ctl00_phL_PanelPublishExt_GridCompanyList_lv0", "ViewCompanyList_lv0");
        protected c_viewvalidateextensions_pxformview4 ViewValidateExtensions_PXFormView4 { get; } = new c_viewvalidateextensions_pxformview4("ctl00_phL_PanelValidateExt_PXFormView4", "ViewValidateExtensions_PXFormView4");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_grid_upload OpenPackage { get; } = new c_grid_upload("ctl00_phL_UploadPackageDlg_UploadPackagePanel", "OpenPackage");
        protected CompilationPanel CompilationPanel { get; } = new CompilationPanel("ctl00_phL_PanelCompiler", "CompilationPanel");
        
        public SM204505_ProjectList()
        {
            ScreenId = "SM204505";
            ScreenUrl = "/Pages/SM/SM204505.aspx";
            ToolBar = new PxToolBar(null);
        }
        
        public virtual SM204505_ProjectList ReadOne(Gate gate, string Name)
        {
            new BiObject<SM204505_ProjectList>(gate).ReadOne(this, Name);
            return this;
        }
        
        public virtual SM204505_ProjectList ReadOne(string Name)
        {
            return this.ReadOne(ApiConnection.Source, Name);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void KeyBtnRefresh()
        {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help()
        {
            ToolBar.Help.Click();
        }
        
        public virtual void MenuOpener()
        {
            ToolBar.MenuOpener.Click();
        }
        
        public virtual void Refresh()
        {
            ToolBar.Refresh.Click();
        }
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void New()
        {
            ToolBar.New.Click();
        }
        
        public virtual void Delete()
        {
            ToolBar.Delete.Click();
        }
        
        public virtual void ActionPublish()
        {
            ToolBar.ActionPublish.Click();
        }
        
        public virtual void ActionUndoPublish()
        {
            ToolBar.ActionUndoPublish.Click();
        }
        
        public virtual void ActionValidateCertStatus()
        {
            ToolBar.ActionValidateCertStatus.Click();
        }
        
        public virtual void AutoValidateCertStatus()
        {
            ToolBar.AutoValidateCertStatus.Click();
        }
        
        public virtual void ActionImport()
        {
            ToolBar.ActionImport.Click();
        }
        
        public virtual void ActionImportReplace()
        {
            ToolBar.ActionImportReplace.Click();
        }
        
        public virtual void ActionSavePackage()
        {
            ToolBar.ActionSavePackage.Click();
        }
        
        public virtual void ActionPublishedXml()
        {
            ToolBar.ActionPublishedXml.Click();
        }
        
        public virtual void ActionPublishExt()
        {
            ToolBar.ActionPublishExt.Click();
        }
        
        public virtual void ActionValidateHighlighted()
        {
            ToolBar.ActionValidateHighlighted.Click();
        }
        
        public virtual void ActionValidateMultiple()
        {
            ToolBar.ActionValidateMultiple.Click();
        }
        
        public virtual void ActionRuntimeValidationDACFieldsTypes()
        {
            ToolBar.ActionRuntimeValidationDACFieldsTypes.Click();
        }
        
        public virtual void ActionRuntimeValidationDACAttributes()
        {
            ToolBar.ActionRuntimeValidationDACAttributes.Click();
        }
        
        public virtual void ActionRuntimeValidationLookupsDefinitions()
        {
            ToolBar.ActionRuntimeValidationLookupsDefinitions.Click();
        }
        
        public virtual void LongRun()
        {
            ToolBar.LongRun.Click();
        }
        
        public virtual void LongrunCancel()
        {
            ToolBar.LongrunCancel.Click();
        }
        
        public virtual void LongrunTimer()
        {
            ToolBar.LongrunTimer.Click();
        }
        
        public class PxToolBar : PxControlCollection
        {
            
			public ToolBarButton SyncTOC { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton MenuOpener { get; }
			public ToolBarButton Refresh { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton New { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton ActionPublish { get; }
			public ToolBarButton ActionUndoPublish { get; }
			public ToolBarButton ActionValidateCertStatus { get; }
			public ToolBarButton AutoValidateCertStatus { get; }
			public ToolBarButton ActionImport { get; }
			public ToolBarButton ActionImportReplace { get; }
			public ToolBarButton ActionSavePackage { get; }
			public ToolBarButton ActionPublishedXml { get; }
			public ToolBarButton ActionPublishExt { get; }
			public ToolBarButton ActionValidateHighlighted { get; }
			public ToolBarButton ActionValidateMultiple { get; }
			public ToolBarButton ActionRuntimeValidationDACFieldsTypes { get; }
			public ToolBarButton ActionRuntimeValidationDACAttributes { get; }
			public ToolBarButton ActionRuntimeValidationLookupsDefinitions { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton LongrunCancel { get; }
			public ToolBarButton LongrunTimer { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Help", locator, null);
                MenuOpener = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_MenuOpener", "Menu", locator, null);
                Refresh = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Refresh", "Refresh", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                New = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_AddNew", "Add Row", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Delete", "Delete Row", locator, null);
                ActionPublish = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionPublish", "Publish the selected projects, unpublish the not selected projects.", locator, null);
                ActionUndoPublish = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionUndoPublish,#ctl00_phDS_ds_ToolBar_actionUndoPub" +
                        "lish_item", "Remove all published customizations from the website.", locator, MenuOpener);
                ActionValidateCertStatus = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionValidateCertStatus,#ctl00_phDS_ds_ToolBar_action" +
                        "ValidateCertStatus_item", "Validate Certification Status", locator, MenuOpener);
                AutoValidateCertStatus = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_autoValidateCertStatus,#ctl00_phDS_ds_ToolBar_autoVali" +
                        "dateCertStatus_item", "Auto Validate Certification Status", locator, MenuOpener);
                ActionImport = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionImport,#ctl00_phDS_ds_ToolBar_actionImport_item", "Import", locator, MenuOpener);
                ActionImportReplace = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionImportReplace,#ctl00_phDS_ds_ToolBar_actionImpor" +
                        "tReplace_item", "Replace Highlighted Project Content", locator, MenuOpener);
                ActionSavePackage = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionSavePackage,#ctl00_phDS_ds_ToolBar_actionSavePac" +
                        "kage_item", "Export the project to a file.", locator, MenuOpener);
                ActionPublishedXml = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionPublishedXml,#ctl00_phDS_ds_ToolBar_actionPublis" +
                        "hedXml_item", "View XML of the published customization.", locator, MenuOpener);
                ActionPublishExt = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionPublishExt,#ctl00_phDS_ds_ToolBar_actionPublishE" +
                        "xt_item", "Publish to Multiple Tenants", locator, MenuOpener);
                ActionValidateHighlighted = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionValidateHighlighted,#ctl00_phDS_ds_ToolBar_actio" +
                        "nValidateHighlighted_item", "Validate Highlighted Project", locator, MenuOpener);
                ActionValidateMultiple = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionValidateMultiple,#ctl00_phDS_ds_ToolBar_actionVa" +
                        "lidateMultiple_item", "Validate Multiple Projects", locator, MenuOpener);
                ActionRuntimeValidationDACFieldsTypes = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionRuntimeValidationDACFieldsTypes,#ctl00_phDS_ds_T" +
                        "oolBar_actionRuntimeValidationDACFieldsTypes_item", "DAC Field Types (Runtime Validation)", locator, MenuOpener);
                ActionRuntimeValidationDACAttributes = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionRuntimeValidationDACAttributes,#ctl00_phDS_ds_To" +
                        "olBar_actionRuntimeValidationDACAttributes_item", "DAC Attributes (Runtime Validation)", locator, MenuOpener);
                ActionRuntimeValidationLookupsDefinitions = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_actionRuntimeValidationLookupsDefinitions,#ctl00_phDS_" +
                        "ds_ToolBar_actionRuntimeValidationLookupsDefinitions_item", "Lookup Definitions (Runtime Validation)", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_projects_grid : Grid<c_projects_grid.c_grid_row, c_projects_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_projects_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phL_grid");
                DataMemberName = "Projects";
                FilterForm = new c_grid_filter("ctl00_phL_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phL_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phL_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phL_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phL_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phL_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox IsWorking { get; }
			public CheckBox IsPublished { get; }
			public PXTextEdit Name { get; }
			public PXNumberEdit Level { get; }
			public PXTextEdit ScreenNames { get; }
			public PXTextEdit Description { get; }
			public PXTextEdit CertificationStatus { get; }
			public PXTextEdit Initials { get; }
			public PXTextEdit CreatedByID_Creator_Username { get; }
			public DateSelector LastModifiedDateTime { get; }
                
                public c_grid_row(c_projects_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsWorking = new CheckBox("_ctl00_phL_grid_lv0_chkIsWorking", "Selected", grid.Locator, "IsWorking");
                    IsWorking.DataField = "IsWorking";
                    IsPublished = new CheckBox("ctl00_phL_grid", "Published", grid.Locator, "IsPublished");
                    IsPublished.DataField = "IsPublished";
                    Name = new PXTextEdit("_ctl00_phL_grid_lv0_edName", "Project Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Level = new PXNumberEdit("ctl00_phL_grid_en", "Level", grid.Locator, "Level");
                    Level.DataField = "Level";
                    ScreenNames = new PXTextEdit("ctl00_phL_grid_ei", "Screen Names", grid.Locator, "ScreenNames");
                    ScreenNames.DataField = "ScreenNames";
                    Description = new PXTextEdit("_ctl00_phL_grid_lv0_edDescription", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    CertificationStatus = new PXTextEdit("ctl00_phL_grid_ei", "Certification Status", grid.Locator, "CertificationStatus");
                    CertificationStatus.DataField = "CertificationStatus";
                    Initials = new PXTextEdit("ctl00_phL_grid_ei", "Initials", grid.Locator, "Initials");
                    Initials.DataField = "Initials";
                    CreatedByID_Creator_Username = new PXTextEdit("ctl00_phL_grid_ei", "Created By", grid.Locator, "CreatedByID_Creator_Username");
                    CreatedByID_Creator_Username.DataField = "CreatedByID_Creator_Username";
                    LastModifiedDateTime = new DateSelector("_ctl00_phL_grid_lv0_edLastModifiedDateTime", "Last Modified On", grid.Locator, "LastModifiedDateTime");
                    LastModifiedDateTime.DataField = "LastModifiedDateTime";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter IsWorking { get; }
				public CheckBoxColumnFilter IsPublished { get; }
				public PXTextEditColumnFilter Name { get; }
				public PXNumberEditColumnFilter Level { get; }
				public PXTextEditColumnFilter ScreenNames { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXTextEditColumnFilter CertificationStatus { get; }
				public PXTextEditColumnFilter Initials { get; }
				public PXTextEditColumnFilter CreatedByID_Creator_Username { get; }
				public DateSelectorColumnFilter LastModifiedDateTime { get; }
                
                public c_grid_header(c_projects_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsWorking = new CheckBoxColumnFilter(grid.Row.IsWorking);
                    IsPublished = new CheckBoxColumnFilter(grid.Row.IsPublished);
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    Level = new PXNumberEditColumnFilter(grid.Row.Level);
                    ScreenNames = new PXTextEditColumnFilter(grid.Row.ScreenNames);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    CertificationStatus = new PXTextEditColumnFilter(grid.Row.CertificationStatus);
                    Initials = new PXTextEditColumnFilter(grid.Row.Initials);
                    CreatedByID_Creator_Username = new PXTextEditColumnFilter(grid.Row.CreatedByID_Creator_Username);
                    LastModifiedDateTime = new DateSelectorColumnFilter(grid.Row.LastModifiedDateTime);
                }
            }
        }
        
        public class c_projects_lv0 : Container
        {
            
			public PXTextEdit Name { get; }
			public Label NameLabel { get; }
			public CheckBox IsWorking { get; }
			public Label IsWorkingLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public Selector CreatedByID { get; }
			public Label CreatedByIDLabel { get; }
			public DateSelector CreatedDateTime { get; }
			public Label CreatedDateTimeLabel { get; }
			public Selector LastModifiedByID { get; }
			public Label LastModifiedByIDLabel { get; }
			public DateSelector LastModifiedDateTime { get; }
			public Label LastModifiedDateTimeLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_projects_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Name = new PXTextEdit("ctl00_phL_grid_lv0_edName", "Project Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                IsWorking = new CheckBox("ctl00_phL_grid_lv0_chkIsWorking", "Selected", locator, null);
                IsWorkingLabel = new Label(IsWorking);
                IsWorking.DataField = "IsWorking";
                Description = new PXTextEdit("ctl00_phL_grid_lv0_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                CreatedByID = new Selector("ctl00_phL_grid_lv0_edCreatedByID", "Owner", locator, null);
                CreatedByIDLabel = new Label(CreatedByID);
                CreatedByID.DataField = "CreatedByID";
                CreatedDateTime = new DateSelector("ctl00_phL_grid_lv0_edCreatedDateTime", "Creation Date", locator, null);
                CreatedDateTimeLabel = new Label(CreatedDateTime);
                CreatedDateTime.DataField = "CreatedDateTime";
                LastModifiedByID = new Selector("ctl00_phL_grid_lv0_edLastModifiedByID", "Last Modified By", locator, null);
                LastModifiedByIDLabel = new Label(LastModifiedByID);
                LastModifiedByID.DataField = "LastModifiedByID";
                LastModifiedDateTime = new DateSelector("ctl00_phL_grid_lv0_edLastModifiedDateTime", "Last Modified On", locator, null);
                LastModifiedDateTimeLabel = new Label(LastModifiedDateTime);
                LastModifiedDateTime.DataField = "LastModifiedDateTime";
                Es = new Selector("ctl00_phL_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Projects";
            }
        }
        
        public class c_parameters_gridwizard : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public CheckBox Override { get; }
			public Label OverrideLabel { get; }
			public Selector RoleName { get; }
			public Label RoleNameLabel { get; }
            
            public c_parameters_gridwizard(string locator, string name) : 
                    base(locator, name)
            {
                IsDefault = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_defaultCkbx", "Is Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                Override = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_overrideCkbx", "Override", locator, null);
                OverrideLabel = new Label(Override);
                Override.DataField = "Override";
                RoleName = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_edRole", "Role Name", locator, null);
                RoleNameLabel = new Label(RoleName);
                RoleName.DataField = "RoleName";
                DataMemberName = "Parameters";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Cancel { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    Cancel = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_cancel", "Cancel", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Prev = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_prev", "Prev", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Next = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_next", "Next", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Finish = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_save", "Finish", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                }
            }
        }
        
        public class c_profilerinfoview_formprofiler : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit StartText { get; }
			public Label StartTextLabel { get; }
			public PXTextEdit Started { get; }
			public Label StartedLabel { get; }
			public PXTextEdit RequestsLogged { get; }
			public Label RequestsLoggedLabel { get; }
			public Label LblPlace_ { get; }
            
            public c_profilerinfoview_formprofiler(string locator, string name) : 
                    base(locator, name)
            {
                StartText = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblStartText", "Start Text", locator, null);
                StartTextLabel = new Label(StartText);
                StartText.DataField = "StartText";
                Started = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblStartedAt", "Started", locator, null);
                StartedLabel = new Label(Started);
                Started.DataField = "Started";
                RequestsLogged = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblRequestsLogged", "Requests Logged", locator, null);
                RequestsLoggedLabel = new Label(RequestsLogged);
                RequestsLogged.DataField = "RequestsLogged";
                LblPlace_ = new Label("ctl00_usrCaption_pnlProfiler_formProfiler_lblPlace", "Lbl Place _", locator, null);
                DataMemberName = "ProfilerInfoView";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnStartProfiler()
            {
                Buttons.BtnStartProfiler.Click();
            }
            
            public virtual void BtnStopProfiler()
            {
                Buttons.BtnStopProfiler.Click();
            }
            
            public virtual void BtnMainProfiler()
            {
                Buttons.BtnMainProfiler.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnStartProfiler { get; }
			public Button BtnStopProfiler { get; }
			public Button BtnMainProfiler { get; }
                
                public PxButtonCollection()
                {
                    BtnStartProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStartProfiler", "btnStartProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnStopProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStopProfiler", "btnStopProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnMainProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnMainProfiler", "btnMainProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                }
            }
        }
        
        public class c_gridlist_gridgrid : Grid<c_gridlist_gridgrid.c_grid_row, c_gridlist_gridgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_gridlist_gridgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid");
                DataMemberName = "GridList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit View { get; }
			public PXTextEdit Id { get; }
                
                public c_grid_row(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ef", "Included", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    View = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Table ID", grid.Locator, "View");
                    View.DataField = "View";
                    Id = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Grid ID", grid.Locator, "Id");
                    Id.DataField = "Id";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter View { get; }
				public PXTextEditColumnFilter Id { get; }
                
                public c_grid_header(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    View = new PXTextEditColumnFilter(grid.Row.View);
                    Id = new PXTextEditColumnFilter(grid.Row.Id);
                }
            }
        }
        
        public class c_userlist_usergrid : Grid<c_userlist_usergrid.c_grid_row, c_userlist_usergrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_userlist_usergrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid");
                DataMemberName = "UserList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Included { get; }
			public Selector Username { get; }
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Email { get; }
			public PXTextEdit Guest { get; }
			public DropDown State { get; }
                
                public c_grid_row(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    Username = new Selector("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Login", grid.Locator, "Username");
                    Username.DataField = "Username";
                    DisplayName = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Display Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Email = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Guest = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Guest Account", grid.Locator, "Guest");
                    Guest.DataField = "Guest";
                    State = new DropDown("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Status", grid.Locator, "State");
                    State.DataField = "State";
                    State.Items.Add("N", "Not Created");
                    State.Items.Add("O", "Online");
                    State.Items.Add("P", "Pending Activation");
                    State.Items.Add("D", "Disabled");
                    State.Items.Add("A", "Active");
                    State.Items.Add("L", "Temporarily Locked");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Included { get; }
				public SelectorColumnFilter Username { get; }
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Email { get; }
				public PXTextEditColumnFilter Guest { get; }
				public DropDownColumnFilter State { get; }
                
                public c_grid_header(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBoxColumnFilter(grid.Row.Included);
                    Username = new SelectorColumnFilter(grid.Row.Username);
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Guest = new PXTextEditColumnFilter(grid.Row.Guest);
                    State = new DropDownColumnFilter(grid.Row.State);
                }
            }
        }
        
        public class c_userlist_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_userlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "UserList";
            }
        }
        
        public class c_projectschooser_gridchooser : Grid<c_projectschooser_gridchooser.c_grid_row, c_projectschooser_gridchooser.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_projectschooser_gridchooser(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phL_PanelChooseProjects_gridChooser");
                DataMemberName = "ProjectsChooser";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phL_PanelChooseProjects_gridChooser_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void VALIDATE()
            {
                Buttons.VALIDATE.Click();
            }
            
            public virtual void VALIDATEANDSHOWALLMESSAGES()
            {
                Buttons.VALIDATEANDSHOWALLMESSAGES.Click();
            }
            
            public virtual void CANCEL()
            {
                Buttons.CANCEL.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phL_PanelChooseProjects_gridChooser_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phL_PanelChooseProjects_gridChooser_at_tlb div[data-cmd=\'AdjustColumns" +
                            "\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phL_PanelChooseProjects_gridChooser_at_tlb div[data-cmd=\'ExportExcel\']" +
                            "", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phL_PanelChooseProjects_gridChooser_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phL_PanelChooseProjects_gridChooser_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button VALIDATE { get; }
			public Button VALIDATEANDSHOWALLMESSAGES { get; }
			public Button CANCEL { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phL_PanelChooseProjects_gridChooser_lfFirst0", "First", "ctl00_phL_PanelChooseProjects_gridChooser");
                    Prev = new Button("ctl00_phL_PanelChooseProjects_gridChooser_lfPrev0", "Prev", "ctl00_phL_PanelChooseProjects_gridChooser");
                    Next = new Button("ctl00_phL_PanelChooseProjects_gridChooser_lfNext0", "Next", "ctl00_phL_PanelChooseProjects_gridChooser");
                    Last = new Button("ctl00_phL_PanelChooseProjects_gridChooser_lfLast0", "Last", "ctl00_phL_PanelChooseProjects_gridChooser");
                    VALIDATE = new Button("ctl00_phL_PanelChooseProjects_PXPanelChooseProjectsOK", "VALIDATE", "ctl00_phL_PanelChooseProjects_gridChooser");
                    VALIDATEANDSHOWALLMESSAGES = new Button("ctl00_phL_PanelChooseProjects_PXPanelChooseProjectsAllMessagesOK", "VALIDATE AND SHOW ALL MESSAGES", "ctl00_phL_PanelChooseProjects_gridChooser");
                    CANCEL = new Button("ctl00_phL_PanelChooseProjects_PXPanelChooseProjectsCancel", "CANCEL", "ctl00_phL_PanelChooseProjects_gridChooser");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public CheckBox IsPublished { get; }
			public Selector Name { get; }
			public PXTextEdit Description { get; }
                
                public c_grid_row(c_projectschooser_gridchooser grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phL_PanelChooseProjects_gridChooser_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    IsPublished = new CheckBox("ctl00_phL_PanelChooseProjects_gridChooser", "Published", grid.Locator, "IsPublished");
                    IsPublished.DataField = "IsPublished";
                    Name = new Selector("_ctl00_phL_PanelChooseProjects_gridChooser_lv0_es", "Project Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Description = new PXTextEdit("ctl00_phL_PanelChooseProjects_gridChooser_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public CheckBoxColumnFilter IsPublished { get; }
				public SelectorColumnFilter Name { get; }
				public PXTextEditColumnFilter Description { get; }
                
                public c_grid_header(c_projectschooser_gridchooser grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    IsPublished = new CheckBoxColumnFilter(grid.Row.IsPublished);
                    Name = new SelectorColumnFilter(grid.Row.Name);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                }
            }
        }
        
        public class c_projectschooser_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_projectschooser_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phL_PanelChooseProjects_gridChooser_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "ProjectsChooser";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void VALIDATE()
            {
                Buttons.VALIDATE.Click();
            }
            
            public virtual void VALIDATEANDSHOWALLMESSAGES()
            {
                Buttons.VALIDATEANDSHOWALLMESSAGES.Click();
            }
            
            public virtual void CANCEL()
            {
                Buttons.CANCEL.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button VALIDATE { get; }
			public Button VALIDATEANDSHOWALLMESSAGES { get; }
			public Button CANCEL { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phL_PanelChooseProjects_gridChooser_lfFirst0", "First", "ctl00_phL_PanelChooseProjects_gridChooser_lv0");
                    Prev = new Button("ctl00_phL_PanelChooseProjects_gridChooser_lfPrev0", "Prev", "ctl00_phL_PanelChooseProjects_gridChooser_lv0");
                    Next = new Button("ctl00_phL_PanelChooseProjects_gridChooser_lfNext0", "Next", "ctl00_phL_PanelChooseProjects_gridChooser_lv0");
                    Last = new Button("ctl00_phL_PanelChooseProjects_gridChooser_lfLast0", "Last", "ctl00_phL_PanelChooseProjects_gridChooser_lv0");
                    VALIDATE = new Button("ctl00_phL_PanelChooseProjects_PXPanelChooseProjectsOK", "VALIDATE", "ctl00_phL_PanelChooseProjects_gridChooser_lv0");
                    VALIDATEANDSHOWALLMESSAGES = new Button("ctl00_phL_PanelChooseProjects_PXPanelChooseProjectsAllMessagesOK", "VALIDATE AND SHOW ALL MESSAGES", "ctl00_phL_PanelChooseProjects_gridChooser_lv0");
                    CANCEL = new Button("ctl00_phL_PanelChooseProjects_PXPanelChooseProjectsCancel", "CANCEL", "ctl00_phL_PanelChooseProjects_gridChooser_lv0");
                }
            }
        }
        
        public class c_viewpublishoptions_viewpublishoptions : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox PublishOnlyDB { get; }
			public Label PublishOnlyDBLabel { get; }
			public CheckBox DisableOptimization { get; }
			public Label DisableOptimizationLabel { get; }
            
            public c_viewpublishoptions_viewpublishoptions(string locator, string name) : 
                    base(locator, name)
            {
                PublishOnlyDB = new CheckBox("ctl00_phL_PanelPublishExt_ViewPublishOptions_PublishOnlyDB", "Apply Changes Only to Database (Skip Website Update)", locator, null);
                PublishOnlyDBLabel = new Label(PublishOnlyDB);
                PublishOnlyDB.DataField = "PublishOnlyDB";
                DisableOptimization = new CheckBox("ctl00_phL_PanelPublishExt_ViewPublishOptions_DisableOptimization", "Execute All Database Scripts (Including Previously Executed)", locator, null);
                DisableOptimizationLabel = new Label(DisableOptimization);
                DisableOptimization.DataField = "DisableOptimization";
                DataMemberName = "ViewPublishOptions";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfFirst0", "First", "ctl00_phL_PanelPublishExt_ViewPublishOptions");
                    Prev = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfPrev0", "Prev", "ctl00_phL_PanelPublishExt_ViewPublishOptions");
                    Next = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfNext0", "Next", "ctl00_phL_PanelPublishExt_ViewPublishOptions");
                    Last = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfLast0", "Last", "ctl00_phL_PanelPublishExt_ViewPublishOptions");
                    Ok = new Button("ctl00_phL_PanelPublishExt_PXButton5", "OK", "ctl00_phL_PanelPublishExt_ViewPublishOptions");
                    Cancel = new Button("ctl00_phL_PanelPublishExt_PXButton6", "Cancel", "ctl00_phL_PanelPublishExt_ViewPublishOptions");
                }
            }
        }
        
        public class c_viewcompanylist_gridcompanylist : Grid<c_viewcompanylist_gridcompanylist.c_grid_row, c_viewcompanylist_gridcompanylist.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_viewcompanylist_gridcompanylist(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ViewCompanyList";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfFirst0", "First", "ctl00_phL_PanelPublishExt_GridCompanyList");
                    Prev = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfPrev0", "Prev", "ctl00_phL_PanelPublishExt_GridCompanyList");
                    Next = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfNext0", "Next", "ctl00_phL_PanelPublishExt_GridCompanyList");
                    Last = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfLast0", "Last", "ctl00_phL_PanelPublishExt_GridCompanyList");
                    Ok = new Button("ctl00_phL_PanelPublishExt_PXButton5", "OK", "ctl00_phL_PanelPublishExt_GridCompanyList");
                    Cancel = new Button("ctl00_phL_PanelPublishExt_PXButton6", "Cancel", "ctl00_phL_PanelPublishExt_GridCompanyList");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit Name { get; }
			public PXNumberEdit ID { get; }
			public PXNumberEdit ParentID { get; }
                
                public c_grid_row(c_viewcompanylist_gridcompanylist grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phL_PanelPublishExt_GridCompanyList_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    Name = new PXTextEdit("ctl00_phL_PanelPublishExt_GridCompanyList_ei", "Tenant Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    ID = new PXNumberEdit("ctl00_phL_PanelPublishExt_GridCompanyList_en", "ID", grid.Locator, "ID");
                    ID.DataField = "ID";
                    ParentID = new PXNumberEdit("ctl00_phL_PanelPublishExt_GridCompanyList_en", "Parent ID", grid.Locator, "ParentID");
                    ParentID.DataField = "ParentID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter Name { get; }
				public PXNumberEditColumnFilter ID { get; }
				public PXNumberEditColumnFilter ParentID { get; }
                
                public c_grid_header(c_viewcompanylist_gridcompanylist grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    ID = new PXNumberEditColumnFilter(grid.Row.ID);
                    ParentID = new PXNumberEditColumnFilter(grid.Row.ParentID);
                }
            }
        }
        
        public class c_viewcompanylist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_viewcompanylist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phL_PanelPublishExt_GridCompanyList_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phL_PanelPublishExt_GridCompanyList_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phL_PanelPublishExt_GridCompanyList_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phL_PanelPublishExt_GridCompanyList_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ViewCompanyList";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfFirst0", "First", "ctl00_phL_PanelPublishExt_GridCompanyList_lv0");
                    Prev = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfPrev0", "Prev", "ctl00_phL_PanelPublishExt_GridCompanyList_lv0");
                    Next = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfNext0", "Next", "ctl00_phL_PanelPublishExt_GridCompanyList_lv0");
                    Last = new Button("ctl00_phL_PanelPublishExt_GridCompanyList_lfLast0", "Last", "ctl00_phL_PanelPublishExt_GridCompanyList_lv0");
                    Ok = new Button("ctl00_phL_PanelPublishExt_PXButton5", "OK", "ctl00_phL_PanelPublishExt_GridCompanyList_lv0");
                    Cancel = new Button("ctl00_phL_PanelPublishExt_PXButton6", "Cancel", "ctl00_phL_PanelPublishExt_GridCompanyList_lv0");
                }
            }
        }
        
        public class c_viewvalidateextensions_pxformview4 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public RichTextEdit Messages { get; }
			public Label MessagesLabel { get; }
            
            public c_viewvalidateextensions_pxformview4(string locator, string name) : 
                    base(locator, name)
            {
                Messages = new RichTextEdit("ctl00_phL_PanelValidateExt_PXFormView4_Msg", "Messages", locator, null);
                MessagesLabel = new Label(Messages);
                Messages.DataField = "Messages";
                DataMemberName = "ViewValidateExtensions";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phL_PanelValidateExt_PXButtonValidateOK", "OK", "ctl00_phL_PanelValidateExt_PXFormView4");
                }
            }
        }
        
        public class c_filterpreview_formpreview : Container
        {
            
            public PxButtonCollection Buttons;
            
            public c_filterpreview_formpreview(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "FilterPreview";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonOK", "OK", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                    Cancel = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonCancel", "Cancel", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                }
            }
        }
    }
}
