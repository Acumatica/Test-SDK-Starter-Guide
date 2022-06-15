using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
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
    
    
    public class SO101000_SOSetupMaint : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_sosetup_tab Sosetup_tab { get; } = new c_sosetup_tab("ctl00_phF_tab", "sosetup_tab");
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
        protected c_setupapproval_gridapproval SetupApproval_gridApproval { get; } = new c_setupapproval_gridapproval("ctl00_phF_tab_t1_gridApproval", "SetupApproval_gridApproval");
        protected c_setupapproval_lv0 SetupApproval_lv0 { get; } = new c_setupapproval_lv0("ctl00_phF_tab_t1_gridApproval_lv0", "SetupApproval_lv0");
        protected c_pickpackshipsetup_formscansetup PickPackShipSetup_formScanSetup { get; } = new c_pickpackshipsetup_formscansetup("ctl00_phF_tab_t3_formScanSetup", "PickPackShipSetup_formScanSetup");
        protected c_notifications_gridns Notifications_gridNS { get; } = new c_notifications_gridns("ctl00_phF_tab_t2_sp1_gridNS", "Notifications_gridNS");
        protected c_notifications_lv0 Notifications_lv0 { get; } = new c_notifications_lv0("ctl00_phF_tab_t2_sp1_gridNS_lv0", "Notifications_lv0");
        protected c_recipients_gridnr Recipients_gridNR { get; } = new c_recipients_gridnr("ctl00_phF_tab_t2_sp1_gridNR", "Recipients_gridNR");
        protected c_recipients_lv0 Recipients_lv0 { get; } = new c_recipients_lv0("ctl00_phF_tab_t2_sp1_gridNR_lv0", "Recipients_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public SO101000_SOSetupMaint()
        {
            ScreenId = "SO101000";
            ScreenUrl = "/Pages/SO/SO101000.aspx";
            ToolBar = new PxToolBar(null);
        }
        
        public virtual SO101000_SOSetupMaint ReadOne(Gate gate)
        {
            new BiObject<SO101000_SOSetupMaint>(gate).ReadOne(this);
            return this;
        }
        
        public virtual SO101000_SOSetupMaint ReadOne()
        {
            return this.ReadOne(ApiConnection.Source);
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
        
        public class c_sosetup_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector DefaultOrderType { get; }
			public Label DefaultOrderTypeLabel { get; }
			public Selector TransferOrderType { get; }
			public Label TransferOrderTypeLabel { get; }
			public Selector ShipmentNumberingID { get; }
			public Label ShipmentNumberingIDLabel { get; }
			public Selector PickingWorksheetNumberingID { get; }
			public Label PickingWorksheetNumberingIDLabel { get; }
			public CheckBox AdvancedAvailCheck { get; }
			public Label AdvancedAvailCheckLabel { get; }
			public DropDown MinGrossProfitValidation { get; }
			public Label MinGrossProfitValidationLabel { get; }
			public CheckBox UsePriceAdjustmentMultiplier { get; }
			public Label UsePriceAdjustmentMultiplierLabel { get; }
			public CheckBox IgnoreMinGrossProfitCustomerPrice { get; }
			public Label IgnoreMinGrossProfitCustomerPriceLabel { get; }
			public CheckBox IgnoreMinGrossProfitCustomerPriceClass { get; }
			public Label IgnoreMinGrossProfitCustomerPriceClassLabel { get; }
			public CheckBox IgnoreMinGrossProfitPromotionalPrice { get; }
			public Label IgnoreMinGrossProfitPromotionalPriceLabel { get; }
			public DropDown FreightAllocation { get; }
			public Label FreightAllocationLabel { get; }
			public DropDown FreeItemShipping { get; }
			public Label FreeItemShippingLabel { get; }
			public CheckBox HoldShipments { get; }
			public Label HoldShipmentsLabel { get; }
			public CheckBox RequireShipmentTotal { get; }
			public Label RequireShipmentTotalLabel { get; }
			public CheckBox AddAllToShipment { get; }
			public Label AddAllToShipmentLabel { get; }
			public CheckBox CreateZeroShipments { get; }
			public Label CreateZeroShipmentsLabel { get; }
			public CheckBox CreditCheckError { get; }
			public Label CreditCheckErrorLabel { get; }
			public CheckBox UseShipDateForInvoiceDate { get; }
			public Label UseShipDateForInvoiceDateLabel { get; }
			public CheckBox AutoReleaseIN { get; }
			public Label AutoReleaseINLabel { get; }
			public DropDown SalesProfitabilityForNSKits { get; }
			public Label SalesProfitabilityForNSKitsLabel { get; }
			public Selector DfltIntercompanyOrderType { get; }
			public Label DfltIntercompanyOrderTypeLabel { get; }
			public Selector DfltIntercompanyRMAType { get; }
			public Label DfltIntercompanyRMATypeLabel { get; }
			public CheckBox DisableAddingItemsForIntercompany { get; }
			public Label DisableAddingItemsForIntercompanyLabel { get; }
			public CheckBox DisableEditingPricesDiscountsForIntercompany { get; }
			public Label DisableEditingPricesDiscountsForIntercompanyLabel { get; }
			public CheckBox ShowOnlyAvailableRelatedItems { get; }
			public Label ShowOnlyAvailableRelatedItemsLabel { get; }
			public CheckBox OrderRequestApproval { get; }
			public Label OrderRequestApprovalLabel { get; }
			public Label LblIgnoreMinGrossProfitOptions_ { get; }
			public Label LblScanSetup_ { get; }
            
            public c_sosetup_tab(string locator, string name) : 
                    base(locator, name)
            {
                DefaultOrderType = new Selector("ctl00_phF_tab_t0_edDefaultOrderType", "Default Sales Order Type", locator, null);
                DefaultOrderTypeLabel = new Label(DefaultOrderType);
                DefaultOrderType.DataField = "DefaultOrderType";
                TransferOrderType = new Selector("ctl00_phF_tab_t0_edTransferOrderType", "Default Transfer Order Type", locator, null);
                TransferOrderTypeLabel = new Label(TransferOrderType);
                TransferOrderType.DataField = "TransferOrderType";
                ShipmentNumberingID = new Selector("ctl00_phF_tab_t0_edShipmentNumberingID", "Shipment Numbering Sequence", locator, null);
                ShipmentNumberingIDLabel = new Label(ShipmentNumberingID);
                ShipmentNumberingID.DataField = "ShipmentNumberingID";
                PickingWorksheetNumberingID = new Selector("ctl00_phF_tab_t0_edWorksheetNumberingID", "Picking Worksheet Numbering Sequence", locator, null);
                PickingWorksheetNumberingIDLabel = new Label(PickingWorksheetNumberingID);
                PickingWorksheetNumberingID.DataField = "PickingWorksheetNumberingID";
                AdvancedAvailCheck = new CheckBox("ctl00_phF_tab_t0_chkAdvancedAvailCheck", "Advanced Availability Validation", locator, null);
                AdvancedAvailCheckLabel = new Label(AdvancedAvailCheck);
                AdvancedAvailCheck.DataField = "AdvancedAvailCheck";
                MinGrossProfitValidation = new DropDown("ctl00_phF_tab_t0_edMinGrossProfitValidation", "Validate Min. Markup", locator, null);
                MinGrossProfitValidationLabel = new Label(MinGrossProfitValidation);
                MinGrossProfitValidation.DataField = "MinGrossProfitValidation";
                MinGrossProfitValidation.Items.Add("N", "No Validation");
                MinGrossProfitValidation.Items.Add("W", "Warning");
                MinGrossProfitValidation.Items.Add("S", "Set to minimum");
                UsePriceAdjustmentMultiplier = new CheckBox("ctl00_phF_tab_t0_edUsePriceAdjustmentMultiplier", "Use a Price Adjustment Multiplier", locator, null);
                UsePriceAdjustmentMultiplierLabel = new Label(UsePriceAdjustmentMultiplier);
                UsePriceAdjustmentMultiplier.DataField = "UsePriceAdjustmentMultiplier";
                IgnoreMinGrossProfitCustomerPrice = new CheckBox("ctl00_phF_tab_t0_edIgnoreMinGrossProfitCustomerPrice", "Customer", locator, null);
                IgnoreMinGrossProfitCustomerPriceLabel = new Label(IgnoreMinGrossProfitCustomerPrice);
                IgnoreMinGrossProfitCustomerPrice.DataField = "IgnoreMinGrossProfitCustomerPrice";
                IgnoreMinGrossProfitCustomerPriceClass = new CheckBox("ctl00_phF_tab_t0_edIgnoreMinGrossProfitCustomerPriceClass", "Customer Price Class", locator, null);
                IgnoreMinGrossProfitCustomerPriceClassLabel = new Label(IgnoreMinGrossProfitCustomerPriceClass);
                IgnoreMinGrossProfitCustomerPriceClass.DataField = "IgnoreMinGrossProfitCustomerPriceClass";
                IgnoreMinGrossProfitPromotionalPrice = new CheckBox("ctl00_phF_tab_t0_edIgnoreMinGrossProfitPromotionalPrice", "Promotional Prices", locator, null);
                IgnoreMinGrossProfitPromotionalPriceLabel = new Label(IgnoreMinGrossProfitPromotionalPrice);
                IgnoreMinGrossProfitPromotionalPrice.DataField = "IgnoreMinGrossProfitPromotionalPrice";
                FreightAllocation = new DropDown("ctl00_phF_tab_t0_edFreightAllocation", "Freight Allocation on Partial Shipping", locator, null);
                FreightAllocationLabel = new Label(FreightAllocation);
                FreightAllocation.DataField = "FreightAllocation";
                FreightAllocation.Items.Add("A", "Full Amount First Time");
                FreightAllocation.Items.Add("P", "Allocate Proportionally");
                FreeItemShipping = new DropDown("ctl00_phF_tab_t0_edFreeItemShipping", "Free Item Shipping", locator, null);
                FreeItemShippingLabel = new Label(FreeItemShipping);
                FreeItemShipping.DataField = "FreeItemShipping";
                FreeItemShipping.Items.Add("P", "Proportional");
                FreeItemShipping.Items.Add("S", "On Last Shipment");
                HoldShipments = new CheckBox("ctl00_phF_tab_t0_chkHoldShipments", "Hold Shipments on Entry", locator, null);
                HoldShipmentsLabel = new Label(HoldShipments);
                HoldShipments.DataField = "HoldShipments";
                RequireShipmentTotal = new CheckBox("ctl00_phF_tab_t0_chkRequireShipmentTotal", "Validate Shipment Total on Confirmation", locator, null);
                RequireShipmentTotalLabel = new Label(RequireShipmentTotal);
                RequireShipmentTotal.DataField = "RequireShipmentTotal";
                AddAllToShipment = new CheckBox("ctl00_phF_tab_t0_chkAddAllToShipment", "Add Zero Lines for Items Not in Stock", locator, null);
                AddAllToShipmentLabel = new Label(AddAllToShipment);
                AddAllToShipment.DataField = "AddAllToShipment";
                CreateZeroShipments = new CheckBox("ctl00_phF_tab_t0_chkCreateZeroShipments", "Create Zero Shipments", locator, null);
                CreateZeroShipmentsLabel = new Label(CreateZeroShipments);
                CreateZeroShipments.DataField = "CreateZeroShipments";
                CreditCheckError = new CheckBox("ctl00_phF_tab_t0_chkCreditCheckError", "Hold Invoices on Failed Credit Check", locator, null);
                CreditCheckErrorLabel = new Label(CreditCheckError);
                CreditCheckError.DataField = "CreditCheckError";
                UseShipDateForInvoiceDate = new CheckBox("ctl00_phF_tab_t0_chkUseShipDateForInvoiceDate", "Use Shipment Date for Invoice Date", locator, null);
                UseShipDateForInvoiceDateLabel = new Label(UseShipDateForInvoiceDate);
                UseShipDateForInvoiceDate.DataField = "UseShipDateForInvoiceDate";
                AutoReleaseIN = new CheckBox("ctl00_phF_tab_t0_chkAutoReleaseIN", "Automatically Release IN Documents", locator, null);
                AutoReleaseINLabel = new Label(AutoReleaseIN);
                AutoReleaseIN.DataField = "AutoReleaseIN";
                SalesProfitabilityForNSKits = new DropDown("ctl00_phF_tab_t0_edSalesProfitabilityForNSKits", "Cost Calculation Basis for Non-Stock Kits", locator, null);
                SalesProfitabilityForNSKitsLabel = new Label(SalesProfitabilityForNSKits);
                SalesProfitabilityForNSKits.DataField = "SalesProfitabilityForNSKits";
                SalesProfitabilityForNSKits.Items.Add("S", "Stock Component Cost");
                SalesProfitabilityForNSKits.Items.Add("K", "Non-Stock Kit Standard Cost");
                SalesProfitabilityForNSKits.Items.Add("C", "Non-Stock Kit Standard Cost Plus Stock Component Cost");
                DfltIntercompanyOrderType = new Selector("ctl00_phF_tab_t0_edDfltIntercompanyOrderType", "Default Type for Intercompany Sales", locator, null);
                DfltIntercompanyOrderTypeLabel = new Label(DfltIntercompanyOrderType);
                DfltIntercompanyOrderType.DataField = "DfltIntercompanyOrderType";
                DfltIntercompanyRMAType = new Selector("ctl00_phF_tab_t0_edDfltIntercompanyRMAType", "Default Type for Intercompany Returns", locator, null);
                DfltIntercompanyRMATypeLabel = new Label(DfltIntercompanyRMAType);
                DfltIntercompanyRMAType.DataField = "DfltIntercompanyRMAType";
                DisableAddingItemsForIntercompany = new CheckBox("ctl00_phF_tab_t0_chkDisableAddingItemsForIntercompany", "Disable Adding Items to Orders", locator, null);
                DisableAddingItemsForIntercompanyLabel = new Label(DisableAddingItemsForIntercompany);
                DisableAddingItemsForIntercompany.DataField = "DisableAddingItemsForIntercompany";
                DisableEditingPricesDiscountsForIntercompany = new CheckBox("ctl00_phF_tab_t0_chkDisableEditingPricesDiscountsForIntercompany", "Disable Editing Prices and Discounts", locator, null);
                DisableEditingPricesDiscountsForIntercompanyLabel = new Label(DisableEditingPricesDiscountsForIntercompany);
                DisableEditingPricesDiscountsForIntercompany.DataField = "DisableEditingPricesDiscountsForIntercompany";
                ShowOnlyAvailableRelatedItems = new CheckBox("ctl00_phF_tab_t0_chkShowOnlyAvailableRelatedItems", "Show Only Available Items", locator, null);
                ShowOnlyAvailableRelatedItemsLabel = new Label(ShowOnlyAvailableRelatedItems);
                ShowOnlyAvailableRelatedItems.DataField = "ShowOnlyAvailableRelatedItems";
                OrderRequestApproval = new CheckBox("ctl00_phF_tab_t1_chkOrderRequestApproval", "Require Approval", locator, null);
                OrderRequestApprovalLabel = new Label(OrderRequestApproval);
                OrderRequestApproval.DataField = "OrderRequestApproval";
                LblIgnoreMinGrossProfitOptions_ = new Label("ctl00_phF_tab_t0_lblIgnoreMinGrossProfitOptions", "Ignore Min. Markup Validation for Prices Specific To", locator, null);
                LblScanSetup_ = new Label("ctl00_phF_tab_t3_formScanSetup_lblScanSetup", "These settings are specific to the current branch.", locator, null);
                DataMemberName = "sosetup";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ShipmentNumberingIDEdit()
            {
                Buttons.ShipmentNumberingIDEdit.Click();
            }
            
            public virtual void PickingWorksheetNumberingIDEdit()
            {
                Buttons.PickingWorksheetNumberingIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ShipmentNumberingIDEdit { get; }
			public Button PickingWorksheetNumberingIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ShipmentNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edShipmentNumberingID\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "ShipmentNumberingIDEdit", "ctl00_phF_tab");
                    ShipmentNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PickingWorksheetNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edWorksheetNumberingID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "PickingWorksheetNumberingIDEdit", "ctl00_phF_tab");
                    PickingWorksheetNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
        
        public class c_setupapproval_gridapproval : Grid<c_setupapproval_gridapproval.c_grid_row, c_setupapproval_gridapproval.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_setupapproval_gridapproval(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t1_gridApproval");
                DataMemberName = "SetupApproval";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t1_gridApproval_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t1_gridApproval_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AssignmentMapIDEdit { get; }
			public Button AssignmentNotificationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AssignmentMapIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t1_gridApproval_lv0_edAssignmentMapID\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "AssignmentMapIDEdit", "ctl00_phF_tab_t1_gridApproval");
                    AssignmentMapIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AssignmentNotificationIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t1_gridApproval_lv0_edAssignmentNotificationID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "AssignmentNotificationIDEdit", "ctl00_phF_tab_t1_gridApproval");
                    AssignmentNotificationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector OrderType { get; }
			public Selector AssignmentMapID { get; }
			public Selector AssignmentNotificationID { get; }
			public PXNumberEdit ApprovalID { get; }
                
                public c_grid_row(c_setupapproval_gridapproval grid) : 
                        base(grid)
                {
                    OrderType = new Selector("_ctl00_phF_tab_t1_gridApproval_lv0_edOrderType", "SO Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    AssignmentMapID = new Selector("_ctl00_phF_tab_t1_gridApproval_lv0_edAssignmentMapID", "Approval Map", grid.Locator, "AssignmentMapID");
                    AssignmentMapID.DataField = "AssignmentMapID";
                    AssignmentNotificationID = new Selector("_ctl00_phF_tab_t1_gridApproval_lv0_edAssignmentNotificationID", "Pending Approval Notification", grid.Locator, "AssignmentNotificationID");
                    AssignmentNotificationID.DataField = "AssignmentNotificationID";
                    ApprovalID = new PXNumberEdit("ctl00_phF_tab_t1_gridApproval_en", "ApprovalID", grid.Locator, "ApprovalID");
                    ApprovalID.DataField = "ApprovalID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter OrderType { get; }
				public SelectorColumnFilter AssignmentMapID { get; }
				public SelectorColumnFilter AssignmentNotificationID { get; }
				public PXNumberEditColumnFilter ApprovalID { get; }
                
                public c_grid_header(c_setupapproval_gridapproval grid) : 
                        base(grid)
                {
                    OrderType = new SelectorColumnFilter(grid.Row.OrderType);
                    AssignmentMapID = new SelectorColumnFilter(grid.Row.AssignmentMapID);
                    AssignmentNotificationID = new SelectorColumnFilter(grid.Row.AssignmentNotificationID);
                    ApprovalID = new PXNumberEditColumnFilter(grid.Row.ApprovalID);
                }
            }
        }
        
        public class c_setupapproval_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector AssignmentMapID { get; }
			public Label AssignmentMapIDLabel { get; }
			public Selector AssignmentNotificationID { get; }
			public Label AssignmentNotificationIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_setupapproval_lv0(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new Selector("ctl00_phF_tab_t1_gridApproval_lv0_edOrderType", "SO Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                AssignmentMapID = new Selector("ctl00_phF_tab_t1_gridApproval_lv0_edAssignmentMapID", "Approval Map", locator, null);
                AssignmentMapIDLabel = new Label(AssignmentMapID);
                AssignmentMapID.DataField = "AssignmentMapID";
                AssignmentNotificationID = new Selector("ctl00_phF_tab_t1_gridApproval_lv0_edAssignmentNotificationID", "Pending Approval Notification", locator, null);
                AssignmentNotificationIDLabel = new Label(AssignmentNotificationID);
                AssignmentNotificationID.DataField = "AssignmentNotificationID";
                Es = new Selector("ctl00_phF_tab_t1_gridApproval_lv0_es", "Es", locator, null);
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
                    AssignmentMapIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t1_gridApproval_lv0_edAssignmentMapID\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "AssignmentMapIDEdit", "ctl00_phF_tab_t1_gridApproval_lv0");
                    AssignmentMapIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AssignmentNotificationIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t1_gridApproval_lv0_edAssignmentNotificationID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "AssignmentNotificationIDEdit", "ctl00_phF_tab_t1_gridApproval_lv0");
                    AssignmentNotificationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_pickpackshipsetup_formscansetup : Container
        {
            
			public CheckBox ShowPickTab { get; }
			public Label ShowPickTabLabel { get; }
			public CheckBox ShowPackTab { get; }
			public Label ShowPackTabLabel { get; }
			public CheckBox ShowShipTab { get; }
			public Label ShowShipTabLabel { get; }
			public CheckBox ShowReturningTab { get; }
			public Label ShowReturningTabLabel { get; }
			public CheckBox ShowScanLogTab { get; }
			public Label ShowScanLogTabLabel { get; }
			public DropDown ShortShipmentConfirmation { get; }
			public Label ShortShipmentConfirmationLabel { get; }
			public DropDown ShipmentLocationOrdering { get; }
			public Label ShipmentLocationOrderingLabel { get; }
			public CheckBox UseDefaultQty { get; }
			public Label UseDefaultQtyLabel { get; }
			public CheckBox ExplicitLineConfirmation { get; }
			public Label ExplicitLineConfirmationLabel { get; }
			public CheckBox UseCartsForPick { get; }
			public Label UseCartsForPickLabel { get; }
			public CheckBox DefaultLocationFromShipment { get; }
			public Label DefaultLocationFromShipmentLabel { get; }
			public CheckBox DefaultLotSerialFromShipment { get; }
			public Label DefaultLotSerialFromShipmentLabel { get; }
			public CheckBox EnterSizeForPackages { get; }
			public Label EnterSizeForPackagesLabel { get; }
			public CheckBox PrintShipmentConfirmation { get; }
			public Label PrintShipmentConfirmationLabel { get; }
			public CheckBox PrintShipmentLabels { get; }
			public Label PrintShipmentLabelsLabel { get; }
			public CheckBox ConfirmEachPackageWeight { get; }
			public Label ConfirmEachPackageWeightLabel { get; }
			public CheckBox RequestLocationForEachItem { get; }
			public Label RequestLocationForEachItemLabel { get; }
			public CheckBox ConfirmToteForEachItem { get; }
			public Label ConfirmToteForEachItemLabel { get; }
			public CheckBox PrintPickListsAndPackSlipsTogether { get; }
			public Label PrintPickListsAndPackSlipsTogetherLabel { get; }
			public Label LblScanSetup_ { get; }
            
            public c_pickpackshipsetup_formscansetup(string locator, string name) : 
                    base(locator, name)
            {
                ShowPickTab = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edShowPickTab", "Display the Pick Tab", locator, null);
                ShowPickTabLabel = new Label(ShowPickTab);
                ShowPickTab.DataField = "ShowPickTab";
                ShowPackTab = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edShowPackTab", "Display the Pack Tab", locator, null);
                ShowPackTabLabel = new Label(ShowPackTab);
                ShowPackTab.DataField = "ShowPackTab";
                ShowShipTab = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edShowShipTab", "Display the Ship Tab", locator, null);
                ShowShipTabLabel = new Label(ShowShipTab);
                ShowShipTab.DataField = "ShowShipTab";
                ShowReturningTab = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edShowReturnTab", "Display the Return Tab", locator, null);
                ShowReturningTabLabel = new Label(ShowReturningTab);
                ShowReturningTab.DataField = "ShowReturningTab";
                ShowScanLogTab = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edShowScanLogTab", "Display the Scan Log Tab", locator, null);
                ShowScanLogTabLabel = new Label(ShowScanLogTab);
                ShowScanLogTab.DataField = "ShowScanLogTab";
                ShortShipmentConfirmation = new DropDown("ctl00_phF_tab_t3_formScanSetup_edShortShipmentConfirmation", "Short Shipment Confirmation", locator, null);
                ShortShipmentConfirmationLabel = new Label(ShortShipmentConfirmation);
                ShortShipmentConfirmation.DataField = "ShortShipmentConfirmation";
                ShortShipmentConfirmation.Items.Add("F", "Forbid");
                ShortShipmentConfirmation.Items.Add("W", "Allow with Warning");
                ShipmentLocationOrdering = new DropDown("ctl00_phF_tab_t3_formScanSetup_edShipmentLocationOrdering", "Order Shipment Lines by Location\'s", locator, null);
                ShipmentLocationOrderingLabel = new Label(ShipmentLocationOrdering);
                ShipmentLocationOrdering.DataField = "ShipmentLocationOrdering";
                ShipmentLocationOrdering.Items.Add("PICK", "Pick Priority");
                ShipmentLocationOrdering.Items.Add("PATH", "Path Priority");
                UseDefaultQty = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edUseDefaultQty", "Use Default Quantity", locator, null);
                UseDefaultQtyLabel = new Label(UseDefaultQty);
                UseDefaultQty.DataField = "UseDefaultQty";
                ExplicitLineConfirmation = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edExplicitLineConfirmation", "Use Explicit Line Confirmation", locator, null);
                ExplicitLineConfirmationLabel = new Label(ExplicitLineConfirmation);
                ExplicitLineConfirmation.DataField = "ExplicitLineConfirmation";
                UseCartsForPick = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edUseCartsForPick", "Use Carts for Picking", locator, null);
                UseCartsForPickLabel = new Label(UseCartsForPick);
                UseCartsForPick.DataField = "UseCartsForPick";
                DefaultLocationFromShipment = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edDefaultLocation", "Use Default Location", locator, null);
                DefaultLocationFromShipmentLabel = new Label(DefaultLocationFromShipment);
                DefaultLocationFromShipment.DataField = "DefaultLocationFromShipment";
                DefaultLotSerialFromShipment = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edDefaultLotSerial", "Use Default Lot/Serial Nbr.", locator, null);
                DefaultLotSerialFromShipmentLabel = new Label(DefaultLotSerialFromShipment);
                DefaultLotSerialFromShipment.DataField = "DefaultLotSerialFromShipment";
                EnterSizeForPackages = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edEnterSizeForPackages", "Enter Length/Width/Height for Packages", locator, null);
                EnterSizeForPackagesLabel = new Label(EnterSizeForPackages);
                EnterSizeForPackages.DataField = "EnterSizeForPackages";
                PrintShipmentConfirmation = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edPrintShipmentConfirmation", "Print Shipment Confirmation Automatically", locator, null);
                PrintShipmentConfirmationLabel = new Label(PrintShipmentConfirmation);
                PrintShipmentConfirmation.DataField = "PrintShipmentConfirmation";
                PrintShipmentLabels = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edPrintShipmentLabels", "Print Shipment Labels Automatically", locator, null);
                PrintShipmentLabelsLabel = new Label(PrintShipmentLabels);
                PrintShipmentLabels.DataField = "PrintShipmentLabels";
                ConfirmEachPackageWeight = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edConfirmEachPackageWeight", "Confirm Weight for Each Package", locator, null);
                ConfirmEachPackageWeightLabel = new Label(ConfirmEachPackageWeight);
                ConfirmEachPackageWeight.DataField = "ConfirmEachPackageWeight";
                RequestLocationForEachItem = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edRequestLocationForEachItem", "Request Location for Each Item", locator, null);
                RequestLocationForEachItemLabel = new Label(RequestLocationForEachItem);
                RequestLocationForEachItem.DataField = "RequestLocationForEachItem";
                ConfirmToteForEachItem = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edConfirmToteForEachItem", "Confirm Tote Selection on Wave Picking", locator, null);
                ConfirmToteForEachItemLabel = new Label(ConfirmToteForEachItem);
                ConfirmToteForEachItem.DataField = "ConfirmToteForEachItem";
                PrintPickListsAndPackSlipsTogether = new CheckBox("ctl00_phF_tab_t3_formScanSetup_edPrintPickListsAndPackSlipsTogether", "Print Packing Slips with Pick Lists", locator, null);
                PrintPickListsAndPackSlipsTogetherLabel = new Label(PrintPickListsAndPackSlipsTogether);
                PrintPickListsAndPackSlipsTogether.DataField = "PrintPickListsAndPackSlipsTogether";
                LblScanSetup_ = new Label("ctl00_phF_tab_t3_formScanSetup_lblScanSetup", "These settings are specific to the current branch.", locator, null);
                DataMemberName = "PickPackShipSetup";
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
                ToolBar = new PxToolBar("ctl00_phF_tab_t2_sp1_gridNS");
                DataMemberName = "Notifications";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t2_sp1_gridNS_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t2_sp1_gridNS");
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
			public Selector ShipVia { get; }
			public DropDown Format { get; }
			public DropDown RecipientsBehavior { get; }
			public PXTextEdit SetupID { get; }
			public PXTextEdit Module { get; }
                
                public c_grid_row(c_notifications_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBox("_ctl00_phF_tab_t2_sp1_gridNS_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    NotificationCD = new PXTextEdit("_ctl00_phF_tab_t2_sp1_gridNS_lv0_edNotificationCD", "Mailing ID", grid.Locator, "NotificationCD");
                    NotificationCD.DataField = "NotificationCD";
                    NBranchID = new Selector("_ctl00_phF_tab_t2_sp1_gridNS_lv0_edNBranchID", "Branch", grid.Locator, "NBranchID");
                    NBranchID.DataField = "NBranchID";
                    EMailAccountID = new Selector("_ctl00_phF_tab_t2_sp1_gridNS_lv0_edEMailAccountID", "Default Email Account", grid.Locator, "EMailAccountID");
                    EMailAccountID.DataField = "EMailAccountID";
                    DefaultPrinterID = new Selector("_ctl00_phF_tab_t2_sp1_gridNS_lv0_edDefPrinterID", "Default Printer", grid.Locator, "DefaultPrinterID");
                    DefaultPrinterID.DataField = "DefaultPrinterID";
                    ReportID = new Selector("_ctl00_phF_tab_t2_sp1_gridNS_lv0_edReportID", "Report ID", grid.Locator, "ReportID");
                    ReportID.DataField = "ReportID";
                    NotificationID = new Selector("_ctl00_phF_tab_t2_sp1_gridNS_lv0_edNotificationID", "Notification Template", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                    ShipVia = new Selector("_ctl00_phF_tab_t2_sp1_gridNS_lv0_edShipVia", "Ship Via", grid.Locator, "ShipVia");
                    ShipVia.DataField = "ShipVia";
                    Format = new DropDown("_ctl00_phF_tab_t2_sp1_gridNS_lv0_edFormat", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    RecipientsBehavior = new DropDown("_ctl00_phF_tab_t2_sp1_gridNS_lv0_ec", "Recipients", grid.Locator, "RecipientsBehavior");
                    RecipientsBehavior.DataField = "RecipientsBehavior";
                    RecipientsBehavior.Items.Add("O", "Override Recipients");
                    RecipientsBehavior.Items.Add("A", "Add Recipients");
                    SetupID = new PXTextEdit("ctl00_phF_tab_t2_sp1_gridNS_ei", "SetupID", grid.Locator, "SetupID");
                    SetupID.DataField = "SetupID";
                    Module = new PXTextEdit("ctl00_phF_tab_t2_sp1_gridNS_em", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
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
				public SelectorColumnFilter ShipVia { get; }
				public DropDownColumnFilter Format { get; }
				public DropDownColumnFilter RecipientsBehavior { get; }
				public PXTextEditColumnFilter SetupID { get; }
				public PXTextEditColumnFilter Module { get; }
                
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
                    ShipVia = new SelectorColumnFilter(grid.Row.ShipVia);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    RecipientsBehavior = new DropDownColumnFilter(grid.Row.RecipientsBehavior);
                    SetupID = new PXTextEditColumnFilter(grid.Row.SetupID);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
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
			public Selector ShipVia { get; }
			public Label ShipViaLabel { get; }
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
                NotificationCD = new PXTextEdit("ctl00_phF_tab_t2_sp1_gridNS_lv0_edNotificationCD", "Mailing ID", locator, null);
                NotificationCDLabel = new Label(NotificationCD);
                NotificationCD.DataField = "NotificationCD";
                NotificationID = new Selector("ctl00_phF_tab_t2_sp1_gridNS_lv0_edNotificationID", "Notification Template", locator, null);
                NotificationIDLabel = new Label(NotificationID);
                NotificationID.DataField = "NotificationID";
                NBranchID = new Selector("ctl00_phF_tab_t2_sp1_gridNS_lv0_edNBranchID", "Branch", locator, null);
                NBranchIDLabel = new Label(NBranchID);
                NBranchID.DataField = "NBranchID";
                Format = new DropDown("ctl00_phF_tab_t2_sp1_gridNS_lv0_edFormat", "Format", locator, null);
                FormatLabel = new Label(Format);
                Format.DataField = "Format";
                Format.Items.Add("H", "Html");
                Format.Items.Add("E", "Excel");
                Format.Items.Add("P", "PDF");
                Active = new CheckBox("ctl00_phF_tab_t2_sp1_gridNS_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                DefaultPrinterID = new Selector("ctl00_phF_tab_t2_sp1_gridNS_lv0_edDefPrinterID", "Default Printer", locator, null);
                DefaultPrinterIDLabel = new Label(DefaultPrinterID);
                DefaultPrinterID.DataField = "DefaultPrinterID";
                ShipVia = new Selector("ctl00_phF_tab_t2_sp1_gridNS_lv0_edShipVia", "Ship Via", locator, null);
                ShipViaLabel = new Label(ShipVia);
                ShipVia.DataField = "ShipVia";
                ReportID = new Selector("ctl00_phF_tab_t2_sp1_gridNS_lv0_edReportID", "Report ID", locator, null);
                ReportIDLabel = new Label(ReportID);
                ReportID.DataField = "ReportID";
                EMailAccountID = new Selector("ctl00_phF_tab_t2_sp1_gridNS_lv0_edEMailAccountID", "Default Email Account", locator, null);
                EMailAccountIDLabel = new Label(EMailAccountID);
                EMailAccountID.DataField = "EMailAccountID";
                Es = new Selector("ctl00_phF_tab_t2_sp1_gridNS_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phF_tab_t2_sp1_gridNS_lv0_ec", "Ec", locator, null);
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
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t2_sp1_gridNS_lv0");
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
                ToolBar = new PxToolBar("ctl00_phF_tab_t2_sp1_gridNR");
                DataMemberName = "Recipients";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t2_sp1_gridNR_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_sp1_gridNR_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t2_sp1_gridNR");
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
                    Active = new CheckBox("ctl00_phF_tab_t2_sp1_gridNR_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    ContactType = new DropDown("_ctl00_phF_tab_t2_sp1_gridNR_lv0_ec", "Contact Type", grid.Locator, "ContactType");
                    ContactType.DataField = "ContactType";
                    ContactType.Items.Add("P", "Account Email");
                    ContactType.Items.Add("R", "Remittance");
                    ContactType.Items.Add("S", "Account Location Email");
                    ContactType.Items.Add("E", "Employee");
                    OriginalContactID = new PXNumberEdit("ctl00_phF_tab_t2_sp1_gridNR_en", "OriginalContactID", grid.Locator, "OriginalContactID");
                    OriginalContactID.DataField = "OriginalContactID";
                    ContactID = new Selector("_ctl00_phF_tab_t2_sp1_gridNR_lv0_edContactID", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                    Format = new DropDown("_ctl00_phF_tab_t2_sp1_gridNR_lv0_ec", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    AddTo = new DropDown("_ctl00_phF_tab_t2_sp1_gridNR_lv0_ec", "Add To", grid.Locator, "AddTo");
                    AddTo.DataField = "AddTo";
                    AddTo.Items.Add("T", "To");
                    AddTo.Items.Add("C", "Cc");
                    AddTo.Items.Add("B", "Bcc");
                    RecipientID = new PXTextEdit("ctl00_phF_tab_t2_sp1_gridNR_ei", "RecipientID", grid.Locator, "RecipientID");
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
                ContactID = new Selector("ctl00_phF_tab_t2_sp1_gridNR_lv0_edContactID", "Contact ID", locator, null);
                ContactIDLabel = new Label(ContactID);
                ContactID.DataField = "ContactID";
                Es = new Selector("ctl00_phF_tab_t2_sp1_gridNR_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phF_tab_t2_sp1_gridNR_lv0_ec", "Ec", locator, null);
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
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t2_sp1_gridNR_lv0");
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
