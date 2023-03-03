using Controls;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
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
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Controls.Uploader;
using Core;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.ISVSOLUTIONNAME
{
    
    
    public class CA306000_CABankTransactionsMaint : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_tranfilter_form TranFilter_form { get; } = new c_tranfilter_form("ctl00_phG_PXSplitContainer_form", "TranFilter_form");
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
        protected c_details_grid1 Details_grid1 { get; } = new c_details_grid1("ctl00_phG_PXSplitContainer_grid1", "Details_grid1");
        protected c_details_lv0 Details_lv0 { get; } = new c_details_lv0("ctl00_phG_PXSplitContainer_grid1_lv0", "Details_lv0");
        protected c_currentcabanktran_pxtaxformview1 CurrentCABankTran_PXTaxFormView1 { get; } = new c_currentcabanktran_pxtaxformview1("ctl00_phG_PXTaxPanel_PXTaxFormView1", "CurrentCABankTran_PXTaxFormView1");
        protected c_detailsforpaymentcreation_frmcreatedocument DetailsForPaymentCreation_frmCreateDocument { get; } = new c_detailsforpaymentcreation_frmcreatedocument("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument", "DetailsForPaymentCreation_frmCreateDocument");
        protected c_detailsforinvoiceapplication_frmcreatedocumentinv DetailsForInvoiceApplication_frmCreateDocumentInv { get; } = new c_detailsforinvoiceapplication_frmcreatedocumentinv("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv", "DetailsForInvoiceApplication_frmCreateDocumentInv");
        protected c_detailsforpaymentmatching_frmmatchtopayments DetailsForPaymentMatching_frmMatchToPayments { get; } = new c_detailsforpaymentmatching_frmmatchtopayments("ctl00_phG_PXSplitContainer_tab2_t0_frmMatchToPayments", "DetailsForPaymentMatching_frmMatchToPayments");
        protected c_taxtrans_pxtaxgrid TaxTrans_PXTaxGrid { get; } = new c_taxtrans_pxtaxgrid("ctl00_phG_PXTaxPanel_PXTaxGrid", "TaxTrans_PXTaxGrid");
        protected c_taxtrans_lv0 TaxTrans_lv0 { get; } = new c_taxtrans_lv0("ctl00_phG_PXTaxPanel_PXTaxGrid_lv0", "TaxTrans_lv0");
        protected c_detailmatchesca_pxgrid1 DetailMatchesCA_PXGrid1 { get; } = new c_detailmatchesca_pxgrid1("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1", "DetailMatchesCA_PXGrid1");
        protected c_detailmatchesca_lv0 DetailMatchesCA_lv0 { get; } = new c_detailmatchesca_lv0("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0", "DetailMatchesCA_lv0");
        protected c_adjustments_gridadjustments Adjustments_gridAdjustments { get; } = new c_adjustments_gridadjustments("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments", "Adjustments_gridAdjustments");
        protected c_adjustments_lv0 Adjustments_lv0 { get; } = new c_adjustments_lv0("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0", "Adjustments_lv0");
        protected c_cashaccount_tabmatchsettings Cashaccount_tabmatchsettings { get; } = new c_cashaccount_tabmatchsettings("ctl00_phG_pnlMatchSettings_tabMatchSettings", "cashAccount_tabMatchSettings");
        protected c_detailmatchinginvoices_griddetailmatches4 Detailmatchinginvoices_griddetailmatches4 { get; } = new c_detailmatchinginvoices_griddetailmatches4("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4", "detailMatchingInvoices_gridDetailMatches4");
        protected c_detailmatchinginvoices_lv0 Detailmatchinginvoices_lv0 { get; } = new c_detailmatchinginvoices_lv0("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0", "detailMatchingInvoices_lv0");
        protected c_expensereceiptdetailmatches_gridexpensereceiptdetailmatches ExpenseReceiptDetailMatches_gridExpenseReceiptDetailMatches { get; } = new c_expensereceiptdetailmatches_gridexpensereceiptdetailmatches("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches", "ExpenseReceiptDetailMatches_gridExpenseReceiptDetailMatches");
        protected c_expensereceiptdetailmatches_lv0 ExpenseReceiptDetailMatches_lv0 { get; } = new c_expensereceiptdetailmatches_lv0("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_lv0", "ExpenseReceiptDetailMatches_lv0");
        protected c_transplit_gridcasplits TranSplit_gridCASplits { get; } = new c_transplit_gridcasplits("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits", "TranSplit_gridCASplits");
        protected c_transplit_lv0 TranSplit_lv0 { get; } = new c_transplit_lv0("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0", "TranSplit_lv0");
        protected c_loadopts_loform Loadopts_loform { get; } = new c_loadopts_loform("ctl00_phG_pnlLoadOpts_loform", "loadOpts_loform");
        protected c_rulecreation_frmcreaterule RuleCreation_frmCreateRule { get; } = new c_rulecreation_frmcreaterule("ctl00_phG_pnlCreateRule_frmCreateRule", "RuleCreation_frmCreateRule");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_screen_upload StatementFileUpload { get; } = new c_screen_upload("ctl00_phG_PXSplitContainer_pnlNewRev", "StatementFileUpload");
        
        public CA306000_CABankTransactionsMaint()
        {
            ScreenId = "CA306000";
            ScreenUrl = "/Pages/CA/CA306000.aspx";
            ToolBar = new PxToolBar(null);
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
        
        public virtual void VECustomerMatch()
        {
            ToolBar.VECustomerMatch.Click();
        }
        
        public virtual void AutoMatch()
        {
            ToolBar.AutoMatch.Click();
        }
        
        public virtual void AutoMatch(bool status, string message = null)
        {
            ToolBar.AutoMatch.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.AutoMatch.Click();
        }
        
        public virtual void ProcessMatched()
        {
            ToolBar.ProcessMatched.Click();
        }
        
        public virtual void ProcessMatched(bool status, string message = null)
        {
            ToolBar.ProcessMatched.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ProcessMatched.Click();
        }
        
        public virtual void MatchSettingsPanel()
        {
            ToolBar.MatchSettingsPanel.Click();
        }
        
        public virtual void UploadFile()
        {
            ToolBar.UploadFile.Click();
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
			public ToolBarButton MenuOpener { get; }
			public ToolBarButton CancelClose { get; }
			public ToolBarButton SaveClose { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton VECustomerMatch { get; }
			public ToolBarButton AutoMatch { get; }
			public ToolBarButton ProcessMatched { get; }
			public ToolBarButton MatchSettingsPanel { get; }
			public ToolBarButton UploadFile { get; }
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
                MenuOpener = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_MenuOpener", "Menu", locator, null);
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CancelClose", "Discard Changes and Close", locator, null);
                CancelClose.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SaveClose", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                VECustomerMatch = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_vECustomerMatch,#ctl00_phDS_ds_ToolBar_vECustomerMatch" +
                        "_item", "CUSTOMER MATCH", locator, MenuOpener);
                AutoMatch = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_AutoMatch,#ctl00_phDS_ds_ToolBar_AutoMatch_item", "Auto-Match", locator, MenuOpener);
                AutoMatch.WaitAction = Wait.WaitForLongOperationToComplete;
                ProcessMatched = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ProcessMatched,#ctl00_phDS_ds_ToolBar_ProcessMatched_i" +
                        "tem", "Process", locator, MenuOpener);
                ProcessMatched.WaitAction = Wait.WaitForLongOperationToComplete;
                MatchSettingsPanel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_MatchSettingsPanel,#ctl00_phDS_ds_ToolBar_MatchSetting" +
                        "sPanel_item", "Match Settings", locator, MenuOpener);
                UploadFile = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_UploadFile,#ctl00_phDS_ds_ToolBar_UploadFile_item", "Upload File", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_tranfilter_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public CheckBox IsCorpCardCashAccount { get; }
			public Label IsCorpCardCashAccountLabel { get; }
            
            public c_tranfilter_form(string locator, string name) : 
                    base(locator, name)
            {
                CashAccountID = new Selector("ctl00_phG_PXSplitContainer_form_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                IsCorpCardCashAccount = new CheckBox("ctl00_phG_PXSplitContainer_form_edIsCorpCardCashAccount", "IsCorpCardCashAccount", locator, null);
                IsCorpCardCashAccountLabel = new Label(IsCorpCardCashAccount);
                IsCorpCardCashAccount.DataField = "IsCorpCardCashAccount";
                DataMemberName = "TranFilter";
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
                    CashAccountIDEdit = new Button("css=div[id=\'ctl00_phG_PXSplitContainer_form_edCashAccountID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "CashAccountIDEdit", "ctl00_phG_PXSplitContainer_form");
                    CashAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
			public PXTextEdit ExportText { get; }
			public Label ExportTextLabel { get; }
			public Label PXLabel1_ { get; }
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
                ExportText = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblExportText", "Export Text", locator, null);
                ExportTextLabel = new Label(ExportText);
                ExportText.DataField = "ExportText";
                PXLabel1_ = new Label("ctl00_usrCaption_pnlProfiler_formProfiler_PXLabel1", "PX Label 1_", locator, null);
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
            
            public virtual void BtnLastRequest()
            {
                Buttons.BtnLastRequest.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnStartProfiler { get; }
			public Button BtnStopProfiler { get; }
			public Button BtnLastRequest { get; }
                
                public PxButtonCollection()
                {
                    BtnStartProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStartProfiler", "btnStartProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnStopProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStopProfiler", "btnStopProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnLastRequest = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnLastRequest", "btnLastRequest", "ctl00_usrCaption_pnlProfiler_formProfiler");
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
        
        public class c_details_grid1 : Grid<c_details_grid1.c_grid_row, c_details_grid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
			public Note NotePanel { get; }
            
            public c_details_grid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXSplitContainer_grid1");
                DataMemberName = "Details";
                PredefinedFilter = new DropDown("ctl00_phG_PXSplitContainer_grid1_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                PredefinedFilter.Items.Add("0000019a-0000-0000-0000-000000000000", "Matched");
                PredefinedFilter.Items.Add("0000019c-0000-0000-0000-000000000000", "Unmatched");
                FilterForm = new c_grid_filter("ctl00_phG_PXSplitContainer_grid1_fe_gf", "FilterForm");
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Unmatch()
            {
                ToolBar.Unmatch.Click();
            }
            
            public virtual void UnmatchAll()
            {
                ToolBar.UnmatchAll.Click();
            }
            
            public virtual void HideTransaction()
            {
                ToolBar.HideTransaction.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Filter()
            {
                ToolBar.Filter.Click();
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
			public ToolBarButtonGrid Unmatch { get; }
			public ToolBarButtonGrid UnmatchAll { get; }
			public ToolBarButtonGrid HideTransaction { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Unmatch = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_at_tlb div:textEqual(\"Unmatch\") > div[data-" +
                            "type=\'button\']", "Unmatch", locator, null);
                    UnmatchAll = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_at_tlb div:textEqual(\"Unmatch All\") > div[d" +
                            "ata-type=\'button\']", "Unmatch All", locator, null);
                    HideTransaction = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_at_tlb div:textEqual(\"Hide Transaction\") > " +
                            "div[data-type=\'button\']", "Hide Transaction", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_grid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public NoteColumnButton Notes { get; }
			public DropDown Status { get; }
			public CheckBox DocumentMatched { get; }
			public CheckBox RuleApplied { get; }
			public CheckBox ApplyRuleEnabled { get; }
			public PXTextEdit ExtTranID { get; }
			public PXTextEdit ExtRefNbr { get; }
			public DateSelector TranDate { get; }
			public PXNumberEdit CuryDebitAmt { get; }
			public PXNumberEdit CuryCreditAmt { get; }
			public PXTextEdit CardNumber { get; }
			public PXTextEdit TranDesc { get; }
			public PXTextEdit UsrVEParticulars { get; }
			public PXTextEdit UsrVECode { get; }
			public PXTextEdit UsrVEReference { get; }
			public PXTextEdit TranCode { get; }
			public DateSelector TranEntryDate { get; }
			public PXTextEdit PayeeName { get; }
			public Selector EntryTypeID1 { get; }
			public PXTextEdit InvoiceInfo1 { get; }
			public Selector PaymentMethodID1 { get; }
			public Selector PayeeBAccountID1 { get; }
			public Selector AcctName { get; }
			public DropDown OrigModule1 { get; }
			public Selector PayeeLocationID1 { get; }
			public PXNumberEdit TranID { get; }
			public PXTextEdit MatchStatsInfo { get; }
                
                public c_grid_row(c_details_grid1 grid) : 
                        base(grid)
                {
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Status = new DropDown("_ctl00_phG_PXSplitContainer_grid1_lv0_ec", "Match Type", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("M", "Matched to Payment");
                    Status.Items.Add("I", "Matched to Invoice");
                    Status.Items.Add("R", "Matched to Expense Receipt");
                    Status.Items.Add("C", "Created");
                    Status.Items.Add("H", "Hidden");
                    DocumentMatched = new CheckBox("ctl00_phG_PXSplitContainer_grid1", "Matched", grid.Locator, "DocumentMatched");
                    DocumentMatched.DataField = "DocumentMatched";
                    RuleApplied = new CheckBox("ctl00_phG_PXSplitContainer_grid1", "Rule Applied", grid.Locator, "RuleApplied");
                    RuleApplied.DataField = "RuleApplied";
                    ApplyRuleEnabled = new CheckBox("ctl00_phG_PXSplitContainer_grid1", "Create Rule Enabled", grid.Locator, "ApplyRuleEnabled");
                    ApplyRuleEnabled.DataField = "ApplyRuleEnabled";
                    ExtTranID = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Ext. Tran. ID", grid.Locator, "ExtTranID");
                    ExtTranID.DataField = "ExtTranID";
                    ExtRefNbr = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Ext. Ref. Nbr.", grid.Locator, "ExtRefNbr");
                    ExtRefNbr.DataField = "ExtRefNbr";
                    TranDate = new DateSelector("_ctl00_phG_PXSplitContainer_grid1_lv0_ed7", "Tran. Date", grid.Locator, "TranDate");
                    TranDate.DataField = "TranDate";
                    CuryDebitAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_grid1_en", "Receipt", grid.Locator, "CuryDebitAmt");
                    CuryDebitAmt.DataField = "CuryDebitAmt";
                    CuryCreditAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_grid1_en", "Disbursement", grid.Locator, "CuryCreditAmt");
                    CuryCreditAmt.DataField = "CuryCreditAmt";
                    CardNumber = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Card Number", grid.Locator, "CardNumber");
                    CardNumber.DataField = "CardNumber";
                    TranDesc = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Tran. Desc", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    UsrVEParticulars = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Particulars", grid.Locator, "UsrVEParticulars");
                    UsrVEParticulars.DataField = "UsrVEParticulars";
                    UsrVECode = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Code", grid.Locator, "UsrVECode");
                    UsrVECode.DataField = "UsrVECode";
                    UsrVEReference = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Reference", grid.Locator, "UsrVEReference");
                    UsrVEReference.DataField = "UsrVEReference";
                    TranCode = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Tran. Code", grid.Locator, "TranCode");
                    TranCode.DataField = "TranCode";
                    TranEntryDate = new DateSelector("_ctl00_phG_PXSplitContainer_grid1_lv0_ed16", "Tran. Entry Date", grid.Locator, "TranEntryDate");
                    TranEntryDate.DataField = "TranEntryDate";
                    PayeeName = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Payee Name", grid.Locator, "PayeeName");
                    PayeeName.DataField = "PayeeName";
                    EntryTypeID1 = new Selector("_ctl00_phG_PXSplitContainer_grid1_lv0_es", "Entry Type ID", grid.Locator, "EntryTypeID1");
                    EntryTypeID1.DataField = "EntryTypeID1";
                    InvoiceInfo1 = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "Invoice Nbr.", grid.Locator, "InvoiceInfo1");
                    InvoiceInfo1.DataField = "InvoiceInfo1";
                    PaymentMethodID1 = new Selector("_ctl00_phG_PXSplitContainer_grid1_lv0_es", "Payment Method", grid.Locator, "PaymentMethodID1");
                    PaymentMethodID1.DataField = "PaymentMethodID1";
                    PayeeBAccountID1 = new Selector("_ctl00_phG_PXSplitContainer_grid1_lv0_es", "Business Account", grid.Locator, "PayeeBAccountID1");
                    PayeeBAccountID1.DataField = "PayeeBAccountID1";
                    AcctName = new Selector("_ctl00_phG_PXSplitContainer_grid1_lv0_es", "Business Account Name", grid.Locator, "AcctName");
                    AcctName.DataField = "AcctName";
                    OrigModule1 = new DropDown("_ctl00_phG_PXSplitContainer_grid1_lv0_ec", "Module", grid.Locator, "OrigModule1");
                    OrigModule1.DataField = "OrigModule1";
                    OrigModule1.Items.Add("AP", "AP");
                    OrigModule1.Items.Add("AR", "AR");
                    OrigModule1.Items.Add("CA", "CA");
                    PayeeLocationID1 = new Selector("_ctl00_phG_PXSplitContainer_grid1_lv0_es", "Location", grid.Locator, "PayeeLocationID1");
                    PayeeLocationID1.DataField = "PayeeLocationID1";
                    TranID = new PXNumberEdit("ctl00_phG_PXSplitContainer_grid1_en", "ID", grid.Locator, "TranID");
                    TranID.DataField = "TranID";
                    MatchStatsInfo = new PXTextEdit("ctl00_phG_PXSplitContainer_grid1_ei", "MatchStatsInfo", grid.Locator, "MatchStatsInfo");
                    MatchStatsInfo.DataField = "MatchStatsInfo";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter Status { get; }
				public CheckBoxColumnFilter DocumentMatched { get; }
				public CheckBoxColumnFilter RuleApplied { get; }
				public CheckBoxColumnFilter ApplyRuleEnabled { get; }
				public PXTextEditColumnFilter ExtTranID { get; }
				public PXTextEditColumnFilter ExtRefNbr { get; }
				public DateSelectorColumnFilter TranDate { get; }
				public PXNumberEditColumnFilter CuryDebitAmt { get; }
				public PXNumberEditColumnFilter CuryCreditAmt { get; }
				public PXTextEditColumnFilter CardNumber { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXTextEditColumnFilter UsrVEParticulars { get; }
				public PXTextEditColumnFilter UsrVECode { get; }
				public PXTextEditColumnFilter UsrVEReference { get; }
				public PXTextEditColumnFilter TranCode { get; }
				public DateSelectorColumnFilter TranEntryDate { get; }
				public PXTextEditColumnFilter PayeeName { get; }
				public SelectorColumnFilter EntryTypeID1 { get; }
				public PXTextEditColumnFilter InvoiceInfo1 { get; }
				public SelectorColumnFilter PaymentMethodID1 { get; }
				public SelectorColumnFilter PayeeBAccountID1 { get; }
				public SelectorColumnFilter AcctName { get; }
				public DropDownColumnFilter OrigModule1 { get; }
				public SelectorColumnFilter PayeeLocationID1 { get; }
				public PXNumberEditColumnFilter TranID { get; }
				public PXTextEditColumnFilter MatchStatsInfo { get; }
                
                public c_grid_header(c_details_grid1 grid) : 
                        base(grid)
                {
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    DocumentMatched = new CheckBoxColumnFilter(grid.Row.DocumentMatched);
                    RuleApplied = new CheckBoxColumnFilter(grid.Row.RuleApplied);
                    ApplyRuleEnabled = new CheckBoxColumnFilter(grid.Row.ApplyRuleEnabled);
                    ExtTranID = new PXTextEditColumnFilter(grid.Row.ExtTranID);
                    ExtRefNbr = new PXTextEditColumnFilter(grid.Row.ExtRefNbr);
                    TranDate = new DateSelectorColumnFilter(grid.Row.TranDate);
                    CuryDebitAmt = new PXNumberEditColumnFilter(grid.Row.CuryDebitAmt);
                    CuryCreditAmt = new PXNumberEditColumnFilter(grid.Row.CuryCreditAmt);
                    CardNumber = new PXTextEditColumnFilter(grid.Row.CardNumber);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    UsrVEParticulars = new PXTextEditColumnFilter(grid.Row.UsrVEParticulars);
                    UsrVECode = new PXTextEditColumnFilter(grid.Row.UsrVECode);
                    UsrVEReference = new PXTextEditColumnFilter(grid.Row.UsrVEReference);
                    TranCode = new PXTextEditColumnFilter(grid.Row.TranCode);
                    TranEntryDate = new DateSelectorColumnFilter(grid.Row.TranEntryDate);
                    PayeeName = new PXTextEditColumnFilter(grid.Row.PayeeName);
                    EntryTypeID1 = new SelectorColumnFilter(grid.Row.EntryTypeID1);
                    InvoiceInfo1 = new PXTextEditColumnFilter(grid.Row.InvoiceInfo1);
                    PaymentMethodID1 = new SelectorColumnFilter(grid.Row.PaymentMethodID1);
                    PayeeBAccountID1 = new SelectorColumnFilter(grid.Row.PayeeBAccountID1);
                    AcctName = new SelectorColumnFilter(grid.Row.AcctName);
                    OrigModule1 = new DropDownColumnFilter(grid.Row.OrigModule1);
                    PayeeLocationID1 = new SelectorColumnFilter(grid.Row.PayeeLocationID1);
                    TranID = new PXNumberEditColumnFilter(grid.Row.TranID);
                    MatchStatsInfo = new PXTextEditColumnFilter(grid.Row.MatchStatsInfo);
                }
            }
        }
        
        public class c_details_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_details_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PXSplitContainer_grid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PXSplitContainer_grid1_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PXSplitContainer_grid1_lv0_ec", "Ec", locator, null);
                DataMemberName = "Details";
            }
        }
        
        public class c_currentcabanktran_pxtaxformview1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
            
            public c_currentcabanktran_pxtaxformview1(string locator, string name) : 
                    base(locator, name)
            {
                TaxZoneID = new Selector("ctl00_phG_PXTaxPanel_PXTaxFormView1_edTaxZoneID", "Tax Zone", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                TaxCalcMode = new DropDown("ctl00_phG_PXTaxPanel_PXTaxFormView1_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                DataMemberName = "CurrentCABankTran";
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
                    Ok = new Button("ctl00_phG_PXTaxPanel_PXButton1", "Ok", "ctl00_phG_PXTaxPanel_PXTaxFormView1");
                }
            }
        }
        
        public class c_detailsforpaymentcreation_frmcreatedocument : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox CreateDocument { get; }
			public Label CreateDocumentLabel { get; }
			public Selector RuleID { get; }
			public Label RuleIDLabel { get; }
			public DropDown OrigModule { get; }
			public Label OrigModuleLabel { get; }
			public DateSelector MatchingPaymentDate { get; }
			public Label MatchingPaymentDateLabel { get; }
			public Selector MatchingFinPeriodID { get; }
			public Label MatchingFinPeriodIDLabel { get; }
			public Selector EntryTypeID { get; }
			public Label EntryTypeIDLabel { get; }
			public Selector PayeeBAccountID { get; }
			public Label PayeeBAccountIDLabel { get; }
			public Selector PayeeLocationID { get; }
			public Label PayeeLocationIDLabel { get; }
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public Selector PMInstanceID { get; }
			public Label PMInstanceIDLabel { get; }
			public PXTextEdit InvoiceInfo { get; }
			public Label InvoiceInfoLabel { get; }
			public PXNumberEdit CuryDetailsWithTaxesTotal { get; }
			public Label CuryDetailsWithTaxesTotalLabel { get; }
			public PXNumberEdit CuryTotalAmt { get; }
			public Label CuryTotalAmtLabel { get; }
			public PXNumberEdit CuryApplAmt { get; }
			public Label CuryApplAmtLabel { get; }
			public PXNumberEdit CuryUnappliedBal { get; }
			public Label CuryUnappliedBalLabel { get; }
			public PXNumberEdit CuryWOAmt { get; }
			public Label CuryWOAmtLabel { get; }
			public PXNumberEdit CuryApplAmtCA { get; }
			public Label CuryApplAmtCALabel { get; }
			public PXNumberEdit CuryTaxTotal { get; }
			public Label CuryTaxTotalLabel { get; }
			public PXNumberEdit CuryUnappliedBalCA { get; }
			public Label CuryUnappliedBalCALabel { get; }
			public PXTextEdit UserDesc { get; }
			public Label UserDescLabel { get; }
			public Label Ctl11_ { get; }
			public Label Ctl12_ { get; }
            
            public c_detailsforpaymentcreation_frmcreatedocument(string locator, string name) : 
                    base(locator, name)
            {
                CreateDocument = new CheckBox("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCreateDocument", "Create", locator, null);
                CreateDocumentLabel = new Label(CreateDocument);
                CreateDocument.DataField = "CreateDocument";
                RuleID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edRuleID", "Applied Rule", locator, null);
                RuleIDLabel = new Label(RuleID);
                RuleID.DataField = "RuleID";
                OrigModule = new DropDown("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edOrigModule", "Module", locator, null);
                OrigModuleLabel = new Label(OrigModule);
                OrigModule.DataField = "OrigModule";
                OrigModule.Items.Add("AP", "AP");
                OrigModule.Items.Add("AR", "AR");
                OrigModule.Items.Add("CA", "CA");
                MatchingPaymentDate = new DateSelector("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edMatchingPaymentDate", "Payment Date", locator, null);
                MatchingPaymentDateLabel = new Label(MatchingPaymentDate);
                MatchingPaymentDate.DataField = "MatchingPaymentDate";
                MatchingFinPeriodID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edMatchingFinPeriodID", "Fin. Period", locator, null);
                MatchingFinPeriodIDLabel = new Label(MatchingFinPeriodID);
                MatchingFinPeriodID.DataField = "MatchingFinPeriodID";
                EntryTypeID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edEntryTypeID", "Entry Type ID", locator, null);
                EntryTypeIDLabel = new Label(EntryTypeID);
                EntryTypeID.DataField = "EntryTypeID";
                PayeeBAccountID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPayeeBAccountID", "Business Account", locator, null);
                PayeeBAccountIDLabel = new Label(PayeeBAccountID);
                PayeeBAccountID.DataField = "PayeeBAccountID";
                PayeeLocationID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPayeeLocationID", "Location", locator, null);
                PayeeLocationIDLabel = new Label(PayeeLocationID);
                PayeeLocationID.DataField = "PayeeLocationID";
                PaymentMethodID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                PMInstanceID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPMInstanceID", "Card/Account Nbr.", locator, null);
                PMInstanceIDLabel = new Label(PMInstanceID);
                PMInstanceID.DataField = "PMInstanceID";
                InvoiceInfo = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edInvoiceInfo", "Invoice Nbr.", locator, null);
                InvoiceInfoLabel = new Label(InvoiceInfo);
                InvoiceInfo.DataField = "InvoiceInfo";
                CuryDetailsWithTaxesTotal = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCuryDetailsWithTaxesTotal", "Amount", locator, null);
                CuryDetailsWithTaxesTotalLabel = new Label(CuryDetailsWithTaxesTotal);
                CuryDetailsWithTaxesTotal.DataField = "CuryDetailsWithTaxesTotal";
                CuryTotalAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCuryTotalAmt", "Total Amount", locator, null);
                CuryTotalAmtLabel = new Label(CuryTotalAmt);
                CuryTotalAmt.DataField = "CuryTotalAmt";
                CuryApplAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCuryApplAmt", "Application Amount", locator, null);
                CuryApplAmtLabel = new Label(CuryApplAmt);
                CuryApplAmt.DataField = "CuryApplAmt";
                CuryUnappliedBal = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCuryUnappliedBal", "Unapplied Balance", locator, null);
                CuryUnappliedBalLabel = new Label(CuryUnappliedBal);
                CuryUnappliedBal.DataField = "CuryUnappliedBal";
                CuryWOAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCuryWOAmt", "Write-Off Amount", locator, null);
                CuryWOAmtLabel = new Label(CuryWOAmt);
                CuryWOAmt.DataField = "CuryWOAmt";
                CuryApplAmtCA = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCuryApplAmtCA", "Detail Total", locator, null);
                CuryApplAmtCALabel = new Label(CuryApplAmtCA);
                CuryApplAmtCA.DataField = "CuryApplAmtCA";
                CuryTaxTotal = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCuryTaxTotal", "Tax Total", locator, null);
                CuryTaxTotalLabel = new Label(CuryTaxTotal);
                CuryTaxTotal.DataField = "CuryTaxTotal";
                CuryUnappliedBalCA = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edCuryUnappliedBalCA", "Discrepancy", locator, null);
                CuryUnappliedBalCALabel = new Label(CuryUnappliedBalCA);
                CuryUnappliedBalCA.DataField = "CuryUnappliedBalCA";
                UserDesc = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edUserDesc", "Tran. Desc", locator, null);
                UserDescLabel = new Label(UserDesc);
                UserDesc.DataField = "UserDesc";
                Ctl11_ = new Label("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_ctl11", "Ctl 11_", locator, null);
                Ctl12_ = new Label("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_ctl12", "Ctl 12_", locator, null);
                DataMemberName = "DetailsForPaymentCreation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ClearRule()
            {
                Buttons.ClearRule.Click();
            }
            
            public virtual void CreateRule()
            {
                Buttons.CreateRule.Click();
            }
            
            public virtual void PayeeBAccountIDEdit()
            {
                Buttons.PayeeBAccountIDEdit.Click();
            }
            
            public virtual void Attachfile()
            {
                Buttons.Attachfile.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ClearRule { get; }
			public Button CreateRule { get; }
			public Button PayeeBAccountIDEdit { get; }
			public Button Attachfile { get; }
                
                public PxButtonCollection()
                {
                    ClearRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnUnapplyRule", "Clear Rule", "ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument");
                    CreateRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnCreateRule", "Create Rule", "ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument");
                    PayeeBAccountIDEdit = new Button("css=div[id=\'ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPayeeBAccountI" +
                            "D\'] div[class=\'editBtnCont\'] > div > div", "PayeeBAccountIDEdit", "ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument");
                    PayeeBAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Attachfile = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_imf", "Attach file", "ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument");
                }
            }
        }
        
        public class c_detailsforinvoiceapplication_frmcreatedocumentinv : Container
        {
            
			public CheckBox MultipleMatching { get; }
			public Label MultipleMatchingLabel { get; }
			public Selector PayeeBAccountIDCopy { get; }
			public Label PayeeBAccountIDCopyLabel { get; }
			public Selector PayeeLocationIDCopy { get; }
			public Label PayeeLocationIDCopyLabel { get; }
			public Selector PaymentMethodIDCopy { get; }
			public Label PaymentMethodIDCopyLabel { get; }
			public Selector PMInstanceIDCopy { get; }
			public Label PMInstanceIDCopyLabel { get; }
			public Selector ChargeTypeID { get; }
			public Label ChargeTypeIDLabel { get; }
			public PXNumberEdit CuryTotalAmtCopy { get; }
			public Label CuryTotalAmtCopyLabel { get; }
			public PXNumberEdit CuryApplAmtMatchToInvoice { get; }
			public Label CuryApplAmtMatchToInvoiceLabel { get; }
			public PXNumberEdit CuryChargeAmt { get; }
			public Label CuryChargeAmtLabel { get; }
			public PXNumberEdit CuryChargeTaxAmt { get; }
			public Label CuryChargeTaxAmtLabel { get; }
			public PXNumberEdit CuryUnappliedBalMatchToInvoice { get; }
			public Label CuryUnappliedBalMatchToInvoiceLabel { get; }
            
            public c_detailsforinvoiceapplication_frmcreatedocumentinv(string locator, string name) : 
                    base(locator, name)
            {
                MultipleMatching = new CheckBox("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edMultipleMatching", "Match to Multiple Documents", locator, null);
                MultipleMatchingLabel = new Label(MultipleMatching);
                MultipleMatching.DataField = "MultipleMatching";
                PayeeBAccountIDCopy = new Selector("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edPayeeBAccountID", "Business Account", locator, null);
                PayeeBAccountIDCopyLabel = new Label(PayeeBAccountIDCopy);
                PayeeBAccountIDCopy.DataField = "PayeeBAccountIDCopy";
                PayeeLocationIDCopy = new Selector("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edPayeeLocationID", "Location", locator, null);
                PayeeLocationIDCopyLabel = new Label(PayeeLocationIDCopy);
                PayeeLocationIDCopy.DataField = "PayeeLocationIDCopy";
                PaymentMethodIDCopy = new Selector("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDCopyLabel = new Label(PaymentMethodIDCopy);
                PaymentMethodIDCopy.DataField = "PaymentMethodIDCopy";
                PMInstanceIDCopy = new Selector("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edPMInstanceID", "Card/Account Nbr.", locator, null);
                PMInstanceIDCopyLabel = new Label(PMInstanceIDCopy);
                PMInstanceIDCopy.DataField = "PMInstanceIDCopy";
                ChargeTypeID = new Selector("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edChargeTypeID", "Charge Type", locator, null);
                ChargeTypeIDLabel = new Label(ChargeTypeID);
                ChargeTypeID.DataField = "ChargeTypeID";
                CuryTotalAmtCopy = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edCuryTotalAmtCopy", "Transaction Amount", locator, null);
                CuryTotalAmtCopyLabel = new Label(CuryTotalAmtCopy);
                CuryTotalAmtCopy.DataField = "CuryTotalAmtCopy";
                CuryApplAmtMatchToInvoice = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edCuryApplAmtMatchToInvoi" +
                        "ce", "Matched Amount", locator, null);
                CuryApplAmtMatchToInvoiceLabel = new Label(CuryApplAmtMatchToInvoice);
                CuryApplAmtMatchToInvoice.DataField = "CuryApplAmtMatchToInvoice";
                CuryChargeAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edCuryChargeAmt", "Charge Amount", locator, null);
                CuryChargeAmtLabel = new Label(CuryChargeAmt);
                CuryChargeAmt.DataField = "CuryChargeAmt";
                CuryChargeTaxAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edCuryChargeTaxAmt", "Charge Tax Amount", locator, null);
                CuryChargeTaxAmtLabel = new Label(CuryChargeTaxAmt);
                CuryChargeTaxAmt.DataField = "CuryChargeTaxAmt";
                CuryUnappliedBalMatchToInvoice = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t1_frmCreateDocumentInv_edCuryUnappliedBalMatchTo" +
                        "Invoice", "Unmatched Amount", locator, null);
                CuryUnappliedBalMatchToInvoiceLabel = new Label(CuryUnappliedBalMatchToInvoice);
                CuryUnappliedBalMatchToInvoice.DataField = "CuryUnappliedBalMatchToInvoice";
                DataMemberName = "DetailsForInvoiceApplication";
            }
        }
        
        public class c_detailsforpaymentmatching_frmmatchtopayments : Container
        {
            
			public CheckBox MultipleMatchingToPayments { get; }
			public Label MultipleMatchingToPaymentsLabel { get; }
			public CheckBox MatchReceiptsAndDisbursements { get; }
			public Label MatchReceiptsAndDisbursementsLabel { get; }
			public PXNumberEdit CuryTotalAmtDisplay { get; }
			public Label CuryTotalAmtDisplayLabel { get; }
			public PXNumberEdit CuryApplAmtMatchToPayment { get; }
			public Label CuryApplAmtMatchToPaymentLabel { get; }
			public PXNumberEdit CuryUnappliedBalMatchToPayment { get; }
			public Label CuryUnappliedBalMatchToPaymentLabel { get; }
            
            public c_detailsforpaymentmatching_frmmatchtopayments(string locator, string name) : 
                    base(locator, name)
            {
                MultipleMatchingToPayments = new CheckBox("ctl00_phG_PXSplitContainer_tab2_t0_frmMatchToPayments_edMultipleMatchingToPayment" +
                        "s", "Match to Multiple Payments", locator, null);
                MultipleMatchingToPaymentsLabel = new Label(MultipleMatchingToPayments);
                MultipleMatchingToPayments.DataField = "MultipleMatchingToPayments";
                MatchReceiptsAndDisbursements = new CheckBox("ctl00_phG_PXSplitContainer_tab2_t0_frmMatchToPayments_edMatchReceiptsAndDisbursem" +
                        "ents", "Match to Receipts and Disbursements", locator, null);
                MatchReceiptsAndDisbursementsLabel = new Label(MatchReceiptsAndDisbursements);
                MatchReceiptsAndDisbursements.DataField = "MatchReceiptsAndDisbursements";
                CuryTotalAmtDisplay = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t0_frmMatchToPayments_edCuryTotalAmtCopy1", "Transaction Amount", locator, null);
                CuryTotalAmtDisplayLabel = new Label(CuryTotalAmtDisplay);
                CuryTotalAmtDisplay.DataField = "CuryTotalAmtDisplay";
                CuryApplAmtMatchToPayment = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t0_frmMatchToPayments_edCuryApplAmtMatch1", "Matched Amount", locator, null);
                CuryApplAmtMatchToPaymentLabel = new Label(CuryApplAmtMatchToPayment);
                CuryApplAmtMatchToPayment.DataField = "CuryApplAmtMatchToPayment";
                CuryUnappliedBalMatchToPayment = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t0_frmMatchToPayments_edCuryUnappliedBalMatch1", "Unmatched Amount", locator, null);
                CuryUnappliedBalMatchToPaymentLabel = new Label(CuryUnappliedBalMatchToPayment);
                CuryUnappliedBalMatchToPayment.DataField = "CuryUnappliedBalMatchToPayment";
                DataMemberName = "DetailsForPaymentMatching";
            }
        }
        
        public class c_taxtrans_pxtaxgrid : Grid<c_taxtrans_pxtaxgrid.c_grid_row, c_taxtrans_pxtaxgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_taxtrans_pxtaxgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXTaxPanel_PXTaxGrid");
                DataMemberName = "TaxTrans";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PXTaxPanel_PXTaxGrid_fe_gf", "FilterForm");
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXTaxPanel_PXTaxGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_PXTaxPanel_PXButton1", "Ok", "ctl00_phG_PXTaxPanel_PXTaxGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector TaxID { get; }
			public PXNumberEdit TaxRate { get; }
			public PXNumberEdit CuryTaxableAmt { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public PXNumberEdit NonDeductibleTaxRate { get; }
			public PXNumberEdit CuryExpenseAmt { get; }
			public PXTextEdit Module { get; }
			public DropDown BankTranType { get; }
			public PXNumberEdit BankTranID { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_taxtrans_pxtaxgrid grid) : 
                        base(grid)
                {
                    TaxID = new Selector("_ctl00_phG_PXTaxPanel_PXTaxGrid_lv0_es", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    TaxRate = new PXNumberEdit("ctl00_phG_PXTaxPanel_PXTaxGrid_en", "Tax Rate", grid.Locator, "TaxRate");
                    TaxRate.DataField = "TaxRate";
                    CuryTaxableAmt = new PXNumberEdit("ctl00_phG_PXTaxPanel_PXTaxGrid_en", "Taxable Amount", grid.Locator, "CuryTaxableAmt");
                    CuryTaxableAmt.DataField = "CuryTaxableAmt";
                    CuryTaxAmt = new PXNumberEdit("ctl00_phG_PXTaxPanel_PXTaxGrid_en", "Tax Amount", grid.Locator, "CuryTaxAmt");
                    CuryTaxAmt.DataField = "CuryTaxAmt";
                    NonDeductibleTaxRate = new PXNumberEdit("ctl00_phG_PXTaxPanel_PXTaxGrid_en", "Deductible Tax Rate", grid.Locator, "NonDeductibleTaxRate");
                    NonDeductibleTaxRate.DataField = "NonDeductibleTaxRate";
                    CuryExpenseAmt = new PXNumberEdit("ctl00_phG_PXTaxPanel_PXTaxGrid_en", "Expense Amount", grid.Locator, "CuryExpenseAmt");
                    CuryExpenseAmt.DataField = "CuryExpenseAmt";
                    Module = new PXTextEdit("ctl00_phG_PXTaxPanel_PXTaxGrid_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    BankTranType = new DropDown("_ctl00_phG_PXTaxPanel_PXTaxGrid_lv0_ec", "Type", grid.Locator, "BankTranType");
                    BankTranType.DataField = "BankTranType";
                    BankTranType.Items.Add("S", "Bank Statement Import");
                    BankTranType.Items.Add("I", "Payments Import");
                    BankTranID = new PXNumberEdit("ctl00_phG_PXTaxPanel_PXTaxGrid_en", "BankTranID", grid.Locator, "BankTranID");
                    BankTranID.DataField = "BankTranID";
                    RecordID = new PXNumberEdit("ctl00_phG_PXTaxPanel_PXTaxGrid_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter TaxID { get; }
				public PXNumberEditColumnFilter TaxRate { get; }
				public PXNumberEditColumnFilter CuryTaxableAmt { get; }
				public PXNumberEditColumnFilter CuryTaxAmt { get; }
				public PXNumberEditColumnFilter NonDeductibleTaxRate { get; }
				public PXNumberEditColumnFilter CuryExpenseAmt { get; }
				public PXTextEditColumnFilter Module { get; }
				public DropDownColumnFilter BankTranType { get; }
				public PXNumberEditColumnFilter BankTranID { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_taxtrans_pxtaxgrid grid) : 
                        base(grid)
                {
                    TaxID = new SelectorColumnFilter(grid.Row.TaxID);
                    TaxRate = new PXNumberEditColumnFilter(grid.Row.TaxRate);
                    CuryTaxableAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxableAmt);
                    CuryTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxAmt);
                    NonDeductibleTaxRate = new PXNumberEditColumnFilter(grid.Row.NonDeductibleTaxRate);
                    CuryExpenseAmt = new PXNumberEditColumnFilter(grid.Row.CuryExpenseAmt);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
                    BankTranType = new DropDownColumnFilter(grid.Row.BankTranType);
                    BankTranID = new PXNumberEditColumnFilter(grid.Row.BankTranID);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_taxtrans_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_taxtrans_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PXTaxPanel_PXTaxGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_PXTaxPanel_PXTaxGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "TaxTrans";
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
                    Ok = new Button("ctl00_phG_PXTaxPanel_PXButton1", "Ok", "ctl00_phG_PXTaxPanel_PXTaxGrid_lv0");
                }
            }
        }
        
        public class c_detailmatchesca_pxgrid1 : Grid<c_detailmatchesca_pxgrid1.c_grid_row, c_detailmatchesca_pxgrid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_detailmatchesca_pxgrid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1");
                DataMemberName = "DetailMatchesCA";
                QuickSearch = new QuickSearch("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_at_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
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
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_at_tlb div[data-cmd=\'AdjustColumn" +
                            "s\']", "Fit to Screen", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsMatched { get; }
			public PXNumberEdit MatchRelevancePercent { get; }
			public PXTextEdit OrigRefNbr { get; }
			public DateSelector TranDate { get; }
			public PXTextEdit ExtRefNbr { get; }
			public DropDown OrigModule { get; }
			public DropDown OrigTranType { get; }
			public PXTextEdit TranDesc { get; }
			public PXTextEdit FinPeriodID { get; }
			public PXNumberEdit CuryTranAbsAmt { get; }
			public PXNumberEdit CuryTranAmtCalc { get; }
			public Selector ReferenceID { get; }
			public PXTextEdit ReferenceID_description { get; }
			public Selector TranID { get; }
                
                public c_grid_row(c_detailmatchesca_pxgrid1 grid) : 
                        base(grid)
                {
                    IsMatched = new CheckBox("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ef", "Matched", grid.Locator, "IsMatched");
                    IsMatched.DataField = "IsMatched";
                    MatchRelevancePercent = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_en", "Match Relevance, %", grid.Locator, "MatchRelevancePercent");
                    MatchRelevancePercent.DataField = "MatchRelevancePercent";
                    OrigRefNbr = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ei", "Orig. Doc. Number", grid.Locator, "OrigRefNbr");
                    OrigRefNbr.DataField = "OrigRefNbr";
                    TranDate = new DateSelector("_ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_ed3", "Doc. Date", grid.Locator, "TranDate");
                    TranDate.DataField = "TranDate";
                    ExtRefNbr = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ei", "Document Ref.", grid.Locator, "ExtRefNbr");
                    ExtRefNbr.DataField = "ExtRefNbr";
                    OrigModule = new DropDown("_ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_ec", "Module", grid.Locator, "OrigModule");
                    OrigModule.DataField = "OrigModule";
                    OrigModule.Items.Add("GL", "GL");
                    OrigModule.Items.Add("AP", "AP");
                    OrigModule.Items.Add("AR", "AR");
                    OrigModule.Items.Add("CM", "CM");
                    OrigModule.Items.Add("CA", "CA");
                    OrigModule.Items.Add("IN", "IN");
                    OrigModule.Items.Add("DR", "DR");
                    OrigModule.Items.Add("FA", "FA");
                    OrigModule.Items.Add("PM", "PM");
                    OrigModule.Items.Add("PR", "PR");
                    OrigTranType = new DropDown("_ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_ec", "Tran. Type", grid.Locator, "OrigTranType");
                    OrigTranType.DataField = "OrigTranType";
                    OrigTranType.Items.Add("CTO", "Transfer Out");
                    OrigTranType.Items.Add("CTI", "Transfer In");
                    OrigTranType.Items.Add("CTE", "Expense Entry");
                    OrigTranType.Items.Add("CAE", "Cash Entry");
                    OrigTranType.Items.Add("CDT", "CA Deposit");
                    OrigTranType.Items.Add("CVD", "CA Void Deposit");
                    OrigTranType.Items.Add("CT%", "Transfer");
                    OrigTranType.Items.Add("GLE", "GL Entry");
                    OrigTranType.Items.Add("CBT", "AP Batch");
                    OrigTranType.Items.Add("ACR", "Credit Adj.");
                    OrigTranType.Items.Add("ADR", "Debit Adj.");
                    OrigTranType.Items.Add("CHK", "Check");
                    OrigTranType.Items.Add("VCK", "Voided Check");
                    OrigTranType.Items.Add("QCK", "Quick Check");
                    OrigTranType.Items.Add("VQC", "Void Quick Check");
                    OrigTranType.Items.Add("PPR", "Prepayment Req.");
                    OrigTranType.Items.Add("DRM", "Debit Memo");
                    OrigTranType.Items.Add("CRM", "Credit Memo");
                    OrigTranType.Items.Add("PMT", "Payment");
                    OrigTranType.Items.Add("RPM", "Voided Payment");
                    OrigTranType.Items.Add("FCH", "Overdue Charge");
                    OrigTranType.Items.Add("SMB", "Balance WO");
                    OrigTranType.Items.Add("SMC", "Credit WO");
                    OrigTranType.Items.Add("CSL", "Cash Sale");
                    OrigTranType.Items.Add("RCS", "Cash Return");
                    OrigTranType.Items.Add("INV", "AR Invoice or AP Bill");
                    OrigTranType.Items.Add("PPM", "Prepayment");
                    OrigTranType.Items.Add("REF", "Refund");
                    OrigTranType.Items.Add("VRF", "Voided Refund");
                    OrigTranType.Items.Add("ECD", "Expense Receipt");
                    TranDesc = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ei", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    FinPeriodID = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_em", "Post Period", grid.Locator, "FinPeriodID");
                    FinPeriodID.DataField = "FinPeriodID";
                    CuryTranAbsAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_en", "Amount", grid.Locator, "CuryTranAbsAmt");
                    CuryTranAbsAmt.DataField = "CuryTranAbsAmt";
                    CuryTranAmtCalc = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_en", "Amount", grid.Locator, "CuryTranAmtCalc");
                    CuryTranAmtCalc.DataField = "CuryTranAmtCalc";
                    ReferenceID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_es", "Business Account", grid.Locator, "ReferenceID");
                    ReferenceID.DataField = "ReferenceID";
                    ReferenceID_description = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_ei", "Business Account Name", grid.Locator, "ReferenceID_description");
                    ReferenceID_description.DataField = "ReferenceID_description";
                    TranID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_es", "Document Number", grid.Locator, "TranID");
                    TranID.DataField = "TranID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter IsMatched { get; }
				public PXNumberEditColumnFilter MatchRelevancePercent { get; }
				public PXTextEditColumnFilter OrigRefNbr { get; }
				public DateSelectorColumnFilter TranDate { get; }
				public PXTextEditColumnFilter ExtRefNbr { get; }
				public DropDownColumnFilter OrigModule { get; }
				public DropDownColumnFilter OrigTranType { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXTextEditColumnFilter FinPeriodID { get; }
				public PXNumberEditColumnFilter CuryTranAbsAmt { get; }
				public PXNumberEditColumnFilter CuryTranAmtCalc { get; }
				public SelectorColumnFilter ReferenceID { get; }
				public PXTextEditColumnFilter ReferenceID_description { get; }
				public SelectorColumnFilter TranID { get; }
                
                public c_grid_header(c_detailmatchesca_pxgrid1 grid) : 
                        base(grid)
                {
                    IsMatched = new CheckBoxColumnFilter(grid.Row.IsMatched);
                    MatchRelevancePercent = new PXNumberEditColumnFilter(grid.Row.MatchRelevancePercent);
                    OrigRefNbr = new PXTextEditColumnFilter(grid.Row.OrigRefNbr);
                    TranDate = new DateSelectorColumnFilter(grid.Row.TranDate);
                    ExtRefNbr = new PXTextEditColumnFilter(grid.Row.ExtRefNbr);
                    OrigModule = new DropDownColumnFilter(grid.Row.OrigModule);
                    OrigTranType = new DropDownColumnFilter(grid.Row.OrigTranType);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    FinPeriodID = new PXTextEditColumnFilter(grid.Row.FinPeriodID);
                    CuryTranAbsAmt = new PXNumberEditColumnFilter(grid.Row.CuryTranAbsAmt);
                    CuryTranAmtCalc = new PXNumberEditColumnFilter(grid.Row.CuryTranAmtCalc);
                    ReferenceID = new SelectorColumnFilter(grid.Row.ReferenceID);
                    ReferenceID_description = new PXTextEditColumnFilter(grid.Row.ReferenceID_description);
                    TranID = new SelectorColumnFilter(grid.Row.TranID);
                }
            }
        }
        
        public class c_detailmatchesca_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_detailmatchesca_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PXSplitContainer_tab2_t0_PXGrid1_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "DetailMatchesCA";
            }
        }
        
        public class c_adjustments_gridadjustments : Grid<c_adjustments_gridadjustments.c_grid_row, c_adjustments_gridadjustments.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_adjustments_gridadjustments(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments");
                DataMemberName = "Adjustments";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_fe_gf", "FilterForm");
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
            
            public virtual void LoadInvoices()
            {
                ToolBar.LoadInvoices.Click();
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
            
            public virtual void Attachfile()
            {
                Buttons.Attachfile.Click();
            }
            
            public virtual void PayeeBAccountIDEdit()
            {
                Buttons.PayeeBAccountIDEdit.Click();
            }
            
            public virtual void ClearRule()
            {
                Buttons.ClearRule.Click();
            }
            
            public virtual void CreateRule()
            {
                Buttons.CreateRule.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid LoadInvoices { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_at_tlb div[data-cmd=\'Refr" +
                            "esh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_at_tlb div[data-cmd=\'AddN" +
                            "ew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_at_tlb div[data-cmd=\'Dele" +
                            "te\']", "Delete Row", locator, null);
                    LoadInvoices = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_at_tlb div[data-cmd=\'Load" +
                            "Invoices\']", "Load Documents", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_at_tlb div[data-cmd=\'Adju" +
                            "stColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_at_tlb div[data-cmd=\'Expo" +
                            "rtExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_at_tlb div[data-cmd=\'hi\']" +
                            "", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_ab_tlb div[data-cmd=\'Page" +
                            "First\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_ab_tlb div[data-cmd=\'Page" +
                            "Prev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_ab_tlb div[data-cmd=\'Page" +
                            "Next\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_ab_tlb div[data-cmd=\'Page" +
                            "Last\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_ab_tlb div[data-cmd=\'hi\']" +
                            "", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Attachfile { get; }
			public Button PayeeBAccountIDEdit { get; }
			public Button ClearRule { get; }
			public Button CreateRule { get; }
                
                public PxButtonCollection()
                {
                    Attachfile = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_imf", "Attach file", "ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments");
                    PayeeBAccountIDEdit = new Button("css=div[id=\'ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPayeeBAccountI" +
                            "D\'] div[class=\'editBtnCont\'] > div > div", "PayeeBAccountIDEdit", "ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments");
                    PayeeBAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ClearRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnUnapplyRule", "Clear Rule", "ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments");
                    CreateRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnCreateRule", "Create Rule", "ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector AdjdBranchID { get; }
			public DropDown AdjdDocType { get; }
			public Selector AdjdRefNbr { get; }
			public Selector ARInvoice__CustomerID { get; }
			public PXNumberEdit CuryAdjgAmt { get; }
			public PXNumberEdit CuryDocBal { get; }
			public PXNumberEdit CuryAdjgDiscAmt { get; }
			public PXNumberEdit CuryDiscBal { get; }
			public PXNumberEdit CuryAdjgWhTaxAmt { get; }
			public PXNumberEdit CuryWhTaxBal { get; }
			public PXNumberEdit CuryAdjgWOAmt { get; }
			public Selector WriteOffReasonCode { get; }
			public DateSelector AdjdDocDate { get; }
			public PXTextEdit AdjdFinPeriodID { get; }
			public PXTextEdit AdjdCuryID { get; }
			public PXNumberEdit AdjdCuryRate { get; }
			public PXNumberEdit TranID { get; }
			public PXNumberEdit AdjNbr { get; }
                
                public c_grid_row(c_adjustments_gridadjustments grid) : 
                        base(grid)
                {
                    AdjdBranchID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_es", "Branch", grid.Locator, "AdjdBranchID");
                    AdjdBranchID.DataField = "AdjdBranchID";
                    AdjdDocType = new DropDown("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdDocType", "Document Type", grid.Locator, "AdjdDocType");
                    AdjdDocType.DataField = "AdjdDocType";
                    AdjdDocType.Items.Add("INV", "Bill");
                    AdjdDocType.Items.Add("ACR", "Credit Adj.");
                    AdjdRefNbr = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdRefNbr", "Reference Nbr.", grid.Locator, "AdjdRefNbr");
                    AdjdRefNbr.DataField = "AdjdRefNbr";
                    ARInvoice__CustomerID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdCustomerID", "Customer", grid.Locator, "ARInvoice__CustomerID");
                    ARInvoice__CustomerID.DataField = "ARInvoice__CustomerID";
                    CuryAdjgAmt = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryAdjgAmt", "Amount Paid", grid.Locator, "CuryAdjgAmt");
                    CuryAdjgAmt.DataField = "CuryAdjgAmt";
                    CuryDocBal = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryDocBal", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    CuryAdjgDiscAmt = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryAdjgDiscAmt", "Cash Discount Taken", grid.Locator, "CuryAdjgDiscAmt");
                    CuryAdjgDiscAmt.DataField = "CuryAdjgDiscAmt";
                    CuryDiscBal = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryDiscBal", "Cash Discount Balance", grid.Locator, "CuryDiscBal");
                    CuryDiscBal.DataField = "CuryDiscBal";
                    CuryAdjgWhTaxAmt = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryAdjgWhTaxAmt", "With. Tax", grid.Locator, "CuryAdjgWhTaxAmt");
                    CuryAdjgWhTaxAmt.DataField = "CuryAdjgWhTaxAmt";
                    CuryWhTaxBal = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryWhTaxBal", "With. Tax Balance", grid.Locator, "CuryWhTaxBal");
                    CuryWhTaxBal.DataField = "CuryWhTaxBal";
                    CuryAdjgWOAmt = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryAdjgWOAmt", "Balance Write-Off", grid.Locator, "CuryAdjgWOAmt");
                    CuryAdjgWOAmt.DataField = "CuryAdjgWOAmt";
                    WriteOffReasonCode = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edWriteOffReasonCode", "Write-Off Reason Code", grid.Locator, "WriteOffReasonCode");
                    WriteOffReasonCode.DataField = "WriteOffReasonCode";
                    AdjdDocDate = new DateSelector("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdDocDate", "Date", grid.Locator, "AdjdDocDate");
                    AdjdDocDate.DataField = "AdjdDocDate";
                    AdjdFinPeriodID = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_em", "Post Period", grid.Locator, "AdjdFinPeriodID");
                    AdjdFinPeriodID.DataField = "AdjdFinPeriodID";
                    AdjdCuryID = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_ei", "Currency", grid.Locator, "AdjdCuryID");
                    AdjdCuryID.DataField = "AdjdCuryID";
                    AdjdCuryRate = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdCuryRate", "Cross Rate", grid.Locator, "AdjdCuryRate");
                    AdjdCuryRate.DataField = "AdjdCuryRate";
                    TranID = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_en", "TranID", grid.Locator, "TranID");
                    TranID.DataField = "TranID";
                    AdjNbr = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_en", "Adjustment Nbr.", grid.Locator, "AdjNbr");
                    AdjNbr.DataField = "AdjNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter AdjdBranchID { get; }
				public DropDownColumnFilter AdjdDocType { get; }
				public SelectorColumnFilter AdjdRefNbr { get; }
				public SelectorColumnFilter ARInvoice__CustomerID { get; }
				public PXNumberEditColumnFilter CuryAdjgAmt { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public PXNumberEditColumnFilter CuryAdjgDiscAmt { get; }
				public PXNumberEditColumnFilter CuryDiscBal { get; }
				public PXNumberEditColumnFilter CuryAdjgWhTaxAmt { get; }
				public PXNumberEditColumnFilter CuryWhTaxBal { get; }
				public PXNumberEditColumnFilter CuryAdjgWOAmt { get; }
				public SelectorColumnFilter WriteOffReasonCode { get; }
				public DateSelectorColumnFilter AdjdDocDate { get; }
				public PXTextEditColumnFilter AdjdFinPeriodID { get; }
				public PXTextEditColumnFilter AdjdCuryID { get; }
				public PXNumberEditColumnFilter AdjdCuryRate { get; }
				public PXNumberEditColumnFilter TranID { get; }
				public PXNumberEditColumnFilter AdjNbr { get; }
                
                public c_grid_header(c_adjustments_gridadjustments grid) : 
                        base(grid)
                {
                    AdjdBranchID = new SelectorColumnFilter(grid.Row.AdjdBranchID);
                    AdjdDocType = new DropDownColumnFilter(grid.Row.AdjdDocType);
                    AdjdRefNbr = new SelectorColumnFilter(grid.Row.AdjdRefNbr);
                    ARInvoice__CustomerID = new SelectorColumnFilter(grid.Row.ARInvoice__CustomerID);
                    CuryAdjgAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgAmt);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    CuryAdjgDiscAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgDiscAmt);
                    CuryDiscBal = new PXNumberEditColumnFilter(grid.Row.CuryDiscBal);
                    CuryAdjgWhTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgWhTaxAmt);
                    CuryWhTaxBal = new PXNumberEditColumnFilter(grid.Row.CuryWhTaxBal);
                    CuryAdjgWOAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgWOAmt);
                    WriteOffReasonCode = new SelectorColumnFilter(grid.Row.WriteOffReasonCode);
                    AdjdDocDate = new DateSelectorColumnFilter(grid.Row.AdjdDocDate);
                    AdjdFinPeriodID = new PXTextEditColumnFilter(grid.Row.AdjdFinPeriodID);
                    AdjdCuryID = new PXTextEditColumnFilter(grid.Row.AdjdCuryID);
                    AdjdCuryRate = new PXNumberEditColumnFilter(grid.Row.AdjdCuryRate);
                    TranID = new PXNumberEditColumnFilter(grid.Row.TranID);
                    AdjNbr = new PXNumberEditColumnFilter(grid.Row.AdjNbr);
                }
            }
        }
        
        public class c_adjustments_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown AdjdDocType { get; }
			public Label AdjdDocTypeLabel { get; }
			public Selector AdjdRefNbr { get; }
			public Label AdjdRefNbrLabel { get; }
			public Selector ARInvoice__CustomerID { get; }
			public Label ARInvoice__CustomerIDLabel { get; }
			public PXNumberEdit CuryAdjgAmt { get; }
			public Label CuryAdjgAmtLabel { get; }
			public PXNumberEdit CuryAdjgDiscAmt { get; }
			public Label CuryAdjgDiscAmtLabel { get; }
			public PXNumberEdit CuryAdjgWhTaxAmt { get; }
			public Label CuryAdjgWhTaxAmtLabel { get; }
			public DateSelector AdjdDocDate { get; }
			public Label AdjdDocDateLabel { get; }
			public PXNumberEdit AdjdCuryRate { get; }
			public Label AdjdCuryRateLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public PXNumberEdit CuryDiscBal { get; }
			public Label CuryDiscBalLabel { get; }
			public PXNumberEdit CuryWhTaxBal { get; }
			public Label CuryWhTaxBalLabel { get; }
			public PXNumberEdit CuryAdjgWOAmt { get; }
			public Label CuryAdjgWOAmtLabel { get; }
			public Selector WriteOffReasonCode { get; }
			public Label WriteOffReasonCodeLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_adjustments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AdjdDocType = new DropDown("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdDocType", "Document Type", locator, null);
                AdjdDocTypeLabel = new Label(AdjdDocType);
                AdjdDocType.DataField = "AdjdDocType";
                AdjdDocType.Items.Add("INV", "Bill");
                AdjdDocType.Items.Add("ACR", "Credit Adj.");
                AdjdRefNbr = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdRefNbr", "Reference Nbr.", locator, null);
                AdjdRefNbrLabel = new Label(AdjdRefNbr);
                AdjdRefNbr.DataField = "AdjdRefNbr";
                ARInvoice__CustomerID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdCustomerID", "Customer", locator, null);
                ARInvoice__CustomerIDLabel = new Label(ARInvoice__CustomerID);
                ARInvoice__CustomerID.DataField = "ARInvoice__CustomerID";
                CuryAdjgAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryAdjgAmt", "Amount Paid", locator, null);
                CuryAdjgAmtLabel = new Label(CuryAdjgAmt);
                CuryAdjgAmt.DataField = "CuryAdjgAmt";
                CuryAdjgDiscAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryAdjgDiscAmt", "Cash Discount Taken", locator, null);
                CuryAdjgDiscAmtLabel = new Label(CuryAdjgDiscAmt);
                CuryAdjgDiscAmt.DataField = "CuryAdjgDiscAmt";
                CuryAdjgWhTaxAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryAdjgWhTaxAmt", "With. Tax", locator, null);
                CuryAdjgWhTaxAmtLabel = new Label(CuryAdjgWhTaxAmt);
                CuryAdjgWhTaxAmt.DataField = "CuryAdjgWhTaxAmt";
                AdjdDocDate = new DateSelector("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdDocDate", "Date", locator, null);
                AdjdDocDateLabel = new Label(AdjdDocDate);
                AdjdDocDate.DataField = "AdjdDocDate";
                AdjdCuryRate = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edAdjdCuryRate", "Cross Rate", locator, null);
                AdjdCuryRateLabel = new Label(AdjdCuryRate);
                AdjdCuryRate.DataField = "AdjdCuryRate";
                CuryDocBal = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryDocBal", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                CuryDiscBal = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryDiscBal", "Cash Discount Balance", locator, null);
                CuryDiscBalLabel = new Label(CuryDiscBal);
                CuryDiscBal.DataField = "CuryDiscBal";
                CuryWhTaxBal = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryWhTaxBal", "With. Tax Balance", locator, null);
                CuryWhTaxBalLabel = new Label(CuryWhTaxBal);
                CuryWhTaxBal.DataField = "CuryWhTaxBal";
                CuryAdjgWOAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edCuryAdjgWOAmt", "Balance Write-Off", locator, null);
                CuryAdjgWOAmtLabel = new Label(CuryAdjgWOAmt);
                CuryAdjgWOAmt.DataField = "CuryAdjgWOAmt";
                WriteOffReasonCode = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_edWriteOffReasonCode", "Write-Off Reason Code", locator, null);
                WriteOffReasonCodeLabel = new Label(WriteOffReasonCode);
                WriteOffReasonCode.DataField = "WriteOffReasonCode";
                Es = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Adjustments";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Attachfile()
            {
                Buttons.Attachfile.Click();
            }
            
            public virtual void PayeeBAccountIDEdit()
            {
                Buttons.PayeeBAccountIDEdit.Click();
            }
            
            public virtual void ClearRule()
            {
                Buttons.ClearRule.Click();
            }
            
            public virtual void CreateRule()
            {
                Buttons.CreateRule.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Attachfile { get; }
			public Button PayeeBAccountIDEdit { get; }
			public Button ClearRule { get; }
			public Button CreateRule { get; }
                
                public PxButtonCollection()
                {
                    Attachfile = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_imf", "Attach file", "ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0");
                    PayeeBAccountIDEdit = new Button("css=div[id=\'ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPayeeBAccountI" +
                            "D\'] div[class=\'editBtnCont\'] > div > div", "PayeeBAccountIDEdit", "ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0");
                    PayeeBAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ClearRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnUnapplyRule", "Clear Rule", "ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0");
                    CreateRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnCreateRule", "Create Rule", "ctl00_phG_PXSplitContainer_tab2_t3_gridAdjustments_lv0");
                }
            }
        }
        
        public class c_cashaccount_tabmatchsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit DisbursementTranDaysBefore { get; }
			public Label DisbursementTranDaysBeforeLabel { get; }
			public PXNumberEdit DisbursementTranDaysAfter { get; }
			public Label DisbursementTranDaysAfterLabel { get; }
			public CheckBox AllowMatchingCreditMemo { get; }
			public Label AllowMatchingCreditMemoLabel { get; }
			public PXNumberEdit ReceiptTranDaysBefore { get; }
			public Label ReceiptTranDaysBeforeLabel { get; }
			public PXNumberEdit ReceiptTranDaysAfter { get; }
			public Label ReceiptTranDaysAfterLabel { get; }
			public CheckBox InvoiceFilterByCashAccount { get; }
			public Label InvoiceFilterByCashAccountLabel { get; }
			public CheckBox InvoiceFilterByDate { get; }
			public Label InvoiceFilterByDateLabel { get; }
			public PXNumberEdit DaysBeforeInvoiceDiscountDate { get; }
			public Label DaysBeforeInvoiceDiscountDateLabel { get; }
			public PXNumberEdit DaysBeforeInvoiceDueDate { get; }
			public Label DaysBeforeInvoiceDueDateLabel { get; }
			public PXNumberEdit DaysAfterInvoiceDueDate { get; }
			public Label DaysAfterInvoiceDueDateLabel { get; }
			public CheckBox SkipVoided { get; }
			public Label SkipVoidedLabel { get; }
			public PXNumberEdit MatchThreshold { get; }
			public Label MatchThresholdLabel { get; }
			public PXNumberEdit RelativeMatchThreshold { get; }
			public Label RelativeMatchThresholdLabel { get; }
			public PXNumberEdit RefNbrCompareWeight { get; }
			public Label RefNbrCompareWeightLabel { get; }
			public CheckBox EmptyRefNbrMatching { get; }
			public Label EmptyRefNbrMatchingLabel { get; }
			public PXNumberEdit DateCompareWeight { get; }
			public Label DateCompareWeightLabel { get; }
			public PXNumberEdit PayeeCompareWeight { get; }
			public Label PayeeCompareWeightLabel { get; }
			public PXNumberEdit RefNbrComparePercent { get; }
			public Label RefNbrComparePercentLabel { get; }
			public PXNumberEdit DateComparePercent { get; }
			public Label DateComparePercentLabel { get; }
			public PXNumberEdit PayeeComparePercent { get; }
			public Label PayeeComparePercentLabel { get; }
			public PXNumberEdit AmountWeight { get; }
			public Label AmountWeightLabel { get; }
			public PXNumberEdit CuryDiffThreshold { get; }
			public Label CuryDiffThresholdLabel { get; }
			public PXNumberEdit DateMeanOffset { get; }
			public Label DateMeanOffsetLabel { get; }
			public PXNumberEdit DateSigma { get; }
			public Label DateSigmaLabel { get; }
			public PXTextEdit RatioInRelevanceCalculationLabel { get; }
			public Label RatioInRelevanceCalculationLabelLabel { get; }
			public PXNumberEdit InvoiceRefNbrCompareWeight { get; }
			public Label InvoiceRefNbrCompareWeightLabel { get; }
			public PXNumberEdit InvoiceDateCompareWeight { get; }
			public Label InvoiceDateCompareWeightLabel { get; }
			public PXNumberEdit InvoicePayeeCompareWeight { get; }
			public Label InvoicePayeeCompareWeightLabel { get; }
			public PXNumberEdit InvoiceRefNbrComparePercent { get; }
			public Label InvoiceRefNbrComparePercentLabel { get; }
			public PXNumberEdit InvoiceDateComparePercent { get; }
			public Label InvoiceDateComparePercentLabel { get; }
			public PXNumberEdit InvoicePayeeComparePercent { get; }
			public Label InvoicePayeeComparePercentLabel { get; }
			public PXNumberEdit AveragePaymentDelay { get; }
			public Label AveragePaymentDelayLabel { get; }
			public PXNumberEdit InvoiceDateSigma { get; }
			public Label InvoiceDateSigmaLabel { get; }
            
            public c_cashaccount_tabmatchsettings(string locator, string name) : 
                    base(locator, name)
            {
                DisbursementTranDaysBefore = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edDisbursementTranDaysBefore", "Days Before Bank Transaction Date", locator, null);
                DisbursementTranDaysBeforeLabel = new Label(DisbursementTranDaysBefore);
                DisbursementTranDaysBefore.DataField = "DisbursementTranDaysBefore";
                DisbursementTranDaysAfter = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edDisbursementTranDaysAfter", "Days After Bank Transaction Date", locator, null);
                DisbursementTranDaysAfterLabel = new Label(DisbursementTranDaysAfter);
                DisbursementTranDaysAfter.DataField = "DisbursementTranDaysAfter";
                AllowMatchingCreditMemo = new CheckBox("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_chkAllowMatchingCreditMemo", "Allow Matching to Credit Memo", locator, null);
                AllowMatchingCreditMemoLabel = new Label(AllowMatchingCreditMemo);
                AllowMatchingCreditMemo.DataField = "AllowMatchingCreditMemo";
                ReceiptTranDaysBefore = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edReceiptTranDaysBefore", "Days Before Bank Transaction Date", locator, null);
                ReceiptTranDaysBeforeLabel = new Label(ReceiptTranDaysBefore);
                ReceiptTranDaysBefore.DataField = "ReceiptTranDaysBefore";
                ReceiptTranDaysAfter = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edReceiptTranDaysAfter", "Days After Bank Transaction Date", locator, null);
                ReceiptTranDaysAfterLabel = new Label(ReceiptTranDaysAfter);
                ReceiptTranDaysAfter.DataField = "ReceiptTranDaysAfter";
                InvoiceFilterByCashAccount = new CheckBox("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_chkInvoiceFilterByCashAccount", "Match by Cash Account", locator, null);
                InvoiceFilterByCashAccountLabel = new Label(InvoiceFilterByCashAccount);
                InvoiceFilterByCashAccount.DataField = "InvoiceFilterByCashAccount";
                InvoiceFilterByDate = new CheckBox("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_chkInvoiceFilterByDate", "Match by Discount and Due Date", locator, null);
                InvoiceFilterByDateLabel = new Label(InvoiceFilterByDate);
                InvoiceFilterByDate.DataField = "InvoiceFilterByDate";
                DaysBeforeInvoiceDiscountDate = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edDaysBeforeInvoiceDiscountDate", "Days Before Discount Date", locator, null);
                DaysBeforeInvoiceDiscountDateLabel = new Label(DaysBeforeInvoiceDiscountDate);
                DaysBeforeInvoiceDiscountDate.DataField = "DaysBeforeInvoiceDiscountDate";
                DaysBeforeInvoiceDueDate = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edDaysBeforeInvoiceDueDate", "Days Before Due Date", locator, null);
                DaysBeforeInvoiceDueDateLabel = new Label(DaysBeforeInvoiceDueDate);
                DaysBeforeInvoiceDueDate.DataField = "DaysBeforeInvoiceDueDate";
                DaysAfterInvoiceDueDate = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edDaysAfterInvoiceDueDate", "Days After Due Date", locator, null);
                DaysAfterInvoiceDueDateLabel = new Label(DaysAfterInvoiceDueDate);
                DaysAfterInvoiceDueDate.DataField = "DaysAfterInvoiceDueDate";
                SkipVoided = new CheckBox("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_chkskipVoided", "Skip Voided Transactions During Matching", locator, null);
                SkipVoidedLabel = new Label(SkipVoided);
                SkipVoided.DataField = "SkipVoided";
                MatchThreshold = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edMatchThreshold", "Absolute Relevance Threshold", locator, null);
                MatchThresholdLabel = new Label(MatchThreshold);
                MatchThreshold.DataField = "MatchThreshold";
                RelativeMatchThreshold = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t0_edRelativeMatchThreshold", "Relative Relevance Threshold", locator, null);
                RelativeMatchThresholdLabel = new Label(RelativeMatchThreshold);
                RelativeMatchThreshold.DataField = "RelativeMatchThreshold";
                RefNbrCompareWeight = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edRefNbrCompareWeight", "Ref. Nbr. Weight", locator, null);
                RefNbrCompareWeightLabel = new Label(RefNbrCompareWeight);
                RefNbrCompareWeight.DataField = "RefNbrCompareWeight";
                EmptyRefNbrMatching = new CheckBox("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_chkEmptyRefNbrMatching", "Consider Empty Ref. Nbr. as Matching", locator, null);
                EmptyRefNbrMatchingLabel = new Label(EmptyRefNbrMatching);
                EmptyRefNbrMatching.DataField = "EmptyRefNbrMatching";
                DateCompareWeight = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edDateCompareWeight", "Doc. Date Weight", locator, null);
                DateCompareWeightLabel = new Label(DateCompareWeight);
                DateCompareWeight.DataField = "DateCompareWeight";
                PayeeCompareWeight = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edPayeeCompareWeight", "Doc. Payee Weight", locator, null);
                PayeeCompareWeightLabel = new Label(PayeeCompareWeight);
                PayeeCompareWeight.DataField = "PayeeCompareWeight";
                RefNbrComparePercent = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edRefNbrComparePercent", "%", locator, null);
                RefNbrComparePercentLabel = new Label(RefNbrComparePercent);
                RefNbrComparePercent.DataField = "RefNbrComparePercent";
                DateComparePercent = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edDateComparePercent", "%", locator, null);
                DateComparePercentLabel = new Label(DateComparePercent);
                DateComparePercent.DataField = "DateComparePercent";
                PayeeComparePercent = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edPayeeComparePercent", "%", locator, null);
                PayeeComparePercentLabel = new Label(PayeeComparePercent);
                PayeeComparePercent.DataField = "PayeeComparePercent";
                AmountWeight = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edAmountWeight", "Amount Weight", locator, null);
                AmountWeightLabel = new Label(AmountWeight);
                AmountWeight.DataField = "AmountWeight";
                CuryDiffThreshold = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edCuryDiffThreshold", "Amount Difference Threshold (%)", locator, null);
                CuryDiffThresholdLabel = new Label(CuryDiffThreshold);
                CuryDiffThreshold.DataField = "CuryDiffThreshold";
                DateMeanOffset = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edDateMeanOffset", "Payment Clearing Average Delay", locator, null);
                DateMeanOffsetLabel = new Label(DateMeanOffset);
                DateMeanOffset.DataField = "DateMeanOffset";
                DateSigma = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edDateSigma", "Estimated Deviation (Days)", locator, null);
                DateSigmaLabel = new Label(DateSigma);
                DateSigma.DataField = "DateSigma";
                RatioInRelevanceCalculationLabel = new PXTextEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edRatioInRelevanceCalculationLabel" +
                        "", "Ratio In Relevance Calculation Label", locator, null);
                RatioInRelevanceCalculationLabelLabel = new Label(RatioInRelevanceCalculationLabel);
                RatioInRelevanceCalculationLabel.DataField = "RatioInRelevanceCalculationLabel";
                InvoiceRefNbrCompareWeight = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edInvoiceRefNbrCompareWeight", "Ref. Nbr. Weight", locator, null);
                InvoiceRefNbrCompareWeightLabel = new Label(InvoiceRefNbrCompareWeight);
                InvoiceRefNbrCompareWeight.DataField = "InvoiceRefNbrCompareWeight";
                InvoiceDateCompareWeight = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edInvoiceDateCompareWeight", "Doc. Date Weight", locator, null);
                InvoiceDateCompareWeightLabel = new Label(InvoiceDateCompareWeight);
                InvoiceDateCompareWeight.DataField = "InvoiceDateCompareWeight";
                InvoicePayeeCompareWeight = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edInvoicePayeeCompareWeight", "Doc. Payee Weight", locator, null);
                InvoicePayeeCompareWeightLabel = new Label(InvoicePayeeCompareWeight);
                InvoicePayeeCompareWeight.DataField = "InvoicePayeeCompareWeight";
                InvoiceRefNbrComparePercent = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edInvoiceRefNbrComparePercent", "%", locator, null);
                InvoiceRefNbrComparePercentLabel = new Label(InvoiceRefNbrComparePercent);
                InvoiceRefNbrComparePercent.DataField = "InvoiceRefNbrComparePercent";
                InvoiceDateComparePercent = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edInvoiceDateComparePercent", "%", locator, null);
                InvoiceDateComparePercentLabel = new Label(InvoiceDateComparePercent);
                InvoiceDateComparePercent.DataField = "InvoiceDateComparePercent";
                InvoicePayeeComparePercent = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edInvoicePayeeComparePercent", "%", locator, null);
                InvoicePayeeComparePercentLabel = new Label(InvoicePayeeComparePercent);
                InvoicePayeeComparePercent.DataField = "InvoicePayeeComparePercent";
                AveragePaymentDelay = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edAveragePaymentDelay", "Average Payment Delay", locator, null);
                AveragePaymentDelayLabel = new Label(AveragePaymentDelay);
                AveragePaymentDelay.DataField = "AveragePaymentDelay";
                InvoiceDateSigma = new PXNumberEdit("ctl00_phG_pnlMatchSettings_tabMatchSettings_t1_edInvoiceDateSigma", "Estimated Deviation (Days)", locator, null);
                InvoiceDateSigmaLabel = new Label(InvoiceDateSigma);
                InvoiceDateSigma.DataField = "InvoiceDateSigma";
                DataMemberName = "cashAccount";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void ResettoDefault()
            {
                Buttons.ResettoDefault.Click();
            }
            
            public virtual void SaveClose()
            {
                Buttons.SaveClose.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button ResettoDefault { get; }
			public Button SaveClose { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phG_pnlMatchSettings_tabMatchSettings_oi", "", "ctl00_phG_pnlMatchSettings_tabMatchSettings");
                    ResettoDefault = new Button("ctl00_phG_pnlMatchSettings_btnResetToDefault", "Reset to Default", "ctl00_phG_pnlMatchSettings_tabMatchSettings");
                    SaveClose = new Button("ctl00_phG_pnlMatchSettings_btnSaveClose", "Save & Close", "ctl00_phG_pnlMatchSettings_tabMatchSettings");
                }
            }
        }
        
        public class c_detailmatchinginvoices_griddetailmatches4 : Grid<c_detailmatchinginvoices_griddetailmatches4.c_grid_row, c_detailmatchinginvoices_griddetailmatches4.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_detailmatchinginvoices_griddetailmatches4(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4");
                DataMemberName = "detailMatchingInvoices";
                QuickSearch = new QuickSearch("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_at_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
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
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_at_tlb div[data-cmd=\'R" +
                            "efresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_at_tlb div[data-cmd=\'A" +
                            "djustColumns\']", "Fit to Screen", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_at_tlb div[data-cmd=\'h" +
                            "i\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ab_tlb div[data-cmd=\'P" +
                            "ageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ab_tlb div[data-cmd=\'P" +
                            "agePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ab_tlb div[data-cmd=\'P" +
                            "ageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ab_tlb div[data-cmd=\'P" +
                            "ageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ab_tlb div[data-cmd=\'h" +
                            "i\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsMatched { get; }
			public PXNumberEdit MatchRelevancePercent { get; }
			public Selector BranchID { get; }
			public DropDown OrigModule { get; }
			public DropDown OrigTranType { get; }
			public PXTextEdit OrigRefNbr { get; }
			public PXTextEdit ExtRefNbr { get; }
			public DateSelector TranDate { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public DateSelector DiscDate { get; }
			public Selector ReferenceID { get; }
			public PXTextEdit ReferenceName { get; }
			public PXTextEdit TranDesc { get; }
                
                public c_grid_row(c_detailmatchinginvoices_griddetailmatches4 grid) : 
                        base(grid)
                {
                    IsMatched = new CheckBox("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ef", "Matched", grid.Locator, "IsMatched");
                    IsMatched.DataField = "IsMatched";
                    MatchRelevancePercent = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_en", "Match Relevance, %", grid.Locator, "MatchRelevancePercent");
                    MatchRelevancePercent.DataField = "MatchRelevancePercent";
                    BranchID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_es", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    OrigModule = new DropDown("_ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_ec", "Module", grid.Locator, "OrigModule");
                    OrigModule.DataField = "OrigModule";
                    OrigModule.Items.Add("GL", "GL");
                    OrigModule.Items.Add("AP", "AP");
                    OrigModule.Items.Add("AR", "AR");
                    OrigModule.Items.Add("CM", "CM");
                    OrigModule.Items.Add("CA", "CA");
                    OrigModule.Items.Add("IN", "IN");
                    OrigModule.Items.Add("DR", "DR");
                    OrigModule.Items.Add("FA", "FA");
                    OrigModule.Items.Add("PM", "PM");
                    OrigModule.Items.Add("PR", "PR");
                    OrigTranType = new DropDown("_ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_ec", "Type", grid.Locator, "OrigTranType");
                    OrigTranType.DataField = "OrigTranType";
                    OrigTranType.Items.Add("GLE", "GL Entry");
                    OrigTranType.Items.Add("CAE", "Cash Entry");
                    OrigTranType.Items.Add("QCK", "Quick Check");
                    OrigTranType.Items.Add("CHK", "Check");
                    OrigTranType.Items.Add("ACR", "Credit Adj.");
                    OrigTranType.Items.Add("ADR", "Debit Adj.");
                    OrigTranType.Items.Add("CSL", "Cash Sale");
                    OrigTranType.Items.Add("CRM", "Credit Memo");
                    OrigTranType.Items.Add("DRM", "Debit Memo");
                    OrigTranType.Items.Add("PMT", "Payment");
                    OrigTranType.Items.Add("INV", "AR Invoice or AP Bill");
                    OrigTranType.Items.Add("PPM", "Prepayment");
                    OrigRefNbr = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_em", "Reference Nbr.", grid.Locator, "OrigRefNbr");
                    OrigRefNbr.DataField = "OrigRefNbr";
                    ExtRefNbr = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ei", "Ext. Ref. Nbr.", grid.Locator, "ExtRefNbr");
                    ExtRefNbr.DataField = "ExtRefNbr";
                    TranDate = new DateSelector("_ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_ed7", "Doc. Date", grid.Locator, "TranDate");
                    TranDate.DataField = "TranDate";
                    CuryTranAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_en", "Amount", grid.Locator, "CuryTranAmt");
                    CuryTranAmt.DataField = "CuryTranAmt";
                    CuryDiscAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_en", "Cash Discount", grid.Locator, "CuryDiscAmt");
                    CuryDiscAmt.DataField = "CuryDiscAmt";
                    DiscDate = new DateSelector("_ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_ed10", "Discount Date", grid.Locator, "DiscDate");
                    DiscDate.DataField = "DiscDate";
                    ReferenceID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_es", "Business Account", grid.Locator, "ReferenceID");
                    ReferenceID.DataField = "ReferenceID";
                    ReferenceName = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ei", "Business Account Name", grid.Locator, "ReferenceName");
                    ReferenceName.DataField = "ReferenceName";
                    TranDesc = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_ei", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter IsMatched { get; }
				public PXNumberEditColumnFilter MatchRelevancePercent { get; }
				public SelectorColumnFilter BranchID { get; }
				public DropDownColumnFilter OrigModule { get; }
				public DropDownColumnFilter OrigTranType { get; }
				public PXTextEditColumnFilter OrigRefNbr { get; }
				public PXTextEditColumnFilter ExtRefNbr { get; }
				public DateSelectorColumnFilter TranDate { get; }
				public PXNumberEditColumnFilter CuryTranAmt { get; }
				public PXNumberEditColumnFilter CuryDiscAmt { get; }
				public DateSelectorColumnFilter DiscDate { get; }
				public SelectorColumnFilter ReferenceID { get; }
				public PXTextEditColumnFilter ReferenceName { get; }
				public PXTextEditColumnFilter TranDesc { get; }
                
                public c_grid_header(c_detailmatchinginvoices_griddetailmatches4 grid) : 
                        base(grid)
                {
                    IsMatched = new CheckBoxColumnFilter(grid.Row.IsMatched);
                    MatchRelevancePercent = new PXNumberEditColumnFilter(grid.Row.MatchRelevancePercent);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    OrigModule = new DropDownColumnFilter(grid.Row.OrigModule);
                    OrigTranType = new DropDownColumnFilter(grid.Row.OrigTranType);
                    OrigRefNbr = new PXTextEditColumnFilter(grid.Row.OrigRefNbr);
                    ExtRefNbr = new PXTextEditColumnFilter(grid.Row.ExtRefNbr);
                    TranDate = new DateSelectorColumnFilter(grid.Row.TranDate);
                    CuryTranAmt = new PXNumberEditColumnFilter(grid.Row.CuryTranAmt);
                    CuryDiscAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscAmt);
                    DiscDate = new DateSelectorColumnFilter(grid.Row.DiscDate);
                    ReferenceID = new SelectorColumnFilter(grid.Row.ReferenceID);
                    ReferenceName = new PXTextEditColumnFilter(grid.Row.ReferenceName);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                }
            }
        }
        
        public class c_detailmatchinginvoices_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_detailmatchinginvoices_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PXSplitContainer_tab2_t1_gridDetailMatches4_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "detailMatchingInvoices";
            }
        }
        
        public class c_expensereceiptdetailmatches_gridexpensereceiptdetailmatches : Grid<c_expensereceiptdetailmatches_gridexpensereceiptdetailmatches.c_grid_row, c_expensereceiptdetailmatches_gridexpensereceiptdetailmatches.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_expensereceiptdetailmatches_gridexpensereceiptdetailmatches(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches");
                DataMemberName = "ExpenseReceiptDetailMatches";
                FilterForm = new c_grid_filter("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
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
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_at_tlb di" +
                            "v[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_at_tlb di" +
                            "v[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_at_tlb di" +
                            "v[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ab_tlb di" +
                            "v[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ab_tlb di" +
                            "v[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ab_tlb di" +
                            "v[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ab_tlb di" +
                            "v[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ab_tlb di" +
                            "v[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsMatched { get; }
			public PXNumberEdit MatchRelevancePercent { get; }
			public Selector RefNbr { get; }
			public PXTextEdit TranDesc { get; }
			public DateSelector DocDate { get; }
			public PXNumberEdit CuryDocAmt { get; }
			public PXTextEdit ClaimCuryID { get; }
			public PXNumberEdit CuryDocAmtDiff { get; }
			public PXTextEdit CardNumber { get; }
			public Selector ReferenceID { get; }
			public PXTextEdit ReferenceName { get; }
			public PXTextEdit ExtRefNbr { get; }
			public DropDown PaidWith { get; }
                
                public c_grid_row(c_expensereceiptdetailmatches_gridexpensereceiptdetailmatches grid) : 
                        base(grid)
                {
                    IsMatched = new CheckBox("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ef", "Matched", grid.Locator, "IsMatched");
                    IsMatched.DataField = "IsMatched";
                    MatchRelevancePercent = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_en", "Match Relevance, %", grid.Locator, "MatchRelevancePercent");
                    MatchRelevancePercent.DataField = "MatchRelevancePercent";
                    RefNbr = new Selector("_ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_lv0_es", "Receipt Number", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    TranDesc = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ei", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    DocDate = new DateSelector("_ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_lv0_ed4", "Doc. Date", grid.Locator, "DocDate");
                    DocDate.DataField = "DocDate";
                    CuryDocAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_en", "Amount in Claim Curr.", grid.Locator, "CuryDocAmt");
                    CuryDocAmt.DataField = "CuryDocAmt";
                    ClaimCuryID = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_em", "Claim Currency", grid.Locator, "ClaimCuryID");
                    ClaimCuryID.DataField = "ClaimCuryID";
                    CuryDocAmtDiff = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_en", "Amount Difference", grid.Locator, "CuryDocAmtDiff");
                    CuryDocAmtDiff.DataField = "CuryDocAmtDiff";
                    CardNumber = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ei", "Card Number", grid.Locator, "CardNumber");
                    CardNumber.DataField = "CardNumber";
                    ReferenceID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_lv0_es", "Employee", grid.Locator, "ReferenceID");
                    ReferenceID.DataField = "ReferenceID";
                    ReferenceName = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ei", "Employee Name", grid.Locator, "ReferenceName");
                    ReferenceName.DataField = "ReferenceName";
                    ExtRefNbr = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_ei", "Ref. Nbr.", grid.Locator, "ExtRefNbr");
                    ExtRefNbr.DataField = "ExtRefNbr";
                    PaidWith = new DropDown("_ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_lv0_ec", "Paid With", grid.Locator, "PaidWith");
                    PaidWith.DataField = "PaidWith";
                    PaidWith.Items.Add("PersAcc", "Personal Account");
                    PaidWith.Items.Add("CardComp", "Corporate Card, Company Expense");
                    PaidWith.Items.Add("CardPers", "Corporate Card, Personal Expense");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter IsMatched { get; }
				public PXNumberEditColumnFilter MatchRelevancePercent { get; }
				public SelectorColumnFilter RefNbr { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public DateSelectorColumnFilter DocDate { get; }
				public PXNumberEditColumnFilter CuryDocAmt { get; }
				public PXTextEditColumnFilter ClaimCuryID { get; }
				public PXNumberEditColumnFilter CuryDocAmtDiff { get; }
				public PXTextEditColumnFilter CardNumber { get; }
				public SelectorColumnFilter ReferenceID { get; }
				public PXTextEditColumnFilter ReferenceName { get; }
				public PXTextEditColumnFilter ExtRefNbr { get; }
				public DropDownColumnFilter PaidWith { get; }
                
                public c_grid_header(c_expensereceiptdetailmatches_gridexpensereceiptdetailmatches grid) : 
                        base(grid)
                {
                    IsMatched = new CheckBoxColumnFilter(grid.Row.IsMatched);
                    MatchRelevancePercent = new PXNumberEditColumnFilter(grid.Row.MatchRelevancePercent);
                    RefNbr = new SelectorColumnFilter(grid.Row.RefNbr);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    DocDate = new DateSelectorColumnFilter(grid.Row.DocDate);
                    CuryDocAmt = new PXNumberEditColumnFilter(grid.Row.CuryDocAmt);
                    ClaimCuryID = new PXTextEditColumnFilter(grid.Row.ClaimCuryID);
                    CuryDocAmtDiff = new PXNumberEditColumnFilter(grid.Row.CuryDocAmtDiff);
                    CardNumber = new PXTextEditColumnFilter(grid.Row.CardNumber);
                    ReferenceID = new SelectorColumnFilter(grid.Row.ReferenceID);
                    ReferenceName = new PXTextEditColumnFilter(grid.Row.ReferenceName);
                    ExtRefNbr = new PXTextEditColumnFilter(grid.Row.ExtRefNbr);
                    PaidWith = new DropDownColumnFilter(grid.Row.PaidWith);
                }
            }
        }
        
        public class c_expensereceiptdetailmatches_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_expensereceiptdetailmatches_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PXSplitContainer_tab2_t2_gridExpenseReceiptDetailMatches_lv0_ec", "Ec", locator, null);
                DataMemberName = "ExpenseReceiptDetailMatches";
            }
        }
        
        public class c_transplit_gridcasplits : Grid<c_transplit_gridcasplits.c_grid_row, c_transplit_gridcasplits.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_transplit_gridcasplits(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits");
                DataMemberName = "TranSplit";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_fe_gf", "FilterForm");
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
            
            public virtual void Attachfile()
            {
                Buttons.Attachfile.Click();
            }
            
            public virtual void PayeeBAccountIDEdit()
            {
                Buttons.PayeeBAccountIDEdit.Click();
            }
            
            public virtual void ClearRule()
            {
                Buttons.ClearRule.Click();
            }
            
            public virtual void CreateRule()
            {
                Buttons.CreateRule.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_at_tlb div[data-cmd=\'Refresh" +
                            "\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_at_tlb div[data-cmd=\'AddNew\'" +
                            "]", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_at_tlb div[data-cmd=\'Delete\'" +
                            "]", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_at_tlb div[data-cmd=\'AdjustC" +
                            "olumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_at_tlb div[data-cmd=\'ExportE" +
                            "xcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_ab_tlb div[data-cmd=\'PageFir" +
                            "st\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_ab_tlb div[data-cmd=\'PagePre" +
                            "v\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_ab_tlb div[data-cmd=\'PageNex" +
                            "t\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_ab_tlb div[data-cmd=\'PageLas" +
                            "t\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Attachfile { get; }
			public Button PayeeBAccountIDEdit { get; }
			public Button ClearRule { get; }
			public Button CreateRule { get; }
                
                public PxButtonCollection()
                {
                    Attachfile = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_imf", "Attach file", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits");
                    PayeeBAccountIDEdit = new Button("css=div[id=\'ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPayeeBAccountI" +
                            "D\'] div[class=\'editBtnCont\'] > div > div", "PayeeBAccountIDEdit", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits");
                    PayeeBAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ClearRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnUnapplyRule", "Clear Rule", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits");
                    CreateRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnCreateRule", "Create Rule", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector BranchID { get; }
			public Selector InventoryID { get; }
			public PXTextEdit TranDesc { get; }
			public PXNumberEdit Qty { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public Selector CashAccountID { get; }
			public Selector AccountID { get; }
			public PXTextEdit AccountID_description { get; }
			public Selector SubID { get; }
			public Selector ProjectID { get; }
			public Selector TaskID { get; }
			public Selector CostCodeID { get; }
			public CheckBox NonBillable { get; }
			public Selector TaxCategoryID { get; }
			public PXNumberEdit BankTranID { get; }
			public PXTextEdit BankTranType { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_transplit_gridcasplits grid) : 
                        base(grid)
                {
                    BranchID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edBranchID", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    InventoryID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edInventoryID", "Item ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    TranDesc = new PXTextEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edTranDesc", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    Qty = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    CuryUnitPrice = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edCuryUnitPrice", "Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    CuryTranAmt = new PXNumberEdit("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edCuryTranAmt", "Amount", grid.Locator, "CuryTranAmt");
                    CuryTranAmt.DataField = "CuryTranAmt";
                    CashAccountID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edCashAccountID", "Offset Cash Account", grid.Locator, "CashAccountID");
                    CashAccountID.DataField = "CashAccountID";
                    AccountID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edAccountID", "Offset Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    AccountID_description = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_ei", "Description", grid.Locator, "AccountID_description");
                    AccountID_description.DataField = "AccountID_description";
                    SubID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edSubID", "Offset Subaccount", grid.Locator, "SubID");
                    SubID.DataField = "SubID";
                    ProjectID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edProjectID", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_es", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    NonBillable = new CheckBox("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_ef", "Non Billable", grid.Locator, "NonBillable");
                    NonBillable.DataField = "NonBillable";
                    TaxCategoryID = new Selector("_ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edTaxCategoryID", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    BankTranID = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_en", "BankTranID", grid.Locator, "BankTranID");
                    BankTranID.DataField = "BankTranID";
                    BankTranType = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_ei", "Type", grid.Locator, "BankTranType");
                    BankTranType.DataField = "BankTranType";
                    LineNbr = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter BranchID { get; }
				public SelectorColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public PXNumberEditColumnFilter CuryTranAmt { get; }
				public SelectorColumnFilter CashAccountID { get; }
				public SelectorColumnFilter AccountID { get; }
				public PXTextEditColumnFilter AccountID_description { get; }
				public SelectorColumnFilter SubID { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public CheckBoxColumnFilter NonBillable { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public PXNumberEditColumnFilter BankTranID { get; }
				public PXTextEditColumnFilter BankTranType { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_transplit_gridcasplits grid) : 
                        base(grid)
                {
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    CuryTranAmt = new PXNumberEditColumnFilter(grid.Row.CuryTranAmt);
                    CashAccountID = new SelectorColumnFilter(grid.Row.CashAccountID);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    AccountID_description = new PXTextEditColumnFilter(grid.Row.AccountID_description);
                    SubID = new SelectorColumnFilter(grid.Row.SubID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    NonBillable = new CheckBoxColumnFilter(grid.Row.NonBillable);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    BankTranID = new PXNumberEditColumnFilter(grid.Row.BankTranID);
                    BankTranType = new PXTextEditColumnFilter(grid.Row.BankTranType);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_transplit_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public Label CuryUnitPriceLabel { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public Label CuryTranAmtLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector SubID { get; }
			public Label SubIDLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_transplit_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BranchID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                ProjectID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                TaskID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                InventoryID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edInventoryID", "Item ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                Qty = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                CuryUnitPrice = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edCuryUnitPrice", "Price", locator, null);
                CuryUnitPriceLabel = new Label(CuryUnitPrice);
                CuryUnitPrice.DataField = "CuryUnitPrice";
                CuryTranAmt = new PXNumberEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edCuryTranAmt", "Amount", locator, null);
                CuryTranAmtLabel = new Label(CuryTranAmt);
                CuryTranAmt.DataField = "CuryTranAmt";
                CashAccountID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edCashAccountID", "Offset Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                AccountID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edAccountID", "Offset Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                SubID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edSubID", "Offset Subaccount", locator, null);
                SubIDLabel = new Label(SubID);
                SubID.DataField = "SubID";
                TaxCategoryID = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                TranDesc = new PXTextEdit("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edTranDesc", "Description", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                Es = new Selector("ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "TranSplit";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void Attachfile()
            {
                Buttons.Attachfile.Click();
            }
            
            public virtual void PayeeBAccountIDEdit()
            {
                Buttons.PayeeBAccountIDEdit.Click();
            }
            
            public virtual void ClearRule()
            {
                Buttons.ClearRule.Click();
            }
            
            public virtual void CreateRule()
            {
                Buttons.CreateRule.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
			public Button Attachfile { get; }
			public Button PayeeBAccountIDEdit { get; }
			public Button ClearRule { get; }
			public Button CreateRule { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0_edInventoryID\'] d" +
                            "iv[class=\'editBtnCont\'] > div > div", "InventoryIDEdit", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Attachfile = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_imf", "Attach file", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0");
                    PayeeBAccountIDEdit = new Button("css=div[id=\'ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_edPayeeBAccountI" +
                            "D\'] div[class=\'editBtnCont\'] > div > div", "PayeeBAccountIDEdit", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0");
                    PayeeBAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ClearRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnUnapplyRule", "Clear Rule", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0");
                    CreateRule = new Button("ctl00_phG_PXSplitContainer_tab2_t3_frmCreateDocument_btnCreateRule", "Create Rule", "ctl00_phG_PXSplitContainer_tab2_t3_gridCASplits_lv0");
                }
            }
        }
        
        public class c_loadopts_loform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXBranchSelector OrgBAccountID { get; }
			public Label OrgBAccountIDLabel { get; }
			public DateSelector FromDate { get; }
			public Label FromDateLabel { get; }
			public DateSelector TillDate { get; }
			public Label TillDateLabel { get; }
			public PXNumberEdit MaxDocs { get; }
			public Label MaxDocsLabel { get; }
			public Selector StartRefNbr { get; }
			public Label StartRefNbrLabel { get; }
			public Selector EndRefNbr { get; }
			public Label EndRefNbrLabel { get; }
			public GroupBox OrderBy { get; }
			public Label OrderByLabel { get; }
            
            public c_loadopts_loform(string locator, string name) : 
                    base(locator, name)
            {
                OrgBAccountID = new PXBranchSelector("ctl00_phG_pnlLoadOpts_loform_BranchSelector1", "Org B Account ID", locator, null);
                OrgBAccountIDLabel = new Label(OrgBAccountID);
                OrgBAccountID.DataField = "OrgBAccountID";
                FromDate = new DateSelector("ctl00_phG_pnlLoadOpts_loform_edFromDate", "From Date", locator, null);
                FromDateLabel = new Label(FromDate);
                FromDate.DataField = "FromDate";
                TillDate = new DateSelector("ctl00_phG_pnlLoadOpts_loform_edTillDate", "Till Date", locator, null);
                TillDateLabel = new Label(TillDate);
                TillDate.DataField = "TillDate";
                MaxDocs = new PXNumberEdit("ctl00_phG_pnlLoadOpts_loform_edMaxDocs", "Max Docs", locator, null);
                MaxDocsLabel = new Label(MaxDocs);
                MaxDocs.DataField = "MaxDocs";
                StartRefNbr = new Selector("ctl00_phG_pnlLoadOpts_loform_edStartRefNbr", "Start Ref Nbr", locator, null);
                StartRefNbrLabel = new Label(StartRefNbr);
                StartRefNbr.DataField = "StartRefNbr";
                EndRefNbr = new Selector("ctl00_phG_pnlLoadOpts_loform_edEndRefNbr", "End Ref Nbr", locator, null);
                EndRefNbrLabel = new Label(EndRefNbr);
                EndRefNbr.DataField = "EndRefNbr";
                OrderBy = new GroupBox("ctl00_phG_pnlLoadOpts_loform_gbOrderBy", "Order By", locator, null);
                OrderByLabel = new Label(OrderBy);
                OrderBy.DataField = "OrderBy";
                DataMemberName = "loadOpts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Load()
            {
                Buttons.Load.Click();
            }
            
            public virtual void Reload()
            {
                Buttons.Reload.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Load { get; }
			public Button Reload { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Load = new Button("ctl00_phG_pnlLoadOpts_loform_btnLoad", "Load", "ctl00_phG_pnlLoadOpts_loform");
                    Reload = new Button("ctl00_phG_pnlLoadOpts_loform_btnReload", "Reload", "ctl00_phG_pnlLoadOpts_loform");
                    Cancel = new Button("ctl00_phG_pnlLoadOpts_loform_btnCancel", "Cancel", "ctl00_phG_pnlLoadOpts_loform");
                }
            }
        }
        
        public class c_rulecreation_frmcreaterule : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit RuleName { get; }
			public Label RuleNameLabel { get; }
            
            public c_rulecreation_frmcreaterule(string locator, string name) : 
                    base(locator, name)
            {
                RuleName = new PXTextEdit("ctl00_phG_pnlCreateRule_frmCreateRule_edRuleName", "Rule Name", locator, null);
                RuleNameLabel = new Label(RuleName);
                RuleName.DataField = "RuleName";
                DataMemberName = "RuleCreation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Create()
            {
                Buttons.Create.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Create { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Create = new Button("ctl00_phG_pnlCreateRule_btnCreateRuleOk", "Create", "ctl00_phG_pnlCreateRule_frmCreateRule");
                    Cancel = new Button("ctl00_phG_pnlCreateRule_btnCreateRuleCancel", "Cancel", "ctl00_phG_pnlCreateRule_frmCreateRule");
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
