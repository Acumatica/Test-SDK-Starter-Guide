using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ISVTestSDK.Extensions
{
    
    
    public class CA204000_PaymentMethodMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_paymentmethod_form PaymentMethod_form { get; } = new c_paymentmethod_form("ctl00_phF_form", "PaymentMethod_form");
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
        protected c_paymentmethodcurrent_tab PaymentMethodCurrent_tab { get; } = new c_paymentmethodcurrent_tab("ctl00_phG_tab", "PaymentMethodCurrent_tab");
        protected c_detailsforreceivable_grid DetailsForReceivable_grid { get; } = new c_detailsforreceivable_grid("ctl00_phG_tab_t1_grid", "DetailsForReceivable_grid");
        protected c_detailsforreceivable_lv0 DetailsForReceivable_lv0 { get; } = new c_detailsforreceivable_lv0("ctl00_phG_tab_t1_grid_lv0", "DetailsForReceivable_lv0");
        protected c_detailsforcashaccount_grid DetailsForCashAccount_grid { get; } = new c_detailsforcashaccount_grid("ctl00_phG_tab_t4_grid", "DetailsForCashAccount_grid");
        protected c_detailsforvendor_grid DetailsForVendor_grid { get; } = new c_detailsforvendor_grid("ctl00_phG_tab_t2_grid", "DetailsForVendor_grid");
        protected c_cashaccounts_grdcashaccounts CashAccounts_grdCashAccounts { get; } = new c_cashaccounts_grdcashaccounts("ctl00_phG_tab_t0_grdCashAccounts", "CashAccounts_grdCashAccounts");
        protected c_cashaccounts_lv0 CashAccounts_lv0 { get; } = new c_cashaccounts_lv0("ctl00_phG_tab_t0_grdCashAccounts_lv0", "CashAccounts_lv0");
        protected c_processingcenters_grdproccenters ProcessingCenters_grdProcCenters { get; } = new c_processingcenters_grdproccenters("ctl00_phG_tab_t5_grdProcCenters", "ProcessingCenters_grdProcCenters");
        protected c_processingcenters_lv0 ProcessingCenters_lv0 { get; } = new c_processingcenters_lv0("ctl00_phG_tab_t5_grdProcCenters_lv0", "ProcessingCenters_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public CA204000_PaymentMethodMaint()
        {
            ScreenId = "CA204000";
            ScreenUrl = "/Pages/CA/CA204000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual CA204000_PaymentMethodMaint ReadOne(Gate gate, string PaymentMethodID)
        {
            new BiObject<CA204000_PaymentMethodMaint>(gate).ReadOne(this, PaymentMethodID);
            return this;
        }
        
        public virtual CA204000_PaymentMethodMaint ReadOne(string PaymentMethodID)
        {
            return this.ReadOne(ApiConnection.Source, PaymentMethodID);
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
                Delete.ConfirmAction = () => Alert.AlertToException("The current Payment Method record will be deleted.");
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
        
        public class c_paymentmethod_form : Container
        {
            
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
			public CheckBox ContainsPersonalData { get; }
			public Label ContainsPersonalDataLabel { get; }
			public DropDown PaymentType { get; }
			public Label PaymentTypeLabel { get; }
			public DropDown DirectDepositFileFormat { get; }
			public Label DirectDepositFileFormatLabel { get; }
			public CheckBox UseForAP { get; }
			public Label UseForAPLabel { get; }
			public CheckBox UseForAR { get; }
			public Label UseForARLabel { get; }
			public CheckBox UseForPR { get; }
			public Label UseForPRLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
			public CheckBox UsrKNVPIsACH { get; }
			public Label UsrKNVPIsACHLabel { get; }
			public CheckBox PaymentDateToBankDate { get; }
			public Label PaymentDateToBankDateLabel { get; }
			public CheckBox UseForCA { get; }
			public Label UseForCALabel { get; }
			public CheckBox HasProcessingCenters { get; }
			public Label HasProcessingCentersLabel { get; }
            
            public c_paymentmethod_form(string locator, string name) : 
                    base(locator, name)
            {
                PaymentMethodID = new Selector("ctl00_phF_form_edPaymentMethodID", "Payment Method ID", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                IsActive = new CheckBox("ctl00_phF_form_chkIsActive", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                ContainsPersonalData = new CheckBox("ctl00_phF_form_chkContainsPersonalData", "Contains Personal Data", locator, null);
                ContainsPersonalDataLabel = new Label(ContainsPersonalData);
                ContainsPersonalData.DataField = "ContainsPersonalData";
                PaymentType = new DropDown("ctl00_phF_form_edPaymentType", "Means of Payment", locator, null);
                PaymentTypeLabel = new Label(PaymentType);
                PaymentType.DataField = "PaymentType";
                PaymentType.Items.Add("CCD", "Credit Card");
                PaymentType.Items.Add("CHC", "Cash/Check");
                PaymentType.Items.Add("DDT", "Direct Deposit");
                DirectDepositFileFormat = new DropDown("ctl00_phF_form_edDirectDepositFileFormat", "Direct Deposit File Format", locator, null);
                DirectDepositFileFormatLabel = new Label(DirectDepositFileFormat);
                DirectDepositFileFormat.DataField = "DirectDepositFileFormat";
                UseForAP = new CheckBox("ctl00_phF_form_chkUseForAP", "Use in AP", locator, null);
                UseForAPLabel = new Label(UseForAP);
                UseForAP.DataField = "UseForAP";
                UseForAR = new CheckBox("ctl00_phF_form_chkUseForAR", "Use in AR", locator, null);
                UseForARLabel = new Label(UseForAR);
                UseForAR.DataField = "UseForAR";
                UseForPR = new CheckBox("ctl00_phF_form_chkUseForPR", "Use in PR", locator, null);
                UseForPRLabel = new Label(UseForPR);
                UseForPR.DataField = "UseForPR";
                Descr = new InputLocalizable("ctl00_phF_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                UsrKNVPIsACH = new CheckBox("ctl00_phF_form_CstPXCheckBox1", "Is ACH", locator, null);
                UsrKNVPIsACHLabel = new Label(UsrKNVPIsACH);
                UsrKNVPIsACH.DataField = "UsrKNVPIsACH";
                PaymentDateToBankDate = new CheckBox("ctl00_phF_form_chkPaymentDateToBankDate", "Set Payment Date to Bank Transaction Date", locator, null);
                PaymentDateToBankDateLabel = new Label(PaymentDateToBankDate);
                PaymentDateToBankDate.DataField = "PaymentDateToBankDate";
                UseForCA = new CheckBox("ctl00_phF_form_chkUseForCA", "Require Remittance Information for Cash Account", locator, null);
                UseForCALabel = new Label(UseForCA);
                UseForCA.DataField = "UseForCA";
                HasProcessingCenters = new CheckBox("ctl00_phF_form_chkHasProcessingCenters", "HasProcessingCenters", locator, null);
                HasProcessingCentersLabel = new Label(HasProcessingCenters);
                HasProcessingCenters.DataField = "HasProcessingCenters";
                DataMemberName = "PaymentMethod";
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
        
        public class c_paymentmethodcurrent_tab : Container
        {
            
			public CheckBox ARIsProcessingRequired { get; }
			public Label ARIsProcessingRequiredLabel { get; }
			public CheckBox IsAccountNumberRequired { get; }
			public Label IsAccountNumberRequiredLabel { get; }
			public CheckBox ARVoidOnDepositAccount { get; }
			public Label ARVoidOnDepositAccountLabel { get; }
			public CheckBox ARHasBillingInfo { get; }
			public Label ARHasBillingInfoLabel { get; }
			public CheckBox ARDefaultVoidDateToDocumentDate { get; }
			public Label ARDefaultVoidDateToDocumentDateLabel { get; }
			public GroupBox APAdditionalProcessing { get; }
			public Label APAdditionalProcessingLabel { get; }
			public Selector APCheckReportID { get; }
			public Label APCheckReportIDLabel { get; }
			public PXNumberEdit APStubLines { get; }
			public Label APStubLinesLabel { get; }
			public CheckBox APPrintRemittance { get; }
			public Label APPrintRemittanceLabel { get; }
			public Selector APRemittanceReportID { get; }
			public Label APRemittanceReportIDLabel { get; }
			public Selector APBatchExportSYMappingID { get; }
			public Label APBatchExportSYMappingIDLabel { get; }
			public CheckBox SkipPaymentsWithZeroAmt { get; }
			public Label SkipPaymentsWithZeroAmtLabel { get; }
			public CheckBox RequireBatchSeqNum { get; }
			public Label RequireBatchSeqNumLabel { get; }
			public CheckBox APRequirePaymentRef { get; }
			public Label APRequirePaymentRefLabel { get; }
			public GroupBox PRProcessing { get; }
			public Label PRProcessingLabel { get; }
			public Selector PRCheckReportID { get; }
			public Label PRCheckReportIDLabel { get; }
			public Selector PRBatchExportSYMappingID { get; }
			public Label PRBatchExportSYMappingIDLabel { get; }
            
            public c_paymentmethodcurrent_tab(string locator, string name) : 
                    base(locator, name)
            {
                ARIsProcessingRequired = new CheckBox("ctl00_phG_tab_t1_chkARIsProcessingRequired1", "Integrated Processing", locator, null);
                ARIsProcessingRequiredLabel = new Label(ARIsProcessingRequired);
                ARIsProcessingRequired.DataField = "ARIsProcessingRequired";
                IsAccountNumberRequired = new CheckBox("ctl00_phG_tab_t1_chkIsAccountNumberRequired0", "Require Card/Account Number", locator, null);
                IsAccountNumberRequiredLabel = new Label(IsAccountNumberRequired);
                IsAccountNumberRequired.DataField = "IsAccountNumberRequired";
                ARVoidOnDepositAccount = new CheckBox("ctl00_phG_tab_t1_chkVoidOnDepositAccount", "Void On Clearing Account", locator, null);
                ARVoidOnDepositAccountLabel = new Label(ARVoidOnDepositAccount);
                ARVoidOnDepositAccount.DataField = "ARVoidOnDepositAccount";
                ARHasBillingInfo = new CheckBox("ctl00_phG_tab_t1_chkARHasBillingInfo", "Has Billing Information", locator, null);
                ARHasBillingInfoLabel = new Label(ARHasBillingInfo);
                ARHasBillingInfo.DataField = "ARHasBillingInfo";
                ARDefaultVoidDateToDocumentDate = new CheckBox("ctl00_phG_tab_t1_chkDefaultVoidDateToDocDate", "Default Void Date to Document Date", locator, null);
                ARDefaultVoidDateToDocumentDateLabel = new Label(ARDefaultVoidDateToDocumentDate);
                ARDefaultVoidDateToDocumentDate.DataField = "ARDefaultVoidDateToDocumentDate";
                APAdditionalProcessing = new GroupBox("ctl00_phG_tab_t2_gbAdditionalProcessing", "AP Additional Processing", locator, null);
                APAdditionalProcessingLabel = new Label(APAdditionalProcessing);
                APAdditionalProcessing.DataField = "APAdditionalProcessing";
                APCheckReportID = new Selector("ctl00_phG_tab_t2_edAPCheckReportID", "Report", locator, null);
                APCheckReportIDLabel = new Label(APCheckReportID);
                APCheckReportID.DataField = "APCheckReportID";
                APStubLines = new PXNumberEdit("ctl00_phG_tab_t2_edStubLines", "Lines per Stub", locator, null);
                APStubLinesLabel = new Label(APStubLines);
                APStubLines.DataField = "APStubLines";
                APPrintRemittance = new CheckBox("ctl00_phG_tab_t2_chkPrintRemittanceReport", "Print Remittance Report", locator, null);
                APPrintRemittanceLabel = new Label(APPrintRemittance);
                APPrintRemittance.DataField = "APPrintRemittance";
                APRemittanceReportID = new Selector("ctl00_phG_tab_t2_edRemittanceReportID", "Remittance Report", locator, null);
                APRemittanceReportIDLabel = new Label(APRemittanceReportID);
                APRemittanceReportID.DataField = "APRemittanceReportID";
                APBatchExportSYMappingID = new Selector("ctl00_phG_tab_t2_edAPBatchExportSYMappingID", "Export Scenario", locator, null);
                APBatchExportSYMappingIDLabel = new Label(APBatchExportSYMappingID);
                APBatchExportSYMappingID.DataField = "APBatchExportSYMappingID";
                SkipPaymentsWithZeroAmt = new CheckBox("ctl00_phG_tab_t2_chkSkipPaymentsWithZeroAmt", "Skip Payments with Zero Amount", locator, null);
                SkipPaymentsWithZeroAmtLabel = new Label(SkipPaymentsWithZeroAmt);
                SkipPaymentsWithZeroAmt.DataField = "SkipPaymentsWithZeroAmt";
                RequireBatchSeqNum = new CheckBox("ctl00_phG_tab_t2_chkRequireBatchSeqNum", "Require Batch Seq. Number", locator, null);
                RequireBatchSeqNumLabel = new Label(RequireBatchSeqNum);
                RequireBatchSeqNum.DataField = "RequireBatchSeqNum";
                APRequirePaymentRef = new CheckBox("ctl00_phG_tab_t2_edAPRequirePaymentRef", "Require Unique Payment Ref.", locator, null);
                APRequirePaymentRefLabel = new Label(APRequirePaymentRef);
                APRequirePaymentRef.DataField = "APRequirePaymentRef";
                PRProcessing = new GroupBox("ctl00_phG_tab_t3_gbPRProcessing", "PR Processing", locator, null);
                PRProcessingLabel = new Label(PRProcessing);
                PRProcessing.DataField = "PRProcessing";
                PRCheckReportID = new Selector("ctl00_phG_tab_t3_edPRCheckReportID", "Report", locator, null);
                PRCheckReportIDLabel = new Label(PRCheckReportID);
                PRCheckReportID.DataField = "PRCheckReportID";
                PRBatchExportSYMappingID = new Selector("ctl00_phG_tab_t3_edPRBatchExportSYMappingID", "Export Scenario", locator, null);
                PRBatchExportSYMappingIDLabel = new Label(PRBatchExportSYMappingID);
                PRBatchExportSYMappingID.DataField = "PRBatchExportSYMappingID";
                DataMemberName = "PaymentMethodCurrent";
            }
        }
        
        public class c_detailsforreceivable_grid : Grid<c_detailsforreceivable_grid.c_grid_row, c_detailsforreceivable_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_detailsforreceivable_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_grid");
                DataMemberName = "DetailsForReceivable";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit PaymentMethodID { get; }
			public PXTextEdit DetailID { get; }
			public InputLocalizable Descr { get; }
			public CheckBox IsRequired { get; }
			public CheckBox IsEncrypted { get; }
			public CheckBox IsIdentifier { get; }
			public CheckBox IsExpirationDate { get; }
			public CheckBox IsCVV { get; }
			public CheckBox IsOwnerName { get; }
			public CheckBox IsCCProcessingID { get; }
			public PXNumberEdit OrderIndex { get; }
			public PXTextEdit EntryMask { get; }
			public PXTextEdit ValidRegexp { get; }
			public PXTextEdit DisplayMask { get; }
			public PXTextEdit UseFor { get; }
                
                public c_grid_row(c_detailsforreceivable_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    PaymentMethodID = new PXTextEdit("ctl00_phG_tab_t1_grid_ei", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    DetailID = new PXTextEdit("_ctl00_phG_tab_t1_grid_lv0_edDetailID", "ID", grid.Locator, "DetailID");
                    DetailID.DataField = "DetailID";
                    Descr = new InputLocalizable("ctl00_phG_tab_t1_grid_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    IsRequired = new CheckBox("ctl00_phG_tab_t1_grid_ef", "Required", grid.Locator, "IsRequired");
                    IsRequired.DataField = "IsRequired";
                    IsEncrypted = new CheckBox("ctl00_phG_tab_t1_grid_ef", "Encrypted", grid.Locator, "IsEncrypted");
                    IsEncrypted.DataField = "IsEncrypted";
                    IsIdentifier = new CheckBox("ctl00_phG_tab_t1_grid", "Card/Account Nbr.", grid.Locator, "IsIdentifier");
                    IsIdentifier.DataField = "IsIdentifier";
                    IsExpirationDate = new CheckBox("ctl00_phG_tab_t1_grid", "Exp. Date", grid.Locator, "IsExpirationDate");
                    IsExpirationDate.DataField = "IsExpirationDate";
                    IsCVV = new CheckBox("ctl00_phG_tab_t1_grid_ef", "CVV Code", grid.Locator, "IsCVV");
                    IsCVV.DataField = "IsCVV";
                    IsOwnerName = new CheckBox("ctl00_phG_tab_t1_grid_ef", "Name on Card", grid.Locator, "IsOwnerName");
                    IsOwnerName.DataField = "IsOwnerName";
                    IsCCProcessingID = new CheckBox("ctl00_phG_tab_t1_grid", "Payment Profile ID", grid.Locator, "IsCCProcessingID");
                    IsCCProcessingID.DataField = "IsCCProcessingID";
                    OrderIndex = new PXNumberEdit("ctl00_phG_tab_t1_grid_en", "Sort Order", grid.Locator, "OrderIndex");
                    OrderIndex.DataField = "OrderIndex";
                    EntryMask = new PXTextEdit("_ctl00_phG_tab_t1_grid_lv0_edEntryMask", "Entry Mask", grid.Locator, "EntryMask");
                    EntryMask.DataField = "EntryMask";
                    ValidRegexp = new PXTextEdit("_ctl00_phG_tab_t1_grid_lv0_edValidRegexp", "Validation Reg. Exp.", grid.Locator, "ValidRegexp");
                    ValidRegexp.DataField = "ValidRegexp";
                    DisplayMask = new PXTextEdit("ctl00_phG_tab_t1_grid_ei", "Display Mask", grid.Locator, "DisplayMask");
                    DisplayMask.DataField = "DisplayMask";
                    UseFor = new PXTextEdit("ctl00_phG_tab_t1_grid_ei", "Used In", grid.Locator, "UseFor");
                    UseFor.DataField = "UseFor";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter PaymentMethodID { get; }
				public PXTextEditColumnFilter DetailID { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public CheckBoxColumnFilter IsEncrypted { get; }
				public CheckBoxColumnFilter IsIdentifier { get; }
				public CheckBoxColumnFilter IsExpirationDate { get; }
				public CheckBoxColumnFilter IsCVV { get; }
				public CheckBoxColumnFilter IsOwnerName { get; }
				public CheckBoxColumnFilter IsCCProcessingID { get; }
				public PXNumberEditColumnFilter OrderIndex { get; }
				public PXTextEditColumnFilter EntryMask { get; }
				public PXTextEditColumnFilter ValidRegexp { get; }
				public PXTextEditColumnFilter DisplayMask { get; }
				public PXTextEditColumnFilter UseFor { get; }
                
                public c_grid_header(c_detailsforreceivable_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    PaymentMethodID = new PXTextEditColumnFilter(grid.Row.PaymentMethodID);
                    DetailID = new PXTextEditColumnFilter(grid.Row.DetailID);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    IsEncrypted = new CheckBoxColumnFilter(grid.Row.IsEncrypted);
                    IsIdentifier = new CheckBoxColumnFilter(grid.Row.IsIdentifier);
                    IsExpirationDate = new CheckBoxColumnFilter(grid.Row.IsExpirationDate);
                    IsCVV = new CheckBoxColumnFilter(grid.Row.IsCVV);
                    IsOwnerName = new CheckBoxColumnFilter(grid.Row.IsOwnerName);
                    IsCCProcessingID = new CheckBoxColumnFilter(grid.Row.IsCCProcessingID);
                    OrderIndex = new PXNumberEditColumnFilter(grid.Row.OrderIndex);
                    EntryMask = new PXTextEditColumnFilter(grid.Row.EntryMask);
                    ValidRegexp = new PXTextEditColumnFilter(grid.Row.ValidRegexp);
                    DisplayMask = new PXTextEditColumnFilter(grid.Row.DisplayMask);
                    UseFor = new PXTextEditColumnFilter(grid.Row.UseFor);
                }
            }
        }
        
        public class c_detailsforreceivable_lv0 : Container
        {
            
			public PXTextEdit DetailID { get; }
			public Label DetailIDLabel { get; }
			public PXTextEdit EntryMask { get; }
			public Label EntryMaskLabel { get; }
			public PXTextEdit ValidRegexp { get; }
			public Label ValidRegexpLabel { get; }
            
            public c_detailsforreceivable_lv0(string locator, string name) : 
                    base(locator, name)
            {
                DetailID = new PXTextEdit("ctl00_phG_tab_t1_grid_lv0_edDetailID", "ID", locator, null);
                DetailIDLabel = new Label(DetailID);
                DetailID.DataField = "DetailID";
                EntryMask = new PXTextEdit("ctl00_phG_tab_t1_grid_lv0_edEntryMask", "Entry Mask", locator, null);
                EntryMaskLabel = new Label(EntryMask);
                EntryMask.DataField = "EntryMask";
                ValidRegexp = new PXTextEdit("ctl00_phG_tab_t1_grid_lv0_edValidRegexp", "Validation Reg. Exp.", locator, null);
                ValidRegexpLabel = new Label(ValidRegexp);
                ValidRegexp.DataField = "ValidRegexp";
                DataMemberName = "DetailsForReceivable";
            }
        }
        
        public class c_detailsforcashaccount_grid : Grid<c_detailsforcashaccount_grid.c_grid_row, c_detailsforcashaccount_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_detailsforcashaccount_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_grid");
                DataMemberName = "DetailsForCashAccount";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit DetailID { get; }
			public InputLocalizable Descr { get; }
			public CheckBox IsRequired { get; }
			public PXNumberEdit OrderIndex { get; }
			public PXTextEdit EntryMask { get; }
			public PXTextEdit ValidRegexp { get; }
			public PXTextEdit PaymentMethodID { get; }
			public PXTextEdit UseFor { get; }
                
                public c_grid_row(c_detailsforcashaccount_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    DetailID = new PXTextEdit("ctl00_phG_tab_t4_grid_em", "ID", grid.Locator, "DetailID");
                    DetailID.DataField = "DetailID";
                    Descr = new InputLocalizable("ctl00_phG_tab_t4_grid_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    IsRequired = new CheckBox("ctl00_phG_tab_t4_grid_ef", "Required", grid.Locator, "IsRequired");
                    IsRequired.DataField = "IsRequired";
                    OrderIndex = new PXNumberEdit("ctl00_phG_tab_t4_grid_en", "Sort Order", grid.Locator, "OrderIndex");
                    OrderIndex.DataField = "OrderIndex";
                    EntryMask = new PXTextEdit("ctl00_phG_tab_t4_grid_ei", "Entry Mask", grid.Locator, "EntryMask");
                    EntryMask.DataField = "EntryMask";
                    ValidRegexp = new PXTextEdit("ctl00_phG_tab_t4_grid_ei", "Validation Reg. Exp.", grid.Locator, "ValidRegexp");
                    ValidRegexp.DataField = "ValidRegexp";
                    PaymentMethodID = new PXTextEdit("ctl00_phG_tab_t4_grid_ei", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    UseFor = new PXTextEdit("ctl00_phG_tab_t4_grid_ei", "Used In", grid.Locator, "UseFor");
                    UseFor.DataField = "UseFor";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter DetailID { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public PXNumberEditColumnFilter OrderIndex { get; }
				public PXTextEditColumnFilter EntryMask { get; }
				public PXTextEditColumnFilter ValidRegexp { get; }
				public PXTextEditColumnFilter PaymentMethodID { get; }
				public PXTextEditColumnFilter UseFor { get; }
                
                public c_grid_header(c_detailsforcashaccount_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    DetailID = new PXTextEditColumnFilter(grid.Row.DetailID);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    OrderIndex = new PXNumberEditColumnFilter(grid.Row.OrderIndex);
                    EntryMask = new PXTextEditColumnFilter(grid.Row.EntryMask);
                    ValidRegexp = new PXTextEditColumnFilter(grid.Row.ValidRegexp);
                    PaymentMethodID = new PXTextEditColumnFilter(grid.Row.PaymentMethodID);
                    UseFor = new PXTextEditColumnFilter(grid.Row.UseFor);
                }
            }
        }
        
        public class c_detailsforvendor_grid : Grid<c_detailsforvendor_grid.c_grid_row, c_detailsforvendor_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_detailsforvendor_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_grid");
                DataMemberName = "DetailsForVendor";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit DetailID { get; }
			public InputLocalizable Descr { get; }
			public CheckBox IsRequired { get; }
			public PXNumberEdit OrderIndex { get; }
			public PXTextEdit EntryMask { get; }
			public PXTextEdit ValidRegexp { get; }
			public PXTextEdit PaymentMethodID { get; }
			public PXTextEdit UseFor { get; }
                
                public c_grid_row(c_detailsforvendor_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    DetailID = new PXTextEdit("ctl00_phG_tab_t2_grid_em", "ID", grid.Locator, "DetailID");
                    DetailID.DataField = "DetailID";
                    Descr = new InputLocalizable("ctl00_phG_tab_t2_grid_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    IsRequired = new CheckBox("ctl00_phG_tab_t2_grid_ef", "Required", grid.Locator, "IsRequired");
                    IsRequired.DataField = "IsRequired";
                    OrderIndex = new PXNumberEdit("ctl00_phG_tab_t2_grid_en", "Sort Order", grid.Locator, "OrderIndex");
                    OrderIndex.DataField = "OrderIndex";
                    EntryMask = new PXTextEdit("ctl00_phG_tab_t2_grid_ei", "Entry Mask", grid.Locator, "EntryMask");
                    EntryMask.DataField = "EntryMask";
                    ValidRegexp = new PXTextEdit("ctl00_phG_tab_t2_grid_ei", "Validation Reg. Exp.", grid.Locator, "ValidRegexp");
                    ValidRegexp.DataField = "ValidRegexp";
                    PaymentMethodID = new PXTextEdit("ctl00_phG_tab_t2_grid_ei", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    UseFor = new PXTextEdit("ctl00_phG_tab_t2_grid_ei", "Used In", grid.Locator, "UseFor");
                    UseFor.DataField = "UseFor";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter DetailID { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public PXNumberEditColumnFilter OrderIndex { get; }
				public PXTextEditColumnFilter EntryMask { get; }
				public PXTextEditColumnFilter ValidRegexp { get; }
				public PXTextEditColumnFilter PaymentMethodID { get; }
				public PXTextEditColumnFilter UseFor { get; }
                
                public c_grid_header(c_detailsforvendor_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    DetailID = new PXTextEditColumnFilter(grid.Row.DetailID);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    OrderIndex = new PXNumberEditColumnFilter(grid.Row.OrderIndex);
                    EntryMask = new PXTextEditColumnFilter(grid.Row.EntryMask);
                    ValidRegexp = new PXTextEditColumnFilter(grid.Row.ValidRegexp);
                    PaymentMethodID = new PXTextEditColumnFilter(grid.Row.PaymentMethodID);
                    UseFor = new PXTextEditColumnFilter(grid.Row.UseFor);
                }
            }
        }
        
        public class c_cashaccounts_grdcashaccounts : Grid<c_cashaccounts_grdcashaccounts.c_grid_row, c_cashaccounts_grdcashaccounts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public Note NotePanel { get; }
            
            public c_cashaccounts_grdcashaccounts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grdCashAccounts");
                DataMemberName = "CashAccounts";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_grdCashAccounts_fe_gf", "FilterForm");
                NotePanel = new Note(locator);
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdCashAccounts_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public NoteColumnButton Notes { get; }
			public Selector CashAccountID { get; }
			public PXTextEdit CashAccountID_CashAccount_Descr { get; }
			public Selector CashAccount__BranchID { get; }
			public CheckBox UseForAP { get; }
			public CheckBox UseForPR { get; }
			public CheckBox APIsDefault { get; }
			public CheckBox APAutoNextNbr { get; }
			public PXTextEdit APLastRefNbr { get; }
			public PXTextEdit APBatchLastRefNbr { get; }
			public CheckBox UseForAR { get; }
			public CheckBox ARIsDefault { get; }
			public CheckBox ARIsDefaultForRefund { get; }
			public CheckBox ARAutoNextNbr { get; }
			public PXTextEdit ARLastRefNbr { get; }
			public Selector PaymentMethodID { get; }
                
                public c_grid_row(c_cashaccounts_grdcashaccounts grid) : 
                        base(grid)
                {
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    CashAccountID = new Selector("_ctl00_phG_tab_t0_grdCashAccounts_lv0_edCashAccountID", "Cash Account", grid.Locator, "CashAccountID");
                    CashAccountID.DataField = "CashAccountID";
                    CashAccountID_CashAccount_Descr = new PXTextEdit("ctl00_phG_tab_t0_grdCashAccounts_ei", "Description", grid.Locator, "CashAccountID_CashAccount_Descr");
                    CashAccountID_CashAccount_Descr.DataField = "CashAccountID_CashAccount_Descr";
                    CashAccount__BranchID = new Selector("_ctl00_phG_tab_t0_grdCashAccounts_lv0_es", "Branch", grid.Locator, "CashAccount__BranchID");
                    CashAccount__BranchID.DataField = "CashAccount__BranchID";
                    UseForAP = new CheckBox("ctl00_phG_tab_t0_grdCashAccounts_ef", "Use in AP", grid.Locator, "UseForAP");
                    UseForAP.DataField = "UseForAP";
                    UseForPR = new CheckBox("ctl00_phG_tab_t0_grdCashAccounts_ef", "Use in PR", grid.Locator, "UseForPR");
                    UseForPR.DataField = "UseForPR";
                    APIsDefault = new CheckBox("ctl00_phG_tab_t0_grdCashAccounts_ef", "AP/PR Default", grid.Locator, "APIsDefault");
                    APIsDefault.DataField = "APIsDefault";
                    APAutoNextNbr = new CheckBox("ctl00_phG_tab_t0_grdCashAccounts_ef", "AP/PR - Suggest Next Number", grid.Locator, "APAutoNextNbr");
                    APAutoNextNbr.DataField = "APAutoNextNbr";
                    APLastRefNbr = new PXTextEdit("ctl00_phG_tab_t0_grdCashAccounts_ei", "AP/PR Last Reference Number", grid.Locator, "APLastRefNbr");
                    APLastRefNbr.DataField = "APLastRefNbr";
                    APBatchLastRefNbr = new PXTextEdit("ctl00_phG_tab_t0_grdCashAccounts_ei", "Batch Last Reference Number", grid.Locator, "APBatchLastRefNbr");
                    APBatchLastRefNbr.DataField = "APBatchLastRefNbr";
                    UseForAR = new CheckBox("ctl00_phG_tab_t0_grdCashAccounts_ef", "Use in AR", grid.Locator, "UseForAR");
                    UseForAR.DataField = "UseForAR";
                    ARIsDefault = new CheckBox("ctl00_phG_tab_t0_grdCashAccounts_ef", "AR Default", grid.Locator, "ARIsDefault");
                    ARIsDefault.DataField = "ARIsDefault";
                    ARIsDefaultForRefund = new CheckBox("ctl00_phG_tab_t0_grdCashAccounts_ef", "AR Default For Refund", grid.Locator, "ARIsDefaultForRefund");
                    ARIsDefaultForRefund.DataField = "ARIsDefaultForRefund";
                    ARAutoNextNbr = new CheckBox("ctl00_phG_tab_t0_grdCashAccounts_ef", "AR - Suggest Next Number", grid.Locator, "ARAutoNextNbr");
                    ARAutoNextNbr.DataField = "ARAutoNextNbr";
                    ARLastRefNbr = new PXTextEdit("ctl00_phG_tab_t0_grdCashAccounts_ei", "AR Last Reference Number", grid.Locator, "ARLastRefNbr");
                    ARLastRefNbr.DataField = "ARLastRefNbr";
                    PaymentMethodID = new Selector("_ctl00_phG_tab_t0_grdCashAccounts_lv0_es", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter CashAccountID { get; }
				public PXTextEditColumnFilter CashAccountID_CashAccount_Descr { get; }
				public SelectorColumnFilter CashAccount__BranchID { get; }
				public CheckBoxColumnFilter UseForAP { get; }
				public CheckBoxColumnFilter UseForPR { get; }
				public CheckBoxColumnFilter APIsDefault { get; }
				public CheckBoxColumnFilter APAutoNextNbr { get; }
				public PXTextEditColumnFilter APLastRefNbr { get; }
				public PXTextEditColumnFilter APBatchLastRefNbr { get; }
				public CheckBoxColumnFilter UseForAR { get; }
				public CheckBoxColumnFilter ARIsDefault { get; }
				public CheckBoxColumnFilter ARIsDefaultForRefund { get; }
				public CheckBoxColumnFilter ARAutoNextNbr { get; }
				public PXTextEditColumnFilter ARLastRefNbr { get; }
				public SelectorColumnFilter PaymentMethodID { get; }
                
                public c_grid_header(c_cashaccounts_grdcashaccounts grid) : 
                        base(grid)
                {
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    CashAccountID = new SelectorColumnFilter(grid.Row.CashAccountID);
                    CashAccountID_CashAccount_Descr = new PXTextEditColumnFilter(grid.Row.CashAccountID_CashAccount_Descr);
                    CashAccount__BranchID = new SelectorColumnFilter(grid.Row.CashAccount__BranchID);
                    UseForAP = new CheckBoxColumnFilter(grid.Row.UseForAP);
                    UseForPR = new CheckBoxColumnFilter(grid.Row.UseForPR);
                    APIsDefault = new CheckBoxColumnFilter(grid.Row.APIsDefault);
                    APAutoNextNbr = new CheckBoxColumnFilter(grid.Row.APAutoNextNbr);
                    APLastRefNbr = new PXTextEditColumnFilter(grid.Row.APLastRefNbr);
                    APBatchLastRefNbr = new PXTextEditColumnFilter(grid.Row.APBatchLastRefNbr);
                    UseForAR = new CheckBoxColumnFilter(grid.Row.UseForAR);
                    ARIsDefault = new CheckBoxColumnFilter(grid.Row.ARIsDefault);
                    ARIsDefaultForRefund = new CheckBoxColumnFilter(grid.Row.ARIsDefaultForRefund);
                    ARAutoNextNbr = new CheckBoxColumnFilter(grid.Row.ARAutoNextNbr);
                    ARLastRefNbr = new PXTextEditColumnFilter(grid.Row.ARLastRefNbr);
                    PaymentMethodID = new SelectorColumnFilter(grid.Row.PaymentMethodID);
                }
            }
        }
        
        public class c_cashaccounts_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_cashaccounts_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CashAccountID = new Selector("ctl00_phG_tab_t0_grdCashAccounts_lv0_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                Es = new Selector("ctl00_phG_tab_t0_grdCashAccounts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "CashAccounts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CashAccountIDEdit()
            {
                Buttons.CashAccountIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CashAccountIDEdit { get; }
                
                public PxButtonCollection()
                {
                    CashAccountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grdCashAccounts_lv0_edCashAccountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "CashAccountIDEdit", "ctl00_phG_tab_t0_grdCashAccounts_lv0");
                    CashAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_processingcenters_grdproccenters : Grid<c_processingcenters_grdproccenters.c_grid_row, c_processingcenters_grdproccenters.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_processingcenters_grdproccenters(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_grdProcCenters");
                DataMemberName = "ProcessingCenters";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_grdProcCenters_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdProcCenters_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector ProcessingCenterID { get; }
			public CheckBox IsActive { get; }
			public CheckBox IsDefault { get; }
			public PXNumberEdit FundHoldPeriod { get; }
			public PXNumberEdit ReauthDelay { get; }
			public Selector PaymentMethodID { get; }
                
                public c_grid_row(c_processingcenters_grdproccenters grid) : 
                        base(grid)
                {
                    ProcessingCenterID = new Selector("_ctl00_phG_tab_t5_grdProcCenters_lv0_edProcessingCenterID", "Proc. Center ID", grid.Locator, "ProcessingCenterID");
                    ProcessingCenterID.DataField = "ProcessingCenterID";
                    IsActive = new CheckBox("_ctl00_phG_tab_t5_grdProcCenters_lv0_chkIsActive", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    IsDefault = new CheckBox("_ctl00_phG_tab_t5_grdProcCenters_lv0_chkIsDefault", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    FundHoldPeriod = new PXNumberEdit("_ctl00_phG_tab_t5_grdProcCenters_lv0_edFundHoldPeriod", "Funds Hold Period (Days)", grid.Locator, "FundHoldPeriod");
                    FundHoldPeriod.DataField = "FundHoldPeriod";
                    ReauthDelay = new PXNumberEdit("_ctl00_phG_tab_t5_grdProcCenters_lv0_edReauthDelay", "Reauthorization Delay (Hours)", grid.Locator, "ReauthDelay");
                    ReauthDelay.DataField = "ReauthDelay";
                    PaymentMethodID = new Selector("_ctl00_phG_tab_t5_grdProcCenters_lv0_es", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter ProcessingCenterID { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public PXNumberEditColumnFilter FundHoldPeriod { get; }
				public PXNumberEditColumnFilter ReauthDelay { get; }
				public SelectorColumnFilter PaymentMethodID { get; }
                
                public c_grid_header(c_processingcenters_grdproccenters grid) : 
                        base(grid)
                {
                    ProcessingCenterID = new SelectorColumnFilter(grid.Row.ProcessingCenterID);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    FundHoldPeriod = new PXNumberEditColumnFilter(grid.Row.FundHoldPeriod);
                    ReauthDelay = new PXNumberEditColumnFilter(grid.Row.ReauthDelay);
                    PaymentMethodID = new SelectorColumnFilter(grid.Row.PaymentMethodID);
                }
            }
        }
        
        public class c_processingcenters_lv0 : Container
        {
            
			public Selector ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public PXNumberEdit FundHoldPeriod { get; }
			public Label FundHoldPeriodLabel { get; }
			public PXNumberEdit ReauthDelay { get; }
			public Label ReauthDelayLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_processingcenters_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ProcessingCenterID = new Selector("ctl00_phG_tab_t5_grdProcCenters_lv0_edProcessingCenterID", "Proc. Center ID", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                IsActive = new CheckBox("ctl00_phG_tab_t5_grdProcCenters_lv0_chkIsActive", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                IsDefault = new CheckBox("ctl00_phG_tab_t5_grdProcCenters_lv0_chkIsDefault", "Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                FundHoldPeriod = new PXNumberEdit("ctl00_phG_tab_t5_grdProcCenters_lv0_edFundHoldPeriod", "Funds Hold Period (Days)", locator, null);
                FundHoldPeriodLabel = new Label(FundHoldPeriod);
                FundHoldPeriod.DataField = "FundHoldPeriod";
                ReauthDelay = new PXNumberEdit("ctl00_phG_tab_t5_grdProcCenters_lv0_edReauthDelay", "Reauthorization Delay (Hours)", locator, null);
                ReauthDelayLabel = new Label(ReauthDelay);
                ReauthDelay.DataField = "ReauthDelay";
                Es = new Selector("ctl00_phG_tab_t5_grdProcCenters_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "ProcessingCenters";
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
