using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.CheckBoxButton;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.EmailEdit;
using Controls.Editors.Selector;
using Controls.Editors.TreeSelector;
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
using Controls.UnknownControl;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ISVTestSDK.Extensions
{
    
    
    public class AR304000_ARCashSaleEntry : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        protected c_document_form Document_form { get; } = new c_document_form("ctl00_phF_form", "Document_form");
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
        protected c_currencyinfo_rf CurrencyInfo_rf { get; } = new c_currencyinfo_rf("ctl00_phF_form_t0_edCury_pnlRate_rf", "CurrencyInfo_rf");
        protected c_currentdocument_tab CurrentDocument_tab { get; } = new c_currentdocument_tab("ctl00_phG_tab", "CurrentDocument_tab");
        protected c_currentdocument_commission CurrentDocument_Commission { get; } = new c_currentdocument_commission("ctl00_phG_tab_t5_Commission", "CurrentDocument_Commission");
        protected c_transactions_grid Transactions_grid { get; } = new c_transactions_grid("ctl00_phG_tab_t0_grid", "Transactions_grid");
        protected c_transactions_lv0 Transactions_lv0 { get; } = new c_transactions_lv0("ctl00_phG_tab_t0_grid_lv0", "Transactions_lv0");
        protected c_taxes_grid1 Taxes_grid1 { get; } = new c_taxes_grid1("ctl00_phG_tab_t3_grid1", "Taxes_grid1");
        protected c_taxes_lv0 Taxes_lv0 { get; } = new c_taxes_lv0("ctl00_phG_tab_t3_grid1_lv0", "Taxes_lv0");
        protected c_billing_address_billing_address Billing_Address_Billing_Address { get; } = new c_billing_address_billing_address("ctl00_phG_tab_t2_Billing_Address", "Billing_Address_Billing_Address");
        protected c_billing_contact_billing_contact Billing_Contact_Billing_Contact { get; } = new c_billing_contact_billing_contact("ctl00_phG_tab_t2_Billing_Contact", "Billing_Contact_Billing_Contact");
        protected c_shipping_address_shipping_address Shipping_Address_Shipping_Address { get; } = new c_shipping_address_shipping_address("ctl00_phG_tab_t2_Shipping_Address", "Shipping_Address_Shipping_Address");
        protected c_shipping_contact_shipping_contact Shipping_Contact_Shipping_Contact { get; } = new c_shipping_contact_shipping_contact("ctl00_phG_tab_t2_Shipping_Contact", "Shipping_Contact_Shipping_Contact");
        protected c_salespertrans_grdsalespertrans Salespertrans_grdsalespertrans { get; } = new c_salespertrans_grdsalespertrans("ctl00_phG_tab_t5_grdSalesPerTrans", "salesPerTrans_grdSalesPerTrans");
        protected c_salespertrans_lv0 Salespertrans_lv0 { get; } = new c_salespertrans_lv0("ctl00_phG_tab_t5_grdSalesPerTrans_lv0", "salesPerTrans_lv0");
        protected c_paymentcharges_detgrid3 PaymentCharges_detgrid3 { get; } = new c_paymentcharges_detgrid3("ctl00_phG_tab_t6_detgrid3", "PaymentCharges_detgrid3");
        protected c_paymentcharges_lv0 PaymentCharges_lv0 { get; } = new c_paymentcharges_lv0("ctl00_phG_tab_t6_detgrid3_lv0", "PaymentCharges_lv0");
        protected c_voucher_voucherdetails Voucher_VoucherDetails { get; } = new c_voucher_voucherdetails("ctl00_phG_tab_t1_VoucherDetails", "Voucher_VoucherDetails");
        protected c_ccproctran_grdccproctran Ccproctran_grdccproctran { get; } = new c_ccproctran_grdccproctran("ctl00_phG_tab_t7_grdCCProcTran", "ccProcTran_grdCCProcTran");
        protected c_ccproctran_lv0 Ccproctran_lv0 { get; } = new c_ccproctran_lv0("ctl00_phG_tab_t7_grdCCProcTran_lv0", "ccProcTran_lv0");
        protected c_approval_gridapproval Approval_gridApproval { get; } = new c_approval_gridapproval("ctl00_phG_tab_t4_gridApproval", "Approval_gridApproval");
        protected c_approval_lv0 Approval_lv0 { get; } = new c_approval_lv0("ctl00_phG_tab_t4_gridApproval_lv0", "Approval_lv0");
        protected c_addresslookupfilter_addresslookuppanelformaddress AddressLookupFilter_AddressLookupPanelformAddress { get; } = new c_addresslookupfilter_addresslookuppanelformaddress("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress", "AddressLookupFilter_AddressLookupPanelformAddress");
        protected c_reasonapproverejectparams_pxformviewpanelreason ReasonApproveRejectParams_PXFormViewPanelReason { get; } = new c_reasonapproverejectparams_pxformviewpanelreason("ctl00_phG_panelReason_PXFormViewPanelReason", "ReasonApproveRejectParams_PXFormViewPanelReason");
        protected c_workflowview_workflowfictivediagram WorkflowView_WorkflowFictiveDiagram { get; } = new c_workflowview_workflowfictivediagram("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram", "WorkflowView_WorkflowFictiveDiagram");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public AR304000_ARCashSaleEntry()
        {
            ScreenId = "AR304000";
            ScreenUrl = "/Pages/AR/AR304000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AR304000_ARCashSaleEntry ReadOne(Gate gate, string DocType, string RefNbr)
        {
            new BiObject<AR304000_ARCashSaleEntry>(gate).ReadOne(this, DocType, RefNbr);
            return this;
        }
        
        public virtual AR304000_ARCashSaleEntry ReadOne(string DocType, string RefNbr)
        {
            return this.ReadOne(ApiConnection.Source, DocType, RefNbr);
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
        
        public virtual void ManageAttributes()
        {
            ToolBar.ManageAttributes.Click();
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
        
        public virtual void InitializeState()
        {
            ToolBar.InitializeState.Click();
        }
        
        public virtual void ReleaseFromHold()
        {
            ToolBar.ReleaseFromHold.Click();
        }
        
        public virtual void Approve()
        {
            ToolBar.Approve.Click();
        }
        
        public virtual void Reject()
        {
            ToolBar.Reject.Click();
        }
        
        public virtual void PutOnHold()
        {
            ToolBar.PutOnHold.Click();
        }
        
        public virtual void CaptureCCPayment()
        {
            ToolBar.CaptureCCPayment.Click();
        }
        
        public virtual void CaptureCCPayment(bool status, string message = null)
        {
            ToolBar.CaptureCCPayment.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CaptureCCPayment.Click();
        }
        
        public virtual void AuthorizeCCPayment()
        {
            ToolBar.AuthorizeCCPayment.Click();
        }
        
        public virtual void AuthorizeCCPayment(bool status, string message = null)
        {
            ToolBar.AuthorizeCCPayment.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.AuthorizeCCPayment.Click();
        }
        
        public virtual void VoidCCPayment()
        {
            ToolBar.VoidCCPayment.Click();
        }
        
        public virtual void VoidCCPayment(bool status, string message = null)
        {
            ToolBar.VoidCCPayment.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.VoidCCPayment.Click();
        }
        
        public virtual void CreditCCPayment()
        {
            ToolBar.CreditCCPayment.Click();
        }
        
        public virtual void CreditCCPayment(bool status, string message = null)
        {
            ToolBar.CreditCCPayment.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CreditCCPayment.Click();
        }
        
        public virtual void RecordCCPayment()
        {
            ToolBar.RecordCCPayment.Click();
        }
        
        public virtual void RecordCCPayment(bool status, string message = null)
        {
            ToolBar.RecordCCPayment.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.RecordCCPayment.Click();
        }
        
        public virtual void CaptureOnlyCCPayment()
        {
            ToolBar.CaptureOnlyCCPayment.Click();
        }
        
        public virtual void CaptureOnlyCCPayment(bool status, string message = null)
        {
            ToolBar.CaptureOnlyCCPayment.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CaptureOnlyCCPayment.Click();
        }
        
        public virtual void ValidateCCPayment()
        {
            ToolBar.ValidateCCPayment.Click();
        }
        
        public virtual void ValidateCCPayment(bool status, string message = null)
        {
            ToolBar.ValidateCCPayment.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ValidateCCPayment.Click();
        }
        
        public virtual void PrintInvoice()
        {
            ToolBar.PrintInvoice.Click();
        }
        
        public virtual void EmailInvoice()
        {
            ToolBar.EmailInvoice.Click();
        }
        
        public virtual void Release()
        {
            ToolBar.Release.Click();
        }
        
        public virtual void Release(bool status, string message = null)
        {
            ToolBar.Release.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Release.Click();
        }
        
        public virtual void VoidCheck()
        {
            ToolBar.VoidCheck.Click();
        }
        
        public virtual void VoidCheck(bool status, string message = null)
        {
            ToolBar.VoidCheck.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.VoidCheck.Click();
        }
        
        public virtual void ReclassifyBatch()
        {
            ToolBar.ReclassifyBatch.Click();
        }
        
        public virtual void SendEmail()
        {
            ToolBar.SendEmail.Click();
        }
        
        public virtual void CustomerDocuments()
        {
            ToolBar.CustomerDocuments.Click();
        }
        
        public virtual void PrintAREdit()
        {
            ToolBar.PrintAREdit.Click();
        }
        
        public virtual void PrintARRegister()
        {
            ToolBar.PrintARRegister.Click();
        }
        
        public virtual void Action()
        {
            ToolBar.Action.Click();
        }
        
        public virtual void ProcessingID()
        {
            ToolBar.ProcessingID.Click();
        }
        
        public virtual void CardProcessingID()
        {
            ToolBar.CardProcessingID.Click();
        }
        
        public virtual void CorrectionsID()
        {
            ToolBar.CorrectionsID.Click();
        }
        
        public virtual void ApprovalID()
        {
            ToolBar.ApprovalID.Click();
        }
        
        public virtual void PrintingAndEmailingID()
        {
            ToolBar.PrintingAndEmailingID.Click();
        }
        
        public virtual void OtherID()
        {
            ToolBar.OtherID.Click();
        }
        
        public virtual void Inquiry()
        {
            ToolBar.Inquiry.Click();
        }
        
        public virtual void Report()
        {
            ToolBar.Report.Click();
        }
        
        public virtual void ViewActivity()
        {
            ToolBar.ViewActivity.Click();
        }
        
        public virtual void ViewactivityWorkflow()
        {
            ToolBar.ViewactivityWorkflow.Click();
        }
        
        public virtual void OpenActivityOwner()
        {
            ToolBar.OpenActivityOwner.Click();
        }
        
        public virtual void OpenactivityownerWorkflow()
        {
            ToolBar.OpenactivityownerWorkflow.Click();
        }
        
        public virtual void ViewAllActivities()
        {
            ToolBar.ViewAllActivities.Click();
        }
        
        public virtual void ViewallactivitiesWorkflow()
        {
            ToolBar.ViewallactivitiesWorkflow.Click();
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
			public ToolBarButton ManageAttributes { get; }
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
			public ToolBarButton InitializeState { get; }
			public ToolBarButton ReleaseFromHold { get; }
			public ToolBarButton Approve { get; }
			public ToolBarButton Reject { get; }
			public ToolBarButton PutOnHold { get; }
			public ToolBarButton CaptureCCPayment { get; }
			public ToolBarButton AuthorizeCCPayment { get; }
			public ToolBarButton VoidCCPayment { get; }
			public ToolBarButton CreditCCPayment { get; }
			public ToolBarButton RecordCCPayment { get; }
			public ToolBarButton CaptureOnlyCCPayment { get; }
			public ToolBarButton ValidateCCPayment { get; }
			public ToolBarButton PrintInvoice { get; }
			public ToolBarButton EmailInvoice { get; }
			public ToolBarButton Release { get; }
			public ToolBarButton VoidCheck { get; }
			public ToolBarButton ReclassifyBatch { get; }
			public ToolBarButton SendEmail { get; }
			public ToolBarButton CustomerDocuments { get; }
			public ToolBarButton PrintAREdit { get; }
			public ToolBarButton PrintARRegister { get; }
			public ToolBarButton Action { get; }
			public ToolBarButton ProcessingID { get; }
			public ToolBarButton CardProcessingID { get; }
			public ToolBarButton CorrectionsID { get; }
			public ToolBarButton ApprovalID { get; }
			public ToolBarButton PrintingAndEmailingID { get; }
			public ToolBarButton OtherID { get; }
			public ToolBarButton Inquiry { get; }
			public ToolBarButton Report { get; }
			public ToolBarButton ViewActivity { get; }
			public ToolBarButton ViewactivityWorkflow { get; }
			public ToolBarButton OpenActivityOwner { get; }
			public ToolBarButton OpenactivityownerWorkflow { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton ViewallactivitiesWorkflow { get; }
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
                ManageAttributes = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ManageAttributes\']", "Manage User-Defined Fields", locator, Custom);
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
                Delete.ConfirmAction = () => Alert.AlertToException("The current Cash Sale record will be deleted.");
                CopyPaste = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CopyPaste", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@CopyDocument\']", "CopyDocument", locator, CopyPaste);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@PasteDocument\']", "PasteDocument", locator, CopyPaste);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@SaveTemplate\']", "SaveTemplate", locator, CopyPaste);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                InitializeState = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_initializeState,#ctl00_phDS_ds_ToolBar_initializeState" +
                        "_item", "Initialize State", locator, MenuOpener);
                ReleaseFromHold = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReleaseFromHold,#ctl00_phDS_ds_ToolBar_ReleaseFromHold" +
                        "_item", "Remove Hold", locator, MenuOpener);
                Approve = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Approve,#ctl00_phDS_ds_ToolBar_Approve_item", "Approve", locator, MenuOpener);
                Reject = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Reject,#ctl00_phDS_ds_ToolBar_Reject_item", "Reject", locator, MenuOpener);
                PutOnHold = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PutOnHold,#ctl00_phDS_ds_ToolBar_PutOnHold_item", "Hold", locator, MenuOpener);
                CaptureCCPayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CaptureCCPayment,#ctl00_phDS_ds_ToolBar_CaptureCCPayme" +
                        "nt_item", "Capture", locator, MenuOpener);
                CaptureCCPayment.WaitAction = Wait.WaitForLongOperationToComplete;
                AuthorizeCCPayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_AuthorizeCCPayment,#ctl00_phDS_ds_ToolBar_AuthorizeCCP" +
                        "ayment_item", "Authorize", locator, MenuOpener);
                AuthorizeCCPayment.WaitAction = Wait.WaitForLongOperationToComplete;
                VoidCCPayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VoidCCPayment,#ctl00_phDS_ds_ToolBar_VoidCCPayment_ite" +
                        "m", "Void Card Payment", locator, MenuOpener);
                VoidCCPayment.WaitAction = Wait.WaitForLongOperationToComplete;
                CreditCCPayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreditCCPayment,#ctl00_phDS_ds_ToolBar_CreditCCPayment" +
                        "_item", "Refund Card Payment", locator, MenuOpener);
                CreditCCPayment.WaitAction = Wait.WaitForLongOperationToComplete;
                RecordCCPayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_RecordCCPayment,#ctl00_phDS_ds_ToolBar_RecordCCPayment" +
                        "_item", "Record Card Payment", locator, MenuOpener);
                RecordCCPayment.WaitAction = Wait.WaitForLongOperationToComplete;
                CaptureOnlyCCPayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CaptureOnlyCCPayment,#ctl00_phDS_ds_ToolBar_CaptureOnl" +
                        "yCCPayment_item", "Record and Capture Preauthorization", locator, MenuOpener);
                CaptureOnlyCCPayment.WaitAction = Wait.WaitForLongOperationToComplete;
                ValidateCCPayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ValidateCCPayment,#ctl00_phDS_ds_ToolBar_ValidateCCPay" +
                        "ment_item", "Validate Card Payment", locator, MenuOpener);
                ValidateCCPayment.WaitAction = Wait.WaitForLongOperationToComplete;
                PrintInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintInvoice,#ctl00_phDS_ds_ToolBar_PrintInvoice_item", "Print", locator, MenuOpener);
                EmailInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_EmailInvoice,#ctl00_phDS_ds_ToolBar_EmailInvoice_item", "Email", locator, MenuOpener);
                Release = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Release,#ctl00_phDS_ds_ToolBar_Release_item", "Release", locator, MenuOpener);
                Release.WaitAction = Wait.WaitForLongOperationToComplete;
                VoidCheck = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VoidCheck,#ctl00_phDS_ds_ToolBar_VoidCheck_item", "Reverse", locator, MenuOpener);
                VoidCheck.WaitAction = Wait.WaitForLongOperationToComplete;
                ReclassifyBatch = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReclassifyBatch,#ctl00_phDS_ds_ToolBar_ReclassifyBatch" +
                        "_item", "Reclassify GL Batch", locator, MenuOpener);
                SendEmail = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SendEmail,#ctl00_phDS_ds_ToolBar_SendEmail_item", "Send Email", locator, MenuOpener);
                CustomerDocuments = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CustomerDocuments,#ctl00_phDS_ds_ToolBar_CustomerDocum" +
                        "ents_item", "Customer Details", locator, MenuOpener);
                PrintAREdit = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintAREdit,#ctl00_phDS_ds_ToolBar_PrintAREdit_item", "AR Edit Detailed", locator, MenuOpener);
                PrintARRegister = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintARRegister,#ctl00_phDS_ds_ToolBar_PrintARRegister" +
                        "_item", "AR Register Detailed", locator, MenuOpener);
                Action = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Action", "Actions", locator, MenuOpener);
                ProcessingID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ProcessingID", "Processing", locator, MenuOpener);
                CardProcessingID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CardProcessingID", "Card Processing", locator, MenuOpener);
                CorrectionsID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CorrectionsID", "Corrections", locator, MenuOpener);
                ApprovalID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ApprovalID", "Approval", locator, MenuOpener);
                PrintingAndEmailingID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintingAndEmailingID", "Printing and Emailing", locator, MenuOpener);
                OtherID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_OtherID", "Other", locator, MenuOpener);
                Inquiry = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Inquiry", "Inquiries", locator, MenuOpener);
                Report = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Report", "Reports", locator, MenuOpener);
                ViewActivity = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewActivity,#ctl00_phDS_ds_ToolBar_ViewActivity_item", "Details", locator, MenuOpener);
                ViewactivityWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewActivity_Workflow,#ctl00_phDS_ds_ToolBar_ViewActiv" +
                        "ity_Workflow_item", "Details", locator, MenuOpener);
                OpenActivityOwner = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_OpenActivityOwner,#ctl00_phDS_ds_ToolBar_OpenActivityO" +
                        "wner_item", "OpenActivityOwner", locator, MenuOpener);
                OpenactivityownerWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_OpenActivityOwner_Workflow,#ctl00_phDS_ds_ToolBar_Open" +
                        "ActivityOwner_Workflow_item", "OpenActivityOwner_Workflow", locator, MenuOpener);
                ViewAllActivities = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewAllActivities,#ctl00_phDS_ds_ToolBar_ViewAllActivi" +
                        "ties_item", "View Activities", locator, MenuOpener);
                ViewallactivitiesWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewAllActivities_Workflow,#ctl00_phDS_ds_ToolBar_View" +
                        "AllActivities_Workflow_item", "View Activities", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_document_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown DocType { get; }
			public Label DocTypeLabel { get; }
			public Selector RefNbr { get; }
			public Label RefNbrLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public DateSelector AdjDate { get; }
			public Label AdjDateLabel { get; }
			public Selector AdjFinPeriodID { get; }
			public Label AdjFinPeriodIDLabel { get; }
			public PXTextEdit ExtRefNbr { get; }
			public Label ExtRefNbrLabel { get; }
			public DateSelector DepositAfter { get; }
			public Label DepositAfterLabel { get; }
			public PXTextEdit DocDesc { get; }
			public Label DocDescLabel { get; }
			public Selector CustomerID { get; }
			public Label CustomerIDLabel { get; }
			public Selector CustomerLocationID { get; }
			public Label CustomerLocationIDLabel { get; }
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public Selector PMInstanceID { get; }
			public Label PMInstanceIDLabel { get; }
			public PXTextEdit CCPaymentStateDescr { get; }
			public Label CCPaymentStateDescrLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBoxButton CuryViewState { get; }
			public Label CuryViewStateLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public PXNumberEdit CuryLineTotal { get; }
			public Label CuryLineTotalLabel { get; }
			public PXNumberEdit CuryVatTaxableTotal { get; }
			public Label CuryVatTaxableTotalLabel { get; }
			public PXNumberEdit CuryVatExemptTotal { get; }
			public Label CuryVatExemptTotalLabel { get; }
			public PXNumberEdit CuryTaxTotal { get; }
			public Label CuryTaxTotalLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public PXNumberEdit CuryRoundDiff { get; }
			public Label CuryRoundDiffLabel { get; }
			public PXNumberEdit CuryOrigDocAmt { get; }
			public Label CuryOrigDocAmtLabel { get; }
			public PXNumberEdit CuryOrigDiscAmt { get; }
			public Label CuryOrigDiscAmtLabel { get; }
			public PXNumberEdit CuryChargeAmt { get; }
			public Label CuryChargeAmtLabel { get; }
			public PXNumberEdit CuryConsolidateChargeTotal { get; }
			public Label CuryConsolidateChargeTotalLabel { get; }
			public Selector RefTranExtNbr { get; }
			public Label RefTranExtNbrLabel { get; }
			public Label Ctl30_ { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
			public Label Ctl02_ { get; }
            
            public c_document_form(string locator, string name) : 
                    base(locator, name)
            {
                DocType = new DropDown("ctl00_phF_form_t0_edDocType", "Type", locator, null);
                DocTypeLabel = new Label(DocType);
                DocType.DataField = "DocType";
                DocType.Items.Add("CSL", "Cash Sale");
                DocType.Items.Add("RCS", "Cash Return");
                RefNbr = new Selector("ctl00_phF_form_t0_edRefNbr", "Reference Nbr.", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                Status = new DropDown("ctl00_phF_form_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("R", "Credit Hold");
                Status.Items.Add("W", "Pending Processing");
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("B", "Balanced");
                Status.Items.Add("V", "Voided");
                Status.Items.Add("S", "Scheduled");
                Status.Items.Add("N", "Open");
                Status.Items.Add("C", "Closed");
                Status.Items.Add("P", "Pending Print");
                Status.Items.Add("E", "Pending Email");
                Status.Items.Add("Z", "Reserved");
                Status.Items.Add("D", "Pending Approval");
                Status.Items.Add("J", "Rejected");
                Status.Items.Add("L", "Canceled");
                AdjDate = new DateSelector("ctl00_phF_form_t0_edAdjDate", "Date", locator, null);
                AdjDateLabel = new Label(AdjDate);
                AdjDate.DataField = "AdjDate";
                AdjFinPeriodID = new Selector("ctl00_phF_form_t0_edAdjFinPeriodID", "Post Period", locator, null);
                AdjFinPeriodIDLabel = new Label(AdjFinPeriodID);
                AdjFinPeriodID.DataField = "AdjFinPeriodID";
                ExtRefNbr = new PXTextEdit("ctl00_phF_form_t0_edExtRefNbr", "Payment Ref.", locator, null);
                ExtRefNbrLabel = new Label(ExtRefNbr);
                ExtRefNbr.DataField = "ExtRefNbr";
                DepositAfter = new DateSelector("ctl00_phF_form_t0_edDepositAfter", "Deposit After", locator, null);
                DepositAfterLabel = new Label(DepositAfter);
                DepositAfter.DataField = "DepositAfter";
                DocDesc = new PXTextEdit("ctl00_phF_form_t0_edDocDesc", "Description", locator, null);
                DocDescLabel = new Label(DocDesc);
                DocDesc.DataField = "DocDesc";
                CustomerID = new Selector("ctl00_phF_form_t0_edCustomerID", "Customer", locator, null);
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.DataField = "CustomerID";
                CustomerLocationID = new Selector("ctl00_phF_form_t0_edCustomerLocationID", "Location", locator, null);
                CustomerLocationIDLabel = new Label(CustomerLocationID);
                CustomerLocationID.DataField = "CustomerLocationID";
                PaymentMethodID = new Selector("ctl00_phF_form_t0_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                PMInstanceID = new Selector("ctl00_phF_form_t0_edPMInstanceID", "Card/Account Nbr.", locator, null);
                PMInstanceIDLabel = new Label(PMInstanceID);
                PMInstanceID.DataField = "PMInstanceID";
                CCPaymentStateDescr = new PXTextEdit("ctl00_phF_form_t0_PXTextEdit1", "Processing Status", locator, null);
                CCPaymentStateDescrLabel = new Label(CCPaymentStateDescr);
                CCPaymentStateDescr.DataField = "CCPaymentStateDescr";
                CashAccountID = new Selector("ctl00_phF_form_t0_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                CuryID = new Selector("ctl00_phF_form_t0_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phF_form_t0_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                ProjectID = new Selector("ctl00_phF_form_t0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                CuryLineTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryLineTotal", "Detail Total", locator, null);
                CuryLineTotalLabel = new Label(CuryLineTotal);
                CuryLineTotal.DataField = "CuryLineTotal";
                CuryVatTaxableTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryVatTaxableTotal", "VAT Taxable Total", locator, null);
                CuryVatTaxableTotalLabel = new Label(CuryVatTaxableTotal);
                CuryVatTaxableTotal.DataField = "CuryVatTaxableTotal";
                CuryVatExemptTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryVatExemptTotal", "VAT Exempt Total", locator, null);
                CuryVatExemptTotalLabel = new Label(CuryVatExemptTotal);
                CuryVatExemptTotal.DataField = "CuryVatExemptTotal";
                CuryTaxTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryTaxTotal", "Tax Total", locator, null);
                CuryTaxTotalLabel = new Label(CuryTaxTotal);
                CuryTaxTotal.DataField = "CuryTaxTotal";
                CuryDocBal = new PXNumberEdit("ctl00_phF_form_t0_edCuryDocBal", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                CuryRoundDiff = new PXNumberEdit("ctl00_phF_form_t0_edCuryRoundDiff", "Rounding Diff.", locator, null);
                CuryRoundDiffLabel = new Label(CuryRoundDiff);
                CuryRoundDiff.DataField = "CuryRoundDiff";
                CuryOrigDocAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrigDocAmt", "Payment Amount", locator, null);
                CuryOrigDocAmtLabel = new Label(CuryOrigDocAmt);
                CuryOrigDocAmt.DataField = "CuryOrigDocAmt";
                CuryOrigDiscAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrigDiscAmt", "Cash Discount Taken", locator, null);
                CuryOrigDiscAmtLabel = new Label(CuryOrigDiscAmt);
                CuryOrigDiscAmt.DataField = "CuryOrigDiscAmt";
                CuryChargeAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryChargeAmt", "Finance Charges", locator, null);
                CuryChargeAmtLabel = new Label(CuryChargeAmt);
                CuryChargeAmt.DataField = "CuryChargeAmt";
                CuryConsolidateChargeTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryConsolidateChargeTotal", "Deducted Charges", locator, null);
                CuryConsolidateChargeTotalLabel = new Label(CuryConsolidateChargeTotal);
                CuryConsolidateChargeTotal.DataField = "CuryConsolidateChargeTotal";
                RefTranExtNbr = new Selector("ctl00_phF_form_t0_edRefTranExtNbr", "Orig. Transaction", locator, null);
                RefTranExtNbrLabel = new Label(RefTranExtNbr);
                RefTranExtNbr.DataField = "RefTranExtNbr";
                Ctl30_ = new Label("ctl00_phF_form_t0_ctl30", "Ctl 30_", locator, null);
                LblCount_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblCount2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                Ctl02_ = new Label("ctl00_phF_form_t1_ctl02", "No user-defined fields have been found.", locator, null);
                DataMemberName = "Document";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Viewbase()
            {
                Buttons.Viewbase.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void CustomerIDEdit()
            {
                Buttons.CustomerIDEdit.Click();
            }
            
            public virtual void ProjectIDEdit()
            {
                Buttons.ProjectIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
			public Button CustomerIDEdit { get; }
			public Button ProjectIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phF_form_t0_edCury_rateB", "0", "ctl00_phF_form");
                    Viewbase = new Button("ctl00_phF_form_t0_edCury_curyB", "View base", "ctl00_phF_form");
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form");
                    CustomerIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edCustomerID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "CustomerIDEdit", "ctl00_phF_form");
                    CustomerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ProjectIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edProjectID\'] div[class=\'editBtnCont\'] > div > div", "ProjectIDEdit", "ctl00_phF_form");
                    ProjectIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
        
        public class c_currencyinfo_rf : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CuryRateTypeID { get; }
			public Label CuryRateTypeIDLabel { get; }
			public DateSelector CuryEffDate { get; }
			public Label CuryEffDateLabel { get; }
			public PXTextEdit DisplayCuryID { get; }
			public Label DisplayCuryIDLabel { get; }
			public PXNumberEdit SampleCuryRate { get; }
			public Label SampleCuryRateLabel { get; }
			public PXTextEdit BaseCuryID { get; }
			public Label BaseCuryIDLabel { get; }
			public PXTextEdit BaseCuryID2 { get; }
			public Label BaseCuryID2Label { get; }
			public PXNumberEdit SampleRecipRate { get; }
			public Label SampleRecipRateLabel { get; }
			public PXTextEdit DisplayCuryID2 { get; }
			public Label DisplayCuryID2Label { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
            
            public c_currencyinfo_rf(string locator, string name) : 
                    base(locator, name)
            {
                CuryRateTypeID = new Selector("ctl00_phF_form_t0_edCury_pnlRate_rf_edRateType", "Curr. Rate Type ID", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                CuryEffDate = new DateSelector("ctl00_phF_form_t0_edCury_pnlRate_rf_edEffDate", "Effective Date", locator, null);
                CuryEffDateLabel = new Label(CuryEffDate);
                CuryEffDate.DataField = "CuryEffDate";
                DisplayCuryID = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCury", "Display Cury ID", locator, null);
                DisplayCuryIDLabel = new Label(DisplayCuryID);
                DisplayCuryID.DataField = "DisplayCuryID";
                SampleCuryRate = new PXNumberEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCuryRate", "Sample Cury Rate", locator, null);
                SampleCuryRateLabel = new Label(SampleCuryRate);
                SampleCuryRate.DataField = "SampleCuryRate";
                BaseCuryID = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtBaseCury", "Base Cury ID", locator, null);
                BaseCuryIDLabel = new Label(BaseCuryID);
                BaseCuryID.DataField = "BaseCuryID";
                BaseCuryID2 = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtBaseCury2", "Base Cury ID 2", locator, null);
                BaseCuryID2Label = new Label(BaseCuryID2);
                BaseCuryID2.DataField = "BaseCuryID";
                SampleRecipRate = new PXNumberEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCuryRate2", "Sample Recip Rate", locator, null);
                SampleRecipRateLabel = new Label(SampleRecipRate);
                SampleRecipRate.DataField = "SampleRecipRate";
                DisplayCuryID2 = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCury2", "Display Cury ID 2", locator, null);
                DisplayCuryID2Label = new Label(DisplayCuryID2);
                DisplayCuryID2.DataField = "DisplayCuryID";
                LblCount_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblCount2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                DataMemberName = "CurrencyInfo";
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
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form_t0_edCury_pnlRate_rf");
                }
            }
        }
        
        public class c_currentdocument_tab : Container
        {
            
			public Selector BatchNbr { get; }
			public Label BatchNbrLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector ARAccountID { get; }
			public Label ARAccountIDLabel { get; }
			public Selector ARSubID { get; }
			public Label ARSubIDLabel { get; }
			public PXTextEdit OrigRefNbr { get; }
			public Label OrigRefNbrLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public CheckBox Cleared { get; }
			public Label ClearedLabel { get; }
			public DateSelector ClearDate { get; }
			public Label ClearDateLabel { get; }
			public CheckBox DepositAsBatch { get; }
			public Label DepositAsBatchLabel { get; }
			public CheckBox Deposited { get; }
			public Label DepositedLabel { get; }
			public DateSelector DepositDate { get; }
			public Label DepositDateLabel { get; }
			public PXTextEdit DepositNbr { get; }
			public Label DepositNbrLabel { get; }
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
			public PXTextEdit ExternalTaxExemptionNumber { get; }
			public Label ExternalTaxExemptionNumberLabel { get; }
			public DropDown AvalaraCustomerUsageType { get; }
			public Label AvalaraCustomerUsageTypeLabel { get; }
			public TreeSelector WorkgroupID { get; }
			public Label WorkgroupIDLabel { get; }
			public Selector OwnerID { get; }
			public Label OwnerIDLabel { get; }
			public CheckBox Printed { get; }
			public Label PrintedLabel { get; }
			public CheckBox DontPrint { get; }
			public Label DontPrintLabel { get; }
			public CheckBox Emailed { get; }
			public Label EmailedLabel { get; }
			public CheckBox DontEmail { get; }
			public Label DontEmailLabel { get; }
            
            public c_currentdocument_tab(string locator, string name) : 
                    base(locator, name)
            {
                BatchNbr = new Selector("ctl00_phG_tab_t1_edBatchNbr", "Batch Nbr.", locator, null);
                BatchNbrLabel = new Label(BatchNbr);
                BatchNbr.DataField = "BatchNbr";
                BranchID = new Selector("ctl00_phG_tab_t1_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                ARAccountID = new Selector("ctl00_phG_tab_t1_edARAccountID", "AR Account", locator, null);
                ARAccountIDLabel = new Label(ARAccountID);
                ARAccountID.DataField = "ARAccountID";
                ARSubID = new Selector("ctl00_phG_tab_t1_edARSubID", "AR Sub.", locator, null);
                ARSubIDLabel = new Label(ARSubID);
                ARSubID.DataField = "ARSubID";
                OrigRefNbr = new PXTextEdit("ctl00_phG_tab_t1_edOrigRefNbr", "Original Document", locator, null);
                OrigRefNbrLabel = new Label(OrigRefNbr);
                OrigRefNbr.DataField = "OrigRefNbr";
                TermsID = new Selector("ctl00_phG_tab_t1_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                Cleared = new CheckBox("ctl00_phG_tab_t1_edCleared", "Cleared", locator, null);
                ClearedLabel = new Label(Cleared);
                Cleared.DataField = "Cleared";
                ClearDate = new DateSelector("ctl00_phG_tab_t1_edClearDate", "Clear Date", locator, null);
                ClearDateLabel = new Label(ClearDate);
                ClearDate.DataField = "ClearDate";
                DepositAsBatch = new CheckBox("ctl00_phG_tab_t1_chkDepositAsBatch", "Batch Deposit", locator, null);
                DepositAsBatchLabel = new Label(DepositAsBatch);
                DepositAsBatch.DataField = "DepositAsBatch";
                Deposited = new CheckBox("ctl00_phG_tab_t1_chkDeposited", "Deposited", locator, null);
                DepositedLabel = new Label(Deposited);
                Deposited.DataField = "Deposited";
                DepositDate = new DateSelector("ctl00_phG_tab_t1_edDepositDate", "Batch Deposit Date", locator, null);
                DepositDateLabel = new Label(DepositDate);
                DepositDate.DataField = "DepositDate";
                DepositNbr = new PXTextEdit("ctl00_phG_tab_t1_edDepositNbr", "Batch Deposit Nbr.", locator, null);
                DepositNbrLabel = new Label(DepositNbr);
                DepositNbr.DataField = "DepositNbr";
                TaxZoneID = new Selector("ctl00_phG_tab_t1_edTaxZoneID", "Customer Tax Zone", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                TaxCalcMode = new DropDown("ctl00_phG_tab_t1_exTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                ExternalTaxExemptionNumber = new PXTextEdit("ctl00_phG_tab_t1_edExternalTaxExemptionNumber", "Tax Exemption Number", locator, null);
                ExternalTaxExemptionNumberLabel = new Label(ExternalTaxExemptionNumber);
                ExternalTaxExemptionNumber.DataField = "ExternalTaxExemptionNumber";
                AvalaraCustomerUsageType = new DropDown("ctl00_phG_tab_t1_edAvalaraCustomerUsageTypeID", "Entity Usage Type", locator, null);
                AvalaraCustomerUsageTypeLabel = new Label(AvalaraCustomerUsageType);
                AvalaraCustomerUsageType.DataField = "AvalaraCustomerUsageType";
                AvalaraCustomerUsageType.Items.Add("A", "Federal Government");
                AvalaraCustomerUsageType.Items.Add("B", "State/Local Govt.");
                AvalaraCustomerUsageType.Items.Add("C", "Tribal Government");
                AvalaraCustomerUsageType.Items.Add("D", "Foreign Diplomat");
                AvalaraCustomerUsageType.Items.Add("E", "Charitable Organization");
                AvalaraCustomerUsageType.Items.Add("F", "Religious");
                AvalaraCustomerUsageType.Items.Add("G", "Resale");
                AvalaraCustomerUsageType.Items.Add("H", "Agricultural Production");
                AvalaraCustomerUsageType.Items.Add("I", "Industrial Prod/Mfg.");
                AvalaraCustomerUsageType.Items.Add("J", "Direct Pay Permit");
                AvalaraCustomerUsageType.Items.Add("K", "Direct Mail");
                AvalaraCustomerUsageType.Items.Add("L", "Other");
                AvalaraCustomerUsageType.Items.Add("M", "Education");
                AvalaraCustomerUsageType.Items.Add("N", "Local Government");
                AvalaraCustomerUsageType.Items.Add("P", "Commercial Aquaculture");
                AvalaraCustomerUsageType.Items.Add("Q", "Commercial Fishery");
                AvalaraCustomerUsageType.Items.Add("R", "Non-resident");
                AvalaraCustomerUsageType.Items.Add("0", "Default");
                WorkgroupID = new TreeSelector("ctl00_phG_tab_t1_edWorkgroupID", "Workgroup ID", locator, null);
                WorkgroupIDLabel = new Label(WorkgroupID);
                WorkgroupID.DataField = "WorkgroupID";
                OwnerID = new Selector("ctl00_phG_tab_t1_edOwnerID", "Owner ID", locator, null);
                OwnerIDLabel = new Label(OwnerID);
                OwnerID.DataField = "OwnerID";
                Printed = new CheckBox("ctl00_phG_tab_t1_chkPrinted", "Printed", locator, null);
                PrintedLabel = new Label(Printed);
                Printed.DataField = "Printed";
                DontPrint = new CheckBox("ctl00_phG_tab_t1_chkDontPrint", "Don\'t Print", locator, null);
                DontPrintLabel = new Label(DontPrint);
                DontPrint.DataField = "DontPrint";
                Emailed = new CheckBox("ctl00_phG_tab_t1_chkEmailed", "Emailed", locator, null);
                EmailedLabel = new Label(Emailed);
                Emailed.DataField = "Emailed";
                DontEmail = new CheckBox("ctl00_phG_tab_t1_chkDontEmail", "Don\'t Email", locator, null);
                DontEmailLabel = new Label(DontEmail);
                DontEmail.DataField = "DontEmail";
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_currentdocument_commission : Container
        {
            
			public Selector SalesPersonID { get; }
			public Label SalesPersonIDLabel { get; }
			public PXNumberEdit CuryCommnblAmt { get; }
			public Label CuryCommnblAmtLabel { get; }
			public PXNumberEdit CuryCommnAmt { get; }
			public Label CuryCommnAmtLabel { get; }
            
            public c_currentdocument_commission(string locator, string name) : 
                    base(locator, name)
            {
                SalesPersonID = new Selector("ctl00_phG_tab_t5_Commission_edSalesPersonID", "Default Salesperson", locator, null);
                SalesPersonIDLabel = new Label(SalesPersonID);
                SalesPersonID.DataField = "SalesPersonID";
                CuryCommnblAmt = new PXNumberEdit("ctl00_phG_tab_t5_Commission_edCuryCommnblAmt", "Total Commissionable", locator, null);
                CuryCommnblAmtLabel = new Label(CuryCommnblAmt);
                CuryCommnblAmt.DataField = "CuryCommnblAmt";
                CuryCommnAmt = new PXNumberEdit("ctl00_phG_tab_t5_Commission_edCuryCommnAmt", "Commission Amt.", locator, null);
                CuryCommnAmtLabel = new Label(CuryCommnAmt);
                CuryCommnAmt.DataField = "CuryCommnAmt";
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_transactions_grid : Grid<c_transactions_grid.c_grid_row, c_transactions_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_transactions_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grid");
                DataMemberName = "Transactions";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_grid_fe_gf", "FilterForm");
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
            
            public virtual void FormView()
            {
                ToolBar.FormView.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void ViewDeferrals()
            {
                ToolBar.ViewDeferrals.Click();
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
			public ToolBarButtonGrid FormView { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid ViewDeferrals { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    FormView = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'EditRecord\']", "Switch Between Grid and Form", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    ViewDeferrals = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdViewSchedule\']", "View Deferrals", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector BranchID { get; }
			public Selector InventoryID { get; }
			public PXTextEdit TranDesc { get; }
			public PXNumberEdit Qty { get; }
			public Selector UOM { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public CheckBox ManualPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public PXNumberEdit DiscPct { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public CheckBox ManualDisc { get; }
			public Selector AccountID { get; }
			public Selector SubID { get; }
			public Selector TaskID { get; }
			public Selector CostCodeID { get; }
			public Selector SalesPersonID { get; }
			public Selector DefScheduleID { get; }
			public Selector DeferredCode { get; }
			public DateSelector DRTermStartDate { get; }
			public DateSelector DRTermEndDate { get; }
			public Selector TaxCategoryID { get; }
			public CheckBox Commissionable { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit CuryUnitPriceDR { get; }
			public PXNumberEdit DiscPctDR { get; }
			public PXTextEdit TranType { get; }
			public PXTextEdit RefNbr { get; }
                
                public c_grid_row(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    BranchID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    InventoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    TranDesc = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Transaction Descr.", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    UOM = new Selector("_ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    CuryUnitPrice = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryUnitPrice", "Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    ManualPrice = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Price", grid.Locator, "ManualPrice");
                    ManualPrice.DataField = "ManualPrice";
                    CuryExtPrice = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryExtPrice", "Ext. Price", grid.Locator, "CuryExtPrice");
                    CuryExtPrice.DataField = "CuryExtPrice";
                    DiscPct = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edDiscPct", "Discount Percent", grid.Locator, "DiscPct");
                    DiscPct.DataField = "DiscPct";
                    CuryDiscAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryDiscAmt", "Discount Amount", grid.Locator, "CuryDiscAmt");
                    CuryDiscAmt.DataField = "CuryDiscAmt";
                    CuryTranAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryTranAmt", "Amount", grid.Locator, "CuryTranAmt");
                    CuryTranAmt.DataField = "CuryTranAmt";
                    ManualDisc = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualDisc", "Manual Discount", grid.Locator, "ManualDisc");
                    ManualDisc.DataField = "ManualDisc";
                    AccountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edAccountID", "Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    SubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubID", "Subaccount", grid.Locator, "SubID");
                    SubID.DataField = "SubID";
                    TaskID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edCostCodeIDDetails", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    SalesPersonID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSalesPersonID", "Salesperson ID", grid.Locator, "SalesPersonID");
                    SalesPersonID.DataField = "SalesPersonID";
                    DefScheduleID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDefScheduleID", "Original Deferral Schedule", grid.Locator, "DefScheduleID");
                    DefScheduleID.DataField = "DefScheduleID";
                    DeferredCode = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDeferredCode", "Deferral Code", grid.Locator, "DeferredCode");
                    DeferredCode.DataField = "DeferredCode";
                    DRTermStartDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_ed21", "Term Start Date", grid.Locator, "DRTermStartDate");
                    DRTermStartDate.DataField = "DRTermStartDate";
                    DRTermEndDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_ed22", "Term End Date", grid.Locator, "DRTermEndDate");
                    DRTermEndDate.DataField = "DRTermEndDate";
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    Commissionable = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkCommissionable", "Commissionable", grid.Locator, "Commissionable");
                    Commissionable.DataField = "Commissionable";
                    LineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    CuryUnitPriceDR = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Unit Price for DR", grid.Locator, "CuryUnitPriceDR");
                    CuryUnitPriceDR.DataField = "CuryUnitPriceDR";
                    DiscPctDR = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Discount Percent for DR", grid.Locator, "DiscPctDR");
                    DiscPctDR.DataField = "DiscPctDR";
                    TranType = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranType", "Tran. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    RefNbr = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edRefNbr", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter BranchID { get; }
				public SelectorColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public CheckBoxColumnFilter ManualPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public PXNumberEditColumnFilter DiscPct { get; }
				public PXNumberEditColumnFilter CuryDiscAmt { get; }
				public PXNumberEditColumnFilter CuryTranAmt { get; }
				public CheckBoxColumnFilter ManualDisc { get; }
				public SelectorColumnFilter AccountID { get; }
				public SelectorColumnFilter SubID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public SelectorColumnFilter SalesPersonID { get; }
				public SelectorColumnFilter DefScheduleID { get; }
				public SelectorColumnFilter DeferredCode { get; }
				public DateSelectorColumnFilter DRTermStartDate { get; }
				public DateSelectorColumnFilter DRTermEndDate { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public CheckBoxColumnFilter Commissionable { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter CuryUnitPriceDR { get; }
				public PXNumberEditColumnFilter DiscPctDR { get; }
				public PXTextEditColumnFilter TranType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
                
                public c_grid_header(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    ManualPrice = new CheckBoxColumnFilter(grid.Row.ManualPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    DiscPct = new PXNumberEditColumnFilter(grid.Row.DiscPct);
                    CuryDiscAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscAmt);
                    CuryTranAmt = new PXNumberEditColumnFilter(grid.Row.CuryTranAmt);
                    ManualDisc = new CheckBoxColumnFilter(grid.Row.ManualDisc);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    SubID = new SelectorColumnFilter(grid.Row.SubID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    SalesPersonID = new SelectorColumnFilter(grid.Row.SalesPersonID);
                    DefScheduleID = new SelectorColumnFilter(grid.Row.DefScheduleID);
                    DeferredCode = new SelectorColumnFilter(grid.Row.DeferredCode);
                    DRTermStartDate = new DateSelectorColumnFilter(grid.Row.DRTermStartDate);
                    DRTermEndDate = new DateSelectorColumnFilter(grid.Row.DRTermEndDate);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    Commissionable = new CheckBoxColumnFilter(grid.Row.Commissionable);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    CuryUnitPriceDR = new PXNumberEditColumnFilter(grid.Row.CuryUnitPriceDR);
                    DiscPctDR = new PXNumberEditColumnFilter(grid.Row.DiscPctDR);
                    TranType = new PXTextEditColumnFilter(grid.Row.TranType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                }
            }
        }
        
        public class c_transactions_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public Label CuryUnitPriceLabel { get; }
			public CheckBox ManualPrice { get; }
			public Label ManualPriceLabel { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public Label CuryExtPriceLabel { get; }
			public PXNumberEdit DiscPct { get; }
			public Label DiscPctLabel { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public Label CuryDiscAmtLabel { get; }
			public CheckBox ManualDisc { get; }
			public Label ManualDiscLabel { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public Label CuryTranAmtLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector SubID { get; }
			public Label SubIDLabel { get; }
			public Selector SalesPersonID { get; }
			public Label SalesPersonIDLabel { get; }
			public CheckBox Commissionable { get; }
			public Label CommissionableLabel { get; }
			public Selector DefScheduleID { get; }
			public Label DefScheduleIDLabel { get; }
			public Selector DeferredCode { get; }
			public Label DeferredCodeLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public PXTextEdit TranType { get; }
			public Label TranTypeLabel { get; }
			public PXTextEdit RefNbr { get; }
			public Label RefNbrLabel { get; }
			public PXNumberEdit LineNbr { get; }
			public Label LineNbrLabel { get; }
            
            public c_transactions_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                UOM = new Selector("ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                CuryUnitPrice = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryUnitPrice", "Unit Price", locator, null);
                CuryUnitPriceLabel = new Label(CuryUnitPrice);
                CuryUnitPrice.DataField = "CuryUnitPrice";
                ManualPrice = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Price", locator, null);
                ManualPriceLabel = new Label(ManualPrice);
                ManualPrice.DataField = "ManualPrice";
                CuryExtPrice = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryExtPrice", "Ext. Price", locator, null);
                CuryExtPriceLabel = new Label(CuryExtPrice);
                CuryExtPrice.DataField = "CuryExtPrice";
                DiscPct = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edDiscPct", "Discount Percent", locator, null);
                DiscPctLabel = new Label(DiscPct);
                DiscPct.DataField = "DiscPct";
                CuryDiscAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryDiscAmt", "Discount Amount", locator, null);
                CuryDiscAmtLabel = new Label(CuryDiscAmt);
                CuryDiscAmt.DataField = "CuryDiscAmt";
                ManualDisc = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkManualDisc", "Manual Discount", locator, null);
                ManualDiscLabel = new Label(ManualDisc);
                ManualDisc.DataField = "ManualDisc";
                CuryTranAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryTranAmt", "Amount", locator, null);
                CuryTranAmtLabel = new Label(CuryTranAmt);
                CuryTranAmt.DataField = "CuryTranAmt";
                BranchID = new Selector("ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                AccountID = new Selector("ctl00_phG_tab_t0_grid_lv0_edAccountID", "Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                SubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubID", "Subaccount", locator, null);
                SubIDLabel = new Label(SubID);
                SubID.DataField = "SubID";
                SalesPersonID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSalesPersonID", "Salesperson ID", locator, null);
                SalesPersonIDLabel = new Label(SalesPersonID);
                SalesPersonID.DataField = "SalesPersonID";
                Commissionable = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkCommissionable", "Commissionable", locator, null);
                CommissionableLabel = new Label(Commissionable);
                Commissionable.DataField = "Commissionable";
                DefScheduleID = new Selector("ctl00_phG_tab_t0_grid_lv0_edDefScheduleID", "Original Deferral Schedule", locator, null);
                DefScheduleIDLabel = new Label(DefScheduleID);
                DefScheduleID.DataField = "DefScheduleID";
                DeferredCode = new Selector("ctl00_phG_tab_t0_grid_lv0_edDeferredCode", "Deferral Code", locator, null);
                DeferredCodeLabel = new Label(DeferredCode);
                DeferredCode.DataField = "DeferredCode";
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                TaskID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                CostCodeID = new Selector("ctl00_phG_tab_t0_grid_lv0_edCostCodeIDDetails", "Cost Code", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                TranDesc = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Transaction Descr.", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t0_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                TranType = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edTranType", "Tran Type", locator, null);
                TranTypeLabel = new Label(TranType);
                TranType.DataField = "TranType";
                RefNbr = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edRefNbr", "Ref Nbr", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                LineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr", locator, null);
                LineNbrLabel = new Label(LineNbr);
                LineNbr.DataField = "LineNbr";
                DataMemberName = "Transactions";
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
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edInventoryID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "InventoryIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_taxes_grid1 : Grid<c_taxes_grid1.c_grid_row, c_taxes_grid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_taxes_grid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_grid1");
                DataMemberName = "Taxes";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_grid1_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_grid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector TaxID { get; }
			public PXNumberEdit TaxRate { get; }
			public PXNumberEdit CuryTaxableAmt { get; }
			public PXNumberEdit CuryExemptedAmt { get; }
			public Selector TaxUOM { get; }
			public PXNumberEdit TaxableQty { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public DropDown Tax__TaxType { get; }
			public CheckBox Tax__PendingTax { get; }
			public CheckBox Tax__ReverseTax { get; }
			public CheckBox Tax__ExemptTax { get; }
			public CheckBox Tax__StatisticalTax { get; }
			public PXTextEdit Module { get; }
			public PXTextEdit TranType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_taxes_grid1 grid) : 
                        base(grid)
                {
                    TaxID = new Selector("_ctl00_phG_tab_t3_grid1_lv0_edTaxID", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    TaxRate = new PXNumberEdit("_ctl00_phG_tab_t3_grid1_lv0_edTaxRate", "Tax Rate", grid.Locator, "TaxRate");
                    TaxRate.DataField = "TaxRate";
                    CuryTaxableAmt = new PXNumberEdit("_ctl00_phG_tab_t3_grid1_lv0_edCuryTaxableAmt", "Taxable Amount", grid.Locator, "CuryTaxableAmt");
                    CuryTaxableAmt.DataField = "CuryTaxableAmt";
                    CuryExemptedAmt = new PXNumberEdit("ctl00_phG_tab_t3_grid1_en", "Exempted Amount", grid.Locator, "CuryExemptedAmt");
                    CuryExemptedAmt.DataField = "CuryExemptedAmt";
                    TaxUOM = new Selector("_ctl00_phG_tab_t3_grid1_lv0_es", "Tax UOM", grid.Locator, "TaxUOM");
                    TaxUOM.DataField = "TaxUOM";
                    TaxableQty = new PXNumberEdit("ctl00_phG_tab_t3_grid1_en", "Taxable Qty.", grid.Locator, "TaxableQty");
                    TaxableQty.DataField = "TaxableQty";
                    CuryTaxAmt = new PXNumberEdit("_ctl00_phG_tab_t3_grid1_lv0_edCuryTaxAmt", "Tax Amount", grid.Locator, "CuryTaxAmt");
                    CuryTaxAmt.DataField = "CuryTaxAmt";
                    Tax__TaxType = new DropDown("_ctl00_phG_tab_t3_grid1_lv0_ec", "Tax Type", grid.Locator, "Tax__TaxType");
                    Tax__TaxType.DataField = "Tax__TaxType";
                    Tax__TaxType.Items.Add("S", "Sales");
                    Tax__TaxType.Items.Add("P", "Use");
                    Tax__TaxType.Items.Add("V", "VAT");
                    Tax__TaxType.Items.Add("W", "Withholding");
                    Tax__TaxType.Items.Add("Q", "Per-Unit/Specific");
                    Tax__PendingTax = new CheckBox("ctl00_phG_tab_t3_grid1", "Pending VAT", grid.Locator, "Tax__PendingTax");
                    Tax__PendingTax.DataField = "Tax__PendingTax";
                    Tax__ReverseTax = new CheckBox("ctl00_phG_tab_t3_grid1", "Reverse VAT", grid.Locator, "Tax__ReverseTax");
                    Tax__ReverseTax.DataField = "Tax__ReverseTax";
                    Tax__ExemptTax = new CheckBox("ctl00_phG_tab_t3_grid1", "Include in VAT Exempt Total", grid.Locator, "Tax__ExemptTax");
                    Tax__ExemptTax.DataField = "Tax__ExemptTax";
                    Tax__StatisticalTax = new CheckBox("ctl00_phG_tab_t3_grid1", "Statistical VAT", grid.Locator, "Tax__StatisticalTax");
                    Tax__StatisticalTax.DataField = "Tax__StatisticalTax";
                    Module = new PXTextEdit("ctl00_phG_tab_t3_grid1_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    TranType = new PXTextEdit("ctl00_phG_tab_t3_grid1_ei", "Tran. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t3_grid1_ei", "Ref. Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t3_grid1_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter TaxID { get; }
				public PXNumberEditColumnFilter TaxRate { get; }
				public PXNumberEditColumnFilter CuryTaxableAmt { get; }
				public PXNumberEditColumnFilter CuryExemptedAmt { get; }
				public SelectorColumnFilter TaxUOM { get; }
				public PXNumberEditColumnFilter TaxableQty { get; }
				public PXNumberEditColumnFilter CuryTaxAmt { get; }
				public DropDownColumnFilter Tax__TaxType { get; }
				public CheckBoxColumnFilter Tax__PendingTax { get; }
				public CheckBoxColumnFilter Tax__ReverseTax { get; }
				public CheckBoxColumnFilter Tax__ExemptTax { get; }
				public CheckBoxColumnFilter Tax__StatisticalTax { get; }
				public PXTextEditColumnFilter Module { get; }
				public PXTextEditColumnFilter TranType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_taxes_grid1 grid) : 
                        base(grid)
                {
                    TaxID = new SelectorColumnFilter(grid.Row.TaxID);
                    TaxRate = new PXNumberEditColumnFilter(grid.Row.TaxRate);
                    CuryTaxableAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxableAmt);
                    CuryExemptedAmt = new PXNumberEditColumnFilter(grid.Row.CuryExemptedAmt);
                    TaxUOM = new SelectorColumnFilter(grid.Row.TaxUOM);
                    TaxableQty = new PXNumberEditColumnFilter(grid.Row.TaxableQty);
                    CuryTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxAmt);
                    Tax__TaxType = new DropDownColumnFilter(grid.Row.Tax__TaxType);
                    Tax__PendingTax = new CheckBoxColumnFilter(grid.Row.Tax__PendingTax);
                    Tax__ReverseTax = new CheckBoxColumnFilter(grid.Row.Tax__ReverseTax);
                    Tax__ExemptTax = new CheckBoxColumnFilter(grid.Row.Tax__ExemptTax);
                    Tax__StatisticalTax = new CheckBoxColumnFilter(grid.Row.Tax__StatisticalTax);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
                    TranType = new PXTextEditColumnFilter(grid.Row.TranType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_taxes_lv0 : Container
        {
            
			public Selector TaxID { get; }
			public Label TaxIDLabel { get; }
			public PXNumberEdit TaxRate { get; }
			public Label TaxRateLabel { get; }
			public PXNumberEdit CuryTaxableAmt { get; }
			public Label CuryTaxableAmtLabel { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public Label CuryTaxAmtLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_taxes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                TaxID = new Selector("ctl00_phG_tab_t3_grid1_lv0_edTaxID", "Tax ID", locator, null);
                TaxIDLabel = new Label(TaxID);
                TaxID.DataField = "TaxID";
                TaxRate = new PXNumberEdit("ctl00_phG_tab_t3_grid1_lv0_edTaxRate", "Tax Rate", locator, null);
                TaxRateLabel = new Label(TaxRate);
                TaxRate.DataField = "TaxRate";
                CuryTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t3_grid1_lv0_edCuryTaxableAmt", "Cury Taxable Amt", locator, null);
                CuryTaxableAmtLabel = new Label(CuryTaxableAmt);
                CuryTaxableAmt.DataField = "CuryTaxableAmt";
                CuryTaxAmt = new PXNumberEdit("ctl00_phG_tab_t3_grid1_lv0_edCuryTaxAmt", "Cury Tax Amt", locator, null);
                CuryTaxAmtLabel = new Label(CuryTaxAmt);
                CuryTaxAmt.DataField = "CuryTaxAmt";
                Es = new Selector("ctl00_phG_tab_t3_grid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t3_grid1_lv0_ec", "Ec", locator, null);
                DataMemberName = "Taxes";
            }
        }
        
        public class c_billing_address_billing_address : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideAddress { get; }
			public Label OverrideAddressLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_billing_address_billing_address(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t2_Billing_Address_chkOverrideAddress", "Override Address", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t2_Billing_Address_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t2_Billing_Address_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t2_Billing_Address_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t2_Billing_Address_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t2_Billing_Address_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t2_Billing_Address_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                IsValidated = new CheckBox("ctl00_phG_tab_t2_Billing_Address_edIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "Billing_Address";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void AddressLookup1()
            {
                Buttons.AddressLookup1.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button AddressLookup1 { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_Billing_Address_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_Billing_Address");
                    AddressLookup1 = new Button("ctl00_phG_tab_t2_Shipping_Address_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_Billing_Address");
                }
            }
        }
        
        public class c_billing_contact_billing_contact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideContact { get; }
			public Label OverrideContactLabel { get; }
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public EmailEdit Email { get; }
			public Label EmailLabel { get; }
            
            public c_billing_contact_billing_contact(string locator, string name) : 
                    base(locator, name)
            {
                OverrideContact = new CheckBox("ctl00_phG_tab_t2_Billing_Contact_chkOverrideContact", "Override Contact", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t2_Billing_Contact_edFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t2_Billing_Contact_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t2_Billing_Contact_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t2_Billing_Contact_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                DataMemberName = "Billing_Contact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void AddressLookup1()
            {
                Buttons.AddressLookup1.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button AddressLookup1 { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_Billing_Address_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_Billing_Contact");
                    AddressLookup1 = new Button("ctl00_phG_tab_t2_Shipping_Address_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_Billing_Contact");
                }
            }
        }
        
        public class c_shipping_address_shipping_address : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideAddress { get; }
			public Label OverrideAddressLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public PXNumberEdit Latitude { get; }
			public Label LatitudeLabel { get; }
			public PXNumberEdit Longitude { get; }
			public Label LongitudeLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_shipping_address_shipping_address(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t2_Shipping_Address_chkOverrideAddress", "Override Address", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t2_Shipping_Address_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t2_Shipping_Address_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t2_Shipping_Address_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t2_Shipping_Address_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t2_Shipping_Address_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t2_Shipping_Address_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                Latitude = new PXNumberEdit("ctl00_phG_tab_t2_Shipping_Address_edLatitude", "Latitude", locator, null);
                LatitudeLabel = new Label(Latitude);
                Latitude.DataField = "Latitude";
                Longitude = new PXNumberEdit("ctl00_phG_tab_t2_Shipping_Address_edLongitude", "Longitude", locator, null);
                LongitudeLabel = new Label(Longitude);
                Longitude.DataField = "Longitude";
                IsValidated = new CheckBox("ctl00_phG_tab_t2_Shipping_Address_edIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "Shipping_Address";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void AddressLookup1()
            {
                Buttons.AddressLookup1.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button AddressLookup1 { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_Shipping_Address_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_Shipping_Address");
                    AddressLookup1 = new Button("ctl00_phG_tab_t2_Billing_Address_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_Shipping_Address");
                }
            }
        }
        
        public class c_shipping_contact_shipping_contact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideContact { get; }
			public Label OverrideContactLabel { get; }
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public EmailEdit Email { get; }
			public Label EmailLabel { get; }
            
            public c_shipping_contact_shipping_contact(string locator, string name) : 
                    base(locator, name)
            {
                OverrideContact = new CheckBox("ctl00_phG_tab_t2_Shipping_Contact_chkOverrideContact", "Override Contact", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t2_Shipping_Contact_edFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t2_Shipping_Contact_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t2_Shipping_Contact_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t2_Shipping_Contact_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                DataMemberName = "Shipping_Contact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void AddressLookup1()
            {
                Buttons.AddressLookup1.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button AddressLookup1 { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_Billing_Address_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_Shipping_Contact");
                    AddressLookup1 = new Button("ctl00_phG_tab_t2_Shipping_Address_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_Shipping_Contact");
                }
            }
        }
        
        public class c_salespertrans_grdsalespertrans : Grid<c_salespertrans_grdsalespertrans.c_grid_row, c_salespertrans_grdsalespertrans.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_salespertrans_grdsalespertrans(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_grdSalesPerTrans");
                DataMemberName = "salesPerTrans";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_grdSalesPerTrans_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_grdSalesPerTrans_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SalespersonID { get; }
			public PXNumberEdit CommnPct { get; }
			public PXNumberEdit CuryCommnAmt { get; }
			public PXNumberEdit CuryCommnblAmt { get; }
			public PXTextEdit AdjdDocType { get; }
			public PXTextEdit DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit AdjNbr { get; }
			public PXTextEdit AdjdRefNbr { get; }
                
                public c_grid_row(c_salespertrans_grdsalespertrans grid) : 
                        base(grid)
                {
                    SalespersonID = new Selector("_ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edSalesPersonID_1", "Salesperson ID", grid.Locator, "SalespersonID");
                    SalespersonID.DataField = "SalespersonID";
                    CommnPct = new PXNumberEdit("_ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edCommnPct", "Commission %", grid.Locator, "CommnPct");
                    CommnPct.DataField = "CommnPct";
                    CuryCommnAmt = new PXNumberEdit("_ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edCuryCommnAmt", "Commission Amt.", grid.Locator, "CuryCommnAmt");
                    CuryCommnAmt.DataField = "CuryCommnAmt";
                    CuryCommnblAmt = new PXNumberEdit("_ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edCuryCommnblAmt", "Commissionable Amount", grid.Locator, "CuryCommnblAmt");
                    CuryCommnblAmt.DataField = "CuryCommnblAmt";
                    AdjdDocType = new PXTextEdit("ctl00_phG_tab_t5_grdSalesPerTrans_ei", "AdjdDocType", grid.Locator, "AdjdDocType");
                    AdjdDocType.DataField = "AdjdDocType";
                    DocType = new PXTextEdit("ctl00_phG_tab_t5_grdSalesPerTrans_ei", "DocType", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t5_grdSalesPerTrans_ei", "RefNbr", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    AdjNbr = new PXNumberEdit("ctl00_phG_tab_t5_grdSalesPerTrans_en", "AdjNbr", grid.Locator, "AdjNbr");
                    AdjNbr.DataField = "AdjNbr";
                    AdjdRefNbr = new PXTextEdit("ctl00_phG_tab_t5_grdSalesPerTrans_em", "AdjdRefNbr", grid.Locator, "AdjdRefNbr");
                    AdjdRefNbr.DataField = "AdjdRefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SalespersonID { get; }
				public PXNumberEditColumnFilter CommnPct { get; }
				public PXNumberEditColumnFilter CuryCommnAmt { get; }
				public PXNumberEditColumnFilter CuryCommnblAmt { get; }
				public PXTextEditColumnFilter AdjdDocType { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter AdjNbr { get; }
				public PXTextEditColumnFilter AdjdRefNbr { get; }
                
                public c_grid_header(c_salespertrans_grdsalespertrans grid) : 
                        base(grid)
                {
                    SalespersonID = new SelectorColumnFilter(grid.Row.SalespersonID);
                    CommnPct = new PXNumberEditColumnFilter(grid.Row.CommnPct);
                    CuryCommnAmt = new PXNumberEditColumnFilter(grid.Row.CuryCommnAmt);
                    CuryCommnblAmt = new PXNumberEditColumnFilter(grid.Row.CuryCommnblAmt);
                    AdjdDocType = new PXTextEditColumnFilter(grid.Row.AdjdDocType);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    AdjNbr = new PXNumberEditColumnFilter(grid.Row.AdjNbr);
                    AdjdRefNbr = new PXTextEditColumnFilter(grid.Row.AdjdRefNbr);
                }
            }
        }
        
        public class c_salespertrans_lv0 : Container
        {
            
			public PXNumberEdit CommnPct { get; }
			public Label CommnPctLabel { get; }
			public PXNumberEdit CommnAmt { get; }
			public Label CommnAmtLabel { get; }
			public PXNumberEdit CuryCommnAmt { get; }
			public Label CuryCommnAmtLabel { get; }
			public PXNumberEdit CommnblAmt { get; }
			public Label CommnblAmtLabel { get; }
			public PXNumberEdit CuryCommnblAmt { get; }
			public Label CuryCommnblAmtLabel { get; }
			public Selector SalespersonID { get; }
			public Label SalespersonIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_salespertrans_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CommnPct = new PXNumberEdit("ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edCommnPct", "Commission %", locator, null);
                CommnPctLabel = new Label(CommnPct);
                CommnPct.DataField = "CommnPct";
                CommnAmt = new PXNumberEdit("ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edCommnAmt", "CommnAmt", locator, null);
                CommnAmtLabel = new Label(CommnAmt);
                CommnAmt.DataField = "CommnAmt";
                CuryCommnAmt = new PXNumberEdit("ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edCuryCommnAmt", "Commission Amt.", locator, null);
                CuryCommnAmtLabel = new Label(CuryCommnAmt);
                CuryCommnAmt.DataField = "CuryCommnAmt";
                CommnblAmt = new PXNumberEdit("ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edCommnblAmt", "CommnblAmt", locator, null);
                CommnblAmtLabel = new Label(CommnblAmt);
                CommnblAmt.DataField = "CommnblAmt";
                CuryCommnblAmt = new PXNumberEdit("ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edCuryCommnblAmt", "Commissionable Amount", locator, null);
                CuryCommnblAmtLabel = new Label(CuryCommnblAmt);
                CuryCommnblAmt.DataField = "CuryCommnblAmt";
                SalespersonID = new Selector("ctl00_phG_tab_t5_grdSalesPerTrans_lv0_edSalesPersonID_1", "Salesperson ID", locator, null);
                SalespersonIDLabel = new Label(SalespersonID);
                SalespersonID.DataField = "SalespersonID";
                Es = new Selector("ctl00_phG_tab_t5_grdSalesPerTrans_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "salesPerTrans";
            }
        }
        
        public class c_paymentcharges_detgrid3 : Grid<c_paymentcharges_detgrid3.c_grid_row, c_paymentcharges_detgrid3.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_paymentcharges_detgrid3(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_detgrid3");
                DataMemberName = "PaymentCharges";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_detgrid3_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid3_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector EntryTypeID { get; }
			public PXTextEdit TranDesc { get; }
			public Selector AccountID { get; }
			public Selector SubID { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public PXTextEdit DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_paymentcharges_detgrid3 grid) : 
                        base(grid)
                {
                    EntryTypeID = new Selector("_ctl00_phG_tab_t6_detgrid3_lv0_edEntryTypeID", "Entry Type", grid.Locator, "EntryTypeID");
                    EntryTypeID.DataField = "EntryTypeID";
                    TranDesc = new PXTextEdit("ctl00_phG_tab_t6_detgrid3_ei", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    AccountID = new Selector("_ctl00_phG_tab_t6_detgrid3_lv0_edChargeAccountID", "Offset Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    SubID = new Selector("_ctl00_phG_tab_t6_detgrid3_lv0_edChargeSubID", "Offset Subaccount", grid.Locator, "SubID");
                    SubID.DataField = "SubID";
                    CuryTranAmt = new PXNumberEdit("_ctl00_phG_tab_t6_detgrid3_lv0_edChargeCuryTranAmt", "Amount", grid.Locator, "CuryTranAmt");
                    CuryTranAmt.DataField = "CuryTranAmt";
                    DocType = new PXTextEdit("ctl00_phG_tab_t6_detgrid3_ei", "DocType", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t6_detgrid3_ei", "RefNbr", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t6_detgrid3_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter EntryTypeID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public SelectorColumnFilter AccountID { get; }
				public SelectorColumnFilter SubID { get; }
				public PXNumberEditColumnFilter CuryTranAmt { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_paymentcharges_detgrid3 grid) : 
                        base(grid)
                {
                    EntryTypeID = new SelectorColumnFilter(grid.Row.EntryTypeID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    SubID = new SelectorColumnFilter(grid.Row.SubID);
                    CuryTranAmt = new PXNumberEditColumnFilter(grid.Row.CuryTranAmt);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_paymentcharges_lv0 : Container
        {
            
			public Selector EntryTypeID { get; }
			public Label EntryTypeIDLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector SubID { get; }
			public Label SubIDLabel { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public Label CuryTranAmtLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_paymentcharges_lv0(string locator, string name) : 
                    base(locator, name)
            {
                EntryTypeID = new Selector("ctl00_phG_tab_t6_detgrid3_lv0_edEntryTypeID", "Entry Type", locator, null);
                EntryTypeIDLabel = new Label(EntryTypeID);
                EntryTypeID.DataField = "EntryTypeID";
                AccountID = new Selector("ctl00_phG_tab_t6_detgrid3_lv0_edChargeAccountID", "Offset Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                SubID = new Selector("ctl00_phG_tab_t6_detgrid3_lv0_edChargeSubID", "Offset Subaccount", locator, null);
                SubIDLabel = new Label(SubID);
                SubID.DataField = "SubID";
                CuryTranAmt = new PXNumberEdit("ctl00_phG_tab_t6_detgrid3_lv0_edChargeCuryTranAmt", "Amount", locator, null);
                CuryTranAmtLabel = new Label(CuryTranAmt);
                CuryTranAmt.DataField = "CuryTranAmt";
                Es = new Selector("ctl00_phG_tab_t6_detgrid3_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "PaymentCharges";
            }
        }
        
        public class c_voucher_voucherdetails : Container
        {
            
			public PXTextEdit VoucherBatchNbr { get; }
			public Label VoucherBatchNbrLabel { get; }
			public PXTextEdit WorkBookID { get; }
			public Label WorkBookIDLabel { get; }
            
            public c_voucher_voucherdetails(string locator, string name) : 
                    base(locator, name)
            {
                VoucherBatchNbr = new PXTextEdit("ctl00_phG_tab_t1_VoucherDetails_linkGLVoucherBatch", "Voucher Batch Nbr.", locator, null);
                VoucherBatchNbrLabel = new Label(VoucherBatchNbr);
                VoucherBatchNbr.DataField = "VoucherBatchNbr";
                WorkBookID = new PXTextEdit("ctl00_phG_tab_t1_VoucherDetails_linkGLWorkBook", "Workbook ID", locator, null);
                WorkBookIDLabel = new Label(WorkBookID);
                WorkBookID.DataField = "WorkBookID";
                DataMemberName = "Voucher";
            }
        }
        
        public class c_ccproctran_grdccproctran : Grid<c_ccproctran_grdccproctran.c_grid_row, c_ccproctran_grdccproctran.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_ccproctran_grdccproctran(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_grdCCProcTran");
                DataMemberName = "ccProcTran";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_grdCCProcTran_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdCCProcTran_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXNumberEdit TranNbr { get; }
			public PXTextEdit ProcessingCenterID { get; }
			public DropDown TranType { get; }
			public DropDown TranStatus { get; }
			public PXNumberEdit Amount { get; }
			public PXNumberEdit RefTranNbr { get; }
			public PXTextEdit PCTranNumber { get; }
			public PXTextEdit AuthNumber { get; }
			public PXTextEdit PCResponseReasonText { get; }
			public DateSelector StartTime { get; }
			public DropDown ProcStatus { get; }
			public DropDown CVVVerificationStatus { get; }
                
                public c_grid_row(c_ccproctran_grdccproctran grid) : 
                        base(grid)
                {
                    TranNbr = new PXNumberEdit("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edTranNbr", "Tran. Nbr.", grid.Locator, "TranNbr");
                    TranNbr.DataField = "TranNbr";
                    ProcessingCenterID = new PXTextEdit("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edProcessingCenterID", "Proc. Center", grid.Locator, "ProcessingCenterID");
                    ProcessingCenterID.DataField = "ProcessingCenterID";
                    TranType = new DropDown("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edCCTranType", "Tran. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    TranType.Items.Add("AUT", "Authorize Only");
                    TranType.Items.Add("AAC", "Authorize and Capture");
                    TranType.Items.Add("PAC", "Capture Authorized");
                    TranType.Items.Add("CAP", "Capture Manualy Authorized");
                    TranType.Items.Add("VDG", "Void");
                    TranType.Items.Add("CDT", "Refund");
                    TranType.Items.Add("UKN", "Unknown");
                    TranStatus = new DropDown("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edTranStatus", "Tran. Status", grid.Locator, "TranStatus");
                    TranStatus.DataField = "TranStatus";
                    TranStatus.Items.Add("APR", "Approved");
                    TranStatus.Items.Add("DEC", "Declined");
                    TranStatus.Items.Add("ERR", "Error");
                    TranStatus.Items.Add("HFR", "Held for Review");
                    TranStatus.Items.Add("EXP", "Expired");
                    TranStatus.Items.Add("UKN", "Unknown");
                    Amount = new PXNumberEdit("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edAmount", "Tran. Amount", grid.Locator, "Amount");
                    Amount.DataField = "Amount";
                    RefTranNbr = new PXNumberEdit("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edRefTranNbr", "Referenced Tran. Nbr.", grid.Locator, "RefTranNbr");
                    RefTranNbr.DataField = "RefTranNbr";
                    PCTranNumber = new PXTextEdit("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edPCTranNumber", "Proc. Center Tran. Nbr.", grid.Locator, "PCTranNumber");
                    PCTranNumber.DataField = "PCTranNumber";
                    AuthNumber = new PXTextEdit("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edAuthNumber", "Proc. Center Auth. Nbr.", grid.Locator, "AuthNumber");
                    AuthNumber.DataField = "AuthNumber";
                    PCResponseReasonText = new PXTextEdit("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edPCResponseReasonText", "Proc. Center Response Reason", grid.Locator, "PCResponseReasonText");
                    PCResponseReasonText.DataField = "PCResponseReasonText";
                    StartTime = new DateSelector("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edStartTime", "Tran. Time", grid.Locator, "StartTime");
                    StartTime.DataField = "StartTime";
                    ProcStatus = new DropDown("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edProcStatus", "Proc. Status", grid.Locator, "ProcStatus");
                    ProcStatus.DataField = "ProcStatus";
                    ProcStatus.Items.Add("OPN", "Open");
                    ProcStatus.Items.Add("FIN", "Completed");
                    ProcStatus.Items.Add("ERR", "Error");
                    CVVVerificationStatus = new DropDown("_ctl00_phG_tab_t7_grdCCProcTran_lv0_edCVVVerificationStatus", "CVV Verification", grid.Locator, "CVVVerificationStatus");
                    CVVVerificationStatus.DataField = "CVVVerificationStatus";
                    CVVVerificationStatus.Items.Add("MTH", "Matched");
                    CVVVerificationStatus.Items.Add("NMH", "Not Matched");
                    CVVVerificationStatus.Items.Add("NOV", "Required but Not Verified");
                    CVVVerificationStatus.Items.Add("SBP", "Required but Not Provided");
                    CVVVerificationStatus.Items.Add("INV", "Not Verified Due to Issuer");
                    CVVVerificationStatus.Items.Add("RPV", "Skipped Due to Prior Verification");
                    CVVVerificationStatus.Items.Add("EMP", "Processing center response is empty");
                    CVVVerificationStatus.Items.Add("UKN", "Unknown");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXNumberEditColumnFilter TranNbr { get; }
				public PXTextEditColumnFilter ProcessingCenterID { get; }
				public DropDownColumnFilter TranType { get; }
				public DropDownColumnFilter TranStatus { get; }
				public PXNumberEditColumnFilter Amount { get; }
				public PXNumberEditColumnFilter RefTranNbr { get; }
				public PXTextEditColumnFilter PCTranNumber { get; }
				public PXTextEditColumnFilter AuthNumber { get; }
				public PXTextEditColumnFilter PCResponseReasonText { get; }
				public DateSelectorColumnFilter StartTime { get; }
				public DropDownColumnFilter ProcStatus { get; }
				public DropDownColumnFilter CVVVerificationStatus { get; }
                
                public c_grid_header(c_ccproctran_grdccproctran grid) : 
                        base(grid)
                {
                    TranNbr = new PXNumberEditColumnFilter(grid.Row.TranNbr);
                    ProcessingCenterID = new PXTextEditColumnFilter(grid.Row.ProcessingCenterID);
                    TranType = new DropDownColumnFilter(grid.Row.TranType);
                    TranStatus = new DropDownColumnFilter(grid.Row.TranStatus);
                    Amount = new PXNumberEditColumnFilter(grid.Row.Amount);
                    RefTranNbr = new PXNumberEditColumnFilter(grid.Row.RefTranNbr);
                    PCTranNumber = new PXTextEditColumnFilter(grid.Row.PCTranNumber);
                    AuthNumber = new PXTextEditColumnFilter(grid.Row.AuthNumber);
                    PCResponseReasonText = new PXTextEditColumnFilter(grid.Row.PCResponseReasonText);
                    StartTime = new DateSelectorColumnFilter(grid.Row.StartTime);
                    ProcStatus = new DropDownColumnFilter(grid.Row.ProcStatus);
                    CVVVerificationStatus = new DropDownColumnFilter(grid.Row.CVVVerificationStatus);
                }
            }
        }
        
        public class c_ccproctran_lv0 : Container
        {
            
			public PXNumberEdit TranNbr { get; }
			public Label TranNbrLabel { get; }
			public DropDown ProcStatus { get; }
			public Label ProcStatusLabel { get; }
			public PXTextEdit ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
			public DropDown CVVVerificationStatus { get; }
			public Label CVVVerificationStatusLabel { get; }
			public DropDown TranType { get; }
			public Label TranTypeLabel { get; }
			public DropDown TranStatus { get; }
			public Label TranStatusLabel { get; }
			public PXNumberEdit Amount { get; }
			public Label AmountLabel { get; }
			public PXNumberEdit RefTranNbr { get; }
			public Label RefTranNbrLabel { get; }
			public PXTextEdit PCTranNumber { get; }
			public Label PCTranNumberLabel { get; }
			public PXTextEdit AuthNumber { get; }
			public Label AuthNumberLabel { get; }
			public PXTextEdit PCResponseReasonText { get; }
			public Label PCResponseReasonTextLabel { get; }
			public DateSelector StartTime { get; }
			public Label StartTimeLabel { get; }
            
            public c_ccproctran_lv0(string locator, string name) : 
                    base(locator, name)
            {
                TranNbr = new PXNumberEdit("ctl00_phG_tab_t7_grdCCProcTran_lv0_edTranNbr", "Tran. Nbr.", locator, null);
                TranNbrLabel = new Label(TranNbr);
                TranNbr.DataField = "TranNbr";
                ProcStatus = new DropDown("ctl00_phG_tab_t7_grdCCProcTran_lv0_edProcStatus", "Proc. Status", locator, null);
                ProcStatusLabel = new Label(ProcStatus);
                ProcStatus.DataField = "ProcStatus";
                ProcStatus.Items.Add("OPN", "Open");
                ProcStatus.Items.Add("FIN", "Completed");
                ProcStatus.Items.Add("ERR", "Error");
                ProcessingCenterID = new PXTextEdit("ctl00_phG_tab_t7_grdCCProcTran_lv0_edProcessingCenterID", "Proc. Center", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                CVVVerificationStatus = new DropDown("ctl00_phG_tab_t7_grdCCProcTran_lv0_edCVVVerificationStatus", "CVV Verification", locator, null);
                CVVVerificationStatusLabel = new Label(CVVVerificationStatus);
                CVVVerificationStatus.DataField = "CVVVerificationStatus";
                CVVVerificationStatus.Items.Add("MTH", "Matched");
                CVVVerificationStatus.Items.Add("NMH", "Not Matched");
                CVVVerificationStatus.Items.Add("NOV", "Required but Not Verified");
                CVVVerificationStatus.Items.Add("SBP", "Required but Not Provided");
                CVVVerificationStatus.Items.Add("INV", "Not Verified Due to Issuer");
                CVVVerificationStatus.Items.Add("RPV", "Skipped Due to Prior Verification");
                CVVVerificationStatus.Items.Add("EMP", "Processing center response is empty");
                CVVVerificationStatus.Items.Add("UKN", "Unknown");
                TranType = new DropDown("ctl00_phG_tab_t7_grdCCProcTran_lv0_edCCTranType", "Tran. Type", locator, null);
                TranTypeLabel = new Label(TranType);
                TranType.DataField = "TranType";
                TranType.Items.Add("AUT", "Authorize Only");
                TranType.Items.Add("AAC", "Authorize and Capture");
                TranType.Items.Add("PAC", "Capture Authorized");
                TranType.Items.Add("CAP", "Capture Manualy Authorized");
                TranType.Items.Add("VDG", "Void");
                TranType.Items.Add("CDT", "Refund");
                TranType.Items.Add("UKN", "Unknown");
                TranStatus = new DropDown("ctl00_phG_tab_t7_grdCCProcTran_lv0_edTranStatus", "Tran. Status", locator, null);
                TranStatusLabel = new Label(TranStatus);
                TranStatus.DataField = "TranStatus";
                TranStatus.Items.Add("APR", "Approved");
                TranStatus.Items.Add("DEC", "Declined");
                TranStatus.Items.Add("ERR", "Error");
                TranStatus.Items.Add("HFR", "Held for Review");
                TranStatus.Items.Add("EXP", "Expired");
                TranStatus.Items.Add("UKN", "Unknown");
                Amount = new PXNumberEdit("ctl00_phG_tab_t7_grdCCProcTran_lv0_edAmount", "Tran. Amount", locator, null);
                AmountLabel = new Label(Amount);
                Amount.DataField = "Amount";
                RefTranNbr = new PXNumberEdit("ctl00_phG_tab_t7_grdCCProcTran_lv0_edRefTranNbr", "Referenced Tran. Nbr.", locator, null);
                RefTranNbrLabel = new Label(RefTranNbr);
                RefTranNbr.DataField = "RefTranNbr";
                PCTranNumber = new PXTextEdit("ctl00_phG_tab_t7_grdCCProcTran_lv0_edPCTranNumber", "Proc. Center Tran. Nbr.", locator, null);
                PCTranNumberLabel = new Label(PCTranNumber);
                PCTranNumber.DataField = "PCTranNumber";
                AuthNumber = new PXTextEdit("ctl00_phG_tab_t7_grdCCProcTran_lv0_edAuthNumber", "Proc. Center Auth. Nbr.", locator, null);
                AuthNumberLabel = new Label(AuthNumber);
                AuthNumber.DataField = "AuthNumber";
                PCResponseReasonText = new PXTextEdit("ctl00_phG_tab_t7_grdCCProcTran_lv0_edPCResponseReasonText", "Proc. Center Response Reason", locator, null);
                PCResponseReasonTextLabel = new Label(PCResponseReasonText);
                PCResponseReasonText.DataField = "PCResponseReasonText";
                StartTime = new DateSelector("ctl00_phG_tab_t7_grdCCProcTran_lv0_edStartTime", "Tran. Time", locator, null);
                StartTimeLabel = new Label(StartTime);
                StartTime.DataField = "StartTime";
                DataMemberName = "ccProcTran";
            }
        }
        
        public class c_approval_gridapproval : Grid<c_approval_gridapproval.c_grid_row, c_approval_gridapproval.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_approval_gridapproval(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_gridApproval");
                DataMemberName = "Approval";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_gridApproval_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridApproval_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit ApproverEmployee__AcctCD { get; }
			public PXTextEdit ApproverEmployee__AcctName { get; }
			public Selector WorkgroupID { get; }
			public PXTextEdit ApprovedByEmployee__AcctCD { get; }
			public PXTextEdit ApprovedByEmployee__AcctName { get; }
			public DateSelector ApproveDate { get; }
			public DropDown Status { get; }
			public PXTextEdit Reason { get; }
			public Selector AssignmentMapID { get; }
			public Selector RuleID { get; }
			public Selector StepID { get; }
			public DateSelector CreatedDateTime { get; }
			public PXNumberEdit ApprovalID { get; }
                
                public c_grid_row(c_approval_gridapproval grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    ApproverEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Assignee ID", grid.Locator, "ApproverEmployee__AcctCD");
                    ApproverEmployee__AcctCD.DataField = "ApproverEmployee__AcctCD";
                    ApproverEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Assigned To", grid.Locator, "ApproverEmployee__AcctName");
                    ApproverEmployee__AcctName.DataField = "ApproverEmployee__AcctName";
                    WorkgroupID = new Selector("_ctl00_phG_tab_t4_gridApproval_lv0_es", "Workgroup", grid.Locator, "WorkgroupID");
                    WorkgroupID.DataField = "WorkgroupID";
                    ApprovedByEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Approved by (ID)", grid.Locator, "ApprovedByEmployee__AcctCD");
                    ApprovedByEmployee__AcctCD.DataField = "ApprovedByEmployee__AcctCD";
                    ApprovedByEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Approved By", grid.Locator, "ApprovedByEmployee__AcctName");
                    ApprovedByEmployee__AcctName.DataField = "ApprovedByEmployee__AcctName";
                    ApproveDate = new DateSelector("_ctl00_phG_tab_t4_gridApproval_lv0_ed7", "Approval Date", grid.Locator, "ApproveDate");
                    ApproveDate.DataField = "ApproveDate";
                    Status = new DropDown("_ctl00_phG_tab_t4_gridApproval_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("P", "Pending");
                    Status.Items.Add("A", "Approved");
                    Status.Items.Add("R", "Rejected");
                    Reason = new PXTextEdit("ctl00_phG_tab_t4_gridApproval_ei", "Reason", grid.Locator, "Reason");
                    Reason.DataField = "Reason";
                    AssignmentMapID = new Selector("_ctl00_phG_tab_t4_gridApproval_lv0_es", "Approval Map", grid.Locator, "AssignmentMapID");
                    AssignmentMapID.DataField = "AssignmentMapID";
                    RuleID = new Selector("_ctl00_phG_tab_t4_gridApproval_lv0_es", "Map Rule", grid.Locator, "RuleID");
                    RuleID.DataField = "RuleID";
                    StepID = new Selector("_ctl00_phG_tab_t4_gridApproval_lv0_es", "Map Step", grid.Locator, "StepID");
                    StepID.DataField = "StepID";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t4_gridApproval_lv0_ed13", "Assignment Date", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    ApprovalID = new PXNumberEdit("ctl00_phG_tab_t4_gridApproval_en", "ApprovalID", grid.Locator, "ApprovalID");
                    ApprovalID.DataField = "ApprovalID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter ApproverEmployee__AcctCD { get; }
				public PXTextEditColumnFilter ApproverEmployee__AcctName { get; }
				public SelectorColumnFilter WorkgroupID { get; }
				public PXTextEditColumnFilter ApprovedByEmployee__AcctCD { get; }
				public PXTextEditColumnFilter ApprovedByEmployee__AcctName { get; }
				public DateSelectorColumnFilter ApproveDate { get; }
				public DropDownColumnFilter Status { get; }
				public PXTextEditColumnFilter Reason { get; }
				public SelectorColumnFilter AssignmentMapID { get; }
				public SelectorColumnFilter RuleID { get; }
				public SelectorColumnFilter StepID { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public PXNumberEditColumnFilter ApprovalID { get; }
                
                public c_grid_header(c_approval_gridapproval grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    ApproverEmployee__AcctCD = new PXTextEditColumnFilter(grid.Row.ApproverEmployee__AcctCD);
                    ApproverEmployee__AcctName = new PXTextEditColumnFilter(grid.Row.ApproverEmployee__AcctName);
                    WorkgroupID = new SelectorColumnFilter(grid.Row.WorkgroupID);
                    ApprovedByEmployee__AcctCD = new PXTextEditColumnFilter(grid.Row.ApprovedByEmployee__AcctCD);
                    ApprovedByEmployee__AcctName = new PXTextEditColumnFilter(grid.Row.ApprovedByEmployee__AcctName);
                    ApproveDate = new DateSelectorColumnFilter(grid.Row.ApproveDate);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    Reason = new PXTextEditColumnFilter(grid.Row.Reason);
                    AssignmentMapID = new SelectorColumnFilter(grid.Row.AssignmentMapID);
                    RuleID = new SelectorColumnFilter(grid.Row.RuleID);
                    StepID = new SelectorColumnFilter(grid.Row.StepID);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    ApprovalID = new PXNumberEditColumnFilter(grid.Row.ApprovalID);
                }
            }
        }
        
        public class c_approval_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_approval_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t4_gridApproval_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t4_gridApproval_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t4_gridApproval_lv0_ec", "Ec", locator, null);
                DataMemberName = "Approval";
            }
        }
        
        public class c_addresslookupfilter_addresslookuppanelformaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit SearchAddress { get; }
			public Label SearchAddressLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit AddressLine3 { get; }
			public Label AddressLine3Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public PXTextEdit CountryID { get; }
			public Label CountryIDLabel { get; }
			public PXTextEdit State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public PXTextEdit Latitude { get; }
			public Label LatitudeLabel { get; }
			public PXTextEdit Longitude { get; }
			public Label LongitudeLabel { get; }
            
            public c_addresslookupfilter_addresslookuppanelformaddress(string locator, string name) : 
                    base(locator, name)
            {
                SearchAddress = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_searchBox", "Search Address", locator, null);
                SearchAddressLabel = new Label(SearchAddress);
                SearchAddress.DataField = "SearchAddress";
                ViewName = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_addressLookupViewName", "ViewName", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                AddressLine1 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine1", "AddressLine1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine2", "AddressLine2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                AddressLine3 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine3", "AddressLine3", locator, null);
                AddressLine3Label = new Label(AddressLine3);
                AddressLine3.DataField = "AddressLine3";
                City = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseCountry", "CountryID", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponsePostalCo" +
                        "de", "PostalCode", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                Latitude = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseLatitude" +
                        "", "Latitude", locator, null);
                LatitudeLabel = new Label(Latitude);
                Latitude.DataField = "Latitude";
                Longitude = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseLongitud" +
                        "e", "Longitude", locator, null);
                LongitudeLabel = new Label(Longitude);
                Longitude.DataField = "Longitude";
                DataMemberName = "AddressLookupFilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Select()
            {
                Buttons.Select.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Select { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Select = new Button("ctl00_phG_AddressLookupPanel_AddressLookupSelectAction", "Select", "ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress");
                    Cancel = new Button("ctl00_phG_AddressLookupPanel_AddressEntityBtnCancel", "Cancel", "ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress");
                }
            }
        }
        
        public class c_reasonapproverejectparams_pxformviewpanelreason : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Reason { get; }
			public Label ReasonLabel { get; }
            
            public c_reasonapproverejectparams_pxformviewpanelreason(string locator, string name) : 
                    base(locator, name)
            {
                Reason = new PXTextEdit("ctl00_phG_panelReason_PXFormViewPanelReason_edReason", "Reason", locator, null);
                ReasonLabel = new Label(Reason);
                Reason.DataField = "Reason";
                DataMemberName = "ReasonApproveRejectParams";
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
                    Ok = new Button("ctl00_phG_panelReason_PXFormViewPanelReason_btnReasonOk", "OK", "ctl00_phG_panelReason_PXFormViewPanelReason");
                    Cancel = new Button("ctl00_phG_panelReason_PXFormViewPanelReason_btnReasonCancel", "Cancel", "ctl00_phG_panelReason_PXFormViewPanelReason");
                }
            }
        }
        
        public class c_workflowview_workflowfictivediagram : Container
        {
            
            public PxButtonCollection Buttons;
            
			public UnknownControl Layout { get; }
			public Label LayoutLabel { get; }
            
            public c_workflowview_workflowfictivediagram(string locator, string name) : 
                    base(locator, name)
            {
                Layout = new UnknownControl("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram_diagram", "Layout", locator, null);
                LayoutLabel = new Label(Layout);
                Layout.DataField = "Layout";
                DataMemberName = "WorkflowView";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Customize { get; }
                
                public PxButtonCollection()
                {
                    Customize = new Button("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_PXButtonCustomize", "Customize", "ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram");
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
        
        public class c_attributes : Container
        {
            
            public c_attributes(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = null;
            }
        }
    }
}
