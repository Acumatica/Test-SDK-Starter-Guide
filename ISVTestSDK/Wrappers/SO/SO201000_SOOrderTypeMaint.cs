using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ISVTestSDK.Extensions
{
    
    
    public class SO201000_SOOrderTypeMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_soordertype_form Soordertype_form { get; } = new c_soordertype_form("ctl00_phF_form", "soordertype_form");
        protected c_soordertype_hiddenform Soordertype_hiddenform { get; } = new c_soordertype_hiddenform("ctl00_phF_hiddenForm", "soordertype_hiddenForm");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_profilerinfoview_formprofiler ProfilerInfoView_formProfiler { get; } = new c_profilerinfoview_formprofiler("ctl00_usrCaption_pnlProfiler_formProfiler", "ProfilerInfoView_formProfiler");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_currentordertype_tab Currentordertype_tab { get; } = new c_currentordertype_tab("ctl00_phG_tab", "currentordertype_tab");
        protected c_operations_grid Operations_grid { get; } = new c_operations_grid("ctl00_phG_tab_t1_grid", "operations_grid");
        protected c_operations_lv0 Operations_lv0 { get; } = new c_operations_lv0("ctl00_phG_tab_t1_grid_lv0", "operations_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public SO201000_SOOrderTypeMaint()
        {
            ScreenId = "SO201000";
            ScreenUrl = "/Pages/SO/SO201000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual SO201000_SOOrderTypeMaint ReadOne(Gate gate, string OrderType)
        {
            new BiObject<SO201000_SOOrderTypeMaint>(gate).ReadOne(this, OrderType);
            return this;
        }
        
        public virtual SO201000_SOOrderTypeMaint ReadOne(string OrderType)
        {
            return this.ReadOne(ApiConnection.Source, OrderType);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Note()
        {
            ToolBar.Note.Click();
        }
        
        public virtual void ActivityShow()
        {
            ToolBar.ActivityShow.Click();
        }
        
        public virtual void FilesMenuShow()
        {
            ToolBar.FilesMenuShow.Click();
        }
        
        public virtual void Custom()
        {
            ToolBar.Custom.Click();
        }
        
        public virtual void ActionSelectWorkingProject()
        {
            ToolBar.ActionSelectWorkingProject.Click();
        }
        
        public virtual void InspectElementCtrlAltClick()
        {
            ToolBar.InspectElementCtrlAltClick.Click();
        }
        
        public virtual void MenuEditProj()
        {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations()
        {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void KeyBtnRefresh()
        {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help()
        {
            ToolBar.Help.Click();
        }
        
        public virtual void CancelClose()
        {
            ToolBar.CancelClose.Click();
        }
        
        public virtual void SaveClose()
        {
            ToolBar.SaveClose.Click();
        }
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Insert()
        {
            ToolBar.Insert.Click();
        }
        
        public virtual void Delete()
        {
            ToolBar.Delete.Click();
        }
        
        public virtual void CopyPaste()
        {
            ToolBar.CopyPaste.Click();
        }
        
        public virtual void CopyDocument()
        {
            ToolBar.CopyDocument.Click();
        }
        
        public virtual void PasteDocument()
        {
            ToolBar.PasteDocument.Click();
        }
        
        public virtual void SaveTemplate()
        {
            ToolBar.SaveTemplate.Click();
        }
        
        public virtual void First()
        {
            ToolBar.First.Click();
        }
        
        public virtual void Previous()
        {
            ToolBar.Previous.Click();
        }
        
        public virtual void Next()
        {
            ToolBar.Next.Click();
        }
        
        public virtual void Last()
        {
            ToolBar.Last.Click();
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
			public ToolBarButton Note { get; }
			public ToolBarButton ActivityShow { get; }
			public ToolBarButton FilesMenuShow { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton CancelClose { get; }
			public ToolBarButton SaveClose { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Insert { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton CopyPaste { get; }
			public ToolBarButton CopyDocument { get; }
			public ToolBarButton PasteDocument { get; }
			public ToolBarButton SaveTemplate { get; }
			public ToolBarButton First { get; }
			public ToolBarButton Previous { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton Last { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton LongrunCancel { get; }
			public ToolBarButton LongrunTimer { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
                ActivityShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'ActivityShow\']", "Activities", locator, null);
                FilesMenuShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'FilesMenuShow\']", "Files", locator, null);
                Custom = new ToolBarButton("css=#ctl00_usrCaption_CustomizationDialogs_PXToolBar1 div[data-cmd=\'Custom\']", "Customization", locator, null);
                ActionSelectWorkingProject = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ActionSelectWorkingProject\']", "Select Project...", locator, Custom);
                InspectElementCtrlAltClick = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Inspect Element (Ctrl+Alt+Click)\")", "Inspect Element (Ctrl+Alt+Click)", locator, Custom);
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "menuEditProj\']", "Edit Project...", locator, Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Manage Customizations...\")", "Manage Customizations...", locator, Custom);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Tools", locator, null);
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CancelClose", "Discard Changes and Close", locator, null);
                CancelClose.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SaveClose", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Insert", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Delete", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current Order Type record will be deleted.");
                CopyPaste = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CopyPaste", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@CopyDocument\']", "CopyDocument", locator, CopyPaste);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@PasteDocument\']", "PasteDocument", locator, CopyPaste);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@SaveTemplate\']", "SaveTemplate", locator, CopyPaste);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_soordertype_form : Container
        {
            
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
			public Selector Template { get; }
			public Label TemplateLabel { get; }
            
            public c_soordertype_form(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new Selector("ctl00_phF_form_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                Active = new CheckBox("ctl00_phF_form_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                Descr = new InputLocalizable("ctl00_phF_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                Template = new Selector("ctl00_phF_form_edTemplate", "Order Template", locator, null);
                TemplateLabel = new Label(Template);
                Template.DataField = "Template";
                DataMemberName = "soordertype";
            }
        }
        
        public class c_soordertype_hiddenform : Container
        {
            
			public CheckBox AllowQuickProcess { get; }
			public Label AllowQuickProcessLabel { get; }
            
            public c_soordertype_hiddenform(string locator, string name) : 
                    base(locator, name)
            {
                AllowQuickProcess = new CheckBox("ctl00_phF_hiddenForm_chkAllowQuickProcess", "Allow Quick Process", locator, null);
                AllowQuickProcessLabel = new Label(AllowQuickProcess);
                AllowQuickProcess.DataField = "AllowQuickProcess";
                DataMemberName = "soordertype";
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
        
        public class c_firstselect_formactions : Container
        {
            
			public PXTextEdit Key { get; }
			public Label KeyLabel { get; }
            
            public c_firstselect_formactions(string locator, string name) : 
                    base(locator, name)
            {
                Key = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions_edKey", "Key", locator, null);
                KeyLabel = new Label(Key);
                Key.DataField = "Key";
                DataMemberName = "FirstSelect";
            }
        }
        
        public class c_comboboxvalues_gridcombos : Grid<c_comboboxvalues_gridcombos.c_grid_row, c_comboboxvalues_gridcombos.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_comboboxvalues_gridcombos(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos");
                DataMemberName = "ComboBoxValues";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_fe_gf", "FilterForm");
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
            
            public virtual void Close()
            {
                Buttons.Close.Click();
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
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    Close = new Button("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_PXButton5", "Close", "ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Value { get; }
			public PXTextEdit Description { get; }
                
                public c_grid_row(c_comboboxvalues_gridcombos grid) : 
                        base(grid)
                {
                    Value = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Description = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Description { get; }
                
                public c_grid_header(c_comboboxvalues_gridcombos grid) : 
                        base(grid)
                {
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                }
            }
        }
        
        public class c_vieweleminfo_formeleminfo : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AspxControl { get; }
			public Label AspxControlLabel { get; }
			public GroupBox IsComboBox { get; }
			public Label IsComboBoxLabel { get; }
			public PXTextEdit CacheType { get; }
			public Label CacheTypeLabel { get; }
			public PXTextEdit FieldName { get; }
			public Label FieldNameLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit GraphName { get; }
			public Label GraphNameLabel { get; }
			public PXTextEdit ActionName { get; }
			public Label ActionNameLabel { get; }
            
            public c_vieweleminfo_formeleminfo(string locator, string name) : 
                    base(locator, name)
            {
                AspxControl = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_edAspxControl", "Control Type", locator, null);
                AspxControlLabel = new Label(AspxControl);
                AspxControl.DataField = "AspxControl";
                IsComboBox = new GroupBox("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1", "Is Combo Box", locator, null);
                IsComboBoxLabel = new Label(IsComboBox);
                IsComboBox.DataField = "IsComboBox";
                CacheType = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_CacheType", "Data Class", locator, null);
                CacheTypeLabel = new Label(CacheType);
                CacheType.DataField = "CacheType";
                FieldName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_FieldName", "Data Field", locator, null);
                FieldNameLabel = new Label(FieldName);
                FieldName.DataField = "FieldName";
                ViewName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ViewName", "View Name", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                GraphName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_GraphName", "Business Logic", locator, null);
                GraphNameLabel = new Label(GraphName);
                GraphName.DataField = "GraphName";
                ActionName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ActionName", "Action Name", locator, null);
                ActionNameLabel = new Label(ActionName);
                ActionName.DataField = "ActionName";
                DataMemberName = "ViewElemInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Drop_downValues()
            {
                Buttons.Drop_downValues.Click();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.Click();
            }
            
            public virtual void Actions()
            {
                Buttons.Actions.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Drop_downValues { get; }
			public Button Customize { get; }
			public Button Actions { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Drop_downValues = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1_P" +
                            "XButton1", "Drop-down Values", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Customize = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton3", "Customize", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Actions = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_ButtonGraphActions", "Actions", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton4", "Cancel", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                }
            }
        }
        
        public class c_filterworkingproject_formnewproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NewProject { get; }
			public Label NewProjectLabel { get; }
            
            public c_filterworkingproject_formnewproject(string locator, string name) : 
                    base(locator, name)
            {
                NewProject = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject_edNewProject", "Project Name", locator, null);
                NewProjectLabel = new Label(NewProject);
                NewProject.DataField = "NewProject";
                DataMemberName = "FilterWorkingProject";
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
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonOk", "OK", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                }
            }
        }
        
        public class c_filterworkingproject_formselectproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Name { get; }
			public Label NameLabel { get; }
            
            public c_filterworkingproject_formselectproject(string locator, string name) : 
                    base(locator, name)
            {
                Name = new Selector("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject_edWP", "Project Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                DataMemberName = "FilterWorkingProject";
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
            
            public virtual void New()
            {
                Buttons.New.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button New { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectOk", "OK", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    New = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_BtnNewProject", "New...", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
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
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
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
        
        public class c_currentordertype_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderNumberingID { get; }
			public Label OrderNumberingIDLabel { get; }
			public PXNumberEdit DaysToKeep { get; }
			public Label DaysToKeepLabel { get; }
			public CheckBox HoldEntry { get; }
			public Label HoldEntryLabel { get; }
			public CheckBox CreditHoldEntry { get; }
			public Label CreditHoldEntryLabel { get; }
			public CheckBox RequireControlTotal { get; }
			public Label RequireControlTotalLabel { get; }
			public CheckBox BillSeparately { get; }
			public Label BillSeparatelyLabel { get; }
			public CheckBox ShipSeparately { get; }
			public Label ShipSeparatelyLabel { get; }
			public CheckBox CalculateFreight { get; }
			public Label CalculateFreightLabel { get; }
			public CheckBox ShipFullIfNegQtyAllowed { get; }
			public Label ShipFullIfNegQtyAllowedLabel { get; }
			public CheckBox DisableAutomaticDiscountCalculation { get; }
			public Label DisableAutomaticDiscountCalculationLabel { get; }
			public CheckBox RecalculateDiscOnPartialShipment { get; }
			public Label RecalculateDiscOnPartialShipmentLabel { get; }
			public CheckBox AllowRefundBeforeReturn { get; }
			public Label AllowRefundBeforeReturnLabel { get; }
			public CheckBox CopyNotes { get; }
			public Label CopyNotesLabel { get; }
			public CheckBox CopyFiles { get; }
			public Label CopyFilesLabel { get; }
			public CheckBox CopyLineNotesToShipment { get; }
			public Label CopyLineNotesToShipmentLabel { get; }
			public CheckBox CopyLineFilesToShipment { get; }
			public Label CopyLineFilesToShipmentLabel { get; }
			public CheckBox CopyLineNotesToInvoice { get; }
			public Label CopyLineNotesToInvoiceLabel { get; }
			public CheckBox CopyLineNotesToInvoiceOnlyNS { get; }
			public Label CopyLineNotesToInvoiceOnlyNSLabel { get; }
			public CheckBox CopyLineFilesToInvoice { get; }
			public Label CopyLineFilesToInvoiceLabel { get; }
			public CheckBox CopyLineFilesToInvoiceOnlyNS { get; }
			public Label CopyLineFilesToInvoiceOnlyNSLabel { get; }
			public CheckBox CopyLineNotesToChildOrder { get; }
			public Label CopyLineNotesToChildOrderLabel { get; }
			public CheckBox CopyLineFilesToChildOrder { get; }
			public Label CopyLineFilesToChildOrderLabel { get; }
			public CheckBox CustomerOrderIsRequired { get; }
			public Label CustomerOrderIsRequiredLabel { get; }
			public DropDown CustomerOrderValidation { get; }
			public Label CustomerOrderValidationLabel { get; }
			public CheckBox EncryptAndPseudonymizePII { get; }
			public Label EncryptAndPseudonymizePIILabel { get; }
			public Selector InvoiceNumberingID { get; }
			public Label InvoiceNumberingIDLabel { get; }
			public CheckBox MarkInvoicePrinted { get; }
			public Label MarkInvoicePrintedLabel { get; }
			public CheckBox MarkInvoiceEmailed { get; }
			public Label MarkInvoiceEmailedLabel { get; }
			public CheckBox InvoiceHoldEntry { get; }
			public Label InvoiceHoldEntryLabel { get; }
			public CheckBox UseCuryRateFromSO { get; }
			public Label UseCuryRateFromSOLabel { get; }
			public DropDown SalesAcctDefault { get; }
			public Label SalesAcctDefaultLabel { get; }
			public Selector SalesSubMask { get; }
			public Label SalesSubMaskLabel { get; }
			public Selector FreightAcctID { get; }
			public Label FreightAcctIDLabel { get; }
			public DropDown FreightAcctDefault { get; }
			public Label FreightAcctDefaultLabel { get; }
			public Selector FreightSubID { get; }
			public Label FreightSubIDLabel { get; }
			public Selector FreightSubMask { get; }
			public Label FreightSubMaskLabel { get; }
			public Selector DiscountAcctID { get; }
			public Label DiscountAcctIDLabel { get; }
			public DropDown DiscAcctDefault { get; }
			public Label DiscAcctDefaultLabel { get; }
			public Selector DiscountSubID { get; }
			public Label DiscountSubIDLabel { get; }
			public Selector DiscSubMask { get; }
			public Label DiscSubMaskLabel { get; }
			public CheckBox UseShippedNotInvoiced { get; }
			public Label UseShippedNotInvoicedLabel { get; }
			public Selector ShippedNotInvoicedAcctID { get; }
			public Label ShippedNotInvoicedAcctIDLabel { get; }
			public Selector ShippedNotInvoicedSubID { get; }
			public Label ShippedNotInvoicedSubIDLabel { get; }
			public CheckBox PostLineDiscSeparately { get; }
			public Label PostLineDiscSeparatelyLabel { get; }
			public CheckBox UseDiscountSubFromSalesSub { get; }
			public Label UseDiscountSubFromSalesSubLabel { get; }
			public DropDown COGSAcctDefault { get; }
			public Label COGSAcctDefaultLabel { get; }
			public Selector COGSSubMask { get; }
			public Label COGSSubMaskLabel { get; }
			public CheckBox AutoWriteOff { get; }
			public Label AutoWriteOffLabel { get; }
			public DropDown IntercompanySalesAcctDefault { get; }
			public Label IntercompanySalesAcctDefaultLabel { get; }
			public DropDown IntercompanyCOGSAcctDefault { get; }
			public Label IntercompanyCOGSAcctDefaultLabel { get; }
			public CheckBox ValidateCCRefundsOrigTransactions { get; }
			public Label ValidateCCRefundsOrigTransactionsLabel { get; }
			public Selector DfltChildOrderType { get; }
			public Label DfltChildOrderTypeLabel { get; }
			public CheckBox UseCuryRateFromBL { get; }
			public Label UseCuryRateFromBLLabel { get; }
			public CheckBox EnableFSIntegration { get; }
			public Label EnableFSIntegrationLabel { get; }
			public CheckBox AMProductionOrderEntry { get; }
			public Label AMProductionOrderEntryLabel { get; }
			public CheckBox AMProductionOrderEntryOnHold { get; }
			public Label AMProductionOrderEntryOnHoldLabel { get; }
			public CheckBox AMEstimateEntry { get; }
			public Label AMEstimateEntryLabel { get; }
			public CheckBox AMConfigurationEntry { get; }
			public Label AMConfigurationEntryLabel { get; }
			public CheckBox AMEnableWarehouseLinkedProduction { get; }
			public Label AMEnableWarehouseLinkedProductionLabel { get; }
			public CheckBox AMMTOOrder { get; }
			public Label AMMTOOrderLabel { get; }
			public DropDown Behavior { get; }
			public Label BehaviorLabel { get; }
			public DropDown DefaultOperation { get; }
			public Label DefaultOperationLabel { get; }
			public DropDown ARDocType { get; }
			public Label ARDocTypeLabel { get; }
			public CheckBox RequireShipping { get; }
			public Label RequireShippingLabel { get; }
			public CheckBox RequireLotSerial { get; }
			public Label RequireLotSerialLabel { get; }
			public CheckBox RequireAllocation { get; }
			public Label RequireAllocationLabel { get; }
			public CheckBox AllowQuickProcess { get; }
			public Label AllowQuickProcessLabel { get; }
			public CheckBox AutoRedirect { get; }
			public Label AutoRedirectLabel { get; }
			public CheckBox AutoDownloadReports { get; }
			public Label AutoDownloadReportsLabel { get; }
			public CheckBox CreateShipment { get; }
			public Label CreateShipmentLabel { get; }
			public CheckBox PrintPickList { get; }
			public Label PrintPickListLabel { get; }
			public CheckBox ConfirmShipment { get; }
			public Label ConfirmShipmentLabel { get; }
			public CheckBox PrintLabels { get; }
			public Label PrintLabelsLabel { get; }
			public CheckBox PrintConfirmation { get; }
			public Label PrintConfirmationLabel { get; }
			public CheckBox UpdateIN { get; }
			public Label UpdateINLabel { get; }
			public CheckBox PrepareInvoiceFromShipment { get; }
			public Label PrepareInvoiceFromShipmentLabel { get; }
			public CheckBox PrepareInvoice { get; }
			public Label PrepareInvoiceLabel { get; }
			public CheckBox PrintInvoice { get; }
			public Label PrintInvoiceLabel { get; }
			public CheckBox EmailInvoice { get; }
			public Label EmailInvoiceLabel { get; }
			public CheckBox ReleaseInvoice { get; }
			public Label ReleaseInvoiceLabel { get; }
			public CheckBox PrintWithDeviceHub { get; }
			public Label PrintWithDeviceHubLabel { get; }
			public CheckBox DefinePrinterManually { get; }
			public Label DefinePrinterManuallyLabel { get; }
			public Selector PrinterID { get; }
			public Label PrinterIDLabel { get; }
			public PXTextEdit NumberOfCopies { get; }
			public Label NumberOfCopiesLabel { get; }
            
            public c_currentordertype_tab(string locator, string name) : 
                    base(locator, name)
            {
                OrderNumberingID = new Selector("ctl00_phG_tab_t0_edOrderNumberingID", "Order Numbering Sequence", locator, null);
                OrderNumberingIDLabel = new Label(OrderNumberingID);
                OrderNumberingID.DataField = "OrderNumberingID";
                DaysToKeep = new PXNumberEdit("ctl00_phG_tab_t0_edDaysToKeep", "Days To Keep", locator, null);
                DaysToKeepLabel = new Label(DaysToKeep);
                DaysToKeep.DataField = "DaysToKeep";
                HoldEntry = new CheckBox("ctl00_phG_tab_t0_chkHoldEntry", "Hold Orders on Entry", locator, null);
                HoldEntryLabel = new Label(HoldEntry);
                HoldEntry.DataField = "HoldEntry";
                CreditHoldEntry = new CheckBox("ctl00_phG_tab_t0_chkCreditHoldEntry", "Hold Document on Failed Credit Check", locator, null);
                CreditHoldEntryLabel = new Label(CreditHoldEntry);
                CreditHoldEntry.DataField = "CreditHoldEntry";
                RequireControlTotal = new CheckBox("ctl00_phG_tab_t0_chkRequireControlTotal", "Require Control Total", locator, null);
                RequireControlTotalLabel = new Label(RequireControlTotal);
                RequireControlTotal.DataField = "RequireControlTotal";
                BillSeparately = new CheckBox("ctl00_phG_tab_t0_chkBillSeparately", "Bill Separately", locator, null);
                BillSeparatelyLabel = new Label(BillSeparately);
                BillSeparately.DataField = "BillSeparately";
                ShipSeparately = new CheckBox("ctl00_phG_tab_t0_chkShipSeparately", "Ship Separately", locator, null);
                ShipSeparatelyLabel = new Label(ShipSeparately);
                ShipSeparately.DataField = "ShipSeparately";
                CalculateFreight = new CheckBox("ctl00_phG_tab_t0_chkCalculateFreight", "Calculate Freight", locator, null);
                CalculateFreightLabel = new Label(CalculateFreight);
                CalculateFreight.DataField = "CalculateFreight";
                ShipFullIfNegQtyAllowed = new CheckBox("ctl00_phG_tab_t0_chkShipFullIfNegQtyAllowed", "Ship in Full if Negative Quantity Is Allowed", locator, null);
                ShipFullIfNegQtyAllowedLabel = new Label(ShipFullIfNegQtyAllowed);
                ShipFullIfNegQtyAllowed.DataField = "ShipFullIfNegQtyAllowed";
                DisableAutomaticDiscountCalculation = new CheckBox("ctl00_phG_tab_t0_chkDisableAutomaticDiscountCalculation", "Disable Automatic Discount Update", locator, null);
                DisableAutomaticDiscountCalculationLabel = new Label(DisableAutomaticDiscountCalculation);
                DisableAutomaticDiscountCalculation.DataField = "DisableAutomaticDiscountCalculation";
                RecalculateDiscOnPartialShipment = new CheckBox("ctl00_phG_tab_t0_chkRecalculateDiscOnPartialShipment", "Recalculate Discount On Partial Shipment", locator, null);
                RecalculateDiscOnPartialShipmentLabel = new Label(RecalculateDiscOnPartialShipment);
                RecalculateDiscOnPartialShipment.DataField = "RecalculateDiscOnPartialShipment";
                AllowRefundBeforeReturn = new CheckBox("ctl00_phG_tab_t0_chkAllowRefundBeforeReturn", "Allow Refund Before Return", locator, null);
                AllowRefundBeforeReturnLabel = new Label(AllowRefundBeforeReturn);
                AllowRefundBeforeReturn.DataField = "AllowRefundBeforeReturn";
                CopyNotes = new CheckBox("ctl00_phG_tab_t0_chkCopyNotes", "Copy Notes", locator, null);
                CopyNotesLabel = new Label(CopyNotes);
                CopyNotes.DataField = "CopyNotes";
                CopyFiles = new CheckBox("ctl00_phG_tab_t0_chkCopyFiles", "Copy Attachments", locator, null);
                CopyFilesLabel = new Label(CopyFiles);
                CopyFiles.DataField = "CopyFiles";
                CopyLineNotesToShipment = new CheckBox("ctl00_phG_tab_t0_chkCopyLineNotesToShipment", "Copy Line Notes To Shipment", locator, null);
                CopyLineNotesToShipmentLabel = new Label(CopyLineNotesToShipment);
                CopyLineNotesToShipment.DataField = "CopyLineNotesToShipment";
                CopyLineFilesToShipment = new CheckBox("ctl00_phG_tab_t0_chkCopyLineFilesToShipment", "Copy Line Attachments To Shipment", locator, null);
                CopyLineFilesToShipmentLabel = new Label(CopyLineFilesToShipment);
                CopyLineFilesToShipment.DataField = "CopyLineFilesToShipment";
                CopyLineNotesToInvoice = new CheckBox("ctl00_phG_tab_t0_chkCopyLineNotesToInvoice", "Copy Line Notes To Invoice", locator, null);
                CopyLineNotesToInvoiceLabel = new Label(CopyLineNotesToInvoice);
                CopyLineNotesToInvoice.DataField = "CopyLineNotesToInvoice";
                CopyLineNotesToInvoiceOnlyNS = new CheckBox("ctl00_phG_tab_t0_chkCopyLineNotesToInvoiceOnlyNS", "Only Non-Stock", locator, null);
                CopyLineNotesToInvoiceOnlyNSLabel = new Label(CopyLineNotesToInvoiceOnlyNS);
                CopyLineNotesToInvoiceOnlyNS.DataField = "CopyLineNotesToInvoiceOnlyNS";
                CopyLineFilesToInvoice = new CheckBox("ctl00_phG_tab_t0_chkCopyLineFilesToInvoice", "Copy Line Attachments To Invoice", locator, null);
                CopyLineFilesToInvoiceLabel = new Label(CopyLineFilesToInvoice);
                CopyLineFilesToInvoice.DataField = "CopyLineFilesToInvoice";
                CopyLineFilesToInvoiceOnlyNS = new CheckBox("ctl00_phG_tab_t0_chkCopyLineFilesToInvoiceOnlyNS", "Only Non-Stock", locator, null);
                CopyLineFilesToInvoiceOnlyNSLabel = new Label(CopyLineFilesToInvoiceOnlyNS);
                CopyLineFilesToInvoiceOnlyNS.DataField = "CopyLineFilesToInvoiceOnlyNS";
                CopyLineNotesToChildOrder = new CheckBox("ctl00_phG_tab_t0_chkCopyLineNotesToChildOrder", "Copy Line Notes To Child Order", locator, null);
                CopyLineNotesToChildOrderLabel = new Label(CopyLineNotesToChildOrder);
                CopyLineNotesToChildOrder.DataField = "CopyLineNotesToChildOrder";
                CopyLineFilesToChildOrder = new CheckBox("ctl00_phG_tab_t0_chkCopyLineFilesToChildOrder", "Copy Line Attachments To Child Order", locator, null);
                CopyLineFilesToChildOrderLabel = new Label(CopyLineFilesToChildOrder);
                CopyLineFilesToChildOrder.DataField = "CopyLineFilesToChildOrder";
                CustomerOrderIsRequired = new CheckBox("ctl00_phG_tab_t0_chkCustomerOrderIsRequired", "Require Customer Order Nbr.", locator, null);
                CustomerOrderIsRequiredLabel = new Label(CustomerOrderIsRequired);
                CustomerOrderIsRequired.DataField = "CustomerOrderIsRequired";
                CustomerOrderValidation = new DropDown("ctl00_phG_tab_t0_edCustomerOrderValidation", "Customer Order Nbr. Validation", locator, null);
                CustomerOrderValidationLabel = new Label(CustomerOrderValidation);
                CustomerOrderValidation.DataField = "CustomerOrderValidation";
                CustomerOrderValidation.Items.Add("N", "Allow Duplicates");
                CustomerOrderValidation.Items.Add("W", "Warn About Duplicates");
                CustomerOrderValidation.Items.Add("E", "Forbid Duplicates");
                EncryptAndPseudonymizePII = new CheckBox("ctl00_phG_tab_t0_chkEncryptAndPseudonymizePII", "Protect Personal Data", locator, null);
                EncryptAndPseudonymizePIILabel = new Label(EncryptAndPseudonymizePII);
                EncryptAndPseudonymizePII.DataField = "EncryptAndPseudonymizePII";
                InvoiceNumberingID = new Selector("ctl00_phG_tab_t0_edInvoiceNumberingID", "Invoice Numbering Sequence", locator, null);
                InvoiceNumberingIDLabel = new Label(InvoiceNumberingID);
                InvoiceNumberingID.DataField = "InvoiceNumberingID";
                MarkInvoicePrinted = new CheckBox("ctl00_phG_tab_t0_chkMarkInvoicePrinted", "Mark as Printed", locator, null);
                MarkInvoicePrintedLabel = new Label(MarkInvoicePrinted);
                MarkInvoicePrinted.DataField = "MarkInvoicePrinted";
                MarkInvoiceEmailed = new CheckBox("ctl00_phG_tab_t0_edMarkInvoiceEmailed", "Mark as Emailed", locator, null);
                MarkInvoiceEmailedLabel = new Label(MarkInvoiceEmailed);
                MarkInvoiceEmailed.DataField = "MarkInvoiceEmailed";
                InvoiceHoldEntry = new CheckBox("ctl00_phG_tab_t0_edInvoiceHoldEntry", "Hold Invoices on Entry", locator, null);
                InvoiceHoldEntryLabel = new Label(InvoiceHoldEntry);
                InvoiceHoldEntry.DataField = "InvoiceHoldEntry";
                UseCuryRateFromSO = new CheckBox("ctl00_phG_tab_t0_edUseCuryRateFromSO", "Use Currency Rate from Sales Order", locator, null);
                UseCuryRateFromSOLabel = new Label(UseCuryRateFromSO);
                UseCuryRateFromSO.DataField = "UseCuryRateFromSO";
                SalesAcctDefault = new DropDown("ctl00_phG_tab_t0_edSalesAcctDefault", "Use Sales Account from", locator, null);
                SalesAcctDefaultLabel = new Label(SalesAcctDefault);
                SalesAcctDefault.DataField = "SalesAcctDefault";
                SalesAcctDefault.Items.Add("I", "Inventory Item");
                SalesAcctDefault.Items.Add("W", "Warehouse");
                SalesAcctDefault.Items.Add("P", "Posting Class");
                SalesAcctDefault.Items.Add("L", "Customer Location");
                SalesAcctDefault.Items.Add("R", "Reason Code");
                SalesSubMask = new Selector("ctl00_phG_tab_t0_edSalesSubMask", "Combine Sales Sub. From", locator, null);
                SalesSubMaskLabel = new Label(SalesSubMask);
                SalesSubMask.DataField = "SalesSubMask";
                FreightAcctID = new Selector("ctl00_phG_tab_t0_edFreightAcctID", "Freight Account", locator, null);
                FreightAcctIDLabel = new Label(FreightAcctID);
                FreightAcctID.DataField = "FreightAcctID";
                FreightAcctDefault = new DropDown("ctl00_phG_tab_t0_edFreightAcctDefault", "Use Freight Account from", locator, null);
                FreightAcctDefaultLabel = new Label(FreightAcctDefault);
                FreightAcctDefault.DataField = "FreightAcctDefault";
                FreightAcctDefault.Items.Add("T", "Order Type");
                FreightAcctDefault.Items.Add("L", "Customer Location");
                FreightAcctDefault.Items.Add("V", "Ship Via");
                FreightSubID = new Selector("ctl00_phG_tab_t0_edFreightSubID", "Freight Sub.", locator, null);
                FreightSubIDLabel = new Label(FreightSubID);
                FreightSubID.DataField = "FreightSubID";
                FreightSubMask = new Selector("ctl00_phG_tab_t0_edFreightSubMask", "Combine Freight Sub. from", locator, null);
                FreightSubMaskLabel = new Label(FreightSubMask);
                FreightSubMask.DataField = "FreightSubMask";
                DiscountAcctID = new Selector("ctl00_phG_tab_t0_edDiscountAcctID", "Discount Account", locator, null);
                DiscountAcctIDLabel = new Label(DiscountAcctID);
                DiscountAcctID.DataField = "DiscountAcctID";
                DiscAcctDefault = new DropDown("ctl00_phG_tab_t0_edDiscAcctDefault", "Use Discount Account from", locator, null);
                DiscAcctDefaultLabel = new Label(DiscAcctDefault);
                DiscAcctDefault.DataField = "DiscAcctDefault";
                DiscAcctDefault.Items.Add("T", "Order Type");
                DiscAcctDefault.Items.Add("L", "Customer Location");
                DiscountSubID = new Selector("ctl00_phG_tab_t0_edDiscountSubID", "Discount Sub.", locator, null);
                DiscountSubIDLabel = new Label(DiscountSubID);
                DiscountSubID.DataField = "DiscountSubID";
                DiscSubMask = new Selector("ctl00_phG_tab_t0_edDiscSubMask", "Combine Discount Sub. from", locator, null);
                DiscSubMaskLabel = new Label(DiscSubMask);
                DiscSubMask.DataField = "DiscSubMask";
                UseShippedNotInvoiced = new CheckBox("ctl00_phG_tab_t0_chkUseShippedNotInvoiced", "Use Shipped-Not-Invoiced Account", locator, null);
                UseShippedNotInvoicedLabel = new Label(UseShippedNotInvoiced);
                UseShippedNotInvoiced.DataField = "UseShippedNotInvoiced";
                ShippedNotInvoicedAcctID = new Selector("ctl00_phG_tab_t0_edShippedNotInvoicedAcctID", "Shipped-Not-Invoiced Account", locator, null);
                ShippedNotInvoicedAcctIDLabel = new Label(ShippedNotInvoicedAcctID);
                ShippedNotInvoicedAcctID.DataField = "ShippedNotInvoicedAcctID";
                ShippedNotInvoicedSubID = new Selector("ctl00_phG_tab_t0_edShippedNotInvoicedSubID", "Shipped-Not-Invoiced Sub.", locator, null);
                ShippedNotInvoicedSubIDLabel = new Label(ShippedNotInvoicedSubID);
                ShippedNotInvoicedSubID.DataField = "ShippedNotInvoicedSubID";
                PostLineDiscSeparately = new CheckBox("ctl00_phG_tab_t0_chkPostLineDiscSeparately", "Post Line Discounts Separately", locator, null);
                PostLineDiscSeparatelyLabel = new Label(PostLineDiscSeparately);
                PostLineDiscSeparately.DataField = "PostLineDiscSeparately";
                UseDiscountSubFromSalesSub = new CheckBox("ctl00_phG_tab_t0_chkUseDiscountSubFromSalesSub", "Use Discount Sub. from Sales Sub.", locator, null);
                UseDiscountSubFromSalesSubLabel = new Label(UseDiscountSubFromSalesSub);
                UseDiscountSubFromSalesSub.DataField = "UseDiscountSubFromSalesSub";
                COGSAcctDefault = new DropDown("ctl00_phG_tab_t0_edCOGSAcctDefault", "Use COGS Account from", locator, null);
                COGSAcctDefaultLabel = new Label(COGSAcctDefault);
                COGSAcctDefault.DataField = "COGSAcctDefault";
                COGSAcctDefault.Items.Add("I", "Inventory Item");
                COGSAcctDefault.Items.Add("W", "Warehouse");
                COGSAcctDefault.Items.Add("P", "Posting Class");
                COGSAcctDefault.Items.Add("L", "Customer Location");
                COGSSubMask = new Selector("ctl00_phG_tab_t0_edCOGSSubMask", "Combine COGS Sub. From", locator, null);
                COGSSubMaskLabel = new Label(COGSSubMask);
                COGSSubMask.DataField = "COGSSubMask";
                AutoWriteOff = new CheckBox("ctl00_phG_tab_t0_chkAutoWriteOff", "Auto Write-Off", locator, null);
                AutoWriteOffLabel = new Label(AutoWriteOff);
                AutoWriteOff.DataField = "AutoWriteOff";
                IntercompanySalesAcctDefault = new DropDown("ctl00_phG_tab_t0_edIntercompanySalesAcctDefault", "Use Sales Account from", locator, null);
                IntercompanySalesAcctDefaultLabel = new Label(IntercompanySalesAcctDefault);
                IntercompanySalesAcctDefault.DataField = "IntercompanySalesAcctDefault";
                IntercompanySalesAcctDefault.Items.Add("I", "Inventory Item");
                IntercompanySalesAcctDefault.Items.Add("L", "Customer Location");
                IntercompanyCOGSAcctDefault = new DropDown("ctl00_phG_tab_t0_edIntercomapnyCOGSAcctDefault", "Use COGS Account from", locator, null);
                IntercompanyCOGSAcctDefaultLabel = new Label(IntercompanyCOGSAcctDefault);
                IntercompanyCOGSAcctDefault.DataField = "IntercompanyCOGSAcctDefault";
                IntercompanyCOGSAcctDefault.Items.Add("I", "Inventory Item");
                IntercompanyCOGSAcctDefault.Items.Add("L", "Customer");
                ValidateCCRefundsOrigTransactions = new CheckBox("ctl00_phG_tab_t0_chkValidateCCRefundsOrigTransactions", "Validate Card Refunds Against Original Transactions", locator, null);
                ValidateCCRefundsOrigTransactionsLabel = new Label(ValidateCCRefundsOrigTransactions);
                ValidateCCRefundsOrigTransactions.DataField = "ValidateCCRefundsOrigTransactions";
                DfltChildOrderType = new Selector("ctl00_phG_tab_t0_edDfltChildOrderType", "Default Child Order Type", locator, null);
                DfltChildOrderTypeLabel = new Label(DfltChildOrderType);
                DfltChildOrderType.DataField = "DfltChildOrderType";
                UseCuryRateFromBL = new CheckBox("ctl00_phG_tab_t0_chkUseCuryRateFromBL", "Use Currency Rate from Blanket Sales Order", locator, null);
                UseCuryRateFromBLLabel = new Label(UseCuryRateFromBL);
                UseCuryRateFromBL.DataField = "UseCuryRateFromBL";
                EnableFSIntegration = new CheckBox("ctl00_phG_tab_t0_chkEnableFSIntegration", "Enable Field Services Integration", locator, null);
                EnableFSIntegrationLabel = new Label(EnableFSIntegration);
                EnableFSIntegration.DataField = "EnableFSIntegration";
                AMProductionOrderEntry = new CheckBox("ctl00_phG_tab_t0_edAMProductionOrderEntry", "Allow Production Orders - Approved", locator, null);
                AMProductionOrderEntryLabel = new Label(AMProductionOrderEntry);
                AMProductionOrderEntry.DataField = "AMProductionOrderEntry";
                AMProductionOrderEntryOnHold = new CheckBox("ctl00_phG_tab_t0_edAMProductionOrderEntryOnHold", "Allow Production Orders - Hold", locator, null);
                AMProductionOrderEntryOnHoldLabel = new Label(AMProductionOrderEntryOnHold);
                AMProductionOrderEntryOnHold.DataField = "AMProductionOrderEntryOnHold";
                AMEstimateEntry = new CheckBox("ctl00_phG_tab_t0_edAMEstimateEntry", "Allow Estimating", locator, null);
                AMEstimateEntryLabel = new Label(AMEstimateEntry);
                AMEstimateEntry.DataField = "AMEstimateEntry";
                AMConfigurationEntry = new CheckBox("ctl00_phG_tab_t0_chkAMConfigurationEntry", "Allow Configuration Entry", locator, null);
                AMConfigurationEntryLabel = new Label(AMConfigurationEntry);
                AMConfigurationEntry.DataField = "AMConfigurationEntry";
                AMEnableWarehouseLinkedProduction = new CheckBox("ctl00_phG_tab_t0_edAMEnableWarehouseLinkedProduction", "Enable Warehouse On Line With Linked Production", locator, null);
                AMEnableWarehouseLinkedProductionLabel = new Label(AMEnableWarehouseLinkedProduction);
                AMEnableWarehouseLinkedProduction.DataField = "AMEnableWarehouseLinkedProduction";
                AMMTOOrder = new CheckBox("ctl00_phG_tab_t0_edAMMTOOrder", "MTO Order", locator, null);
                AMMTOOrderLabel = new Label(AMMTOOrder);
                AMMTOOrder.DataField = "AMMTOOrder";
                Behavior = new DropDown("ctl00_phG_tab_t1_edBehavior", "Automation Behavior", locator, null);
                BehaviorLabel = new Label(Behavior);
                Behavior.DataField = "Behavior";
                Behavior.Items.Add("SO", "Sales Order");
                Behavior.Items.Add("TR", "Transfer Order");
                Behavior.Items.Add("IN", "Invoice");
                Behavior.Items.Add("QT", "Quote");
                Behavior.Items.Add("CM", "Credit Memo");
                Behavior.Items.Add("RM", "RMA Order");
                Behavior.Items.Add("BL", "Blanket Order");
                DefaultOperation = new DropDown("ctl00_phG_tab_t1_edDefaultOperation", "Default Operation", locator, null);
                DefaultOperationLabel = new Label(DefaultOperation);
                DefaultOperation.DataField = "DefaultOperation";
                DefaultOperation.Items.Add("I", "Issue");
                DefaultOperation.Items.Add("R", "Receipt");
                ARDocType = new DropDown("ctl00_phG_tab_t1_edARDocType", "AR Document Type", locator, null);
                ARDocTypeLabel = new Label(ARDocType);
                ARDocType.DataField = "ARDocType";
                ARDocType.Items.Add("INV", "Invoice");
                ARDocType.Items.Add("DRM", "Debit Memo");
                ARDocType.Items.Add("CRM", "Credit Memo");
                ARDocType.Items.Add("CSL", "Cash Sale");
                ARDocType.Items.Add("RCS", "Cash Return");
                ARDocType.Items.Add("UND", "No Update");
                RequireShipping = new CheckBox("ctl00_phG_tab_t1_chkRequireShipping", "Process Shipments", locator, null);
                RequireShippingLabel = new Label(RequireShipping);
                RequireShipping.DataField = "RequireShipping";
                RequireLotSerial = new CheckBox("ctl00_phG_tab_t1_chkRequireLotSerial", "Require Lot/Serial Entry", locator, null);
                RequireLotSerialLabel = new Label(RequireLotSerial);
                RequireLotSerial.DataField = "RequireLotSerial";
                RequireAllocation = new CheckBox("ctl00_phG_tab_t1_chkRequireAllocation", "Require Stock Allocation", locator, null);
                RequireAllocationLabel = new Label(RequireAllocation);
                RequireAllocation.DataField = "RequireAllocation";
                AllowQuickProcess = new CheckBox("ctl00_phG_tab_t1_chkAllowQuickProcess", "Allow Quick Process", locator, null);
                AllowQuickProcessLabel = new Label(AllowQuickProcess);
                AllowQuickProcess.DataField = "AllowQuickProcess";
                AutoRedirect = new CheckBox("ctl00_phG_tab_t2_chkAutoRedirect", "Open All Created Documents in New Tabs", locator, null);
                AutoRedirectLabel = new Label(AutoRedirect);
                AutoRedirect.DataField = "AutoRedirect";
                AutoDownloadReports = new CheckBox("ctl00_phG_tab_t2_chkAutoDownloadReports", "Download All Created Print Forms", locator, null);
                AutoDownloadReportsLabel = new Label(AutoDownloadReports);
                AutoDownloadReports.DataField = "AutoDownloadReports";
                CreateShipment = new CheckBox("ctl00_phG_tab_t2_edCreateShipment", "Create Shipment", locator, null);
                CreateShipmentLabel = new Label(CreateShipment);
                CreateShipment.DataField = "CreateShipment";
                PrintPickList = new CheckBox("ctl00_phG_tab_t2_edPrintPickList", "Print Pick List", locator, null);
                PrintPickListLabel = new Label(PrintPickList);
                PrintPickList.DataField = "PrintPickList";
                ConfirmShipment = new CheckBox("ctl00_phG_tab_t2_edConfirmShipment", "Confirm Shipment", locator, null);
                ConfirmShipmentLabel = new Label(ConfirmShipment);
                ConfirmShipment.DataField = "ConfirmShipment";
                PrintLabels = new CheckBox("ctl00_phG_tab_t2_edPrintLabels", "Print Labels", locator, null);
                PrintLabelsLabel = new Label(PrintLabels);
                PrintLabels.DataField = "PrintLabels";
                PrintConfirmation = new CheckBox("ctl00_phG_tab_t2_edPrintShipmentConfirmation", "Print Shipment Confirmation", locator, null);
                PrintConfirmationLabel = new Label(PrintConfirmation);
                PrintConfirmation.DataField = "PrintConfirmation";
                UpdateIN = new CheckBox("ctl00_phG_tab_t2_edUpdateIN", "Update IN", locator, null);
                UpdateINLabel = new Label(UpdateIN);
                UpdateIN.DataField = "UpdateIN";
                PrepareInvoiceFromShipment = new CheckBox("ctl00_phG_tab_t2_edPrepareInvoiceFromShipment", "Prepare Invoice", locator, null);
                PrepareInvoiceFromShipmentLabel = new Label(PrepareInvoiceFromShipment);
                PrepareInvoiceFromShipment.DataField = "PrepareInvoiceFromShipment";
                PrepareInvoice = new CheckBox("ctl00_phG_tab_t2_edPrepareInvoice", "Prepare Invoice", locator, null);
                PrepareInvoiceLabel = new Label(PrepareInvoice);
                PrepareInvoice.DataField = "PrepareInvoice";
                PrintInvoice = new CheckBox("ctl00_phG_tab_t2_edPrintInvoice", "Print Invoice", locator, null);
                PrintInvoiceLabel = new Label(PrintInvoice);
                PrintInvoice.DataField = "PrintInvoice";
                EmailInvoice = new CheckBox("ctl00_phG_tab_t2_edEmailInvoice", "Email Invoice", locator, null);
                EmailInvoiceLabel = new Label(EmailInvoice);
                EmailInvoice.DataField = "EmailInvoice";
                ReleaseInvoice = new CheckBox("ctl00_phG_tab_t2_edReleaseInvoice", "Release Invoice", locator, null);
                ReleaseInvoiceLabel = new Label(ReleaseInvoice);
                ReleaseInvoice.DataField = "ReleaseInvoice";
                PrintWithDeviceHub = new CheckBox("ctl00_phG_tab_t2_edPrintWithDeviceHub", "Print with DeviceHub", locator, null);
                PrintWithDeviceHubLabel = new Label(PrintWithDeviceHub);
                PrintWithDeviceHub.DataField = "PrintWithDeviceHub";
                DefinePrinterManually = new CheckBox("ctl00_phG_tab_t2_PXDefinePrinterAutomatically", "Define Printers Manually", locator, null);
                DefinePrinterManuallyLabel = new Label(DefinePrinterManually);
                DefinePrinterManually.DataField = "DefinePrinterManually";
                PrinterID = new Selector("ctl00_phG_tab_t2_edPrinterID", "Printer", locator, null);
                PrinterIDLabel = new Label(PrinterID);
                PrinterID.DataField = "PrinterID";
                NumberOfCopies = new PXTextEdit("ctl00_phG_tab_t2_edNumberOfCopies", "Number of Copies", locator, null);
                NumberOfCopiesLabel = new Label(NumberOfCopies);
                NumberOfCopies.DataField = "NumberOfCopies";
                DataMemberName = "currentordertype";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void OrderNumberingIDEdit()
            {
                Buttons.OrderNumberingIDEdit.Click();
            }
            
            public virtual void InvoiceNumberingIDEdit()
            {
                Buttons.InvoiceNumberingIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderNumberingIDEdit { get; }
			public Button InvoiceNumberingIDEdit { get; }
                
                public PxButtonCollection()
                {
                    OrderNumberingIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edOrderNumberingID\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "OrderNumberingIDEdit", "ctl00_phG_tab");
                    OrderNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvoiceNumberingIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edInvoiceNumberingID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "InvoiceNumberingIDEdit", "ctl00_phG_tab");
                    InvoiceNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_operations_grid : Grid<c_operations_grid.c_grid_row, c_operations_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_operations_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_grid");
                DataMemberName = "operations";
                Buttons = new PxButtonCollection();
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
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
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
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t1_grid_lfFirst0", "First", "ctl00_phG_tab_t1_grid");
                    Prev = new Button("ctl00_phG_tab_t1_grid_lfPrev0", "Prev", "ctl00_phG_tab_t1_grid");
                    Next = new Button("ctl00_phG_tab_t1_grid_lfNext0", "Next", "ctl00_phG_tab_t1_grid");
                    Last = new Button("ctl00_phG_tab_t1_grid_lfLast0", "Last", "ctl00_phG_tab_t1_grid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown Operation { get; }
			public CheckBox Active { get; }
			public DropDown INDocType { get; }
			public Selector OrderPlanType { get; }
			public Selector ShipmentPlanType { get; }
			public PXTextEdit OrderType { get; }
			public CheckBox AutoCreateIssueLine { get; }
			public CheckBox RequireReasonCode { get; }
                
                public c_grid_row(c_operations_grid grid) : 
                        base(grid)
                {
                    Operation = new DropDown("_ctl00_phG_tab_t1_grid_lv0_ec", "Operation", grid.Locator, "Operation");
                    Operation.DataField = "Operation";
                    Operation.Items.Add("I", "Issue");
                    Operation.Items.Add("R", "Receipt");
                    Active = new CheckBox("ctl00_phG_tab_t1_grid_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    INDocType = new DropDown("_ctl00_phG_tab_t1_grid_lv0_ec", "Inventory Transaction Type", grid.Locator, "INDocType");
                    INDocType.DataField = "INDocType";
                    INDocType.Items.Add("III", "Issue");
                    INDocType.Items.Add("RET", "Return");
                    INDocType.Items.Add("TRX", "Transfer");
                    INDocType.Items.Add("INV", "Invoice");
                    INDocType.Items.Add("DRM", "Debit Memo");
                    INDocType.Items.Add("CRM", "Credit Memo");
                    INDocType.Items.Add("UND", "No Update");
                    OrderPlanType = new Selector("_ctl00_phG_tab_t1_grid_lv0_edOrderPlanType", "Order Plan Type", grid.Locator, "OrderPlanType");
                    OrderPlanType.DataField = "OrderPlanType";
                    ShipmentPlanType = new Selector("_ctl00_phG_tab_t1_grid_lv0_edShipmentPlanType", "Shipment Plan Type", grid.Locator, "ShipmentPlanType");
                    ShipmentPlanType.DataField = "ShipmentPlanType";
                    OrderType = new PXTextEdit("ctl00_phG_tab_t1_grid_em", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    AutoCreateIssueLine = new CheckBox("ctl00_phG_tab_t1_grid_ef", "Auto Create Issue Line", grid.Locator, "AutoCreateIssueLine");
                    AutoCreateIssueLine.DataField = "AutoCreateIssueLine";
                    RequireReasonCode = new CheckBox("ctl00_phG_tab_t1_grid_ef", "Require Reason Code", grid.Locator, "RequireReasonCode");
                    RequireReasonCode.DataField = "RequireReasonCode";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter Operation { get; }
				public CheckBoxColumnFilter Active { get; }
				public DropDownColumnFilter INDocType { get; }
				public SelectorColumnFilter OrderPlanType { get; }
				public SelectorColumnFilter ShipmentPlanType { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public CheckBoxColumnFilter AutoCreateIssueLine { get; }
				public CheckBoxColumnFilter RequireReasonCode { get; }
                
                public c_grid_header(c_operations_grid grid) : 
                        base(grid)
                {
                    Operation = new DropDownColumnFilter(grid.Row.Operation);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    INDocType = new DropDownColumnFilter(grid.Row.INDocType);
                    OrderPlanType = new SelectorColumnFilter(grid.Row.OrderPlanType);
                    ShipmentPlanType = new SelectorColumnFilter(grid.Row.ShipmentPlanType);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    AutoCreateIssueLine = new CheckBoxColumnFilter(grid.Row.AutoCreateIssueLine);
                    RequireReasonCode = new CheckBoxColumnFilter(grid.Row.RequireReasonCode);
                }
            }
        }
        
        public class c_operations_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderPlanType { get; }
			public Label OrderPlanTypeLabel { get; }
			public Selector ShipmentPlanType { get; }
			public Label ShipmentPlanTypeLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_operations_lv0(string locator, string name) : 
                    base(locator, name)
            {
                OrderPlanType = new Selector("ctl00_phG_tab_t1_grid_lv0_edOrderPlanType", "Order Plan Type", locator, null);
                OrderPlanTypeLabel = new Label(OrderPlanType);
                OrderPlanType.DataField = "OrderPlanType";
                ShipmentPlanType = new Selector("ctl00_phG_tab_t1_grid_lv0_edShipmentPlanType", "Shipment Plan Type", locator, null);
                ShipmentPlanTypeLabel = new Label(ShipmentPlanType);
                ShipmentPlanType.DataField = "ShipmentPlanType";
                Es = new Selector("ctl00_phG_tab_t1_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t1_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t1_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t1_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "operations";
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
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t1_grid_lfFirst0", "First", "ctl00_phG_tab_t1_grid_lv0");
                    Prev = new Button("ctl00_phG_tab_t1_grid_lfPrev0", "Prev", "ctl00_phG_tab_t1_grid_lv0");
                    Next = new Button("ctl00_phG_tab_t1_grid_lfNext0", "Next", "ctl00_phG_tab_t1_grid_lv0");
                    Last = new Button("ctl00_phG_tab_t1_grid_lfLast0", "Last", "ctl00_phG_tab_t1_grid_lv0");
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
