using Controls;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.QuickSearch;
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
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ISVTestSDK.Extensions
{
    
    
    public class IN401000_InventorySummaryEnq : Wrapper
    {
        
        public PxToolBar ToolBar;
        
			public QuickSearch QuickSearch { get; }
        protected c_filter_form Filter_form { get; } = new c_filter_form("ctl00_phF_form", "Filter_form");
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
        protected c_iserecords_grid ISERecords_grid { get; } = new c_iserecords_grid("ctl00_phG_grid", "ISERecords_grid");
        protected c_iserecords_lv0 ISERecords_lv0 { get; } = new c_iserecords_lv0("ctl00_phG_grid_lv0", "ISERecords_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public IN401000_InventorySummaryEnq()
        {
            ScreenId = "IN401000";
            ScreenUrl = "/Pages/IN/IN401000.aspx";
            ToolBar = new PxToolBar(null);
            QuickSearch = new QuickSearch("ctl00_phDS_ds_ToolBar_fb", "QuickSearch", null, null);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
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
        
        public virtual void Refresh()
        {
            ToolBar.Refresh.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Adjust()
        {
            ToolBar.Adjust.Click();
        }
        
        public virtual void Export()
        {
            ToolBar.Export.Click();
        }
        
        public virtual void Filter()
        {
            ToolBar.Filter.Click();
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
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton Refresh { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Adjust { get; }
			public ToolBarButton Export { get; }
			public ToolBarButton Filter { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton LongrunCancel { get; }
			public ToolBarButton LongrunTimer { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
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
                Refresh = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Refresh", "Refresh", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Adjust = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_AdjustColumns", "Fit to Screen", locator, null);
                Export = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ExportExcel", "Export to Excel", locator, null);
                Filter = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_FilterShow", "Filter Settings", locator, null);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_filter_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXBranchSelector OrgBAccountID { get; }
			public Label OrgBAccountIDLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public CheckBox ExpandByLotSerialNbr { get; }
			public Label ExpandByLotSerialNbrLabel { get; }
			public Selector SubItemCD { get; }
			public Label SubItemCDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
            
            public c_filter_form(string locator, string name) : 
                    base(locator, name)
            {
                OrgBAccountID = new PXBranchSelector("ctl00_phF_form_bsOrgBAccountID", "Company/Branch", locator, null);
                OrgBAccountIDLabel = new Label(OrgBAccountID);
                OrgBAccountID.DataField = "OrgBAccountID";
                InventoryID = new Selector("ctl00_phF_form_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                ExpandByLotSerialNbr = new CheckBox("ctl00_phF_form_chkExpandByLotSerialNbr", "Expand by Lot/Serial Number", locator, null);
                ExpandByLotSerialNbrLabel = new Label(ExpandByLotSerialNbr);
                ExpandByLotSerialNbr.DataField = "ExpandByLotSerialNbr";
                SubItemCD = new Selector("ctl00_phF_form_edSubItemCD", "Subitem", locator, null);
                SubItemCDLabel = new Label(SubItemCD);
                SubItemCD.DataField = "SubItemCD";
                SiteID = new Selector("ctl00_phF_form_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LocationID = new Selector("ctl00_phF_form_edLocationID", "Location", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                DataMemberName = "Filter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phF_form_edInventoryID\'] div[class=\'editBtnCont\'] > div > div", "InventoryIDEdit", "ctl00_phF_form");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
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
        
        public class c_iserecords_grid : Grid<c_iserecords_grid.c_grid_row, c_iserecords_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_iserecords_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_grid");
                DataMemberName = "ISERecords";
                FilterForm = new c_grid_filter("ctl00_phG_grid_fe_gf", "FilterForm");
            }
            
            public virtual void AllRecords()
            {
                ToolBar.AllRecords.Click();
            }
            
            public virtual void Edit()
            {
                ToolBar.Edit.Click();
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
                
			public ToolBarButtonGrid AllRecords { get; }
			public ToolBarButtonGrid Edit { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    AllRecords = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div[data-cmd=\'all\']", "All Records", locator, null);
                    Edit = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div[data-cmd=\'edit\']", "Edit", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_grid_at_ft div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector SiteID { get; }
			public PXTextEdit LocationID { get; }
			public PXNumberEdit QtyAvail { get; }
			public PXNumberEdit QtyHardAvail { get; }
			public PXNumberEdit QtyActual { get; }
			public PXNumberEdit QtyNotAvail { get; }
			public PXNumberEdit QtySOPrepared { get; }
			public PXNumberEdit QtySOBooked { get; }
			public PXNumberEdit QtySOShipping { get; }
			public PXNumberEdit QtySOShipped { get; }
			public PXNumberEdit QtySOBackOrdered { get; }
			public PXNumberEdit QtyINIssues { get; }
			public PXNumberEdit QtyINReceipts { get; }
			public PXNumberEdit QtyInTransit { get; }
			public PXNumberEdit QtyInTransitToSO { get; }
			public PXNumberEdit QtyProductionSupplyPrepared { get; }
			public PXNumberEdit QtyProductionSupply { get; }
			public PXNumberEdit QtyProdFixedProdOrdersPrepared { get; }
			public PXNumberEdit QtyProdFixedProdOrders { get; }
			public PXNumberEdit QtyPOFixedProductionPrepared { get; }
			public PXNumberEdit QtyPOFixedProductionOrders { get; }
			public PXNumberEdit QtyProdFixedSalesOrdersPrepared { get; }
			public PXNumberEdit QtyProdFixedSalesOrders { get; }
			public PXNumberEdit QtyProductionDemandPrepared { get; }
			public PXNumberEdit QtyProductionDemand { get; }
			public PXNumberEdit QtyProductionAllocated { get; }
			public PXNumberEdit QtyProdFixedProduction { get; }
			public PXNumberEdit QtyProdFixedPurchase { get; }
			public PXNumberEdit QtySOFixedProduction { get; }
			public PXNumberEdit QtyInAssemblyDemand { get; }
			public PXNumberEdit QtyInAssemblySupply { get; }
			public PXNumberEdit QtyPOPrepared { get; }
			public PXNumberEdit QtyPOOrders { get; }
			public PXNumberEdit QtyPOReceipts { get; }
			public PXNumberEdit QtyExpired { get; }
			public PXNumberEdit QtyOnHand { get; }
			public PXNumberEdit QtySOFixed { get; }
			public PXNumberEdit QtyPOFixedOrders { get; }
			public PXNumberEdit QtyPOFixedPrepared { get; }
			public PXNumberEdit QtyPOFixedReceipts { get; }
			public PXNumberEdit QtySODropShip { get; }
			public PXNumberEdit QtyPODropShipOrders { get; }
			public PXNumberEdit QtyPODropShipPrepared { get; }
			public PXNumberEdit QtyPODropShipReceipts { get; }
			public PXNumberEdit QtyFSSrvOrdPrepared { get; }
			public PXNumberEdit QtyFSSrvOrdBooked { get; }
			public PXNumberEdit QtyFSSrvOrdAllocated { get; }
			public PXNumberEdit QtyFixedFSSrvOrd { get; }
			public PXNumberEdit QtyPOFixedFSSrvOrd { get; }
			public PXNumberEdit QtyPOFixedFSSrvOrdPrepared { get; }
			public PXNumberEdit QtyPOFixedFSSrvOrdReceipts { get; }
			public Selector BaseUnit { get; }
			public PXNumberEdit UnitCost { get; }
			public PXNumberEdit TotalCost { get; }
			public PXTextEdit LotSerialNbr { get; }
			public DateSelector ExpireDate { get; }
			public PXNumberEdit GridLineNbr { get; }
                
                public c_grid_row(c_iserecords_grid grid) : 
                        base(grid)
                {
                    InventoryID = new Selector("_ctl00_phG_grid_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_grid_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SiteID = new Selector("_ctl00_phG_grid_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LocationID = new PXTextEdit("ctl00_phG_grid_ei", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    QtyAvail = new PXNumberEdit("ctl00_phG_grid_en", "Available", grid.Locator, "QtyAvail");
                    QtyAvail.DataField = "QtyAvail";
                    QtyHardAvail = new PXNumberEdit("ctl00_phG_grid_en", "Available for Shipment", grid.Locator, "QtyHardAvail");
                    QtyHardAvail.DataField = "QtyHardAvail";
                    QtyActual = new PXNumberEdit("ctl00_phG_grid_en", "Available for Issue", grid.Locator, "QtyActual");
                    QtyActual.DataField = "QtyActual";
                    QtyNotAvail = new PXNumberEdit("ctl00_phG_grid_en", "Not Available", grid.Locator, "QtyNotAvail");
                    QtyNotAvail.DataField = "QtyNotAvail";
                    QtySOPrepared = new PXNumberEdit("ctl00_phG_grid_en", "SO Prepared", grid.Locator, "QtySOPrepared");
                    QtySOPrepared.DataField = "QtySOPrepared";
                    QtySOBooked = new PXNumberEdit("ctl00_phG_grid_en", "SO Booked", grid.Locator, "QtySOBooked");
                    QtySOBooked.DataField = "QtySOBooked";
                    QtySOShipping = new PXNumberEdit("ctl00_phG_grid_en", "SO Allocated", grid.Locator, "QtySOShipping");
                    QtySOShipping.DataField = "QtySOShipping";
                    QtySOShipped = new PXNumberEdit("ctl00_phG_grid_en", "SO Shipped", grid.Locator, "QtySOShipped");
                    QtySOShipped.DataField = "QtySOShipped";
                    QtySOBackOrdered = new PXNumberEdit("ctl00_phG_grid_en", "SO Back Ordered", grid.Locator, "QtySOBackOrdered");
                    QtySOBackOrdered.DataField = "QtySOBackOrdered";
                    QtyINIssues = new PXNumberEdit("ctl00_phG_grid_en", "IN Issues", grid.Locator, "QtyINIssues");
                    QtyINIssues.DataField = "QtyINIssues";
                    QtyINReceipts = new PXNumberEdit("ctl00_phG_grid_en", "IN Receipts", grid.Locator, "QtyINReceipts");
                    QtyINReceipts.DataField = "QtyINReceipts";
                    QtyInTransit = new PXNumberEdit("ctl00_phG_grid_en", "In-Transit", grid.Locator, "QtyInTransit");
                    QtyInTransit.DataField = "QtyInTransit";
                    QtyInTransitToSO = new PXNumberEdit("ctl00_phG_grid_en", "In-Transit to SO", grid.Locator, "QtyInTransitToSO");
                    QtyInTransitToSO.DataField = "QtyInTransitToSO";
                    QtyProductionSupplyPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Production Supply Prepared", grid.Locator, "QtyProductionSupplyPrepared");
                    QtyProductionSupplyPrepared.DataField = "QtyProductionSupplyPrepared";
                    QtyProductionSupply = new PXNumberEdit("ctl00_phG_grid_en", "Production Supply", grid.Locator, "QtyProductionSupply");
                    QtyProductionSupply.DataField = "QtyProductionSupply";
                    QtyProdFixedProdOrdersPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Production for Prod. Prepared", grid.Locator, "QtyProdFixedProdOrdersPrepared");
                    QtyProdFixedProdOrdersPrepared.DataField = "QtyProdFixedProdOrdersPrepared";
                    QtyProdFixedProdOrders = new PXNumberEdit("ctl00_phG_grid_en", "Production for Production", grid.Locator, "QtyProdFixedProdOrders");
                    QtyProdFixedProdOrders.DataField = "QtyProdFixedProdOrders";
                    QtyPOFixedProductionPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Purchase for Prod. Prepared", grid.Locator, "QtyPOFixedProductionPrepared");
                    QtyPOFixedProductionPrepared.DataField = "QtyPOFixedProductionPrepared";
                    QtyPOFixedProductionOrders = new PXNumberEdit("ctl00_phG_grid_en", "Purchase for Production", grid.Locator, "QtyPOFixedProductionOrders");
                    QtyPOFixedProductionOrders.DataField = "QtyPOFixedProductionOrders";
                    QtyProdFixedSalesOrdersPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Production for SO Prepared", grid.Locator, "QtyProdFixedSalesOrdersPrepared");
                    QtyProdFixedSalesOrdersPrepared.DataField = "QtyProdFixedSalesOrdersPrepared";
                    QtyProdFixedSalesOrders = new PXNumberEdit("ctl00_phG_grid_en", "Production for SO", grid.Locator, "QtyProdFixedSalesOrders");
                    QtyProdFixedSalesOrders.DataField = "QtyProdFixedSalesOrders";
                    QtyProductionDemandPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Production Demand Prepared", grid.Locator, "QtyProductionDemandPrepared");
                    QtyProductionDemandPrepared.DataField = "QtyProductionDemandPrepared";
                    QtyProductionDemand = new PXNumberEdit("ctl00_phG_grid_en", "Production Demand", grid.Locator, "QtyProductionDemand");
                    QtyProductionDemand.DataField = "QtyProductionDemand";
                    QtyProductionAllocated = new PXNumberEdit("ctl00_phG_grid_en", "Production Allocated", grid.Locator, "QtyProductionAllocated");
                    QtyProductionAllocated.DataField = "QtyProductionAllocated";
                    QtyProdFixedProduction = new PXNumberEdit("ctl00_phG_grid_en", "Production to Production", grid.Locator, "QtyProdFixedProduction");
                    QtyProdFixedProduction.DataField = "QtyProdFixedProduction";
                    QtyProdFixedPurchase = new PXNumberEdit("ctl00_phG_grid_en", "Production to Purchase", grid.Locator, "QtyProdFixedPurchase");
                    QtyProdFixedPurchase.DataField = "QtyProdFixedPurchase";
                    QtySOFixedProduction = new PXNumberEdit("ctl00_phG_grid_en", "SO to Production", grid.Locator, "QtySOFixedProduction");
                    QtySOFixedProduction.DataField = "QtySOFixedProduction";
                    QtyInAssemblyDemand = new PXNumberEdit("ctl00_phG_grid_en", "In Assembly Demand", grid.Locator, "QtyInAssemblyDemand");
                    QtyInAssemblyDemand.DataField = "QtyInAssemblyDemand";
                    QtyInAssemblySupply = new PXNumberEdit("ctl00_phG_grid_en", "In Assembly Supply", grid.Locator, "QtyInAssemblySupply");
                    QtyInAssemblySupply.DataField = "QtyInAssemblySupply";
                    QtyPOPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Purchase Prepared", grid.Locator, "QtyPOPrepared");
                    QtyPOPrepared.DataField = "QtyPOPrepared";
                    QtyPOOrders = new PXNumberEdit("ctl00_phG_grid_en", "Purchase Orders", grid.Locator, "QtyPOOrders");
                    QtyPOOrders.DataField = "QtyPOOrders";
                    QtyPOReceipts = new PXNumberEdit("ctl00_phG_grid_en", "PO Receipts", grid.Locator, "QtyPOReceipts");
                    QtyPOReceipts.DataField = "QtyPOReceipts";
                    QtyExpired = new PXNumberEdit("ctl00_phG_grid_en", "Expired", grid.Locator, "QtyExpired");
                    QtyExpired.DataField = "QtyExpired";
                    QtyOnHand = new PXNumberEdit("ctl00_phG_grid_en", "On Hand", grid.Locator, "QtyOnHand");
                    QtyOnHand.DataField = "QtyOnHand";
                    QtySOFixed = new PXNumberEdit("ctl00_phG_grid_en", "SO to Purchase", grid.Locator, "QtySOFixed");
                    QtySOFixed.DataField = "QtySOFixed";
                    QtyPOFixedOrders = new PXNumberEdit("ctl00_phG_grid_en", "Purchase for SO", grid.Locator, "QtyPOFixedOrders");
                    QtyPOFixedOrders.DataField = "QtyPOFixedOrders";
                    QtyPOFixedPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Purchase for SO Prepared", grid.Locator, "QtyPOFixedPrepared");
                    QtyPOFixedPrepared.DataField = "QtyPOFixedPrepared";
                    QtyPOFixedReceipts = new PXNumberEdit("ctl00_phG_grid_en", "Receipts for SO", grid.Locator, "QtyPOFixedReceipts");
                    QtyPOFixedReceipts.DataField = "QtyPOFixedReceipts";
                    QtySODropShip = new PXNumberEdit("ctl00_phG_grid_en", "SO to Drop-Ship", grid.Locator, "QtySODropShip");
                    QtySODropShip.DataField = "QtySODropShip";
                    QtyPODropShipOrders = new PXNumberEdit("ctl00_phG_grid_en", "Drop-Ship for SO", grid.Locator, "QtyPODropShipOrders");
                    QtyPODropShipOrders.DataField = "QtyPODropShipOrders";
                    QtyPODropShipPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Drop-Ship for SO Prepared", grid.Locator, "QtyPODropShipPrepared");
                    QtyPODropShipPrepared.DataField = "QtyPODropShipPrepared";
                    QtyPODropShipReceipts = new PXNumberEdit("ctl00_phG_grid_en", "Drop-Ship for SO Receipts", grid.Locator, "QtyPODropShipReceipts");
                    QtyPODropShipReceipts.DataField = "QtyPODropShipReceipts";
                    QtyFSSrvOrdPrepared = new PXNumberEdit("ctl00_phG_grid_en", "FS Prepared", grid.Locator, "QtyFSSrvOrdPrepared");
                    QtyFSSrvOrdPrepared.DataField = "QtyFSSrvOrdPrepared";
                    QtyFSSrvOrdBooked = new PXNumberEdit("ctl00_phG_grid_en", "FS Booked", grid.Locator, "QtyFSSrvOrdBooked");
                    QtyFSSrvOrdBooked.DataField = "QtyFSSrvOrdBooked";
                    QtyFSSrvOrdAllocated = new PXNumberEdit("ctl00_phG_grid_en", "FS Allocated", grid.Locator, "QtyFSSrvOrdAllocated");
                    QtyFSSrvOrdAllocated.DataField = "QtyFSSrvOrdAllocated";
                    QtyFixedFSSrvOrd = new PXNumberEdit("ctl00_phG_grid_en", "FS to Purchase", grid.Locator, "QtyFixedFSSrvOrd");
                    QtyFixedFSSrvOrd.DataField = "QtyFixedFSSrvOrd";
                    QtyPOFixedFSSrvOrd = new PXNumberEdit("ctl00_phG_grid_en", "Purchase for FS", grid.Locator, "QtyPOFixedFSSrvOrd");
                    QtyPOFixedFSSrvOrd.DataField = "QtyPOFixedFSSrvOrd";
                    QtyPOFixedFSSrvOrdPrepared = new PXNumberEdit("ctl00_phG_grid_en", "Purchase for FS Prepared", grid.Locator, "QtyPOFixedFSSrvOrdPrepared");
                    QtyPOFixedFSSrvOrdPrepared.DataField = "QtyPOFixedFSSrvOrdPrepared";
                    QtyPOFixedFSSrvOrdReceipts = new PXNumberEdit("ctl00_phG_grid_en", "Receipts for FS", grid.Locator, "QtyPOFixedFSSrvOrdReceipts");
                    QtyPOFixedFSSrvOrdReceipts.DataField = "QtyPOFixedFSSrvOrdReceipts";
                    BaseUnit = new Selector("_ctl00_phG_grid_lv0_es", "Base Unit", grid.Locator, "BaseUnit");
                    BaseUnit.DataField = "BaseUnit";
                    UnitCost = new PXNumberEdit("ctl00_phG_grid_en", "Estimated Unit Cost", grid.Locator, "UnitCost");
                    UnitCost.DataField = "UnitCost";
                    TotalCost = new PXNumberEdit("ctl00_phG_grid_en", "Estimated Total Cost", grid.Locator, "TotalCost");
                    TotalCost.DataField = "TotalCost";
                    LotSerialNbr = new PXTextEdit("ctl00_phG_grid_ei", "Lot/Serial Number", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    ExpireDate = new DateSelector("_ctl00_phG_grid_lv0_ed57", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    GridLineNbr = new PXNumberEdit("ctl00_phG_grid_en", "Line Nbr.", grid.Locator, "GridLineNbr");
                    GridLineNbr.DataField = "GridLineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter LocationID { get; }
				public PXNumberEditColumnFilter QtyAvail { get; }
				public PXNumberEditColumnFilter QtyHardAvail { get; }
				public PXNumberEditColumnFilter QtyActual { get; }
				public PXNumberEditColumnFilter QtyNotAvail { get; }
				public PXNumberEditColumnFilter QtySOPrepared { get; }
				public PXNumberEditColumnFilter QtySOBooked { get; }
				public PXNumberEditColumnFilter QtySOShipping { get; }
				public PXNumberEditColumnFilter QtySOShipped { get; }
				public PXNumberEditColumnFilter QtySOBackOrdered { get; }
				public PXNumberEditColumnFilter QtyINIssues { get; }
				public PXNumberEditColumnFilter QtyINReceipts { get; }
				public PXNumberEditColumnFilter QtyInTransit { get; }
				public PXNumberEditColumnFilter QtyInTransitToSO { get; }
				public PXNumberEditColumnFilter QtyProductionSupplyPrepared { get; }
				public PXNumberEditColumnFilter QtyProductionSupply { get; }
				public PXNumberEditColumnFilter QtyProdFixedProdOrdersPrepared { get; }
				public PXNumberEditColumnFilter QtyProdFixedProdOrders { get; }
				public PXNumberEditColumnFilter QtyPOFixedProductionPrepared { get; }
				public PXNumberEditColumnFilter QtyPOFixedProductionOrders { get; }
				public PXNumberEditColumnFilter QtyProdFixedSalesOrdersPrepared { get; }
				public PXNumberEditColumnFilter QtyProdFixedSalesOrders { get; }
				public PXNumberEditColumnFilter QtyProductionDemandPrepared { get; }
				public PXNumberEditColumnFilter QtyProductionDemand { get; }
				public PXNumberEditColumnFilter QtyProductionAllocated { get; }
				public PXNumberEditColumnFilter QtyProdFixedProduction { get; }
				public PXNumberEditColumnFilter QtyProdFixedPurchase { get; }
				public PXNumberEditColumnFilter QtySOFixedProduction { get; }
				public PXNumberEditColumnFilter QtyInAssemblyDemand { get; }
				public PXNumberEditColumnFilter QtyInAssemblySupply { get; }
				public PXNumberEditColumnFilter QtyPOPrepared { get; }
				public PXNumberEditColumnFilter QtyPOOrders { get; }
				public PXNumberEditColumnFilter QtyPOReceipts { get; }
				public PXNumberEditColumnFilter QtyExpired { get; }
				public PXNumberEditColumnFilter QtyOnHand { get; }
				public PXNumberEditColumnFilter QtySOFixed { get; }
				public PXNumberEditColumnFilter QtyPOFixedOrders { get; }
				public PXNumberEditColumnFilter QtyPOFixedPrepared { get; }
				public PXNumberEditColumnFilter QtyPOFixedReceipts { get; }
				public PXNumberEditColumnFilter QtySODropShip { get; }
				public PXNumberEditColumnFilter QtyPODropShipOrders { get; }
				public PXNumberEditColumnFilter QtyPODropShipPrepared { get; }
				public PXNumberEditColumnFilter QtyPODropShipReceipts { get; }
				public PXNumberEditColumnFilter QtyFSSrvOrdPrepared { get; }
				public PXNumberEditColumnFilter QtyFSSrvOrdBooked { get; }
				public PXNumberEditColumnFilter QtyFSSrvOrdAllocated { get; }
				public PXNumberEditColumnFilter QtyFixedFSSrvOrd { get; }
				public PXNumberEditColumnFilter QtyPOFixedFSSrvOrd { get; }
				public PXNumberEditColumnFilter QtyPOFixedFSSrvOrdPrepared { get; }
				public PXNumberEditColumnFilter QtyPOFixedFSSrvOrdReceipts { get; }
				public SelectorColumnFilter BaseUnit { get; }
				public PXNumberEditColumnFilter UnitCost { get; }
				public PXNumberEditColumnFilter TotalCost { get; }
				public PXTextEditColumnFilter LotSerialNbr { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public PXNumberEditColumnFilter GridLineNbr { get; }
                
                public c_grid_header(c_iserecords_grid grid) : 
                        base(grid)
                {
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LocationID = new PXTextEditColumnFilter(grid.Row.LocationID);
                    QtyAvail = new PXNumberEditColumnFilter(grid.Row.QtyAvail);
                    QtyHardAvail = new PXNumberEditColumnFilter(grid.Row.QtyHardAvail);
                    QtyActual = new PXNumberEditColumnFilter(grid.Row.QtyActual);
                    QtyNotAvail = new PXNumberEditColumnFilter(grid.Row.QtyNotAvail);
                    QtySOPrepared = new PXNumberEditColumnFilter(grid.Row.QtySOPrepared);
                    QtySOBooked = new PXNumberEditColumnFilter(grid.Row.QtySOBooked);
                    QtySOShipping = new PXNumberEditColumnFilter(grid.Row.QtySOShipping);
                    QtySOShipped = new PXNumberEditColumnFilter(grid.Row.QtySOShipped);
                    QtySOBackOrdered = new PXNumberEditColumnFilter(grid.Row.QtySOBackOrdered);
                    QtyINIssues = new PXNumberEditColumnFilter(grid.Row.QtyINIssues);
                    QtyINReceipts = new PXNumberEditColumnFilter(grid.Row.QtyINReceipts);
                    QtyInTransit = new PXNumberEditColumnFilter(grid.Row.QtyInTransit);
                    QtyInTransitToSO = new PXNumberEditColumnFilter(grid.Row.QtyInTransitToSO);
                    QtyProductionSupplyPrepared = new PXNumberEditColumnFilter(grid.Row.QtyProductionSupplyPrepared);
                    QtyProductionSupply = new PXNumberEditColumnFilter(grid.Row.QtyProductionSupply);
                    QtyProdFixedProdOrdersPrepared = new PXNumberEditColumnFilter(grid.Row.QtyProdFixedProdOrdersPrepared);
                    QtyProdFixedProdOrders = new PXNumberEditColumnFilter(grid.Row.QtyProdFixedProdOrders);
                    QtyPOFixedProductionPrepared = new PXNumberEditColumnFilter(grid.Row.QtyPOFixedProductionPrepared);
                    QtyPOFixedProductionOrders = new PXNumberEditColumnFilter(grid.Row.QtyPOFixedProductionOrders);
                    QtyProdFixedSalesOrdersPrepared = new PXNumberEditColumnFilter(grid.Row.QtyProdFixedSalesOrdersPrepared);
                    QtyProdFixedSalesOrders = new PXNumberEditColumnFilter(grid.Row.QtyProdFixedSalesOrders);
                    QtyProductionDemandPrepared = new PXNumberEditColumnFilter(grid.Row.QtyProductionDemandPrepared);
                    QtyProductionDemand = new PXNumberEditColumnFilter(grid.Row.QtyProductionDemand);
                    QtyProductionAllocated = new PXNumberEditColumnFilter(grid.Row.QtyProductionAllocated);
                    QtyProdFixedProduction = new PXNumberEditColumnFilter(grid.Row.QtyProdFixedProduction);
                    QtyProdFixedPurchase = new PXNumberEditColumnFilter(grid.Row.QtyProdFixedPurchase);
                    QtySOFixedProduction = new PXNumberEditColumnFilter(grid.Row.QtySOFixedProduction);
                    QtyInAssemblyDemand = new PXNumberEditColumnFilter(grid.Row.QtyInAssemblyDemand);
                    QtyInAssemblySupply = new PXNumberEditColumnFilter(grid.Row.QtyInAssemblySupply);
                    QtyPOPrepared = new PXNumberEditColumnFilter(grid.Row.QtyPOPrepared);
                    QtyPOOrders = new PXNumberEditColumnFilter(grid.Row.QtyPOOrders);
                    QtyPOReceipts = new PXNumberEditColumnFilter(grid.Row.QtyPOReceipts);
                    QtyExpired = new PXNumberEditColumnFilter(grid.Row.QtyExpired);
                    QtyOnHand = new PXNumberEditColumnFilter(grid.Row.QtyOnHand);
                    QtySOFixed = new PXNumberEditColumnFilter(grid.Row.QtySOFixed);
                    QtyPOFixedOrders = new PXNumberEditColumnFilter(grid.Row.QtyPOFixedOrders);
                    QtyPOFixedPrepared = new PXNumberEditColumnFilter(grid.Row.QtyPOFixedPrepared);
                    QtyPOFixedReceipts = new PXNumberEditColumnFilter(grid.Row.QtyPOFixedReceipts);
                    QtySODropShip = new PXNumberEditColumnFilter(grid.Row.QtySODropShip);
                    QtyPODropShipOrders = new PXNumberEditColumnFilter(grid.Row.QtyPODropShipOrders);
                    QtyPODropShipPrepared = new PXNumberEditColumnFilter(grid.Row.QtyPODropShipPrepared);
                    QtyPODropShipReceipts = new PXNumberEditColumnFilter(grid.Row.QtyPODropShipReceipts);
                    QtyFSSrvOrdPrepared = new PXNumberEditColumnFilter(grid.Row.QtyFSSrvOrdPrepared);
                    QtyFSSrvOrdBooked = new PXNumberEditColumnFilter(grid.Row.QtyFSSrvOrdBooked);
                    QtyFSSrvOrdAllocated = new PXNumberEditColumnFilter(grid.Row.QtyFSSrvOrdAllocated);
                    QtyFixedFSSrvOrd = new PXNumberEditColumnFilter(grid.Row.QtyFixedFSSrvOrd);
                    QtyPOFixedFSSrvOrd = new PXNumberEditColumnFilter(grid.Row.QtyPOFixedFSSrvOrd);
                    QtyPOFixedFSSrvOrdPrepared = new PXNumberEditColumnFilter(grid.Row.QtyPOFixedFSSrvOrdPrepared);
                    QtyPOFixedFSSrvOrdReceipts = new PXNumberEditColumnFilter(grid.Row.QtyPOFixedFSSrvOrdReceipts);
                    BaseUnit = new SelectorColumnFilter(grid.Row.BaseUnit);
                    UnitCost = new PXNumberEditColumnFilter(grid.Row.UnitCost);
                    TotalCost = new PXNumberEditColumnFilter(grid.Row.TotalCost);
                    LotSerialNbr = new PXTextEditColumnFilter(grid.Row.LotSerialNbr);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    GridLineNbr = new PXNumberEditColumnFilter(grid.Row.GridLineNbr);
                }
            }
        }
        
        public class c_iserecords_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_iserecords_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ISERecords";
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
