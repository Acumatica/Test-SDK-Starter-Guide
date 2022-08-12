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


namespace GeneratedWrappers.ISVTEST
{
    
    
    public class SO303000_SOInvoiceEntry : Wrapper
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
        protected c_currentdocument_commission CurrentDocument_Commission { get; } = new c_currentdocument_commission("ctl00_phG_tab_t2_Commission", "CurrentDocument_Commission");
        protected c_currentdocument_formg CurrentDocument_formG { get; } = new c_currentdocument_formg("ctl00_phG_tab_t3_formG", "CurrentDocument_formG");
        protected c_currentdocument_formpt CurrentDocument_formPT { get; } = new c_currentdocument_formpt("ctl00_phG_tab_t7_formPT", "CurrentDocument_formPT");
        protected c_rutrots_rutrotform Rutrots_RUTROTForm { get; } = new c_rutrots_rutrotform("ctl00_phG_tab_t8_RUTROTForm", "Rutrots_RUTROTForm");
        protected c_sodocument_formp SODocument_formP { get; } = new c_sodocument_formp("ctl00_phG_tab_t4_formP", "SODocument_formP");
        protected c_transactions_grid Transactions_grid { get; } = new c_transactions_grid("ctl00_phG_tab_t0_grid", "Transactions_grid");
        protected c_transactions_lv0 Transactions_lv0 { get; } = new c_transactions_lv0("ctl00_phG_tab_t0_grid_lv0", "Transactions_lv0");
        protected c_taxes_grid1 Taxes_grid1 { get; } = new c_taxes_grid1("ctl00_phG_tab_t1_grid1", "Taxes_grid1");
        protected c_taxes_lv0 Taxes_lv0 { get; } = new c_taxes_lv0("ctl00_phG_tab_t1_grid1_lv0", "Taxes_lv0");
        protected c_adjustments_detgrid Adjustments_detgrid { get; } = new c_adjustments_detgrid("ctl00_phG_tab_t7_detgrid", "Adjustments_detgrid");
        protected c_adjustments_lv0 Adjustments_lv0 { get; } = new c_adjustments_lv0("ctl00_phG_tab_t7_detgrid_lv0", "Adjustments_lv0");
        protected c_adjustments_1_detgrid2 Adjustments_1_detgrid2 { get; } = new c_adjustments_1_detgrid2("ctl00_phG_tab_t7_detgrid2", "Adjustments_1_detgrid2");
        protected c_adjustments_1_lv0 Adjustments_1_lv0 { get; } = new c_adjustments_1_lv0("ctl00_phG_tab_t7_detgrid2_lv0", "Adjustments_1_lv0");
        protected c_shipping_address_shipping_address Shipping_Address_Shipping_Address { get; } = new c_shipping_address_shipping_address("ctl00_phG_tab_t5_Shipping_Address", "Shipping_Address_Shipping_Address");
        protected c_currentdocument_address CurrentDocument_Address { get; } = new c_currentdocument_address("ctl00_phG_tab_t5_Shipping_Address", "CurrentDocument_Address");
        protected c_shipping_contact_shipping_contact Shipping_Contact_Shipping_Contact { get; } = new c_shipping_contact_shipping_contact("ctl00_phG_tab_t5_Shipping_Contact", "Shipping_Contact_Shipping_Contact");
        protected c_billing_address_forma Billing_Address_formA { get; } = new c_billing_address_forma("ctl00_phG_tab_t5_formA", "Billing_Address_formA");
        protected c_billing_contact_formc Billing_Contact_formC { get; } = new c_billing_contact_formc("ctl00_phG_tab_t5_formC", "Billing_Contact_formC");
        protected c_recalcdiscountsfilter_formrecalcdiscounts Recalcdiscountsfilter_formrecalcdiscounts { get; } = new c_recalcdiscountsfilter_formrecalcdiscounts("ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts", "recalcdiscountsfilter_formRecalcDiscounts");
        protected c_ardiscountdetails_discountdetailgrid ARDiscountDetails_discountDetailGrid { get; } = new c_ardiscountdetails_discountdetailgrid("ctl00_phG_tab_t6_discountDetailGrid", "ARDiscountDetails_discountDetailGrid");
        protected c_ardiscountdetails_lv0 ARDiscountDetails_lv0 { get; } = new c_ardiscountdetails_lv0("ctl00_phG_tab_t6_discountDetailGrid_lv0", "ARDiscountDetails_lv0");
        protected c_salespertrans_gridsalespertran SalesPerTrans_gridSalesPerTran { get; } = new c_salespertrans_gridsalespertran("ctl00_phG_tab_t2_gridSalesPerTran", "SalesPerTrans_gridSalesPerTran");
        protected c_salespertrans_lv0 SalesPerTrans_lv0 { get; } = new c_salespertrans_lv0("ctl00_phG_tab_t2_gridSalesPerTran_lv0", "SalesPerTrans_lv0");
        protected c_rrdistribution_griddistribution RRDistribution_gridDistribution { get; } = new c_rrdistribution_griddistribution("ctl00_phG_tab_t8_RUTROTForm_gridDistribution", "RRDistribution_gridDistribution");
        protected c_rrdistribution_lv0 RRDistribution_lv0 { get; } = new c_rrdistribution_lv0("ctl00_phG_tab_t8_RUTROTForm_gridDistribution_lv0", "RRDistribution_lv0");
        protected c_duplicatefilter_pxformviewpanelduplicate Duplicatefilter_pxformviewpanelduplicate { get; } = new c_duplicatefilter_pxformviewpanelduplicate("ctl00_phG_panelDuplicate_PXFormViewPanelDuplicate", "duplicatefilter_PXFormViewPanelDuplicate");
        protected c_shipmentlist_grid4 Shipmentlist_grid4 { get; } = new c_shipmentlist_grid4("ctl00_phG_PanelAddShipment_grid4", "shipmentlist_grid4");
        protected c_shipmentlist_lv0 Shipmentlist_lv0 { get; } = new c_shipmentlist_lv0("ctl00_phG_PanelAddShipment_grid4_lv0", "shipmentlist_lv0");
        protected c_freightdetails_gridfreightdetails FreightDetails_gridFreightDetails { get; } = new c_freightdetails_gridfreightdetails("ctl00_phG_tab_t3_gridFreightDetails", "FreightDetails_gridFreightDetails");
        protected c_freightdetails_lv0 FreightDetails_lv0 { get; } = new c_freightdetails_lv0("ctl00_phG_tab_t3_gridFreightDetails_lv0", "FreightDetails_lv0");
        protected c_addresslookupfilter_addresslookuppanelformaddress AddressLookupFilter_AddressLookupPanelformAddress { get; } = new c_addresslookupfilter_addresslookuppanelformaddress("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress", "AddressLookupFilter_AddressLookupPanelformAddress");
        protected c_relateditemsfilter_fvrelateditemsheader RelatedItemsFilter_fvRelatedItemsHeader { get; } = new c_relateditemsfilter_fvrelateditemsheader("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader", "RelatedItemsFilter_fvRelatedItemsHeader");
        protected c_allrelateditems_gridallrelateditems Allrelateditems_gridallrelateditems { get; } = new c_allrelateditems_gridallrelateditems("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems", "allRelatedItems_gridAllRelatedItems");
        protected c_allrelateditems_lv0 Allrelateditems_lv0 { get; } = new c_allrelateditems_lv0("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0", "allRelatedItems_lv0");
        protected c_substituteitems_gridsubstituteitems Substituteitems_gridsubstituteitems { get; } = new c_substituteitems_gridsubstituteitems("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems", "substituteItems_gridSubstituteItems");
        protected c_substituteitems_lv0 Substituteitems_lv0 { get; } = new c_substituteitems_lv0("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0", "substituteItems_lv0");
        protected c_upsellitems_gridupsellitems Upsellitems_gridupsellitems { get; } = new c_upsellitems_gridupsellitems("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems", "upSellItems_gridUpSellItems");
        protected c_upsellitems_lv0 Upsellitems_lv0 { get; } = new c_upsellitems_lv0("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0", "upSellItems_lv0");
        protected c_crosssellitems_gridcrosssellitems Crosssellitems_gridcrosssellitems { get; } = new c_crosssellitems_gridcrosssellitems("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems", "crossSellItems_gridCrossSellItems");
        protected c_crosssellitems_lv0 Crosssellitems_lv0 { get; } = new c_crosssellitems_lv0("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0", "crossSellItems_lv0");
        protected c_otherrelateditems_gridotherrelateditems Otherrelateditems_gridotherrelateditems { get; } = new c_otherrelateditems_gridotherrelateditems("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems", "otherRelatedItems_gridOtherRelatedItems");
        protected c_otherrelateditems_lv0 Otherrelateditems_lv0 { get; } = new c_otherrelateditems_lv0("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0", "otherRelatedItems_lv0");
        protected c_artranlist_gridartranlist Artranlist_gridartranlist { get; } = new c_artranlist_gridartranlist("ctl00_phG_PanelAddARTran_gridARTranList", "arTranList_gridARTranList");
        protected c_artranlist_lv0 Artranlist_lv0 { get; } = new c_artranlist_lv0("ctl00_phG_PanelAddARTran_gridARTranList_lv0", "arTranList_lv0");
        protected c_solinelist_gridsolinelist Solinelist_gridsolinelist { get; } = new c_solinelist_gridsolinelist("ctl00_phG_PanelAddSOLine_gridSOLineList", "soLineList_gridSOLineList");
        protected c_solinelist_lv0 Solinelist_lv0 { get; } = new c_solinelist_lv0("ctl00_phG_PanelAddSOLine_gridSOLineList_lv0", "soLineList_lv0");
        protected c_quickpayment_createpaymentformview QuickPayment_CreatePaymentFormView { get; } = new c_quickpayment_createpaymentformview("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView", "QuickPayment_CreatePaymentFormView");
        protected c_importexternaltran_importpaymentformview ImportExternalTran_ImportPaymentFormView { get; } = new c_importexternaltran_importpaymentformview("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView", "ImportExternalTran_ImportPaymentFormView");
        protected c_workflowview_workflowfictivediagram WorkflowView_WorkflowFictiveDiagram { get; } = new c_workflowview_workflowfictivediagram("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram", "WorkflowView_WorkflowFictiveDiagram");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public SO303000_SOInvoiceEntry()
        {
            ScreenId = "SO303000";
            ScreenUrl = "/Pages/SO/SO303000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual SO303000_SOInvoiceEntry ReadOne(Gate gate, string DocType, string RefNbr)
        {
            new BiObject<SO303000_SOInvoiceEntry>(gate).ReadOne(this, DocType, RefNbr);
            return this;
        }
        
        public virtual SO303000_SOInvoiceEntry ReadOne(string DocType, string RefNbr)
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
        
        public virtual void VoidCheck()
        {
            ToolBar.VoidCheck.Click();
        }
        
        public virtual void VoidCheck(bool status, string message = null)
        {
            ToolBar.VoidCheck.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.VoidCheck.Click();
        }
        
        public virtual void Action()
        {
            ToolBar.Action.Click();
        }
        
        public virtual void Inquiry()
        {
            ToolBar.Inquiry.Click();
        }
        
        public virtual void ProcessingCategory()
        {
            ToolBar.ProcessingCategory.Click();
        }
        
        public virtual void CorrectionsCategory()
        {
            ToolBar.CorrectionsCategory.Click();
        }
        
        public virtual void ApprovalCategory()
        {
            ToolBar.ApprovalCategory.Click();
        }
        
        public virtual void PrintingAndEmailingCategory()
        {
            ToolBar.PrintingAndEmailingCategory.Click();
        }
        
        public virtual void OtherCategory()
        {
            ToolBar.OtherCategory.Click();
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
        
        public virtual void Notification()
        {
            ToolBar.Notification.Click();
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
        
        public virtual void CorrectInvoice()
        {
            ToolBar.CorrectInvoice.Click();
        }
        
        public virtual void CancelInvoice()
        {
            ToolBar.CancelInvoice.Click();
        }
        
        public virtual void WriteOff()
        {
            ToolBar.WriteOff.Click();
        }
        
        public virtual void ReclassifyBatch()
        {
            ToolBar.ReclassifyBatch.Click();
        }
        
        public virtual void ReleaseFromCreditHold()
        {
            ToolBar.ReleaseFromCreditHold.Click();
        }
        
        public virtual void PutOnCreditHold()
        {
            ToolBar.PutOnCreditHold.Click();
        }
        
        public virtual void PrintInvoice()
        {
            ToolBar.PrintInvoice.Click();
        }
        
        public virtual void EmailInvoice()
        {
            ToolBar.EmailInvoice.Click();
        }
        
        public virtual void RecalculateDiscountsAction()
        {
            ToolBar.RecalculateDiscountsAction.Click();
        }
        
        public virtual void Post()
        {
            ToolBar.Post.Click();
        }
        
        public virtual void Post(bool status, string message = null)
        {
            ToolBar.Post.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Post.Click();
        }
        
        public virtual void ValidateAddresses()
        {
            ToolBar.ValidateAddresses.Click();
        }
        
        public virtual void AREdit()
        {
            ToolBar.AREdit.Click();
        }
        
        public virtual void PrintAREdit()
        {
            ToolBar.PrintAREdit.Click();
        }
        
        public virtual void PrintARRegister()
        {
            ToolBar.PrintARRegister.Click();
        }
        
        public virtual void CreateAndCapturePayment()
        {
            ToolBar.CreateAndCapturePayment.Click();
        }
        
        public virtual void ReverseInvoiceAndApplyToMemo()
        {
            ToolBar.ReverseInvoiceAndApplyToMemo.Click();
        }
        
        public virtual void ReverseInvoice()
        {
            ToolBar.ReverseInvoice.Click();
        }
        
        public virtual void SendEmail()
        {
            ToolBar.SendEmail.Click();
        }
        
        public virtual void PutOnHold()
        {
            ToolBar.PutOnHold.Click();
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
        
        public virtual void ViewRetainageDocument()
        {
            ToolBar.ViewRetainageDocument.Click();
        }
        
        public virtual void CreateAndAuthorizePayment()
        {
            ToolBar.CreateAndAuthorizePayment.Click();
        }
        
        public virtual void SyncPaymentTransaction()
        {
            ToolBar.SyncPaymentTransaction.Click();
        }
        
        public virtual void SyncPaymentTransaction(bool status, string message = null)
        {
            ToolBar.SyncPaymentTransaction.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.SyncPaymentTransaction.Click();
        }
        
        public virtual void SoordershipmentDisplayshippingrefnoteidLink()
        {
            ToolBar.SoordershipmentDisplayshippingrefnoteidLink.Click();
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
			public ToolBarButton VoidCheck { get; }
			public ToolBarButton Action { get; }
			public ToolBarButton Inquiry { get; }
			public ToolBarButton ProcessingCategory { get; }
			public ToolBarButton CorrectionsCategory { get; }
			public ToolBarButton ApprovalCategory { get; }
			public ToolBarButton PrintingAndEmailingCategory { get; }
			public ToolBarButton OtherCategory { get; }
			public ToolBarButton Report { get; }
			public ToolBarButton ViewActivity { get; }
			public ToolBarButton ViewactivityWorkflow { get; }
			public ToolBarButton OpenActivityOwner { get; }
			public ToolBarButton OpenactivityownerWorkflow { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton ViewallactivitiesWorkflow { get; }
			public ToolBarButton Notification { get; }
			public ToolBarButton Release { get; }
			public ToolBarButton PayInvoice { get; }
			public ToolBarButton CorrectInvoice { get; }
			public ToolBarButton CancelInvoice { get; }
			public ToolBarButton WriteOff { get; }
			public ToolBarButton ReclassifyBatch { get; }
			public ToolBarButton ReleaseFromCreditHold { get; }
			public ToolBarButton PutOnCreditHold { get; }
			public ToolBarButton PrintInvoice { get; }
			public ToolBarButton EmailInvoice { get; }
			public ToolBarButton RecalculateDiscountsAction { get; }
			public ToolBarButton Post { get; }
			public ToolBarButton ValidateAddresses { get; }
			public ToolBarButton AREdit { get; }
			public ToolBarButton PrintAREdit { get; }
			public ToolBarButton PrintARRegister { get; }
			public ToolBarButton CreateAndCapturePayment { get; }
			public ToolBarButton ReverseInvoiceAndApplyToMemo { get; }
			public ToolBarButton ReverseInvoice { get; }
			public ToolBarButton SendEmail { get; }
			public ToolBarButton PutOnHold { get; }
			public ToolBarButton ReleaseRetainage { get; }
			public ToolBarButton ViewRetainageDocument { get; }
			public ToolBarButton CreateAndAuthorizePayment { get; }
			public ToolBarButton SyncPaymentTransaction { get; }
			public ToolBarButton SoordershipmentDisplayshippingrefnoteidLink { get; }
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
                Delete.ConfirmAction = () => Alert.AlertToException("The current AR Invoice/Memo record will be deleted.");
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
                VoidCheck = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VoidCheck,#ctl00_phDS_ds_ToolBar_VoidCheck_item", "Void", locator, MenuOpener);
                VoidCheck.WaitAction = Wait.WaitForLongOperationToComplete;
                Action = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Action", "Actions", locator, MenuOpener);
                Inquiry = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Inquiry", "Inquiries", locator, MenuOpener);
                ProcessingCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Processing_Category", "Processing", locator, MenuOpener);
                CorrectionsCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Corrections_Category", "Corrections", locator, MenuOpener);
                ApprovalCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Approval_Category", "Approval", locator, MenuOpener);
                PrintingAndEmailingCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Printing_and_Emailing_Category", "Printing and Emailing", locator, MenuOpener);
                OtherCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Other_Category", "Other", locator, MenuOpener);
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
                Notification = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Notification,#ctl00_phDS_ds_ToolBar_Notification_item", "Notifications", locator, MenuOpener);
                Release = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Release,#ctl00_phDS_ds_ToolBar_Release_item", "Release", locator, MenuOpener);
                Release.WaitAction = Wait.WaitForLongOperationToComplete;
                PayInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PayInvoice,#ctl00_phDS_ds_ToolBar_PayInvoice_item", "Pay", locator, MenuOpener);
                CorrectInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CorrectInvoice,#ctl00_phDS_ds_ToolBar_CorrectInvoice_i" +
                        "tem", "Correct Invoice", locator, MenuOpener);
                CancelInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CancelInvoice,#ctl00_phDS_ds_ToolBar_CancelInvoice_ite" +
                        "m", "Cancel Invoice", locator, MenuOpener);
                WriteOff = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_WriteOff,#ctl00_phDS_ds_ToolBar_WriteOff_item", "Write Off", locator, MenuOpener);
                ReclassifyBatch = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReclassifyBatch,#ctl00_phDS_ds_ToolBar_ReclassifyBatch" +
                        "_item", "Reclassify GL Batch", locator, MenuOpener);
                ReleaseFromCreditHold = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReleaseFromCreditHold,#ctl00_phDS_ds_ToolBar_ReleaseFr" +
                        "omCreditHold_item", "Remove Credit Hold", locator, MenuOpener);
                PutOnCreditHold = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PutOnCreditHold,#ctl00_phDS_ds_ToolBar_PutOnCreditHold" +
                        "_item", "Credit Hold", locator, MenuOpener);
                PrintInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintInvoice,#ctl00_phDS_ds_ToolBar_PrintInvoice_item", "Print Invoice", locator, MenuOpener);
                EmailInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_EmailInvoice,#ctl00_phDS_ds_ToolBar_EmailInvoice_item", "Email Invoice", locator, MenuOpener);
                RecalculateDiscountsAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_RecalculateDiscountsAction,#ctl00_phDS_ds_ToolBar_Reca" +
                        "lculateDiscountsAction_item", "Recalculate Prices", locator, MenuOpener);
                Post = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Post,#ctl00_phDS_ds_ToolBar_Post_item", "Post Invoice to IN", locator, MenuOpener);
                Post.WaitAction = Wait.WaitForLongOperationToComplete;
                ValidateAddresses = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ValidateAddresses,#ctl00_phDS_ds_ToolBar_ValidateAddre" +
                        "sses_item", "Validate Addresses", locator, MenuOpener);
                AREdit = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_AREdit,#ctl00_phDS_ds_ToolBar_AREdit_item", "AR Edit", locator, MenuOpener);
                PrintAREdit = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintAREdit,#ctl00_phDS_ds_ToolBar_PrintAREdit_item", "AR Edit Detailed", locator, MenuOpener);
                PrintARRegister = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintARRegister,#ctl00_phDS_ds_ToolBar_PrintARRegister" +
                        "_item", "AR Register Detailed", locator, MenuOpener);
                CreateAndCapturePayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreateAndCapturePayment,#ctl00_phDS_ds_ToolBar_CreateA" +
                        "ndCapturePayment_item", "Create and Capture", locator, MenuOpener);
                ReverseInvoiceAndApplyToMemo = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReverseInvoiceAndApplyToMemo,#ctl00_phDS_ds_ToolBar_Re" +
                        "verseInvoiceAndApplyToMemo_item", "Reverse and Apply to Memo", locator, MenuOpener);
                ReverseInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReverseInvoice,#ctl00_phDS_ds_ToolBar_ReverseInvoice_i" +
                        "tem", "Reverse", locator, MenuOpener);
                SendEmail = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SendEmail,#ctl00_phDS_ds_ToolBar_SendEmail_item", "Send Email", locator, MenuOpener);
                PutOnHold = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PutOnHold,#ctl00_phDS_ds_ToolBar_PutOnHold_item", "Hold", locator, MenuOpener);
                ReleaseRetainage = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReleaseRetainage,#ctl00_phDS_ds_ToolBar_ReleaseRetaina" +
                        "ge_item", "Release Retainage", locator, MenuOpener);
                ReleaseRetainage.WaitAction = Wait.WaitForLongOperationToComplete;
                ViewRetainageDocument = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_viewRetainageDocument,#ctl00_phDS_ds_ToolBar_viewRetai" +
                        "nageDocument_item", "viewRetainageDocument", locator, MenuOpener);
                CreateAndAuthorizePayment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreateAndAuthorizePayment,#ctl00_phDS_ds_ToolBar_Creat" +
                        "eAndAuthorizePayment_item", "Create and Authorize", locator, MenuOpener);
                SyncPaymentTransaction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SyncPaymentTransaction,#ctl00_phDS_ds_ToolBar_SyncPaym" +
                        "entTransaction_item", "SyncPaymentTransaction", locator, MenuOpener);
                SyncPaymentTransaction.WaitAction = Wait.WaitForLongOperationToComplete;
                SoordershipmentDisplayshippingrefnoteidLink = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SOOrderShipment~DisplayShippingRefNoteID~Link,#ctl00_p" +
                        "hDS_ds_ToolBar_SOOrderShipment~DisplayShippingRefNoteID~Link_item", "SOOrderShipment\r\nDisplayShippingRefNoteID\r\nLink", locator, MenuOpener);
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
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public PXTextEdit DocDesc { get; }
			public Label DocDescLabel { get; }
			public Selector CustomerID { get; }
			public Label CustomerIDLabel { get; }
			public Selector CustomerLocationID { get; }
			public Label CustomerLocationIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBoxButton CuryViewState { get; }
			public Label CuryViewStateLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public DateSelector DueDate { get; }
			public Label DueDateLabel { get; }
			public DateSelector DiscDate { get; }
			public Label DiscDateLabel { get; }
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
			public PXNumberEdit CuryBalanceWOTotal { get; }
			public Label CuryBalanceWOTotalLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public PXNumberEdit CuryOrigDocAmt { get; }
			public Label CuryOrigDocAmtLabel { get; }
			public PXNumberEdit CuryOrigDiscAmt { get; }
			public Label CuryOrigDiscAmtLabel { get; }
			public CheckBox IsRUTROTDeductible { get; }
			public Label IsRUTROTDeductibleLabel { get; }
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
                DocType.Items.Add("INV", "Invoice");
                DocType.Items.Add("DRM", "Debit Memo");
                DocType.Items.Add("CRM", "Credit Memo");
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
                DocDate = new DateSelector("ctl00_phF_form_t0_edDocDate", "Date", locator, null);
                DocDateLabel = new Label(DocDate);
                DocDate.DataField = "DocDate";
                FinPeriodID = new Selector("ctl00_phF_form_t0_edFinPeriodID", "Post Period", locator, null);
                FinPeriodIDLabel = new Label(FinPeriodID);
                FinPeriodID.DataField = "FinPeriodID";
                InvoiceNbr = new PXTextEdit("ctl00_phF_form_t0_edInvoiceNbr", "Customer Order Nbr.", locator, null);
                InvoiceNbrLabel = new Label(InvoiceNbr);
                InvoiceNbr.DataField = "InvoiceNbr";
                ProjectID = new Selector("ctl00_phF_form_t0_edProjectID", "Project/Contract", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                DocDesc = new PXTextEdit("ctl00_phF_form_t0_edDocDesc", "Description", locator, null);
                DocDescLabel = new Label(DocDesc);
                DocDesc.DataField = "DocDesc";
                CustomerID = new Selector("ctl00_phF_form_t0_edCustomerID", "Customer", locator, null);
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.DataField = "CustomerID";
                CustomerLocationID = new Selector("ctl00_phF_form_t0_edCustomerLocationID", "Location", locator, null);
                CustomerLocationIDLabel = new Label(CustomerLocationID);
                CustomerLocationID.DataField = "CustomerLocationID";
                CuryID = new Selector("ctl00_phF_form_t0_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phF_form_t0_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                TermsID = new Selector("ctl00_phF_form_t0_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                DueDate = new DateSelector("ctl00_phF_form_t0_edDueDate", "Due Date", locator, null);
                DueDateLabel = new Label(DueDate);
                DueDate.DataField = "DueDate";
                DiscDate = new DateSelector("ctl00_phF_form_t0_edDiscDate", "Cash Discount Date", locator, null);
                DiscDateLabel = new Label(DiscDate);
                DiscDate.DataField = "DiscDate";
                CuryLineTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryLineTotal", "Detail Total", locator, null);
                CuryLineTotalLabel = new Label(CuryLineTotal);
                CuryLineTotal.DataField = "CuryLineTotal";
                CuryDiscTot = new PXNumberEdit("ctl00_phF_form_t0_edCuryDiscTot", "Discount Total", locator, null);
                CuryDiscTotLabel = new Label(CuryDiscTot);
                CuryDiscTot.DataField = "CuryDiscTot";
                CuryVatTaxableTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryVatTaxableTotal", "VAT Taxable Total", locator, null);
                CuryVatTaxableTotalLabel = new Label(CuryVatTaxableTotal);
                CuryVatTaxableTotal.DataField = "CuryVatTaxableTotal";
                CuryVatExemptTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryVatExemptTotal", "VAT Exempt Total", locator, null);
                CuryVatExemptTotalLabel = new Label(CuryVatExemptTotal);
                CuryVatExemptTotal.DataField = "CuryVatExemptTotal";
                CuryTaxTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryTaxTotal2", "Tax Total", locator, null);
                CuryTaxTotalLabel = new Label(CuryTaxTotal);
                CuryTaxTotal.DataField = "CuryTaxTotal";
                CuryBalanceWOTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryBalanceWOTotal", "Write-Off Total", locator, null);
                CuryBalanceWOTotalLabel = new Label(CuryBalanceWOTotal);
                CuryBalanceWOTotal.DataField = "CuryBalanceWOTotal";
                CuryDocBal = new PXNumberEdit("ctl00_phF_form_t0_edCuryDocBal", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                CuryOrigDocAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrigDocAmt", "Amount", locator, null);
                CuryOrigDocAmtLabel = new Label(CuryOrigDocAmt);
                CuryOrigDocAmt.DataField = "CuryOrigDocAmt";
                CuryOrigDiscAmt = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrigDiscAmt", "Cash Discount", locator, null);
                CuryOrigDiscAmtLabel = new Label(CuryOrigDiscAmt);
                CuryOrigDiscAmt.DataField = "CuryOrigDiscAmt";
                IsRUTROTDeductible = new CheckBox("ctl00_phF_form_t0_chkRUTROT", "ROT and RUT deductible document", locator, null);
                IsRUTROTDeductibleLabel = new Label(IsRUTROTDeductible);
                IsRUTROTDeductible.DataField = "IsRUTROTDeductible";
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
            
            public virtual void ProjectIDEdit()
            {
                Buttons.ProjectIDEdit.Click();
            }
            
            public virtual void CustomerIDEdit()
            {
                Buttons.CustomerIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
			public Button ProjectIDEdit { get; }
			public Button CustomerIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phF_form_t0_edCury_rateB", "0", "ctl00_phF_form");
                    Viewbase = new Button("ctl00_phF_form_t0_edCury_curyB", "View base", "ctl00_phF_form");
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form");
                    ProjectIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edProjectID\'] div[class=\'editBtnCont\'] > div > div", "ProjectIDEdit", "ctl00_phF_form");
                    ProjectIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    CustomerIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edCustomerID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "CustomerIDEdit", "ctl00_phF_form");
                    CustomerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
			public PXTextEdit CorrectionRefNbr { get; }
			public Label CorrectionRefNbrLabel { get; }
			public TreeSelector WorkgroupID { get; }
			public Label WorkgroupIDLabel { get; }
			public Selector OwnerID { get; }
			public Label OwnerIDLabel { get; }
			public CheckBox DontPrint { get; }
			public Label DontPrintLabel { get; }
			public CheckBox Printed { get; }
			public Label PrintedLabel { get; }
			public CheckBox DontEmail { get; }
			public Label DontEmailLabel { get; }
			public CheckBox Emailed { get; }
			public Label EmailedLabel { get; }
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
			public PXTextEdit ExternalTaxExemptionNumber { get; }
			public Label ExternalTaxExemptionNumberLabel { get; }
			public DropDown AvalaraCustomerUsageType { get; }
			public Label AvalaraCustomerUsageTypeLabel { get; }
			public PXNumberEdit CuryDiscountedDocTotal { get; }
			public Label CuryDiscountedDocTotalLabel { get; }
			public PXNumberEdit CuryDiscountedTaxableTotal { get; }
			public Label CuryDiscountedTaxableTotalLabel { get; }
			public PXNumberEdit CuryDiscountedPrice { get; }
			public Label CuryDiscountedPriceLabel { get; }
			public Label Space_ { get; }
            
            public c_currentdocument_tab(string locator, string name) : 
                    base(locator, name)
            {
                BatchNbr = new Selector("ctl00_phG_tab_t4_edBatchNbr", "Batch Nbr.", locator, null);
                BatchNbrLabel = new Label(BatchNbr);
                BatchNbr.DataField = "BatchNbr";
                BranchID = new Selector("ctl00_phG_tab_t4_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                ARAccountID = new Selector("ctl00_phG_tab_t4_edARAccountID", "AR Account", locator, null);
                ARAccountIDLabel = new Label(ARAccountID);
                ARAccountID.DataField = "ARAccountID";
                ARSubID = new Selector("ctl00_phG_tab_t4_edARSubID", "AR Subaccount", locator, null);
                ARSubIDLabel = new Label(ARSubID);
                ARSubID.DataField = "ARSubID";
                OrigRefNbr = new PXTextEdit("ctl00_phG_tab_t4_edOrigRefNbr", "Original Document", locator, null);
                OrigRefNbrLabel = new Label(OrigRefNbr);
                OrigRefNbr.DataField = "OrigRefNbr";
                CorrectionRefNbr = new PXTextEdit("ctl00_phG_tab_t4_edCorrectionRefNbr", "Correction Document", locator, null);
                CorrectionRefNbrLabel = new Label(CorrectionRefNbr);
                CorrectionRefNbr.DataField = "CorrectionRefNbr";
                WorkgroupID = new TreeSelector("ctl00_phG_tab_t4_edWorkgroupID", "Workgroup ID", locator, null);
                WorkgroupIDLabel = new Label(WorkgroupID);
                WorkgroupID.DataField = "WorkgroupID";
                OwnerID = new Selector("ctl00_phG_tab_t4_edOwnerID", "Owner", locator, null);
                OwnerIDLabel = new Label(OwnerID);
                OwnerID.DataField = "OwnerID";
                DontPrint = new CheckBox("ctl00_phG_tab_t4_chkDontPrint", "Don\'t Print", locator, null);
                DontPrintLabel = new Label(DontPrint);
                DontPrint.DataField = "DontPrint";
                Printed = new CheckBox("ctl00_phG_tab_t4_chkPrinted", "Printed", locator, null);
                PrintedLabel = new Label(Printed);
                Printed.DataField = "Printed";
                DontEmail = new CheckBox("ctl00_phG_tab_t4_chkDontEmail", "Don\'t Email", locator, null);
                DontEmailLabel = new Label(DontEmail);
                DontEmail.DataField = "DontEmail";
                Emailed = new CheckBox("ctl00_phG_tab_t4_chkEmailed", "Emailed", locator, null);
                EmailedLabel = new Label(Emailed);
                Emailed.DataField = "Emailed";
                TaxZoneID = new Selector("ctl00_phG_tab_t4_edTaxZoneID", "Customer Tax Zone", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                TaxCalcMode = new DropDown("ctl00_phG_tab_t4_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                ExternalTaxExemptionNumber = new PXTextEdit("ctl00_phG_tab_t4_edExternalTaxExemptionNumber", "Tax Exemption Number", locator, null);
                ExternalTaxExemptionNumberLabel = new Label(ExternalTaxExemptionNumber);
                ExternalTaxExemptionNumber.DataField = "ExternalTaxExemptionNumber";
                AvalaraCustomerUsageType = new DropDown("ctl00_phG_tab_t4_edAvalaraCustomerUsageTypeID", "Entity Usage Type", locator, null);
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
                CuryDiscountedDocTotal = new PXNumberEdit("ctl00_phG_tab_t4_edCuryDiscountedDocTotal", "Discounted Doc. Total", locator, null);
                CuryDiscountedDocTotalLabel = new Label(CuryDiscountedDocTotal);
                CuryDiscountedDocTotal.DataField = "CuryDiscountedDocTotal";
                CuryDiscountedTaxableTotal = new PXNumberEdit("ctl00_phG_tab_t4_edCuryDiscountedTaxableTotal", "Discounted Taxable Total", locator, null);
                CuryDiscountedTaxableTotalLabel = new Label(CuryDiscountedTaxableTotal);
                CuryDiscountedTaxableTotal.DataField = "CuryDiscountedTaxableTotal";
                CuryDiscountedPrice = new PXNumberEdit("ctl00_phG_tab_t4_edCuryDiscountedPrice", "Tax on Discounted Price", locator, null);
                CuryDiscountedPriceLabel = new Label(CuryDiscountedPrice);
                CuryDiscountedPrice.DataField = "CuryDiscountedPrice";
                Space_ = new Label("ctl00_phG_tab_t7_formPT_space", "Space _", locator, null);
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
                SalesPersonID = new Selector("ctl00_phG_tab_t2_Commission_edSalesPersonID", "Default Salesperson", locator, null);
                SalesPersonIDLabel = new Label(SalesPersonID);
                SalesPersonID.DataField = "SalesPersonID";
                CuryCommnblAmt = new PXNumberEdit("ctl00_phG_tab_t2_Commission_edCuryCommnblAmt", "Total Commissionable", locator, null);
                CuryCommnblAmtLabel = new Label(CuryCommnblAmt);
                CuryCommnblAmt.DataField = "CuryCommnblAmt";
                CuryCommnAmt = new PXNumberEdit("ctl00_phG_tab_t2_Commission_edCuryCommnAmt", "Commission Amt.", locator, null);
                CuryCommnAmtLabel = new Label(CuryCommnAmt);
                CuryCommnAmt.DataField = "CuryCommnAmt";
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_currentdocument_formg : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit CuryFreightAmt { get; }
			public Label CuryFreightAmtLabel { get; }
			public PXNumberEdit CuryPremiumFreightAmt { get; }
			public Label CuryPremiumFreightAmtLabel { get; }
            
            public c_currentdocument_formg(string locator, string name) : 
                    base(locator, name)
            {
                CuryFreightAmt = new PXNumberEdit("ctl00_phG_tab_t3_formG_edCuryFreightAmt", "Freight Price", locator, null);
                CuryFreightAmtLabel = new Label(CuryFreightAmt);
                CuryFreightAmt.DataField = "CuryFreightAmt";
                CuryPremiumFreightAmt = new PXNumberEdit("ctl00_phG_tab_t3_formG_edCuryPremiumFreightAmt", "Premium Freight Price", locator, null);
                CuryPremiumFreightAmtLabel = new Label(CuryPremiumFreightAmt);
                CuryPremiumFreightAmt.DataField = "CuryPremiumFreightAmt";
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
            }
            
            public virtual void ShipmentNbrEdit()
            {
                Buttons.ShipmentNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderNbrEdit { get; }
			public Button ShipmentNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_gridFreightDetails_lv0_edOrderNbr\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "OrderNbrEdit", "ctl00_phG_tab_t3_formG");
                    OrderNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ShipmentNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipmentNbr\'] div[class=\'ed" +
                            "itBtnCont\'] > div > div", "ShipmentNbrEdit", "ctl00_phG_tab_t3_formG");
                    ShipmentNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_currentdocument_formpt : Container
        {
            
			public PXNumberEdit CuryUnreleasedPaymentAmt { get; }
			public Label CuryUnreleasedPaymentAmtLabel { get; }
			public PXNumberEdit CuryCCAuthorizedAmt { get; }
			public Label CuryCCAuthorizedAmtLabel { get; }
			public PXNumberEdit CuryPaidAmt { get; }
			public Label CuryPaidAmtLabel { get; }
			public PXNumberEdit CuryPaymentTotal { get; }
			public Label CuryPaymentTotalLabel { get; }
			public PXNumberEdit CuryUnpaidBalance { get; }
			public Label CuryUnpaidBalanceLabel { get; }
			public Label Space_ { get; }
            
            public c_currentdocument_formpt(string locator, string name) : 
                    base(locator, name)
            {
                CuryUnreleasedPaymentAmt = new PXNumberEdit("ctl00_phG_tab_t7_formPT_edCuryUnreleasedPaymentAmt", "Not Released", locator, null);
                CuryUnreleasedPaymentAmtLabel = new Label(CuryUnreleasedPaymentAmt);
                CuryUnreleasedPaymentAmt.DataField = "CuryUnreleasedPaymentAmt";
                CuryCCAuthorizedAmt = new PXNumberEdit("ctl00_phG_tab_t7_formPT_edCuryCCAuthorizedAmt", "Authorized", locator, null);
                CuryCCAuthorizedAmtLabel = new Label(CuryCCAuthorizedAmt);
                CuryCCAuthorizedAmt.DataField = "CuryCCAuthorizedAmt";
                CuryPaidAmt = new PXNumberEdit("ctl00_phG_tab_t7_formPT_edCuryPaidAmt", "Released", locator, null);
                CuryPaidAmtLabel = new Label(CuryPaidAmt);
                CuryPaidAmt.DataField = "CuryPaidAmt";
                CuryPaymentTotal = new PXNumberEdit("ctl00_phG_tab_t7_formPT_edCuryPaymentTotal", "Total Paid", locator, null);
                CuryPaymentTotalLabel = new Label(CuryPaymentTotal);
                CuryPaymentTotal.DataField = "CuryPaymentTotal";
                CuryUnpaidBalance = new PXNumberEdit("ctl00_phG_tab_t7_formPT_edCuryUnpaidBalance", "Unpaid Balance", locator, null);
                CuryUnpaidBalanceLabel = new Label(CuryUnpaidBalance);
                CuryUnpaidBalance.DataField = "CuryUnpaidBalance";
                Space_ = new Label("ctl00_phG_tab_t7_formPT_space", "Space _", locator, null);
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_rutrots_rutrotform : Container
        {
            
			public CheckBox AutoDistribution { get; }
			public Label AutoDistributionLabel { get; }
			public GroupBox RUTROTType { get; }
			public Label RUTROTTypeLabel { get; }
			public PXTextEdit ROTAppartment { get; }
			public Label ROTAppartmentLabel { get; }
			public PXTextEdit ROTEstate { get; }
			public Label ROTEstateLabel { get; }
			public PXTextEdit ROTOrganizationNbr { get; }
			public Label ROTOrganizationNbrLabel { get; }
			public PXNumberEdit DeductionPct { get; }
			public Label DeductionPctLabel { get; }
			public PXNumberEdit CuryTotalAmt { get; }
			public Label CuryTotalAmtLabel { get; }
			public PXNumberEdit CuryOtherCost { get; }
			public Label CuryOtherCostLabel { get; }
			public PXNumberEdit CuryMaterialCost { get; }
			public Label CuryMaterialCostLabel { get; }
			public PXNumberEdit CuryWorkPrice { get; }
			public Label CuryWorkPriceLabel { get; }
			public PXNumberEdit CuryDistributedAmt { get; }
			public Label CuryDistributedAmtLabel { get; }
			public PXNumberEdit CuryUndistributedAmt { get; }
			public Label CuryUndistributedAmtLabel { get; }
            
            public c_rutrots_rutrotform(string locator, string name) : 
                    base(locator, name)
            {
                AutoDistribution = new CheckBox("ctl00_phG_tab_t8_RUTROTForm_chkRRAutoDistribution", "Distribute Automatically", locator, null);
                AutoDistributionLabel = new Label(AutoDistribution);
                AutoDistribution.DataField = "AutoDistribution";
                RUTROTType = new GroupBox("ctl00_phG_tab_t8_RUTROTForm_gbRRType", "RUTROT Type", locator, null);
                RUTROTTypeLabel = new Label(RUTROTType);
                RUTROTType.DataField = "RUTROTType";
                ROTAppartment = new PXTextEdit("ctl00_phG_tab_t8_RUTROTForm_edRAppartment", "Apartment", locator, null);
                ROTAppartmentLabel = new Label(ROTAppartment);
                ROTAppartment.DataField = "ROTAppartment";
                ROTEstate = new PXTextEdit("ctl00_phG_tab_t8_RUTROTForm_edRREstate", "Real estate", locator, null);
                ROTEstateLabel = new Label(ROTEstate);
                ROTEstate.DataField = "ROTEstate";
                ROTOrganizationNbr = new PXTextEdit("ctl00_phG_tab_t8_RUTROTForm_edRROrganizationNbr", "Organization nbr.", locator, null);
                ROTOrganizationNbrLabel = new Label(ROTOrganizationNbr);
                ROTOrganizationNbr.DataField = "ROTOrganizationNbr";
                DeductionPct = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_edRRDeduction", "Deduction,%", locator, null);
                DeductionPctLabel = new Label(DeductionPct);
                DeductionPct.DataField = "DeductionPct";
                CuryTotalAmt = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_edRRTotalAmt", "Total Deductible Amount", locator, null);
                CuryTotalAmtLabel = new Label(CuryTotalAmt);
                CuryTotalAmt.DataField = "CuryTotalAmt";
                CuryOtherCost = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_edRUTROTOtherCost", "Other Cost", locator, null);
                CuryOtherCostLabel = new Label(CuryOtherCost);
                CuryOtherCost.DataField = "CuryOtherCost";
                CuryMaterialCost = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_edRUTROTMaterialCost", "Material Cost", locator, null);
                CuryMaterialCostLabel = new Label(CuryMaterialCost);
                CuryMaterialCost.DataField = "CuryMaterialCost";
                CuryWorkPrice = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_edRUTROTWorkPrice", "Work Price", locator, null);
                CuryWorkPriceLabel = new Label(CuryWorkPrice);
                CuryWorkPrice.DataField = "CuryWorkPrice";
                CuryDistributedAmt = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_edRRAvailAmt", "Distributed Amount", locator, null);
                CuryDistributedAmtLabel = new Label(CuryDistributedAmt);
                CuryDistributedAmt.DataField = "CuryDistributedAmt";
                CuryUndistributedAmt = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_edRRUndsitributedAmt", "Undistributed Amount", locator, null);
                CuryUndistributedAmtLabel = new Label(CuryUndistributedAmt);
                CuryUndistributedAmt.DataField = "CuryUndistributedAmt";
                DataMemberName = "Rutrots";
            }
        }
        
        public class c_sodocument_formp : Container
        {
            
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public Selector PMInstanceID { get; }
			public Label PMInstanceIDLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public PXTextEdit ExtRefNbr { get; }
			public Label ExtRefNbrLabel { get; }
            
            public c_sodocument_formp(string locator, string name) : 
                    base(locator, name)
            {
                PaymentMethodID = new Selector("ctl00_phG_tab_t4_formP_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                PMInstanceID = new Selector("ctl00_phG_tab_t4_formP_edPMInstanceID", "Card/Account Nbr.", locator, null);
                PMInstanceIDLabel = new Label(PMInstanceID);
                PMInstanceID.DataField = "PMInstanceID";
                CashAccountID = new Selector("ctl00_phG_tab_t4_formP_edCashAccountID", "Cash Account", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                ExtRefNbr = new PXTextEdit("ctl00_phG_tab_t4_formP_edExtRefNbr", "Payment Ref.", locator, null);
                ExtRefNbrLabel = new Label(ExtRefNbr);
                ExtRefNbr.DataField = "ExtRefNbr";
                DataMemberName = "SODocument";
            }
        }
        
        public class c_transactions_grid : Grid<c_transactions_grid.c_grid_row, c_transactions_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_transactions_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grid");
                DataMemberName = "Transactions";
                Buttons = new PxButtonCollection();
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
            
            public virtual void AddOrder()
            {
                ToolBar.AddOrder.Click();
            }
            
            public virtual void AddSoLine()
            {
                ToolBar.AddSoLine.Click();
            }
            
            public virtual void AddReturnLine()
            {
                ToolBar.AddReturnLine.Click();
            }
            
            public virtual void ViewDeferrals()
            {
                ToolBar.ViewDeferrals.Click();
            }
            
            public virtual void ViewItem()
            {
                ToolBar.ViewItem.Click();
            }
            
            public virtual void ResetOrder()
            {
                ToolBar.ResetOrder.Click();
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
            
            public virtual void FSARTran__ReplaceSMEquipmentIDEdit()
            {
                Buttons.FSARTran__ReplaceSMEquipmentIDEdit.Click();
            }
            
            public virtual void FSARTran__SMEquipmentIDEdit()
            {
                Buttons.FSARTran__SMEquipmentIDEdit.Click();
            }
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void InvtRefNbrEdit()
            {
                Buttons.InvtRefNbrEdit.Click();
            }
            
            public virtual void BlanketNbrEdit()
            {
                Buttons.BlanketNbrEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid FormView { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid AddOrder { get; }
			public ToolBarButtonGrid AddSoLine { get; }
			public ToolBarButtonGrid AddReturnLine { get; }
			public ToolBarButtonGrid ViewDeferrals { get; }
			public ToolBarButtonGrid ViewItem { get; }
			public ToolBarButtonGrid ResetOrder { get; }
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
                    AddOrder = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdShipmentList\']", "Add Order", locator, null);
                    AddSoLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdSOLineList\']", "Add SO Line", locator, null);
                    AddReturnLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdARTranList\']", "Add Return Line", locator, null);
                    ViewDeferrals = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdViewSchedule\']", "View Deferrals", locator, null);
                    ViewItem = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ViewItem\']", "View Item", locator, null);
                    ResetOrder = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdResetOrder\']", "Reset Order", locator, null);
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
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button FSARTran__ReplaceSMEquipmentIDEdit { get; }
			public Button FSARTran__SMEquipmentIDEdit { get; }
			public Button DiscountIDEdit { get; }
			public Button InvtRefNbrEdit { get; }
			public Button BlanketNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    FSARTran__ReplaceSMEquipmentIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edReplaceSMEquipmentID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "FSARTran__ReplaceSMEquipmentIDEdit", "ctl00_phG_tab_t0_grid");
                    FSARTran__ReplaceSMEquipmentIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    FSARTran__SMEquipmentIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edSMEquipmentID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "FSARTran__SMEquipmentIDEdit", "ctl00_phG_tab_t0_grid");
                    FSARTran__SMEquipmentIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edDiscountCode\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DiscountIDEdit", "ctl00_phG_tab_t0_grid");
                    DiscountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvtRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edInvtRefNbr\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "InvtRefNbrEdit", "ctl00_phG_tab_t0_grid");
                    InvtRefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BlanketNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edBlanketNbr\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "BlanketNbrEdit", "ctl00_phG_tab_t0_grid");
                    BlanketNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector BranchID { get; }
			public PXTextEdit TranType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit SortOrder { get; }
			public DropDown LineType { get; }
			public Selector SOShipmentNbr { get; }
			public PXTextEdit SOOrderType { get; }
			public Selector SOOrderNbr { get; }
			public PXTextEdit AssociatedOrderLineNbr { get; }
			public PXTextEdit GiftMessage { get; }
			public Selector InventoryID { get; }
			public PXTextEdit RelatedItems { get; }
			public CheckBox SubstitutionRequired { get; }
			public Selector SubItemID { get; }
			public Selector FSARTran__ReplaceSMEquipmentID { get; }
			public DropDown FSARTran__EquipmentAction { get; }
			public PXTextEdit FSARTran__Comment { get; }
			public Selector FSARTran__SMEquipmentID { get; }
			public Selector FSARTran__NewEquipmentLineNbr { get; }
			public Selector FSARTran__ComponentID { get; }
			public Selector FSARTran__EquipmentComponentLineNbr { get; }
			public PXTextEdit FSARTran__RelatedDocument { get; }
			public PXTextEdit TranDesc { get; }
			public Selector SiteID { get; }
			public Selector LocationID { get; }
			public PXNumberEdit Qty { get; }
			public PXNumberEdit BaseQty { get; }
			public Selector UOM { get; }
			public Selector LotSerialNbr { get; }
			public DateSelector ExpireDate { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public CheckBox ManualPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public PXNumberEdit DiscPct { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public CheckBox ManualDisc { get; }
			public Selector DiscountID { get; }
			public PXTextEdit DiscountSequenceID { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public Selector AccountID { get; }
			public PXTextEdit AccountID_Account_description { get; }
			public Selector SubID { get; }
			public Selector ExpenseAccrualAccountID { get; }
			public PXTextEdit ExpenseAccrualAccountID_Account_description { get; }
			public Selector ExpenseAccrualSubID { get; }
			public Selector ExpenseAccountID { get; }
			public PXTextEdit ExpenseAccountID_Account_description { get; }
			public Selector ExpenseSubID { get; }
			public DropDown CostBasis { get; }
			public PXNumberEdit CuryAccruedCost { get; }
			public Selector TaskID { get; }
			public Selector CostCodeID { get; }
			public Selector SalesPersonID { get; }
			public Selector DeferredCode { get; }
			public DateSelector DRTermStartDate { get; }
			public DateSelector DRTermEndDate { get; }
			public Selector DefScheduleID { get; }
			public Selector TaxCategoryID { get; }
			public DropDown AvalaraCustomerUsageType { get; }
			public CheckBox Commissionable { get; }
			public PXNumberEdit SOOrderLineNbr { get; }
			public CheckBox IsRUTROTDeductible { get; }
			public DropDown RUTROTItemType { get; }
			public Selector RUTROTWorkTypeID { get; }
			public PXNumberEdit CuryRUTROTAvailableAmt { get; }
			public DropDown OrigInvoiceType { get; }
			public Selector OrigInvoiceNbr { get; }
			public PXNumberEdit OrigInvoiceLineNbr { get; }
			public DropDown InvtDocType { get; }
			public Selector InvtRefNbr { get; }
			public Selector BlanketNbr { get; }
                
                public c_grid_row(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    BranchID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    TranType = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranType", "Tran. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    RefNbr = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edRefNbr", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Line Order", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    LineType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_ec", "Line Type", grid.Locator, "LineType");
                    LineType.DataField = "LineType";
                    LineType.Items.Add("GI", "Goods for Inventory");
                    LineType.Items.Add("GN", "Non-Inventory Goods");
                    LineType.Items.Add("MI", "Misc. Charge");
                    SOShipmentNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSOShipmentNbr", "Shipment Nbr.", grid.Locator, "SOShipmentNbr");
                    SOShipmentNbr.DataField = "SOShipmentNbr";
                    SOOrderType = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edSOOrderType1", "Order Type", grid.Locator, "SOOrderType");
                    SOOrderType.DataField = "SOOrderType";
                    SOOrderNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSOOrderNbr1", "Order Nbr.", grid.Locator, "SOOrderNbr");
                    SOOrderNbr.DataField = "SOOrderNbr";
                    AssociatedOrderLineNbr = new PXTextEdit("ctl00_phG_tab_t0_grid", "Associated Order Line Nbr.", grid.Locator, "AssociatedOrderLineNbr");
                    AssociatedOrderLineNbr.DataField = "AssociatedOrderLineNbr";
                    GiftMessage = new PXTextEdit("ctl00_phG_tab_t0_grid", "Gift Message", grid.Locator, "GiftMessage");
                    GiftMessage.DataField = "GiftMessage";
                    InventoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    RelatedItems = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Related Items", grid.Locator, "RelatedItems");
                    RelatedItems.DataField = "RelatedItems";
                    SubstitutionRequired = new CheckBox("ctl00_phG_tab_t0_grid_ef", "Substitution Required", grid.Locator, "SubstitutionRequired");
                    SubstitutionRequired.DataField = "SubstitutionRequired";
                    SubItemID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    FSARTran__ReplaceSMEquipmentID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edReplaceSMEquipmentID", "Suspended Target Equipment ID", grid.Locator, "FSARTran__ReplaceSMEquipmentID");
                    FSARTran__ReplaceSMEquipmentID.DataField = "FSARTran__ReplaceSMEquipmentID";
                    FSARTran__EquipmentAction = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edEquipmentAction", "Equipment Action", grid.Locator, "FSARTran__EquipmentAction");
                    FSARTran__EquipmentAction.DataField = "FSARTran__EquipmentAction";
                    FSARTran__EquipmentAction.Items.Add("NO", "N/A");
                    FSARTran__EquipmentAction.Items.Add("ST", "Selling Model Equipment");
                    FSARTran__EquipmentAction.Items.Add("RT", "Replacing Target Equipment");
                    FSARTran__EquipmentAction.Items.Add("CC", "Selling Optional Component");
                    FSARTran__EquipmentAction.Items.Add("UC", "Upgrading Component");
                    FSARTran__EquipmentAction.Items.Add("RC", "Replacing Component");
                    FSARTran__Comment = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Equipment Action Comment", grid.Locator, "FSARTran__Comment");
                    FSARTran__Comment.DataField = "FSARTran__Comment";
                    FSARTran__SMEquipmentID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSMEquipmentID", "Target Equipment ID", grid.Locator, "FSARTran__SMEquipmentID");
                    FSARTran__SMEquipmentID.DataField = "FSARTran__SMEquipmentID";
                    FSARTran__NewEquipmentLineNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edNewEquipmentLineNbr", "Model Equipment Line Nbr.", grid.Locator, "FSARTran__NewEquipmentLineNbr");
                    FSARTran__NewEquipmentLineNbr.DataField = "FSARTran__NewEquipmentLineNbr";
                    FSARTran__ComponentID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSMComponentID", "Component ID", grid.Locator, "FSARTran__ComponentID");
                    FSARTran__ComponentID.DataField = "FSARTran__ComponentID";
                    FSARTran__EquipmentComponentLineNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edEquipmentComponentLineNbr", "Component Line Nbr.", grid.Locator, "FSARTran__EquipmentComponentLineNbr");
                    FSARTran__EquipmentComponentLineNbr.DataField = "FSARTran__EquipmentComponentLineNbr";
                    FSARTran__RelatedDocument = new PXTextEdit("ctl00_phG_tab_t0_grid", "Related Svc. Doc. Nbr.", grid.Locator, "FSARTran__RelatedDocument");
                    FSARTran__RelatedDocument.DataField = "FSARTran__RelatedDocument";
                    TranDesc = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranDesc1", "Transaction Descr.", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    SiteID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LocationID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    BaseQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Base Qty.", grid.Locator, "BaseQty");
                    BaseQty.DataField = "BaseQty";
                    UOM = new Selector("_ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    LotSerialNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    ExpireDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
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
                    ManualDisc = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkManualDisc", "Manual Discount", grid.Locator, "ManualDisc");
                    ManualDisc.DataField = "ManualDisc";
                    DiscountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDiscountCode", "Discount Code", grid.Locator, "DiscountID");
                    DiscountID.DataField = "DiscountID";
                    DiscountSequenceID = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Discount Sequence", grid.Locator, "DiscountSequenceID");
                    DiscountSequenceID.DataField = "DiscountSequenceID";
                    CuryTranAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryTranAmt1", "Amount", grid.Locator, "CuryTranAmt");
                    CuryTranAmt.DataField = "CuryTranAmt";
                    AccountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edAccountID1", "Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    AccountID_Account_description = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Description", grid.Locator, "AccountID_Account_description");
                    AccountID_Account_description.DataField = "AccountID_Account_description";
                    SubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubID1", "Subaccount", grid.Locator, "SubID");
                    SubID.DataField = "SubID";
                    ExpenseAccrualAccountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edExpenseAccrualAccountID", "Expense Accrual Account", grid.Locator, "ExpenseAccrualAccountID");
                    ExpenseAccrualAccountID.DataField = "ExpenseAccrualAccountID";
                    ExpenseAccrualAccountID_Account_description = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Description", grid.Locator, "ExpenseAccrualAccountID_Account_description");
                    ExpenseAccrualAccountID_Account_description.DataField = "ExpenseAccrualAccountID_Account_description";
                    ExpenseAccrualSubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edExpenseAccrualSubID", "Expense Accrual Subaccount", grid.Locator, "ExpenseAccrualSubID");
                    ExpenseAccrualSubID.DataField = "ExpenseAccrualSubID";
                    ExpenseAccountID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edExpenseAccountID", "Expense Account", grid.Locator, "ExpenseAccountID");
                    ExpenseAccountID.DataField = "ExpenseAccountID";
                    ExpenseAccountID_Account_description = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Description", grid.Locator, "ExpenseAccountID_Account_description");
                    ExpenseAccountID_Account_description.DataField = "ExpenseAccountID_Account_description";
                    ExpenseSubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edExpenseSubID", "Expense Subaccount", grid.Locator, "ExpenseSubID");
                    ExpenseSubID.DataField = "ExpenseSubID";
                    CostBasis = new DropDown("_ctl00_phG_tab_t0_grid_lv0_cmbCostBasis", "Cost Based On", grid.Locator, "CostBasis");
                    CostBasis.DataField = "CostBasis";
                    CostBasis.Items.Add("S", "Standard Cost");
                    CostBasis.Items.Add("M", "Markup %");
                    CostBasis.Items.Add("P", "Percentage of Sales Price");
                    CuryAccruedCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryAccruedCost", "Cost Accrual", grid.Locator, "CuryAccruedCost");
                    CuryAccruedCost.DataField = "CuryAccruedCost";
                    TaskID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_es", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    SalesPersonID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSalesPersonID1", "Salesperson ID", grid.Locator, "SalesPersonID");
                    SalesPersonID.DataField = "SalesPersonID";
                    DeferredCode = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDeferredCode", "Deferral Code", grid.Locator, "DeferredCode");
                    DeferredCode.DataField = "DeferredCode";
                    DRTermStartDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edDRTermStartDate", "Term Start Date", grid.Locator, "DRTermStartDate");
                    DRTermStartDate.DataField = "DRTermStartDate";
                    DRTermEndDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edDRTermEndDate", "Term End Date", grid.Locator, "DRTermEndDate");
                    DRTermEndDate.DataField = "DRTermEndDate";
                    DefScheduleID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edDefScheduleID", "Original Deferral Schedule", grid.Locator, "DefScheduleID");
                    DefScheduleID.DataField = "DefScheduleID";
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID1", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    AvalaraCustomerUsageType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edAvalaraCustomerUsageTypeID1", "Entity Usage Type", grid.Locator, "AvalaraCustomerUsageType");
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
                    Commissionable = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkCommissionable", "Commissionable", grid.Locator, "Commissionable");
                    Commissionable.DataField = "Commissionable";
                    SOOrderLineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Order Line Nbr", grid.Locator, "SOOrderLineNbr");
                    SOOrderLineNbr.DataField = "SOOrderLineNbr";
                    IsRUTROTDeductible = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkRRDeductibleTran", "ROT or RUT deductible", grid.Locator, "IsRUTROTDeductible");
                    IsRUTROTDeductible.DataField = "IsRUTROTDeductible";
                    RUTROTItemType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_cmbRRItemType", "Item Type", grid.Locator, "RUTROTItemType");
                    RUTROTItemType.DataField = "RUTROTItemType";
                    RUTROTWorkTypeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_cmbRRWorkType", "Type of Work", grid.Locator, "RUTROTWorkTypeID");
                    RUTROTWorkTypeID.DataField = "RUTROTWorkTypeID";
                    CuryRUTROTAvailableAmt = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edRRAvailable", "Deductible Amount", grid.Locator, "CuryRUTROTAvailableAmt");
                    CuryRUTROTAvailableAmt.DataField = "CuryRUTROTAvailableAmt";
                    OrigInvoiceType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_ec", "Orig. Inv. Type", grid.Locator, "OrigInvoiceType");
                    OrigInvoiceType.DataField = "OrigInvoiceType";
                    OrigInvoiceType.Items.Add("INV", "Invoice");
                    OrigInvoiceType.Items.Add("DRM", "Debit Memo");
                    OrigInvoiceType.Items.Add("CRM", "Credit Memo");
                    OrigInvoiceType.Items.Add("PMT", "Payment");
                    OrigInvoiceType.Items.Add("RPM", "Voided Payment");
                    OrigInvoiceType.Items.Add("PPM", "Prepayment");
                    OrigInvoiceType.Items.Add("REF", "Customer Refund");
                    OrigInvoiceType.Items.Add("VRF", "Voided Refund");
                    OrigInvoiceType.Items.Add("FCH", "Overdue Charge");
                    OrigInvoiceType.Items.Add("SMB", "Balance WO");
                    OrigInvoiceType.Items.Add("SMC", "Credit WO");
                    OrigInvoiceType.Items.Add("CSL", "Cash Sale");
                    OrigInvoiceType.Items.Add("RCS", "Cash Return");
                    OrigInvoiceNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_es", "Orig. Inv. Nbr.", grid.Locator, "OrigInvoiceNbr");
                    OrigInvoiceNbr.DataField = "OrigInvoiceNbr";
                    OrigInvoiceLineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Orig. Inv. Line Nbr.", grid.Locator, "OrigInvoiceLineNbr");
                    OrigInvoiceLineNbr.DataField = "OrigInvoiceLineNbr";
                    InvtDocType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_ec", "Inventory Doc. Type", grid.Locator, "InvtDocType");
                    InvtDocType.DataField = "InvtDocType";
                    InvtDocType.Items.Add("I", "Issue");
                    InvtDocType.Items.Add("R", "Receipt");
                    InvtDocType.Items.Add("T", "Transfer");
                    InvtDocType.Items.Add("A", "Adjustment");
                    InvtDocType.Items.Add("P", "Production");
                    InvtDocType.Items.Add("D", "Disassembly");
                    InvtRefNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edInvtRefNbr", "Inventory Ref. Nbr.", grid.Locator, "InvtRefNbr");
                    InvtRefNbr.DataField = "InvtRefNbr";
                    BlanketNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edBlanketNbr", "Blanket SO Ref. Nbr.", grid.Locator, "BlanketNbr");
                    BlanketNbr.DataField = "BlanketNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter BranchID { get; }
				public PXTextEditColumnFilter TranType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public DropDownColumnFilter LineType { get; }
				public SelectorColumnFilter SOShipmentNbr { get; }
				public PXTextEditColumnFilter SOOrderType { get; }
				public SelectorColumnFilter SOOrderNbr { get; }
				public PXTextEditColumnFilter AssociatedOrderLineNbr { get; }
				public PXTextEditColumnFilter GiftMessage { get; }
				public SelectorColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter RelatedItems { get; }
				public CheckBoxColumnFilter SubstitutionRequired { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter FSARTran__ReplaceSMEquipmentID { get; }
				public DropDownColumnFilter FSARTran__EquipmentAction { get; }
				public PXTextEditColumnFilter FSARTran__Comment { get; }
				public SelectorColumnFilter FSARTran__SMEquipmentID { get; }
				public SelectorColumnFilter FSARTran__NewEquipmentLineNbr { get; }
				public SelectorColumnFilter FSARTran__ComponentID { get; }
				public SelectorColumnFilter FSARTran__EquipmentComponentLineNbr { get; }
				public PXTextEditColumnFilter FSARTran__RelatedDocument { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter LocationID { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXNumberEditColumnFilter BaseQty { get; }
				public SelectorColumnFilter UOM { get; }
				public SelectorColumnFilter LotSerialNbr { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public CheckBoxColumnFilter ManualPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public PXNumberEditColumnFilter DiscPct { get; }
				public PXNumberEditColumnFilter CuryDiscAmt { get; }
				public CheckBoxColumnFilter ManualDisc { get; }
				public SelectorColumnFilter DiscountID { get; }
				public PXTextEditColumnFilter DiscountSequenceID { get; }
				public PXNumberEditColumnFilter CuryTranAmt { get; }
				public SelectorColumnFilter AccountID { get; }
				public PXTextEditColumnFilter AccountID_Account_description { get; }
				public SelectorColumnFilter SubID { get; }
				public SelectorColumnFilter ExpenseAccrualAccountID { get; }
				public PXTextEditColumnFilter ExpenseAccrualAccountID_Account_description { get; }
				public SelectorColumnFilter ExpenseAccrualSubID { get; }
				public SelectorColumnFilter ExpenseAccountID { get; }
				public PXTextEditColumnFilter ExpenseAccountID_Account_description { get; }
				public SelectorColumnFilter ExpenseSubID { get; }
				public DropDownColumnFilter CostBasis { get; }
				public PXNumberEditColumnFilter CuryAccruedCost { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public SelectorColumnFilter SalesPersonID { get; }
				public SelectorColumnFilter DeferredCode { get; }
				public DateSelectorColumnFilter DRTermStartDate { get; }
				public DateSelectorColumnFilter DRTermEndDate { get; }
				public SelectorColumnFilter DefScheduleID { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public DropDownColumnFilter AvalaraCustomerUsageType { get; }
				public CheckBoxColumnFilter Commissionable { get; }
				public PXNumberEditColumnFilter SOOrderLineNbr { get; }
				public CheckBoxColumnFilter IsRUTROTDeductible { get; }
				public DropDownColumnFilter RUTROTItemType { get; }
				public InputColumnFilter RUTROTWorkTypeID { get; }
				public PXNumberEditColumnFilter CuryRUTROTAvailableAmt { get; }
				public DropDownColumnFilter OrigInvoiceType { get; }
				public SelectorColumnFilter OrigInvoiceNbr { get; }
				public PXNumberEditColumnFilter OrigInvoiceLineNbr { get; }
				public DropDownColumnFilter InvtDocType { get; }
				public SelectorColumnFilter InvtRefNbr { get; }
				public SelectorColumnFilter BlanketNbr { get; }
                
                public c_grid_header(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    TranType = new PXTextEditColumnFilter(grid.Row.TranType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    LineType = new DropDownColumnFilter(grid.Row.LineType);
                    SOShipmentNbr = new SelectorColumnFilter(grid.Row.SOShipmentNbr);
                    SOOrderType = new PXTextEditColumnFilter(grid.Row.SOOrderType);
                    SOOrderNbr = new SelectorColumnFilter(grid.Row.SOOrderNbr);
                    AssociatedOrderLineNbr = new PXTextEditColumnFilter(grid.Row.AssociatedOrderLineNbr);
                    GiftMessage = new PXTextEditColumnFilter(grid.Row.GiftMessage);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    RelatedItems = new PXTextEditColumnFilter(grid.Row.RelatedItems);
                    SubstitutionRequired = new CheckBoxColumnFilter(grid.Row.SubstitutionRequired);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    FSARTran__ReplaceSMEquipmentID = new SelectorColumnFilter(grid.Row.FSARTran__ReplaceSMEquipmentID);
                    FSARTran__EquipmentAction = new DropDownColumnFilter(grid.Row.FSARTran__EquipmentAction);
                    FSARTran__Comment = new PXTextEditColumnFilter(grid.Row.FSARTran__Comment);
                    FSARTran__SMEquipmentID = new SelectorColumnFilter(grid.Row.FSARTran__SMEquipmentID);
                    FSARTran__NewEquipmentLineNbr = new SelectorColumnFilter(grid.Row.FSARTran__NewEquipmentLineNbr);
                    FSARTran__ComponentID = new SelectorColumnFilter(grid.Row.FSARTran__ComponentID);
                    FSARTran__EquipmentComponentLineNbr = new SelectorColumnFilter(grid.Row.FSARTran__EquipmentComponentLineNbr);
                    FSARTran__RelatedDocument = new PXTextEditColumnFilter(grid.Row.FSARTran__RelatedDocument);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    BaseQty = new PXNumberEditColumnFilter(grid.Row.BaseQty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    LotSerialNbr = new SelectorColumnFilter(grid.Row.LotSerialNbr);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    ManualPrice = new CheckBoxColumnFilter(grid.Row.ManualPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    DiscPct = new PXNumberEditColumnFilter(grid.Row.DiscPct);
                    CuryDiscAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscAmt);
                    ManualDisc = new CheckBoxColumnFilter(grid.Row.ManualDisc);
                    DiscountID = new SelectorColumnFilter(grid.Row.DiscountID);
                    DiscountSequenceID = new PXTextEditColumnFilter(grid.Row.DiscountSequenceID);
                    CuryTranAmt = new PXNumberEditColumnFilter(grid.Row.CuryTranAmt);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    AccountID_Account_description = new PXTextEditColumnFilter(grid.Row.AccountID_Account_description);
                    SubID = new SelectorColumnFilter(grid.Row.SubID);
                    ExpenseAccrualAccountID = new SelectorColumnFilter(grid.Row.ExpenseAccrualAccountID);
                    ExpenseAccrualAccountID_Account_description = new PXTextEditColumnFilter(grid.Row.ExpenseAccrualAccountID_Account_description);
                    ExpenseAccrualSubID = new SelectorColumnFilter(grid.Row.ExpenseAccrualSubID);
                    ExpenseAccountID = new SelectorColumnFilter(grid.Row.ExpenseAccountID);
                    ExpenseAccountID_Account_description = new PXTextEditColumnFilter(grid.Row.ExpenseAccountID_Account_description);
                    ExpenseSubID = new SelectorColumnFilter(grid.Row.ExpenseSubID);
                    CostBasis = new DropDownColumnFilter(grid.Row.CostBasis);
                    CuryAccruedCost = new PXNumberEditColumnFilter(grid.Row.CuryAccruedCost);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    SalesPersonID = new SelectorColumnFilter(grid.Row.SalesPersonID);
                    DeferredCode = new SelectorColumnFilter(grid.Row.DeferredCode);
                    DRTermStartDate = new DateSelectorColumnFilter(grid.Row.DRTermStartDate);
                    DRTermEndDate = new DateSelectorColumnFilter(grid.Row.DRTermEndDate);
                    DefScheduleID = new SelectorColumnFilter(grid.Row.DefScheduleID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    AvalaraCustomerUsageType = new DropDownColumnFilter(grid.Row.AvalaraCustomerUsageType);
                    Commissionable = new CheckBoxColumnFilter(grid.Row.Commissionable);
                    SOOrderLineNbr = new PXNumberEditColumnFilter(grid.Row.SOOrderLineNbr);
                    IsRUTROTDeductible = new CheckBoxColumnFilter(grid.Row.IsRUTROTDeductible);
                    RUTROTItemType = new DropDownColumnFilter(grid.Row.RUTROTItemType);
                    RUTROTWorkTypeID = new InputColumnFilter(grid.Row.RUTROTWorkTypeID);
                    CuryRUTROTAvailableAmt = new PXNumberEditColumnFilter(grid.Row.CuryRUTROTAvailableAmt);
                    OrigInvoiceType = new DropDownColumnFilter(grid.Row.OrigInvoiceType);
                    OrigInvoiceNbr = new SelectorColumnFilter(grid.Row.OrigInvoiceNbr);
                    OrigInvoiceLineNbr = new PXNumberEditColumnFilter(grid.Row.OrigInvoiceLineNbr);
                    InvtDocType = new DropDownColumnFilter(grid.Row.InvtDocType);
                    InvtRefNbr = new SelectorColumnFilter(grid.Row.InvtRefNbr);
                    BlanketNbr = new SelectorColumnFilter(grid.Row.BlanketNbr);
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
			public Selector FSARTran__ReplaceSMEquipmentID { get; }
			public Label FSARTran__ReplaceSMEquipmentIDLabel { get; }
			public DropDown FSARTran__EquipmentAction { get; }
			public Label FSARTran__EquipmentActionLabel { get; }
			public Selector FSARTran__SMEquipmentID { get; }
			public Label FSARTran__SMEquipmentIDLabel { get; }
			public Selector FSARTran__NewEquipmentLineNbr { get; }
			public Label FSARTran__NewEquipmentLineNbrLabel { get; }
			public Selector FSARTran__ComponentID { get; }
			public Label FSARTran__ComponentIDLabel { get; }
			public Selector FSARTran__EquipmentComponentLineNbr { get; }
			public Label FSARTran__EquipmentComponentLineNbrLabel { get; }
			public Selector SOShipmentNbr { get; }
			public Label SOShipmentNbrLabel { get; }
			public PXTextEdit SOOrderType { get; }
			public Label SOOrderTypeLabel { get; }
			public Selector SOOrderNbr { get; }
			public Label SOOrderNbrLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public Label CuryUnitPriceLabel { get; }
			public CheckBox ManualPrice { get; }
			public Label ManualPriceLabel { get; }
			public Selector DiscountID { get; }
			public Label DiscountIDLabel { get; }
			public PXNumberEdit DiscPct { get; }
			public Label DiscPctLabel { get; }
			public PXNumberEdit CuryDiscAmt { get; }
			public Label CuryDiscAmtLabel { get; }
			public CheckBox ManualDisc { get; }
			public Label ManualDiscLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public Label CuryExtPriceLabel { get; }
			public PXNumberEdit CuryTranAmt { get; }
			public Label CuryTranAmtLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector SubID { get; }
			public Label SubIDLabel { get; }
			public Selector SalesPersonID { get; }
			public Label SalesPersonIDLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public DropDown AvalaraCustomerUsageType { get; }
			public Label AvalaraCustomerUsageTypeLabel { get; }
			public CheckBox Commissionable { get; }
			public Label CommissionableLabel { get; }
			public Selector DeferredCode { get; }
			public Label DeferredCodeLabel { get; }
			public DateSelector DRTermStartDate { get; }
			public Label DRTermStartDateLabel { get; }
			public DateSelector DRTermEndDate { get; }
			public Label DRTermEndDateLabel { get; }
			public Selector DefScheduleID { get; }
			public Label DefScheduleIDLabel { get; }
			public CheckBox IsRUTROTDeductible { get; }
			public Label IsRUTROTDeductibleLabel { get; }
			public DropDown RUTROTItemType { get; }
			public Label RUTROTItemTypeLabel { get; }
			public Selector RUTROTWorkTypeID { get; }
			public Label RUTROTWorkTypeIDLabel { get; }
			public PXNumberEdit CuryRUTROTAvailableAmt { get; }
			public Label CuryRUTROTAvailableAmtLabel { get; }
			public Selector InvtRefNbr { get; }
			public Label InvtRefNbrLabel { get; }
			public Selector BlanketNbr { get; }
			public Label BlanketNbrLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector ExpenseAccrualAccountID { get; }
			public Label ExpenseAccrualAccountIDLabel { get; }
			public Selector ExpenseAccrualSubID { get; }
			public Label ExpenseAccrualSubIDLabel { get; }
			public Selector ExpenseAccountID { get; }
			public Label ExpenseAccountIDLabel { get; }
			public Selector ExpenseSubID { get; }
			public Label ExpenseSubIDLabel { get; }
			public DropDown CostBasis { get; }
			public Label CostBasisLabel { get; }
			public PXNumberEdit CuryAccruedCost { get; }
			public Label CuryAccruedCostLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
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
                SubItemID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                FSARTran__ReplaceSMEquipmentID = new Selector("ctl00_phG_tab_t0_grid_lv0_edReplaceSMEquipmentID", "Suspended Target Equipment ID", locator, null);
                FSARTran__ReplaceSMEquipmentIDLabel = new Label(FSARTran__ReplaceSMEquipmentID);
                FSARTran__ReplaceSMEquipmentID.DataField = "FSARTran__ReplaceSMEquipmentID";
                FSARTran__EquipmentAction = new DropDown("ctl00_phG_tab_t0_grid_lv0_edEquipmentAction", "Equipment Action", locator, null);
                FSARTran__EquipmentActionLabel = new Label(FSARTran__EquipmentAction);
                FSARTran__EquipmentAction.DataField = "FSARTran__EquipmentAction";
                FSARTran__EquipmentAction.Items.Add("NO", "N/A");
                FSARTran__EquipmentAction.Items.Add("ST", "Selling Model Equipment");
                FSARTran__EquipmentAction.Items.Add("RT", "Replacing Target Equipment");
                FSARTran__EquipmentAction.Items.Add("CC", "Selling Optional Component");
                FSARTran__EquipmentAction.Items.Add("UC", "Upgrading Component");
                FSARTran__EquipmentAction.Items.Add("RC", "Replacing Component");
                FSARTran__SMEquipmentID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSMEquipmentID", "Target Equipment ID", locator, null);
                FSARTran__SMEquipmentIDLabel = new Label(FSARTran__SMEquipmentID);
                FSARTran__SMEquipmentID.DataField = "FSARTran__SMEquipmentID";
                FSARTran__NewEquipmentLineNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edNewEquipmentLineNbr", "Model Equipment Line Nbr.", locator, null);
                FSARTran__NewEquipmentLineNbrLabel = new Label(FSARTran__NewEquipmentLineNbr);
                FSARTran__NewEquipmentLineNbr.DataField = "FSARTran__NewEquipmentLineNbr";
                FSARTran__ComponentID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSMComponentID", "Component ID", locator, null);
                FSARTran__ComponentIDLabel = new Label(FSARTran__ComponentID);
                FSARTran__ComponentID.DataField = "FSARTran__ComponentID";
                FSARTran__EquipmentComponentLineNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edEquipmentComponentLineNbr", "Component Line Nbr.", locator, null);
                FSARTran__EquipmentComponentLineNbrLabel = new Label(FSARTran__EquipmentComponentLineNbr);
                FSARTran__EquipmentComponentLineNbr.DataField = "FSARTran__EquipmentComponentLineNbr";
                SOShipmentNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edSOShipmentNbr", "Shipment Nbr.", locator, null);
                SOShipmentNbrLabel = new Label(SOShipmentNbr);
                SOShipmentNbr.DataField = "SOShipmentNbr";
                SOOrderType = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edSOOrderType1", "Order Type", locator, null);
                SOOrderTypeLabel = new Label(SOOrderType);
                SOOrderType.DataField = "SOOrderType";
                SOOrderNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edSOOrderNbr1", "Order Nbr.", locator, null);
                SOOrderNbrLabel = new Label(SOOrderNbr);
                SOOrderNbr.DataField = "SOOrderNbr";
                SiteID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LocationID = new Selector("ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                UOM = new Selector("ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                LotSerialNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                ExpireDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                CuryUnitPrice = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryUnitPrice", "Unit Price", locator, null);
                CuryUnitPriceLabel = new Label(CuryUnitPrice);
                CuryUnitPrice.DataField = "CuryUnitPrice";
                ManualPrice = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkManualPrice", "Manual Price", locator, null);
                ManualPriceLabel = new Label(ManualPrice);
                ManualPrice.DataField = "ManualPrice";
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
                BranchID = new Selector("ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                TaskID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                CuryExtPrice = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryExtPrice", "Ext. Price", locator, null);
                CuryExtPriceLabel = new Label(CuryExtPrice);
                CuryExtPrice.DataField = "CuryExtPrice";
                CuryTranAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryTranAmt1", "Amount", locator, null);
                CuryTranAmtLabel = new Label(CuryTranAmt);
                CuryTranAmt.DataField = "CuryTranAmt";
                AccountID = new Selector("ctl00_phG_tab_t0_grid_lv0_edAccountID1", "Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                SubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubID1", "Subaccount", locator, null);
                SubIDLabel = new Label(SubID);
                SubID.DataField = "SubID";
                SalesPersonID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSalesPersonID1", "Salesperson ID", locator, null);
                SalesPersonIDLabel = new Label(SalesPersonID);
                SalesPersonID.DataField = "SalesPersonID";
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaxCategoryID1", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                AvalaraCustomerUsageType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edAvalaraCustomerUsageTypeID1", "Entity Usage Type", locator, null);
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
                Commissionable = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkCommissionable", "Commissionable", locator, null);
                CommissionableLabel = new Label(Commissionable);
                Commissionable.DataField = "Commissionable";
                DeferredCode = new Selector("ctl00_phG_tab_t0_grid_lv0_edDeferredCode", "Deferral Code", locator, null);
                DeferredCodeLabel = new Label(DeferredCode);
                DeferredCode.DataField = "DeferredCode";
                DRTermStartDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edDRTermStartDate", "Term Start Date", locator, null);
                DRTermStartDateLabel = new Label(DRTermStartDate);
                DRTermStartDate.DataField = "DRTermStartDate";
                DRTermEndDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edDRTermEndDate", "Term End Date", locator, null);
                DRTermEndDateLabel = new Label(DRTermEndDate);
                DRTermEndDate.DataField = "DRTermEndDate";
                DefScheduleID = new Selector("ctl00_phG_tab_t0_grid_lv0_edDefScheduleID", "Original Deferral Schedule", locator, null);
                DefScheduleIDLabel = new Label(DefScheduleID);
                DefScheduleID.DataField = "DefScheduleID";
                IsRUTROTDeductible = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkRRDeductibleTran", "ROT or RUT deductible", locator, null);
                IsRUTROTDeductibleLabel = new Label(IsRUTROTDeductible);
                IsRUTROTDeductible.DataField = "IsRUTROTDeductible";
                RUTROTItemType = new DropDown("ctl00_phG_tab_t0_grid_lv0_cmbRRItemType", "Item Type", locator, null);
                RUTROTItemTypeLabel = new Label(RUTROTItemType);
                RUTROTItemType.DataField = "RUTROTItemType";
                RUTROTWorkTypeID = new Selector("ctl00_phG_tab_t0_grid_lv0_cmbRRWorkType", "Type of Work", locator, null);
                RUTROTWorkTypeIDLabel = new Label(RUTROTWorkTypeID);
                RUTROTWorkTypeID.DataField = "RUTROTWorkTypeID";
                CuryRUTROTAvailableAmt = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edRRAvailable", "Deductible Amount", locator, null);
                CuryRUTROTAvailableAmtLabel = new Label(CuryRUTROTAvailableAmt);
                CuryRUTROTAvailableAmt.DataField = "CuryRUTROTAvailableAmt";
                InvtRefNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edInvtRefNbr", "Inventory Ref. Nbr.", locator, null);
                InvtRefNbrLabel = new Label(InvtRefNbr);
                InvtRefNbr.DataField = "InvtRefNbr";
                BlanketNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edBlanketNbr", "Blanket SO Ref. Nbr.", locator, null);
                BlanketNbrLabel = new Label(BlanketNbr);
                BlanketNbr.DataField = "BlanketNbr";
                TranDesc = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edTranDesc1", "Transaction Descr.", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                ExpenseAccrualAccountID = new Selector("ctl00_phG_tab_t0_grid_lv0_edExpenseAccrualAccountID", "Expense Accrual Account", locator, null);
                ExpenseAccrualAccountIDLabel = new Label(ExpenseAccrualAccountID);
                ExpenseAccrualAccountID.DataField = "ExpenseAccrualAccountID";
                ExpenseAccrualSubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edExpenseAccrualSubID", "Expense Accrual Subaccount", locator, null);
                ExpenseAccrualSubIDLabel = new Label(ExpenseAccrualSubID);
                ExpenseAccrualSubID.DataField = "ExpenseAccrualSubID";
                ExpenseAccountID = new Selector("ctl00_phG_tab_t0_grid_lv0_edExpenseAccountID", "Expense Account", locator, null);
                ExpenseAccountIDLabel = new Label(ExpenseAccountID);
                ExpenseAccountID.DataField = "ExpenseAccountID";
                ExpenseSubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edExpenseSubID", "Expense Subaccount", locator, null);
                ExpenseSubIDLabel = new Label(ExpenseSubID);
                ExpenseSubID.DataField = "ExpenseSubID";
                CostBasis = new DropDown("ctl00_phG_tab_t0_grid_lv0_cmbCostBasis", "Cost Based On", locator, null);
                CostBasisLabel = new Label(CostBasis);
                CostBasis.DataField = "CostBasis";
                CostBasis.Items.Add("S", "Standard Cost");
                CostBasis.Items.Add("M", "Markup %");
                CostBasis.Items.Add("P", "Percentage of Sales Price");
                CuryAccruedCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryAccruedCost", "Cost Accrual", locator, null);
                CuryAccruedCostLabel = new Label(CuryAccruedCost);
                CuryAccruedCost.DataField = "CuryAccruedCost";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t0_grid_lv0_ec", "Ec", locator, null);
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
            
            public virtual void FSARTran__ReplaceSMEquipmentIDEdit()
            {
                Buttons.FSARTran__ReplaceSMEquipmentIDEdit.Click();
            }
            
            public virtual void FSARTran__SMEquipmentIDEdit()
            {
                Buttons.FSARTran__SMEquipmentIDEdit.Click();
            }
            
            public virtual void DiscountIDEdit()
            {
                Buttons.DiscountIDEdit.Click();
            }
            
            public virtual void InvtRefNbrEdit()
            {
                Buttons.InvtRefNbrEdit.Click();
            }
            
            public virtual void BlanketNbrEdit()
            {
                Buttons.BlanketNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
			public Button FSARTran__ReplaceSMEquipmentIDEdit { get; }
			public Button FSARTran__SMEquipmentIDEdit { get; }
			public Button DiscountIDEdit { get; }
			public Button InvtRefNbrEdit { get; }
			public Button BlanketNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edInventoryID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "InventoryIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    FSARTran__ReplaceSMEquipmentIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edReplaceSMEquipmentID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "FSARTran__ReplaceSMEquipmentIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    FSARTran__ReplaceSMEquipmentIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    FSARTran__SMEquipmentIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edSMEquipmentID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "FSARTran__SMEquipmentIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    FSARTran__SMEquipmentIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edDiscountCode\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DiscountIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    DiscountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvtRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edInvtRefNbr\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "InvtRefNbrEdit", "ctl00_phG_tab_t0_grid_lv0");
                    InvtRefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BlanketNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edBlanketNbr\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "BlanketNbrEdit", "ctl00_phG_tab_t0_grid_lv0");
                    BlanketNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_grid1");
                DataMemberName = "Taxes";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_grid1_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
			public PXNumberEdit CuryDiscountedTaxableAmt { get; }
			public PXNumberEdit CuryDiscountedPrice { get; }
			public PXTextEdit Module { get; }
			public PXTextEdit TranType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_taxes_grid1 grid) : 
                        base(grid)
                {
                    TaxID = new Selector("_ctl00_phG_tab_t1_grid1_lv0_edTaxID", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    TaxRate = new PXNumberEdit("_ctl00_phG_tab_t1_grid1_lv0_edTaxRate", "Tax Rate", grid.Locator, "TaxRate");
                    TaxRate.DataField = "TaxRate";
                    CuryTaxableAmt = new PXNumberEdit("_ctl00_phG_tab_t1_grid1_lv0_edCuryTaxableAmt", "Taxable Amount", grid.Locator, "CuryTaxableAmt");
                    CuryTaxableAmt.DataField = "CuryTaxableAmt";
                    CuryExemptedAmt = new PXNumberEdit("ctl00_phG_tab_t1_grid1_en", "Exempted Amount", grid.Locator, "CuryExemptedAmt");
                    CuryExemptedAmt.DataField = "CuryExemptedAmt";
                    TaxUOM = new Selector("_ctl00_phG_tab_t1_grid1_lv0_es", "Tax UOM", grid.Locator, "TaxUOM");
                    TaxUOM.DataField = "TaxUOM";
                    TaxableQty = new PXNumberEdit("ctl00_phG_tab_t1_grid1_en", "Taxable Qty.", grid.Locator, "TaxableQty");
                    TaxableQty.DataField = "TaxableQty";
                    CuryTaxAmt = new PXNumberEdit("_ctl00_phG_tab_t1_grid1_lv0_edCuryTaxAmt", "Tax Amount", grid.Locator, "CuryTaxAmt");
                    CuryTaxAmt.DataField = "CuryTaxAmt";
                    Tax__TaxType = new DropDown("_ctl00_phG_tab_t1_grid1_lv0_ec", "Tax Type", grid.Locator, "Tax__TaxType");
                    Tax__TaxType.DataField = "Tax__TaxType";
                    Tax__TaxType.Items.Add("S", "Sales");
                    Tax__TaxType.Items.Add("P", "Use");
                    Tax__TaxType.Items.Add("V", "VAT");
                    Tax__TaxType.Items.Add("W", "Withholding");
                    Tax__TaxType.Items.Add("Q", "Per-Unit/Specific");
                    Tax__PendingTax = new CheckBox("ctl00_phG_tab_t1_grid1", "Pending VAT", grid.Locator, "Tax__PendingTax");
                    Tax__PendingTax.DataField = "Tax__PendingTax";
                    Tax__ReverseTax = new CheckBox("ctl00_phG_tab_t1_grid1", "Reverse VAT", grid.Locator, "Tax__ReverseTax");
                    Tax__ReverseTax.DataField = "Tax__ReverseTax";
                    Tax__ExemptTax = new CheckBox("ctl00_phG_tab_t1_grid1", "Include in VAT Exempt Total", grid.Locator, "Tax__ExemptTax");
                    Tax__ExemptTax.DataField = "Tax__ExemptTax";
                    Tax__StatisticalTax = new CheckBox("ctl00_phG_tab_t1_grid1", "Statistical VAT", grid.Locator, "Tax__StatisticalTax");
                    Tax__StatisticalTax.DataField = "Tax__StatisticalTax";
                    CuryDiscountedTaxableAmt = new PXNumberEdit("_ctl00_phG_tab_t1_grid1_lv0_edCuryDiscountedTaxableAmt", "Discounted Taxable Amount", grid.Locator, "CuryDiscountedTaxableAmt");
                    CuryDiscountedTaxableAmt.DataField = "CuryDiscountedTaxableAmt";
                    CuryDiscountedPrice = new PXNumberEdit("_ctl00_phG_tab_t1_grid1_lv0_edCuryDiscountedPrice", "Tax on Discounted Price", grid.Locator, "CuryDiscountedPrice");
                    CuryDiscountedPrice.DataField = "CuryDiscountedPrice";
                    Module = new PXTextEdit("ctl00_phG_tab_t1_grid1_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    TranType = new PXTextEdit("ctl00_phG_tab_t1_grid1_ei", "Tran. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t1_grid1_ei", "Ref. Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t1_grid1_en", "RecordID", grid.Locator, "RecordID");
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
                    CuryExemptedAmt = new PXNumberEditColumnFilter(grid.Row.CuryExemptedAmt);
                    TaxUOM = new SelectorColumnFilter(grid.Row.TaxUOM);
                    TaxableQty = new PXNumberEditColumnFilter(grid.Row.TaxableQty);
                    CuryTaxAmt = new PXNumberEditColumnFilter(grid.Row.CuryTaxAmt);
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
            
			public Selector TaxID { get; }
			public Label TaxIDLabel { get; }
			public PXNumberEdit TaxRate { get; }
			public Label TaxRateLabel { get; }
			public PXNumberEdit CuryTaxableAmt { get; }
			public Label CuryTaxableAmtLabel { get; }
			public PXNumberEdit CuryTaxAmt { get; }
			public Label CuryTaxAmtLabel { get; }
			public PXNumberEdit CuryDiscountedTaxableAmt { get; }
			public Label CuryDiscountedTaxableAmtLabel { get; }
			public PXNumberEdit CuryDiscountedPrice { get; }
			public Label CuryDiscountedPriceLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_taxes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                TaxID = new Selector("ctl00_phG_tab_t1_grid1_lv0_edTaxID", "Tax ID", locator, null);
                TaxIDLabel = new Label(TaxID);
                TaxID.DataField = "TaxID";
                TaxRate = new PXNumberEdit("ctl00_phG_tab_t1_grid1_lv0_edTaxRate", "Tax Rate", locator, null);
                TaxRateLabel = new Label(TaxRate);
                TaxRate.DataField = "TaxRate";
                CuryTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t1_grid1_lv0_edCuryTaxableAmt", "Cury Taxable Amt", locator, null);
                CuryTaxableAmtLabel = new Label(CuryTaxableAmt);
                CuryTaxableAmt.DataField = "CuryTaxableAmt";
                CuryTaxAmt = new PXNumberEdit("ctl00_phG_tab_t1_grid1_lv0_edCuryTaxAmt", "Cury Tax Amt", locator, null);
                CuryTaxAmtLabel = new Label(CuryTaxAmt);
                CuryTaxAmt.DataField = "CuryTaxAmt";
                CuryDiscountedTaxableAmt = new PXNumberEdit("ctl00_phG_tab_t1_grid1_lv0_edCuryDiscountedTaxableAmt", "Discounted Taxable Amount", locator, null);
                CuryDiscountedTaxableAmtLabel = new Label(CuryDiscountedTaxableAmt);
                CuryDiscountedTaxableAmt.DataField = "CuryDiscountedTaxableAmt";
                CuryDiscountedPrice = new PXNumberEdit("ctl00_phG_tab_t1_grid1_lv0_edCuryDiscountedPrice", "Tax on Discounted Price", locator, null);
                CuryDiscountedPriceLabel = new Label(CuryDiscountedPrice);
                CuryDiscountedPrice.DataField = "CuryDiscountedPrice";
                Es = new Selector("ctl00_phG_tab_t1_grid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t1_grid1_lv0_ec", "Ec", locator, null);
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_detgrid");
                DataMemberName = "Adjustments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_detgrid_fe_gf", "FilterForm");
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
            
            public virtual void LoadDocuments()
            {
                ToolBar.LoadDocuments.Click();
            }
            
            public virtual void AutoApply()
            {
                ToolBar.AutoApply.Click();
            }
            
            public virtual void CreateDocumentPayment()
            {
                ToolBar.CreateDocumentPayment.Click();
            }
            
            public virtual void CaptureDocumentPayment()
            {
                ToolBar.CaptureDocumentPayment.Click();
            }
            
            public virtual void VoidDocumentPayment()
            {
                ToolBar.VoidDocumentPayment.Click();
            }
            
            public virtual void ImportDocumentPayment()
            {
                ToolBar.ImportDocumentPayment.Click();
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
			public ToolBarButtonGrid LoadDocuments { get; }
			public ToolBarButtonGrid AutoApply { get; }
			public ToolBarButtonGrid CreateDocumentPayment { get; }
			public ToolBarButtonGrid CaptureDocumentPayment { get; }
			public ToolBarButtonGrid VoidDocumentPayment { get; }
			public ToolBarButtonGrid ImportDocumentPayment { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    LoadDocuments = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'LoadDocuments\']", "Load Documents", locator, null);
                    AutoApply = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'AutoApply\']", "Auto Apply", locator, null);
                    CreateDocumentPayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'CreateDocumentPayment\']", "Create Payment", locator, null);
                    CaptureDocumentPayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'CaptureDocumentPayment\']", "Capture", locator, null);
                    VoidDocumentPayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'VoidDocumentPayment\']", "Void Card Payment", locator, null);
                    ImportDocumentPayment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'ImportDocumentPayment\']", "Import Card Payment", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public DropDown AdjgDocType { get; }
			public Selector AdjgRefNbr { get; }
			public PXNumberEdit CuryAdjdAmt { get; }
			public PXNumberEdit CuryAdjgDiscAmt { get; }
			public PXNumberEdit CuryAdjdWOAmt { get; }
			public DateSelector ARPayment__DocDate { get; }
			public PXNumberEdit CuryDocBal { get; }
			public PXTextEdit ARPayment__DocDesc { get; }
			public Selector ARPayment__CuryID { get; }
			public Selector ARPayment__FinPeriodID { get; }
			public PXTextEdit ARPayment__ExtRefNbr { get; }
			public Selector CustomerID { get; }
			public PXTextEdit AdjdDocType { get; }
			public PXTextEdit AdjdRefNbr { get; }
			public PXNumberEdit AdjNbr { get; }
			public DropDown ARPayment__Status { get; }
			public DropDown ExternalTransaction__ProcStatus { get; }
			public CheckBox CanVoid { get; }
			public CheckBox CanCapture { get; }
			public Selector AdjdLineNbr { get; }
                
                public c_grid_row(c_adjustments_detgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_tab_t7_detgrid", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    AdjgDocType = new DropDown("_ctl00_phG_tab_t7_detgrid_lv0_edAdjgDocType", "Doc. Type", grid.Locator, "AdjgDocType");
                    AdjgDocType.DataField = "AdjgDocType";
                    AdjgDocType.Items.Add("CRM", "Credit Memo");
                    AdjgDocType.Items.Add("PMT", "Payment");
                    AdjgDocType.Items.Add("PPM", "Prepayment");
                    AdjgRefNbr = new Selector("_ctl00_phG_tab_t7_detgrid_lv0_edAdjgRefNbr", "Reference Nbr.", grid.Locator, "AdjgRefNbr");
                    AdjgRefNbr.DataField = "AdjgRefNbr";
                    CuryAdjdAmt = new PXNumberEdit("_ctl00_phG_tab_t7_detgrid_lv0_edCuryAdjdAmt", "Amount Paid", grid.Locator, "CuryAdjdAmt");
                    CuryAdjdAmt.DataField = "CuryAdjdAmt";
                    CuryAdjgDiscAmt = new PXNumberEdit("ctl00_phG_tab_t7_detgrid_en", "Cash Discount Taken", grid.Locator, "CuryAdjgDiscAmt");
                    CuryAdjgDiscAmt.DataField = "CuryAdjgDiscAmt";
                    CuryAdjdWOAmt = new PXNumberEdit("ctl00_phG_tab_t7_detgrid_en", "Write-Off Amount", grid.Locator, "CuryAdjdWOAmt");
                    CuryAdjdWOAmt.DataField = "CuryAdjdWOAmt";
                    ARPayment__DocDate = new DateSelector("_ctl00_phG_tab_t7_detgrid_lv0_edARPayment__DocDate", "Payment Date", grid.Locator, "ARPayment__DocDate");
                    ARPayment__DocDate.DataField = "ARPayment__DocDate";
                    CuryDocBal = new PXNumberEdit("_ctl00_phG_tab_t7_detgrid_lv0_edCuryDocBal", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    ARPayment__DocDesc = new PXTextEdit("_ctl00_phG_tab_t7_detgrid_lv0_edARPayment__DocDesc", "Description", grid.Locator, "ARPayment__DocDesc");
                    ARPayment__DocDesc.DataField = "ARPayment__DocDesc";
                    ARPayment__CuryID = new Selector("_ctl00_phG_tab_t7_detgrid_lv0_edARPayment__CuryID", "Currency", grid.Locator, "ARPayment__CuryID");
                    ARPayment__CuryID.DataField = "ARPayment__CuryID";
                    ARPayment__FinPeriodID = new Selector("_ctl00_phG_tab_t7_detgrid_lv0_edARPayment__FinPeriodID", "Payment Period", grid.Locator, "ARPayment__FinPeriodID");
                    ARPayment__FinPeriodID.DataField = "ARPayment__FinPeriodID";
                    ARPayment__ExtRefNbr = new PXTextEdit("_ctl00_phG_tab_t7_detgrid_lv0_edARPayment__ExtRefNbr", "Payment Ref.", grid.Locator, "ARPayment__ExtRefNbr");
                    ARPayment__ExtRefNbr.DataField = "ARPayment__ExtRefNbr";
                    CustomerID = new Selector("_ctl00_phG_tab_t7_detgrid_lv0_es", "Customer", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    AdjdDocType = new PXTextEdit("ctl00_phG_tab_t7_detgrid_ei", "Document Type", grid.Locator, "AdjdDocType");
                    AdjdDocType.DataField = "AdjdDocType";
                    AdjdRefNbr = new PXTextEdit("ctl00_phG_tab_t7_detgrid_ei", "Reference Nbr.", grid.Locator, "AdjdRefNbr");
                    AdjdRefNbr.DataField = "AdjdRefNbr";
                    AdjNbr = new PXNumberEdit("ctl00_phG_tab_t7_detgrid_en", "Adjustment Nbr.", grid.Locator, "AdjNbr");
                    AdjNbr.DataField = "AdjNbr";
                    ARPayment__Status = new DropDown("_ctl00_phG_tab_t7_detgrid_lv0_edARPayment__Status", "Status", grid.Locator, "ARPayment__Status");
                    ARPayment__Status.DataField = "ARPayment__Status";
                    ARPayment__Status.Items.Add("R", "Credit Hold");
                    ARPayment__Status.Items.Add("W", "Pending Processing");
                    ARPayment__Status.Items.Add("H", "On Hold");
                    ARPayment__Status.Items.Add("B", "Balanced");
                    ARPayment__Status.Items.Add("V", "Voided");
                    ARPayment__Status.Items.Add("S", "Scheduled");
                    ARPayment__Status.Items.Add("N", "Open");
                    ARPayment__Status.Items.Add("C", "Closed");
                    ARPayment__Status.Items.Add("P", "Pending Print");
                    ARPayment__Status.Items.Add("E", "Pending Email");
                    ARPayment__Status.Items.Add("Z", "Reserved");
                    ARPayment__Status.Items.Add("D", "Pending Approval");
                    ARPayment__Status.Items.Add("J", "Rejected");
                    ARPayment__Status.Items.Add("L", "Canceled");
                    ExternalTransaction__ProcStatus = new DropDown("_ctl00_phG_tab_t7_detgrid_lv0_ec", "Proc. Status", grid.Locator, "ExternalTransaction__ProcStatus");
                    ExternalTransaction__ProcStatus.DataField = "ExternalTransaction__ProcStatus";
                    ExternalTransaction__ProcStatus.Items.Add("AUF", "Pre-Authorization Failed");
                    ExternalTransaction__ProcStatus.Items.Add("CAF", "Capture Failed");
                    ExternalTransaction__ProcStatus.Items.Add("VDF", "Voiding failed");
                    ExternalTransaction__ProcStatus.Items.Add("CDF", "Refund Failed");
                    ExternalTransaction__ProcStatus.Items.Add("AUS", "Pre-Authorized");
                    ExternalTransaction__ProcStatus.Items.Add("CAS", "Captured");
                    ExternalTransaction__ProcStatus.Items.Add("VDS", "Voided");
                    ExternalTransaction__ProcStatus.Items.Add("CDS", "Refunded");
                    ExternalTransaction__ProcStatus.Items.Add("AUH", "Held for Review (Authorization)");
                    ExternalTransaction__ProcStatus.Items.Add("CAH", "Held for Review (Capture)");
                    ExternalTransaction__ProcStatus.Items.Add("VDH", "Held for Review (Void)");
                    ExternalTransaction__ProcStatus.Items.Add("CDH", "Held for Review (Refund)");
                    ExternalTransaction__ProcStatus.Items.Add("AUD", "Pre-Authorization Declined");
                    ExternalTransaction__ProcStatus.Items.Add("CAD", "Capture Declined");
                    ExternalTransaction__ProcStatus.Items.Add("VDD", "Voiding Declined");
                    ExternalTransaction__ProcStatus.Items.Add("CDD", "Refund Declined");
                    ExternalTransaction__ProcStatus.Items.Add("AUE", "Pre-Authorization Expired");
                    ExternalTransaction__ProcStatus.Items.Add("CAE", "Held for Review (Capture) Expired");
                    ExternalTransaction__ProcStatus.Items.Add("UKN", "Unknown");
                    CanVoid = new CheckBox("ctl00_phG_tab_t7_detgrid_ef", "CanVoid", grid.Locator, "CanVoid");
                    CanVoid.DataField = "CanVoid";
                    CanCapture = new CheckBox("ctl00_phG_tab_t7_detgrid_ef", "CanCapture", grid.Locator, "CanCapture");
                    CanCapture.DataField = "CanCapture";
                    AdjdLineNbr = new Selector("_ctl00_phG_tab_t7_detgrid_lv0_es", "Line Nbr.", grid.Locator, "AdjdLineNbr");
                    AdjdLineNbr.DataField = "AdjdLineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter AdjgDocType { get; }
				public SelectorColumnFilter AdjgRefNbr { get; }
				public PXNumberEditColumnFilter CuryAdjdAmt { get; }
				public PXNumberEditColumnFilter CuryAdjgDiscAmt { get; }
				public PXNumberEditColumnFilter CuryAdjdWOAmt { get; }
				public DateSelectorColumnFilter ARPayment__DocDate { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public PXTextEditColumnFilter ARPayment__DocDesc { get; }
				public SelectorColumnFilter ARPayment__CuryID { get; }
				public SelectorColumnFilter ARPayment__FinPeriodID { get; }
				public PXTextEditColumnFilter ARPayment__ExtRefNbr { get; }
				public SelectorColumnFilter CustomerID { get; }
				public PXTextEditColumnFilter AdjdDocType { get; }
				public PXTextEditColumnFilter AdjdRefNbr { get; }
				public PXNumberEditColumnFilter AdjNbr { get; }
				public DropDownColumnFilter ARPayment__Status { get; }
				public DropDownColumnFilter ExternalTransaction__ProcStatus { get; }
				public CheckBoxColumnFilter CanVoid { get; }
				public CheckBoxColumnFilter CanCapture { get; }
				public SelectorColumnFilter AdjdLineNbr { get; }
                
                public c_grid_header(c_adjustments_detgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    AdjgDocType = new DropDownColumnFilter(grid.Row.AdjgDocType);
                    AdjgRefNbr = new SelectorColumnFilter(grid.Row.AdjgRefNbr);
                    CuryAdjdAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjdAmt);
                    CuryAdjgDiscAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjgDiscAmt);
                    CuryAdjdWOAmt = new PXNumberEditColumnFilter(grid.Row.CuryAdjdWOAmt);
                    ARPayment__DocDate = new DateSelectorColumnFilter(grid.Row.ARPayment__DocDate);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    ARPayment__DocDesc = new PXTextEditColumnFilter(grid.Row.ARPayment__DocDesc);
                    ARPayment__CuryID = new SelectorColumnFilter(grid.Row.ARPayment__CuryID);
                    ARPayment__FinPeriodID = new SelectorColumnFilter(grid.Row.ARPayment__FinPeriodID);
                    ARPayment__ExtRefNbr = new PXTextEditColumnFilter(grid.Row.ARPayment__ExtRefNbr);
                    CustomerID = new SelectorColumnFilter(grid.Row.CustomerID);
                    AdjdDocType = new PXTextEditColumnFilter(grid.Row.AdjdDocType);
                    AdjdRefNbr = new PXTextEditColumnFilter(grid.Row.AdjdRefNbr);
                    AdjNbr = new PXNumberEditColumnFilter(grid.Row.AdjNbr);
                    ARPayment__Status = new DropDownColumnFilter(grid.Row.ARPayment__Status);
                    ExternalTransaction__ProcStatus = new DropDownColumnFilter(grid.Row.ExternalTransaction__ProcStatus);
                    CanVoid = new CheckBoxColumnFilter(grid.Row.CanVoid);
                    CanCapture = new CheckBoxColumnFilter(grid.Row.CanCapture);
                    AdjdLineNbr = new SelectorColumnFilter(grid.Row.AdjdLineNbr);
                }
            }
        }
        
        public class c_adjustments_lv0 : Container
        {
            
			public DropDown AdjgDocType { get; }
			public Label AdjgDocTypeLabel { get; }
			public Selector AdjgRefNbr { get; }
			public Label AdjgRefNbrLabel { get; }
			public PXNumberEdit CuryAdjdAmt { get; }
			public Label CuryAdjdAmtLabel { get; }
			public DateSelector ARPayment__DocDate { get; }
			public Label ARPayment__DocDateLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public Selector ARPayment__CuryID { get; }
			public Label ARPayment__CuryIDLabel { get; }
			public Selector ARPayment__FinPeriodID { get; }
			public Label ARPayment__FinPeriodIDLabel { get; }
			public PXTextEdit ARPayment__ExtRefNbr { get; }
			public Label ARPayment__ExtRefNbrLabel { get; }
			public DropDown ARPayment__Status { get; }
			public Label ARPayment__StatusLabel { get; }
			public PXTextEdit ARPayment__DocDesc { get; }
			public Label ARPayment__DocDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_adjustments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AdjgDocType = new DropDown("ctl00_phG_tab_t7_detgrid_lv0_edAdjgDocType", "Doc. Type", locator, null);
                AdjgDocTypeLabel = new Label(AdjgDocType);
                AdjgDocType.DataField = "AdjgDocType";
                AdjgDocType.Items.Add("CRM", "Credit Memo");
                AdjgDocType.Items.Add("PMT", "Payment");
                AdjgDocType.Items.Add("PPM", "Prepayment");
                AdjgRefNbr = new Selector("ctl00_phG_tab_t7_detgrid_lv0_edAdjgRefNbr", "Reference Nbr.", locator, null);
                AdjgRefNbrLabel = new Label(AdjgRefNbr);
                AdjgRefNbr.DataField = "AdjgRefNbr";
                CuryAdjdAmt = new PXNumberEdit("ctl00_phG_tab_t7_detgrid_lv0_edCuryAdjdAmt", "Amount Paid", locator, null);
                CuryAdjdAmtLabel = new Label(CuryAdjdAmt);
                CuryAdjdAmt.DataField = "CuryAdjdAmt";
                ARPayment__DocDate = new DateSelector("ctl00_phG_tab_t7_detgrid_lv0_edARPayment__DocDate", "Payment Date", locator, null);
                ARPayment__DocDateLabel = new Label(ARPayment__DocDate);
                ARPayment__DocDate.DataField = "ARPayment__DocDate";
                CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t7_detgrid_lv0_edCuryDocBal", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                ARPayment__CuryID = new Selector("ctl00_phG_tab_t7_detgrid_lv0_edARPayment__CuryID", "Currency", locator, null);
                ARPayment__CuryIDLabel = new Label(ARPayment__CuryID);
                ARPayment__CuryID.DataField = "ARPayment__CuryID";
                ARPayment__FinPeriodID = new Selector("ctl00_phG_tab_t7_detgrid_lv0_edARPayment__FinPeriodID", "Payment Period", locator, null);
                ARPayment__FinPeriodIDLabel = new Label(ARPayment__FinPeriodID);
                ARPayment__FinPeriodID.DataField = "ARPayment__FinPeriodID";
                ARPayment__ExtRefNbr = new PXTextEdit("ctl00_phG_tab_t7_detgrid_lv0_edARPayment__ExtRefNbr", "Payment Ref.", locator, null);
                ARPayment__ExtRefNbrLabel = new Label(ARPayment__ExtRefNbr);
                ARPayment__ExtRefNbr.DataField = "ARPayment__ExtRefNbr";
                ARPayment__Status = new DropDown("ctl00_phG_tab_t7_detgrid_lv0_edARPayment__Status", "Status", locator, null);
                ARPayment__StatusLabel = new Label(ARPayment__Status);
                ARPayment__Status.DataField = "ARPayment__Status";
                ARPayment__Status.Items.Add("R", "Credit Hold");
                ARPayment__Status.Items.Add("W", "Pending Processing");
                ARPayment__Status.Items.Add("H", "On Hold");
                ARPayment__Status.Items.Add("B", "Balanced");
                ARPayment__Status.Items.Add("V", "Voided");
                ARPayment__Status.Items.Add("S", "Scheduled");
                ARPayment__Status.Items.Add("N", "Open");
                ARPayment__Status.Items.Add("C", "Closed");
                ARPayment__Status.Items.Add("P", "Pending Print");
                ARPayment__Status.Items.Add("E", "Pending Email");
                ARPayment__Status.Items.Add("Z", "Reserved");
                ARPayment__Status.Items.Add("D", "Pending Approval");
                ARPayment__Status.Items.Add("J", "Rejected");
                ARPayment__Status.Items.Add("L", "Canceled");
                ARPayment__DocDesc = new PXTextEdit("ctl00_phG_tab_t7_detgrid_lv0_edARPayment__DocDesc", "Description", locator, null);
                ARPayment__DocDescLabel = new Label(ARPayment__DocDesc);
                ARPayment__DocDesc.DataField = "ARPayment__DocDesc";
                Es = new Selector("ctl00_phG_tab_t7_detgrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t7_detgrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "Adjustments";
            }
        }
        
        public class c_adjustments_1_detgrid2 : Grid<c_adjustments_1_detgrid2.c_grid_row, c_adjustments_1_detgrid2.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_adjustments_1_detgrid2(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_detgrid2");
                DataMemberName = "Adjustments_1";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_detgrid2_fe_gf", "FilterForm");
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
            
            public virtual void CreateDocumentRefund()
            {
                ToolBar.CreateDocumentRefund.Click();
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
			public ToolBarButtonGrid CreateDocumentRefund { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    CreateDocumentRefund = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_at_tlb div[data-cmd=\'CreateDocumentRefund\']", "Create Refund", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_detgrid2_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public DropDown DisplayDocType { get; }
			public Selector DisplayRefNbr { get; }
			public Selector DisplayCustomerID { get; }
			public PXNumberEdit DisplayCuryAmt { get; }
			public DateSelector DisplayDocDate { get; }
			public PXNumberEdit CuryDocBal { get; }
			public PXTextEdit DisplayDocDesc { get; }
			public Selector DisplayCuryID { get; }
			public Selector DisplayFinPeriodID { get; }
			public PXTextEdit ARInvoice__InvoiceNbr { get; }
			public DropDown DisplayStatus { get; }
			public DropDown DisplayProcStatus { get; }
			public PXTextEdit AdjgDocType { get; }
			public PXTextEdit AdjgRefNbr { get; }
			public DropDown AdjdDocType { get; }
			public PXTextEdit AdjdRefNbr { get; }
			public Selector AdjdLineNbr { get; }
			public PXNumberEdit AdjNbr { get; }
                
                public c_grid_row(c_adjustments_1_detgrid2 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    DisplayDocType = new DropDown("_ctl00_phG_tab_t7_detgrid2_lv0_edAdjdDocType3", "Doc. Type", grid.Locator, "DisplayDocType");
                    DisplayDocType.DataField = "DisplayDocType";
                    DisplayDocType.Items.Add("INV", "Invoice");
                    DisplayDocType.Items.Add("DRM", "Debit Memo");
                    DisplayDocType.Items.Add("FCH", "Overdue Charge");
                    DisplayDocType.Items.Add("REF", "Customer Refund");
                    DisplayRefNbr = new Selector("_ctl00_phG_tab_t7_detgrid2_lv0_edAdjdRefNbr3", "Reference Nbr.", grid.Locator, "DisplayRefNbr");
                    DisplayRefNbr.DataField = "DisplayRefNbr";
                    DisplayCustomerID = new Selector("_ctl00_phG_tab_t7_detgrid2_lv0_es", "Customer", grid.Locator, "DisplayCustomerID");
                    DisplayCustomerID.DataField = "DisplayCustomerID";
                    DisplayCuryAmt = new PXNumberEdit("_ctl00_phG_tab_t7_detgrid2_lv0_edCuryAdjgAmt3", "Amount Paid", grid.Locator, "DisplayCuryAmt");
                    DisplayCuryAmt.DataField = "DisplayCuryAmt";
                    DisplayDocDate = new DateSelector("_ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__DocDate3", "Date", grid.Locator, "DisplayDocDate");
                    DisplayDocDate.DataField = "DisplayDocDate";
                    CuryDocBal = new PXNumberEdit("_ctl00_phG_tab_t7_detgrid2_lv0_edCuryDocBal3", "Balance", grid.Locator, "CuryDocBal");
                    CuryDocBal.DataField = "CuryDocBal";
                    DisplayDocDesc = new PXTextEdit("_ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__DocDesc3", "Description", grid.Locator, "DisplayDocDesc");
                    DisplayDocDesc.DataField = "DisplayDocDesc";
                    DisplayCuryID = new Selector("_ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__CuryID3", "Currency", grid.Locator, "DisplayCuryID");
                    DisplayCuryID.DataField = "DisplayCuryID";
                    DisplayFinPeriodID = new Selector("_ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__FinPeriodID3", "Post Period", grid.Locator, "DisplayFinPeriodID");
                    DisplayFinPeriodID.DataField = "DisplayFinPeriodID";
                    ARInvoice__InvoiceNbr = new PXTextEdit("_ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__InvoiceNbr3", "Customer Order Nbr.", grid.Locator, "ARInvoice__InvoiceNbr");
                    ARInvoice__InvoiceNbr.DataField = "ARInvoice__InvoiceNbr";
                    DisplayStatus = new DropDown("_ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__Status3", "Status", grid.Locator, "DisplayStatus");
                    DisplayStatus.DataField = "DisplayStatus";
                    DisplayStatus.Items.Add("R", "Credit Hold");
                    DisplayStatus.Items.Add("W", "Pending Processing");
                    DisplayStatus.Items.Add("H", "On Hold");
                    DisplayStatus.Items.Add("B", "Balanced");
                    DisplayStatus.Items.Add("V", "Voided");
                    DisplayStatus.Items.Add("S", "Scheduled");
                    DisplayStatus.Items.Add("N", "Open");
                    DisplayStatus.Items.Add("C", "Closed");
                    DisplayStatus.Items.Add("P", "Pending Print");
                    DisplayStatus.Items.Add("E", "Pending Email");
                    DisplayStatus.Items.Add("Z", "Reserved");
                    DisplayStatus.Items.Add("D", "Pending Approval");
                    DisplayStatus.Items.Add("J", "Rejected");
                    DisplayStatus.Items.Add("L", "Canceled");
                    DisplayProcStatus = new DropDown("_ctl00_phG_tab_t7_detgrid2_lv0_ec", "Proc. Status", grid.Locator, "DisplayProcStatus");
                    DisplayProcStatus.DataField = "DisplayProcStatus";
                    DisplayProcStatus.Items.Add("AUF", "Pre-Authorization Failed");
                    DisplayProcStatus.Items.Add("CAF", "Capture Failed");
                    DisplayProcStatus.Items.Add("VDF", "Voiding failed");
                    DisplayProcStatus.Items.Add("CDF", "Refund Failed");
                    DisplayProcStatus.Items.Add("AUS", "Pre-Authorized");
                    DisplayProcStatus.Items.Add("CAS", "Captured");
                    DisplayProcStatus.Items.Add("VDS", "Voided");
                    DisplayProcStatus.Items.Add("CDS", "Refunded");
                    DisplayProcStatus.Items.Add("AUH", "Held for Review (Authorization)");
                    DisplayProcStatus.Items.Add("CAH", "Held for Review (Capture)");
                    DisplayProcStatus.Items.Add("VDH", "Held for Review (Void)");
                    DisplayProcStatus.Items.Add("CDH", "Held for Review (Refund)");
                    DisplayProcStatus.Items.Add("AUD", "Pre-Authorization Declined");
                    DisplayProcStatus.Items.Add("CAD", "Capture Declined");
                    DisplayProcStatus.Items.Add("VDD", "Voiding Declined");
                    DisplayProcStatus.Items.Add("CDD", "Refund Declined");
                    DisplayProcStatus.Items.Add("AUE", "Pre-Authorization Expired");
                    DisplayProcStatus.Items.Add("CAE", "Held for Review (Capture) Expired");
                    DisplayProcStatus.Items.Add("UKN", "Unknown");
                    AdjgDocType = new PXTextEdit("ctl00_phG_tab_t7_detgrid2_ei", "AdjgDocType", grid.Locator, "AdjgDocType");
                    AdjgDocType.DataField = "AdjgDocType";
                    AdjgRefNbr = new PXTextEdit("ctl00_phG_tab_t7_detgrid2_ei", "AdjgRefNbr", grid.Locator, "AdjgRefNbr");
                    AdjgRefNbr.DataField = "AdjgRefNbr";
                    AdjdDocType = new DropDown("_ctl00_phG_tab_t7_detgrid2_lv0_ec", "Doc. Type", grid.Locator, "AdjdDocType");
                    AdjdDocType.DataField = "AdjdDocType";
                    AdjdDocType.Items.Add("INV", "Invoice");
                    AdjdDocType.Items.Add("DRM", "Debit Memo");
                    AdjdDocType.Items.Add("FCH", "Overdue Charge");
                    AdjdRefNbr = new PXTextEdit("ctl00_phG_tab_t7_detgrid2_em", "Reference Nbr.", grid.Locator, "AdjdRefNbr");
                    AdjdRefNbr.DataField = "AdjdRefNbr";
                    AdjdLineNbr = new Selector("_ctl00_phG_tab_t7_detgrid2_lv0_es", "Line Nbr.", grid.Locator, "AdjdLineNbr");
                    AdjdLineNbr.DataField = "AdjdLineNbr";
                    AdjNbr = new PXNumberEdit("ctl00_phG_tab_t7_detgrid2_en", "AdjNbr", grid.Locator, "AdjNbr");
                    AdjNbr.DataField = "AdjNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter DisplayDocType { get; }
				public SelectorColumnFilter DisplayRefNbr { get; }
				public SelectorColumnFilter DisplayCustomerID { get; }
				public PXNumberEditColumnFilter DisplayCuryAmt { get; }
				public DateSelectorColumnFilter DisplayDocDate { get; }
				public PXNumberEditColumnFilter CuryDocBal { get; }
				public PXTextEditColumnFilter DisplayDocDesc { get; }
				public SelectorColumnFilter DisplayCuryID { get; }
				public SelectorColumnFilter DisplayFinPeriodID { get; }
				public PXTextEditColumnFilter ARInvoice__InvoiceNbr { get; }
				public DropDownColumnFilter DisplayStatus { get; }
				public DropDownColumnFilter DisplayProcStatus { get; }
				public PXTextEditColumnFilter AdjgDocType { get; }
				public PXTextEditColumnFilter AdjgRefNbr { get; }
				public DropDownColumnFilter AdjdDocType { get; }
				public PXTextEditColumnFilter AdjdRefNbr { get; }
				public SelectorColumnFilter AdjdLineNbr { get; }
				public PXNumberEditColumnFilter AdjNbr { get; }
                
                public c_grid_header(c_adjustments_1_detgrid2 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    DisplayDocType = new DropDownColumnFilter(grid.Row.DisplayDocType);
                    DisplayRefNbr = new SelectorColumnFilter(grid.Row.DisplayRefNbr);
                    DisplayCustomerID = new SelectorColumnFilter(grid.Row.DisplayCustomerID);
                    DisplayCuryAmt = new PXNumberEditColumnFilter(grid.Row.DisplayCuryAmt);
                    DisplayDocDate = new DateSelectorColumnFilter(grid.Row.DisplayDocDate);
                    CuryDocBal = new PXNumberEditColumnFilter(grid.Row.CuryDocBal);
                    DisplayDocDesc = new PXTextEditColumnFilter(grid.Row.DisplayDocDesc);
                    DisplayCuryID = new SelectorColumnFilter(grid.Row.DisplayCuryID);
                    DisplayFinPeriodID = new SelectorColumnFilter(grid.Row.DisplayFinPeriodID);
                    ARInvoice__InvoiceNbr = new PXTextEditColumnFilter(grid.Row.ARInvoice__InvoiceNbr);
                    DisplayStatus = new DropDownColumnFilter(grid.Row.DisplayStatus);
                    DisplayProcStatus = new DropDownColumnFilter(grid.Row.DisplayProcStatus);
                    AdjgDocType = new PXTextEditColumnFilter(grid.Row.AdjgDocType);
                    AdjgRefNbr = new PXTextEditColumnFilter(grid.Row.AdjgRefNbr);
                    AdjdDocType = new DropDownColumnFilter(grid.Row.AdjdDocType);
                    AdjdRefNbr = new PXTextEditColumnFilter(grid.Row.AdjdRefNbr);
                    AdjdLineNbr = new SelectorColumnFilter(grid.Row.AdjdLineNbr);
                    AdjNbr = new PXNumberEditColumnFilter(grid.Row.AdjNbr);
                }
            }
        }
        
        public class c_adjustments_1_lv0 : Container
        {
            
			public DropDown DisplayDocType { get; }
			public Label DisplayDocTypeLabel { get; }
			public Selector DisplayRefNbr { get; }
			public Label DisplayRefNbrLabel { get; }
			public PXNumberEdit DisplayCuryAmt { get; }
			public Label DisplayCuryAmtLabel { get; }
			public DateSelector DisplayDocDate { get; }
			public Label DisplayDocDateLabel { get; }
			public PXNumberEdit CuryDocBal { get; }
			public Label CuryDocBalLabel { get; }
			public Selector DisplayCuryID { get; }
			public Label DisplayCuryIDLabel { get; }
			public Selector DisplayFinPeriodID { get; }
			public Label DisplayFinPeriodIDLabel { get; }
			public PXTextEdit ARInvoice__InvoiceNbr { get; }
			public Label ARInvoice__InvoiceNbrLabel { get; }
			public DropDown DisplayStatus { get; }
			public Label DisplayStatusLabel { get; }
			public PXTextEdit DisplayDocDesc { get; }
			public Label DisplayDocDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_adjustments_1_lv0(string locator, string name) : 
                    base(locator, name)
            {
                DisplayDocType = new DropDown("ctl00_phG_tab_t7_detgrid2_lv0_edAdjdDocType3", "Doc. Type", locator, null);
                DisplayDocTypeLabel = new Label(DisplayDocType);
                DisplayDocType.DataField = "DisplayDocType";
                DisplayDocType.Items.Add("INV", "Invoice");
                DisplayDocType.Items.Add("DRM", "Debit Memo");
                DisplayDocType.Items.Add("FCH", "Overdue Charge");
                DisplayDocType.Items.Add("REF", "Customer Refund");
                DisplayRefNbr = new Selector("ctl00_phG_tab_t7_detgrid2_lv0_edAdjdRefNbr3", "Reference Nbr.", locator, null);
                DisplayRefNbrLabel = new Label(DisplayRefNbr);
                DisplayRefNbr.DataField = "DisplayRefNbr";
                DisplayCuryAmt = new PXNumberEdit("ctl00_phG_tab_t7_detgrid2_lv0_edCuryAdjgAmt3", "Amount Paid", locator, null);
                DisplayCuryAmtLabel = new Label(DisplayCuryAmt);
                DisplayCuryAmt.DataField = "DisplayCuryAmt";
                DisplayDocDate = new DateSelector("ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__DocDate3", "Date", locator, null);
                DisplayDocDateLabel = new Label(DisplayDocDate);
                DisplayDocDate.DataField = "DisplayDocDate";
                CuryDocBal = new PXNumberEdit("ctl00_phG_tab_t7_detgrid2_lv0_edCuryDocBal3", "Balance", locator, null);
                CuryDocBalLabel = new Label(CuryDocBal);
                CuryDocBal.DataField = "CuryDocBal";
                DisplayCuryID = new Selector("ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__CuryID3", "Currency", locator, null);
                DisplayCuryIDLabel = new Label(DisplayCuryID);
                DisplayCuryID.DataField = "DisplayCuryID";
                DisplayFinPeriodID = new Selector("ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__FinPeriodID3", "Post Period", locator, null);
                DisplayFinPeriodIDLabel = new Label(DisplayFinPeriodID);
                DisplayFinPeriodID.DataField = "DisplayFinPeriodID";
                ARInvoice__InvoiceNbr = new PXTextEdit("ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__InvoiceNbr3", "Customer Order Nbr.", locator, null);
                ARInvoice__InvoiceNbrLabel = new Label(ARInvoice__InvoiceNbr);
                ARInvoice__InvoiceNbr.DataField = "ARInvoice__InvoiceNbr";
                DisplayStatus = new DropDown("ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__Status3", "Status", locator, null);
                DisplayStatusLabel = new Label(DisplayStatus);
                DisplayStatus.DataField = "DisplayStatus";
                DisplayStatus.Items.Add("R", "Credit Hold");
                DisplayStatus.Items.Add("W", "Pending Processing");
                DisplayStatus.Items.Add("H", "On Hold");
                DisplayStatus.Items.Add("B", "Balanced");
                DisplayStatus.Items.Add("V", "Voided");
                DisplayStatus.Items.Add("S", "Scheduled");
                DisplayStatus.Items.Add("N", "Open");
                DisplayStatus.Items.Add("C", "Closed");
                DisplayStatus.Items.Add("P", "Pending Print");
                DisplayStatus.Items.Add("E", "Pending Email");
                DisplayStatus.Items.Add("Z", "Reserved");
                DisplayStatus.Items.Add("D", "Pending Approval");
                DisplayStatus.Items.Add("J", "Rejected");
                DisplayStatus.Items.Add("L", "Canceled");
                DisplayDocDesc = new PXTextEdit("ctl00_phG_tab_t7_detgrid2_lv0_edARInvoice__DocDesc3", "Description", locator, null);
                DisplayDocDescLabel = new Label(DisplayDocDesc);
                DisplayDocDesc.DataField = "DisplayDocDesc";
                Es = new Selector("ctl00_phG_tab_t7_detgrid2_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t7_detgrid2_lv0_ec", "Ec", locator, null);
                DataMemberName = "Adjustments_1";
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
                OverrideAddress = new CheckBox("ctl00_phG_tab_t5_Shipping_Address_chkOverrideAddress", "Override Address", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t5_Shipping_Address_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t5_Shipping_Address_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t5_Shipping_Address_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t5_Shipping_Address_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t5_Shipping_Address_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t5_Shipping_Address_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                Latitude = new PXNumberEdit("ctl00_phG_tab_t5_Shipping_Address_edLatitude", "Latitude", locator, null);
                LatitudeLabel = new Label(Latitude);
                Latitude.DataField = "Latitude";
                Longitude = new PXNumberEdit("ctl00_phG_tab_t5_Shipping_Address_edLongitude", "Longitude", locator, null);
                LongitudeLabel = new Label(Longitude);
                Longitude.DataField = "Longitude";
                IsValidated = new CheckBox("ctl00_phG_tab_t5_Shipping_Address_edIsValidated", "Validated", locator, null);
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
                    AddressLookup = new Button("ctl00_phG_tab_t5_Shipping_Address_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_Shipping_Address");
                    AddressLookup1 = new Button("ctl00_phG_tab_t5_formA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_Shipping_Address");
                }
            }
        }
        
        public class c_currentdocument_address : Container
        {
            
			public CheckBox MultiShipAddress { get; }
			public Label MultiShipAddressLabel { get; }
            
            public c_currentdocument_address(string locator, string name) : 
                    base(locator, name)
            {
                MultiShipAddress = new CheckBox("ctl00_phG_tab_t5_Shipping_Address_chkMultiShipAddress", "Multiple Ship-To Addresses", locator, null);
                MultiShipAddressLabel = new Label(MultiShipAddress);
                MultiShipAddress.DataField = "MultiShipAddress";
                DataMemberName = "CurrentDocument";
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
                OverrideContact = new CheckBox("ctl00_phG_tab_t5_Shipping_Contact_chkOverrideContact", "Override Contact", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t5_Shipping_Contact_edFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t5_Shipping_Contact_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t5_Shipping_Contact_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t5_Shipping_Contact_edEmail", "Email", locator, null);
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
                    AddressLookup = new Button("ctl00_phG_tab_t5_formA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_Shipping_Contact");
                    AddressLookup1 = new Button("ctl00_phG_tab_t5_Shipping_Address_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_Shipping_Contact");
                }
            }
        }
        
        public class c_billing_address_forma : Container
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
            
            public c_billing_address_forma(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t5_formA_chkOverrideAddress", "Override Address", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t5_formA_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t5_formA_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t5_formA_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t5_formA_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t5_formA_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t5_formA_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                IsValidated = new CheckBox("ctl00_phG_tab_t5_formA_edIsValidated", "Validated", locator, null);
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
                    AddressLookup = new Button("ctl00_phG_tab_t5_formA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_formA");
                    AddressLookup1 = new Button("ctl00_phG_tab_t5_Shipping_Address_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_formA");
                }
            }
        }
        
        public class c_billing_contact_formc : Container
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
            
            public c_billing_contact_formc(string locator, string name) : 
                    base(locator, name)
            {
                OverrideContact = new CheckBox("ctl00_phG_tab_t5_formC_chkOverrideContact", "Override Contact", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t5_formC_edFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t5_formC_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t5_formC_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t5_formC_edEmail", "Email", locator, null);
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
                    AddressLookup = new Button("ctl00_phG_tab_t5_formA_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_formC");
                    AddressLookup1 = new Button("ctl00_phG_tab_t5_Shipping_Address_btnShippingAddressLookup", "Address Lookup", "ctl00_phG_tab_t5_formC");
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
                    Ok = new Button("ctl00_phG_PanelRecalcDiscounts_PXButton10", "OK", "ctl00_phG_PanelRecalcDiscounts_formRecalcDiscounts");
                }
            }
        }
        
        public class c_ardiscountdetails_discountdetailgrid : Grid<c_ardiscountdetails_discountdetailgrid.c_grid_row, c_ardiscountdetails_discountdetailgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_ardiscountdetails_discountdetailgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_discountDetailGrid");
                DataMemberName = "ARDiscountDetails";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_discountDetailGrid_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_discountDetailGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DiscountSequenceIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t6_discountDetailGrid");
                    DiscountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t6_discountDetailGrid");
                    DiscountSequenceIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox SkipDiscount { get; }
			public PXTextEdit LineNbr { get; }
			public PXTextEdit OrderType { get; }
			public Selector OrderNbr { get; }
			public Selector DiscountID { get; }
			public Selector DiscountSequenceID { get; }
			public DropDown Type { get; }
			public CheckBox IsManual { get; }
			public PXNumberEdit CuryDiscountableAmt { get; }
			public PXNumberEdit DiscountableQty { get; }
			public PXNumberEdit CuryDiscountAmt { get; }
			public PXNumberEdit DiscountPct { get; }
			public Selector FreeItemID { get; }
			public PXNumberEdit FreeItemQty { get; }
			public PXTextEdit ExtDiscCode { get; }
			public PXTextEdit Description { get; }
			public PXTextEdit DocType { get; }
			public PXNumberEdit RecordID { get; }
			public PXTextEdit RefNbr { get; }
                
                public c_grid_row(c_ardiscountdetails_discountdetailgrid grid) : 
                        base(grid)
                {
                    SkipDiscount = new CheckBox("_ctl00_phG_tab_t6_discountDetailGrid_lv0_chkSkipDiscount", "Skip Discount", grid.Locator, "SkipDiscount");
                    SkipDiscount.DataField = "SkipDiscount";
                    LineNbr = new PXTextEdit("ctl00_phG_tab_t6_discountDetailGrid", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    OrderType = new PXTextEdit("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edSOOrderType", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new Selector("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edSOOrderNbr", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    DiscountID = new Selector("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountID", "Discount Code", grid.Locator, "DiscountID");
                    DiscountID.DataField = "DiscountID";
                    DiscountSequenceID = new Selector("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountSequenceID", "Sequence ID", grid.Locator, "DiscountSequenceID");
                    DiscountSequenceID.DataField = "DiscountSequenceID";
                    Type = new DropDown("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edType", "Type", grid.Locator, "Type");
                    Type.DataField = "Type";
                    Type.Items.Add("L", "Line");
                    Type.Items.Add("G", "Group");
                    Type.Items.Add("D", "Document");
                    Type.Items.Add("B", "External Document");
                    IsManual = new CheckBox("_ctl00_phG_tab_t6_discountDetailGrid_lv0_chkIsManual", "Manual Discount", grid.Locator, "IsManual");
                    IsManual.DataField = "IsManual";
                    CuryDiscountableAmt = new PXNumberEdit("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edCuryDiscountableAmt", "Discountable Amt.", grid.Locator, "CuryDiscountableAmt");
                    CuryDiscountableAmt.DataField = "CuryDiscountableAmt";
                    DiscountableQty = new PXNumberEdit("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountableQty", "Discountable Qty.", grid.Locator, "DiscountableQty");
                    DiscountableQty.DataField = "DiscountableQty";
                    CuryDiscountAmt = new PXNumberEdit("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edCuryDiscountAmt", "Discount Amt.", grid.Locator, "CuryDiscountAmt");
                    CuryDiscountAmt.DataField = "CuryDiscountAmt";
                    DiscountPct = new PXNumberEdit("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountPct", "Discount Percent", grid.Locator, "DiscountPct");
                    DiscountPct.DataField = "DiscountPct";
                    FreeItemID = new Selector("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edFreeItemID", "Free Item", grid.Locator, "FreeItemID");
                    FreeItemID.DataField = "FreeItemID";
                    FreeItemQty = new PXNumberEdit("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edFreeItemQty", "Free Item Qty.", grid.Locator, "FreeItemQty");
                    FreeItemQty.DataField = "FreeItemQty";
                    ExtDiscCode = new PXTextEdit("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edExtDiscCode", "External Discount Code", grid.Locator, "ExtDiscCode");
                    ExtDiscCode.DataField = "ExtDiscCode";
                    Description = new PXTextEdit("_ctl00_phG_tab_t6_discountDetailGrid_lv0_edDescription", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    DocType = new PXTextEdit("ctl00_phG_tab_t6_discountDetailGrid_ei", "Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t6_discountDetailGrid_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t6_discountDetailGrid_em", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter SkipDiscount { get; }
				public PXTextEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public SelectorColumnFilter DiscountID { get; }
				public SelectorColumnFilter DiscountSequenceID { get; }
				public DropDownColumnFilter Type { get; }
				public CheckBoxColumnFilter IsManual { get; }
				public PXNumberEditColumnFilter CuryDiscountableAmt { get; }
				public PXNumberEditColumnFilter DiscountableQty { get; }
				public PXNumberEditColumnFilter CuryDiscountAmt { get; }
				public PXNumberEditColumnFilter DiscountPct { get; }
				public SelectorColumnFilter FreeItemID { get; }
				public PXNumberEditColumnFilter FreeItemQty { get; }
				public PXTextEditColumnFilter ExtDiscCode { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXNumberEditColumnFilter RecordID { get; }
				public PXTextEditColumnFilter RefNbr { get; }
                
                public c_grid_header(c_ardiscountdetails_discountdetailgrid grid) : 
                        base(grid)
                {
                    SkipDiscount = new CheckBoxColumnFilter(grid.Row.SkipDiscount);
                    LineNbr = new PXTextEditColumnFilter(grid.Row.LineNbr);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    DiscountID = new SelectorColumnFilter(grid.Row.DiscountID);
                    DiscountSequenceID = new SelectorColumnFilter(grid.Row.DiscountSequenceID);
                    Type = new DropDownColumnFilter(grid.Row.Type);
                    IsManual = new CheckBoxColumnFilter(grid.Row.IsManual);
                    CuryDiscountableAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountableAmt);
                    DiscountableQty = new PXNumberEditColumnFilter(grid.Row.DiscountableQty);
                    CuryDiscountAmt = new PXNumberEditColumnFilter(grid.Row.CuryDiscountAmt);
                    DiscountPct = new PXNumberEditColumnFilter(grid.Row.DiscountPct);
                    FreeItemID = new SelectorColumnFilter(grid.Row.FreeItemID);
                    FreeItemQty = new PXNumberEditColumnFilter(grid.Row.FreeItemQty);
                    ExtDiscCode = new PXTextEditColumnFilter(grid.Row.ExtDiscCode);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                }
            }
        }
        
        public class c_ardiscountdetails_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox SkipDiscount { get; }
			public Label SkipDiscountLabel { get; }
			public PXTextEdit OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public Selector DiscountID { get; }
			public Label DiscountIDLabel { get; }
			public Selector DiscountSequenceID { get; }
			public Label DiscountSequenceIDLabel { get; }
			public PXTextEdit Type { get; }
			public Label TypeLabel { get; }
			public CheckBox IsManual { get; }
			public Label IsManualLabel { get; }
			public PXNumberEdit CuryDiscountableAmt { get; }
			public Label CuryDiscountableAmtLabel { get; }
			public PXNumberEdit DiscountableQty { get; }
			public Label DiscountableQtyLabel { get; }
			public PXNumberEdit CuryDiscountAmt { get; }
			public Label CuryDiscountAmtLabel { get; }
			public PXNumberEdit DiscountPct { get; }
			public Label DiscountPctLabel { get; }
			public Selector FreeItemID { get; }
			public Label FreeItemIDLabel { get; }
			public PXNumberEdit FreeItemQty { get; }
			public Label FreeItemQtyLabel { get; }
			public PXTextEdit ExtDiscCode { get; }
			public Label ExtDiscCodeLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_ardiscountdetails_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SkipDiscount = new CheckBox("ctl00_phG_tab_t6_discountDetailGrid_lv0_chkSkipDiscount", "Skip Discount", locator, null);
                SkipDiscountLabel = new Label(SkipDiscount);
                SkipDiscount.DataField = "SkipDiscount";
                OrderType = new PXTextEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edSOOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phG_tab_t6_discountDetailGrid_lv0_edSOOrderNbr", "Order Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                DiscountID = new Selector("ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountID", "Discount Code", locator, null);
                DiscountIDLabel = new Label(DiscountID);
                DiscountID.DataField = "DiscountID";
                DiscountSequenceID = new Selector("ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountSequenceID", "Sequence ID", locator, null);
                DiscountSequenceIDLabel = new Label(DiscountSequenceID);
                DiscountSequenceID.DataField = "DiscountSequenceID";
                Type = new PXTextEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edType", "Type", locator, null);
                TypeLabel = new Label(Type);
                Type.DataField = "Type";
                IsManual = new CheckBox("ctl00_phG_tab_t6_discountDetailGrid_lv0_chkIsManual", "Manual Discount", locator, null);
                IsManualLabel = new Label(IsManual);
                IsManual.DataField = "IsManual";
                CuryDiscountableAmt = new PXNumberEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edCuryDiscountableAmt", "Discountable Amt.", locator, null);
                CuryDiscountableAmtLabel = new Label(CuryDiscountableAmt);
                CuryDiscountableAmt.DataField = "CuryDiscountableAmt";
                DiscountableQty = new PXNumberEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountableQty", "Discountable Qty.", locator, null);
                DiscountableQtyLabel = new Label(DiscountableQty);
                DiscountableQty.DataField = "DiscountableQty";
                CuryDiscountAmt = new PXNumberEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edCuryDiscountAmt", "Discount Amt.", locator, null);
                CuryDiscountAmtLabel = new Label(CuryDiscountAmt);
                CuryDiscountAmt.DataField = "CuryDiscountAmt";
                DiscountPct = new PXNumberEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountPct", "Discount Percent", locator, null);
                DiscountPctLabel = new Label(DiscountPct);
                DiscountPct.DataField = "DiscountPct";
                FreeItemID = new Selector("ctl00_phG_tab_t6_discountDetailGrid_lv0_edFreeItemID", "Free Item", locator, null);
                FreeItemIDLabel = new Label(FreeItemID);
                FreeItemID.DataField = "FreeItemID";
                FreeItemQty = new PXNumberEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edFreeItemQty", "Free Item Qty.", locator, null);
                FreeItemQtyLabel = new Label(FreeItemQty);
                FreeItemQty.DataField = "FreeItemQty";
                ExtDiscCode = new PXTextEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edExtDiscCode", "External Discount Code", locator, null);
                ExtDiscCodeLabel = new Label(ExtDiscCode);
                ExtDiscCode.DataField = "ExtDiscCode";
                Description = new PXTextEdit("ctl00_phG_tab_t6_discountDetailGrid_lv0_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                Es = new Selector("ctl00_phG_tab_t6_discountDetailGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "ARDiscountDetails";
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
            
            public virtual void FreeItemIDEdit()
            {
                Buttons.FreeItemIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DiscountIDEdit { get; }
			public Button DiscountSequenceIDEdit { get; }
			public Button FreeItemIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DiscountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "DiscountIDEdit", "ctl00_phG_tab_t6_discountDetailGrid_lv0");
                    DiscountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DiscountSequenceIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_discountDetailGrid_lv0_edDiscountSequenceID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "DiscountSequenceIDEdit", "ctl00_phG_tab_t6_discountDetailGrid_lv0");
                    DiscountSequenceIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    FreeItemIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t6_discountDetailGrid_lv0_edFreeItemID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "FreeItemIDEdit", "ctl00_phG_tab_t6_discountDetailGrid_lv0");
                    FreeItemIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_salespertrans_gridsalespertran : Grid<c_salespertrans_gridsalespertran.c_grid_row, c_salespertrans_gridsalespertran.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_salespertrans_gridsalespertran(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_gridSalesPerTran");
                DataMemberName = "SalesPerTrans";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_gridSalesPerTran_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridSalesPerTran_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SalespersonID { get; }
			public PXNumberEdit CommnPct { get; }
			public PXNumberEdit CuryCommnAmt { get; }
			public PXNumberEdit CuryCommnblAmt { get; }
			public PXTextEdit DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit AdjNbr { get; }
			public PXTextEdit AdjdDocType { get; }
			public PXTextEdit AdjdRefNbr { get; }
                
                public c_grid_row(c_salespertrans_gridsalespertran grid) : 
                        base(grid)
                {
                    SalespersonID = new Selector("_ctl00_phG_tab_t2_gridSalesPerTran_lv0_edSalesPersonID_1", "Salesperson ID", grid.Locator, "SalespersonID");
                    SalespersonID.DataField = "SalespersonID";
                    CommnPct = new PXNumberEdit("_ctl00_phG_tab_t2_gridSalesPerTran_lv0_edCommnPct", "Commission %", grid.Locator, "CommnPct");
                    CommnPct.DataField = "CommnPct";
                    CuryCommnAmt = new PXNumberEdit("_ctl00_phG_tab_t2_gridSalesPerTran_lv0_edCuryCommnAmt", "Commission Amt.", grid.Locator, "CuryCommnAmt");
                    CuryCommnAmt.DataField = "CuryCommnAmt";
                    CuryCommnblAmt = new PXNumberEdit("_ctl00_phG_tab_t2_gridSalesPerTran_lv0_edCuryCommnblAmt", "Commissionable Amount", grid.Locator, "CuryCommnblAmt");
                    CuryCommnblAmt.DataField = "CuryCommnblAmt";
                    DocType = new PXTextEdit("ctl00_phG_tab_t2_gridSalesPerTran_ei", "DocType", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t2_gridSalesPerTran_ei", "RefNbr", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    AdjNbr = new PXNumberEdit("ctl00_phG_tab_t2_gridSalesPerTran_en", "AdjNbr", grid.Locator, "AdjNbr");
                    AdjNbr.DataField = "AdjNbr";
                    AdjdDocType = new PXTextEdit("ctl00_phG_tab_t2_gridSalesPerTran_ei", "AdjdDocType", grid.Locator, "AdjdDocType");
                    AdjdDocType.DataField = "AdjdDocType";
                    AdjdRefNbr = new PXTextEdit("ctl00_phG_tab_t2_gridSalesPerTran_em", "AdjdRefNbr", grid.Locator, "AdjdRefNbr");
                    AdjdRefNbr.DataField = "AdjdRefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SalespersonID { get; }
				public PXNumberEditColumnFilter CommnPct { get; }
				public PXNumberEditColumnFilter CuryCommnAmt { get; }
				public PXNumberEditColumnFilter CuryCommnblAmt { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter AdjNbr { get; }
				public PXTextEditColumnFilter AdjdDocType { get; }
				public PXTextEditColumnFilter AdjdRefNbr { get; }
                
                public c_grid_header(c_salespertrans_gridsalespertran grid) : 
                        base(grid)
                {
                    SalespersonID = new SelectorColumnFilter(grid.Row.SalespersonID);
                    CommnPct = new PXNumberEditColumnFilter(grid.Row.CommnPct);
                    CuryCommnAmt = new PXNumberEditColumnFilter(grid.Row.CuryCommnAmt);
                    CuryCommnblAmt = new PXNumberEditColumnFilter(grid.Row.CuryCommnblAmt);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    AdjNbr = new PXNumberEditColumnFilter(grid.Row.AdjNbr);
                    AdjdDocType = new PXTextEditColumnFilter(grid.Row.AdjdDocType);
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
                CommnPct = new PXNumberEdit("ctl00_phG_tab_t2_gridSalesPerTran_lv0_edCommnPct", "Commission %", locator, null);
                CommnPctLabel = new Label(CommnPct);
                CommnPct.DataField = "CommnPct";
                CommnAmt = new PXNumberEdit("ctl00_phG_tab_t2_gridSalesPerTran_lv0_edCommnAmt", "CommnAmt", locator, null);
                CommnAmtLabel = new Label(CommnAmt);
                CommnAmt.DataField = "CommnAmt";
                CuryCommnAmt = new PXNumberEdit("ctl00_phG_tab_t2_gridSalesPerTran_lv0_edCuryCommnAmt", "Commission Amt.", locator, null);
                CuryCommnAmtLabel = new Label(CuryCommnAmt);
                CuryCommnAmt.DataField = "CuryCommnAmt";
                CommnblAmt = new PXNumberEdit("ctl00_phG_tab_t2_gridSalesPerTran_lv0_edCommnblAmt", "CommnblAmt", locator, null);
                CommnblAmtLabel = new Label(CommnblAmt);
                CommnblAmt.DataField = "CommnblAmt";
                CuryCommnblAmt = new PXNumberEdit("ctl00_phG_tab_t2_gridSalesPerTran_lv0_edCuryCommnblAmt", "Commissionable Amount", locator, null);
                CuryCommnblAmtLabel = new Label(CuryCommnblAmt);
                CuryCommnblAmt.DataField = "CuryCommnblAmt";
                SalespersonID = new Selector("ctl00_phG_tab_t2_gridSalesPerTran_lv0_edSalesPersonID_1", "Salesperson ID", locator, null);
                SalespersonIDLabel = new Label(SalespersonID);
                SalespersonID.DataField = "SalespersonID";
                Es = new Selector("ctl00_phG_tab_t2_gridSalesPerTran_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "SalesPerTrans";
            }
        }
        
        public class c_rrdistribution_griddistribution : Grid<c_rrdistribution_griddistribution.c_grid_row, c_rrdistribution_griddistribution.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public c_rrdistribution_griddistribution(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_RUTROTForm_gridDistribution");
                DataMemberName = "RRDistribution";
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'AdjustColu" +
                            "mns\']", "Fit to Screen", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'PageFirst\'" +
                            "]", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'PagePrev\']" +
                            "", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'PageNext\']" +
                            "", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'PageLast\']" +
                            "", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_RUTROTForm_gridDistribution_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit PersonalID { get; }
			public PXNumberEdit CuryAmount { get; }
			public CheckBox Extra { get; }
			public PXTextEdit DocType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_rrdistribution_griddistribution grid) : 
                        base(grid)
                {
                    PersonalID = new PXTextEdit("_ctl00_phG_tab_t8_RUTROTForm_gridDistribution_lv0_edPersonalID", "Personal ID", grid.Locator, "PersonalID");
                    PersonalID.DataField = "PersonalID";
                    CuryAmount = new PXNumberEdit("_ctl00_phG_tab_t8_RUTROTForm_gridDistribution_lv0_edAmountRR", "Amount", grid.Locator, "CuryAmount");
                    CuryAmount.DataField = "CuryAmount";
                    Extra = new CheckBox("ctl00_phG_tab_t8_RUTROTForm_gridDistribution", "Extra", grid.Locator, "Extra");
                    Extra.DataField = "Extra";
                    DocType = new PXTextEdit("ctl00_phG_tab_t8_RUTROTForm_gridDistribution_ei", "DocType", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t8_RUTROTForm_gridDistribution_ei", "RefNbr", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_gridDistribution_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter PersonalID { get; }
				public PXNumberEditColumnFilter CuryAmount { get; }
				public CheckBoxColumnFilter Extra { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_rrdistribution_griddistribution grid) : 
                        base(grid)
                {
                    PersonalID = new PXTextEditColumnFilter(grid.Row.PersonalID);
                    CuryAmount = new PXNumberEditColumnFilter(grid.Row.CuryAmount);
                    Extra = new CheckBoxColumnFilter(grid.Row.Extra);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_rrdistribution_lv0 : Container
        {
            
			public PXTextEdit PersonalID { get; }
			public Label PersonalIDLabel { get; }
			public PXNumberEdit CuryAmount { get; }
			public Label CuryAmountLabel { get; }
            
            public c_rrdistribution_lv0(string locator, string name) : 
                    base(locator, name)
            {
                PersonalID = new PXTextEdit("ctl00_phG_tab_t8_RUTROTForm_gridDistribution_lv0_edPersonalID", "Personal ID", locator, null);
                PersonalIDLabel = new Label(PersonalID);
                PersonalID.DataField = "PersonalID";
                CuryAmount = new PXNumberEdit("ctl00_phG_tab_t8_RUTROTForm_gridDistribution_lv0_edAmountRR", "Amount", locator, null);
                CuryAmountLabel = new Label(CuryAmount);
                CuryAmount.DataField = "CuryAmount";
                DataMemberName = "RRDistribution";
            }
        }
        
        public class c_duplicatefilter_pxformviewpanelduplicate : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit RefNbr { get; }
			public Label RefNbrLabel { get; }
			public Label LblMessage_ { get; }
            
            public c_duplicatefilter_pxformviewpanelduplicate(string locator, string name) : 
                    base(locator, name)
            {
                RefNbr = new PXTextEdit("ctl00_phG_panelDuplicate_PXFormViewPanelDuplicate_edRefNbr", "Ref Nbr", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                LblMessage_ = new Label("ctl00_phG_panelDuplicate_PXFormViewPanelDuplicate_lblMessage", "Record already exists. Please enter new Reference Nbr.", locator, null);
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
                    Ok = new Button("ctl00_phG_panelDuplicate_PXButtonOK", "OK", "ctl00_phG_panelDuplicate_PXFormViewPanelDuplicate");
                    Cancel = new Button("ctl00_phG_panelDuplicate_PXButtonCancel", "Cancel", "ctl00_phG_panelDuplicate_PXFormViewPanelDuplicate");
                }
            }
        }
        
        public class c_shipmentlist_grid4 : Grid<c_shipmentlist_grid4.c_grid_row, c_shipmentlist_grid4.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_shipmentlist_grid4(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddShipment_grid4");
                DataMemberName = "shipmentlist";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddShipment_grid4_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddShipment_grid4_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddShipment_PXButton1", "Add", "ctl00_phG_PanelAddShipment_grid4");
                    AddClose = new Button("ctl00_phG_PanelAddShipment_PXButton2", "Add & Close", "ctl00_phG_PanelAddShipment_grid4");
                    Cancel = new Button("ctl00_phG_PanelAddShipment_PXButton3", "Cancel", "ctl00_phG_PanelAddShipment_grid4");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public Selector OrderType { get; }
			public Selector OrderNbr { get; }
			public PXTextEdit ShipmentNbr { get; }
			public Selector CustomerID { get; }
			public Selector CustomerLocationID { get; }
			public DateSelector ShipDate { get; }
			public PXNumberEdit ShipmentQty { get; }
			public PXTextEdit ShippingRefNoteID { get; }
                
                public c_grid_row(c_shipmentlist_grid4 grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddShipment_grid4_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderType = new Selector("_ctl00_phG_PanelAddShipment_grid4_lv0_es", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new Selector("_ctl00_phG_PanelAddShipment_grid4_lv0_es", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    ShipmentNbr = new PXTextEdit("ctl00_phG_PanelAddShipment_grid4_ei", "Shipment Nbr.", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    CustomerID = new Selector("_ctl00_phG_PanelAddShipment_grid4_lv0_es", "Customer", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    CustomerLocationID = new Selector("_ctl00_phG_PanelAddShipment_grid4_lv0_es", "Location", grid.Locator, "CustomerLocationID");
                    CustomerLocationID.DataField = "CustomerLocationID";
                    ShipDate = new DateSelector("_ctl00_phG_PanelAddShipment_grid4_lv0_ed6", "Shipment Date", grid.Locator, "ShipDate");
                    ShipDate.DataField = "ShipDate";
                    ShipmentQty = new PXNumberEdit("ctl00_phG_PanelAddShipment_grid4_en", "Shipped Qty.", grid.Locator, "ShipmentQty");
                    ShipmentQty.DataField = "ShipmentQty";
                    ShippingRefNoteID = new PXTextEdit("ctl00_phG_PanelAddShipment_grid4_ei", "ShippingRefNoteID", grid.Locator, "ShippingRefNoteID");
                    ShippingRefNoteID.DataField = "ShippingRefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public PXTextEditColumnFilter ShipmentNbr { get; }
				public SelectorColumnFilter CustomerID { get; }
				public SelectorColumnFilter CustomerLocationID { get; }
				public DateSelectorColumnFilter ShipDate { get; }
				public PXNumberEditColumnFilter ShipmentQty { get; }
				public PXTextEditColumnFilter ShippingRefNoteID { get; }
                
                public c_grid_header(c_shipmentlist_grid4 grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderType = new SelectorColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    ShipmentNbr = new PXTextEditColumnFilter(grid.Row.ShipmentNbr);
                    CustomerID = new SelectorColumnFilter(grid.Row.CustomerID);
                    CustomerLocationID = new SelectorColumnFilter(grid.Row.CustomerLocationID);
                    ShipDate = new DateSelectorColumnFilter(grid.Row.ShipDate);
                    ShipmentQty = new PXNumberEditColumnFilter(grid.Row.ShipmentQty);
                    ShippingRefNoteID = new PXTextEditColumnFilter(grid.Row.ShippingRefNoteID);
                }
            }
        }
        
        public class c_shipmentlist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_shipmentlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddShipment_grid4_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddShipment_grid4_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "shipmentlist";
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
                    Add = new Button("ctl00_phG_PanelAddShipment_PXButton1", "Add", "ctl00_phG_PanelAddShipment_grid4_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddShipment_PXButton2", "Add & Close", "ctl00_phG_PanelAddShipment_grid4_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddShipment_PXButton3", "Cancel", "ctl00_phG_PanelAddShipment_grid4_lv0");
                }
            }
        }
        
        public class c_freightdetails_gridfreightdetails : Grid<c_freightdetails_gridfreightdetails.c_grid_row, c_freightdetails_gridfreightdetails.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_freightdetails_gridfreightdetails(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_gridFreightDetails");
                DataMemberName = "FreightDetails";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_gridFreightDetails_fe_gf", "FilterForm");
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
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
            }
            
            public virtual void ShipmentNbrEdit()
            {
                Buttons.ShipmentNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridFreightDetails_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderNbrEdit { get; }
			public Button ShipmentNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_gridFreightDetails_lv0_edOrderNbr\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "OrderNbrEdit", "ctl00_phG_tab_t3_gridFreightDetails");
                    OrderNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ShipmentNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipmentNbr\'] div[class=\'ed" +
                            "itBtnCont\'] > div > div", "ShipmentNbrEdit", "ctl00_phG_tab_t3_gridFreightDetails");
                    ShipmentNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector OrderType { get; }
			public Selector OrderNbr { get; }
			public Selector ShipmentNbr { get; }
			public DropDown ShipmentType { get; }
			public Selector ShipTermsID { get; }
			public Selector ShipZoneID { get; }
			public Selector ShipVia { get; }
			public PXNumberEdit Weight { get; }
			public PXNumberEdit Volume { get; }
			public PXNumberEdit CuryLineTotal { get; }
			public PXNumberEdit CuryFreightCost { get; }
			public PXNumberEdit CuryFreightAmt { get; }
			public PXNumberEdit CuryPremiumFreightAmt { get; }
			public PXNumberEdit CuryTotalFreightAmt { get; }
			public Selector AccountID { get; }
			public PXTextEdit AccountID_Account_description { get; }
			public Selector SubID { get; }
			public Selector TaskID { get; }
			public Selector TaxCategoryID { get; }
			public PXTextEdit DocType { get; }
			public PXTextEdit RefNbr { get; }
                
                public c_grid_row(c_freightdetails_gridfreightdetails grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    OrderType = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edOrderType", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edOrderNbr", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    ShipmentNbr = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipmentNbr", "Shipment Nbr.", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    ShipmentType = new DropDown("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipmentType", "Shipment Type", grid.Locator, "ShipmentType");
                    ShipmentType.DataField = "ShipmentType";
                    ShipmentType.Items.Add("I", "Shipment");
                    ShipmentType.Items.Add("H", "Drop-Shipment");
                    ShipmentType.Items.Add("T", "Transfer");
                    ShipmentType.Items.Add("N", "Invoice");
                    ShipTermsID = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipTermsID", "Shipping Terms", grid.Locator, "ShipTermsID");
                    ShipTermsID.DataField = "ShipTermsID";
                    ShipZoneID = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipZoneID", "Shipping Zone ID", grid.Locator, "ShipZoneID");
                    ShipZoneID.DataField = "ShipZoneID";
                    ShipVia = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipVia", "Ship Via", grid.Locator, "ShipVia");
                    ShipVia.DataField = "ShipVia";
                    Weight = new PXNumberEdit("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edWeight", "Weight", grid.Locator, "Weight");
                    Weight.DataField = "Weight";
                    Volume = new PXNumberEdit("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edVolume", "Volume", grid.Locator, "Volume");
                    Volume.DataField = "Volume";
                    CuryLineTotal = new PXNumberEdit("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edCuryLineTotal", "Line Total", grid.Locator, "CuryLineTotal");
                    CuryLineTotal.DataField = "CuryLineTotal";
                    CuryFreightCost = new PXNumberEdit("ctl00_phG_tab_t3_gridFreightDetails_en", "Freight Cost", grid.Locator, "CuryFreightCost");
                    CuryFreightCost.DataField = "CuryFreightCost";
                    CuryFreightAmt = new PXNumberEdit("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edCuryFreightAmt", "Freight Price", grid.Locator, "CuryFreightAmt");
                    CuryFreightAmt.DataField = "CuryFreightAmt";
                    CuryPremiumFreightAmt = new PXNumberEdit("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edCuryPremiumFreightAmt", "Premium Freight Price", grid.Locator, "CuryPremiumFreightAmt");
                    CuryPremiumFreightAmt.DataField = "CuryPremiumFreightAmt";
                    CuryTotalFreightAmt = new PXNumberEdit("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edCuryTotalFreightAmt", "Total Freight Price", grid.Locator, "CuryTotalFreightAmt");
                    CuryTotalFreightAmt.DataField = "CuryTotalFreightAmt";
                    AccountID = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edAccountID2", "Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    AccountID_Account_description = new PXTextEdit("ctl00_phG_tab_t3_gridFreightDetails_ei", "Description", grid.Locator, "AccountID_Account_description");
                    AccountID_Account_description.DataField = "AccountID_Account_description";
                    SubID = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edSubID2", "Sub.", grid.Locator, "SubID");
                    SubID.DataField = "SubID";
                    TaskID = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_es", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    TaxCategoryID = new Selector("_ctl00_phG_tab_t3_gridFreightDetails_lv0_edTaxCategoryID2", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    DocType = new PXTextEdit("ctl00_phG_tab_t3_gridFreightDetails_ei", "DocType", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    RefNbr = new PXTextEdit("ctl00_phG_tab_t3_gridFreightDetails_ei", "RefNbr", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public SelectorColumnFilter ShipmentNbr { get; }
				public DropDownColumnFilter ShipmentType { get; }
				public SelectorColumnFilter ShipTermsID { get; }
				public SelectorColumnFilter ShipZoneID { get; }
				public SelectorColumnFilter ShipVia { get; }
				public PXNumberEditColumnFilter Weight { get; }
				public PXNumberEditColumnFilter Volume { get; }
				public PXNumberEditColumnFilter CuryLineTotal { get; }
				public PXNumberEditColumnFilter CuryFreightCost { get; }
				public PXNumberEditColumnFilter CuryFreightAmt { get; }
				public PXNumberEditColumnFilter CuryPremiumFreightAmt { get; }
				public PXNumberEditColumnFilter CuryTotalFreightAmt { get; }
				public SelectorColumnFilter AccountID { get; }
				public PXTextEditColumnFilter AccountID_Account_description { get; }
				public SelectorColumnFilter SubID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter TaxCategoryID { get; }
				public PXTextEditColumnFilter DocType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
                
                public c_grid_header(c_freightdetails_gridfreightdetails grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    OrderType = new SelectorColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    ShipmentNbr = new SelectorColumnFilter(grid.Row.ShipmentNbr);
                    ShipmentType = new DropDownColumnFilter(grid.Row.ShipmentType);
                    ShipTermsID = new SelectorColumnFilter(grid.Row.ShipTermsID);
                    ShipZoneID = new SelectorColumnFilter(grid.Row.ShipZoneID);
                    ShipVia = new SelectorColumnFilter(grid.Row.ShipVia);
                    Weight = new PXNumberEditColumnFilter(grid.Row.Weight);
                    Volume = new PXNumberEditColumnFilter(grid.Row.Volume);
                    CuryLineTotal = new PXNumberEditColumnFilter(grid.Row.CuryLineTotal);
                    CuryFreightCost = new PXNumberEditColumnFilter(grid.Row.CuryFreightCost);
                    CuryFreightAmt = new PXNumberEditColumnFilter(grid.Row.CuryFreightAmt);
                    CuryPremiumFreightAmt = new PXNumberEditColumnFilter(grid.Row.CuryPremiumFreightAmt);
                    CuryTotalFreightAmt = new PXNumberEditColumnFilter(grid.Row.CuryTotalFreightAmt);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    AccountID_Account_description = new PXTextEditColumnFilter(grid.Row.AccountID_Account_description);
                    SubID = new SelectorColumnFilter(grid.Row.SubID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    DocType = new PXTextEditColumnFilter(grid.Row.DocType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                }
            }
        }
        
        public class c_freightdetails_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public Selector ShipmentNbr { get; }
			public Label ShipmentNbrLabel { get; }
			public DropDown ShipmentType { get; }
			public Label ShipmentTypeLabel { get; }
			public Selector ShipTermsID { get; }
			public Label ShipTermsIDLabel { get; }
			public Selector ShipZoneID { get; }
			public Label ShipZoneIDLabel { get; }
			public Selector ShipVia { get; }
			public Label ShipViaLabel { get; }
			public PXNumberEdit Weight { get; }
			public Label WeightLabel { get; }
			public PXNumberEdit Volume { get; }
			public Label VolumeLabel { get; }
			public PXNumberEdit CuryLineTotal { get; }
			public Label CuryLineTotalLabel { get; }
			public PXNumberEdit CuryFreightAmt { get; }
			public Label CuryFreightAmtLabel { get; }
			public PXNumberEdit CuryPremiumFreightAmt { get; }
			public Label CuryPremiumFreightAmtLabel { get; }
			public PXNumberEdit CuryTotalFreightAmt { get; }
			public Label CuryTotalFreightAmtLabel { get; }
			public Selector AccountID { get; }
			public Label AccountIDLabel { get; }
			public Selector SubID { get; }
			public Label SubIDLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_freightdetails_lv0(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edOrderNbr", "Order Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                ShipmentNbr = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipmentNbr", "Shipment Nbr.", locator, null);
                ShipmentNbrLabel = new Label(ShipmentNbr);
                ShipmentNbr.DataField = "ShipmentNbr";
                ShipmentType = new DropDown("ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipmentType", "Shipment Type", locator, null);
                ShipmentTypeLabel = new Label(ShipmentType);
                ShipmentType.DataField = "ShipmentType";
                ShipmentType.Items.Add("I", "Shipment");
                ShipmentType.Items.Add("H", "Drop-Shipment");
                ShipmentType.Items.Add("T", "Transfer");
                ShipmentType.Items.Add("N", "Invoice");
                ShipTermsID = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipTermsID", "Shipping Terms", locator, null);
                ShipTermsIDLabel = new Label(ShipTermsID);
                ShipTermsID.DataField = "ShipTermsID";
                ShipZoneID = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipZoneID", "Shipping Zone ID", locator, null);
                ShipZoneIDLabel = new Label(ShipZoneID);
                ShipZoneID.DataField = "ShipZoneID";
                ShipVia = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipVia", "Ship Via", locator, null);
                ShipViaLabel = new Label(ShipVia);
                ShipVia.DataField = "ShipVia";
                Weight = new PXNumberEdit("ctl00_phG_tab_t3_gridFreightDetails_lv0_edWeight", "Weight", locator, null);
                WeightLabel = new Label(Weight);
                Weight.DataField = "Weight";
                Volume = new PXNumberEdit("ctl00_phG_tab_t3_gridFreightDetails_lv0_edVolume", "Volume", locator, null);
                VolumeLabel = new Label(Volume);
                Volume.DataField = "Volume";
                CuryLineTotal = new PXNumberEdit("ctl00_phG_tab_t3_gridFreightDetails_lv0_edCuryLineTotal", "Line Total", locator, null);
                CuryLineTotalLabel = new Label(CuryLineTotal);
                CuryLineTotal.DataField = "CuryLineTotal";
                CuryFreightAmt = new PXNumberEdit("ctl00_phG_tab_t3_gridFreightDetails_lv0_edCuryFreightAmt", "Freight Price", locator, null);
                CuryFreightAmtLabel = new Label(CuryFreightAmt);
                CuryFreightAmt.DataField = "CuryFreightAmt";
                CuryPremiumFreightAmt = new PXNumberEdit("ctl00_phG_tab_t3_gridFreightDetails_lv0_edCuryPremiumFreightAmt", "Premium Freight Price", locator, null);
                CuryPremiumFreightAmtLabel = new Label(CuryPremiumFreightAmt);
                CuryPremiumFreightAmt.DataField = "CuryPremiumFreightAmt";
                CuryTotalFreightAmt = new PXNumberEdit("ctl00_phG_tab_t3_gridFreightDetails_lv0_edCuryTotalFreightAmt", "Total Freight Price", locator, null);
                CuryTotalFreightAmtLabel = new Label(CuryTotalFreightAmt);
                CuryTotalFreightAmt.DataField = "CuryTotalFreightAmt";
                AccountID = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edAccountID2", "Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                SubID = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edSubID2", "Sub.", locator, null);
                SubIDLabel = new Label(SubID);
                SubID.DataField = "SubID";
                TaxCategoryID = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_edTaxCategoryID2", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                Es = new Selector("ctl00_phG_tab_t3_gridFreightDetails_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "FreightDetails";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
            }
            
            public virtual void ShipmentNbrEdit()
            {
                Buttons.ShipmentNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderNbrEdit { get; }
			public Button ShipmentNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_gridFreightDetails_lv0_edOrderNbr\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "OrderNbrEdit", "ctl00_phG_tab_t3_gridFreightDetails_lv0");
                    OrderNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ShipmentNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_gridFreightDetails_lv0_edShipmentNbr\'] div[class=\'ed" +
                            "itBtnCont\'] > div > div", "ShipmentNbrEdit", "ctl00_phG_tab_t3_gridFreightDetails_lv0");
                    ShipmentNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
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
        
        public class c_relateditemsfilter_fvrelateditemsheader : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public Label CuryUnitPriceLabel { get; }
			public PXTextEdit CuryID { get; }
			public Label CuryIDLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public PXTextEdit UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public Label CuryExtPriceLabel { get; }
			public PXTextEdit CuryID2 { get; }
			public Label CuryID2Label { get; }
			public PXNumberEdit AvailableQty { get; }
			public Label AvailableQtyLabel { get; }
			public PXTextEdit UOM2 { get; }
			public Label UOM2Label { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public CheckBox KeepOriginalPrice { get; }
			public Label KeepOriginalPriceLabel { get; }
			public CheckBox OnlyAvailableItems { get; }
			public Label OnlyAvailableItemsLabel { get; }
			public CheckBox ShowSubstituteItems { get; }
			public Label ShowSubstituteItemsLabel { get; }
			public CheckBox ShowUpSellItems { get; }
			public Label ShowUpSellItemsLabel { get; }
			public CheckBox ShowCrossSellItems { get; }
			public Label ShowCrossSellItemsLabel { get; }
			public CheckBox ShowOtherRelatedItems { get; }
			public Label ShowOtherRelatedItemsLabel { get; }
			public CheckBox ShowAllRelatedItems { get; }
			public Label ShowAllRelatedItemsLabel { get; }
            
            public c_relateditemsfilter_fvrelateditemsheader(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_smOrigInventory", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                CuryUnitPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_neOrigInventoryPrice", "Cury Unit Price", locator, null);
                CuryUnitPriceLabel = new Label(CuryUnitPrice);
                CuryUnitPrice.DataField = "CuryUnitPrice";
                CuryID = new PXTextEdit("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_txtOrigInventoryCurrency", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                Qty = new PXNumberEdit("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_neOrigInventoryQty", "Qty", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                UOM = new PXTextEdit("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_lblOrigInventoryUom", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                CuryExtPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_neOrigInventoryExtPrice", "Cury Ext Price", locator, null);
                CuryExtPriceLabel = new Label(CuryExtPrice);
                CuryExtPrice.DataField = "CuryExtPrice";
                CuryID2 = new PXTextEdit("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_txtOrigInventoryCurrency2", "Cury ID 2", locator, null);
                CuryID2Label = new Label(CuryID2);
                CuryID2.DataField = "CuryID";
                AvailableQty = new PXNumberEdit("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_neOrigInventoryAvailQty", "Available Qty", locator, null);
                AvailableQtyLabel = new Label(AvailableQty);
                AvailableQty.DataField = "AvailableQty";
                UOM2 = new PXTextEdit("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_lblOrigInventoryUom2", "UOM 2", locator, null);
                UOM2Label = new Label(UOM2);
                UOM2.DataField = "UOM";
                SiteID = new Selector("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_smOrigInventotySite", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                KeepOriginalPrice = new CheckBox("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_cbKeepOriginalPrice", "Keep Original Price", locator, null);
                KeepOriginalPriceLabel = new Label(KeepOriginalPrice);
                KeepOriginalPrice.DataField = "KeepOriginalPrice";
                OnlyAvailableItems = new CheckBox("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_cbOnlyAvailableRelatedItems", "Only Available Items", locator, null);
                OnlyAvailableItemsLabel = new Label(OnlyAvailableItems);
                OnlyAvailableItems.DataField = "OnlyAvailableItems";
                ShowSubstituteItems = new CheckBox("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_cbShowSubstituteItems", "Show Substitute Items", locator, null);
                ShowSubstituteItemsLabel = new Label(ShowSubstituteItems);
                ShowSubstituteItems.DataField = "ShowSubstituteItems";
                ShowUpSellItems = new CheckBox("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_cbShowUpSellItems", "Show Up Sell Items", locator, null);
                ShowUpSellItemsLabel = new Label(ShowUpSellItems);
                ShowUpSellItems.DataField = "ShowUpSellItems";
                ShowCrossSellItems = new CheckBox("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_cbShowCrossSellItems", "Show Cross Sell Items", locator, null);
                ShowCrossSellItemsLabel = new Label(ShowCrossSellItems);
                ShowCrossSellItems.DataField = "ShowCrossSellItems";
                ShowOtherRelatedItems = new CheckBox("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_cbShowOtherRelatedItems", "Show Other Related Items", locator, null);
                ShowOtherRelatedItemsLabel = new Label(ShowOtherRelatedItems);
                ShowOtherRelatedItems.DataField = "ShowOtherRelatedItems";
                ShowAllRelatedItems = new CheckBox("ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader_cbShowAllRelatedItems", "Show All Related Items", locator, null);
                ShowAllRelatedItemsLabel = new Label(ShowAllRelatedItems);
                ShowAllRelatedItems.DataField = "ShowAllRelatedItems";
                DataMemberName = "RelatedItemsFilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
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
                
			public Button Unnamed { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phG_spAddRelatedItems_tabRelatedItems_oi", "", "ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader");
                    AddClose = new Button("ctl00_phG_spAddRelatedItems_btnRIOk", "Add & Close", "ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader");
                    Cancel = new Button("ctl00_phG_spAddRelatedItems_btnRICancel", "Cancel", "ctl00_phG_spAddRelatedItems_fvRelatedItemsHeader");
                }
            }
        }
        
        public class c_allrelateditems_gridallrelateditems : Grid<c_allrelateditems_gridallrelateditems.c_grid_row, c_allrelateditems_gridallrelateditems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_allrelateditems_gridallrelateditems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems");
                DataMemberName = "allRelatedItems";
                PredefinedFilter = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                FilterForm = new c_grid_filter("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_fe_gf", "FilterForm");
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
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_at_tlb di" +
                            "v[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_at_tlb di" +
                            "v[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_at_tlb di" +
                            "v[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_at_tlb di" +
                            "v[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_at_tlb di" +
                            "v[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_at_tlb di" +
                            "v[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_at_tlb di" +
                            "v[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ab_tlb di" +
                            "v[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ab_tlb di" +
                            "v[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ab_tlb di" +
                            "v[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ab_tlb di" +
                            "v[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ab_tlb di" +
                            "v[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public PXNumberEdit QtySelected { get; }
			public PXNumberEdit Rank { get; }
			public DropDown Relation { get; }
			public DropDown Tag { get; }
			public Selector RelatedInventoryID { get; }
			public Selector SubItemID { get; }
			public PXTextEdit SubItemCD { get; }
			public PXTextEdit Desc { get; }
			public Selector UOM { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public PXNumberEdit PriceDiff { get; }
			public PXNumberEdit AvailableQty { get; }
			public Selector SiteID { get; }
			public PXTextEdit SiteCD { get; }
			public CheckBox Interchangeable { get; }
			public CheckBox Required { get; }
			public PXNumberEdit InventoryID { get; }
			public PXNumberEdit LineID { get; }
                
                public c_grid_row(c_allrelateditems_gridallrelateditems grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    QtySelected = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_en", "Qty. Selected", grid.Locator, "QtySelected");
                    QtySelected.DataField = "QtySelected";
                    Rank = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_en", "Rank", grid.Locator, "Rank");
                    Rank.DataField = "Rank";
                    Relation = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_ec", "Relation", grid.Locator, "Relation");
                    Relation.DataField = "Relation";
                    Relation.Items.Add("CSELL", "Cross-Sell");
                    Relation.Items.Add("USELL", "Up-Sell");
                    Relation.Items.Add("SUBST", "Substitute");
                    Relation.Items.Add("OTHER", "Other");
                    Tag = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_ec", "Tag", grid.Locator, "Tag");
                    Tag.DataField = "Tag";
                    Tag.Items.Add("COMP", "Complementary Items");
                    Tag.Items.Add("INTS", "Items of Interest");
                    Tag.Items.Add("USER", "Other Users Bought");
                    Tag.Items.Add("ESNT", "Essential Related Products");
                    Tag.Items.Add("SERV", "Services");
                    Tag.Items.Add("PREM", "Premium");
                    Tag.Items.Add("CUST", "Customization");
                    Tag.Items.Add("OPTN", "Options");
                    Tag.Items.Add("PROM", "Promotional");
                    Tag.Items.Add("POPL", "Popular");
                    Tag.Items.Add("SEAS", "Seasonal");
                    Tag.Items.Add("RLTD", "Related");
                    Tag.Items.Add("SUBS", "Substitute");
                    Tag.Items.Add("ALTN", "Alternative");
                    RelatedInventoryID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_es", "Inventory ID", grid.Locator, "RelatedInventoryID");
                    RelatedInventoryID.DataField = "RelatedInventoryID";
                    SubItemID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SubItemCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ei", "SubItemCD", grid.Locator, "SubItemCD");
                    SubItemCD.DataField = "SubItemCD";
                    Desc = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ei", "Description", grid.Locator, "Desc");
                    Desc.DataField = "Desc";
                    UOM = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    CuryUnitPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_en", "Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    CuryExtPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_en", "Ext. Price", grid.Locator, "CuryExtPrice");
                    CuryExtPrice.DataField = "CuryExtPrice";
                    PriceDiff = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_en", "Ext. Price Difference", grid.Locator, "PriceDiff");
                    PriceDiff.DataField = "PriceDiff";
                    AvailableQty = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_en", "Qty. Available", grid.Locator, "AvailableQty");
                    AvailableQty.DataField = "AvailableQty";
                    SiteID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    SiteCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_ei", "SiteCD", grid.Locator, "SiteCD");
                    SiteCD.DataField = "SiteCD";
                    Interchangeable = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems", "Customer Approval Not Needed", grid.Locator, "Interchangeable");
                    Interchangeable.DataField = "Interchangeable";
                    Required = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    InventoryID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LineID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_en", "LineID", grid.Locator, "LineID");
                    LineID.DataField = "LineID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter QtySelected { get; }
				public PXNumberEditColumnFilter Rank { get; }
				public DropDownColumnFilter Relation { get; }
				public DropDownColumnFilter Tag { get; }
				public SelectorColumnFilter RelatedInventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter SubItemCD { get; }
				public PXTextEditColumnFilter Desc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public PXNumberEditColumnFilter PriceDiff { get; }
				public PXNumberEditColumnFilter AvailableQty { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter SiteCD { get; }
				public CheckBoxColumnFilter Interchangeable { get; }
				public CheckBoxColumnFilter Required { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXNumberEditColumnFilter LineID { get; }
                
                public c_grid_header(c_allrelateditems_gridallrelateditems grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    QtySelected = new PXNumberEditColumnFilter(grid.Row.QtySelected);
                    Rank = new PXNumberEditColumnFilter(grid.Row.Rank);
                    Relation = new DropDownColumnFilter(grid.Row.Relation);
                    Tag = new DropDownColumnFilter(grid.Row.Tag);
                    RelatedInventoryID = new SelectorColumnFilter(grid.Row.RelatedInventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SubItemCD = new PXTextEditColumnFilter(grid.Row.SubItemCD);
                    Desc = new PXTextEditColumnFilter(grid.Row.Desc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    PriceDiff = new PXNumberEditColumnFilter(grid.Row.PriceDiff);
                    AvailableQty = new PXNumberEditColumnFilter(grid.Row.AvailableQty);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    SiteCD = new PXTextEditColumnFilter(grid.Row.SiteCD);
                    Interchangeable = new CheckBoxColumnFilter(grid.Row.Interchangeable);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    LineID = new PXNumberEditColumnFilter(grid.Row.LineID);
                }
            }
        }
        
        public class c_allrelateditems_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_allrelateditems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t0_gridAllRelatedItems_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "allRelatedItems";
            }
        }
        
        public class c_substituteitems_gridsubstituteitems : Grid<c_substituteitems_gridsubstituteitems.c_grid_row, c_substituteitems_gridsubstituteitems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_substituteitems_gridsubstituteitems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems");
                DataMemberName = "substituteItems";
                PredefinedFilter = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                FilterForm = new c_grid_filter("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_fe_gf", "FilterForm");
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
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_at_tlb di" +
                            "v[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_at_tlb di" +
                            "v[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_at_tlb di" +
                            "v[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_at_tlb di" +
                            "v[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_at_tlb di" +
                            "v[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_at_tlb di" +
                            "v[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_at_tlb di" +
                            "v[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ab_tlb di" +
                            "v[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ab_tlb di" +
                            "v[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ab_tlb di" +
                            "v[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ab_tlb di" +
                            "v[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ab_tlb di" +
                            "v[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public PXNumberEdit QtySelected { get; }
			public PXNumberEdit Rank { get; }
			public DropDown Relation { get; }
			public DropDown Tag { get; }
			public Selector RelatedInventoryID { get; }
			public Selector SubItemID { get; }
			public PXTextEdit SubItemCD { get; }
			public PXTextEdit Desc { get; }
			public Selector UOM { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public PXNumberEdit PriceDiff { get; }
			public PXNumberEdit AvailableQty { get; }
			public Selector SiteID { get; }
			public PXTextEdit SiteCD { get; }
			public CheckBox Interchangeable { get; }
			public CheckBox Required { get; }
			public PXNumberEdit InventoryID { get; }
			public PXNumberEdit LineID { get; }
                
                public c_grid_row(c_substituteitems_gridsubstituteitems grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    QtySelected = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_en", "Qty. Selected", grid.Locator, "QtySelected");
                    QtySelected.DataField = "QtySelected";
                    Rank = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_en", "Rank", grid.Locator, "Rank");
                    Rank.DataField = "Rank";
                    Relation = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_ec", "Relation", grid.Locator, "Relation");
                    Relation.DataField = "Relation";
                    Relation.Items.Add("CSELL", "Cross-Sell");
                    Relation.Items.Add("USELL", "Up-Sell");
                    Relation.Items.Add("SUBST", "Substitute");
                    Relation.Items.Add("OTHER", "Other");
                    Tag = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_ec", "Tag", grid.Locator, "Tag");
                    Tag.DataField = "Tag";
                    Tag.Items.Add("COMP", "Complementary Items");
                    Tag.Items.Add("INTS", "Items of Interest");
                    Tag.Items.Add("USER", "Other Users Bought");
                    Tag.Items.Add("ESNT", "Essential Related Products");
                    Tag.Items.Add("SERV", "Services");
                    Tag.Items.Add("PREM", "Premium");
                    Tag.Items.Add("CUST", "Customization");
                    Tag.Items.Add("OPTN", "Options");
                    Tag.Items.Add("PROM", "Promotional");
                    Tag.Items.Add("POPL", "Popular");
                    Tag.Items.Add("SEAS", "Seasonal");
                    Tag.Items.Add("RLTD", "Related");
                    Tag.Items.Add("SUBS", "Substitute");
                    Tag.Items.Add("ALTN", "Alternative");
                    RelatedInventoryID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_es", "Inventory ID", grid.Locator, "RelatedInventoryID");
                    RelatedInventoryID.DataField = "RelatedInventoryID";
                    SubItemID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SubItemCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ei", "SubItemCD", grid.Locator, "SubItemCD");
                    SubItemCD.DataField = "SubItemCD";
                    Desc = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ei", "Description", grid.Locator, "Desc");
                    Desc.DataField = "Desc";
                    UOM = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    CuryUnitPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_en", "Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    CuryExtPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_en", "Ext. Price", grid.Locator, "CuryExtPrice");
                    CuryExtPrice.DataField = "CuryExtPrice";
                    PriceDiff = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_en", "Ext. Price Difference", grid.Locator, "PriceDiff");
                    PriceDiff.DataField = "PriceDiff";
                    AvailableQty = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_en", "Qty. Available", grid.Locator, "AvailableQty");
                    AvailableQty.DataField = "AvailableQty";
                    SiteID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    SiteCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_ei", "SiteCD", grid.Locator, "SiteCD");
                    SiteCD.DataField = "SiteCD";
                    Interchangeable = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems", "Customer Approval Not Needed", grid.Locator, "Interchangeable");
                    Interchangeable.DataField = "Interchangeable";
                    Required = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    InventoryID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LineID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_en", "LineID", grid.Locator, "LineID");
                    LineID.DataField = "LineID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter QtySelected { get; }
				public PXNumberEditColumnFilter Rank { get; }
				public DropDownColumnFilter Relation { get; }
				public DropDownColumnFilter Tag { get; }
				public SelectorColumnFilter RelatedInventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter SubItemCD { get; }
				public PXTextEditColumnFilter Desc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public PXNumberEditColumnFilter PriceDiff { get; }
				public PXNumberEditColumnFilter AvailableQty { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter SiteCD { get; }
				public CheckBoxColumnFilter Interchangeable { get; }
				public CheckBoxColumnFilter Required { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXNumberEditColumnFilter LineID { get; }
                
                public c_grid_header(c_substituteitems_gridsubstituteitems grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    QtySelected = new PXNumberEditColumnFilter(grid.Row.QtySelected);
                    Rank = new PXNumberEditColumnFilter(grid.Row.Rank);
                    Relation = new DropDownColumnFilter(grid.Row.Relation);
                    Tag = new DropDownColumnFilter(grid.Row.Tag);
                    RelatedInventoryID = new SelectorColumnFilter(grid.Row.RelatedInventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SubItemCD = new PXTextEditColumnFilter(grid.Row.SubItemCD);
                    Desc = new PXTextEditColumnFilter(grid.Row.Desc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    PriceDiff = new PXNumberEditColumnFilter(grid.Row.PriceDiff);
                    AvailableQty = new PXNumberEditColumnFilter(grid.Row.AvailableQty);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    SiteCD = new PXTextEditColumnFilter(grid.Row.SiteCD);
                    Interchangeable = new CheckBoxColumnFilter(grid.Row.Interchangeable);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    LineID = new PXNumberEditColumnFilter(grid.Row.LineID);
                }
            }
        }
        
        public class c_substituteitems_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_substituteitems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t1_gridSubstituteItems_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "substituteItems";
            }
        }
        
        public class c_upsellitems_gridupsellitems : Grid<c_upsellitems_gridupsellitems.c_grid_row, c_upsellitems_gridupsellitems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_upsellitems_gridupsellitems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems");
                DataMemberName = "upSellItems";
                PredefinedFilter = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                FilterForm = new c_grid_filter("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_fe_gf", "FilterForm");
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
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_at_tlb div[da" +
                            "ta-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_at_tlb div[da" +
                            "ta-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_at_tlb div[da" +
                            "ta-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_at_tlb div[da" +
                            "ta-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_at_tlb div[da" +
                            "ta-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_at_tlb div[da" +
                            "ta-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_at_tlb div[da" +
                            "ta-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ab_tlb div[da" +
                            "ta-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ab_tlb div[da" +
                            "ta-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ab_tlb div[da" +
                            "ta-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ab_tlb div[da" +
                            "ta-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ab_tlb div[da" +
                            "ta-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public PXNumberEdit QtySelected { get; }
			public PXNumberEdit Rank { get; }
			public DropDown Relation { get; }
			public DropDown Tag { get; }
			public Selector RelatedInventoryID { get; }
			public Selector SubItemID { get; }
			public PXTextEdit SubItemCD { get; }
			public PXTextEdit Desc { get; }
			public Selector UOM { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public PXNumberEdit PriceDiff { get; }
			public PXNumberEdit AvailableQty { get; }
			public Selector SiteID { get; }
			public PXTextEdit SiteCD { get; }
			public CheckBox Interchangeable { get; }
			public CheckBox Required { get; }
			public PXNumberEdit InventoryID { get; }
			public PXNumberEdit LineID { get; }
                
                public c_grid_row(c_upsellitems_gridupsellitems grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    QtySelected = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_en", "Qty. Selected", grid.Locator, "QtySelected");
                    QtySelected.DataField = "QtySelected";
                    Rank = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_en", "Rank", grid.Locator, "Rank");
                    Rank.DataField = "Rank";
                    Relation = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_ec", "Relation", grid.Locator, "Relation");
                    Relation.DataField = "Relation";
                    Relation.Items.Add("CSELL", "Cross-Sell");
                    Relation.Items.Add("USELL", "Up-Sell");
                    Relation.Items.Add("SUBST", "Substitute");
                    Relation.Items.Add("OTHER", "Other");
                    Tag = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_ec", "Tag", grid.Locator, "Tag");
                    Tag.DataField = "Tag";
                    Tag.Items.Add("COMP", "Complementary Items");
                    Tag.Items.Add("INTS", "Items of Interest");
                    Tag.Items.Add("USER", "Other Users Bought");
                    Tag.Items.Add("ESNT", "Essential Related Products");
                    Tag.Items.Add("SERV", "Services");
                    Tag.Items.Add("PREM", "Premium");
                    Tag.Items.Add("CUST", "Customization");
                    Tag.Items.Add("OPTN", "Options");
                    Tag.Items.Add("PROM", "Promotional");
                    Tag.Items.Add("POPL", "Popular");
                    Tag.Items.Add("SEAS", "Seasonal");
                    Tag.Items.Add("RLTD", "Related");
                    Tag.Items.Add("SUBS", "Substitute");
                    Tag.Items.Add("ALTN", "Alternative");
                    RelatedInventoryID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_es", "Inventory ID", grid.Locator, "RelatedInventoryID");
                    RelatedInventoryID.DataField = "RelatedInventoryID";
                    SubItemID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SubItemCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ei", "SubItemCD", grid.Locator, "SubItemCD");
                    SubItemCD.DataField = "SubItemCD";
                    Desc = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ei", "Description", grid.Locator, "Desc");
                    Desc.DataField = "Desc";
                    UOM = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    CuryUnitPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_en", "Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    CuryExtPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_en", "Ext. Price", grid.Locator, "CuryExtPrice");
                    CuryExtPrice.DataField = "CuryExtPrice";
                    PriceDiff = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_en", "Ext. Price Difference", grid.Locator, "PriceDiff");
                    PriceDiff.DataField = "PriceDiff";
                    AvailableQty = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_en", "Qty. Available", grid.Locator, "AvailableQty");
                    AvailableQty.DataField = "AvailableQty";
                    SiteID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    SiteCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_ei", "SiteCD", grid.Locator, "SiteCD");
                    SiteCD.DataField = "SiteCD";
                    Interchangeable = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems", "Customer Approval Not Needed", grid.Locator, "Interchangeable");
                    Interchangeable.DataField = "Interchangeable";
                    Required = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    InventoryID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LineID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_en", "LineID", grid.Locator, "LineID");
                    LineID.DataField = "LineID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter QtySelected { get; }
				public PXNumberEditColumnFilter Rank { get; }
				public DropDownColumnFilter Relation { get; }
				public DropDownColumnFilter Tag { get; }
				public SelectorColumnFilter RelatedInventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter SubItemCD { get; }
				public PXTextEditColumnFilter Desc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public PXNumberEditColumnFilter PriceDiff { get; }
				public PXNumberEditColumnFilter AvailableQty { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter SiteCD { get; }
				public CheckBoxColumnFilter Interchangeable { get; }
				public CheckBoxColumnFilter Required { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXNumberEditColumnFilter LineID { get; }
                
                public c_grid_header(c_upsellitems_gridupsellitems grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    QtySelected = new PXNumberEditColumnFilter(grid.Row.QtySelected);
                    Rank = new PXNumberEditColumnFilter(grid.Row.Rank);
                    Relation = new DropDownColumnFilter(grid.Row.Relation);
                    Tag = new DropDownColumnFilter(grid.Row.Tag);
                    RelatedInventoryID = new SelectorColumnFilter(grid.Row.RelatedInventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SubItemCD = new PXTextEditColumnFilter(grid.Row.SubItemCD);
                    Desc = new PXTextEditColumnFilter(grid.Row.Desc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    PriceDiff = new PXNumberEditColumnFilter(grid.Row.PriceDiff);
                    AvailableQty = new PXNumberEditColumnFilter(grid.Row.AvailableQty);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    SiteCD = new PXTextEditColumnFilter(grid.Row.SiteCD);
                    Interchangeable = new CheckBoxColumnFilter(grid.Row.Interchangeable);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    LineID = new PXNumberEditColumnFilter(grid.Row.LineID);
                }
            }
        }
        
        public class c_upsellitems_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_upsellitems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t2_gridUpSellItems_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "upSellItems";
            }
        }
        
        public class c_crosssellitems_gridcrosssellitems : Grid<c_crosssellitems_gridcrosssellitems.c_grid_row, c_crosssellitems_gridcrosssellitems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_crosssellitems_gridcrosssellitems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems");
                DataMemberName = "crossSellItems";
                PredefinedFilter = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                FilterForm = new c_grid_filter("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_fe_gf", "FilterForm");
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
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_at_tlb div" +
                            "[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_at_tlb div" +
                            "[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_at_tlb div" +
                            "[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_at_tlb div" +
                            "[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_at_tlb div" +
                            "[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_at_tlb div" +
                            "[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_at_tlb div" +
                            "[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ab_tlb div" +
                            "[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ab_tlb div" +
                            "[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ab_tlb div" +
                            "[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ab_tlb div" +
                            "[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ab_tlb div" +
                            "[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public PXNumberEdit QtySelected { get; }
			public PXNumberEdit Rank { get; }
			public DropDown Relation { get; }
			public DropDown Tag { get; }
			public Selector RelatedInventoryID { get; }
			public Selector SubItemID { get; }
			public PXTextEdit SubItemCD { get; }
			public PXTextEdit Desc { get; }
			public Selector UOM { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public PXNumberEdit AvailableQty { get; }
			public Selector SiteID { get; }
			public PXTextEdit SiteCD { get; }
			public CheckBox Interchangeable { get; }
			public CheckBox Required { get; }
			public PXNumberEdit InventoryID { get; }
			public PXNumberEdit LineID { get; }
                
                public c_grid_row(c_crosssellitems_gridcrosssellitems grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    QtySelected = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_en", "Qty. Selected", grid.Locator, "QtySelected");
                    QtySelected.DataField = "QtySelected";
                    Rank = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_en", "Rank", grid.Locator, "Rank");
                    Rank.DataField = "Rank";
                    Relation = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_ec", "Relation", grid.Locator, "Relation");
                    Relation.DataField = "Relation";
                    Relation.Items.Add("CSELL", "Cross-Sell");
                    Relation.Items.Add("USELL", "Up-Sell");
                    Relation.Items.Add("SUBST", "Substitute");
                    Relation.Items.Add("OTHER", "Other");
                    Tag = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_ec", "Tag", grid.Locator, "Tag");
                    Tag.DataField = "Tag";
                    Tag.Items.Add("COMP", "Complementary Items");
                    Tag.Items.Add("INTS", "Items of Interest");
                    Tag.Items.Add("USER", "Other Users Bought");
                    Tag.Items.Add("ESNT", "Essential Related Products");
                    Tag.Items.Add("SERV", "Services");
                    Tag.Items.Add("PREM", "Premium");
                    Tag.Items.Add("CUST", "Customization");
                    Tag.Items.Add("OPTN", "Options");
                    Tag.Items.Add("PROM", "Promotional");
                    Tag.Items.Add("POPL", "Popular");
                    Tag.Items.Add("SEAS", "Seasonal");
                    Tag.Items.Add("RLTD", "Related");
                    Tag.Items.Add("SUBS", "Substitute");
                    Tag.Items.Add("ALTN", "Alternative");
                    RelatedInventoryID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_es", "Inventory ID", grid.Locator, "RelatedInventoryID");
                    RelatedInventoryID.DataField = "RelatedInventoryID";
                    SubItemID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SubItemCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ei", "SubItemCD", grid.Locator, "SubItemCD");
                    SubItemCD.DataField = "SubItemCD";
                    Desc = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ei", "Description", grid.Locator, "Desc");
                    Desc.DataField = "Desc";
                    UOM = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    CuryUnitPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_en", "Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    CuryExtPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_en", "Ext. Price", grid.Locator, "CuryExtPrice");
                    CuryExtPrice.DataField = "CuryExtPrice";
                    AvailableQty = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_en", "Qty. Available", grid.Locator, "AvailableQty");
                    AvailableQty.DataField = "AvailableQty";
                    SiteID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    SiteCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_ei", "SiteCD", grid.Locator, "SiteCD");
                    SiteCD.DataField = "SiteCD";
                    Interchangeable = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems", "Customer Approval Not Needed", grid.Locator, "Interchangeable");
                    Interchangeable.DataField = "Interchangeable";
                    Required = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    InventoryID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LineID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_en", "LineID", grid.Locator, "LineID");
                    LineID.DataField = "LineID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter QtySelected { get; }
				public PXNumberEditColumnFilter Rank { get; }
				public DropDownColumnFilter Relation { get; }
				public DropDownColumnFilter Tag { get; }
				public SelectorColumnFilter RelatedInventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter SubItemCD { get; }
				public PXTextEditColumnFilter Desc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public PXNumberEditColumnFilter AvailableQty { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter SiteCD { get; }
				public CheckBoxColumnFilter Interchangeable { get; }
				public CheckBoxColumnFilter Required { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXNumberEditColumnFilter LineID { get; }
                
                public c_grid_header(c_crosssellitems_gridcrosssellitems grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    QtySelected = new PXNumberEditColumnFilter(grid.Row.QtySelected);
                    Rank = new PXNumberEditColumnFilter(grid.Row.Rank);
                    Relation = new DropDownColumnFilter(grid.Row.Relation);
                    Tag = new DropDownColumnFilter(grid.Row.Tag);
                    RelatedInventoryID = new SelectorColumnFilter(grid.Row.RelatedInventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SubItemCD = new PXTextEditColumnFilter(grid.Row.SubItemCD);
                    Desc = new PXTextEditColumnFilter(grid.Row.Desc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    AvailableQty = new PXNumberEditColumnFilter(grid.Row.AvailableQty);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    SiteCD = new PXTextEditColumnFilter(grid.Row.SiteCD);
                    Interchangeable = new CheckBoxColumnFilter(grid.Row.Interchangeable);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    LineID = new PXNumberEditColumnFilter(grid.Row.LineID);
                }
            }
        }
        
        public class c_crosssellitems_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_crosssellitems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t3_gridCrossSellItems_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "crossSellItems";
            }
        }
        
        public class c_otherrelateditems_gridotherrelateditems : Grid<c_otherrelateditems_gridotherrelateditems.c_grid_row, c_otherrelateditems_gridotherrelateditems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_otherrelateditems_gridotherrelateditems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems");
                DataMemberName = "otherRelatedItems";
                PredefinedFilter = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                FilterForm = new c_grid_filter("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_fe_gf", "FilterForm");
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
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_at_tlb " +
                            "div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_at_tlb " +
                            "div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_at_tlb " +
                            "div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_at_tlb " +
                            "div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_at_tlb " +
                            "div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_at_tlb " +
                            "div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_at_tlb " +
                            "div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ab_tlb " +
                            "div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ab_tlb " +
                            "div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ab_tlb " +
                            "div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ab_tlb " +
                            "div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ab_tlb " +
                            "div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public PXNumberEdit QtySelected { get; }
			public PXNumberEdit Rank { get; }
			public DropDown Relation { get; }
			public DropDown Tag { get; }
			public Selector RelatedInventoryID { get; }
			public Selector SubItemID { get; }
			public PXTextEdit SubItemCD { get; }
			public PXTextEdit Desc { get; }
			public Selector UOM { get; }
			public PXNumberEdit CuryUnitPrice { get; }
			public PXNumberEdit CuryExtPrice { get; }
			public PXNumberEdit PriceDiff { get; }
			public PXNumberEdit AvailableQty { get; }
			public Selector SiteID { get; }
			public PXTextEdit SiteCD { get; }
			public CheckBox Interchangeable { get; }
			public CheckBox Required { get; }
			public PXNumberEdit InventoryID { get; }
			public PXNumberEdit LineID { get; }
                
                public c_grid_row(c_otherrelateditems_gridotherrelateditems grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    QtySelected = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_en", "Qty. Selected", grid.Locator, "QtySelected");
                    QtySelected.DataField = "QtySelected";
                    Rank = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_en", "Rank", grid.Locator, "Rank");
                    Rank.DataField = "Rank";
                    Relation = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_ec", "Relation", grid.Locator, "Relation");
                    Relation.DataField = "Relation";
                    Relation.Items.Add("CSELL", "Cross-Sell");
                    Relation.Items.Add("USELL", "Up-Sell");
                    Relation.Items.Add("SUBST", "Substitute");
                    Relation.Items.Add("OTHER", "Other");
                    Tag = new DropDown("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_ec", "Tag", grid.Locator, "Tag");
                    Tag.DataField = "Tag";
                    Tag.Items.Add("COMP", "Complementary Items");
                    Tag.Items.Add("INTS", "Items of Interest");
                    Tag.Items.Add("USER", "Other Users Bought");
                    Tag.Items.Add("ESNT", "Essential Related Products");
                    Tag.Items.Add("SERV", "Services");
                    Tag.Items.Add("PREM", "Premium");
                    Tag.Items.Add("CUST", "Customization");
                    Tag.Items.Add("OPTN", "Options");
                    Tag.Items.Add("PROM", "Promotional");
                    Tag.Items.Add("POPL", "Popular");
                    Tag.Items.Add("SEAS", "Seasonal");
                    Tag.Items.Add("RLTD", "Related");
                    Tag.Items.Add("SUBS", "Substitute");
                    Tag.Items.Add("ALTN", "Alternative");
                    RelatedInventoryID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_es", "Inventory ID", grid.Locator, "RelatedInventoryID");
                    RelatedInventoryID.DataField = "RelatedInventoryID";
                    SubItemID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SubItemCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ei", "SubItemCD", grid.Locator, "SubItemCD");
                    SubItemCD.DataField = "SubItemCD";
                    Desc = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ei", "Description", grid.Locator, "Desc");
                    Desc.DataField = "Desc";
                    UOM = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    CuryUnitPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_en", "Unit Price", grid.Locator, "CuryUnitPrice");
                    CuryUnitPrice.DataField = "CuryUnitPrice";
                    CuryExtPrice = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_en", "Ext. Price", grid.Locator, "CuryExtPrice");
                    CuryExtPrice.DataField = "CuryExtPrice";
                    PriceDiff = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_en", "Ext. Price Difference", grid.Locator, "PriceDiff");
                    PriceDiff.DataField = "PriceDiff";
                    AvailableQty = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_en", "Qty. Available", grid.Locator, "AvailableQty");
                    AvailableQty.DataField = "AvailableQty";
                    SiteID = new Selector("_ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    SiteCD = new PXTextEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_ei", "SiteCD", grid.Locator, "SiteCD");
                    SiteCD.DataField = "SiteCD";
                    Interchangeable = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems", "Customer Approval Not Needed", grid.Locator, "Interchangeable");
                    Interchangeable.DataField = "Interchangeable";
                    Required = new CheckBox("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    InventoryID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LineID = new PXNumberEdit("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_en", "LineID", grid.Locator, "LineID");
                    LineID.DataField = "LineID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter QtySelected { get; }
				public PXNumberEditColumnFilter Rank { get; }
				public DropDownColumnFilter Relation { get; }
				public DropDownColumnFilter Tag { get; }
				public SelectorColumnFilter RelatedInventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter SubItemCD { get; }
				public PXTextEditColumnFilter Desc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter CuryUnitPrice { get; }
				public PXNumberEditColumnFilter CuryExtPrice { get; }
				public PXNumberEditColumnFilter PriceDiff { get; }
				public PXNumberEditColumnFilter AvailableQty { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXTextEditColumnFilter SiteCD { get; }
				public CheckBoxColumnFilter Interchangeable { get; }
				public CheckBoxColumnFilter Required { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXNumberEditColumnFilter LineID { get; }
                
                public c_grid_header(c_otherrelateditems_gridotherrelateditems grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    QtySelected = new PXNumberEditColumnFilter(grid.Row.QtySelected);
                    Rank = new PXNumberEditColumnFilter(grid.Row.Rank);
                    Relation = new DropDownColumnFilter(grid.Row.Relation);
                    Tag = new DropDownColumnFilter(grid.Row.Tag);
                    RelatedInventoryID = new SelectorColumnFilter(grid.Row.RelatedInventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SubItemCD = new PXTextEditColumnFilter(grid.Row.SubItemCD);
                    Desc = new PXTextEditColumnFilter(grid.Row.Desc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    CuryUnitPrice = new PXNumberEditColumnFilter(grid.Row.CuryUnitPrice);
                    CuryExtPrice = new PXNumberEditColumnFilter(grid.Row.CuryExtPrice);
                    PriceDiff = new PXNumberEditColumnFilter(grid.Row.PriceDiff);
                    AvailableQty = new PXNumberEditColumnFilter(grid.Row.AvailableQty);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    SiteCD = new PXTextEditColumnFilter(grid.Row.SiteCD);
                    Interchangeable = new CheckBoxColumnFilter(grid.Row.Interchangeable);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    LineID = new PXNumberEditColumnFilter(grid.Row.LineID);
                }
            }
        }
        
        public class c_otherrelateditems_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_otherrelateditems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_spAddRelatedItems_tabRelatedItems_t4_gridOtherRelatedItems_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "otherRelatedItems";
            }
        }
        
        public class c_artranlist_gridartranlist : Grid<c_artranlist_gridartranlist.c_grid_row, c_artranlist_gridartranlist.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_artranlist_gridartranlist(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddARTran_gridARTranList");
                DataMemberName = "arTranList";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddARTran_gridARTranList_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_at_tlb div[data-cmd=\'AdjustColumns\']" +
                            "", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddARTran_gridARTranList_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddARTran_PXButton40", "Add", "ctl00_phG_PanelAddARTran_gridARTranList");
                    AddClose = new Button("ctl00_phG_PanelAddARTran_PXButton50", "Add & Close", "ctl00_phG_PanelAddARTran_gridARTranList");
                    Cancel = new Button("ctl00_phG_PanelAddARTran_PXButton60", "Cancel", "ctl00_phG_PanelAddARTran_gridARTranList");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public DropDown TranType { get; }
			public PXTextEdit RefNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public Selector CustomerID { get; }
			public DateSelector TranDate { get; }
			public Selector InventoryID { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public PXTextEdit FSARTran__RelatedDocument { get; }
                
                public c_grid_row(c_artranlist_gridartranlist grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddARTran_gridARTranList_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    TranType = new DropDown("_ctl00_phG_PanelAddARTran_gridARTranList_lv0_ec", "Doc. Type", grid.Locator, "TranType");
                    TranType.DataField = "TranType";
                    TranType.Items.Add("INV", "Invoice");
                    TranType.Items.Add("DRM", "Debit Memo");
                    TranType.Items.Add("CRM", "Credit Memo");
                    TranType.Items.Add("PMT", "Payment");
                    TranType.Items.Add("RPM", "Voided Payment");
                    TranType.Items.Add("PPM", "Prepayment");
                    TranType.Items.Add("REF", "Customer Refund");
                    TranType.Items.Add("VRF", "Voided Refund");
                    TranType.Items.Add("FCH", "Overdue Charge");
                    TranType.Items.Add("SMB", "Balance WO");
                    TranType.Items.Add("SMC", "Credit WO");
                    TranType.Items.Add("CSL", "Cash Sale");
                    TranType.Items.Add("RCS", "Cash Return");
                    RefNbr = new PXTextEdit("ctl00_phG_PanelAddARTran_gridARTranList_ei", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelAddARTran_gridARTranList_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    CustomerID = new Selector("_ctl00_phG_PanelAddARTran_gridARTranList_lv0_es", "Customer", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    TranDate = new DateSelector("_ctl00_phG_PanelAddARTran_gridARTranList_lv0_ed5", "Doc. Date", grid.Locator, "TranDate");
                    TranDate.DataField = "TranDate";
                    InventoryID = new Selector("_ctl00_phG_PanelAddARTran_gridARTranList_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    UOM = new Selector("_ctl00_phG_PanelAddARTran_gridARTranList_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("ctl00_phG_PanelAddARTran_gridARTranList_en", "Qty", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    FSARTran__RelatedDocument = new PXTextEdit("ctl00_phG_PanelAddARTran_gridARTranList", "Related Svc. Doc. Nbr.", grid.Locator, "FSARTran__RelatedDocument");
                    FSARTran__RelatedDocument.DataField = "FSARTran__RelatedDocument";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter TranType { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public SelectorColumnFilter CustomerID { get; }
				public DateSelectorColumnFilter TranDate { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXTextEditColumnFilter FSARTran__RelatedDocument { get; }
                
                public c_grid_header(c_artranlist_gridartranlist grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    TranType = new DropDownColumnFilter(grid.Row.TranType);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    CustomerID = new SelectorColumnFilter(grid.Row.CustomerID);
                    TranDate = new DateSelectorColumnFilter(grid.Row.TranDate);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    FSARTran__RelatedDocument = new PXTextEditColumnFilter(grid.Row.FSARTran__RelatedDocument);
                }
            }
        }
        
        public class c_artranlist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_artranlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddARTran_gridARTranList_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddARTran_gridARTranList_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelAddARTran_gridARTranList_lv0_ec", "Ec", locator, null);
                DataMemberName = "arTranList";
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
                    Add = new Button("ctl00_phG_PanelAddARTran_PXButton40", "Add", "ctl00_phG_PanelAddARTran_gridARTranList_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddARTran_PXButton50", "Add & Close", "ctl00_phG_PanelAddARTran_gridARTranList_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddARTran_PXButton60", "Cancel", "ctl00_phG_PanelAddARTran_gridARTranList_lv0");
                }
            }
        }
        
        public class c_solinelist_gridsolinelist : Grid<c_solinelist_gridsolinelist.c_grid_row, c_solinelist_gridsolinelist.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_solinelist_gridsolinelist(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddSOLine_gridSOLineList");
                DataMemberName = "soLineList";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddSOLine_gridSOLineList_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_at_tlb div[data-cmd=\'AdjustColumns\']" +
                            "", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSOLine_gridSOLineList_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddSOLine_PXButton4", "Add", "ctl00_phG_PanelAddSOLine_gridSOLineList");
                    AddClose = new Button("ctl00_phG_PanelAddSOLine_PXButton5", "Add & Close", "ctl00_phG_PanelAddSOLine_gridSOLineList");
                    Cancel = new Button("ctl00_phG_PanelAddSOLine_PXButton6", "Cancel", "ctl00_phG_PanelAddSOLine_gridSOLineList");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public Selector OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public Selector CustomerID { get; }
			public DropDown Operation { get; }
			public DateSelector ShipDate { get; }
			public Selector InventoryID { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit ShippedQty { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_solinelist_gridsolinelist grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddSOLine_gridSOLineList_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderType = new Selector("_ctl00_phG_PanelAddSOLine_gridSOLineList_lv0_es", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_PanelAddSOLine_gridSOLineList_ei", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    CustomerID = new Selector("_ctl00_phG_PanelAddSOLine_gridSOLineList_lv0_es", "Customer", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    Operation = new DropDown("_ctl00_phG_PanelAddSOLine_gridSOLineList_lv0_ec", "Operation", grid.Locator, "Operation");
                    Operation.DataField = "Operation";
                    Operation.Items.Add("I", "Issue");
                    Operation.Items.Add("R", "Receipt");
                    ShipDate = new DateSelector("_ctl00_phG_PanelAddSOLine_gridSOLineList_lv0_ed5", "Ship On", grid.Locator, "ShipDate");
                    ShipDate.DataField = "ShipDate";
                    InventoryID = new Selector("_ctl00_phG_PanelAddSOLine_gridSOLineList_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    OrderQty = new PXNumberEdit("ctl00_phG_PanelAddSOLine_gridSOLineList_en", "Order Qty.", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    ShippedQty = new PXNumberEdit("ctl00_phG_PanelAddSOLine_gridSOLineList_en", "Qty. on Shipments", grid.Locator, "ShippedQty");
                    ShippedQty.DataField = "ShippedQty";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelAddSOLine_gridSOLineList_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public SelectorColumnFilter CustomerID { get; }
				public DropDownColumnFilter Operation { get; }
				public DateSelectorColumnFilter ShipDate { get; }
				public SelectorColumnFilter InventoryID { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter ShippedQty { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_solinelist_gridsolinelist grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderType = new SelectorColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    CustomerID = new SelectorColumnFilter(grid.Row.CustomerID);
                    Operation = new DropDownColumnFilter(grid.Row.Operation);
                    ShipDate = new DateSelectorColumnFilter(grid.Row.ShipDate);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    ShippedQty = new PXNumberEditColumnFilter(grid.Row.ShippedQty);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_solinelist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_solinelist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddSOLine_gridSOLineList_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddSOLine_gridSOLineList_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelAddSOLine_gridSOLineList_lv0_ec", "Ec", locator, null);
                DataMemberName = "soLineList";
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
                    Add = new Button("ctl00_phG_PanelAddSOLine_PXButton4", "Add", "ctl00_phG_PanelAddSOLine_gridSOLineList_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddSOLine_PXButton5", "Add & Close", "ctl00_phG_PanelAddSOLine_gridSOLineList_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddSOLine_PXButton6", "Cancel", "ctl00_phG_PanelAddSOLine_gridSOLineList_lv0");
                }
            }
        }
        
        public class c_quickpayment_createpaymentformview : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit CuryOrigDocAmt { get; }
			public Label CuryOrigDocAmtLabel { get; }
			public PXNumberEdit CuryRefundAmt { get; }
			public Label CuryRefundAmtLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public PXTextEdit DocDesc { get; }
			public Label DocDescLabel { get; }
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public Selector RefTranExtNbr { get; }
			public Label RefTranExtNbrLabel { get; }
			public CheckBox NewCard { get; }
			public Label NewCardLabel { get; }
			public CheckBox SaveCard { get; }
			public Label SaveCardLabel { get; }
			public Selector PMInstanceID { get; }
			public Label PMInstanceIDLabel { get; }
			public Selector CashAccountID { get; }
			public Label CashAccountIDLabel { get; }
			public Selector ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
			public PXTextEdit ExtRefNbr { get; }
			public Label ExtRefNbrLabel { get; }
            
            public c_quickpayment_createpaymentformview(string locator, string name) : 
                    base(locator, name)
            {
                CuryOrigDocAmt = new PXNumberEdit("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edCuryOrigDocAmt", "Cury Orig Doc Amt", locator, null);
                CuryOrigDocAmtLabel = new Label(CuryOrigDocAmt);
                CuryOrigDocAmt.DataField = "CuryOrigDocAmt";
                CuryRefundAmt = new PXNumberEdit("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edCuryRefundAmt", "Cury Refund Amt", locator, null);
                CuryRefundAmtLabel = new Label(CuryRefundAmt);
                CuryRefundAmt.DataField = "CuryRefundAmt";
                CuryID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edCuryID", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                DocDesc = new PXTextEdit("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edDocDesc", "Doc Desc", locator, null);
                DocDescLabel = new Label(DocDesc);
                DocDesc.DataField = "DocDesc";
                PaymentMethodID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_selPaymentMethodID", "Payment Method ID", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                RefTranExtNbr = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_selRefTranExtNbr", "Ref Tran Ext Nbr", locator, null);
                RefTranExtNbrLabel = new Label(RefTranExtNbr);
                RefTranExtNbr.DataField = "RefTranExtNbr";
                NewCard = new CheckBox("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_chkNewCard", "New Card", locator, null);
                NewCardLabel = new Label(NewCard);
                NewCard.DataField = "NewCard";
                SaveCard = new CheckBox("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_chkSaveCard", "Save Card", locator, null);
                SaveCardLabel = new Label(SaveCard);
                SaveCard.DataField = "SaveCard";
                PMInstanceID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edPMInstanceID", "PM Instance ID", locator, null);
                PMInstanceIDLabel = new Label(PMInstanceID);
                PMInstanceID.DataField = "PMInstanceID";
                CashAccountID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edCashAccountID", "Cash Account ID", locator, null);
                CashAccountIDLabel = new Label(CashAccountID);
                CashAccountID.DataField = "CashAccountID";
                ProcessingCenterID = new Selector("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edProcessingCenterID", "Processing Center ID", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                ExtRefNbr = new PXTextEdit("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView_edExtRefNbr", "Ext Ref Nbr", locator, null);
                ExtRefNbrLabel = new Label(ExtRefNbr);
                ExtRefNbr.DataField = "ExtRefNbr";
                DataMemberName = "QuickPayment";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CreatePaymentRefundButton()
            {
                Buttons.CreatePaymentRefundButton.Click();
            }
            
            public virtual void CreatePaymentCaptureButton()
            {
                Buttons.CreatePaymentCaptureButton.Click();
            }
            
            public virtual void CreatePaymentAuthorizeButton()
            {
                Buttons.CreatePaymentAuthorizeButton.Click();
            }
            
            public virtual void CreatePaymentOKButton()
            {
                Buttons.CreatePaymentOKButton.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CreatePaymentRefundButton { get; }
			public Button CreatePaymentCaptureButton { get; }
			public Button CreatePaymentAuthorizeButton { get; }
			public Button CreatePaymentOKButton { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    CreatePaymentRefundButton = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentRefundButton", "CreatePaymentRefundButton", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                    CreatePaymentCaptureButton = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentCaptureButton", "CreatePaymentCaptureButton", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                    CreatePaymentAuthorizeButton = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentAuthorizeButton", "CreatePaymentAuthorizeButton", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                    CreatePaymentOKButton = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentOKButton", "CreatePaymentOKButton", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                    Cancel = new Button("ctl00_phG_CreatePaymentSmartPanel_CreatePaymentCancelButton", "Cancel", "ctl00_phG_CreatePaymentSmartPanel_CreatePaymentFormView");
                }
            }
        }
        
        public class c_importexternaltran_importpaymentformview : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit TranNumber { get; }
			public Label TranNumberLabel { get; }
			public Selector ProcessingCenterID { get; }
			public Label ProcessingCenterIDLabel { get; }
            
            public c_importexternaltran_importpaymentformview(string locator, string name) : 
                    base(locator, name)
            {
                TranNumber = new PXTextEdit("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView_edTranNumber", "Tran Number", locator, null);
                TranNumberLabel = new Label(TranNumber);
                TranNumber.DataField = "TranNumber";
                ProcessingCenterID = new Selector("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView_edProcessingCenterID", "Processing Center ID", locator, null);
                ProcessingCenterIDLabel = new Label(ProcessingCenterID);
                ProcessingCenterID.DataField = "ProcessingCenterID";
                DataMemberName = "ImportExternalTran";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ImportPaymentCreateButton()
            {
                Buttons.ImportPaymentCreateButton.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ImportPaymentCreateButton { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    ImportPaymentCreateButton = new Button("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentCreateButton", "ImportPaymentCreateButton", "ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView");
                    Cancel = new Button("ctl00_phG_ImportPaymentSmartPanel_ImportPaymentCancelButton", "Cancel", "ctl00_phG_ImportPaymentSmartPanel_ImportPaymentFormView");
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
