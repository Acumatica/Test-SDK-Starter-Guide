using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.CheckBoxButton;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.QuickSearch;
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
using Controls.UnknownControl;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.ISVTEST
{
    
    
    public class AP301000_APInvoiceEntry : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
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
        protected c_currencyinfo_rf Currencyinfo_rf { get; } = new c_currencyinfo_rf("ctl00_phF_form_t0_edCury_pnlRate_rf", "currencyinfo_rf");
        protected c_currentdocument_form2 CurrentDocument_form2 { get; } = new c_currentdocument_form2("ctl00_phG_tab_t1_form2", "CurrentDocument_form2");
        protected c_currentdocument_formretainage CurrentDocument_formRetainage { get; } = new c_currentdocument_formretainage("ctl00_phG_tab_t5_formRetainage", "CurrentDocument_formRetainage");
        protected c_currentdocument_frmvendor CurrentDocument_frmVendor { get; } = new c_currentdocument_frmvendor("ctl00_phG_PanelPayBillJC_frmVendor", "CurrentDocument_frmVendor");
        protected c_transactions_grid Transactions_grid { get; } = new c_transactions_grid("ctl00_phG_tab_t0_grid", "Transactions_grid");
        protected c_transactions_lv0 Transactions_lv0 { get; } = new c_transactions_lv0("ctl00_phG_tab_t0_grid_lv0", "Transactions_lv0");
        protected c_taxes_grid1 Taxes_grid1 { get; } = new c_taxes_grid1("ctl00_phG_tab_t2_grid1", "Taxes_grid1");
        protected c_taxes_lv0 Taxes_lv0 { get; } = new c_taxes_lv0("ctl00_phG_tab_t2_grid1_lv0", "Taxes_lv0");
        protected c_adjustments_detgrid Adjustments_detgrid { get; } = new c_adjustments_detgrid("ctl00_phG_tab_t6_detgrid", "Adjustments_detgrid");
        protected c_adjustments_lv0 Adjustments_lv0 { get; } = new c_adjustments_lv0("ctl00_phG_tab_t6_detgrid_lv0", "Adjustments_lv0");
        protected c_discountdetails_formdiscountdetail DiscountDetails_formDiscountDetail { get; } = new c_discountdetails_formdiscountdetail("ctl00_phG_tab_t4_formDiscountDetail", "DiscountDetails_formDiscountDetail");
        protected c_discountdetails_lv0 DiscountDetails_lv0 { get; } = new c_discountdetails_lv0("ctl00_phG_tab_t4_formDiscountDetail_lv0", "DiscountDetails_lv0");
        protected c_recalcdiscountsfilter_formrecalcdiscounts Recalcdiscountsfilter_formrecalcdiscounts { get; } = new c_recalcdiscountsfilter_formrecalcdiscounts("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts", "recalcdiscountsfilter_formRecalcDiscounts");
        protected c_duplicatefilter_formcopyto Duplicatefilter_formcopyto { get; } = new c_duplicatefilter_formcopyto("ctl00_phG_panelDuplicate_formCopyTo", "duplicatefilter_formCopyTo");
        protected c_voucher_voucherdetails Voucher_VoucherDetails { get; } = new c_voucher_voucherdetails("ctl00_phG_tab_t1_form2_VoucherDetails", "Voucher_VoucherDetails");
        protected c_approval_gridapproval Approval_gridApproval { get; } = new c_approval_gridapproval("ctl00_phG_tab_t3_gridApproval", "Approval_gridApproval");
        protected c_approval_lv0 Approval_lv0 { get; } = new c_approval_lv0("ctl00_phG_tab_t3_gridApproval_lv0", "Approval_lv0");
        protected c_releaseretainageoptions_frmretainageoptions ReleaseRetainageOptions_frmRetainageOptions { get; } = new c_releaseretainageoptions_frmretainageoptions("ctl00_phG_spRetainageOptions_frmRetainageOptions", "ReleaseRetainageOptions_frmRetainageOptions");
        protected c_linklinelandedcostdetail_linklinelandedcostgrid LinkLineLandedCostDetail_LinkLineLandedCostGrid { get; } = new c_linklinelandedcostdetail_linklinelandedcostgrid("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid", "LinkLineLandedCostDetail_LinkLineLandedCostGrid");
        protected c_linklinelandedcostdetail_lv0 LinkLineLandedCostDetail_lv0 { get; } = new c_linklinelandedcostdetail_lv0("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_lv0", "LinkLineLandedCostDetail_lv0");
        protected c_landedcostdetailsadd_grdlc LandedCostDetailsAdd_grdLC { get; } = new c_landedcostdetailsadd_grdlc("ctl00_phG_PanelAddLandedCost_grdLC", "LandedCostDetailsAdd_grdLC");
        protected c_landedcostdetailsadd_lv0 LandedCostDetailsAdd_lv0 { get; } = new c_landedcostdetailsadd_lv0("ctl00_phG_PanelAddLandedCost_grdLC_lv0", "LandedCostDetailsAdd_lv0");
        protected c_linklineordertran_linklineordergrid Linklineordertran_linklineordergrid { get; } = new c_linklineordertran_linklineordergrid("ctl00_phG_PanelLinkLine_LinkLineOrderGrid", "linkLineOrderTran_LinkLineOrderGrid");
        protected c_linklineordertran_lv0 Linklineordertran_lv0 { get; } = new c_linklineordertran_lv0("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0", "linkLineOrderTran_lv0");
        protected c_linklinereceipttran_linklinegrid Linklinereceipttran_linklinegrid { get; } = new c_linklinereceipttran_linklinegrid("ctl00_phG_PanelLinkLine_LinkLineGrid", "linkLineReceiptTran_LinkLineGrid");
        protected c_linklinereceipttran_lv0 Linklinereceipttran_lv0 { get; } = new c_linklinereceipttran_lv0("ctl00_phG_PanelLinkLine_LinkLineGrid_lv0", "linkLineReceiptTran_lv0");
        protected c_linklinefilter_linklinefilterform Linklinefilter_linklinefilterform { get; } = new c_linklinefilter_linklinefilterform("ctl00_phG_PanelLinkLine_LinkLineFilterForm", "linkLineFilter_LinkLineFilterForm");
        protected c_filter_frmporderfilter Filter_frmporderfilter { get; } = new c_filter_frmporderfilter("ctl00_phG_PanelAddPOReceipt_frmPOrderFilter", "filter_frmPOrderFilter");
        protected c_filter_frmpofilter Filter_frmpofilter { get; } = new c_filter_frmpofilter("ctl00_phG_PanelAddPOReceiptLine_frmPOFilter", "filter_frmPOFilter");
        protected c_poorderlineslist_poorderlinesgrid Poorderlineslist_poorderlinesgrid { get; } = new c_poorderlineslist_poorderlinesgrid("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid", "poorderlineslist_POOrderLinesGrid");
        protected c_poorderlineslist_lv0 Poorderlineslist_lv0 { get; } = new c_poorderlineslist_lv0("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0", "poorderlineslist_lv0");
        protected c_subcontractlines_subcontractlinesgrid SubcontractLines_SubcontractLinesGrid { get; } = new c_subcontractlines_subcontractlinesgrid("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid", "SubcontractLines_SubcontractLinesGrid");
        protected c_orderfilter_pxformview1 Orderfilter_pxformview1 { get; } = new c_orderfilter_pxformview1("ctl00_phG_PanelAddPOOrderLine_PXFormView1", "orderfilter_PXFormView1");
        protected c_orderfilter_pxaddsubcontractlineformview Orderfilter_pxaddsubcontractlineformview { get; } = new c_orderfilter_pxaddsubcontractlineformview("ctl00_phG_PanelAddSubcontractLine_PXAddSubcontractLineFormView", "orderfilter_PXAddSubcontractLineFormView");
        protected c_poreceiptslist_grid4 Poreceiptslist_grid4 { get; } = new c_poreceiptslist_grid4("ctl00_phG_PanelAddPOReceipt_grid4", "poreceiptslist_grid4");
        protected c_poreceiptslist_lv0 Poreceiptslist_lv0 { get; } = new c_poreceiptslist_lv0("ctl00_phG_PanelAddPOReceipt_grid4_lv0", "poreceiptslist_lv0");
        protected c_poreceiptlinesselection_gridol Poreceiptlinesselection_gridol { get; } = new c_poreceiptlinesselection_gridol("ctl00_phG_PanelAddPOReceiptLine_gridOL", "poReceiptLinesSelection_gridOL");
        protected c_poreceiptlinesselection_lv0 Poreceiptlinesselection_lv0 { get; } = new c_poreceiptlinesselection_lv0("ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0", "poReceiptLinesSelection_lv0");
        protected c_landedcostfilter_frmlcfilter Landedcostfilter_frmlcfilter { get; } = new c_landedcostfilter_frmlcfilter("ctl00_phG_PanelAddLandedCost_frmLCFilter", "landedCostFilter_frmLCFilter");
        protected c_reasonapproverejectparams_pxformviewpanelreason ReasonApproveRejectParams_PXFormViewPanelReason { get; } = new c_reasonapproverejectparams_pxformviewpanelreason("ctl00_phG_panelReason_PXFormViewPanelReason", "ReasonApproveRejectParams_PXFormViewPanelReason");
        protected c_retainagedocuments_detgrid RetainageDocuments_detgrid { get; } = new c_retainagedocuments_detgrid("ctl00_phG_tab_t5_detgrid", "RetainageDocuments_detgrid");
        protected c_retainagedocuments_lv0 RetainageDocuments_lv0 { get; } = new c_retainagedocuments_lv0("ctl00_phG_tab_t5_detgrid_lv0", "RetainageDocuments_lv0");
        protected c_poorderslist_pxgrid1 Poorderslist_pxgrid1 { get; } = new c_poorderslist_pxgrid1("ctl00_phG_PanelAddPOOrder_PXGrid1", "poorderslist_PXGrid1");
        protected c_poorderslist_lv0 Poorderslist_lv0 { get; } = new c_poorderslist_lv0("ctl00_phG_PanelAddPOOrder_PXGrid1_lv0", "poorderslist_lv0");
        protected c_subcontracts_pxgridsubcontract Subcontracts_pxgridsubcontract { get; } = new c_subcontracts_pxgridsubcontract("ctl00_phG_PanelAddSubcontract_PXGridSubcontract", "subcontracts_PXGridSubcontract");
        protected c_jointpayeepayments_pxgridjointcheck JointPayeePayments_PXGridJointCheck { get; } = new c_jointpayeepayments_pxgridjointcheck("ctl00_phG_PanelPayBillJC_PXGridJointCheck", "JointPayeePayments_PXGridJointCheck");
        protected c_jointpayeepayments_lv0 JointPayeePayments_lv0 { get; } = new c_jointpayeepayments_lv0("ctl00_phG_PanelPayBillJC_PXGridJointCheck_lv0", "JointPayeePayments_lv0");
        protected c_workflowview_workflowfictivediagram WorkflowView_WorkflowFictiveDiagram { get; } = new c_workflowview_workflowfictivediagram("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram", "WorkflowView_WorkflowFictiveDiagram");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_transactions_importcsvsettings_frmimportcsvsettings Transactions_ImportCSVSettings_frmImportCSVSettings { get; } = new c_transactions_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings", "Transactions$ImportCSVSettings_frmImportCSVSettings");
        protected c_transactions_importxlsxsettings_frmimportxlsxsettings Transactions_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_transactions_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "Transactions$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_transactions_importcolumns_grdimportcolumn Transactions_ImportColumns_grdImportColumn { get; } = new c_transactions_importcolumns_grdimportcolumn("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn", "Transactions$ImportColumns_grdImportColumn");
        protected c_transactions_importcolumns_lv0 Transactions_ImportColumns_lv0 { get; } = new c_transactions_importcolumns_lv0("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0", "Transactions$ImportColumns_lv0");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public AP301000_APInvoiceEntry()
        {
            ScreenId = "AP301000";
            ScreenUrl = "/Pages/AP/AP301000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AP301000_APInvoiceEntry ReadOne(Gate gate, string DocType, string RefNbr)
        {
            new BiObject<AP301000_APInvoiceEntry>(gate).ReadOne(this, DocType, RefNbr);
            return this;
        }
        
        public virtual AP301000_APInvoiceEntry ReadOne(string DocType, string RefNbr)
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
        
        public virtual void Prebook()
        {
            ToolBar.Prebook.Click();
        }
        
        public virtual void Prebook(bool status, string message = null)
        {
            ToolBar.Prebook.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Prebook.Click();
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
        
        public virtual void PayInvoice()
        {
            ToolBar.PayInvoice.Click();
        }
        
        public virtual void ReleaseRetainage()
        {
            ToolBar.ReleaseRetainage.Click();
        }
        
        public virtual void ReleaseRetainage(bool status, string message = null)
        {
            ToolBar.ReleaseRetainage.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ReleaseRetainage.Click();
        }
        
        public virtual void Reclassify()
        {
            ToolBar.Reclassify.Click();
        }
        
        public virtual void VendorRefund()
        {
            ToolBar.VendorRefund.Click();
        }
        
        public virtual void ReverseInvoice()
        {
            ToolBar.ReverseInvoice.Click();
        }
        
        public virtual void VoidInvoice()
        {
            ToolBar.VoidInvoice.Click();
        }
        
        public virtual void VoidInvoice(bool status, string message = null)
        {
            ToolBar.VoidInvoice.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.VoidInvoice.Click();
        }
        
        public virtual void ReclassifyBatch()
        {
            ToolBar.ReclassifyBatch.Click();
        }
        
        public virtual void VoidDocument()
        {
            ToolBar.VoidDocument.Click();
        }
        
        public virtual void CreateSchedule()
        {
            ToolBar.CreateSchedule.Click();
        }
        
        public virtual void CreateSchedule(bool status, string message = null)
        {
            ToolBar.CreateSchedule.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CreateSchedule.Click();
        }
        
        public virtual void RecalculateDiscountsAction()
        {
            ToolBar.RecalculateDiscountsAction.Click();
        }
        
        public virtual void VendorDocuments()
        {
            ToolBar.VendorDocuments.Click();
        }
        
        public virtual void PrintAPEdit()
        {
            ToolBar.PrintAPEdit.Click();
        }
        
        public virtual void PrintAPRegister()
        {
            ToolBar.PrintAPRegister.Click();
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
        
        public virtual void ViewPayment()
        {
            ToolBar.ViewPayment.Click();
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
        
        public virtual void Processing()
        {
            ToolBar.Processing.Click();
        }
        
        public virtual void Corrections()
        {
            ToolBar.Corrections.Click();
        }
        
        public virtual void Approval()
        {
            ToolBar.Approval.Click();
        }
        
        public virtual void CustomOther()
        {
            ToolBar.CustomOther.Click();
        }
        
        public virtual void Inquiry()
        {
            ToolBar.Inquiry.Click();
        }
        
        public virtual void Report()
        {
            ToolBar.Report.Click();
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
			public ToolBarButton Prebook { get; }
			public ToolBarButton Release { get; }
			public ToolBarButton PayInvoice { get; }
			public ToolBarButton ReleaseRetainage { get; }
			public ToolBarButton Reclassify { get; }
			public ToolBarButton VendorRefund { get; }
			public ToolBarButton ReverseInvoice { get; }
			public ToolBarButton VoidInvoice { get; }
			public ToolBarButton ReclassifyBatch { get; }
			public ToolBarButton VoidDocument { get; }
			public ToolBarButton CreateSchedule { get; }
			public ToolBarButton RecalculateDiscountsAction { get; }
			public ToolBarButton VendorDocuments { get; }
			public ToolBarButton PrintAPEdit { get; }
			public ToolBarButton PrintAPRegister { get; }
			public ToolBarButton VoidCheck { get; }
			public ToolBarButton ViewPayment { get; }
			public ToolBarButton ViewActivity { get; }
			public ToolBarButton ViewactivityWorkflow { get; }
			public ToolBarButton OpenActivityOwner { get; }
			public ToolBarButton OpenactivityownerWorkflow { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton ViewallactivitiesWorkflow { get; }
			public ToolBarButton Processing { get; }
			public ToolBarButton Corrections { get; }
			public ToolBarButton Approval { get; }
			public ToolBarButton CustomOther { get; }
			public ToolBarButton Inquiry { get; }
			public ToolBarButton Report { get; }
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
                Delete.ConfirmAction = () => Alert.AlertToException("The current AP document record will be deleted.");
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
                Prebook = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Prebook,#ctl00_phDS_ds_ToolBar_Prebook_item", "Pre-release", locator, MenuOpener);
                Prebook.WaitAction = Wait.WaitForLongOperationToComplete;
                Release = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Release,#ctl00_phDS_ds_ToolBar_Release_item", "Release", locator, MenuOpener);
                Release.WaitAction = Wait.WaitForLongOperationToComplete;
                PayInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PayInvoice,#ctl00_phDS_ds_ToolBar_PayInvoice_item", "Pay", locator, MenuOpener);
                ReleaseRetainage = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReleaseRetainage,#ctl00_phDS_ds_ToolBar_ReleaseRetaina" +
                        "ge_item", "Release Retainage", locator, MenuOpener);
                ReleaseRetainage.WaitAction = Wait.WaitForLongOperationToComplete;
                Reclassify = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Reclassify,#ctl00_phDS_ds_ToolBar_Reclassify_item", "Reclassify Bill", locator, MenuOpener);
                VendorRefund = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VendorRefund,#ctl00_phDS_ds_ToolBar_VendorRefund_item", "Refund", locator, MenuOpener);
                ReverseInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReverseInvoice,#ctl00_phDS_ds_ToolBar_ReverseInvoice_i" +
                        "tem", "Reverse", locator, MenuOpener);
                VoidInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VoidInvoice,#ctl00_phDS_ds_ToolBar_VoidInvoice_item", "Void", locator, MenuOpener);
                VoidInvoice.WaitAction = Wait.WaitForLongOperationToComplete;
                ReclassifyBatch = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReclassifyBatch,#ctl00_phDS_ds_ToolBar_ReclassifyBatch" +
                        "_item", "Reclassify GL Batch", locator, MenuOpener);
                VoidDocument = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VoidDocument,#ctl00_phDS_ds_ToolBar_VoidDocument_item", "Void", locator, MenuOpener);
                CreateSchedule = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreateSchedule,#ctl00_phDS_ds_ToolBar_CreateSchedule_i" +
                        "tem", "Add to Schedule", locator, MenuOpener);
                CreateSchedule.WaitAction = Wait.WaitForLongOperationToComplete;
                RecalculateDiscountsAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_RecalculateDiscountsAction,#ctl00_phDS_ds_ToolBar_Reca" +
                        "lculateDiscountsAction_item", "Recalculate Prices", locator, MenuOpener);
                VendorDocuments = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VendorDocuments,#ctl00_phDS_ds_ToolBar_VendorDocuments" +
                        "_item", "Vendor Details", locator, MenuOpener);
                PrintAPEdit = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintAPEdit,#ctl00_phDS_ds_ToolBar_PrintAPEdit_item", "AP Edit Detailed", locator, MenuOpener);
                PrintAPRegister = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintAPRegister,#ctl00_phDS_ds_ToolBar_PrintAPRegister" +
                        "_item", "AP Register Detailed", locator, MenuOpener);
                VoidCheck = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VoidCheck,#ctl00_phDS_ds_ToolBar_VoidCheck_item", "Void", locator, MenuOpener);
                VoidCheck.WaitAction = Wait.WaitForLongOperationToComplete;
                ViewPayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewPayment,#ctl00_phDS_ds_ToolBar_ViewPayment_item", "View Document", locator, MenuOpener);
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
                Processing = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Processing", "Processing", locator, MenuOpener);
                Corrections = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Corrections", "Corrections", locator, MenuOpener);
                Approval = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Approval", "Approval", locator, MenuOpener);
                CustomOther = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CustomOther", "Other", locator, MenuOpener);
                Inquiry = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Inquiry", "Inquiries", locator, MenuOpener);
                Report = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Report", "Reports", locator, MenuOpener);
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
			public DateSelector DocDate { get; }
			public Label DocDateLabel { get; }
			public Selector FinPeriodID { get; }
			public Label FinPeriodIDLabel { get; }
			public PXTextEdit InvoiceNbr { get; }
			public Label InvoiceNbrLabel { get; }
			public PXTextEdit DocDesc { get; }
			public Label DocDescLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector VendorLocationID { get; }
			public Label VendorLocationIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBoxButton CuryViewState { get; }
			public Label CuryViewStateLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public DateSelector DueDate { get; }
			public Label DueDateLabel { get; }
			public CheckBox IsRetainageDocument { get; }
			public Label IsRetainageDocumentLabel { get; }
			public CheckBox RetainageApply { get; }
			public Label RetainageApplyLabel { get; }
			public DateSelector DiscDate { get; }
			public Label DiscDateLabel { get; }
			public CheckBox PaymentsByLinesAllowed { get; }
			public Label PaymentsByLinesAllowedLabel { get; }
			public CheckBox IsJointPayees { get; }
			public Label IsJointPayeesLabel { get; }
			public PXNumberEdit CuryLineTotal { get; }
			public Label CuryLineTotalLabel { get; }
			public PXNumberEdit CuryDiscTot { get; }
			public Label CuryDiscTotLabel { get; }
			public PXNumberEdit CuryVatTaxableTotal { get; }
			public Label CuryVatTaxableTotalLabel { get; }
			public PXNumberEdit CuryVatExemptTotal { get; }
			public Label CuryVatExemptTotalLabel { get; }
			public PXNumberEdit CuryTaxTotal { get; }
			public Label CuryTaxTotalLabel { get; }
			public PXNumberEdit CuryOrigWhTaxAmt { get; }
			public Label CuryOrigWhTaxAmtLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public PXNumberEdit CuryInitDocBal { get; }
			public Label CuryInitDocBalLabel { get; }
			public PXNumberEdit CuryRoundDiff { get; }
			public Label CuryRoundDiffLabel { get; }
			public PXNumberEdit CuryOrigDocAmt { get; }
			public Label CuryOrigDocAmtLabel { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public Label CuryTaxAmtLabel { get; }
			public PXNumberEdit CuryOrigDiscAmt { get; }
			public Label CuryOrigDiscAmtLabel { get; }
			public Label Ctl39_ { get; }
			public Label Ctl40_ { get; }
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
                DocType.Items.Add("INV", "Bill");
                DocType.Items.Add("ACR", "Credit Adj.");
                DocType.Items.Add("ADR", "Debit Adj.");
                DocType.Items.Add("PPM", "Prepayment");
                RefNbr = new Selector("ctl00_phF_form_t0_edRefNbr", "Reference Nbr.", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                Status = new DropDown("ctl00_phF_form_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("B", "Balanced");
                Status.Items.Add("V", "Voided");
                Status.Items.Add("S", "Scheduled");
                Status.Items.Add("N", "Open");
                Status.Items.Add("C", "Closed");
                Status.Items.Add("P", "Printed");
                Status.Items.Add("K", "Pre-Released");
                Status.Items.Add("E", "Pending Approval");
                Status.Items.Add("R", "Rejected");
                Status.Items.Add("Z", "Reserved");
                Status.Items.Add("G", "Pending Print");
                Status.Items.Add("X", "Under Reclassification");
                DocDate = new DateSelector("ctl00_phF_form_t0_edDocDate", "Date", locator, null);
                DocDateLabel = new Label(DocDate);
                DocDate.DataField = "DocDate";
                FinPeriodID = new Selector("ctl00_phF_form_t0_edFinPeriodID", "Post Period", locator, null);
                FinPeriodIDLabel = new Label(FinPeriodID);
                FinPeriodID.DataField = "FinPeriodID";
                InvoiceNbr = new PXTextEdit("ctl00_phF_form_t0_edInvoiceNbr", "Vendor Ref.", locator, null);
                InvoiceNbrLabel = new Label(InvoiceNbr);
                InvoiceNbr.DataField = "InvoiceNbr";
                DocDesc = new PXTextEdit("ctl00_phF_form_t0_edDocDesc", "Description", locator, null);
                DocDescLabel = new Label(DocDesc);
                DocDesc.DataField = "DocDesc";
                VendorID = new Selector("ctl00_phF_form_t0_edVendorID", "Vendor", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                VendorLocationID = new Selector("ctl00_phF_form_t0_edVendorLocationID", "Location", locator, null);
                VendorLocationIDLabel = new Label(VendorLocationID);
                VendorLocationID.DataField = "VendorLocationID";
                CuryID = new Selector("ctl00_phF_form_t0_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phF_form_t0_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                TermsID = new Selector("ctl00_phF_form_t0_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                ProjectID = new Selector("ctl00_phF_form_t0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                DueDate = new DateSelector("ctl00_phF_form_t0_edDueDate", "Due Date", locator, null);
                DueDateLabel = new Label(DueDate);
                DueDate.DataField = "DueDate";
                IsRetainageDocument = new CheckBox("ctl00_phF_form_t0_chkIsRetainageDocument", "Retainage Bill", locator, null);
                IsRetainageDocumentLabel = new Label(IsRetainageDocument);
                IsRetainageDocument.DataField = "IsRetainageDocument";
                RetainageApply = new CheckBox("ctl00_phF_form_t0_chkRetainageApply", "Apply Retainage", locator, null);
                RetainageApplyLabel = new Label(RetainageApply);
                RetainageApply.DataField = "RetainageApply";
                DiscDate = new DateSelector("ctl00_phF_form_t0_edDiscDate", "Cash Discount Date", locator, null);
                DiscDateLabel = new Label(DiscDate);
                DiscDate.DataField = "DiscDate";
                PaymentsByLinesAllowed = new CheckBox("ctl00_phF_form_t0_chkPaymentsByLinesAllowed", "Pay by Line", locator, null);
                PaymentsByLinesAllowedLabel = new Label(PaymentsByLinesAllowed);
                PaymentsByLinesAllowed.DataField = "PaymentsByLinesAllowed";
                IsJointPayees = new CheckBox("ctl00_phF_form_t0_chkIsJointPayees", "Joint Payees", locator, null);
                IsJointPayeesLabel = new Label(IsJointPayees);
                IsJointPayees.DataField = "IsJointPayees";
                CuryLineTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryLineTotal", "Detail Total", locator, null);
                CuryLineTotalLabel = new Label(CuryLineTotal);
                CuryLineTotal.DataField = "CuryLineTotal";
                CuryDiscTot = new PXNumberEdit("ctl00_phF_form_t0_edCuryDiscTot", "Discount Total", locator, null);
                CuryDiscTotLabel = new Label(CuryDiscTot);
                CuryDiscTot.DataField = "CuryDiscTot";
                CuryVatTaxableTotal = new PXNumberEdit("ctl00_phF_form_t0_CuryVatTaxableTotal", "VAT Taxable Total", locator, null);
                CuryVatTaxableTotalLabel = new Label(CuryVatTaxableTotal);
                CuryVatTaxableTotal.DataField = "CuryVatTaxableTotal";
                CuryVatExemptTotal = new PXNumberEdit("ctl00_phF_form_t0_CuryVatExemptTotal", "VAT Exempt Total", locator, null);
                CuryVatExemptTotalLabel = new Label(CuryVatExemptTotal);
                CuryVatExemptTotal.DataField = "CuryVatExemptTotal";
                CuryTaxTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryTaxTotal", "Tax Total", locator, null);
                CuryTaxTotalLabel = new Label(CuryTaxTotal);
                CuryTaxTotal.DataField = "CuryTaxTotal";
                CuryOrigWhTaxAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrigWhTaxAmt", "With. Tax", locator, null);
                CuryOrigWhTaxAmtLabel = new Label(CuryOrigWhTaxAmt);
                CuryOrigWhTaxAmt.DataField = "CuryOrigWhTaxAmt";
                CuryDocBal = new PXNumberEdit("ctl00_phF_form_t0_edCuryDocBal", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                CuryInitDocBal = new PXNumberEdit("ctl00_phF_form_t0_edCuryInitDocBal", "Balance", locator, null);
                CuryInitDocBalLabel = new Label(CuryInitDocBal);
                CuryInitDocBal.DataField = "CuryInitDocBal";
                CuryRoundDiff = new PXNumberEdit("ctl00_phF_form_t0_edCuryRoundDiff", "Rounding Diff.", locator, null);
                CuryRoundDiffLabel = new Label(CuryRoundDiff);
                CuryRoundDiff.DataField = "CuryRoundDiff";
                CuryOrigDocAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrigDocAmt", "Amount", locator, null);
                CuryOrigDocAmtLabel = new Label(CuryOrigDocAmt);
                CuryOrigDocAmt.DataField = "CuryOrigDocAmt";
                CuryTaxAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryTaxAmt", "Tax Amount", locator, null);
                CuryTaxAmtLabel = new Label(CuryTaxAmt);
                CuryTaxAmt.DataField = "CuryTaxAmt";
                CuryOrigDiscAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrigDiscAmt", "Cash Discount", locator, null);
                CuryOrigDiscAmtLabel = new Label(CuryOrigDiscAmt);
                CuryOrigDiscAmt.DataField = "CuryOrigDiscAmt";
                Ctl39_ = new Label("ctl00_phF_form_t0_ctl39", "Ctl 39_", locator, null);
                Ctl40_ = new Label("ctl00_phF_form_t0_ctl40", "Ctl 40_", locator, null);
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
            
            public virtual void VendorIDEdit()
            {
                Buttons.VendorIDEdit.Click();
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
			public Button VendorIDEdit { get; }
			public Button ProjectIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phF_form_t0_edCury_rateB", "0", "ctl00_phF_form");
                    Viewbase = new Button("ctl00_phF_form_t0_edCury_curyB", "View base", "ctl00_phF_form");
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form");
                    VendorIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edVendorID\'] div[class=\'editBtnCont\'] > div > div", "VendorIDEdit", "ctl00_phF_form");
                    VendorIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
                DataMemberName = "currencyinfo";
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
        
        public class c_currentdocument_form2 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BatchNbr { get; }
			public Label BatchNbrLabel { get; }
			public Selector PrebookBatchNbr { get; }
			public Label PrebookBatchNbrLabel { get; }
			public Selector VoidBatchNbr { get; }
			public Label VoidBatchNbrLabel { get; }
			public PXNumberEdit DisplayCuryInitDocBal { get; }
			public Label DisplayCuryInitDocBalLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector APAccountID { get; }
			public Label APAccountIDLabel { get; }
			public Selector APSubID { get; }
			public Label APSubIDLabel { get; }
			public Selector PrebookAcctID { get; }
			public Label PrebookAcctIDLabel { get; }
			public Selector PrebookSubID { get; }
			public Label PrebookSubIDLabel { get; }
			public Selector RetainageAcctID { get; }
			public Label RetainageAcctIDLabel { get; }
			public Selector RetainageSubID { get; }
			public Label RetainageSubIDLabel { get; }
			public PXTextEdit OrigRefNbr { get; }
			public Label OrigRefNbrLabel { get; }
			public CheckBox SeparateCheck { get; }
			public Label SeparateCheckLabel { get; }
			public CheckBox PaySel { get; }
			public Label PaySelLabel { get; }
			public DateSelector PayDate { get; }
			public Label PayDateLabel { get; }
			public Selector PayLocationID { get; }
			public Label PayLocationIDLabel { get; }
			public Selector PayTypeID { get; }
			public Label PayTypeIDLabel { get; }
			public Selector PayAccountID { get; }
			public Label PayAccountIDLabel { get; }
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public CheckBox UsesManualVAT { get; }
			public Label UsesManualVATLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
			public Selector TaxCostINAdjRefNbr { get; }
			public Label TaxCostINAdjRefNbrLabel { get; }
			public Selector EmployeeWorkgroupID { get; }
			public Label EmployeeWorkgroupIDLabel { get; }
			public Selector EmployeeID { get; }
			public Label EmployeeIDLabel { get; }
			public Selector SuppliedByVendorID { get; }
			public Label SuppliedByVendorIDLabel { get; }
			public Selector SuppliedByVendorLocationID { get; }
			public Label SuppliedByVendorLocationIDLabel { get; }
			public Selector IntercompanyInvoiceNoteID { get; }
			public Label IntercompanyInvoiceNoteIDLabel { get; }
			public PXNumberEdit CuryDiscountedDocTotal { get; }
			public Label CuryDiscountedDocTotalLabel { get; }
			public PXNumberEdit CuryDiscountedTaxableTotal { get; }
			public Label CuryDiscountedTaxableTotalLabel { get; }
			public PXNumberEdit CuryDiscountedPrice { get; }
			public Label CuryDiscountedPriceLabel { get; }
            
            public c_currentdocument_form2(string locator, string name) : 
                    base(locator, name)
            {
                BatchNbr = new Selector("ctl00_phG_tab_t1_form2_edBatchNbr", "Batch Nbr.", locator, null);
                BatchNbrLabel = new Label(BatchNbr);
                BatchNbr.DataField = "BatchNbr";
                PrebookBatchNbr = new Selector("ctl00_phG_tab_t1_form2_edPrebookBatchNbr", "Pre-Releasing Batch Nbr.", locator, null);
                PrebookBatchNbrLabel = new Label(PrebookBatchNbr);
                PrebookBatchNbr.DataField = "PrebookBatchNbr";
                VoidBatchNbr = new Selector("ctl00_phG_tab_t1_form2_edVoidBatchNbr", "Void Batch Nbr.", locator, null);
                VoidBatchNbrLabel = new Label(VoidBatchNbr);
                VoidBatchNbr.DataField = "VoidBatchNbr";
                DisplayCuryInitDocBal = new PXNumberEdit("ctl00_phG_tab_t1_form2_edDisplayCuryInitDocBal", "Migrated Balance", locator, null);
                DisplayCuryInitDocBalLabel = new Label(DisplayCuryInitDocBal);
                DisplayCuryInitDocBal.DataField = "DisplayCuryInitDocBal";
                BranchID = new Selector("ctl00_phG_tab_t1_form2_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                APAccountID = new Selector("ctl00_phG_tab_t1_form2_edAPAccountID", "AP Account", locator, null);
                APAccountIDLabel = new Label(APAccountID);
                APAccountID.DataField = "APAccountID";
                APSubID = new Selector("ctl00_phG_tab_t1_form2_edAPSubID", "AP Subaccount", locator, null);
                APSubIDLabel = new Label(APSubID);
                APSubID.DataField = "APSubID";
                PrebookAcctID = new Selector("ctl00_phG_tab_t1_form2_edPrebookAcctID", "Reclassification Account", locator, null);
                PrebookAcctIDLabel = new Label(PrebookAcctID);
                PrebookAcctID.DataField = "PrebookAcctID";
                PrebookSubID = new Selector("ctl00_phG_tab_t1_form2_edPrebookSubID", "Reclassification Subaccount", locator, null);
                PrebookSubIDLabel = new Label(PrebookSubID);
                PrebookSubID.DataField = "PrebookSubID";
                RetainageAcctID = new Selector("ctl00_phG_tab_t1_form2_edRetainageAcctID", "Retainage Payable Account", locator, null);
                RetainageAcctIDLabel = new Label(RetainageAcctID);
                RetainageAcctID.DataField = "RetainageAcctID";
                RetainageSubID = new Selector("ctl00_phG_tab_t1_form2_edRetainageSubID", "Retainage Payable Sub.", locator, null);
                RetainageSubIDLabel = new Label(RetainageSubID);
                RetainageSubID.DataField = "RetainageSubID";
                OrigRefNbr = new PXTextEdit("ctl00_phG_tab_t1_form2_edOrigRefNbr", "Original Document", locator, null);
                OrigRefNbrLabel = new Label(OrigRefNbr);
                OrigRefNbr.DataField = "OrigRefNbr";
                SeparateCheck = new CheckBox("ctl00_phG_tab_t1_form2_chkSeparateCheck", "Pay Separately", locator, null);
                SeparateCheckLabel = new Label(SeparateCheck);
                SeparateCheck.DataField = "SeparateCheck";
                PaySel = new CheckBox("ctl00_phG_tab_t1_form2_chkPaySel", "Approved for Payment", locator, null);
                PaySelLabel = new Label(PaySel);
                PaySel.DataField = "PaySel";
                PayDate = new DateSelector("ctl00_phG_tab_t1_form2_edPayDate", "Pay Date", locator, null);
                PayDateLabel = new Label(PayDate);
                PayDate.DataField = "PayDate";
                PayLocationID = new Selector("ctl00_phG_tab_t1_form2_edPayLocationID", "Payment Location", locator, null);
                PayLocationIDLabel = new Label(PayLocationID);
                PayLocationID.DataField = "PayLocationID";
                PayTypeID = new Selector("ctl00_phG_tab_t1_form2_edPayTypeID", "Payment Method", locator, null);
                PayTypeIDLabel = new Label(PayTypeID);
                PayTypeID.DataField = "PayTypeID";
                PayAccountID = new Selector("ctl00_phG_tab_t1_form2_edPayAccountID", "Cash Account", locator, null);
                PayAccountIDLabel = new Label(PayAccountID);
                PayAccountID.DataField = "PayAccountID";
                TaxZoneID = new Selector("ctl00_phG_tab_t1_form2_edTaxZoneID", "Vendor Tax Zone", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                UsesManualVAT = new CheckBox("ctl00_phG_tab_t1_form2_chkUsesManualVAT", "Manual VAT Entry", locator, null);
                UsesManualVATLabel = new Label(UsesManualVAT);
                UsesManualVAT.DataField = "UsesManualVAT";
                TaxCalcMode = new DropDown("ctl00_phG_tab_t1_form2_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                TaxCostINAdjRefNbr = new Selector("ctl00_phG_tab_t1_form2_edTaxCostINAdjRefNbr", "Adjustment Nbr.", locator, null);
                TaxCostINAdjRefNbrLabel = new Label(TaxCostINAdjRefNbr);
                TaxCostINAdjRefNbr.DataField = "TaxCostINAdjRefNbr";
                EmployeeWorkgroupID = new Selector("ctl00_phG_tab_t1_form2_edEmployeeWorkgroupID", "Workgroup ID", locator, null);
                EmployeeWorkgroupIDLabel = new Label(EmployeeWorkgroupID);
                EmployeeWorkgroupID.DataField = "EmployeeWorkgroupID";
                EmployeeID = new Selector("ctl00_phG_tab_t1_form2_edEmployeeID", "Owner", locator, null);
                EmployeeIDLabel = new Label(EmployeeID);
                EmployeeID.DataField = "EmployeeID";
                SuppliedByVendorID = new Selector("ctl00_phG_tab_t1_form2_edSuppliedByVendorID", "Supplied-by Vendor", locator, null);
                SuppliedByVendorIDLabel = new Label(SuppliedByVendorID);
                SuppliedByVendorID.DataField = "SuppliedByVendorID";
                SuppliedByVendorLocationID = new Selector("ctl00_phG_tab_t1_form2_edSuppliedByVendorLocationID", "Supplied-by Vendor Location", locator, null);
                SuppliedByVendorLocationIDLabel = new Label(SuppliedByVendorLocationID);
                SuppliedByVendorLocationID.DataField = "SuppliedByVendorLocationID";
                IntercompanyInvoiceNoteID = new Selector("ctl00_phG_tab_t1_form2_edIntercompanyInvoiceNoteID", "Related AR Document", locator, null);
                IntercompanyInvoiceNoteIDLabel = new Label(IntercompanyInvoiceNoteID);
                IntercompanyInvoiceNoteID.DataField = "IntercompanyInvoiceNoteID";
                CuryDiscountedDocTotal = new PXNumberEdit("ctl00_phG_tab_t1_form2_edCuryDiscountedDocTotal", "Discounted Doc. Total", locator, null);
                CuryDiscountedDocTotalLabel = new Label(CuryDiscountedDocTotal);
                CuryDiscountedDocTotal.DataField = "CuryDiscountedDocTotal";
                CuryDiscountedTaxableTotal = new PXNumberEdit("ctl00_phG_tab_t1_form2_edCuryDiscountedTaxableTotal", "Discounted Taxable Total", locator, null);
                CuryDiscountedTaxableTotalLabel = new Label(CuryDiscountedTaxableTotal);
                CuryDiscountedTaxableTotal.DataField = "CuryDiscountedTaxableTotal";
                CuryDiscountedPrice = new PXNumberEdit("ctl00_phG_tab_t1_form2_edCuryDiscountedPrice", "Tax on Discounted Price", locator, null);
                CuryDiscountedPriceLabel = new Label(CuryDiscountedPrice);
                CuryDiscountedPrice.DataField = "CuryDiscountedPrice";
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void SuppliedByVendorIDEdit()
            {
                Buttons.SuppliedByVendorIDEdit.Click();
            }
            
            public virtual void IntercompanyInvoiceNoteIDEdit()
            {
                Buttons.IntercompanyInvoiceNoteIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button SuppliedByVendorIDEdit { get; }
			public Button IntercompanyInvoiceNoteIDEdit { get; }
                
                public PxButtonCollection()
                {
                    SuppliedByVendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_form2_edSuppliedByVendorID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "SuppliedByVendorIDEdit", "ctl00_phG_tab_t1_form2");
                    SuppliedByVendorIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    IntercompanyInvoiceNoteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_form2_edIntercompanyInvoiceNoteID\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "IntercompanyInvoiceNoteIDEdit", "ctl00_phG_tab_t1_form2");
                    IntercompanyInvoiceNoteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_currentdocument_formretainage : Container
        {
            
			public PXNumberEdit DefRetainagePct { get; }
			public Label DefRetainagePctLabel { get; }
			public PXNumberEdit CuryOrigDocAmtWithRetainageTotal { get; }
			public Label CuryOrigDocAmtWithRetainageTotalLabel { get; }
			public PXNumberEdit CuryRetainageTotal { get; }
			public Label CuryRetainageTotalLabel { get; }
			public PXNumberEdit CuryRetainageUnreleasedAmt { get; }
			public Label CuryRetainageUnreleasedAmtLabel { get; }
			public PXNumberEdit CuryRetainageReleased { get; }
			public Label CuryRetainageReleasedLabel { get; }
			public PXNumberEdit CuryRetainageUnpaidTotal { get; }
			public Label CuryRetainageUnpaidTotalLabel { get; }
			public PXNumberEdit CuryRetainagePaidTotal { get; }
			public Label CuryRetainagePaidTotalLabel { get; }
			public PXNumberEdit CuryRetainedTaxTotal { get; }
			public Label CuryRetainedTaxTotalLabel { get; }
			public PXNumberEdit CuryRetainedDiscTotal { get; }
			public Label CuryRetainedDiscTotalLabel { get; }
            
            public c_currentdocument_formretainage(string locator, string name) : 
                    base(locator, name)
            {
                DefRetainagePct = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edDefRetainagePct", "Default Retainage Percent", locator, null);
                DefRetainagePctLabel = new Label(DefRetainagePct);
                DefRetainagePct.DataField = "DefRetainagePct";
                CuryOrigDocAmtWithRetainageTotal = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edCuryOrigDocAmtWithRetainageTotal", "Total Amount", locator, null);
                CuryOrigDocAmtWithRetainageTotalLabel = new Label(CuryOrigDocAmtWithRetainageTotal);
                CuryOrigDocAmtWithRetainageTotal.DataField = "CuryOrigDocAmtWithRetainageTotal";
                CuryRetainageTotal = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edCuryRetainageTotal", "Original Retainage", locator, null);
                CuryRetainageTotalLabel = new Label(CuryRetainageTotal);
                CuryRetainageTotal.DataField = "CuryRetainageTotal";
                CuryRetainageUnreleasedAmt = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edCuryRetainageUnreleasedAmt", "Unreleased Retainage", locator, null);
                CuryRetainageUnreleasedAmtLabel = new Label(CuryRetainageUnreleasedAmt);
                CuryRetainageUnreleasedAmt.DataField = "CuryRetainageUnreleasedAmt";
                CuryRetainageReleased = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edCuryRetainageReleasedAmt", "Released Retainage", locator, null);
                CuryRetainageReleasedLabel = new Label(CuryRetainageReleased);
                CuryRetainageReleased.DataField = "CuryRetainageReleased";
                CuryRetainageUnpaidTotal = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edCuryRetainageUnpaidTotal", "Unpaid Retainage", locator, null);
                CuryRetainageUnpaidTotalLabel = new Label(CuryRetainageUnpaidTotal);
                CuryRetainageUnpaidTotal.DataField = "CuryRetainageUnpaidTotal";
                CuryRetainagePaidTotal = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edCuryRetainagePaidTotal", "Paid Retainage", locator, null);
                CuryRetainagePaidTotalLabel = new Label(CuryRetainagePaidTotal);
                CuryRetainagePaidTotal.DataField = "CuryRetainagePaidTotal";
                CuryRetainedTaxTotal = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edCuryRetainedTaxTotal", "Tax on Retainage", locator, null);
                CuryRetainedTaxTotalLabel = new Label(CuryRetainedTaxTotal);
                CuryRetainedTaxTotal.DataField = "CuryRetainedTaxTotal";
                CuryRetainedDiscTotal = new PXNumberEdit("ctl00_phG_tab_t5_formRetainage_edCuryRetainedDiscTotal", "Discount on Retainage", locator, null);
                CuryRetainedDiscTotalLabel = new Label(CuryRetainedDiscTotal);
                CuryRetainedDiscTotal.DataField = "CuryRetainedDiscTotal";
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_currentdocument_frmvendor : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public PXNumberEdit AmountToPay { get; }
			public Label AmountToPayLabel { get; }
			public PXNumberEdit VendorBalance { get; }
			public Label VendorBalanceLabel { get; }
            
            public c_currentdocument_frmvendor(string locator, string name) : 
                    base(locator, name)
            {
                VendorID = new Selector("ctl00_phG_PanelPayBillJC_frmVendor_edVendor", "Vendor ID", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                AmountToPay = new PXNumberEdit("ctl00_phG_PanelPayBillJC_frmVendor_edAmountToPay", "Amount To Pay", locator, null);
                AmountToPayLabel = new Label(AmountToPay);
                AmountToPay.DataField = "AmountToPay";
                VendorBalance = new PXNumberEdit("ctl00_phG_PanelPayBillJC_frmVendor_edVendorBalance", "Vendor Balance", locator, null);
                VendorBalanceLabel = new Label(VendorBalance);
                VendorBalance.DataField = "VendorBalance";
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Confirm()
            {
                Buttons.Confirm.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirm { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Confirm = new Button("ctl00_phG_PanelPayBillJC_btnOK123", "Confirm", "ctl00_phG_PanelPayBillJC_frmVendor");
                    Cancel = new Button("ctl00_phG_PanelPayBillJC_btnCancel123", "Cancel", "ctl00_phG_PanelPayBillJC_frmVendor");
                }
            }
        }
        
        public class c_transactions_grid : Grid<c_transactions_grid.c_grid_row, c_transactions_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_transactions_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grid");
                DataMemberName = "Transactions";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_tab_t0_grid_imp_upl_pnl", "UploadForm");
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
            
            public virtual void AddPoReceipt()
            {
                ToolBar.AddPoReceipt.Click();
            }
            
            public virtual void AddPoReceiptLine()
            {
                ToolBar.AddPoReceiptLine.Click();
            }
            
            public virtual void AddPo()
            {
                ToolBar.AddPo.Click();
            }
            
            public virtual void AddSubcontract()
            {
                ToolBar.AddSubcontract.Click();
            }
            
            public virtual void AddPoLine()
            {
                ToolBar.AddPoLine.Click();
            }
            
            public virtual void AddSubcontractLine()
            {
                ToolBar.AddSubcontractLine.Click();
            }
            
            public virtual void AddLc()
            {
                ToolBar.AddLc.Click();
            }
            
            public virtual void LinkLine()
            {
                ToolBar.LinkLine.Click();
            }
            
            public virtual void ViewItem()
            {
                ToolBar.ViewItem.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Upload()
            {
                ToolBar.Upload.Click();
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
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void DefScheduleIDEdit()
            {
                Buttons.DefScheduleIDEdit.Click();
            }
            
            public virtual void RelatedDocNoteIDEdit()
            {
                Buttons.RelatedDocNoteIDEdit.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
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
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void Upload1()
            {
                Buttons.Upload1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid FormView { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid ViewDeferrals { get; }
			public ToolBarButtonGrid AddPoReceipt { get; }
			public ToolBarButtonGrid AddPoReceiptLine { get; }
			public ToolBarButtonGrid AddPo { get; }
			public ToolBarButtonGrid AddSubcontract { get; }
			public ToolBarButtonGrid AddPoLine { get; }
			public ToolBarButtonGrid AddSubcontractLine { get; }
			public ToolBarButtonGrid AddLc { get; }
			public ToolBarButtonGrid LinkLine { get; }
			public ToolBarButtonGrid ViewItem { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Upload { get; }
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
                    AddPoReceipt = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdRT\']", "Add PO Receipt", locator, null);
                    AddPoReceiptLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdRTL\']", "Add PO Receipt Line", locator, null);
                    AddPo = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdPO\']", "Add PO", locator, null);
                    AddSubcontract = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdSC\']", "Add Subcontract", locator, null);
                    AddPoLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdPOLine\']", "Add PO Line", locator, null);
                    AddSubcontractLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdSCLine\']", "Add Subcontract Line", locator, null);
                    AddLc = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdLC\']", "Add LC", locator, null);
                    LinkLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'LinkLine\']", "Link Line", locator, null);
                    ViewItem = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ViewItem\']", "View Item", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DefScheduleIDEdit { get; }
			public Button RelatedDocNoteIDEdit { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button Upload1 { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edDiscountCode\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DiscountIDEdit", "ctl00_phG_tab_t0_grid");
                    DiscountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefScheduleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edDefScheduleID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "DefScheduleIDEdit", "ctl00_phG_tab_t0_grid");
                    DefScheduleIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    RelatedDocNoteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edRelatedDocNoteID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "RelatedDocNoteIDEdit", "ctl00_phG_tab_t0_grid");
                    RelatedDocNoteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_grid");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_grid");
                    Ok1 = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_grid");
                    Cancel1 = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_grid");
                    First = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_grid");
                    Prev = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_grid");
                    Next = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_grid");
                    Last = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_grid");
                    Ok2 = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_grid");
                    Cancel2 = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_grid");
                    Upload1 = new Button("ctl00_phG_tab_t0_grid_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t0_grid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit SubcontractLineNbr { get; }
			public Selector BranchID { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit SortOrder { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public PXTextEdit TranDesc { get; }
			public PXNumberEdit Qty { get; }
			public PXNumberEdit BaseQty { get; }
			public Selector UOM { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public CheckBox ManualPrice { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public PXNumberEdit DiscPct { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public PXNumberEdit CuryDiscCost { get; }
			public CheckBox ManualDisc { get; }
			public Selector DiscountID { get; }
			public PXTextEdit DiscountSequenceID { get; }
			public PXNumberEdit PrepaymentPct { get; }
			public PXNumberEdit CuryPrepaymentAmt { get; }
			public PXNumberEdit RetainagePct { get; }
			public PXNumberEdit CuryCashDiscBal { get; }
			public PXNumberEdit CuryRetainageAmt { get; }
			public PXNumberEdit CuryRetainageBal { get; }
			public PXNumberEdit CuryRetainedTaxAmt { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public PXNumberEdit CuryTranBal { get; }
			public PXNumberEdit CuryOrigTaxAmt { get; }
			public Selector AccountID { get; }
			public PXTextEdit AccountID_Account_description { get; }
			public Selector SubID { get; }
			public Selector ProjectID { get; }
			public Selector TaskID { get; }
			public Selector CostCodeID { get; }
			public CheckBox NonBillable { get; }
			public Selector Box1099 { get; }
			public Selector DeferredCode { get; }
			public Selector DefScheduleID { get; }
			public DateSelector DRTermStartDate { get; }
			public DateSelector DRTermEndDate { get; }
			public Selector TaxCategoryID { get; }
			public DateSelector Date { get; }
			public DropDown POOrderType { get; }
			public Selector PONbr { get; }
			public PXTextEdit SubcontractNbr { get; }
			public Selector POLineNbr { get; }
			public DropDown LCDocType { get; }
			public Selector LCRefNbr { get; }
			public PXNumberEdit LCLineNbr { get; }
			public DropDown ReceiptType { get; }
			public Selector ReceiptNbr { get; }
			public PXNumberEdit ReceiptLineNbr { get; }
			public DropDown RelatedEntityType { get; }
			public Selector RelatedDocNoteID { get; }
			public DropDown PPVDocType { get; }
			public Selector PPVRefNbr { get; }
			public CheckBox HasExpiredComplianceDocuments { get; }
			public DropDown TranType { get; }
			public PXTextEdit RefNbr { get; }
                
                public c_grid_row(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    SubcontractLineNbr = new PXTextEdit("ctl00_phG_tab_t0_grid", "Subcontract Line", grid.Locator, "SubcontractLineNbr");
                    SubcontractLineNbr.DataField = "SubcontractLineNbr";
                    BranchID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    LineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Line Order", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    InventoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    TranDesc = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Transaction Descr.", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    BaseQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Base Qty.", grid.Locator, "BaseQty");
                    BaseQty.DataField = "BaseQty";
                    UOM = new Selector("_ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    CuryUnitCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryUnitCost", "Unit Cost", grid.Locator, "CuryUnitCost");
                    CuryUnitCost.DataField = "CuryUnitCost";
                    ManualPrice = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Cost", grid.Locator, "ManualPrice");
                    ManualPrice.DataField = "ManualPrice";
                    CuryLineAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryLineAmt", "Ext. Cost", grid.Locator, "CuryLineAmt");
                    CuryLineAmt.DataField = "CuryLineAmt";
                    DiscPct = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edDiscPct", "Discount Percent", grid.Locator, "DiscPct");
                    DiscPct.DataField = "DiscPct";
                    CuryDiscAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryDiscAmt", "Discount Amount", grid.Locator, "CuryDiscAmt");
                    CuryDiscAmt.DataField = "CuryDiscAmt";
                    CuryDiscCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Disc. Unit Cost", grid.Locator, "CuryDiscCost");
                    CuryDiscCost.DataField = "CuryDiscCost";
                    ManualDisc = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualDisc", "Manual Discount", grid.Locator, "ManualDisc");
                    ManualDisc.DataField = "ManualDisc";
                    DiscountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDiscountCode", "Discount Code", grid.Locator, "DiscountID");
                    DiscountID.DataField = "DiscountID";
                    DiscountSequenceID = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Discount Sequence", grid.Locator, "DiscountSequenceID");
                    DiscountSequenceID.DataField = "DiscountSequenceID";
                    PrepaymentPct = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Prepayment Percent", grid.Locator, "PrepaymentPct");
                    PrepaymentPct.DataField = "PrepaymentPct";
                    CuryPrepaymentAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Prepayment Amount", grid.Locator, "CuryPrepaymentAmt");
                    CuryPrepaymentAmt.DataField = "CuryPrepaymentAmt";
                    RetainagePct = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edRetainagePct", "Retainage Percent", grid.Locator, "RetainagePct");
                    RetainagePct.DataField = "RetainagePct";
                    CuryCashDiscBal = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Cash Discount Balance", grid.Locator, "CuryCashDiscBal");
                    CuryCashDiscBal.DataField = "CuryCashDiscBal";
                    CuryRetainageAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Retainage Amount", grid.Locator, "CuryRetainageAmt");
                    CuryRetainageAmt.DataField = "CuryRetainageAmt";
                    CuryRetainageBal = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Unreleased Retainage", grid.Locator, "CuryRetainageBal");
                    CuryRetainageBal.DataField = "CuryRetainageBal";
                    CuryRetainedTaxAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Retained Tax", grid.Locator, "CuryRetainedTaxAmt");
                    CuryRetainedTaxAmt.DataField = "CuryRetainedTaxAmt";
                    CuryTranAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryTranAmt", "Amount", grid.Locator, "CuryTranAmt");
                    CuryTranAmt.DataField = "CuryTranAmt";
                    CuryTranBal = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryTranBal", "Balance", grid.Locator, "CuryTranBal");
                    CuryTranBal.DataField = "CuryTranBal";
                    CuryOrigTaxAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryOrigTaxAmt", "Tax Amount", grid.Locator, "CuryOrigTaxAmt");
                    CuryOrigTaxAmt.DataField = "CuryOrigTaxAmt";
                    AccountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edAccountID", "Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    AccountID_Account_description = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Description", grid.Locator, "AccountID_Account_description");
                    AccountID_Account_description.DataField = "AccountID_Account_description";
                    SubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubID", "Subaccount", grid.Locator, "SubID");
                    SubID.DataField = "SubID";
                    ProjectID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edCostCode", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    NonBillable = new CheckBox("ctl00_phG_tab_t0_grid_ef", "Non Billable", grid.Locator, "NonBillable");
                    NonBillable.DataField = "NonBillable";
                    Box1099 = new Selector("_ctl00_phG_tab_t0_grid_lv0_edBox1099", "1099 Box", grid.Locator, "Box1099");
                    Box1099.DataField = "Box1099";
                    DeferredCode = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDeferredCode", "Deferral Code", grid.Locator, "DeferredCode");
                    DeferredCode.DataField = "DeferredCode";
                    DefScheduleID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDefScheduleID", "Original Deferral Schedule", grid.Locator, "DefScheduleID");
                    DefScheduleID.DataField = "DefScheduleID";
                    DRTermStartDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edDRTermStartDate", "Term Start Date", grid.Locator, "DRTermStartDate");
                    DRTermStartDate.DataField = "DRTermStartDate";
                    DRTermEndDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edDRTermEndDate", "Term End Date", grid.Locator, "DRTermEndDate");
                    DRTermEndDate.DataField = "DRTermEndDate";
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    Date = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_ed44", "Expense Date", grid.Locator, "Date");
                    Date.DataField = "Date";
                    POOrderType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edPOOrderType", "PO Type", grid.Locator, "POOrderType");
                    POOrderType.DataField = "POOrderType";
                    POOrderType.Items.Add("RO", "Normal");
                    POOrderType.Items.Add("DP", "Drop-Ship");
                    POOrderType.Items.Add("PD", "Project Drop-Ship");
                    POOrderType.Items.Add("BL", "Blanket");
                    POOrderType.Items.Add("SB", "Standard");
                    PONbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPONbr", "PO Number", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    SubcontractNbr = new PXTextEdit("ctl00_phG_tab_t0_grid", "Subcontract Nbr.", grid.Locator, "SubcontractNbr");
                    SubcontractNbr.DataField = "SubcontractNbr";
                    POLineNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_es", "PO Line", grid.Locator, "POLineNbr");
                    POLineNbr.DataField = "POLineNbr";
                    LCDocType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edLCDocType", "LC Type", grid.Locator, "LCDocType");
                    LCDocType.DataField = "LCDocType";
                    LCDocType.Items.Add("L", "Landed Cost");
                    LCDocType.Items.Add("C", "Correction");
                    LCDocType.Items.Add("R", "Reversal");
                    LCRefNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLCRefNbr", "LC Number", grid.Locator, "LCRefNbr");
                    LCRefNbr.DataField = "LCRefNbr";
                    LCLineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edLCLineNbr", "LC Line", grid.Locator, "LCLineNbr");
                    LCLineNbr.DataField = "LCLineNbr";
                    ReceiptType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edReceiptType", "PO Receipt Type", grid.Locator, "ReceiptType");
                    ReceiptType.DataField = "ReceiptType";
                    ReceiptType.Items.Add("RT", "Receipt");
                    ReceiptType.Items.Add("RN", "Return");
                    ReceiptType.Items.Add("RX", "Transfer Receipt");
                    ReceiptNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edReceiptNbr", "PO Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                    ReceiptLineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "PO Receipt Line", grid.Locator, "ReceiptLineNbr");
                    ReceiptLineNbr.DataField = "ReceiptLineNbr";
                    RelatedEntityType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edRelatedEntityType", "Related Svc. Doc. Type", grid.Locator, "RelatedEntityType");
                    RelatedEntityType.DataField = "RelatedEntityType";
                    RelatedDocNoteID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edRelatedDocNoteID", "Related Svc. Doc. Nbr.", grid.Locator, "RelatedDocNoteID");
                    RelatedDocNoteID.DataField = "RelatedDocNoteID";
                    PPVDocType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edPPVDocType", "PPV Doc. Type", grid.Locator, "PPVDocType");
                    PPVDocType.DataField = "PPVDocType";
                    PPVDocType.Items.Add("I", "Issue");
                    PPVDocType.Items.Add("R", "Receipt");
                    PPVDocType.Items.Add("T", "Transfer");
                    PPVDocType.Items.Add("A", "Adjustment");
                    PPVDocType.Items.Add("P", "Production");
                    PPVDocType.Items.Add("D", "Disassembly");
                    PPVRefNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPPVRefNbr", "PPV Ref. Nbr.", grid.Locator, "PPVRefNbr");
                    PPVRefNbr.DataField = "PPVRefNbr";
                    HasExpiredComplianceDocuments = new CheckBox("ctl00_phG_tab_t0_grid", "Expired Compliance", grid.Locator, "HasExpiredComplianceDocuments");
                    HasExpiredComplianceDocuments.DataField = "HasExpiredComplianceDocuments";
                    TranType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edTranType", "Tran. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    TranType.Items.Add("INV", "Bill");
                    TranType.Items.Add("ACR", "Credit Adj.");
                    TranType.Items.Add("ADR", "Debit Adj.");
                    TranType.Items.Add("CHK", "Check");
                    TranType.Items.Add("VCK", "Voided Check");
                    TranType.Items.Add("PPM", "Prepayment");
                    TranType.Items.Add("REF", "Vendor Refund");
                    TranType.Items.Add("VRF", "Voided Refund");
                    TranType.Items.Add("QCK", "Quick Check");
                    TranType.Items.Add("VQC", "Void Quick Check");
                    TranType.Items.Add("PPR", "Prepayment Req.");
                    RefNbr = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edRefNbr", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter SubcontractLineNbr { get; }
				public SelectorColumnFilter BranchID { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXNumberEditColumnFilter BaseQty { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter CuryUnitCost { get; }
				public CheckBoxColumnFilter ManualPrice { get; }
				public PXNumberEditColumnFilter CuryLineAmt { get; }
				public PXNumberEditColumnFilter DiscPct { get; }
				public PXNumberEditColumnFilter CuryDiscAmt { get; }
				public PXNumberEditColumnFilter CuryDiscCost { get; }
				public CheckBoxColumnFilter ManualDisc { get; }
				public SelectorColumnFilter DiscountID { get; }
				public PXTextEditColumnFilter DiscountSequenceID { get; }
				public PXNumberEditColumnFilter PrepaymentPct { get; }
				public PXNumberEditColumnFilter CuryPrepaymentAmt { get; }
				public PXNumberEditColumnFilter RetainagePct { get; }
				public PXNumberEditColumnFilter CuryCashDiscBal { get; }
				public PXNumberEditColumnFilter CuryRetainageAmt { get; }
				public PXNumberEditColumnFilter CuryRetainageBal { get; }
				public PXNumberEditColumnFilter CuryRetainedTaxAmt { get; }
				public PXNumberEditColumnFilter CuryTranAmt { get; }
				public PXNumberEditColumnFilter CuryTranBal { get; }
				public PXNumberEditColumnFilter CuryOrigTaxAmt { get; }
				public SelectorColumnFilter AccountID { get; }
				public PXTextEditColumnFilter AccountID_Account_description { get; }
				public SelectorColumnFilter SubID { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public CheckBoxColumnFilter NonBillable { get; }
				public SelectorColumnFilter Box1099 { get; }
				public SelectorColumnFilter DeferredCode { get; }
				public SelectorColumnFilter DefScheduleID { get; }
				public DateSelectorColumnFilter DRTermStartDate { get; }
				public DateSelectorColumnFilter DRTermEndDate { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public DateSelectorColumnFilter Date { get; }
				public DropDownColumnFilter POOrderType { get; }
				public SelectorColumnFilter PONbr { get; }
				public PXTextEditColumnFilter SubcontractNbr { get; }
				public SelectorColumnFilter POLineNbr { get; }
				public DropDownColumnFilter LCDocType { get; }
				public SelectorColumnFilter LCRefNbr { get; }
				public PXNumberEditColumnFilter LCLineNbr { get; }
				public DropDownColumnFilter ReceiptType { get; }
				public SelectorColumnFilter ReceiptNbr { get; }
				public PXNumberEditColumnFilter ReceiptLineNbr { get; }
				public DropDownColumnFilter RelatedEntityType { get; }
				public InputColumnFilter RelatedDocNoteID { get; }
				public DropDownColumnFilter PPVDocType { get; }
				public SelectorColumnFilter PPVRefNbr { get; }
				public CheckBoxColumnFilter HasExpiredComplianceDocuments { get; }
				public DropDownColumnFilter TranType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
                
                public c_grid_header(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    SubcontractLineNbr = new PXTextEditColumnFilter(grid.Row.SubcontractLineNbr);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    BaseQty = new PXNumberEditColumnFilter(grid.Row.BaseQty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    CuryUnitCost = new PXNumberEditColumnFilter(grid.Row.CuryUnitCost);
                    ManualPrice = new CheckBoxColumnFilter(grid.Row.ManualPrice);
                    CuryLineAmt = new PXNumberEditColumnFilter(grid.Row.CuryLineAmt);
                    DiscPct = new PXNumberEditColumnFilter(grid.Row.DiscPct);
                    CuryDiscAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscAmt);
                    CuryDiscCost = new PXNumberEditColumnFilter(grid.Row.CuryDiscCost);
                    ManualDisc = new CheckBoxColumnFilter(grid.Row.ManualDisc);
                    DiscountID = new SelectorColumnFilter(grid.Row.DiscountID);
                    DiscountSequenceID = new PXTextEditColumnFilter(grid.Row.DiscountSequenceID);
                    PrepaymentPct = new PXNumberEditColumnFilter(grid.Row.PrepaymentPct);
                    CuryPrepaymentAmt = new PXNumberEditColumnFilter(grid.Row.CuryPrepaymentAmt);
                    RetainagePct = new PXNumberEditColumnFilter(grid.Row.RetainagePct);
                    CuryCashDiscBal = new PXNumberEditColumnFilter(grid.Row.CuryCashDiscBal);
                    CuryRetainageAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainageAmt);
                    CuryRetainageBal = new PXNumberEditColumnFilter(grid.Row.CuryRetainageBal);
                    CuryRetainedTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainedTaxAmt);
                    CuryTranAmt = new PXNumberEditColumnFilter(grid.Row.CuryTranAmt);
                    CuryTranBal = new PXNumberEditColumnFilter(grid.Row.CuryTranBal);
                    CuryOrigTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryOrigTaxAmt);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    AccountID_Account_description = new PXTextEditColumnFilter(grid.Row.AccountID_Account_description);
                    SubID = new SelectorColumnFilter(grid.Row.SubID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    NonBillable = new CheckBoxColumnFilter(grid.Row.NonBillable);
                    Box1099 = new SelectorColumnFilter(grid.Row.Box1099);
                    DeferredCode = new SelectorColumnFilter(grid.Row.DeferredCode);
                    DefScheduleID = new SelectorColumnFilter(grid.Row.DefScheduleID);
                    DRTermStartDate = new DateSelectorColumnFilter(grid.Row.DRTermStartDate);
                    DRTermEndDate = new DateSelectorColumnFilter(grid.Row.DRTermEndDate);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    Date = new DateSelectorColumnFilter(grid.Row.Date);
                    POOrderType = new DropDownColumnFilter(grid.Row.POOrderType);
                    PONbr = new SelectorColumnFilter(grid.Row.PONbr);
                    SubcontractNbr = new PXTextEditColumnFilter(grid.Row.SubcontractNbr);
                    POLineNbr = new SelectorColumnFilter(grid.Row.POLineNbr);
                    LCDocType = new DropDownColumnFilter(grid.Row.LCDocType);
                    LCRefNbr = new SelectorColumnFilter(grid.Row.LCRefNbr);
                    LCLineNbr = new PXNumberEditColumnFilter(grid.Row.LCLineNbr);
                    ReceiptType = new DropDownColumnFilter(grid.Row.ReceiptType);
                    ReceiptNbr = new SelectorColumnFilter(grid.Row.ReceiptNbr);
                    ReceiptLineNbr = new PXNumberEditColumnFilter(grid.Row.ReceiptLineNbr);
                    RelatedEntityType = new DropDownColumnFilter(grid.Row.RelatedEntityType);
                    RelatedDocNoteID = new InputColumnFilter(grid.Row.RelatedDocNoteID);
                    PPVDocType = new DropDownColumnFilter(grid.Row.PPVDocType);
                    PPVRefNbr = new SelectorColumnFilter(grid.Row.PPVRefNbr);
                    HasExpiredComplianceDocuments = new CheckBoxColumnFilter(grid.Row.HasExpiredComplianceDocuments);
                    TranType = new DropDownColumnFilter(grid.Row.TranType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                }
            }
        }
        
        public class c_transactions_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public Label CuryUnitCostLabel { get; }
			public CheckBox ManualPrice { get; }
			public Label ManualPriceLabel { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public Label CuryLineAmtLabel { get; }
			public Selector DiscountID { get; }
			public Label DiscountIDLabel { get; }
			public PXNumberEdit DiscPct { get; }
			public Label DiscPctLabel { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public Label CuryDiscAmtLabel { get; }
			public CheckBox ManualDisc { get; }
			public Label ManualDiscLabel { get; }
			public PXNumberEdit RetainagePct { get; }
			public Label RetainagePctLabel { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public Label CuryTranAmtLabel { get; }
			public PXNumberEdit CuryTranBal { get; }
			public Label CuryTranBalLabel { get; }
			public PXNumberEdit CuryOrigTaxAmt { get; }
			public Label CuryOrigTaxAmtLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector SubID { get; }
			public Label SubIDLabel { get; }
			public Selector Box1099 { get; }
			public Label Box1099Label { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector DeferredCode { get; }
			public Label DeferredCodeLabel { get; }
			public Selector DefScheduleID { get; }
			public Label DefScheduleIDLabel { get; }
			public DateSelector DRTermStartDate { get; }
			public Label DRTermStartDateLabel { get; }
			public DateSelector DRTermEndDate { get; }
			public Label DRTermEndDateLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
			public DropDown POOrderType { get; }
			public Label POOrderTypeLabel { get; }
			public Selector PONbr { get; }
			public Label PONbrLabel { get; }
			public DropDown ReceiptType { get; }
			public Label ReceiptTypeLabel { get; }
			public Selector ReceiptNbr { get; }
			public Label ReceiptNbrLabel { get; }
			public DropDown RelatedEntityType { get; }
			public Label RelatedEntityTypeLabel { get; }
			public Selector RelatedDocNoteID { get; }
			public Label RelatedDocNoteIDLabel { get; }
			public DropDown PPVDocType { get; }
			public Label PPVDocTypeLabel { get; }
			public Selector PPVRefNbr { get; }
			public Label PPVRefNbrLabel { get; }
			public DropDown LCDocType { get; }
			public Label LCDocTypeLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector LCRefNbr { get; }
			public Label LCRefNbrLabel { get; }
			public PXNumberEdit LCLineNbr { get; }
			public Label LCLineNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
			public DropDown TranType { get; }
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
                SubItemID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                UOM = new Selector("ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                CuryUnitCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryUnitCost", "Unit Cost", locator, null);
                CuryUnitCostLabel = new Label(CuryUnitCost);
                CuryUnitCost.DataField = "CuryUnitCost";
                ManualPrice = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Cost", locator, null);
                ManualPriceLabel = new Label(ManualPrice);
                ManualPrice.DataField = "ManualPrice";
                CuryLineAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryLineAmt", "Ext. Cost", locator, null);
                CuryLineAmtLabel = new Label(CuryLineAmt);
                CuryLineAmt.DataField = "CuryLineAmt";
                DiscountID = new Selector("ctl00_phG_tab_t0_grid_lv0_edDiscountCode", "Discount Code", locator, null);
                DiscountIDLabel = new Label(DiscountID);
                DiscountID.DataField = "DiscountID";
                DiscPct = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edDiscPct", "Discount Percent", locator, null);
                DiscPctLabel = new Label(DiscPct);
                DiscPct.DataField = "DiscPct";
                CuryDiscAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryDiscAmt", "Discount Amount", locator, null);
                CuryDiscAmtLabel = new Label(CuryDiscAmt);
                CuryDiscAmt.DataField = "CuryDiscAmt";
                ManualDisc = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkManualDisc", "Manual Discount", locator, null);
                ManualDiscLabel = new Label(ManualDisc);
                ManualDisc.DataField = "ManualDisc";
                RetainagePct = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edRetainagePct", "Retainage Percent", locator, null);
                RetainagePctLabel = new Label(RetainagePct);
                RetainagePct.DataField = "RetainagePct";
                CuryTranAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryTranAmt", "Amount", locator, null);
                CuryTranAmtLabel = new Label(CuryTranAmt);
                CuryTranAmt.DataField = "CuryTranAmt";
                CuryTranBal = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryTranBal", "Balance", locator, null);
                CuryTranBalLabel = new Label(CuryTranBal);
                CuryTranBal.DataField = "CuryTranBal";
                CuryOrigTaxAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryOrigTaxAmt", "Tax Amount", locator, null);
                CuryOrigTaxAmtLabel = new Label(CuryOrigTaxAmt);
                CuryOrigTaxAmt.DataField = "CuryOrigTaxAmt";
                AccountID = new Selector("ctl00_phG_tab_t0_grid_lv0_edAccountID", "Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                SubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubID", "Subaccount", locator, null);
                SubIDLabel = new Label(SubID);
                SubID.DataField = "SubID";
                Box1099 = new Selector("ctl00_phG_tab_t0_grid_lv0_edBox1099", "1099 Box", locator, null);
                Box1099Label = new Label(Box1099);
                Box1099.DataField = "Box1099";
                BranchID = new Selector("ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                DeferredCode = new Selector("ctl00_phG_tab_t0_grid_lv0_edDeferredCode", "Deferral Code", locator, null);
                DeferredCodeLabel = new Label(DeferredCode);
                DeferredCode.DataField = "DeferredCode";
                DefScheduleID = new Selector("ctl00_phG_tab_t0_grid_lv0_edDefScheduleID", "Original Deferral Schedule", locator, null);
                DefScheduleIDLabel = new Label(DefScheduleID);
                DefScheduleID.DataField = "DefScheduleID";
                DRTermStartDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edDRTermStartDate", "Term Start Date", locator, null);
                DRTermStartDateLabel = new Label(DRTermStartDate);
                DRTermStartDate.DataField = "DRTermStartDate";
                DRTermEndDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edDRTermEndDate", "Term End Date", locator, null);
                DRTermEndDateLabel = new Label(DRTermEndDate);
                DRTermEndDate.DataField = "DRTermEndDate";
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                ProjectID = new Selector("ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                TaskID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                CostCodeID = new Selector("ctl00_phG_tab_t0_grid_lv0_edCostCode", "Cost Code", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                POOrderType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edPOOrderType", "PO Type", locator, null);
                POOrderTypeLabel = new Label(POOrderType);
                POOrderType.DataField = "POOrderType";
                POOrderType.Items.Add("RO", "Normal");
                POOrderType.Items.Add("DP", "Drop-Ship");
                POOrderType.Items.Add("PD", "Project Drop-Ship");
                POOrderType.Items.Add("BL", "Blanket");
                POOrderType.Items.Add("SB", "Standard");
                PONbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edPONbr", "PO Number", locator, null);
                PONbrLabel = new Label(PONbr);
                PONbr.DataField = "PONbr";
                ReceiptType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edReceiptType", "PO Receipt Type", locator, null);
                ReceiptTypeLabel = new Label(ReceiptType);
                ReceiptType.DataField = "ReceiptType";
                ReceiptType.Items.Add("RT", "Receipt");
                ReceiptType.Items.Add("RN", "Return");
                ReceiptType.Items.Add("RX", "Transfer Receipt");
                ReceiptNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edReceiptNbr", "PO Receipt Nbr.", locator, null);
                ReceiptNbrLabel = new Label(ReceiptNbr);
                ReceiptNbr.DataField = "ReceiptNbr";
                RelatedEntityType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edRelatedEntityType", "Related Svc. Doc. Type", locator, null);
                RelatedEntityTypeLabel = new Label(RelatedEntityType);
                RelatedEntityType.DataField = "RelatedEntityType";
                RelatedDocNoteID = new Selector("ctl00_phG_tab_t0_grid_lv0_edRelatedDocNoteID", "Related Svc. Doc. Nbr.", locator, null);
                RelatedDocNoteIDLabel = new Label(RelatedDocNoteID);
                RelatedDocNoteID.DataField = "RelatedDocNoteID";
                PPVDocType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edPPVDocType", "PPV Doc. Type", locator, null);
                PPVDocTypeLabel = new Label(PPVDocType);
                PPVDocType.DataField = "PPVDocType";
                PPVDocType.Items.Add("I", "Issue");
                PPVDocType.Items.Add("R", "Receipt");
                PPVDocType.Items.Add("T", "Transfer");
                PPVDocType.Items.Add("A", "Adjustment");
                PPVDocType.Items.Add("P", "Production");
                PPVDocType.Items.Add("D", "Disassembly");
                PPVRefNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edPPVRefNbr", "PPV Ref. Nbr.", locator, null);
                PPVRefNbrLabel = new Label(PPVRefNbr);
                PPVRefNbr.DataField = "PPVRefNbr";
                LCDocType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edLCDocType", "LC Type", locator, null);
                LCDocTypeLabel = new Label(LCDocType);
                LCDocType.DataField = "LCDocType";
                LCDocType.Items.Add("L", "Landed Cost");
                LCDocType.Items.Add("C", "Correction");
                LCDocType.Items.Add("R", "Reversal");
                TranDesc = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Transaction Descr.", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                LCRefNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edLCRefNbr", "LC Number", locator, null);
                LCRefNbrLabel = new Label(LCRefNbr);
                LCRefNbr.DataField = "LCRefNbr";
                LCLineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edLCLineNbr", "LC Line", locator, null);
                LCLineNbrLabel = new Label(LCLineNbr);
                LCLineNbr.DataField = "LCLineNbr";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t0_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t0_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                TranType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edTranType", "Tran Type", locator, null);
                TranTypeLabel = new Label(TranType);
                TranType.DataField = "TranType";
                TranType.Items.Add("INV", "Bill");
                TranType.Items.Add("ACR", "Credit Adj.");
                TranType.Items.Add("ADR", "Debit Adj.");
                TranType.Items.Add("CHK", "Check");
                TranType.Items.Add("VCK", "Voided Check");
                TranType.Items.Add("PPM", "Prepayment");
                TranType.Items.Add("REF", "Vendor Refund");
                TranType.Items.Add("VRF", "Voided Refund");
                TranType.Items.Add("QCK", "Quick Check");
                TranType.Items.Add("VQC", "Void Quick Check");
                TranType.Items.Add("PPR", "Prepayment Req.");
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
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void DefScheduleIDEdit()
            {
                Buttons.DefScheduleIDEdit.Click();
            }
            
            public virtual void RelatedDocNoteIDEdit()
            {
                Buttons.RelatedDocNoteIDEdit.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
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
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void Upload()
            {
                Buttons.Upload.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
			public Button DiscountIDEdit { get; }
			public Button DefScheduleIDEdit { get; }
			public Button RelatedDocNoteIDEdit { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button Upload { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edInventoryID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "InventoryIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edDiscountCode\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DiscountIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    DiscountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefScheduleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edDefScheduleID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "DefScheduleIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    DefScheduleIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    RelatedDocNoteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edRelatedDocNoteID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "RelatedDocNoteIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    RelatedDocNoteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_grid_lv0");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_grid_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_grid_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_grid_lv0");
                    First = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_grid_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_grid_lv0");
                    Next = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_grid_lv0");
                    Last = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_grid_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_grid_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_grid_lv0");
                    Upload = new Button("ctl00_phG_tab_t0_grid_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t0_grid_lv0");
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_grid1");
                DataMemberName = "Taxes";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_grid1_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector TaxID { get; }
			public PXNumberEdit TaxRate { get; }
			public PXNumberEdit CuryTaxableAmt { get; }
			public Selector TaxUOM { get; }
			public PXNumberEdit TaxableQty { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public PXNumberEdit CuryRetainedTaxableAmt { get; }
			public PXNumberEdit CuryRetainedTaxAmt { get; }
			public PXNumberEdit NonDeductibleTaxRate { get; }
			public PXNumberEdit CuryExpenseAmt { get; }
			public DropDown Tax__TaxType { get; }
			public CheckBox Tax__PendingTax { get; }
			public CheckBox Tax__ReverseTax { get; }
			public CheckBox Tax__ExemptTax { get; }
			public CheckBox Tax__StatisticalTax { get; }
			public PXNumberEdit CuryDiscountedTaxableAmt { get; }
			public PXNumberEdit CuryDiscountedPrice { get; }
			public PXTextEdit Module { get; }
			public PXTextEdit TranType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_taxes_grid1 grid) : 
                        base(grid)
                {
                    TaxID = new Selector("_ctl00_phG_tab_t2_grid1_lv0_es", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    TaxRate = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Tax Rate", grid.Locator, "TaxRate");
                    TaxRate.DataField = "TaxRate";
                    CuryTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Taxable Amount", grid.Locator, "CuryTaxableAmt");
                    CuryTaxableAmt.DataField = "CuryTaxableAmt";
                    TaxUOM = new Selector("_ctl00_phG_tab_t2_grid1_lv0_es", "Tax UOM", grid.Locator, "TaxUOM");
                    TaxUOM.DataField = "TaxUOM";
                    TaxableQty = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Taxable Qty.", grid.Locator, "TaxableQty");
                    TaxableQty.DataField = "TaxableQty";
                    CuryTaxAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Tax Amount", grid.Locator, "CuryTaxAmt");
                    CuryTaxAmt.DataField = "CuryTaxAmt";
                    CuryRetainedTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Retained Taxable Amount", grid.Locator, "CuryRetainedTaxableAmt");
                    CuryRetainedTaxableAmt.DataField = "CuryRetainedTaxableAmt";
                    CuryRetainedTaxAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Retained Tax", grid.Locator, "CuryRetainedTaxAmt");
                    CuryRetainedTaxAmt.DataField = "CuryRetainedTaxAmt";
                    NonDeductibleTaxRate = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Deductible Tax Rate", grid.Locator, "NonDeductibleTaxRate");
                    NonDeductibleTaxRate.DataField = "NonDeductibleTaxRate";
                    CuryExpenseAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Expense Amount", grid.Locator, "CuryExpenseAmt");
                    CuryExpenseAmt.DataField = "CuryExpenseAmt";
                    Tax__TaxType = new DropDown("_ctl00_phG_tab_t2_grid1_lv0_ec", "Tax Type", grid.Locator, "Tax__TaxType");
                    Tax__TaxType.DataField = "Tax__TaxType";
                    Tax__TaxType.Items.Add("S", "Sales");
                    Tax__TaxType.Items.Add("P", "Use");
                    Tax__TaxType.Items.Add("V", "VAT");
                    Tax__TaxType.Items.Add("W", "Withholding");
                    Tax__TaxType.Items.Add("Q", "Per-Unit/Specific");
                    Tax__PendingTax = new CheckBox("ctl00_phG_tab_t2_grid1", "Pending VAT", grid.Locator, "Tax__PendingTax");
                    Tax__PendingTax.DataField = "Tax__PendingTax";
                    Tax__ReverseTax = new CheckBox("ctl00_phG_tab_t2_grid1", "Reverse VAT", grid.Locator, "Tax__ReverseTax");
                    Tax__ReverseTax.DataField = "Tax__ReverseTax";
                    Tax__ExemptTax = new CheckBox("ctl00_phG_tab_t2_grid1", "Include in VAT Exempt Total", grid.Locator, "Tax__ExemptTax");
                    Tax__ExemptTax.DataField = "Tax__ExemptTax";
                    Tax__StatisticalTax = new CheckBox("ctl00_phG_tab_t2_grid1", "Statistical VAT", grid.Locator, "Tax__StatisticalTax");
                    Tax__StatisticalTax.DataField = "Tax__StatisticalTax";
                    CuryDiscountedTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Discounted Taxable Amount", grid.Locator, "CuryDiscountedTaxableAmt");
                    CuryDiscountedTaxableAmt.DataField = "CuryDiscountedTaxableAmt";
                    CuryDiscountedPrice = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "Tax on Discounted Price", grid.Locator, "CuryDiscountedPrice");
                    CuryDiscountedPrice.DataField = "CuryDiscountedPrice";
                    Module = new PXTextEdit("ctl00_phG_tab_t2_grid1_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    TranType = new PXTextEdit("ctl00_phG_tab_t2_grid1_ei", "Tran. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t2_grid1_ei", "Ref. Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t2_grid1_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter TaxID { get; }
				public PXNumberEditColumnFilter TaxRate { get; }
				public PXNumberEditColumnFilter CuryTaxableAmt { get; }
				public SelectorColumnFilter TaxUOM { get; }
				public PXNumberEditColumnFilter TaxableQty { get; }
				public PXNumberEditColumnFilter CuryTaxAmt { get; }
				public PXNumberEditColumnFilter CuryRetainedTaxableAmt { get; }
				public PXNumberEditColumnFilter CuryRetainedTaxAmt { get; }
				public PXNumberEditColumnFilter NonDeductibleTaxRate { get; }
				public PXNumberEditColumnFilter CuryExpenseAmt { get; }
				public DropDownColumnFilter Tax__TaxType { get; }
				public CheckBoxColumnFilter Tax__PendingTax { get; }
				public CheckBoxColumnFilter Tax__ReverseTax { get; }
				public CheckBoxColumnFilter Tax__ExemptTax { get; }
				public CheckBoxColumnFilter Tax__StatisticalTax { get; }
				public PXNumberEditColumnFilter CuryDiscountedTaxableAmt { get; }
				public PXNumberEditColumnFilter CuryDiscountedPrice { get; }
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
                    TaxUOM = new SelectorColumnFilter(grid.Row.TaxUOM);
                    TaxableQty = new PXNumberEditColumnFilter(grid.Row.TaxableQty);
                    CuryTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxAmt);
                    CuryRetainedTaxableAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainedTaxableAmt);
                    CuryRetainedTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainedTaxAmt);
                    NonDeductibleTaxRate = new PXNumberEditColumnFilter(grid.Row.NonDeductibleTaxRate);
                    CuryExpenseAmt = new PXNumberEditColumnFilter(grid.Row.CuryExpenseAmt);
                    Tax__TaxType = new DropDownColumnFilter(grid.Row.Tax__TaxType);
                    Tax__PendingTax = new CheckBoxColumnFilter(grid.Row.Tax__PendingTax);
                    Tax__ReverseTax = new CheckBoxColumnFilter(grid.Row.Tax__ReverseTax);
                    Tax__ExemptTax = new CheckBoxColumnFilter(grid.Row.Tax__ExemptTax);
                    Tax__StatisticalTax = new CheckBoxColumnFilter(grid.Row.Tax__StatisticalTax);
                    CuryDiscountedTaxableAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountedTaxableAmt);
                    CuryDiscountedPrice = new PXNumberEditColumnFilter(grid.Row.CuryDiscountedPrice);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
                    TranType = new PXTextEditColumnFilter(grid.Row.TranType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_taxes_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_taxes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t2_grid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t2_grid1_lv0_ec", "Ec", locator, null);
                DataMemberName = "Taxes";
            }
        }
        
        public class c_adjustments_detgrid : Grid<c_adjustments_detgrid.c_grid_row, c_adjustments_detgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_adjustments_detgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_detgrid");
                DataMemberName = "Adjustments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_detgrid_fe_gf", "FilterForm");
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
            
            public virtual void AutoApply()
            {
                ToolBar.AutoApply.Click();
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
			public ToolBarButtonGrid AutoApply { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    AutoApply = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_at_tlb div[data-cmd=\'AutoApply\']", "Auto Apply", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_detgrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector AdjgBranchID { get; }
			public DropDown DisplayDocType { get; }
			public Selector DisplayRefNbr { get; }
			public PXNumberEdit CuryAdjdAmt { get; }
			public PXNumberEdit CuryAdjdPPDAmt { get; }
			public DateSelector DisplayDocDate { get; }
			public PXNumberEdit CuryDocBal { get; }
			public PXTextEdit DisplayDocDesc { get; }
			public Selector DisplayCuryID { get; }
			public Selector DisplayFinPeriodID { get; }
			public PXTextEdit APPayment__ExtRefNbr { get; }
			public PXTextEdit AdjdDocType { get; }
			public PXTextEdit AdjdRefNbr { get; }
			public DropDown DisplayStatus { get; }
			public DropDown AdjgDocType { get; }
			public Selector AdjgRefNbr { get; }
			public Selector AdjdLineNbr { get; }
			public PXNumberEdit AdjNbr { get; }
                
                public c_grid_row(c_adjustments_detgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    AdjgBranchID = new Selector("_ctl00_phG_tab_t6_detgrid_lv0_es", "Branch", grid.Locator, "AdjgBranchID");
                    AdjgBranchID.DataField = "AdjgBranchID";
                    DisplayDocType = new DropDown("_ctl00_phG_tab_t6_detgrid_lv0_ec", "Doc. Type", grid.Locator, "DisplayDocType");
                    DisplayDocType.DataField = "DisplayDocType";
                    DisplayDocType.Items.Add("INV", "Bill");
                    DisplayDocType.Items.Add("ACR", "Credit Adj.");
                    DisplayDocType.Items.Add("ADR", "Debit Adj.");
                    DisplayDocType.Items.Add("CHK", "Check");
                    DisplayDocType.Items.Add("VCK", "Voided Check");
                    DisplayDocType.Items.Add("PPM", "Prepayment");
                    DisplayDocType.Items.Add("REF", "Vendor Refund");
                    DisplayDocType.Items.Add("VRF", "Voided Refund");
                    DisplayDocType.Items.Add("QCK", "Quick Check");
                    DisplayDocType.Items.Add("VQC", "Void Quick Check");
                    DisplayDocType.Items.Add("PPR", "Prepayment Req.");
                    DisplayRefNbr = new Selector("_ctl00_phG_tab_t6_detgrid_lv0_es", "Reference Nbr.", grid.Locator, "DisplayRefNbr");
                    DisplayRefNbr.DataField = "DisplayRefNbr";
                    CuryAdjdAmt = new PXNumberEdit("_ctl00_phG_tab_t6_detgrid_lv0_edCuryAdjdAmt", "Amount Paid", grid.Locator, "CuryAdjdAmt");
                    CuryAdjdAmt.DataField = "CuryAdjdAmt";
                    CuryAdjdPPDAmt = new PXNumberEdit("ctl00_phG_tab_t6_detgrid_en", "Cash Discount Taken", grid.Locator, "CuryAdjdPPDAmt");
                    CuryAdjdPPDAmt.DataField = "CuryAdjdPPDAmt";
                    DisplayDocDate = new DateSelector("_ctl00_phG_tab_t6_detgrid_lv0_ed7", "Date", grid.Locator, "DisplayDocDate");
                    DisplayDocDate.DataField = "DisplayDocDate";
                    CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t6_detgrid_en", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    DisplayDocDesc = new PXTextEdit("ctl00_phG_tab_t6_detgrid_ei", "Description", grid.Locator, "DisplayDocDesc");
                    DisplayDocDesc.DataField = "DisplayDocDesc";
                    DisplayCuryID = new Selector("_ctl00_phG_tab_t6_detgrid_lv0_es", "Currency", grid.Locator, "DisplayCuryID");
                    DisplayCuryID.DataField = "DisplayCuryID";
                    DisplayFinPeriodID = new Selector("_ctl00_phG_tab_t6_detgrid_lv0_es", "Post Period", grid.Locator, "DisplayFinPeriodID");
                    DisplayFinPeriodID.DataField = "DisplayFinPeriodID";
                    APPayment__ExtRefNbr = new PXTextEdit("ctl00_phG_tab_t6_detgrid_ei", "Payment Ref.", grid.Locator, "APPayment__ExtRefNbr");
                    APPayment__ExtRefNbr.DataField = "APPayment__ExtRefNbr";
                    AdjdDocType = new PXTextEdit("ctl00_phG_tab_t6_detgrid_ei", "Document Type", grid.Locator, "AdjdDocType");
                    AdjdDocType.DataField = "AdjdDocType";
                    AdjdRefNbr = new PXTextEdit("ctl00_phG_tab_t6_detgrid_ei", "Reference Nbr.", grid.Locator, "AdjdRefNbr");
                    AdjdRefNbr.DataField = "AdjdRefNbr";
                    DisplayStatus = new DropDown("_ctl00_phG_tab_t6_detgrid_lv0_ec", "Status", grid.Locator, "DisplayStatus");
                    DisplayStatus.DataField = "DisplayStatus";
                    DisplayStatus.Items.Add("H", "On Hold");
                    DisplayStatus.Items.Add("B", "Balanced");
                    DisplayStatus.Items.Add("V", "Voided");
                    DisplayStatus.Items.Add("S", "Scheduled");
                    DisplayStatus.Items.Add("N", "Open");
                    DisplayStatus.Items.Add("C", "Closed");
                    DisplayStatus.Items.Add("P", "Printed");
                    DisplayStatus.Items.Add("K", "Pre-Released");
                    DisplayStatus.Items.Add("E", "Pending Approval");
                    DisplayStatus.Items.Add("R", "Rejected");
                    DisplayStatus.Items.Add("Z", "Reserved");
                    DisplayStatus.Items.Add("G", "Pending Print");
                    DisplayStatus.Items.Add("X", "Under Reclassification");
                    AdjgDocType = new DropDown("_ctl00_phG_tab_t6_detgrid_lv0_ec", "Doc. Type", grid.Locator, "AdjgDocType");
                    AdjgDocType.DataField = "AdjgDocType";
                    AdjgDocType.Items.Add("CHK", "Check");
                    AdjgDocType.Items.Add("ADR", "Debit Adj.");
                    AdjgDocType.Items.Add("PPM", "Prepayment");
                    AdjgDocType.Items.Add("REF", "Vendor Refund");
                    AdjgDocType.Items.Add("VRF", "Voided Refund");
                    AdjgDocType.Items.Add("VCK", "Voided Check");
                    AdjgRefNbr = new Selector("_ctl00_phG_tab_t6_detgrid_lv0_es", "Reference Nbr.", grid.Locator, "AdjgRefNbr");
                    AdjgRefNbr.DataField = "AdjgRefNbr";
                    AdjdLineNbr = new Selector("_ctl00_phG_tab_t6_detgrid_lv0_es", "Line Nbr.", grid.Locator, "AdjdLineNbr");
                    AdjdLineNbr.DataField = "AdjdLineNbr";
                    AdjNbr = new PXNumberEdit("ctl00_phG_tab_t6_detgrid_en", "Adjustment Nbr.", grid.Locator, "AdjNbr");
                    AdjNbr.DataField = "AdjNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter AdjgBranchID { get; }
				public DropDownColumnFilter DisplayDocType { get; }
				public SelectorColumnFilter DisplayRefNbr { get; }
				public PXNumberEditColumnFilter CuryAdjdAmt { get; }
				public PXNumberEditColumnFilter CuryAdjdPPDAmt { get; }
				public DateSelectorColumnFilter DisplayDocDate { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public PXTextEditColumnFilter DisplayDocDesc { get; }
				public SelectorColumnFilter DisplayCuryID { get; }
				public SelectorColumnFilter DisplayFinPeriodID { get; }
				public PXTextEditColumnFilter APPayment__ExtRefNbr { get; }
				public PXTextEditColumnFilter AdjdDocType { get; }
				public PXTextEditColumnFilter AdjdRefNbr { get; }
				public DropDownColumnFilter DisplayStatus { get; }
				public DropDownColumnFilter AdjgDocType { get; }
				public SelectorColumnFilter AdjgRefNbr { get; }
				public SelectorColumnFilter AdjdLineNbr { get; }
				public PXNumberEditColumnFilter AdjNbr { get; }
                
                public c_grid_header(c_adjustments_detgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    AdjgBranchID = new SelectorColumnFilter(grid.Row.AdjgBranchID);
                    DisplayDocType = new DropDownColumnFilter(grid.Row.DisplayDocType);
                    DisplayRefNbr = new SelectorColumnFilter(grid.Row.DisplayRefNbr);
                    CuryAdjdAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjdAmt);
                    CuryAdjdPPDAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjdPPDAmt);
                    DisplayDocDate = new DateSelectorColumnFilter(grid.Row.DisplayDocDate);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    DisplayDocDesc = new PXTextEditColumnFilter(grid.Row.DisplayDocDesc);
                    DisplayCuryID = new SelectorColumnFilter(grid.Row.DisplayCuryID);
                    DisplayFinPeriodID = new SelectorColumnFilter(grid.Row.DisplayFinPeriodID);
                    APPayment__ExtRefNbr = new PXTextEditColumnFilter(grid.Row.APPayment__ExtRefNbr);
                    AdjdDocType = new PXTextEditColumnFilter(grid.Row.AdjdDocType);
                    AdjdRefNbr = new PXTextEditColumnFilter(grid.Row.AdjdRefNbr);
                    DisplayStatus = new DropDownColumnFilter(grid.Row.DisplayStatus);
                    AdjgDocType = new DropDownColumnFilter(grid.Row.AdjgDocType);
                    AdjgRefNbr = new SelectorColumnFilter(grid.Row.AdjgRefNbr);
                    AdjdLineNbr = new SelectorColumnFilter(grid.Row.AdjdLineNbr);
                    AdjNbr = new PXNumberEditColumnFilter(grid.Row.AdjNbr);
                }
            }
        }
        
        public class c_adjustments_lv0 : Container
        {
            
			public PXNumberEdit CuryAdjdAmt { get; }
			public Label CuryAdjdAmtLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_adjustments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CuryAdjdAmt = new PXNumberEdit("ctl00_phG_tab_t6_detgrid_lv0_edCuryAdjdAmt", "Amount Paid", locator, null);
                CuryAdjdAmtLabel = new Label(CuryAdjdAmt);
                CuryAdjdAmt.DataField = "CuryAdjdAmt";
                Es = new Selector("ctl00_phG_tab_t6_detgrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t6_detgrid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t6_detgrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "Adjustments";
            }
        }
        
        public class c_discountdetails_formdiscountdetail : Grid<c_discountdetails_formdiscountdetail.c_grid_row, c_discountdetails_formdiscountdetail.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_discountdetails_formdiscountdetail(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_formDiscountDetail");
                DataMemberName = "DiscountDetails";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_formDiscountDetail_fe_gf", "FilterForm");
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
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void DiscountSequenceIDEdit()
            {
                Buttons.DiscountSequenceIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formDiscountDetail_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DiscountSequenceIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t4_formDiscountDetail");
                    DiscountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t4_formDiscountDetail");
                    DiscountSequenceIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox SkipDiscount { get; }
			public Selector DiscountID { get; }
			public Selector DiscountSequenceID { get; }
			public DropDown Type { get; }
			public CheckBox IsManual { get; }
			public PXNumberEdit CuryDiscountableAmt { get; }
			public PXNumberEdit DiscountableQty { get; }
			public PXNumberEdit CuryDiscountAmt { get; }
			public PXNumberEdit CuryRetainedDiscountAmt { get; }
			public PXNumberEdit DiscountPct { get; }
			public PXTextEdit ExtDiscCode { get; }
			public PXTextEdit Description { get; }
			public PXTextEdit DocType { get; }
			public PXNumberEdit RecordID { get; }
			public PXTextEdit RefNbr { get; }
                
                public c_grid_row(c_discountdetails_formdiscountdetail grid) : 
                        base(grid)
                {
                    SkipDiscount = new CheckBox("_ctl00_phG_tab_t4_formDiscountDetail_lv0_chkSkipDiscount", "Skip Discount", grid.Locator, "SkipDiscount");
                    SkipDiscount.DataField = "SkipDiscount";
                    DiscountID = new Selector("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountID", "Discount Code", grid.Locator, "DiscountID");
                    DiscountID.DataField = "DiscountID";
                    DiscountSequenceID = new Selector("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountSequenceID", "Sequence ID", grid.Locator, "DiscountSequenceID");
                    DiscountSequenceID.DataField = "DiscountSequenceID";
                    Type = new DropDown("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edType", "Type", grid.Locator, "Type");
                    Type.DataField = "Type";
                    Type.Items.Add("L", "Line");
                    Type.Items.Add("G", "Group");
                    Type.Items.Add("D", "Document");
                    Type.Items.Add("B", "External Document");
                    IsManual = new CheckBox("_ctl00_phG_tab_t4_formDiscountDetail_lv0_chkIsManual", "Manual Discount", grid.Locator, "IsManual");
                    IsManual.DataField = "IsManual";
                    CuryDiscountableAmt = new PXNumberEdit("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edCuryDiscountableAmt", "Discountable Amt.", grid.Locator, "CuryDiscountableAmt");
                    CuryDiscountableAmt.DataField = "CuryDiscountableAmt";
                    DiscountableQty = new PXNumberEdit("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountableQty", "Discountable Qty.", grid.Locator, "DiscountableQty");
                    DiscountableQty.DataField = "DiscountableQty";
                    CuryDiscountAmt = new PXNumberEdit("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edCuryDiscountAmt", "Discount Amt.", grid.Locator, "CuryDiscountAmt");
                    CuryDiscountAmt.DataField = "CuryDiscountAmt";
                    CuryRetainedDiscountAmt = new PXNumberEdit("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edCuryRetainedDiscountAmt", "Retained Discount", grid.Locator, "CuryRetainedDiscountAmt");
                    CuryRetainedDiscountAmt.DataField = "CuryRetainedDiscountAmt";
                    DiscountPct = new PXNumberEdit("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountPct", "Discount Percent", grid.Locator, "DiscountPct");
                    DiscountPct.DataField = "DiscountPct";
                    ExtDiscCode = new PXTextEdit("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edExtDiscCode", "External Discount Code", grid.Locator, "ExtDiscCode");
                    ExtDiscCode.DataField = "ExtDiscCode";
                    Description = new PXTextEdit("_ctl00_phG_tab_t4_formDiscountDetail_lv0_edDescription", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    DocType = new PXTextEdit("ctl00_phG_tab_t4_formDiscountDetail_ei", "Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t4_formDiscountDetail_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t4_formDiscountDetail_em", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter SkipDiscount { get; }
				public SelectorColumnFilter DiscountID { get; }
				public SelectorColumnFilter DiscountSequenceID { get; }
				public DropDownColumnFilter Type { get; }
				public CheckBoxColumnFilter IsManual { get; }
				public PXNumberEditColumnFilter CuryDiscountableAmt { get; }
				public PXNumberEditColumnFilter DiscountableQty { get; }
				public PXNumberEditColumnFilter CuryDiscountAmt { get; }
				public PXNumberEditColumnFilter CuryRetainedDiscountAmt { get; }
				public PXNumberEditColumnFilter DiscountPct { get; }
				public PXTextEditColumnFilter ExtDiscCode { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXNumberEditColumnFilter RecordID { get; }
				public PXTextEditColumnFilter RefNbr { get; }
                
                public c_grid_header(c_discountdetails_formdiscountdetail grid) : 
                        base(grid)
                {
                    SkipDiscount = new CheckBoxColumnFilter(grid.Row.SkipDiscount);
                    DiscountID = new SelectorColumnFilter(grid.Row.DiscountID);
                    DiscountSequenceID = new SelectorColumnFilter(grid.Row.DiscountSequenceID);
                    Type = new DropDownColumnFilter(grid.Row.Type);
                    IsManual = new CheckBoxColumnFilter(grid.Row.IsManual);
                    CuryDiscountableAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountableAmt);
                    DiscountableQty = new PXNumberEditColumnFilter(grid.Row.DiscountableQty);
                    CuryDiscountAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountAmt);
                    CuryRetainedDiscountAmt = new PXNumberEditColumnFilter(grid.Row.CuryRetainedDiscountAmt);
                    DiscountPct = new PXNumberEditColumnFilter(grid.Row.DiscountPct);
                    ExtDiscCode = new PXTextEditColumnFilter(grid.Row.ExtDiscCode);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                }
            }
        }
        
        public class c_discountdetails_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox SkipDiscount { get; }
			public Label SkipDiscountLabel { get; }
			public Selector DiscountID { get; }
			public Label DiscountIDLabel { get; }
			public DropDown Type { get; }
			public Label TypeLabel { get; }
			public CheckBox IsManual { get; }
			public Label IsManualLabel { get; }
			public Selector DiscountSequenceID { get; }
			public Label DiscountSequenceIDLabel { get; }
			public PXNumberEdit CuryDiscountableAmt { get; }
			public Label CuryDiscountableAmtLabel { get; }
			public PXNumberEdit DiscountableQty { get; }
			public Label DiscountableQtyLabel { get; }
			public PXNumberEdit CuryDiscountAmt { get; }
			public Label CuryDiscountAmtLabel { get; }
			public PXNumberEdit CuryRetainedDiscountAmt { get; }
			public Label CuryRetainedDiscountAmtLabel { get; }
			public PXNumberEdit DiscountPct { get; }
			public Label DiscountPctLabel { get; }
			public PXTextEdit ExtDiscCode { get; }
			public Label ExtDiscCodeLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_discountdetails_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SkipDiscount = new CheckBox("ctl00_phG_tab_t4_formDiscountDetail_lv0_chkSkipDiscount", "Skip Discount", locator, null);
                SkipDiscountLabel = new Label(SkipDiscount);
                SkipDiscount.DataField = "SkipDiscount";
                DiscountID = new Selector("ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountID", "Discount Code", locator, null);
                DiscountIDLabel = new Label(DiscountID);
                DiscountID.DataField = "DiscountID";
                Type = new DropDown("ctl00_phG_tab_t4_formDiscountDetail_lv0_edType", "Type", locator, null);
                TypeLabel = new Label(Type);
                Type.DataField = "Type";
                Type.Items.Add("L", "Line");
                Type.Items.Add("G", "Group");
                Type.Items.Add("D", "Document");
                Type.Items.Add("B", "External Document");
                IsManual = new CheckBox("ctl00_phG_tab_t4_formDiscountDetail_lv0_chkIsManual", "Manual Discount", locator, null);
                IsManualLabel = new Label(IsManual);
                IsManual.DataField = "IsManual";
                DiscountSequenceID = new Selector("ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountSequenceID", "Sequence ID", locator, null);
                DiscountSequenceIDLabel = new Label(DiscountSequenceID);
                DiscountSequenceID.DataField = "DiscountSequenceID";
                CuryDiscountableAmt = new PXNumberEdit("ctl00_phG_tab_t4_formDiscountDetail_lv0_edCuryDiscountableAmt", "Discountable Amt.", locator, null);
                CuryDiscountableAmtLabel = new Label(CuryDiscountableAmt);
                CuryDiscountableAmt.DataField = "CuryDiscountableAmt";
                DiscountableQty = new PXNumberEdit("ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountableQty", "Discountable Qty.", locator, null);
                DiscountableQtyLabel = new Label(DiscountableQty);
                DiscountableQty.DataField = "DiscountableQty";
                CuryDiscountAmt = new PXNumberEdit("ctl00_phG_tab_t4_formDiscountDetail_lv0_edCuryDiscountAmt", "Discount Amt.", locator, null);
                CuryDiscountAmtLabel = new Label(CuryDiscountAmt);
                CuryDiscountAmt.DataField = "CuryDiscountAmt";
                CuryRetainedDiscountAmt = new PXNumberEdit("ctl00_phG_tab_t4_formDiscountDetail_lv0_edCuryRetainedDiscountAmt", "Retained Discount", locator, null);
                CuryRetainedDiscountAmtLabel = new Label(CuryRetainedDiscountAmt);
                CuryRetainedDiscountAmt.DataField = "CuryRetainedDiscountAmt";
                DiscountPct = new PXNumberEdit("ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountPct", "Discount Percent", locator, null);
                DiscountPctLabel = new Label(DiscountPct);
                DiscountPct.DataField = "DiscountPct";
                ExtDiscCode = new PXTextEdit("ctl00_phG_tab_t4_formDiscountDetail_lv0_edExtDiscCode", "External Discount Code", locator, null);
                ExtDiscCodeLabel = new Label(ExtDiscCode);
                ExtDiscCode.DataField = "ExtDiscCode";
                Description = new PXTextEdit("ctl00_phG_tab_t4_formDiscountDetail_lv0_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                Es = new Selector("ctl00_phG_tab_t4_formDiscountDetail_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "DiscountDetails";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void DiscountSequenceIDEdit()
            {
                Buttons.DiscountSequenceIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DiscountSequenceIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t4_formDiscountDetail_lv0");
                    DiscountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_formDiscountDetail_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t4_formDiscountDetail_lv0");
                    DiscountSequenceIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_recalcdiscountsfilter_formrecalcdiscounts : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown RecalcTarget { get; }
			public Label RecalcTargetLabel { get; }
			public CheckBox RecalcUnitPrices { get; }
			public Label RecalcUnitPricesLabel { get; }
			public CheckBox OverrideManualPrices { get; }
			public Label OverrideManualPricesLabel { get; }
			public CheckBox RecalcDiscounts { get; }
			public Label RecalcDiscountsLabel { get; }
			public CheckBox OverrideManualDiscounts { get; }
			public Label OverrideManualDiscountsLabel { get; }
			public CheckBox OverrideManualDocGroupDiscounts { get; }
			public Label OverrideManualDocGroupDiscountsLabel { get; }
            
            public c_recalcdiscountsfilter_formrecalcdiscounts(string locator, string name) : 
                    base(locator, name)
            {
                RecalcTarget = new DropDown("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_edRecalcTerget", "Recalc Target", locator, null);
                RecalcTargetLabel = new Label(RecalcTarget);
                RecalcTarget.DataField = "RecalcTarget";
                RecalcUnitPrices = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkRecalcUnitPrices", "Recalc Unit Prices", locator, null);
                RecalcUnitPricesLabel = new Label(RecalcUnitPrices);
                RecalcUnitPrices.DataField = "RecalcUnitPrices";
                OverrideManualPrices = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkOverrideManualPrices", "Override Manual Prices", locator, null);
                OverrideManualPricesLabel = new Label(OverrideManualPrices);
                OverrideManualPrices.DataField = "OverrideManualPrices";
                RecalcDiscounts = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkRecalcDiscounts", "Recalc Discounts", locator, null);
                RecalcDiscountsLabel = new Label(RecalcDiscounts);
                RecalcDiscounts.DataField = "RecalcDiscounts";
                OverrideManualDiscounts = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkOverrideManualDiscounts", "Override Manual Discounts", locator, null);
                OverrideManualDiscountsLabel = new Label(OverrideManualDiscounts);
                OverrideManualDiscounts.DataField = "OverrideManualDiscounts";
                OverrideManualDocGroupDiscounts = new CheckBox("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts_chkOverrideManualDocGroupDisco" +
                        "unts", "Override Manual Doc Group Discounts", locator, null);
                OverrideManualDocGroupDiscountsLabel = new Label(OverrideManualDocGroupDiscounts);
                OverrideManualDocGroupDiscounts.DataField = "OverrideManualDocGroupDiscounts";
                DataMemberName = "recalcdiscountsfilter";
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
                    Ok = new Button("ctl00_phG_PanelRecalcDiscounts_PXButton13", "OK", "ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts");
                }
            }
        }
        
        public class c_duplicatefilter_formcopyto : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit RefNbr { get; }
			public Label RefNbrLabel { get; }
			public Label LblMessage_ { get; }
            
            public c_duplicatefilter_formcopyto(string locator, string name) : 
                    base(locator, name)
            {
                RefNbr = new PXTextEdit("ctl00_phG_panelDuplicate_formCopyTo_edRefNbr", "Ref Nbr", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                LblMessage_ = new Label("ctl00_phG_panelDuplicate_formCopyTo_lblMessage", "Record already exists. Please enter new Reference Nbr.", locator, null);
                DataMemberName = "duplicatefilter";
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
                    Ok = new Button("ctl00_phG_panelDuplicate_PXButton14", "OK", "ctl00_phG_panelDuplicate_formCopyTo");
                    Cancel = new Button("ctl00_phG_panelDuplicate_PXButton15", "Cancel", "ctl00_phG_panelDuplicate_formCopyTo");
                }
            }
        }
        
        public class c_voucher_voucherdetails : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit VoucherBatchNbr { get; }
			public Label VoucherBatchNbrLabel { get; }
			public PXTextEdit WorkBookID { get; }
			public Label WorkBookIDLabel { get; }
            
            public c_voucher_voucherdetails(string locator, string name) : 
                    base(locator, name)
            {
                VoucherBatchNbr = new PXTextEdit("ctl00_phG_tab_t1_form2_VoucherDetails_linkGLVoucherBatch", "Voucher Batch Nbr.", locator, null);
                VoucherBatchNbrLabel = new Label(VoucherBatchNbr);
                VoucherBatchNbr.DataField = "VoucherBatchNbr";
                WorkBookID = new PXTextEdit("ctl00_phG_tab_t1_form2_VoucherDetails_linkGLWorkBook", "Workbook ID", locator, null);
                WorkBookIDLabel = new Label(WorkBookID);
                WorkBookID.DataField = "WorkBookID";
                DataMemberName = "Voucher";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void IntercompanyInvoiceNoteIDEdit()
            {
                Buttons.IntercompanyInvoiceNoteIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button IntercompanyInvoiceNoteIDEdit { get; }
                
                public PxButtonCollection()
                {
                    IntercompanyInvoiceNoteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_form2_edIntercompanyInvoiceNoteID\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "IntercompanyInvoiceNoteIDEdit", "ctl00_phG_tab_t1_form2_VoucherDetails");
                    IntercompanyInvoiceNoteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_gridApproval");
                DataMemberName = "Approval";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_gridApproval_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridApproval_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                    ApproverEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t3_gridApproval_ei", "Assignee ID", grid.Locator, "ApproverEmployee__AcctCD");
                    ApproverEmployee__AcctCD.DataField = "ApproverEmployee__AcctCD";
                    ApproverEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t3_gridApproval_ei", "Assigned To", grid.Locator, "ApproverEmployee__AcctName");
                    ApproverEmployee__AcctName.DataField = "ApproverEmployee__AcctName";
                    WorkgroupID = new Selector("_ctl00_phG_tab_t3_gridApproval_lv0_es", "Workgroup", grid.Locator, "WorkgroupID");
                    WorkgroupID.DataField = "WorkgroupID";
                    ApprovedByEmployee__AcctCD = new PXTextEdit("ctl00_phG_tab_t3_gridApproval_ei", "Approved by (ID)", grid.Locator, "ApprovedByEmployee__AcctCD");
                    ApprovedByEmployee__AcctCD.DataField = "ApprovedByEmployee__AcctCD";
                    ApprovedByEmployee__AcctName = new PXTextEdit("ctl00_phG_tab_t3_gridApproval_ei", "Approved By", grid.Locator, "ApprovedByEmployee__AcctName");
                    ApprovedByEmployee__AcctName.DataField = "ApprovedByEmployee__AcctName";
                    ApproveDate = new DateSelector("_ctl00_phG_tab_t3_gridApproval_lv0_ed7", "Approval Date", grid.Locator, "ApproveDate");
                    ApproveDate.DataField = "ApproveDate";
                    Status = new DropDown("_ctl00_phG_tab_t3_gridApproval_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("P", "Pending");
                    Status.Items.Add("A", "Approved");
                    Status.Items.Add("R", "Rejected");
                    AssignmentMapID = new Selector("_ctl00_phG_tab_t3_gridApproval_lv0_es", "Map", grid.Locator, "AssignmentMapID");
                    AssignmentMapID.DataField = "AssignmentMapID";
                    RuleID = new Selector("_ctl00_phG_tab_t3_gridApproval_lv0_es", "Map Rule", grid.Locator, "RuleID");
                    RuleID.DataField = "RuleID";
                    StepID = new Selector("_ctl00_phG_tab_t3_gridApproval_lv0_es", "Map Step", grid.Locator, "StepID");
                    StepID.DataField = "StepID";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t3_gridApproval_lv0_ed12", "Assignment Date", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    ApprovalID = new PXNumberEdit("ctl00_phG_tab_t3_gridApproval_en", "ApprovalID", grid.Locator, "ApprovalID");
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
                Es = new Selector("ctl00_phG_tab_t3_gridApproval_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t3_gridApproval_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t3_gridApproval_lv0_ec", "Ec", locator, null);
                DataMemberName = "Approval";
            }
        }
        
        public class c_releaseretainageoptions_frmretainageoptions : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit RetainagePct { get; }
			public Label RetainagePctLabel { get; }
			public PXNumberEdit CuryRetainageAmt { get; }
			public Label CuryRetainageAmtLabel { get; }
			public PXNumberEdit CuryRetainageUnreleasedAmt { get; }
			public Label CuryRetainageUnreleasedAmtLabel { get; }
			public PXTextEdit InvoiceNbr { get; }
			public Label InvoiceNbrLabel { get; }
            
            public c_releaseretainageoptions_frmretainageoptions(string locator, string name) : 
                    base(locator, name)
            {
                RetainagePct = new PXNumberEdit("ctl00_phG_spRetainageOptions_frmRetainageOptions_edRetainagePct", "Retainage Pct", locator, null);
                RetainagePctLabel = new Label(RetainagePct);
                RetainagePct.DataField = "RetainagePct";
                CuryRetainageAmt = new PXNumberEdit("ctl00_phG_spRetainageOptions_frmRetainageOptions_edCuryRetainageAmt", "Cury Retainage Amt", locator, null);
                CuryRetainageAmtLabel = new Label(CuryRetainageAmt);
                CuryRetainageAmt.DataField = "CuryRetainageAmt";
                CuryRetainageUnreleasedAmt = new PXNumberEdit("ctl00_phG_spRetainageOptions_frmRetainageOptions_edCuryRetainageUnreleasedAmt", "Cury Retainage Unreleased Amt", locator, null);
                CuryRetainageUnreleasedAmtLabel = new Label(CuryRetainageUnreleasedAmt);
                CuryRetainageUnreleasedAmt.DataField = "CuryRetainageUnreleasedAmt";
                InvoiceNbr = new PXTextEdit("ctl00_phG_spRetainageOptions_frmRetainageOptions_edInvoiceNbr", "Invoice Nbr", locator, null);
                InvoiceNbrLabel = new Label(InvoiceNbr);
                InvoiceNbr.DataField = "InvoiceNbr";
                DataMemberName = "ReleaseRetainageOptions";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Release()
            {
                Buttons.Release.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Cancel { get; }
			public Button Release { get; }
                
                public PxButtonCollection()
                {
                    Cancel = new Button("ctl00_phG_spRetainageOptions_btnCancel", "Cancel", "ctl00_phG_spRetainageOptions_frmRetainageOptions");
                    Release = new Button("ctl00_phG_spRetainageOptions_btnRelease", "Release", "ctl00_phG_spRetainageOptions_frmRetainageOptions");
                }
            }
        }
        
        public class c_linklinelandedcostdetail_linklinelandedcostgrid : Grid<c_linklinelandedcostdetail_linklinelandedcostgrid.c_grid_row, c_linklinelandedcostdetail_linklinelandedcostgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_linklinelandedcostdetail_linklinelandedcostgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid");
                DataMemberName = "LinkLineLandedCostDetail";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_fe_gf", "FilterForm");
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
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_at_tlb div[data-cmd=\'Refresh\'" +
                            "]", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_at_tlb div[data-cmd=\'AdjustCo" +
                            "lumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_at_tlb div[data-cmd=\'ExportEx" +
                            "cel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ab_tlb div[data-cmd=\'PageFirs" +
                            "t\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ab_tlb div[data-cmd=\'PagePrev" +
                            "\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ab_tlb div[data-cmd=\'PageNext" +
                            "\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ab_tlb div[data-cmd=\'PageLast" +
                            "\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phG_PanelLinkLine_LinkLineSave", "Save", "ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid");
                    Cancel = new Button("ctl00_phG_PanelLinkLine_LinkLineCancel", "Cancel", "ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public DropDown DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit VendorRefNbr { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public InputLocalizable Descr { get; }
			public DropDown INDocType { get; }
			public Selector INRefNbr { get; }
                
                public c_grid_row(c_linklinelandedcostdetail_linklinelandedcostgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    DocType = new DropDown("_ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_lv0_ec", "Doc. Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("L", "Landed Cost");
                    DocType.Items.Add("C", "Correction");
                    DocType.Items.Add("R", "Reversal");
                    RefNbr = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ei", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    VendorRefNbr = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ei", "Vendor Ref.", grid.Locator, "VendorRefNbr");
                    VendorRefNbr.DataField = "VendorRefNbr";
                    CuryLineAmt = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_en", "Amount", grid.Locator, "CuryLineAmt");
                    CuryLineAmt.DataField = "CuryLineAmt";
                    Descr = new InputLocalizable("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    INDocType = new DropDown("_ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_lv0_ec", "IN Doc. Type", grid.Locator, "INDocType");
                    INDocType.DataField = "INDocType";
                    INDocType.Items.Add("I", "Issue");
                    INDocType.Items.Add("R", "Receipt");
                    INDocType.Items.Add("T", "Transfer");
                    INDocType.Items.Add("A", "Adjustment");
                    INDocType.Items.Add("P", "Production");
                    INDocType.Items.Add("D", "Disassembly");
                    INRefNbr = new Selector("_ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_lv0_es", "IN Ref. Nbr.", grid.Locator, "INRefNbr");
                    INRefNbr.DataField = "INRefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter VendorRefNbr { get; }
				public PXNumberEditColumnFilter CuryLineAmt { get; }
				public PXTextEditColumnFilter Descr { get; }
				public DropDownColumnFilter INDocType { get; }
				public SelectorColumnFilter INRefNbr { get; }
                
                public c_grid_header(c_linklinelandedcostdetail_linklinelandedcostgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    VendorRefNbr = new PXTextEditColumnFilter(grid.Row.VendorRefNbr);
                    CuryLineAmt = new PXNumberEditColumnFilter(grid.Row.CuryLineAmt);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    INDocType = new DropDownColumnFilter(grid.Row.INDocType);
                    INRefNbr = new SelectorColumnFilter(grid.Row.INRefNbr);
                }
            }
        }
        
        public class c_linklinelandedcostdetail_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_linklinelandedcostdetail_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "LinkLineLandedCostDetail";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phG_PanelLinkLine_LinkLineSave", "Save", "ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_lv0");
                    Cancel = new Button("ctl00_phG_PanelLinkLine_LinkLineCancel", "Cancel", "ctl00_phG_PanelLinkLine_LinkLineLandedCostGrid_lv0");
                }
            }
        }
        
        public class c_landedcostdetailsadd_grdlc : Grid<c_landedcostdetailsadd_grdlc.c_grid_row, c_landedcostdetailsadd_grdlc.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_landedcostdetailsadd_grdlc(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddLandedCost_grdLC");
                DataMemberName = "LandedCostDetailsAdd";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelAddLandedCost_grdLC_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddLandedCost_grdLC_fe_gf", "FilterForm");
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
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddLandedCost_grdLC_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddLandedCost_PXButton16", "Add", "ctl00_phG_PanelAddLandedCost_grdLC");
                    AddClose = new Button("ctl00_phG_PanelAddLandedCost_PXButton17", "Add & Close", "ctl00_phG_PanelAddLandedCost_grdLC");
                    Cancel = new Button("ctl00_phG_PanelAddLandedCost_PXButton18", "Cancel", "ctl00_phG_PanelAddLandedCost_grdLC");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public DropDown DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXTextEdit VendorRefNbr { get; }
			public Selector LandedCostCodeID { get; }
			public InputLocalizable Descr { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public Selector CuryID { get; }
			public Selector TaxCategoryID { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_landedcostdetailsadd_grdlc grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddLandedCost_grdLC", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    DocType = new DropDown("_ctl00_phG_PanelAddLandedCost_grdLC_lv0_ec", "Doc. Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("L", "Landed Cost");
                    DocType.Items.Add("C", "Correction");
                    DocType.Items.Add("R", "Reversal");
                    RefNbr = new PXTextEdit("ctl00_phG_PanelAddLandedCost_grdLC_ei", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    VendorRefNbr = new PXTextEdit("ctl00_phG_PanelAddLandedCost_grdLC_ei", "Vendor Ref.", grid.Locator, "VendorRefNbr");
                    VendorRefNbr.DataField = "VendorRefNbr";
                    LandedCostCodeID = new Selector("_ctl00_phG_PanelAddLandedCost_grdLC_lv0_es", "Landed Cost Code", grid.Locator, "LandedCostCodeID");
                    LandedCostCodeID.DataField = "LandedCostCodeID";
                    Descr = new InputLocalizable("ctl00_phG_PanelAddLandedCost_grdLC_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    CuryLineAmt = new PXNumberEdit("ctl00_phG_PanelAddLandedCost_grdLC_en", "Amount", grid.Locator, "CuryLineAmt");
                    CuryLineAmt.DataField = "CuryLineAmt";
                    CuryID = new Selector("_ctl00_phG_PanelAddLandedCost_grdLC_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    TaxCategoryID = new Selector("_ctl00_phG_PanelAddLandedCost_grdLC_lv0_es", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelAddLandedCost_grdLC_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXTextEditColumnFilter VendorRefNbr { get; }
				public SelectorColumnFilter LandedCostCodeID { get; }
				public PXTextEditColumnFilter Descr { get; }
				public PXNumberEditColumnFilter CuryLineAmt { get; }
				public SelectorColumnFilter CuryID { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_landedcostdetailsadd_grdlc grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    VendorRefNbr = new PXTextEditColumnFilter(grid.Row.VendorRefNbr);
                    LandedCostCodeID = new SelectorColumnFilter(grid.Row.LandedCostCodeID);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    CuryLineAmt = new PXNumberEditColumnFilter(grid.Row.CuryLineAmt);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_landedcostdetailsadd_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_landedcostdetailsadd_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddLandedCost_grdLC_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_PanelAddLandedCost_grdLC_lv0_ec", "Ec", locator, null);
                DataMemberName = "LandedCostDetailsAdd";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddLandedCost_PXButton16", "Add", "ctl00_phG_PanelAddLandedCost_grdLC_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddLandedCost_PXButton17", "Add & Close", "ctl00_phG_PanelAddLandedCost_grdLC_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddLandedCost_PXButton18", "Cancel", "ctl00_phG_PanelAddLandedCost_grdLC_lv0");
                }
            }
        }
        
        public class c_linklineordertran_linklineordergrid : Grid<c_linklineordertran_linklineordergrid.c_grid_row, c_linklineordertran_linklineordergrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_linklineordertran_linklineordergrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelLinkLine_LinkLineOrderGrid");
                DataMemberName = "linkLineOrderTran";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_fe_gf", "FilterForm");
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
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_at_tlb div[data-cmd=\'AdjustColumns" +
                            "\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_at_tlb div[data-cmd=\'ExportExcel\']" +
                            "", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phG_PanelLinkLine_LinkLineSave", "Save", "ctl00_phG_PanelLinkLine_LinkLineOrderGrid");
                    Cancel = new Button("ctl00_phG_PanelLinkLine_LinkLineCancel", "Cancel", "ctl00_phG_PanelLinkLine_LinkLineOrderGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public Selector POOrder__OrderNbr { get; }
			public DropDown POOrder__OrderType { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit POOrder__VendorRefNbr { get; }
			public Selector SubItemID { get; }
			public Selector SiteID { get; }
			public Selector POOrder__CuryID { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public PXNumberEdit UnbilledQty { get; }
			public PXNumberEdit CuryUnbilledAmt { get; }
			public PXTextEdit TranDesc { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
                
                public c_grid_row(c_linklineordertran_linklineordergrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    POOrder__OrderNbr = new Selector("_ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0_es", "Order Nbr.", grid.Locator, "POOrder__OrderNbr");
                    POOrder__OrderNbr.DataField = "POOrder__OrderNbr";
                    POOrder__OrderType = new DropDown("_ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0_ec", "Type", grid.Locator, "POOrder__OrderType");
                    POOrder__OrderType.DataField = "POOrder__OrderType";
                    POOrder__OrderType.Items.Add("RO", "Normal");
                    POOrder__OrderType.Items.Add("DP", "Drop-Ship");
                    POOrder__OrderType.Items.Add("PD", "Project Drop-Ship");
                    POOrder__OrderType.Items.Add("BL", "Blanket");
                    POOrder__OrderType.Items.Add("SB", "Standard");
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    POOrder__VendorRefNbr = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ei", "Vendor Ref.", grid.Locator, "POOrder__VendorRefNbr");
                    POOrder__VendorRefNbr.DataField = "POOrder__VendorRefNbr";
                    SubItemID = new Selector("_ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SiteID = new Selector("_ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    POOrder__CuryID = new Selector("_ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0_es", "Currency", grid.Locator, "POOrder__CuryID");
                    POOrder__CuryID.DataField = "POOrder__CuryID";
                    OrderQty = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_en", "Order Qty.", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    CuryLineAmt = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_en", "Ext. Cost", grid.Locator, "curyLineAmt");
                    CuryLineAmt.DataField = "curyLineAmt";
                    UnbilledQty = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_en", "Unbilled Qty.", grid.Locator, "UnbilledQty");
                    UnbilledQty.DataField = "UnbilledQty";
                    CuryUnbilledAmt = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_en", "Unbilled Amount", grid.Locator, "CuryUnbilledAmt");
                    CuryUnbilledAmt.DataField = "CuryUnbilledAmt";
                    TranDesc = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ei", "Line Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    OrderType = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ei", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_ei", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter POOrder__OrderNbr { get; }
				public DropDownColumnFilter POOrder__OrderType { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter POOrder__VendorRefNbr { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter POOrder__CuryID { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter CuryLineAmt { get; }
				public PXNumberEditColumnFilter UnbilledQty { get; }
				public PXNumberEditColumnFilter CuryUnbilledAmt { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
                
                public c_grid_header(c_linklineordertran_linklineordergrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    POOrder__OrderNbr = new SelectorColumnFilter(grid.Row.POOrder__OrderNbr);
                    POOrder__OrderType = new DropDownColumnFilter(grid.Row.POOrder__OrderType);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    POOrder__VendorRefNbr = new PXTextEditColumnFilter(grid.Row.POOrder__VendorRefNbr);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    POOrder__CuryID = new SelectorColumnFilter(grid.Row.POOrder__CuryID);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    CuryLineAmt = new PXNumberEditColumnFilter(grid.Row.CuryLineAmt);
                    UnbilledQty = new PXNumberEditColumnFilter(grid.Row.UnbilledQty);
                    CuryUnbilledAmt = new PXNumberEditColumnFilter(grid.Row.CuryUnbilledAmt);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                }
            }
        }
        
        public class c_linklineordertran_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_linklineordertran_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "linkLineOrderTran";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phG_PanelLinkLine_LinkLineSave", "Save", "ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0");
                    Cancel = new Button("ctl00_phG_PanelLinkLine_LinkLineCancel", "Cancel", "ctl00_phG_PanelLinkLine_LinkLineOrderGrid_lv0");
                }
            }
        }
        
        public class c_linklinereceipttran_linklinegrid : Grid<c_linklinereceipttran_linklinegrid.c_grid_row, c_linklinereceipttran_linklinegrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_linklinereceipttran_linklinegrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelLinkLine_LinkLineGrid");
                DataMemberName = "linkLineReceiptTran";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelLinkLine_LinkLineGrid_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelLinkLine_LinkLineGrid_fe_gf", "FilterForm");
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
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelLinkLine_LinkLineGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phG_PanelLinkLine_LinkLineSave", "Save", "ctl00_phG_PanelLinkLine_LinkLineGrid");
                    Cancel = new Button("ctl00_phG_PanelLinkLine_LinkLineCancel", "Cancel", "ctl00_phG_PanelLinkLine_LinkLineGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit PONbr { get; }
			public DropDown POType { get; }
			public PXTextEdit ReceiptNbr { get; }
			public PXTextEdit POReceipt__InvoiceNbr { get; }
			public Selector SubItemID { get; }
			public Selector SiteID { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit CuryID { get; }
			public PXNumberEdit ReceiptQty { get; }
			public PXNumberEdit CuryExtCost { get; }
			public PXNumberEdit UnbilledQty { get; }
			public PXTextEdit TranDesc { get; }
			public PXTextEdit ReceiptType { get; }
                
                public c_grid_row(c_linklinereceipttran_linklinegrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelLinkLine_LinkLineGrid_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    PONbr = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_ei", "Order Nbr.", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    POType = new DropDown("_ctl00_phG_PanelLinkLine_LinkLineGrid_lv0_ec", "Order Type", grid.Locator, "POType");
                    POType.DataField = "POType";
                    POType.Items.Add("RO", "Normal");
                    POType.Items.Add("DP", "Drop-Ship");
                    POType.Items.Add("PD", "Project Drop-Ship");
                    POType.Items.Add("BL", "Blanket");
                    POType.Items.Add("SB", "Standard");
                    ReceiptNbr = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_ei", "Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                    POReceipt__InvoiceNbr = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_ei", "Vendor Ref.", grid.Locator, "POReceipt__InvoiceNbr");
                    POReceipt__InvoiceNbr.DataField = "POReceipt__InvoiceNbr";
                    SubItemID = new Selector("_ctl00_phG_PanelLinkLine_LinkLineGrid_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SiteID = new Selector("_ctl00_phG_PanelLinkLine_LinkLineGrid_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    CuryID = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_em", "Order Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    ReceiptQty = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_en", "Receipt Qty.", grid.Locator, "ReceiptQty");
                    ReceiptQty.DataField = "ReceiptQty";
                    CuryExtCost = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_en", "Order Line Amount", grid.Locator, "CuryExtCost");
                    CuryExtCost.DataField = "CuryExtCost";
                    UnbilledQty = new PXNumberEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_en", "Unbilled Qty.", grid.Locator, "UnbilledQty");
                    UnbilledQty.DataField = "UnbilledQty";
                    TranDesc = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_ei", "Transaction Descr.", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    ReceiptType = new PXTextEdit("ctl00_phG_PanelLinkLine_LinkLineGrid_ei", "Receipt Type", grid.Locator, "ReceiptType");
                    ReceiptType.DataField = "ReceiptType";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter PONbr { get; }
				public DropDownColumnFilter POType { get; }
				public PXTextEditColumnFilter ReceiptNbr { get; }
				public PXTextEditColumnFilter POReceipt__InvoiceNbr { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter ReceiptQty { get; }
				public PXNumberEditColumnFilter CuryExtCost { get; }
				public PXNumberEditColumnFilter UnbilledQty { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXTextEditColumnFilter ReceiptType { get; }
                
                public c_grid_header(c_linklinereceipttran_linklinegrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    PONbr = new PXTextEditColumnFilter(grid.Row.PONbr);
                    POType = new DropDownColumnFilter(grid.Row.POType);
                    ReceiptNbr = new PXTextEditColumnFilter(grid.Row.ReceiptNbr);
                    POReceipt__InvoiceNbr = new PXTextEditColumnFilter(grid.Row.POReceipt__InvoiceNbr);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    ReceiptQty = new PXNumberEditColumnFilter(grid.Row.ReceiptQty);
                    CuryExtCost = new PXNumberEditColumnFilter(grid.Row.CuryExtCost);
                    UnbilledQty = new PXNumberEditColumnFilter(grid.Row.UnbilledQty);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    ReceiptType = new PXTextEditColumnFilter(grid.Row.ReceiptType);
                }
            }
        }
        
        public class c_linklinereceipttran_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_linklinereceipttran_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelLinkLine_LinkLineGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_PanelLinkLine_LinkLineGrid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PanelLinkLine_LinkLineGrid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "linkLineReceiptTran";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phG_PanelLinkLine_LinkLineSave", "Save", "ctl00_phG_PanelLinkLine_LinkLineGrid_lv0");
                    Cancel = new Button("ctl00_phG_PanelLinkLine_LinkLineCancel", "Cancel", "ctl00_phG_PanelLinkLine_LinkLineGrid_lv0");
                }
            }
        }
        
        public class c_linklinefilter_linklinefilterform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector POOrderNbr { get; }
			public Label POOrderNbrLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public GroupBox SelectedMode { get; }
			public Label SelectedModeLabel { get; }
            
            public c_linklinefilter_linklinefilterform(string locator, string name) : 
                    base(locator, name)
            {
                POOrderNbr = new Selector("ctl00_phG_PanelLinkLine_LinkLineFilterForm_edPOOrderNbr", "Order Nbr.", locator, null);
                POOrderNbrLabel = new Label(POOrderNbr);
                POOrderNbr.DataField = "POOrderNbr";
                SiteID = new Selector("ctl00_phG_PanelLinkLine_LinkLineFilterForm_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                InventoryID = new Selector("ctl00_phG_PanelLinkLine_LinkLineFilterForm_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                UOM = new Selector("ctl00_phG_PanelLinkLine_LinkLineFilterForm_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                SelectedMode = new GroupBox("ctl00_phG_PanelLinkLine_LinkLineFilterForm_gpMode", "Selected Mode", locator, null);
                SelectedModeLabel = new Label(SelectedMode);
                SelectedMode.DataField = "SelectedMode";
                DataMemberName = "linkLineFilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Save()
            {
                Buttons.Save.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Save { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Save = new Button("ctl00_phG_PanelLinkLine_LinkLineSave", "Save", "ctl00_phG_PanelLinkLine_LinkLineFilterForm");
                    Cancel = new Button("ctl00_phG_PanelLinkLine_LinkLineCancel", "Cancel", "ctl00_phG_PanelLinkLine_LinkLineFilterForm");
                }
            }
        }
        
        public class c_filter_frmporderfilter : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
            
            public c_filter_frmporderfilter(string locator, string name) : 
                    base(locator, name)
            {
                OrderNbr = new Selector("ctl00_phG_PanelAddPOReceipt_frmPOrderFilter_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                DataMemberName = "filter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AddClose = new Button("ctl00_phG_PanelAddPOReceipt_PXButton1", "Add & Close", "ctl00_phG_PanelAddPOReceipt_frmPOrderFilter");
                    Cancel = new Button("ctl00_phG_PanelAddPOReceipt_PXButton2", "Cancel", "ctl00_phG_PanelAddPOReceipt_frmPOrderFilter");
                }
            }
        }
        
        public class c_filter_frmpofilter : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
            
            public c_filter_frmpofilter(string locator, string name) : 
                    base(locator, name)
            {
                OrderNbr = new Selector("ctl00_phG_PanelAddPOReceiptLine_frmPOFilter_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                DataMemberName = "filter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton3", "Add", "ctl00_phG_PanelAddPOReceiptLine_frmPOFilter");
                    AddClose = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton4", "Add & Close", "ctl00_phG_PanelAddPOReceiptLine_frmPOFilter");
                    Cancel = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton5", "Cancel", "ctl00_phG_PanelAddPOReceiptLine_frmPOFilter");
                }
            }
        }
        
        public class c_poorderlineslist_poorderlinesgrid : Grid<c_poorderlineslist_poorderlinesgrid.c_grid_row, c_poorderlineslist_poorderlinesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_poorderlineslist_poorderlinesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid");
                DataMemberName = "poorderlineslist";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_fe_gf", "FilterForm");
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
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_at_tlb div[data-cmd=\'Refresh\'" +
                            "]", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_at_tlb div[data-cmd=\'AdjustCo" +
                            "lumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_at_tlb div[data-cmd=\'ExportEx" +
                            "cel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_ab_tlb div[data-cmd=\'PageFirs" +
                            "t\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_ab_tlb div[data-cmd=\'PagePrev" +
                            "\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_ab_tlb div[data-cmd=\'PageNext" +
                            "\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_ab_tlb div[data-cmd=\'PageLast" +
                            "\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton9", "Add", "ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid");
                    AddClose = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton10", "Add & Close", "ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid");
                    Cancel = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton11", "Cancel", "ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit OrderNbr { get; }
			public DropDown OrderType { get; }
			public Selector VendorID { get; }
			public Selector VendorLocationID { get; }
			public DateSelector OrderDate { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector SiteID { get; }
			public Selector CuryID { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public PXNumberEdit UnbilledQty { get; }
			public PXNumberEdit CuryUnbilledAmt { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_poorderlineslist_poorderlinesgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderNbr = new PXTextEdit("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_ei", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    OrderType = new DropDown("_ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_ec", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderType.Items.Add("RO", "Normal");
                    OrderType.Items.Add("DP", "Drop-Ship");
                    OrderType.Items.Add("PD", "Project Drop-Ship");
                    OrderType.Items.Add("BL", "Blanket");
                    OrderType.Items.Add("SB", "Standard");
                    VendorID = new Selector("_ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_es", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorLocationID = new Selector("_ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_es", "Location", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    OrderDate = new DateSelector("_ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_ed5", "Order Date", grid.Locator, "OrderDate");
                    OrderDate.DataField = "OrderDate";
                    InventoryID = new Selector("_ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SiteID = new Selector("_ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    CuryID = new Selector("_ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    CuryLineAmt = new PXNumberEdit("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_en", "Ext. Cost", grid.Locator, "CuryLineAmt");
                    CuryLineAmt.DataField = "CuryLineAmt";
                    UnbilledQty = new PXNumberEdit("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_en", "Unbilled Qty.", grid.Locator, "UnbilledQty");
                    UnbilledQty.DataField = "UnbilledQty";
                    CuryUnbilledAmt = new PXNumberEdit("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_en", "Unbilled Amount", grid.Locator, "CuryUnbilledAmt");
                    CuryUnbilledAmt.DataField = "CuryUnbilledAmt";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public DropDownColumnFilter OrderType { get; }
				public SelectorColumnFilter VendorID { get; }
				public SelectorColumnFilter VendorLocationID { get; }
				public DateSelectorColumnFilter OrderDate { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter CuryLineAmt { get; }
				public PXNumberEditColumnFilter UnbilledQty { get; }
				public PXNumberEditColumnFilter CuryUnbilledAmt { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_poorderlineslist_poorderlinesgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    OrderType = new DropDownColumnFilter(grid.Row.OrderType);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    VendorLocationID = new SelectorColumnFilter(grid.Row.VendorLocationID);
                    OrderDate = new DateSelectorColumnFilter(grid.Row.OrderDate);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    CuryLineAmt = new PXNumberEditColumnFilter(grid.Row.CuryLineAmt);
                    UnbilledQty = new PXNumberEditColumnFilter(grid.Row.UnbilledQty);
                    CuryUnbilledAmt = new PXNumberEditColumnFilter(grid.Row.CuryUnbilledAmt);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_poorderlineslist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_poorderlineslist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "poorderlineslist";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton9", "Add", "ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton10", "Add & Close", "ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton11", "Cancel", "ctl00_phG_PanelAddPOOrderLine_POOrderLinesGrid_lv0");
                }
            }
        }
        
        public class c_subcontractlines_subcontractlinesgrid : Grid<c_subcontractlines_subcontractlinesgrid.c_grid_row, c_subcontractlines_subcontractlinesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_subcontractlines_subcontractlinesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid");
                DataMemberName = "SubcontractLines";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_fe_gf", "FilterForm");
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
            
            public virtual void AddSubcontractLine()
            {
                Buttons.AddSubcontractLine.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_at_tlb div[data-cmd=\'" +
                            "Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_at_tlb div[data-cmd=\'" +
                            "AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_at_tlb div[data-cmd=\'" +
                            "ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_at_tlb div[data-cmd=\'" +
                            "hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ab_tlb div[data-cmd=\'" +
                            "PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ab_tlb div[data-cmd=\'" +
                            "PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ab_tlb div[data-cmd=\'" +
                            "PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ab_tlb div[data-cmd=\'" +
                            "PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ab_tlb div[data-cmd=\'" +
                            "hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddSubcontractLine { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AddSubcontractLine = new Button("ctl00_phG_PanelAddSubcontractLine_btnAddSubcontractLine", "Add Subcontract Line", "ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid");
                    AddClose = new Button("ctl00_phG_PanelAddSubcontractLine_btnAddCloseSubcontractLine", "Add & Close", "ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid");
                    Cancel = new Button("ctl00_phG_PanelAddSubcontractLine_btnCancelAddSubcontractLine", "Cancel", "ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit SubcontractNbr { get; }
			public PXTextEdit ProjectID { get; }
			public PXTextEdit TaskID { get; }
			public PXTextEdit CostCodeID { get; }
			public PXTextEdit VendorID { get; }
			public PXTextEdit VendorLocationID { get; }
			public PXTextEdit SubcontractDate { get; }
			public PXTextEdit CuryID { get; }
			public PXTextEdit InventoryID { get; }
			public PXTextEdit CuryLineAmt { get; }
			public PXTextEdit UnbilledQty { get; }
			public PXTextEdit CuryUnbilledAmt { get; }
			public PXTextEdit BilledQty { get; }
			public PXTextEdit CuryBilledAmt { get; }
                
                public c_grid_row(c_subcontractlines_subcontractlinesgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    SubcontractNbr = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Subcontract Nbr", grid.Locator, "SubcontractNbr");
                    SubcontractNbr.DataField = "SubcontractNbr";
                    ProjectID = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Project ID", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Task ID", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Cost Code ID", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    VendorID = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorLocationID = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Vendor Location ID", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    SubcontractDate = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Subcontract Date", grid.Locator, "SubcontractDate");
                    SubcontractDate.DataField = "SubcontractDate";
                    CuryID = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Cury ID", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    InventoryID = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    CuryLineAmt = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Cury Line Amt", grid.Locator, "CuryLineAmt");
                    CuryLineAmt.DataField = "CuryLineAmt";
                    UnbilledQty = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Unbilled Qty", grid.Locator, "UnbilledQty");
                    UnbilledQty.DataField = "UnbilledQty";
                    CuryUnbilledAmt = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Cury Unbilled Amt", grid.Locator, "CuryUnbilledAmt");
                    CuryUnbilledAmt.DataField = "CuryUnbilledAmt";
                    BilledQty = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Billed Qty", grid.Locator, "BilledQty");
                    BilledQty.DataField = "BilledQty";
                    CuryBilledAmt = new PXTextEdit("ctl00_phG_PanelAddSubcontractLine_SubcontractLinesGrid_ei", "Cury Billed Amt", grid.Locator, "CuryBilledAmt");
                    CuryBilledAmt.DataField = "CuryBilledAmt";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter SubcontractNbr { get; }
				public PXTextEditColumnFilter ProjectID { get; }
				public PXTextEditColumnFilter TaskID { get; }
				public PXTextEditColumnFilter CostCodeID { get; }
				public PXTextEditColumnFilter VendorID { get; }
				public PXTextEditColumnFilter VendorLocationID { get; }
				public PXTextEditColumnFilter SubcontractDate { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public PXTextEditColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter CuryLineAmt { get; }
				public PXTextEditColumnFilter UnbilledQty { get; }
				public PXTextEditColumnFilter CuryUnbilledAmt { get; }
				public PXTextEditColumnFilter BilledQty { get; }
				public PXTextEditColumnFilter CuryBilledAmt { get; }
                
                public c_grid_header(c_subcontractlines_subcontractlinesgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    SubcontractNbr = new PXTextEditColumnFilter(grid.Row.SubcontractNbr);
                    ProjectID = new PXTextEditColumnFilter(grid.Row.ProjectID);
                    TaskID = new PXTextEditColumnFilter(grid.Row.TaskID);
                    CostCodeID = new PXTextEditColumnFilter(grid.Row.CostCodeID);
                    VendorID = new PXTextEditColumnFilter(grid.Row.VendorID);
                    VendorLocationID = new PXTextEditColumnFilter(grid.Row.VendorLocationID);
                    SubcontractDate = new PXTextEditColumnFilter(grid.Row.SubcontractDate);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    InventoryID = new PXTextEditColumnFilter(grid.Row.InventoryID);
                    CuryLineAmt = new PXTextEditColumnFilter(grid.Row.CuryLineAmt);
                    UnbilledQty = new PXTextEditColumnFilter(grid.Row.UnbilledQty);
                    CuryUnbilledAmt = new PXTextEditColumnFilter(grid.Row.CuryUnbilledAmt);
                    BilledQty = new PXTextEditColumnFilter(grid.Row.BilledQty);
                    CuryBilledAmt = new PXTextEditColumnFilter(grid.Row.CuryBilledAmt);
                }
            }
        }
        
        public class c_orderfilter_pxformview1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public CheckBox ShowBilledLines { get; }
			public Label ShowBilledLinesLabel { get; }
            
            public c_orderfilter_pxformview1(string locator, string name) : 
                    base(locator, name)
            {
                OrderNbr = new Selector("ctl00_phG_PanelAddPOOrderLine_PXFormView1_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                ShowBilledLines = new CheckBox("ctl00_phG_PanelAddPOOrderLine_PXFormView1_chkShowBilledLines", "Show Billed Lines", locator, null);
                ShowBilledLinesLabel = new Label(ShowBilledLines);
                ShowBilledLines.DataField = "ShowBilledLines";
                DataMemberName = "orderfilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton9", "Add", "ctl00_phG_PanelAddPOOrderLine_PXFormView1");
                    AddClose = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton10", "Add & Close", "ctl00_phG_PanelAddPOOrderLine_PXFormView1");
                    Cancel = new Button("ctl00_phG_PanelAddPOOrderLine_PXButton11", "Cancel", "ctl00_phG_PanelAddPOOrderLine_PXFormView1");
                }
            }
        }
        
        public class c_orderfilter_pxaddsubcontractlineformview : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SubcontractNumber { get; }
			public Label SubcontractNumberLabel { get; }
			public CheckBox ShowBilledLines { get; }
			public Label ShowBilledLinesLabel { get; }
			public CheckBox ShowUnbilledLines { get; }
			public Label ShowUnbilledLinesLabel { get; }
            
            public c_orderfilter_pxaddsubcontractlineformview(string locator, string name) : 
                    base(locator, name)
            {
                SubcontractNumber = new Selector("ctl00_phG_PanelAddSubcontractLine_PXAddSubcontractLineFormView_edOrderNbr", "Subcontract Number", locator, null);
                SubcontractNumberLabel = new Label(SubcontractNumber);
                SubcontractNumber.DataField = "SubcontractNumber";
                ShowBilledLines = new CheckBox("ctl00_phG_PanelAddSubcontractLine_PXAddSubcontractLineFormView_chkShowBilledLines" +
                        "", "Show Billed Lines", locator, null);
                ShowBilledLinesLabel = new Label(ShowBilledLines);
                ShowBilledLines.DataField = "ShowBilledLines";
                ShowUnbilledLines = new CheckBox("ctl00_phG_PanelAddSubcontractLine_PXAddSubcontractLineFormView_chkShowUnbilledLin" +
                        "es", "Show Unbilled Lines", locator, null);
                ShowUnbilledLinesLabel = new Label(ShowUnbilledLines);
                ShowUnbilledLines.DataField = "ShowUnbilledLines";
                DataMemberName = "orderfilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddSubcontractLine()
            {
                Buttons.AddSubcontractLine.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddSubcontractLine { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AddSubcontractLine = new Button("ctl00_phG_PanelAddSubcontractLine_btnAddSubcontractLine", "Add Subcontract Line", "ctl00_phG_PanelAddSubcontractLine_PXAddSubcontractLineFormView");
                    AddClose = new Button("ctl00_phG_PanelAddSubcontractLine_btnAddCloseSubcontractLine", "Add & Close", "ctl00_phG_PanelAddSubcontractLine_PXAddSubcontractLineFormView");
                    Cancel = new Button("ctl00_phG_PanelAddSubcontractLine_btnCancelAddSubcontractLine", "Cancel", "ctl00_phG_PanelAddSubcontractLine_PXAddSubcontractLineFormView");
                }
            }
        }
        
        public class c_poreceiptslist_grid4 : Grid<c_poreceiptslist_grid4.c_grid_row, c_poreceiptslist_grid4.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_poreceiptslist_grid4(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddPOReceipt_grid4");
                DataMemberName = "poreceiptslist";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelAddPOReceipt_grid4_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddPOReceipt_grid4_fe_gf", "FilterForm");
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
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceipt_grid4_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AddClose = new Button("ctl00_phG_PanelAddPOReceipt_PXButton1", "Add & Close", "ctl00_phG_PanelAddPOReceipt_grid4");
                    Cancel = new Button("ctl00_phG_PanelAddPOReceipt_PXButton2", "Cancel", "ctl00_phG_PanelAddPOReceipt_grid4");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public Selector ReceiptNbr { get; }
			public DropDown ReceiptType { get; }
			public Selector VendorID { get; }
			public Selector VendorLocationID { get; }
			public DateSelector ReceiptDate { get; }
			public Selector CuryID { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit UnbilledQty { get; }
			public PXNumberEdit CuryOrderTotal { get; }
                
                public c_grid_row(c_poreceiptslist_grid4 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_PanelAddPOReceipt_grid4", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    ReceiptNbr = new Selector("_ctl00_phG_PanelAddPOReceipt_grid4_lv0_es", "Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                    ReceiptType = new DropDown("_ctl00_phG_PanelAddPOReceipt_grid4_lv0_ec", "Type", grid.Locator, "ReceiptType");
                    ReceiptType.DataField = "ReceiptType";
                    ReceiptType.Items.Add("RT", "Receipt");
                    ReceiptType.Items.Add("RN", "Return");
                    ReceiptType.Items.Add("RX", "Transfer Receipt");
                    VendorID = new Selector("_ctl00_phG_PanelAddPOReceipt_grid4_lv0_es", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorLocationID = new Selector("_ctl00_phG_PanelAddPOReceipt_grid4_lv0_es", "Location", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    ReceiptDate = new DateSelector("_ctl00_phG_PanelAddPOReceipt_grid4_lv0_ed7", "Date", grid.Locator, "ReceiptDate");
                    ReceiptDate.DataField = "ReceiptDate";
                    CuryID = new Selector("_ctl00_phG_PanelAddPOReceipt_grid4_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    OrderQty = new PXNumberEdit("ctl00_phG_PanelAddPOReceipt_grid4_en", "Total Qty.", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    UnbilledQty = new PXNumberEdit("ctl00_phG_PanelAddPOReceipt_grid4_en", "Unbilled Quantity", grid.Locator, "UnbilledQty");
                    UnbilledQty.DataField = "UnbilledQty";
                    CuryOrderTotal = new PXNumberEdit("ctl00_phG_PanelAddPOReceipt_grid4_en", "Total Cost", grid.Locator, "CuryOrderTotal");
                    CuryOrderTotal.DataField = "CuryOrderTotal";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter ReceiptNbr { get; }
				public DropDownColumnFilter ReceiptType { get; }
				public SelectorColumnFilter VendorID { get; }
				public SelectorColumnFilter VendorLocationID { get; }
				public DateSelectorColumnFilter ReceiptDate { get; }
				public SelectorColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter UnbilledQty { get; }
				public PXNumberEditColumnFilter CuryOrderTotal { get; }
                
                public c_grid_header(c_poreceiptslist_grid4 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    ReceiptNbr = new SelectorColumnFilter(grid.Row.ReceiptNbr);
                    ReceiptType = new DropDownColumnFilter(grid.Row.ReceiptType);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    VendorLocationID = new SelectorColumnFilter(grid.Row.VendorLocationID);
                    ReceiptDate = new DateSelectorColumnFilter(grid.Row.ReceiptDate);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    UnbilledQty = new PXNumberEditColumnFilter(grid.Row.UnbilledQty);
                    CuryOrderTotal = new PXNumberEditColumnFilter(grid.Row.CuryOrderTotal);
                }
            }
        }
        
        public class c_poreceiptslist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_poreceiptslist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddPOReceipt_grid4_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddPOReceipt_grid4_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelAddPOReceipt_grid4_lv0_ec", "Ec", locator, null);
                DataMemberName = "poreceiptslist";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AddClose = new Button("ctl00_phG_PanelAddPOReceipt_PXButton1", "Add & Close", "ctl00_phG_PanelAddPOReceipt_grid4_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddPOReceipt_PXButton2", "Cancel", "ctl00_phG_PanelAddPOReceipt_grid4_lv0");
                }
            }
        }
        
        public class c_poreceiptlinesselection_gridol : Grid<c_poreceiptlinesselection_gridol.c_grid_row, c_poreceiptlinesselection_gridol.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_poreceiptlinesselection_gridol(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddPOReceiptLine_gridOL");
                DataMemberName = "poReceiptLinesSelection";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelAddPOReceiptLine_gridOL_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddPOReceiptLine_gridOL_fe_gf", "FilterForm");
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
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOReceiptLine_gridOL_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton3", "Add", "ctl00_phG_PanelAddPOReceiptLine_gridOL");
                    AddClose = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton4", "Add & Close", "ctl00_phG_PanelAddPOReceiptLine_gridOL");
                    Cancel = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton5", "Cancel", "ctl00_phG_PanelAddPOReceiptLine_gridOL");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit PONbr { get; }
			public DropDown POType { get; }
			public PXTextEdit ReceiptNbr { get; }
			public PXTextEdit POReceipt__InvoiceNbr { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector SiteID { get; }
			public Selector UOM { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit CuryID { get; }
			public PXNumberEdit ReceiptQty { get; }
			public PXNumberEdit CuryExtCost { get; }
			public PXNumberEdit UnbilledQty { get; }
			public PXTextEdit TranDesc { get; }
			public Selector VendorID { get; }
			public Selector POReceipt__VendorLocationID { get; }
			public PXTextEdit ReceiptType { get; }
                
                public c_grid_row(c_poreceiptlinesselection_gridol grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddPOReceiptLine_gridOL", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    PONbr = new PXTextEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_ei", "Order Nbr.", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    POType = new DropDown("_ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_ec", "Order Type", grid.Locator, "POType");
                    POType.DataField = "POType";
                    POType.Items.Add("RO", "Normal");
                    POType.Items.Add("DP", "Drop-Ship");
                    POType.Items.Add("PD", "Project Drop-Ship");
                    POType.Items.Add("BL", "Blanket");
                    POType.Items.Add("SB", "Standard");
                    ReceiptNbr = new PXTextEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_ei", "Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                    POReceipt__InvoiceNbr = new PXTextEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_ei", "Vendor Ref.", grid.Locator, "POReceipt__InvoiceNbr");
                    POReceipt__InvoiceNbr.DataField = "POReceipt__InvoiceNbr";
                    InventoryID = new Selector("_ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SiteID = new Selector("_ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    UOM = new Selector("_ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    CuryID = new PXTextEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_em", "Order Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    ReceiptQty = new PXNumberEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_en", "Receipt Qty.", grid.Locator, "ReceiptQty");
                    ReceiptQty.DataField = "ReceiptQty";
                    CuryExtCost = new PXNumberEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_en", "Order Line Amount", grid.Locator, "CuryExtCost");
                    CuryExtCost.DataField = "CuryExtCost";
                    UnbilledQty = new PXNumberEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_en", "Unbilled Qty.", grid.Locator, "UnbilledQty");
                    UnbilledQty.DataField = "UnbilledQty";
                    TranDesc = new PXTextEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_ei", "Transaction Descr.", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    VendorID = new Selector("_ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_es", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    POReceipt__VendorLocationID = new Selector("_ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_es", "Location", grid.Locator, "POReceipt__VendorLocationID");
                    POReceipt__VendorLocationID.DataField = "POReceipt__VendorLocationID";
                    ReceiptType = new PXTextEdit("ctl00_phG_PanelAddPOReceiptLine_gridOL_ei", "Receipt Type", grid.Locator, "ReceiptType");
                    ReceiptType.DataField = "ReceiptType";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter PONbr { get; }
				public DropDownColumnFilter POType { get; }
				public PXTextEditColumnFilter ReceiptNbr { get; }
				public PXTextEditColumnFilter POReceipt__InvoiceNbr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter ReceiptQty { get; }
				public PXNumberEditColumnFilter CuryExtCost { get; }
				public PXNumberEditColumnFilter UnbilledQty { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public SelectorColumnFilter VendorID { get; }
				public SelectorColumnFilter POReceipt__VendorLocationID { get; }
				public PXTextEditColumnFilter ReceiptType { get; }
                
                public c_grid_header(c_poreceiptlinesselection_gridol grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    PONbr = new PXTextEditColumnFilter(grid.Row.PONbr);
                    POType = new DropDownColumnFilter(grid.Row.POType);
                    ReceiptNbr = new PXTextEditColumnFilter(grid.Row.ReceiptNbr);
                    POReceipt__InvoiceNbr = new PXTextEditColumnFilter(grid.Row.POReceipt__InvoiceNbr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    ReceiptQty = new PXNumberEditColumnFilter(grid.Row.ReceiptQty);
                    CuryExtCost = new PXNumberEditColumnFilter(grid.Row.CuryExtCost);
                    UnbilledQty = new PXNumberEditColumnFilter(grid.Row.UnbilledQty);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    POReceipt__VendorLocationID = new SelectorColumnFilter(grid.Row.POReceipt__VendorLocationID);
                    ReceiptType = new PXTextEditColumnFilter(grid.Row.ReceiptType);
                }
            }
        }
        
        public class c_poreceiptlinesselection_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_poreceiptlinesselection_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "poReceiptLinesSelection";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton3", "Add", "ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton4", "Add & Close", "ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddPOReceiptLine_PXButton5", "Cancel", "ctl00_phG_PanelAddPOReceiptLine_gridOL_lv0");
                }
            }
        }
        
        public class c_landedcostfilter_frmlcfilter : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector LandedCostDocRefNbr { get; }
			public Label LandedCostDocRefNbrLabel { get; }
			public Selector LandedCostCodeID { get; }
			public Label LandedCostCodeIDLabel { get; }
			public DropDown ReceiptType { get; }
			public Label ReceiptTypeLabel { get; }
			public Selector ReceiptNbr { get; }
			public Label ReceiptNbrLabel { get; }
			public DropDown OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
            
            public c_landedcostfilter_frmlcfilter(string locator, string name) : 
                    base(locator, name)
            {
                LandedCostDocRefNbr = new Selector("ctl00_phG_PanelAddLandedCost_frmLCFilter_edLandedCostDocRefNbr", "Landed Cost Doc Ref Nbr", locator, null);
                LandedCostDocRefNbrLabel = new Label(LandedCostDocRefNbr);
                LandedCostDocRefNbr.DataField = "LandedCostDocRefNbr";
                LandedCostCodeID = new Selector("ctl00_phG_PanelAddLandedCost_frmLCFilter_edLandedCostCodeID", "Landed Cost Code ID", locator, null);
                LandedCostCodeIDLabel = new Label(LandedCostCodeID);
                LandedCostCodeID.DataField = "LandedCostCodeID";
                ReceiptType = new DropDown("ctl00_phG_PanelAddLandedCost_frmLCFilter_edReceiptType", "Receipt Type", locator, null);
                ReceiptTypeLabel = new Label(ReceiptType);
                ReceiptType.DataField = "ReceiptType";
                ReceiptNbr = new Selector("ctl00_phG_PanelAddLandedCost_frmLCFilter_edReceiptNbr", "Receipt Nbr", locator, null);
                ReceiptNbrLabel = new Label(ReceiptNbr);
                ReceiptNbr.DataField = "ReceiptNbr";
                OrderType = new DropDown("ctl00_phG_PanelAddLandedCost_frmLCFilter_edPOOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phG_PanelAddLandedCost_frmLCFilter_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                DataMemberName = "landedCostFilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddLandedCost_PXButton16", "Add", "ctl00_phG_PanelAddLandedCost_frmLCFilter");
                    AddClose = new Button("ctl00_phG_PanelAddLandedCost_PXButton17", "Add & Close", "ctl00_phG_PanelAddLandedCost_frmLCFilter");
                    Cancel = new Button("ctl00_phG_PanelAddLandedCost_PXButton18", "Cancel", "ctl00_phG_PanelAddLandedCost_frmLCFilter");
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
        
        public class c_retainagedocuments_detgrid : Grid<c_retainagedocuments_detgrid.c_grid_row, c_retainagedocuments_detgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_retainagedocuments_detgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_detgrid");
                DataMemberName = "RetainageDocuments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_detgrid_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_detgrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public DropDown DocType { get; }
			public Selector RefNbr { get; }
			public DateSelector DocDate { get; }
			public Selector FinPeriodID { get; }
			public DropDown Status { get; }
			public PXNumberEdit CuryOrigDocAmt { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Selector APInvoice__PayTypeID { get; }
			public PXTextEdit APInvoice__InvoiceNbr { get; }
			public PXTextEdit DocDesc { get; }
                
                public c_grid_row(c_retainagedocuments_detgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    DocType = new DropDown("_ctl00_phG_tab_t5_detgrid_lv0_ec", "Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("INV", "Bill");
                    DocType.Items.Add("ACR", "Credit Adj.");
                    DocType.Items.Add("ADR", "Debit Adj.");
                    DocType.Items.Add("CHK", "Check");
                    DocType.Items.Add("VCK", "Voided Check");
                    DocType.Items.Add("PPM", "Prepayment");
                    DocType.Items.Add("REF", "Vendor Refund");
                    DocType.Items.Add("VRF", "Voided Refund");
                    DocType.Items.Add("QCK", "Quick Check");
                    DocType.Items.Add("VQC", "Void Quick Check");
                    DocType.Items.Add("PPR", "Prepayment Req.");
                    RefNbr = new Selector("_ctl00_phG_tab_t5_detgrid_lv0_es", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    DocDate = new DateSelector("_ctl00_phG_tab_t5_detgrid_lv0_ed4", "Date", grid.Locator, "DocDate");
                    DocDate.DataField = "DocDate";
                    FinPeriodID = new Selector("_ctl00_phG_tab_t5_detgrid_lv0_es", "Post Period", grid.Locator, "FinPeriodID");
                    FinPeriodID.DataField = "FinPeriodID";
                    Status = new DropDown("_ctl00_phG_tab_t5_detgrid_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Balanced");
                    Status.Items.Add("V", "Voided");
                    Status.Items.Add("S", "Scheduled");
                    Status.Items.Add("N", "Open");
                    Status.Items.Add("C", "Closed");
                    Status.Items.Add("P", "Printed");
                    Status.Items.Add("K", "Pre-Released");
                    Status.Items.Add("E", "Pending Approval");
                    Status.Items.Add("R", "Rejected");
                    Status.Items.Add("Z", "Reserved");
                    Status.Items.Add("G", "Pending Print");
                    Status.Items.Add("X", "Under Reclassification");
                    CuryOrigDocAmt = new PXNumberEdit("ctl00_phG_tab_t5_detgrid_en", "Amount", grid.Locator, "CuryOrigDocAmt");
                    CuryOrigDocAmt.DataField = "CuryOrigDocAmt";
                    CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t5_detgrid_en", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    APInvoice__PayTypeID = new Selector("_ctl00_phG_tab_t5_detgrid_lv0_es", "Payment Method", grid.Locator, "APInvoice__PayTypeID");
                    APInvoice__PayTypeID.DataField = "APInvoice__PayTypeID";
                    APInvoice__InvoiceNbr = new PXTextEdit("ctl00_phG_tab_t5_detgrid_ei", "Vendor Ref.", grid.Locator, "APInvoice__InvoiceNbr");
                    APInvoice__InvoiceNbr.DataField = "APInvoice__InvoiceNbr";
                    DocDesc = new PXTextEdit("ctl00_phG_tab_t5_detgrid_ei", "Description", grid.Locator, "DocDesc");
                    DocDesc.DataField = "DocDesc";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter DocType { get; }
				public SelectorColumnFilter RefNbr { get; }
				public DateSelectorColumnFilter DocDate { get; }
				public SelectorColumnFilter FinPeriodID { get; }
				public DropDownColumnFilter Status { get; }
				public PXNumberEditColumnFilter CuryOrigDocAmt { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public SelectorColumnFilter APInvoice__PayTypeID { get; }
				public PXTextEditColumnFilter APInvoice__InvoiceNbr { get; }
				public PXTextEditColumnFilter DocDesc { get; }
                
                public c_grid_header(c_retainagedocuments_detgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                    RefNbr = new SelectorColumnFilter(grid.Row.RefNbr);
                    DocDate = new DateSelectorColumnFilter(grid.Row.DocDate);
                    FinPeriodID = new SelectorColumnFilter(grid.Row.FinPeriodID);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    CuryOrigDocAmt = new PXNumberEditColumnFilter(grid.Row.CuryOrigDocAmt);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    APInvoice__PayTypeID = new SelectorColumnFilter(grid.Row.APInvoice__PayTypeID);
                    APInvoice__InvoiceNbr = new PXTextEditColumnFilter(grid.Row.APInvoice__InvoiceNbr);
                    DocDesc = new PXTextEditColumnFilter(grid.Row.DocDesc);
                }
            }
        }
        
        public class c_retainagedocuments_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_retainagedocuments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t5_detgrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t5_detgrid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t5_detgrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "RetainageDocuments";
            }
        }
        
        public class c_poorderslist_pxgrid1 : Grid<c_poorderslist_pxgrid1.c_grid_row, c_poorderslist_pxgrid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_poorderslist_pxgrid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddPOOrder_PXGrid1");
                DataMemberName = "poorderslist";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelAddPOOrder_PXGrid1_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddPOOrder_PXGrid1_fe_gf", "FilterForm");
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
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOOrder_PXGrid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOOrder_PXButton6", "Add", "ctl00_phG_PanelAddPOOrder_PXGrid1");
                    AddClose = new Button("ctl00_phG_PanelAddPOOrder_PXButton7", "Add & Close", "ctl00_phG_PanelAddPOOrder_PXGrid1");
                    Cancel = new Button("ctl00_phG_PanelAddPOOrder_PXButton8", "Cancel", "ctl00_phG_PanelAddPOOrder_PXGrid1");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public Selector OrderNbr { get; }
			public DropDown OrderType { get; }
			public Selector VendorID { get; }
			public Selector VendorLocationID { get; }
			public DateSelector OrderDate { get; }
			public Selector CuryID { get; }
			public PXNumberEdit CuryOrderTotal { get; }
			public PXNumberEdit UnbilledOrderQty { get; }
			public PXNumberEdit CuryUnbilledOrderTotal { get; }
                
                public c_grid_row(c_poorderslist_pxgrid1 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_PanelAddPOOrder_PXGrid1", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderNbr = new Selector("_ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_es", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    OrderType = new DropDown("_ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_ec", "Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderType.Items.Add("RO", "Normal");
                    OrderType.Items.Add("DP", "Drop-Ship");
                    OrderType.Items.Add("PD", "Project Drop-Ship");
                    OrderType.Items.Add("BL", "Blanket");
                    OrderType.Items.Add("SB", "Standard");
                    VendorID = new Selector("_ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_es", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorLocationID = new Selector("_ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_es", "Location", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    OrderDate = new DateSelector("_ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_ed7", "Date", grid.Locator, "OrderDate");
                    OrderDate.DataField = "OrderDate";
                    CuryID = new Selector("_ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    CuryOrderTotal = new PXNumberEdit("ctl00_phG_PanelAddPOOrder_PXGrid1_en", "Order Total", grid.Locator, "CuryOrderTotal");
                    CuryOrderTotal.DataField = "CuryOrderTotal";
                    UnbilledOrderQty = new PXNumberEdit("ctl00_phG_PanelAddPOOrder_PXGrid1_en", "Unbilled Qty.", grid.Locator, "UnbilledOrderQty");
                    UnbilledOrderQty.DataField = "UnbilledOrderQty";
                    CuryUnbilledOrderTotal = new PXNumberEdit("ctl00_phG_PanelAddPOOrder_PXGrid1_en", "Unbilled Amt.", grid.Locator, "CuryUnbilledOrderTotal");
                    CuryUnbilledOrderTotal.DataField = "CuryUnbilledOrderTotal";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public DropDownColumnFilter OrderType { get; }
				public SelectorColumnFilter VendorID { get; }
				public SelectorColumnFilter VendorLocationID { get; }
				public DateSelectorColumnFilter OrderDate { get; }
				public SelectorColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter CuryOrderTotal { get; }
				public PXNumberEditColumnFilter UnbilledOrderQty { get; }
				public PXNumberEditColumnFilter CuryUnbilledOrderTotal { get; }
                
                public c_grid_header(c_poorderslist_pxgrid1 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    OrderType = new DropDownColumnFilter(grid.Row.OrderType);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    VendorLocationID = new SelectorColumnFilter(grid.Row.VendorLocationID);
                    OrderDate = new DateSelectorColumnFilter(grid.Row.OrderDate);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    CuryOrderTotal = new PXNumberEditColumnFilter(grid.Row.CuryOrderTotal);
                    UnbilledOrderQty = new PXNumberEditColumnFilter(grid.Row.UnbilledOrderQty);
                    CuryUnbilledOrderTotal = new PXNumberEditColumnFilter(grid.Row.CuryUnbilledOrderTotal);
                }
            }
        }
        
        public class c_poorderslist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_poorderslist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelAddPOOrder_PXGrid1_lv0_ec", "Ec", locator, null);
                DataMemberName = "poorderslist";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOOrder_PXButton6", "Add", "ctl00_phG_PanelAddPOOrder_PXGrid1_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddPOOrder_PXButton7", "Add & Close", "ctl00_phG_PanelAddPOOrder_PXGrid1_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddPOOrder_PXButton8", "Cancel", "ctl00_phG_PanelAddPOOrder_PXGrid1_lv0");
                }
            }
        }
        
        public class c_subcontracts_pxgridsubcontract : Grid<c_subcontracts_pxgridsubcontract.c_grid_row, c_subcontracts_pxgridsubcontract.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_subcontracts_pxgridsubcontract(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddSubcontract_PXGridSubcontract");
                DataMemberName = "subcontracts";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_fe_gf", "FilterForm");
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
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_at_tlb div[data-cmd=\'Refresh" +
                            "\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_at_tlb div[data-cmd=\'AdjustC" +
                            "olumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_at_tlb div[data-cmd=\'ExportE" +
                            "xcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ab_tlb div[data-cmd=\'PageFir" +
                            "st\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ab_tlb div[data-cmd=\'PagePre" +
                            "v\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ab_tlb div[data-cmd=\'PageNex" +
                            "t\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ab_tlb div[data-cmd=\'PageLas" +
                            "t\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddSubcontract_btnAddSubcontract", "Add", "ctl00_phG_PanelAddSubcontract_PXGridSubcontract");
                    AddClose = new Button("ctl00_phG_PanelAddSubcontract_btnOkAddSubcontract", "Add & Close", "ctl00_phG_PanelAddSubcontract_PXGridSubcontract");
                    Cancel = new Button("ctl00_phG_PanelAddSubcontract_btnNoAddSubcontract", "Cancel", "ctl00_phG_PanelAddSubcontract_PXGridSubcontract");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit SubcontractNbr { get; }
			public PXTextEdit POLine__ProjectID { get; }
			public PXTextEdit VendorID { get; }
			public PXTextEdit VendorLocationID { get; }
			public PXTextEdit OrderDate { get; }
			public PXTextEdit CuryID { get; }
			public PXTextEdit SubcontractTotal { get; }
			public PXTextEdit SubcontractBilledQty { get; }
			public PXTextEdit CurySubcontractBilledTotal { get; }
                
                public c_grid_row(c_subcontracts_pxgridsubcontract grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    SubcontractNbr = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Subcontract Nbr", grid.Locator, "SubcontractNbr");
                    SubcontractNbr.DataField = "SubcontractNbr";
                    POLine__ProjectID = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "PO Line __ Project ID", grid.Locator, "POLine__ProjectID");
                    POLine__ProjectID.DataField = "POLine__ProjectID";
                    VendorID = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorLocationID = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Vendor Location ID", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    OrderDate = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Order Date", grid.Locator, "OrderDate");
                    OrderDate.DataField = "OrderDate";
                    CuryID = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Cury ID", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    SubcontractTotal = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Subcontract Total", grid.Locator, "SubcontractTotal");
                    SubcontractTotal.DataField = "SubcontractTotal";
                    SubcontractBilledQty = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Subcontract Billed Qty", grid.Locator, "SubcontractBilledQty");
                    SubcontractBilledQty.DataField = "SubcontractBilledQty";
                    CurySubcontractBilledTotal = new PXTextEdit("ctl00_phG_PanelAddSubcontract_PXGridSubcontract_ei", "Cury Subcontract Billed Total", grid.Locator, "CurySubcontractBilledTotal");
                    CurySubcontractBilledTotal.DataField = "CurySubcontractBilledTotal";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter SubcontractNbr { get; }
				public PXTextEditColumnFilter POLine__ProjectID { get; }
				public PXTextEditColumnFilter VendorID { get; }
				public PXTextEditColumnFilter VendorLocationID { get; }
				public PXTextEditColumnFilter OrderDate { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public PXTextEditColumnFilter SubcontractTotal { get; }
				public PXTextEditColumnFilter SubcontractBilledQty { get; }
				public PXTextEditColumnFilter CurySubcontractBilledTotal { get; }
                
                public c_grid_header(c_subcontracts_pxgridsubcontract grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    SubcontractNbr = new PXTextEditColumnFilter(grid.Row.SubcontractNbr);
                    POLine__ProjectID = new PXTextEditColumnFilter(grid.Row.POLine__ProjectID);
                    VendorID = new PXTextEditColumnFilter(grid.Row.VendorID);
                    VendorLocationID = new PXTextEditColumnFilter(grid.Row.VendorLocationID);
                    OrderDate = new PXTextEditColumnFilter(grid.Row.OrderDate);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    SubcontractTotal = new PXTextEditColumnFilter(grid.Row.SubcontractTotal);
                    SubcontractBilledQty = new PXTextEditColumnFilter(grid.Row.SubcontractBilledQty);
                    CurySubcontractBilledTotal = new PXTextEditColumnFilter(grid.Row.CurySubcontractBilledTotal);
                }
            }
        }
        
        public class c_jointpayeepayments_pxgridjointcheck : Grid<c_jointpayeepayments_pxgridjointcheck.c_grid_row, c_jointpayeepayments_pxgridjointcheck.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
            
            public c_jointpayeepayments_pxgridjointcheck(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelPayBillJC_PXGridJointCheck");
                DataMemberName = "JointPayeePayments";
                Buttons = new PxButtonCollection();
                QuickSearch = new QuickSearch("ctl00_phG_PanelPayBillJC_PXGridJointCheck_ab_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_PanelPayBillJC_PXGridJointCheck_fe_gf", "FilterForm");
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
            
            public virtual void Confirm()
            {
                Buttons.Confirm.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_at_tlb div[data-cmd=\'AdjustColumns" +
                            "\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_at_tlb div[data-cmd=\'ExportExcel\']" +
                            "", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelPayBillJC_PXGridJointCheck_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirm { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Confirm = new Button("ctl00_phG_PanelPayBillJC_btnOK123", "Confirm", "ctl00_phG_PanelPayBillJC_PXGridJointCheck");
                    Cancel = new Button("ctl00_phG_PanelPayBillJC_btnCancel123", "Cancel", "ctl00_phG_PanelPayBillJC_PXGridJointCheck");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit JointPayee__JointPayeeInternalId { get; }
			public PXTextEdit JointPayee__JointPayeeExternalName { get; }
			public PXTextEdit BillLineNumber { get; }
			public PXNumberEdit JointAmountToPay { get; }
			public PXTextEdit JointPayee__JointBalance { get; }
                
                public c_grid_row(c_jointpayeepayments_pxgridjointcheck grid) : 
                        base(grid)
                {
                    JointPayee__JointPayeeInternalId = new PXTextEdit("ctl00_phG_PanelPayBillJC_PXGridJointCheck_ei", "Joint Payee __ Joint Payee Internal Id", grid.Locator, "JointPayee__JointPayeeInternalId");
                    JointPayee__JointPayeeInternalId.DataField = "JointPayee__JointPayeeInternalId";
                    JointPayee__JointPayeeExternalName = new PXTextEdit("ctl00_phG_PanelPayBillJC_PXGridJointCheck_ei", "Joint Payee __ Joint Payee External Name", grid.Locator, "JointPayee__JointPayeeExternalName");
                    JointPayee__JointPayeeExternalName.DataField = "JointPayee__JointPayeeExternalName";
                    BillLineNumber = new PXTextEdit("ctl00_phG_PanelPayBillJC_PXGridJointCheck_ei", "Bill Line Number", grid.Locator, "BillLineNumber");
                    BillLineNumber.DataField = "BillLineNumber";
                    JointAmountToPay = new PXNumberEdit("_ctl00_phG_PanelPayBillJC_PXGridJointCheck_lv0_PXNumberEdit5", "Joint Amount To Pay", grid.Locator, "JointAmountToPay");
                    JointAmountToPay.DataField = "JointAmountToPay";
                    JointPayee__JointBalance = new PXTextEdit("ctl00_phG_PanelPayBillJC_PXGridJointCheck_ei", "Joint Payee __ Joint Balance", grid.Locator, "JointPayee__JointBalance");
                    JointPayee__JointBalance.DataField = "JointPayee__JointBalance";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter JointPayee__JointPayeeInternalId { get; }
				public PXTextEditColumnFilter JointPayee__JointPayeeExternalName { get; }
				public PXTextEditColumnFilter BillLineNumber { get; }
				public PXNumberEditColumnFilter JointAmountToPay { get; }
				public PXTextEditColumnFilter JointPayee__JointBalance { get; }
                
                public c_grid_header(c_jointpayeepayments_pxgridjointcheck grid) : 
                        base(grid)
                {
                    JointPayee__JointPayeeInternalId = new PXTextEditColumnFilter(grid.Row.JointPayee__JointPayeeInternalId);
                    JointPayee__JointPayeeExternalName = new PXTextEditColumnFilter(grid.Row.JointPayee__JointPayeeExternalName);
                    BillLineNumber = new PXTextEditColumnFilter(grid.Row.BillLineNumber);
                    JointAmountToPay = new PXNumberEditColumnFilter(grid.Row.JointAmountToPay);
                    JointPayee__JointBalance = new PXTextEditColumnFilter(grid.Row.JointPayee__JointBalance);
                }
            }
        }
        
        public class c_jointpayeepayments_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit JointAmountToPay { get; }
			public Label JointAmountToPayLabel { get; }
            
            public c_jointpayeepayments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                JointAmountToPay = new PXNumberEdit("ctl00_phG_PanelPayBillJC_PXGridJointCheck_lv0_PXNumberEdit5", "Joint Amount To Pay", locator, null);
                JointAmountToPayLabel = new Label(JointAmountToPay);
                JointAmountToPay.DataField = "JointAmountToPay";
                DataMemberName = "JointPayeePayments";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Confirm()
            {
                Buttons.Confirm.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Confirm { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Confirm = new Button("ctl00_phG_PanelPayBillJC_btnOK123", "Confirm", "ctl00_phG_PanelPayBillJC_PXGridJointCheck_lv0");
                    Cancel = new Button("ctl00_phG_PanelPayBillJC_btnCancel123", "Cancel", "ctl00_phG_PanelPayBillJC_PXGridJointCheck_lv0");
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
        
        public class c_transactions_importcsvsettings_frmimportcsvsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Separator { get; }
			public Label SeparatorLabel { get; }
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown CodePage { get; }
			public Label CodePageLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_transactions_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "Transactions$ImportCSVSettings";
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
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t0_grid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_transactions_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_transactions_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edNullValue" +
                        "", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "Transactions$ImportXLSXSettings";
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
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t0_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                }
            }
        }
        
        public class c_transactions_importcolumns_grdimportcolumn : Grid<c_transactions_importcolumns_grdimportcolumn.c_grid_row, c_transactions_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_transactions_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "Transactions$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_transactions_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_transactions_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_transactions_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_transactions_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Transactions$ImportColumns";
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
                    First = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t0_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t0_grid_imp_importColumnDlg_grdImportColumn_lv0");
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
