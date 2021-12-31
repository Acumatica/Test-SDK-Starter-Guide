using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
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
    
    
    public class APSetupMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_setup_tab Setup_tab { get; } = new c_setup_tab("ctl00_phF_tab", "Setup_tab");
        protected c_setup_discountparameters Setup_DiscountParameters { get; } = new c_setup_discountparameters("ctl00_phF_tab_t3_DiscountParameters", "Setup_DiscountParameters");
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
        protected c_setupapproval_gridapproval SetupApproval_gridApproval { get; } = new c_setupapproval_gridapproval("ctl00_phF_tab_t2_gridApproval", "SetupApproval_gridApproval");
        protected c_setupapproval_lv0 SetupApproval_lv0 { get; } = new c_setupapproval_lv0("ctl00_phF_tab_t2_gridApproval_lv0", "SetupApproval_lv0");
        protected c_boxes1099_grid Boxes1099_grid { get; } = new c_boxes1099_grid("ctl00_phF_tab_t3_grid", "Boxes1099_grid");
        protected c_boxes1099_lv0 Boxes1099_lv0 { get; } = new c_boxes1099_lv0("ctl00_phF_tab_t3_grid_lv0", "Boxes1099_lv0");
        protected c_notifications_gridns Notifications_gridNS { get; } = new c_notifications_gridns("ctl00_phF_tab_t4_sp1_gridNS", "Notifications_gridNS");
        protected c_notifications_lv0 Notifications_lv0 { get; } = new c_notifications_lv0("ctl00_phF_tab_t4_sp1_gridNS_lv0", "Notifications_lv0");
        protected c_recipients_gridnr Recipients_gridNR { get; } = new c_recipients_gridnr("ctl00_phF_tab_t4_sp1_gridNR", "Recipients_gridNR");
        protected c_recipients_lv0 Recipients_lv0 { get; } = new c_recipients_lv0("ctl00_phF_tab_t4_sp1_gridNR_lv0", "Recipients_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public APSetupMaint()
        {
            ScreenId = "AP101000";
            ScreenUrl = "/Pages/AP/AP101000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual APSetupMaint ReadOne(Gate gate)
        {
            new BiObject<APSetupMaint>(gate).ReadOne(this);
            return this;
        }
        
        public virtual APSetupMaint ReadOne()
        {
            return this.ReadOne(ApiConnection.Source);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Note()
        {
            ToolBar.Note.Click();
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
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
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
			public ToolBarButton FilesMenuShow { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton LongrunCancel { get; }
			public ToolBarButton LongrunTimer { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
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
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_setup_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BatchNumberingID { get; }
			public Label BatchNumberingIDLabel { get; }
			public Selector InvoiceNumberingID { get; }
			public Label InvoiceNumberingIDLabel { get; }
			public Selector DebitAdjNumberingID { get; }
			public Label DebitAdjNumberingIDLabel { get; }
			public Selector CreditAdjNumberingID { get; }
			public Label CreditAdjNumberingIDLabel { get; }
			public Selector CheckNumberingID { get; }
			public Label CheckNumberingIDLabel { get; }
			public Selector PriceWSNumberingID { get; }
			public Label PriceWSNumberingIDLabel { get; }
			public CheckBox AutoPost { get; }
			public Label AutoPostLabel { get; }
			public CheckBox SummaryPost { get; }
			public Label SummaryPostLabel { get; }
			public CheckBox MigrationMode { get; }
			public Label MigrationModeLabel { get; }
			public CheckBox ReclassifyInvoices { get; }
			public Label ReclassifyInvoicesLabel { get; }
			public PXNumberEdit PastDue00 { get; }
			public Label PastDue00Label { get; }
			public PXNumberEdit PastDue01 { get; }
			public Label PastDue01Label { get; }
			public PXNumberEdit PastDue02 { get; }
			public Label PastDue02Label { get; }
			public Selector DfltVendorClassID { get; }
			public Label DfltVendorClassIDLabel { get; }
			public Selector ExpenseSubMask { get; }
			public Label ExpenseSubMaskLabel { get; }
			public DropDown IntercompanyExpenseAccountDefault { get; }
			public Label IntercompanyExpenseAccountDefaultLabel { get; }
			public DropDown InvoiceRounding { get; }
			public Label InvoiceRoundingLabel { get; }
			public DropDown InvoicePrecision { get; }
			public Label InvoicePrecisionLabel { get; }
			public PXNumberEdit PaymentLeadTime { get; }
			public Label PaymentLeadTimeLabel { get; }
			public CheckBox HoldEntry { get; }
			public Label HoldEntryLabel { get; }
			public CheckBox RequireApprovePayments { get; }
			public Label RequireApprovePaymentsLabel { get; }
			public CheckBox EarlyChecks { get; }
			public Label EarlyChecksLabel { get; }
			public CheckBox RequireControlTotal { get; }
			public Label RequireControlTotalLabel { get; }
			public CheckBox RequireControlTaxTotal { get; }
			public Label RequireControlTaxTotalLabel { get; }
			public CheckBox SuggestPaymentAmount { get; }
			public Label SuggestPaymentAmountLabel { get; }
			public CheckBox RequireVendorRef { get; }
			public Label RequireVendorRefLabel { get; }
			public CheckBox RaiseErrorOnDoubleInvoiceNbr { get; }
			public Label RaiseErrorOnDoubleInvoiceNbrLabel { get; }
			public CheckBox RetainTaxes { get; }
			public Label RetainTaxesLabel { get; }
			public CheckBox RetainageBillsAutoRelease { get; }
			public Label RetainageBillsAutoReleaseLabel { get; }
			public CheckBox RequireSingleProjectPerDocument { get; }
			public Label RequireSingleProjectPerDocumentLabel { get; }
			public InputLocalizable PPDDebitAdjustmentDescr { get; }
			public Label PPDDebitAdjustmentDescrLabel { get; }
			public DropDown VendorPriceUpdate { get; }
			public Label VendorPriceUpdateLabel { get; }
			public CheckBox LoadVendorsPricesUsingAlternateID { get; }
			public Label LoadVendorsPricesUsingAlternateIDLabel { get; }
			public DropDown RetentionType { get; }
			public Label RetentionTypeLabel { get; }
			public PXNumberEdit NumberOfMonths { get; }
			public Label NumberOfMonthsLabel { get; }
			public DropDown ApplyQuantityDiscountBy { get; }
			public Label ApplyQuantityDiscountByLabel { get; }
			public Label LblDays1_ { get; }
			public Label LblDays2_ { get; }
			public Label LblDays3_ { get; }
			public Label LblDays4_ { get; }
            
            public c_setup_tab(string locator, string name) : 
                    base(locator, name)
            {
                BatchNumberingID = new Selector("ctl00_phF_tab_t0_edBatchNumberingID", "Batch Numbering Sequence", locator, null);
                BatchNumberingIDLabel = new Label(BatchNumberingID);
                BatchNumberingID.DataField = "BatchNumberingID";
                InvoiceNumberingID = new Selector("ctl00_phF_tab_t0_edInvoiceNumberingID", "Bill Numbering Sequence", locator, null);
                InvoiceNumberingIDLabel = new Label(InvoiceNumberingID);
                InvoiceNumberingID.DataField = "InvoiceNumberingID";
                DebitAdjNumberingID = new Selector("ctl00_phF_tab_t0_edDebitAdjNumberingID", "Debit Adjustment Numbering Sequence", locator, null);
                DebitAdjNumberingIDLabel = new Label(DebitAdjNumberingID);
                DebitAdjNumberingID.DataField = "DebitAdjNumberingID";
                CreditAdjNumberingID = new Selector("ctl00_phF_tab_t0_edCreditAdjNumberingID", "Credit Adjustment Numbering Sequence", locator, null);
                CreditAdjNumberingIDLabel = new Label(CreditAdjNumberingID);
                CreditAdjNumberingID.DataField = "CreditAdjNumberingID";
                CheckNumberingID = new Selector("ctl00_phF_tab_t0_edCheckNumberingID", "Payment Numbering Sequence", locator, null);
                CheckNumberingIDLabel = new Label(CheckNumberingID);
                CheckNumberingID.DataField = "CheckNumberingID";
                PriceWSNumberingID = new Selector("ctl00_phF_tab_t0_edPriceWSNumberingID", "Price Worksheet Numbering Sequence", locator, null);
                PriceWSNumberingIDLabel = new Label(PriceWSNumberingID);
                PriceWSNumberingID.DataField = "PriceWSNumberingID";
                AutoPost = new CheckBox("ctl00_phF_tab_t0_chkAutoPost", "Automatically Post on Release", locator, null);
                AutoPostLabel = new Label(AutoPost);
                AutoPost.DataField = "AutoPost";
                SummaryPost = new CheckBox("ctl00_phF_tab_t0_chkSummaryPost", "Post Summary on Updating GL", locator, null);
                SummaryPostLabel = new Label(SummaryPost);
                SummaryPost.DataField = "SummaryPost";
                MigrationMode = new CheckBox("ctl00_phF_tab_t0_chkMigrationMode", "Activate Migration Mode", locator, null);
                MigrationModeLabel = new Label(MigrationMode);
                MigrationMode.DataField = "MigrationMode";
                ReclassifyInvoices = new CheckBox("ctl00_phF_tab_t0_chkReclassifyInvoices", "Allow Bill Reclassification", locator, null);
                ReclassifyInvoicesLabel = new Label(ReclassifyInvoices);
                ReclassifyInvoices.DataField = "ReclassifyInvoices";
                PastDue00 = new PXNumberEdit("ctl00_phF_tab_t0_edPastDue00", "Aging Period 1", locator, null);
                PastDue00Label = new Label(PastDue00);
                PastDue00.DataField = "PastDue00";
                PastDue01 = new PXNumberEdit("ctl00_phF_tab_t0_edPastDue01", "Aging Period 2", locator, null);
                PastDue01Label = new Label(PastDue01);
                PastDue01.DataField = "PastDue01";
                PastDue02 = new PXNumberEdit("ctl00_phF_tab_t0_edPastDue02", "Aging Period 3", locator, null);
                PastDue02Label = new Label(PastDue02);
                PastDue02.DataField = "PastDue02";
                DfltVendorClassID = new Selector("ctl00_phF_tab_t0_edDfltVendorClassID", "Default Vendor Class ID", locator, null);
                DfltVendorClassIDLabel = new Label(DfltVendorClassID);
                DfltVendorClassID.DataField = "DfltVendorClassID";
                ExpenseSubMask = new Selector("ctl00_phF_tab_t0_edExpenseSubMask", "Combine Expense Sub. From", locator, null);
                ExpenseSubMaskLabel = new Label(ExpenseSubMask);
                ExpenseSubMask.DataField = "ExpenseSubMask";
                IntercompanyExpenseAccountDefault = new DropDown("ctl00_phF_tab_t0_edIntercompanyExpenseAccountDefault", "Use Intercompany Expense Account From", locator, null);
                IntercompanyExpenseAccountDefaultLabel = new Label(IntercompanyExpenseAccountDefault);
                IntercompanyExpenseAccountDefault.DataField = "IntercompanyExpenseAccountDefault";
                IntercompanyExpenseAccountDefault.Items.Add("L", "Vendor Location");
                IntercompanyExpenseAccountDefault.Items.Add("I", "Inventory Item");
                InvoiceRounding = new DropDown("ctl00_phF_tab_t0_edInvoiceRounding", "Rounding Rule for Bills", locator, null);
                InvoiceRoundingLabel = new Label(InvoiceRounding);
                InvoiceRounding.DataField = "InvoiceRounding";
                InvoiceRounding.Items.Add("N", "Use Currency Precision");
                InvoiceRounding.Items.Add("R", "Nearest");
                InvoiceRounding.Items.Add("C", "Up");
                InvoiceRounding.Items.Add("F", "Down");
                InvoicePrecision = new DropDown("ctl00_phF_tab_t0_edInvoicePrecision", "Rounding Precision", locator, null);
                InvoicePrecisionLabel = new Label(InvoicePrecision);
                InvoicePrecision.DataField = "InvoicePrecision";
                InvoicePrecision.Items.Add("0.05", "0.05");
                InvoicePrecision.Items.Add("0.10", "0.10");
                InvoicePrecision.Items.Add("0.50", "0.50");
                InvoicePrecision.Items.Add("1.00", "1.00");
                InvoicePrecision.Items.Add("10.00", "10.00");
                InvoicePrecision.Items.Add("100.00", "100.00");
                PaymentLeadTime = new PXNumberEdit("ctl00_phF_tab_t0_edPaymentLeadTime", "Payment Lead Time", locator, null);
                PaymentLeadTimeLabel = new Label(PaymentLeadTime);
                PaymentLeadTime.DataField = "PaymentLeadTime";
                HoldEntry = new CheckBox("ctl00_phF_tab_t0_chkHoldEntry", "Hold Documents on Entry", locator, null);
                HoldEntryLabel = new Label(HoldEntry);
                HoldEntry.DataField = "HoldEntry";
                RequireApprovePayments = new CheckBox("ctl00_phF_tab_t0_chkAutoPreapprovePayments", "Require Approval of Bills Prior to Payment", locator, null);
                RequireApprovePaymentsLabel = new Label(RequireApprovePayments);
                RequireApprovePayments.DataField = "RequireApprovePayments";
                EarlyChecks = new CheckBox("ctl00_phF_tab_t0_chkEarlyChecks", "Enable Early Checks", locator, null);
                EarlyChecksLabel = new Label(EarlyChecks);
                EarlyChecks.DataField = "EarlyChecks";
                RequireControlTotal = new CheckBox("ctl00_phF_tab_t0_chkRequireControlTotal", "Validate Document Totals on Entry", locator, null);
                RequireControlTotalLabel = new Label(RequireControlTotal);
                RequireControlTotal.DataField = "RequireControlTotal";
                RequireControlTaxTotal = new CheckBox("ctl00_phF_tab_t0_chkRequireControlTaxTotal", "Validate Tax Totals on Entry", locator, null);
                RequireControlTaxTotalLabel = new Label(RequireControlTaxTotal);
                RequireControlTaxTotal.DataField = "RequireControlTaxTotal";
                SuggestPaymentAmount = new CheckBox("ctl00_phF_tab_t0_chkSuggestPaymentAmount", "Set Zero Payment Amount to Application Amount", locator, null);
                SuggestPaymentAmountLabel = new Label(SuggestPaymentAmount);
                SuggestPaymentAmount.DataField = "SuggestPaymentAmount";
                RequireVendorRef = new CheckBox("ctl00_phF_tab_t0_chkRequireVendorRef", "Require Vendor Reference", locator, null);
                RequireVendorRefLabel = new Label(RequireVendorRef);
                RequireVendorRef.DataField = "RequireVendorRef";
                RaiseErrorOnDoubleInvoiceNbr = new CheckBox("ctl00_phF_tab_t0_chkRaiseErrorOnDoubleInvoiceNbr", "Raise an Error on Duplicate Vendor Reference Number", locator, null);
                RaiseErrorOnDoubleInvoiceNbrLabel = new Label(RaiseErrorOnDoubleInvoiceNbr);
                RaiseErrorOnDoubleInvoiceNbr.DataField = "RaiseErrorOnDoubleInvoiceNbr";
                RetainTaxes = new CheckBox("ctl00_phF_tab_t0_chkRetainTaxes", "Retain Taxes", locator, null);
                RetainTaxesLabel = new Label(RetainTaxes);
                RetainTaxes.DataField = "RetainTaxes";
                RetainageBillsAutoRelease = new CheckBox("ctl00_phF_tab_t0_chkRetainageBillsAutoRelease", "Automatically Release Retainage Bills", locator, null);
                RetainageBillsAutoReleaseLabel = new Label(RetainageBillsAutoRelease);
                RetainageBillsAutoRelease.DataField = "RetainageBillsAutoRelease";
                RequireSingleProjectPerDocument = new CheckBox("ctl00_phF_tab_t0_chkRequireSingleProjectPerDocument", "Require Single Project per Document", locator, null);
                RequireSingleProjectPerDocumentLabel = new Label(RequireSingleProjectPerDocument);
                RequireSingleProjectPerDocument.DataField = "RequireSingleProjectPerDocument";
                PPDDebitAdjustmentDescr = new InputLocalizable("ctl00_phF_tab_t0_txtPPDDebitAdjustmentDescr", "Debit Adjustment Description", locator, null);
                PPDDebitAdjustmentDescrLabel = new Label(PPDDebitAdjustmentDescr);
                PPDDebitAdjustmentDescr.DataField = "PPDDebitAdjustmentDescr";
                VendorPriceUpdate = new DropDown("ctl00_phF_tab_t1_edVendorPriceUpdate", "Vendor Price Update", locator, null);
                VendorPriceUpdateLabel = new Label(VendorPriceUpdate);
                VendorPriceUpdate.DataField = "VendorPriceUpdate";
                VendorPriceUpdate.Items.Add("N", "None");
                VendorPriceUpdate.Items.Add("P", "On PO Entry");
                VendorPriceUpdate.Items.Add("B", "On AP Bill Release");
                LoadVendorsPricesUsingAlternateID = new CheckBox("ctl00_phF_tab_t1_chkLoadVendorsPricesUsingAlternateID", "Load Vendor Prices by Alternate ID", locator, null);
                LoadVendorsPricesUsingAlternateIDLabel = new Label(LoadVendorsPricesUsingAlternateID);
                LoadVendorsPricesUsingAlternateID.DataField = "LoadVendorsPricesUsingAlternateID";
                RetentionType = new DropDown("ctl00_phF_tab_t1_edRetentionType", "Retention Type", locator, null);
                RetentionTypeLabel = new Label(RetentionType);
                RetentionType.DataField = "RetentionType";
                RetentionType.Items.Add("L", "Last Price");
                RetentionType.Items.Add("F", "Fixed Number of Months");
                NumberOfMonths = new PXNumberEdit("ctl00_phF_tab_t1_edNumberOfMonths", "Number of Months", locator, null);
                NumberOfMonthsLabel = new Label(NumberOfMonths);
                NumberOfMonths.DataField = "NumberOfMonths";
                ApplyQuantityDiscountBy = new DropDown("ctl00_phF_tab_t1_edApplyQuantityDiscountBy", "Apply Quantity Discounts To", locator, null);
                ApplyQuantityDiscountByLabel = new Label(ApplyQuantityDiscountBy);
                ApplyQuantityDiscountBy.DataField = "ApplyQuantityDiscountBy";
                ApplyQuantityDiscountBy.Items.Add("L", "Document Line UOM");
                ApplyQuantityDiscountBy.Items.Add("B", "Base UOM");
                LblDays1_ = new Label("ctl00_phF_tab_t0_lblDays1", "Days", locator, null);
                LblDays2_ = new Label("ctl00_phF_tab_t0_lblDays2", "Days", locator, null);
                LblDays3_ = new Label("ctl00_phF_tab_t0_lblDays3", "Days", locator, null);
                LblDays4_ = new Label("ctl00_phF_tab_t0_lblDays4", "Days", locator, null);
                DataMemberName = "Setup";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BatchNumberingIDEdit()
            {
                Buttons.BatchNumberingIDEdit.Click();
            }
            
            public virtual void InvoiceNumberingIDEdit()
            {
                Buttons.InvoiceNumberingIDEdit.Click();
            }
            
            public virtual void DebitAdjNumberingIDEdit()
            {
                Buttons.DebitAdjNumberingIDEdit.Click();
            }
            
            public virtual void CreditAdjNumberingIDEdit()
            {
                Buttons.CreditAdjNumberingIDEdit.Click();
            }
            
            public virtual void CheckNumberingIDEdit()
            {
                Buttons.CheckNumberingIDEdit.Click();
            }
            
            public virtual void PriceWSNumberingIDEdit()
            {
                Buttons.PriceWSNumberingIDEdit.Click();
            }
            
            public virtual void DfltVendorClassIDEdit()
            {
                Buttons.DfltVendorClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BatchNumberingIDEdit { get; }
			public Button InvoiceNumberingIDEdit { get; }
			public Button DebitAdjNumberingIDEdit { get; }
			public Button CreditAdjNumberingIDEdit { get; }
			public Button CheckNumberingIDEdit { get; }
			public Button PriceWSNumberingIDEdit { get; }
			public Button DfltVendorClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    BatchNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edBatchNumberingID\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "BatchNumberingIDEdit", "ctl00_phF_tab");
                    BatchNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvoiceNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edInvoiceNumberingID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "InvoiceNumberingIDEdit", "ctl00_phF_tab");
                    InvoiceNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DebitAdjNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edDebitAdjNumberingID\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "DebitAdjNumberingIDEdit", "ctl00_phF_tab");
                    DebitAdjNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    CreditAdjNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edCreditAdjNumberingID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "CreditAdjNumberingIDEdit", "ctl00_phF_tab");
                    CreditAdjNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    CheckNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edCheckNumberingID\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "CheckNumberingIDEdit", "ctl00_phF_tab");
                    CheckNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceWSNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edPriceWSNumberingID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "PriceWSNumberingIDEdit", "ctl00_phF_tab");
                    PriceWSNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DfltVendorClassIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edDfltVendorClassID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "DfltVendorClassIDEdit", "ctl00_phF_tab");
                    DfltVendorClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_setup_discountparameters : Container
        {
            
			public DropDown PrintDirectSalesOn { get; }
			public Label PrintDirectSalesOnLabel { get; }
            
            public c_setup_discountparameters(string locator, string name) : 
                    base(locator, name)
            {
                PrintDirectSalesOn = new DropDown("ctl00_phF_tab_t3_DiscountParameters_edPrintDirectSalesOn", "Report Direct Sales On", locator, null);
                PrintDirectSalesOnLabel = new Label(PrintDirectSalesOn);
                PrintDirectSalesOn.DataField = "PrintDirectSalesOn";
                PrintDirectSalesOn.Items.Add("MA", "Form 1099-MISC Always");
                PrintDirectSalesOn.Items.Add("NA", "Form 1099-NEC Always");
                PrintDirectSalesOn.Items.Add("MF", "Form 1099-MISC if Filed for Payee");
                PrintDirectSalesOn.Items.Add("NF", "Form 1099-NEC if Filed for Payee");
                DataMemberName = "Setup";
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
        
        public class c_setupapproval_gridapproval : Grid<c_setupapproval_gridapproval.c_grid_row, c_setupapproval_gridapproval.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_setupapproval_gridapproval(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t2_gridApproval");
                DataMemberName = "SetupApproval";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t2_gridApproval_fe_gf", "FilterForm");
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
            
            public virtual void AssignmentMapIDEdit()
            {
                Buttons.AssignmentMapIDEdit.Click();
            }
            
            public virtual void AssignmentNotificationIDEdit()
            {
                Buttons.AssignmentNotificationIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AssignmentMapIDEdit { get; }
			public Button AssignmentNotificationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AssignmentMapIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentMapID\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "AssignmentMapIDEdit", "ctl00_phF_tab_t2_gridApproval");
                    AssignmentMapIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AssignmentNotificationIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentNotificationID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "AssignmentNotificationIDEdit", "ctl00_phF_tab_t2_gridApproval");
                    AssignmentNotificationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsActive { get; }
			public DropDown DocType { get; }
			public Selector AssignmentMapID { get; }
			public Selector AssignmentNotificationID { get; }
			public PXNumberEdit ApprovalID { get; }
                
                public c_grid_row(c_setupapproval_gridapproval grid) : 
                        base(grid)
                {
                    IsActive = new CheckBox("_ctl00_phF_tab_t2_gridApproval_lv0_edIsActive", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    DocType = new DropDown("_ctl00_phF_tab_t2_gridApproval_lv0_edDocType", "Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("INV", "Bill");
                    DocType.Items.Add("ACR", "Credit Adj.");
                    DocType.Items.Add("ADR", "Debit Adj.");
                    DocType.Items.Add("PPR", "Prepayment Req.");
                    DocType.Items.Add("CHK", "Check");
                    DocType.Items.Add("QCK", "Quick Check");
                    DocType.Items.Add("PPM", "Prepayment");
                    AssignmentMapID = new Selector("_ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentMapID", "Approval Map", grid.Locator, "AssignmentMapID");
                    AssignmentMapID.DataField = "AssignmentMapID";
                    AssignmentNotificationID = new Selector("_ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentNotificationID", "Pending Approval Notification", grid.Locator, "AssignmentNotificationID");
                    AssignmentNotificationID.DataField = "AssignmentNotificationID";
                    ApprovalID = new PXNumberEdit("ctl00_phF_tab_t2_gridApproval_en", "ApprovalID", grid.Locator, "ApprovalID");
                    ApprovalID.DataField = "ApprovalID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter IsActive { get; }
				public DropDownColumnFilter DocType { get; }
				public SelectorColumnFilter AssignmentMapID { get; }
				public SelectorColumnFilter AssignmentNotificationID { get; }
				public PXNumberEditColumnFilter ApprovalID { get; }
                
                public c_grid_header(c_setupapproval_gridapproval grid) : 
                        base(grid)
                {
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                    AssignmentMapID = new SelectorColumnFilter(grid.Row.AssignmentMapID);
                    AssignmentNotificationID = new SelectorColumnFilter(grid.Row.AssignmentNotificationID);
                    ApprovalID = new PXNumberEditColumnFilter(grid.Row.ApprovalID);
                }
            }
        }
        
        public class c_setupapproval_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
			public DropDown DocType { get; }
			public Label DocTypeLabel { get; }
			public Selector AssignmentMapID { get; }
			public Label AssignmentMapIDLabel { get; }
			public Selector AssignmentNotificationID { get; }
			public Label AssignmentNotificationIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_setupapproval_lv0(string locator, string name) : 
                    base(locator, name)
            {
                IsActive = new CheckBox("ctl00_phF_tab_t2_gridApproval_lv0_edIsActive", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                DocType = new DropDown("ctl00_phF_tab_t2_gridApproval_lv0_edDocType", "Type", locator, null);
                DocTypeLabel = new Label(DocType);
                DocType.DataField = "DocType";
                DocType.Items.Add("INV", "Bill");
                DocType.Items.Add("ACR", "Credit Adj.");
                DocType.Items.Add("ADR", "Debit Adj.");
                DocType.Items.Add("PPR", "Prepayment Req.");
                DocType.Items.Add("CHK", "Check");
                DocType.Items.Add("QCK", "Quick Check");
                DocType.Items.Add("PPM", "Prepayment");
                AssignmentMapID = new Selector("ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentMapID", "Approval Map", locator, null);
                AssignmentMapIDLabel = new Label(AssignmentMapID);
                AssignmentMapID.DataField = "AssignmentMapID";
                AssignmentNotificationID = new Selector("ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentNotificationID", "Pending Approval Notification", locator, null);
                AssignmentNotificationIDLabel = new Label(AssignmentNotificationID);
                AssignmentNotificationID.DataField = "AssignmentNotificationID";
                Es = new Selector("ctl00_phF_tab_t2_gridApproval_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "SetupApproval";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AssignmentMapIDEdit()
            {
                Buttons.AssignmentMapIDEdit.Click();
            }
            
            public virtual void AssignmentNotificationIDEdit()
            {
                Buttons.AssignmentNotificationIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AssignmentMapIDEdit { get; }
			public Button AssignmentNotificationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AssignmentMapIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentMapID\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "AssignmentMapIDEdit", "ctl00_phF_tab_t2_gridApproval_lv0");
                    AssignmentMapIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AssignmentNotificationIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentNotificationID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "AssignmentNotificationIDEdit", "ctl00_phF_tab_t2_gridApproval_lv0");
                    AssignmentNotificationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_boxes1099_grid : Grid<c_boxes1099_grid.c_grid_row, c_boxes1099_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_boxes1099_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t3_grid");
                DataMemberName = "Boxes1099";
                FilterForm = new c_grid_filter("ctl00_phF_tab_t3_grid_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXNumberEdit BoxNbr { get; }
			public PXTextEdit Descr { get; }
			public PXNumberEdit MinReportAmt { get; }
			public Selector AccountID { get; }
                
                public c_grid_row(c_boxes1099_grid grid) : 
                        base(grid)
                {
                    BoxNbr = new PXNumberEdit("_ctl00_phF_tab_t3_grid_lv0_edBoxNbr", "Box", grid.Locator, "BoxNbr");
                    BoxNbr.DataField = "BoxNbr";
                    Descr = new PXTextEdit("_ctl00_phF_tab_t3_grid_lv0_edDescr", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    MinReportAmt = new PXNumberEdit("_ctl00_phF_tab_t3_grid_lv0_edMinReportAmt", "Minimum Report Amount", grid.Locator, "MinReportAmt");
                    MinReportAmt.DataField = "MinReportAmt";
                    AccountID = new Selector("_ctl00_phF_tab_t3_grid_lv0_edAccountID", "Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXNumberEditColumnFilter BoxNbr { get; }
				public PXTextEditColumnFilter Descr { get; }
				public PXNumberEditColumnFilter MinReportAmt { get; }
				public SelectorColumnFilter AccountID { get; }
                
                public c_grid_header(c_boxes1099_grid grid) : 
                        base(grid)
                {
                    BoxNbr = new PXNumberEditColumnFilter(grid.Row.BoxNbr);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    MinReportAmt = new PXNumberEditColumnFilter(grid.Row.MinReportAmt);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                }
            }
        }
        
        public class c_boxes1099_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit BoxNbr { get; }
			public Label BoxNbrLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
			public PXNumberEdit MinReportAmt { get; }
			public Label MinReportAmtLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_boxes1099_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BoxNbr = new PXNumberEdit("ctl00_phF_tab_t3_grid_lv0_edBoxNbr", "Box", locator, null);
                BoxNbrLabel = new Label(BoxNbr);
                BoxNbr.DataField = "BoxNbr";
                Descr = new PXTextEdit("ctl00_phF_tab_t3_grid_lv0_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                MinReportAmt = new PXNumberEdit("ctl00_phF_tab_t3_grid_lv0_edMinReportAmt", "Minimum Report Amount", locator, null);
                MinReportAmtLabel = new Label(MinReportAmt);
                MinReportAmt.DataField = "MinReportAmt";
                AccountID = new Selector("ctl00_phF_tab_t3_grid_lv0_edAccountID", "Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                Es = new Selector("ctl00_phF_tab_t3_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Boxes1099";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AccountIDEdit()
            {
                Buttons.AccountIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AccountIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AccountIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t3_grid_lv0_edAccountID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "AccountIDEdit", "ctl00_phF_tab_t3_grid_lv0");
                    AccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_notifications_gridns : Grid<c_notifications_gridns.c_grid_row, c_notifications_gridns.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_notifications_gridns(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t4_sp1_gridNS");
                DataMemberName = "Notifications";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t4_sp1_gridNS_fe_gf", "FilterForm");
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
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t4_sp1_gridNS");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public PXTextEdit NotificationCD { get; }
			public Selector NBranchID { get; }
			public Selector EMailAccountID { get; }
			public Selector DefaultPrinterID { get; }
			public Selector ReportID { get; }
			public Selector NotificationID { get; }
			public DropDown Format { get; }
			public DropDown RecipientsBehavior { get; }
			public PXTextEdit SetupID { get; }
			public PXTextEdit Module { get; }
			public PXTextEdit SourceCD { get; }
                
                public c_grid_row(c_notifications_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBox("_ctl00_phF_tab_t4_sp1_gridNS_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    NotificationCD = new PXTextEdit("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edNotificationCD", "Mailing ID", grid.Locator, "NotificationCD");
                    NotificationCD.DataField = "NotificationCD";
                    NBranchID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edNBranchID", "Branch", grid.Locator, "NBranchID");
                    NBranchID.DataField = "NBranchID";
                    EMailAccountID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edEMailAccountID", "Default Email Account", grid.Locator, "EMailAccountID");
                    EMailAccountID.DataField = "EMailAccountID";
                    DefaultPrinterID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edDefPrinterID", "Default Printer", grid.Locator, "DefaultPrinterID");
                    DefaultPrinterID.DataField = "DefaultPrinterID";
                    ReportID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edReportID", "Report", grid.Locator, "ReportID");
                    ReportID.DataField = "ReportID";
                    NotificationID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edNotificationID", "Notification Template", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                    Format = new DropDown("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edFormat", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    RecipientsBehavior = new DropDown("_ctl00_phF_tab_t4_sp1_gridNS_lv0_ec", "Recipients", grid.Locator, "RecipientsBehavior");
                    RecipientsBehavior.DataField = "RecipientsBehavior";
                    RecipientsBehavior.Items.Add("O", "Override Recipients");
                    RecipientsBehavior.Items.Add("A", "Add Recipients");
                    SetupID = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNS_ei", "SetupID", grid.Locator, "SetupID");
                    SetupID.DataField = "SetupID";
                    Module = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNS_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    SourceCD = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNS_em", "SourceCD", grid.Locator, "SourceCD");
                    SourceCD.DataField = "SourceCD";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public PXTextEditColumnFilter NotificationCD { get; }
				public SelectorColumnFilter NBranchID { get; }
				public SelectorColumnFilter EMailAccountID { get; }
				public SelectorColumnFilter DefaultPrinterID { get; }
				public SelectorColumnFilter ReportID { get; }
				public SelectorColumnFilter NotificationID { get; }
				public DropDownColumnFilter Format { get; }
				public DropDownColumnFilter RecipientsBehavior { get; }
				public PXTextEditColumnFilter SetupID { get; }
				public PXTextEditColumnFilter Module { get; }
				public PXTextEditColumnFilter SourceCD { get; }
                
                public c_grid_header(c_notifications_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    NotificationCD = new PXTextEditColumnFilter(grid.Row.NotificationCD);
                    NBranchID = new SelectorColumnFilter(grid.Row.NBranchID);
                    EMailAccountID = new SelectorColumnFilter(grid.Row.EMailAccountID);
                    DefaultPrinterID = new SelectorColumnFilter(grid.Row.DefaultPrinterID);
                    ReportID = new SelectorColumnFilter(grid.Row.ReportID);
                    NotificationID = new SelectorColumnFilter(grid.Row.NotificationID);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    RecipientsBehavior = new DropDownColumnFilter(grid.Row.RecipientsBehavior);
                    SetupID = new PXTextEditColumnFilter(grid.Row.SetupID);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
                    SourceCD = new PXTextEditColumnFilter(grid.Row.SourceCD);
                }
            }
        }
        
        public class c_notifications_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NotificationCD { get; }
			public Label NotificationCDLabel { get; }
			public Selector NotificationID { get; }
			public Label NotificationIDLabel { get; }
			public Selector NBranchID { get; }
			public Label NBranchIDLabel { get; }
			public DropDown Format { get; }
			public Label FormatLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public Selector DefaultPrinterID { get; }
			public Label DefaultPrinterIDLabel { get; }
			public Selector ReportID { get; }
			public Label ReportIDLabel { get; }
			public Selector EMailAccountID { get; }
			public Label EMailAccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_notifications_lv0(string locator, string name) : 
                    base(locator, name)
            {
                NotificationCD = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNS_lv0_edNotificationCD", "Mailing ID", locator, null);
                NotificationCDLabel = new Label(NotificationCD);
                NotificationCD.DataField = "NotificationCD";
                NotificationID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edNotificationID", "Notification Template", locator, null);
                NotificationIDLabel = new Label(NotificationID);
                NotificationID.DataField = "NotificationID";
                NBranchID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edNBranchID", "Branch", locator, null);
                NBranchIDLabel = new Label(NBranchID);
                NBranchID.DataField = "NBranchID";
                Format = new DropDown("ctl00_phF_tab_t4_sp1_gridNS_lv0_edFormat", "Format", locator, null);
                FormatLabel = new Label(Format);
                Format.DataField = "Format";
                Format.Items.Add("H", "Html");
                Format.Items.Add("E", "Excel");
                Format.Items.Add("P", "PDF");
                Active = new CheckBox("ctl00_phF_tab_t4_sp1_gridNS_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                DefaultPrinterID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edDefPrinterID", "Default Printer", locator, null);
                DefaultPrinterIDLabel = new Label(DefaultPrinterID);
                DefaultPrinterID.DataField = "DefaultPrinterID";
                ReportID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edReportID", "Report", locator, null);
                ReportIDLabel = new Label(ReportID);
                ReportID.DataField = "ReportID";
                EMailAccountID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edEMailAccountID", "Default Email Account", locator, null);
                EMailAccountIDLabel = new Label(EMailAccountID);
                EMailAccountID.DataField = "EMailAccountID";
                Es = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phF_tab_t4_sp1_gridNS_lv0_ec", "Ec", locator, null);
                DataMemberName = "Notifications";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t4_sp1_gridNS_lv0");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_recipients_gridnr : Grid<c_recipients_gridnr.c_grid_row, c_recipients_gridnr.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_recipients_gridnr(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t4_sp1_gridNR");
                DataMemberName = "Recipients";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t4_sp1_gridNR_fe_gf", "FilterForm");
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
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t4_sp1_gridNR");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public DropDown ContactType { get; }
			public PXNumberEdit OriginalContactID { get; }
			public Selector ContactID { get; }
			public DropDown Format { get; }
			public DropDown AddTo { get; }
			public PXTextEdit RecipientID { get; }
                
                public c_grid_row(c_recipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBox("ctl00_phF_tab_t4_sp1_gridNR_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    ContactType = new DropDown("_ctl00_phF_tab_t4_sp1_gridNR_lv0_ec", "Contact Type", grid.Locator, "ContactType");
                    ContactType.DataField = "ContactType";
                    ContactType.Items.Add("P", "Primary");
                    ContactType.Items.Add("R", "Remittance");
                    ContactType.Items.Add("S", "Shipping");
                    ContactType.Items.Add("E", "Employee");
                    OriginalContactID = new PXNumberEdit("ctl00_phF_tab_t4_sp1_gridNR_en", "OriginalContactID", grid.Locator, "OriginalContactID");
                    OriginalContactID.DataField = "OriginalContactID";
                    ContactID = new Selector("_ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                    Format = new DropDown("_ctl00_phF_tab_t4_sp1_gridNR_lv0_ec", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    AddTo = new DropDown("_ctl00_phF_tab_t4_sp1_gridNR_lv0_ec", "Add To", grid.Locator, "AddTo");
                    AddTo.DataField = "AddTo";
                    AddTo.Items.Add("T", "To");
                    AddTo.Items.Add("C", "Cc");
                    AddTo.Items.Add("B", "Bcc");
                    RecipientID = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNR_ei", "RecipientID", grid.Locator, "RecipientID");
                    RecipientID.DataField = "RecipientID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public DropDownColumnFilter ContactType { get; }
				public PXNumberEditColumnFilter OriginalContactID { get; }
				public SelectorColumnFilter ContactID { get; }
				public DropDownColumnFilter Format { get; }
				public DropDownColumnFilter AddTo { get; }
				public PXTextEditColumnFilter RecipientID { get; }
                
                public c_grid_header(c_recipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    ContactType = new DropDownColumnFilter(grid.Row.ContactType);
                    OriginalContactID = new PXNumberEditColumnFilter(grid.Row.OriginalContactID);
                    ContactID = new SelectorColumnFilter(grid.Row.ContactID);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    AddTo = new DropDownColumnFilter(grid.Row.AddTo);
                    RecipientID = new PXTextEditColumnFilter(grid.Row.RecipientID);
                }
            }
        }
        
        public class c_recipients_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ContactID { get; }
			public Label ContactIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_recipients_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ContactID = new Selector("ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID", "Contact ID", locator, null);
                ContactIDLabel = new Label(ContactID);
                ContactID.DataField = "ContactID";
                Es = new Selector("ctl00_phF_tab_t4_sp1_gridNR_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phF_tab_t4_sp1_gridNR_lv0_ec", "Ec", locator, null);
                DataMemberName = "Recipients";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t4_sp1_gridNR_lv0");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
