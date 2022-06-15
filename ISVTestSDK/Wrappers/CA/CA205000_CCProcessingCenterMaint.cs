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
    
    
    public class CA205000_CCProcessingCenterMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        protected c_processingcenter_form ProcessingCenter_form { get; } = new c_processingcenter_form("ctl00_phF_form", "ProcessingCenter_form");
        protected c_cashaccount_form CashAccount_form { get; } = new c_cashaccount_form("ctl00_phF_form", "CashAccount_form");
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
        protected c_currentprocessingcenter_tab CurrentProcessingCenter_tab { get; } = new c_currentprocessingcenter_tab("ctl00_phG_tab", "CurrentProcessingCenter_tab");
        protected c_details_grddetails Details_grdDetails { get; } = new c_details_grddetails("ctl00_phG_tab_t0_grdDetails", "Details_grdDetails");
        protected c_details_lv0 Details_lv0 { get; } = new c_details_lv0("ctl00_phG_tab_t0_grdDetails_lv0", "Details_lv0");
        protected c_paymentmethods_grdpaymentmethods PaymentMethods_grdPaymentMethods { get; } = new c_paymentmethods_grdpaymentmethods("ctl00_phG_tab_t1_grdPaymentMethods", "PaymentMethods_grdPaymentMethods");
        protected c_paymentmethods_lv0 PaymentMethods_lv0 { get; } = new c_paymentmethods_lv0("ctl00_phG_tab_t1_grdPaymentMethods_lv0", "PaymentMethods_lv0");
        protected c_feetypes_grdfeetypes FeeTypes_grdFeeTypes { get; } = new c_feetypes_grdfeetypes("ctl00_phG_tab_t3_grdFeeTypes", "FeeTypes_grdFeeTypes");
        protected c_feetypes_lv0 FeeTypes_lv0 { get; } = new c_feetypes_lv0("ctl00_phG_tab_t3_grdFeeTypes_lv0", "FeeTypes_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public CA205000_CCProcessingCenterMaint()
        {
            ScreenId = "CA205000";
            ScreenUrl = "/Pages/CA/CA205000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual CA205000_CCProcessingCenterMaint ReadOne(Gate gate, string ProcessingCenterID)
        {
            new BiObject<CA205000_CCProcessingCenterMaint>(gate).ReadOne(this, ProcessingCenterID);
            return this;
        }
        
        public virtual CA205000_CCProcessingCenterMaint ReadOne(string ProcessingCenterID)
        {
            return this.ReadOne(ApiConnection.Source, ProcessingCenterID);
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
        
        public virtual void MenuOpener()
        {
            ToolBar.MenuOpener.Click();
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
        
        public virtual void TestCredentials()
        {
            ToolBar.TestCredentials.Click();
        }
        
        public virtual void TestCredentials(bool status, string message = null)
        {
            ToolBar.TestCredentials.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.TestCredentials.Click();
        }
        
        public virtual void UpdateExpirationDate()
        {
            ToolBar.UpdateExpirationDate.Click();
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
			public ToolBarButton MenuOpener { get; }
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
			public ToolBarButton TestCredentials { get; }
			public ToolBarButton UpdateExpirationDate { get; }
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
                MenuOpener = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_MenuOpener", "Menu", locator, null);
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CancelClose", "Discard Changes and Close", locator, null);
                CancelClose.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SaveClose", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Insert", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Delete", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current Processing Center record will be deleted.");
                CopyPaste = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CopyPaste", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@CopyDocument\']", "CopyDocument", locator, CopyPaste);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@PasteDocument\']", "PasteDocument", locator, CopyPaste);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@SaveTemplate\']", "SaveTemplate", locator, CopyPaste);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                TestCredentials = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_TestCredentials,#ctl00_phDS_ds_ToolBar_TestCredentials" +
                        "_item", "Test Credentials", locator, MenuOpener);
                TestCredentials.WaitAction = Wait.WaitForLongOperationToComplete;
                UpdateExpirationDate = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_UpdateExpirationDate,#ctl00_phDS_ds_ToolBar_UpdateExpi" +
                        "rationDate_item", "Update Expiration Dates", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_processingcenter_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
			public PXTextEdit Name { get; }
			public Label NameLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
			public Selector ProcessingTypeName { get; }
			public Label ProcessingTypeNameLabel { get; }
			public CheckBox AllowDirectInput { get; }
			public Label AllowDirectInputLabel { get; }
			public CheckBox AllowSaveProfile { get; }
			public Label AllowSaveProfileLabel { get; }
			public CheckBox SyncronizeDeletion { get; }
			public Label SyncronizeDeletionLabel { get; }
			public CheckBox UseAcceptPaymentForm { get; }
			public Label UseAcceptPaymentFormLabel { get; }
			public CheckBox AllowUnlinkedRefund { get; }
			public Label AllowUnlinkedRefundLabel { get; }
            
            public c_processingcenter_form(string locator, string name) : 
                    base(locator, name)
            {
                ProcessingCenterID = new Selector("ctl00_phF_form_edProcessingCenterID", "Proc. Center ID", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                Name = new PXTextEdit("ctl00_phF_form_edName", "Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                CashAccountID = new Selector("ctl00_phF_form_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                IsActive = new CheckBox("ctl00_phF_form_chkIsActive", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                ProcessingTypeName = new Selector("ctl00_phF_form_edProcessingTypeName", "Payment Plug-In (Type)", locator, null);
                ProcessingTypeNameLabel = new Label(ProcessingTypeName);
                ProcessingTypeName.DataField = "ProcessingTypeName";
                AllowDirectInput = new CheckBox("ctl00_phF_form_chkAllowDirectInput", "Allow Direct Input", locator, null);
                AllowDirectInputLabel = new Label(AllowDirectInput);
                AllowDirectInput.DataField = "AllowDirectInput";
                AllowSaveProfile = new CheckBox("ctl00_phF_form_chkAllowSaveProfile", "Allow Saving Payment Profiles", locator, null);
                AllowSaveProfileLabel = new Label(AllowSaveProfile);
                AllowSaveProfile.DataField = "AllowSaveProfile";
                SyncronizeDeletion = new CheckBox("ctl00_phF_form_edSyncDeletion", "Synchronize Deletion", locator, null);
                SyncronizeDeletionLabel = new Label(SyncronizeDeletion);
                SyncronizeDeletion.DataField = "SyncronizeDeletion";
                UseAcceptPaymentForm = new CheckBox("ctl00_phF_form_chkUseAcceptPaymentForm", "Accept Payments from New Cards", locator, null);
                UseAcceptPaymentFormLabel = new Label(UseAcceptPaymentForm);
                UseAcceptPaymentForm.DataField = "UseAcceptPaymentForm";
                AllowUnlinkedRefund = new CheckBox("ctl00_phF_form_chkAllowUnlinkedRefund", "Allow Unlinked Refunds", locator, null);
                AllowUnlinkedRefundLabel = new Label(AllowUnlinkedRefund);
                AllowUnlinkedRefund.DataField = "AllowUnlinkedRefund";
                DataMemberName = "ProcessingCenter";
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
                    CashAccountIDEdit = new Button("css=div[id=\'ctl00_phF_form_edCashAccountID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "CashAccountIDEdit", "ctl00_phF_form");
                    CashAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_cashaccount_form : Container
        {
            
			public PXTextEdit CuryID { get; }
			public Label CuryIDLabel { get; }
            
            public c_cashaccount_form(string locator, string name) : 
                    base(locator, name)
            {
                CuryID = new PXTextEdit("ctl00_phF_form_edCashAccountCury", "Currency", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                DataMemberName = "CashAccount";
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
        
        public class c_currentprocessingcenter_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit OpenTranTimeout { get; }
			public Label OpenTranTimeoutLabel { get; }
			public PXNumberEdit SyncRetryAttemptsNo { get; }
			public Label SyncRetryAttemptsNoLabel { get; }
			public PXNumberEdit SyncRetryDelayMs { get; }
			public Label SyncRetryDelayMsLabel { get; }
			public CheckBox CreateAdditionalCustomerProfiles { get; }
			public Label CreateAdditionalCustomerProfilesLabel { get; }
			public PXNumberEdit CreditCardLimit { get; }
			public Label CreditCardLimitLabel { get; }
			public PXNumberEdit ReauthRetryNbr { get; }
			public Label ReauthRetryNbrLabel { get; }
			public PXNumberEdit ReauthRetryDelay { get; }
			public Label ReauthRetryDelayLabel { get; }
			public CheckBox ImportSettlementBatches { get; }
			public Label ImportSettlementBatchesLabel { get; }
			public DateSelector ImportStartDate { get; }
			public Label ImportStartDateLabel { get; }
			public DateSelector LastSettlementDate { get; }
			public Label LastSettlementDateLabel { get; }
			public Selector DepositAccountID { get; }
			public Label DepositAccountIDLabel { get; }
			public CheckBox AutoCreateBankDeposit { get; }
			public Label AutoCreateBankDepositLabel { get; }
            
            public c_currentprocessingcenter_tab(string locator, string name) : 
                    base(locator, name)
            {
                OpenTranTimeout = new PXNumberEdit("ctl00_phG_tab_t2_edOpenTranTimeout", "Transaction Timeout (s)", locator, null);
                OpenTranTimeoutLabel = new Label(OpenTranTimeout);
                OpenTranTimeout.DataField = "OpenTranTimeout";
                SyncRetryAttemptsNo = new PXNumberEdit("ctl00_phG_tab_t2_edSyncRetryAttemptsNo", "Number of Additional Synchronization Attempts", locator, null);
                SyncRetryAttemptsNoLabel = new Label(SyncRetryAttemptsNo);
                SyncRetryAttemptsNo.DataField = "SyncRetryAttemptsNo";
                SyncRetryDelayMs = new PXNumberEdit("ctl00_phG_tab_t2_edSyncRetryDelayMs", "Delay Between Synchronization Attempts (ms)", locator, null);
                SyncRetryDelayMsLabel = new Label(SyncRetryDelayMs);
                SyncRetryDelayMs.DataField = "SyncRetryDelayMs";
                CreateAdditionalCustomerProfiles = new CheckBox("ctl00_phG_tab_t2_chkCreateAdditionalCustomerProfile", "Create Additional Customer Profiles", locator, null);
                CreateAdditionalCustomerProfilesLabel = new Label(CreateAdditionalCustomerProfiles);
                CreateAdditionalCustomerProfiles.DataField = "CreateAdditionalCustomerProfiles";
                CreditCardLimit = new PXNumberEdit("ctl00_phG_tab_t2_edCreditCardLimit", "Maximum Credit Cards per Profile", locator, null);
                CreditCardLimitLabel = new Label(CreditCardLimit);
                CreditCardLimit.DataField = "CreditCardLimit";
                ReauthRetryNbr = new PXNumberEdit("ctl00_phG_tab_t2_edReauthRetryNbr", "Number of Reauthorization Retries", locator, null);
                ReauthRetryNbrLabel = new Label(ReauthRetryNbr);
                ReauthRetryNbr.DataField = "ReauthRetryNbr";
                ReauthRetryDelay = new PXNumberEdit("ctl00_phG_tab_t2_edReauthRetryDelay", "Reauthorization Retry Delay (Hours)", locator, null);
                ReauthRetryDelayLabel = new Label(ReauthRetryDelay);
                ReauthRetryDelay.DataField = "ReauthRetryDelay";
                ImportSettlementBatches = new CheckBox("ctl00_phG_tab_t2_chkImportSettlementBatches", "Import Settlement Batches", locator, null);
                ImportSettlementBatchesLabel = new Label(ImportSettlementBatches);
                ImportSettlementBatches.DataField = "ImportSettlementBatches";
                ImportStartDate = new DateSelector("ctl00_phG_tab_t2_dtImportStartDate", "Import Start Date", locator, null);
                ImportStartDateLabel = new Label(ImportStartDate);
                ImportStartDate.DataField = "ImportStartDate";
                LastSettlementDate = new DateSelector("ctl00_phG_tab_t2_dtLastSettlementDate", "Last Settlement Date", locator, null);
                LastSettlementDateLabel = new Label(LastSettlementDate);
                LastSettlementDate.DataField = "LastSettlementDate";
                DepositAccountID = new Selector("ctl00_phG_tab_t2_edDepositAccountID", "Deposit Account", locator, null);
                DepositAccountIDLabel = new Label(DepositAccountID);
                DepositAccountID.DataField = "DepositAccountID";
                AutoCreateBankDeposit = new CheckBox("ctl00_phG_tab_t2_chkAutoCreateBankDeposit", "Automatically Create Bank Deposits", locator, null);
                AutoCreateBankDepositLabel = new Label(AutoCreateBankDeposit);
                AutoCreateBankDeposit.DataField = "AutoCreateBankDeposit";
                DataMemberName = "CurrentProcessingCenter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DepositAccountIDEdit()
            {
                Buttons.DepositAccountIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DepositAccountIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DepositAccountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edDepositAccountID\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "DepositAccountIDEdit", "ctl00_phG_tab");
                    DepositAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_details_grddetails : Grid<c_details_grddetails.c_grid_row, c_details_grddetails.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_details_grddetails(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grdDetails");
                DataMemberName = "Details";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_grdDetails_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grdDetails_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit DetailID { get; }
			public PXTextEdit Descr { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit ProcessingCenterID { get; }
                
                public c_grid_row(c_details_grddetails grid) : 
                        base(grid)
                {
                    DetailID = new PXTextEdit("_ctl00_phG_tab_t0_grdDetails_lv0_edDetailID", "ID", grid.Locator, "DetailID");
                    DetailID.DataField = "DetailID";
                    Descr = new PXTextEdit("_ctl00_phG_tab_t0_grdDetails_lv0_edDescr", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    Value = new PXTextEdit("_ctl00_phG_tab_t0_grdDetails_lv0_edValue", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    ProcessingCenterID = new PXTextEdit("ctl00_phG_tab_t0_grdDetails_ei", "ProcessingCenterID", grid.Locator, "ProcessingCenterID");
                    ProcessingCenterID.DataField = "ProcessingCenterID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter DetailID { get; }
				public PXTextEditColumnFilter Descr { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter ProcessingCenterID { get; }
                
                public c_grid_header(c_details_grddetails grid) : 
                        base(grid)
                {
                    DetailID = new PXTextEditColumnFilter(grid.Row.DetailID);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    ProcessingCenterID = new PXTextEditColumnFilter(grid.Row.ProcessingCenterID);
                }
            }
        }
        
        public class c_details_lv0 : Container
        {
            
			public PXTextEdit DetailID { get; }
			public Label DetailIDLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
			public PXTextEdit Value { get; }
			public Label ValueLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_details_lv0(string locator, string name) : 
                    base(locator, name)
            {
                DetailID = new PXTextEdit("ctl00_phG_tab_t0_grdDetails_lv0_edDetailID", "ID", locator, null);
                DetailIDLabel = new Label(DetailID);
                DetailID.DataField = "DetailID";
                Descr = new PXTextEdit("ctl00_phG_tab_t0_grdDetails_lv0_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                Value = new PXTextEdit("ctl00_phG_tab_t0_grdDetails_lv0_edValue", "Value", locator, null);
                ValueLabel = new Label(Value);
                Value.DataField = "Value";
                Ed = new DateSelector("ctl00_phG_tab_t0_grdDetails_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_grdDetails_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t0_grdDetails_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t0_grdDetails_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Details";
            }
        }
        
        public class c_paymentmethods_grdpaymentmethods : Grid<c_paymentmethods_grdpaymentmethods.c_grid_row, c_paymentmethods_grdpaymentmethods.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_paymentmethods_grdpaymentmethods(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_grdPaymentMethods");
                DataMemberName = "PaymentMethods";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_grdPaymentMethods_fe_gf", "FilterForm");
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
            
            public virtual void PaymentMethodIDEdit()
            {
                Buttons.PaymentMethodIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grdPaymentMethods_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PaymentMethodIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PaymentMethodIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_grdPaymentMethods_lv0_edPaymentMethodID\'] div[class=" +
                            "\'editBtnCont\'] > div > div", "PaymentMethodIDEdit", "ctl00_phG_tab_t1_grdPaymentMethods");
                    PaymentMethodIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector PaymentMethodID { get; }
			public CheckBox IsActive { get; }
			public CheckBox IsDefault { get; }
			public PXNumberEdit FundHoldPeriod { get; }
			public PXNumberEdit ReauthDelay { get; }
			public PXTextEdit ProcessingCenterID { get; }
                
                public c_grid_row(c_paymentmethods_grdpaymentmethods grid) : 
                        base(grid)
                {
                    PaymentMethodID = new Selector("_ctl00_phG_tab_t1_grdPaymentMethods_lv0_edPaymentMethodID", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    IsActive = new CheckBox("_ctl00_phG_tab_t1_grdPaymentMethods_lv0_chkIsActive", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    IsDefault = new CheckBox("_ctl00_phG_tab_t1_grdPaymentMethods_lv0_chkIsDefault", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    FundHoldPeriod = new PXNumberEdit("_ctl00_phG_tab_t1_grdPaymentMethods_lv0_edFundHoldPeriod", "Funds Hold Period (Days)", grid.Locator, "FundHoldPeriod");
                    FundHoldPeriod.DataField = "FundHoldPeriod";
                    ReauthDelay = new PXNumberEdit("_ctl00_phG_tab_t1_grdPaymentMethods_lv0_edReauthDelay", "Reauthorization Delay (Hours)", grid.Locator, "ReauthDelay");
                    ReauthDelay.DataField = "ReauthDelay";
                    ProcessingCenterID = new PXTextEdit("ctl00_phG_tab_t1_grdPaymentMethods_em", "Proc. Center ID", grid.Locator, "ProcessingCenterID");
                    ProcessingCenterID.DataField = "ProcessingCenterID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter PaymentMethodID { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public PXNumberEditColumnFilter FundHoldPeriod { get; }
				public PXNumberEditColumnFilter ReauthDelay { get; }
				public PXTextEditColumnFilter ProcessingCenterID { get; }
                
                public c_grid_header(c_paymentmethods_grdpaymentmethods grid) : 
                        base(grid)
                {
                    PaymentMethodID = new SelectorColumnFilter(grid.Row.PaymentMethodID);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    FundHoldPeriod = new PXNumberEditColumnFilter(grid.Row.FundHoldPeriod);
                    ReauthDelay = new PXNumberEditColumnFilter(grid.Row.ReauthDelay);
                    ProcessingCenterID = new PXTextEditColumnFilter(grid.Row.ProcessingCenterID);
                }
            }
        }
        
        public class c_paymentmethods_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
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
            
            public c_paymentmethods_lv0(string locator, string name) : 
                    base(locator, name)
            {
                PaymentMethodID = new Selector("ctl00_phG_tab_t1_grdPaymentMethods_lv0_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                IsActive = new CheckBox("ctl00_phG_tab_t1_grdPaymentMethods_lv0_chkIsActive", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                IsDefault = new CheckBox("ctl00_phG_tab_t1_grdPaymentMethods_lv0_chkIsDefault", "Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                FundHoldPeriod = new PXNumberEdit("ctl00_phG_tab_t1_grdPaymentMethods_lv0_edFundHoldPeriod", "Funds Hold Period (Days)", locator, null);
                FundHoldPeriodLabel = new Label(FundHoldPeriod);
                FundHoldPeriod.DataField = "FundHoldPeriod";
                ReauthDelay = new PXNumberEdit("ctl00_phG_tab_t1_grdPaymentMethods_lv0_edReauthDelay", "Reauthorization Delay (Hours)", locator, null);
                ReauthDelayLabel = new Label(ReauthDelay);
                ReauthDelay.DataField = "ReauthDelay";
                Es = new Selector("ctl00_phG_tab_t1_grdPaymentMethods_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "PaymentMethods";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PaymentMethodIDEdit()
            {
                Buttons.PaymentMethodIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PaymentMethodIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PaymentMethodIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_grdPaymentMethods_lv0_edPaymentMethodID\'] div[class=" +
                            "\'editBtnCont\'] > div > div", "PaymentMethodIDEdit", "ctl00_phG_tab_t1_grdPaymentMethods_lv0");
                    PaymentMethodIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_feetypes_grdfeetypes : Grid<c_feetypes_grdfeetypes.c_grid_row, c_feetypes_grdfeetypes.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_feetypes_grdfeetypes(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_grdFeeTypes");
                DataMemberName = "FeeTypes";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_grdFeeTypes_fe_gf", "FilterForm");
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
            
            public virtual void EntryTypeIDEdit()
            {
                Buttons.EntryTypeIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grdFeeTypes_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button EntryTypeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    EntryTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_grdFeeTypes_lv0_edEntryTypeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "EntryTypeIDEdit", "ctl00_phG_tab_t3_grdFeeTypes");
                    EntryTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit FeeType { get; }
			public Selector EntryTypeID { get; }
			public PXTextEdit ProcessingCenterID { get; }
                
                public c_grid_row(c_feetypes_grdfeetypes grid) : 
                        base(grid)
                {
                    FeeType = new PXTextEdit("_ctl00_phG_tab_t3_grdFeeTypes_lv0_edFeeType", "Fee Type", grid.Locator, "FeeType");
                    FeeType.DataField = "FeeType";
                    EntryTypeID = new Selector("_ctl00_phG_tab_t3_grdFeeTypes_lv0_edEntryTypeID", "Entry Type", grid.Locator, "EntryTypeID");
                    EntryTypeID.DataField = "EntryTypeID";
                    ProcessingCenterID = new PXTextEdit("ctl00_phG_tab_t3_grdFeeTypes_ei", "ProcessingCenterID", grid.Locator, "ProcessingCenterID");
                    ProcessingCenterID.DataField = "ProcessingCenterID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter FeeType { get; }
				public SelectorColumnFilter EntryTypeID { get; }
				public PXTextEditColumnFilter ProcessingCenterID { get; }
                
                public c_grid_header(c_feetypes_grdfeetypes grid) : 
                        base(grid)
                {
                    FeeType = new PXTextEditColumnFilter(grid.Row.FeeType);
                    EntryTypeID = new SelectorColumnFilter(grid.Row.EntryTypeID);
                    ProcessingCenterID = new PXTextEditColumnFilter(grid.Row.ProcessingCenterID);
                }
            }
        }
        
        public class c_feetypes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FeeType { get; }
			public Label FeeTypeLabel { get; }
			public Selector EntryTypeID { get; }
			public Label EntryTypeIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_feetypes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                FeeType = new PXTextEdit("ctl00_phG_tab_t3_grdFeeTypes_lv0_edFeeType", "Fee Type", locator, null);
                FeeTypeLabel = new Label(FeeType);
                FeeType.DataField = "FeeType";
                EntryTypeID = new Selector("ctl00_phG_tab_t3_grdFeeTypes_lv0_edEntryTypeID", "Entry Type", locator, null);
                EntryTypeIDLabel = new Label(EntryTypeID);
                EntryTypeID.DataField = "EntryTypeID";
                Es = new Selector("ctl00_phG_tab_t3_grdFeeTypes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "FeeTypes";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void EntryTypeIDEdit()
            {
                Buttons.EntryTypeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button EntryTypeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    EntryTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_grdFeeTypes_lv0_edEntryTypeID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "EntryTypeIDEdit", "ctl00_phG_tab_t3_grdFeeTypes_lv0");
                    EntryTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
