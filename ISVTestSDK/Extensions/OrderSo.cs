using System;
using Controls.Button;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public class OrderSo : SO301000_SOOrderEntry
    {
        public c_document_form Summary
        {
            get { return base.Document_form; }
        }

        public c__soorder_currencyinfo__rf CurrencyInformation
        {
            get { return base._SOOrder_CurrencyInfo__rf; }
        }

        public c_transactions_grid DocumentDetails
        {
            get { return base.Transactions_grid; }
        }

        public c_transactions_lv0 FormView
        {
            get { return base.Transactions_lv0; }
        }

        public c_taxes_grid1 Taxes
        {
            get { return base.Taxes_grid1; }
        }

        public c_salespertran_gridsalespertran SalespersonCommission
        {
            get { return base.SalesPerTran_gridSalesPerTran; }
        }

        public c_adjustments_detgrid Payments
        {
            get { return base.Adjustments_detgrid; }
        }

        public c_currentdocument_commission Commission
        {
            get { return base.CurrentDocument_Commission; }
        }

        public c_billing_contact_formc FinancialSettingsContact
        {
            get { return base.Billing_Contact_formC; }
        }

        public c_billing_address_forma FinancialSettingsAddress
        {
            get { return base.Billing_Address_formA; }
        }

        public c_currentdocument_formfinancialinformation FinancialSettingsInformation
        {
            get { return base.CurrentDocument_formFinancialInformation; }
        }

        public c_shipping_contact_formd ShippingSettingsContact
        {
            get { return base.Shipping_Contact_formD; }
        }

        public c_currentdocument_formpaymentinformation PaymentSettings
        {
            get { return base.CurrentDocument_formPaymentInformation; }
        }

        public c_shipping_address_formb ShippingSettingsAddress
        {
            get { return base.Shipping_Address_formB; }
        }

        public c_billing_address_forma BillingSettingsAddress
        {
            get { return base.Billing_Address_formA; }
        }

        public c_billing_contact_formc BillingSettingsContact
        {
            get { return base.Billing_Contact_formC; }
        }

        public c_currentdocument_formdeliverysettings DeliverySettingsInformation
        {
            get { return base.CurrentDocument_formDeliverySettings; }
        }

        public c_currentdocument_formshippingsettings ShippingSettingsInformation
        {
            get { return base.CurrentDocument_formShippingSettings; }
        }

        public c_discountdetails_formdiscountdetail Discounts
        {
            get { return base.DiscountDetails_formDiscountDetail; }
        }

        public c_currentdocument_risk Risks
        {
            get { return base.CurrentDocument_Risk; }
        }

        public c_orderrisks_gridorderrisks  RisksGrid
        {
            get { return OrderRisks_gridOrderRisks; }
        }
        public c_currentdocument_formcalculatedamounts CalculatedAmounts
        {
            get { return CurrentDocument_formCalculatedAmounts; }
        }

        public c_currentdocument_formordertotals Totals
        {
            get { return base.CurrentDocument_formOrderTotals; }
        }

        public c_currentdocument_formfreightinfo FreightInfo
        {
            get { return base.CurrentDocument_formFreightInfo; }
        }

        public c_approval_gridapproval ApprovalDetails
        {
            get { return base.Approval_gridApproval; }
        }

        public c_documentproperties_pxformview1 ShopForRates
        {
            get { return base.DocumentProperties_PXFormView1; }
        }

        public c_shipmentlist_grid5 Shipments
        {
            get { return base.ShipmentList_grid5; }
        }

        public c_soparamfilter_formcreateshipment ShipmentParameters
        {
            get { return base.Soparamfilter_formcreateshipment; }
        }

        public c_copyparamfilter_formcopyto CopyParameters
        {
            get { return base.Copyparamfilter_formcopyto; }
        }

        public c_transactions_importxlsxsettings_frmimportxlsxsettings ExcelImportSettings
        {
            get { return base.Transactions_ImportXLSXSettings_frmImportXLSXSettings; }
        }

        public c_transactions_importcsvsettings_frmimportcsvsettings CsvImportSettings
        {
            get { return base.Transactions_ImportCSVSettings_frmImportCSVSettings; }
        }

        public c_transactions_importcolumns_grdimportcolumn ImportColumns
        {
            get { return base.Transactions_ImportColumns_grdImportColumn; }
        }

        public c_soorderlinesplittingextension_lotseroptions_optform AllocationsForm
        {
            get { return base.SOOrderLineSplittingExtension_LotSerOptions_optform; }
        }

        public c_splits_grid2 Allocations
        {
            get { return base.Splits_grid2; }
        }

        public c_sitestatusfilter_formsitesstatus InventoryLookupFilter
        {
            get { return base.Sitestatusfilter_formsitesstatus; }
        }

        public c_sitestatus_gripsitestatus InventoryLookupGrid
        {
            get { return base.Sitestatus_gripsitestatus; }
        }

        public c_packages_gridpackages Packages
        {
            get { return base.Packages_gridPackages; }
        }

        public c_carrierrates_gridrates Rates
        {
            get { return base.CarrierRates_gridRates; }
        }

        public c_recalcdiscountsfilter_formrecalcdiscounts RecalculateForm
        {
            get { return base.Recalcdiscountsfilter_formrecalcdiscounts; }
        }

        public c_rrdistribution_griddistribution RutRotPersonalIDs
        {
            get { return base.RRDistribution_gridDistribution; }
        }

        public c_rutrots_rutrotform RUTROTSettings
        {
            get { return base.Rutrots_RUTROTForm; }
        }

        public c_quickprocessparameters_fromquickprocess QuickProcessForm
        {
            get { return base.QuickProcessParameters_fromQuickProcess; }
        }

        public c_processingresults ProcessingResultsForm
        {
            get { return base.ProcessingResults; }
        }

        public c_currentdocument_discountparameters DiscountParameters
        {
            get { return base.CurrentDocument_DiscountParameters; }
        }

        public c_createserviceorderfilter_formcreateserviceorder ServiceOrderParameters
        {
            get { return CreateServiceOrderFilter_formCreateServiceOrder; }
        }

        public c_adjustments_detgrid Applications
        {
            get { return Adjustments_detgrid; }
        }

        public c_adjustments_detgrid Payment
        {
            get { return Adjustments_detgrid; }
        }
        
        public c_orderestimaterecords_gridestimates Estimates 
        {
            get { return base.OrderEstimateRecords_gridEstimates; }
        }
        
        public c_orderestimateitemfilter_estimateaddform EstimateDialogForm
        {
            get { return base.OrderEstimateItemFilter_estimateAddForm; }
        }

        public c_blanketsplits_gridblanketsplits AddBlanketLineGrid
        {
            get { return base.BlanketSplits_gridBlanketSplits; }
        }

        public c_blanketorderchildrendisplaylist_ordersgrid ChildOrders
        {
            get { return base.BlanketOrderChildrenDisplayList_ordersGrid; }
        }

        public c_currentdocument_formpt PaymentTotals => base.CurrentDocument_formPT;
        public c_quickpayment_createpaymentformview CreatePaymentForm => base.QuickPayment_CreatePaymentFormView;
        public c_amsolinerecords_createprodgrid ProductionOrders => base.AMSOLineRecords_CreateProdgrid;
        public c_transactions_importcsvsettings_frmimportcsvsettings CommonSettings => base.Transactions_ImportCSVSettings_frmImportCSVSettings;
        public c_header_matrixformview MatrixSummary => base.Header_MatrixFormView;
        public c_additionalattributes_matrixattributes MatrixAdditionalAttributes => base.AdditionalAttributes_MatrixAttributes;
        public c_matrix_matrixmatrix Matrix => base.Matrix_MatrixMatrix;
        public c_header_matrixentryformview MatrixEntrySummary => base.Header_MatrixEntryFormView;
        public c_matrixitems_matrixitems MatrixEntryGrid => base.MatrixItems_MatrixItems;
        public c_addresslookupfilter_addresslookuppanelformaddress AutocompletePanel => AddressLookupFilter_AddressLookupPanelformAddress;
        public c_importexternaltran_importpaymentformview ImportPaymentForm => base.ImportExternalTran_ImportPaymentFormView;
        public c_selectedestimaterecord_quickestimateform QuickEstimateForm => base.SelectedEstimateRecord_QuickEstimateForm;
        public c_addinvoicefilter_form4 AddInvoiceFilter => base.Addinvoicefilter_form4;
        public c_invoicesplits_grid4 AddInvoiceGrid => base.Invoicesplits_grid4;

        private AddInvoiceForm_ex _addInvoiceForm;

        public c_currentdocument_formi IntercompanyPurchase => CurrentDocument_formI;

        public c_amsolinelinkrecords_linkprodgrid Linkprodgrid => AMSOLineLinkRecords_LinkProdGrid;

        public c_linkprodorderselectfilter_formlinkfilter LinkProdFilter => Linkprodorderselectfilter_formlinkfilter;
        public c_upsellitems_gridupsellitems UpsellItems => base.Upsellitems_gridupsellitems;
        public c_crosssellitems_gridcrosssellitems CrosssellItems => base.Crosssellitems_gridcrosssellitems;
        public c_substituteitems_gridsubstituteitems SubstituteItems => base.Substituteitems_gridsubstituteitems;
        public c_relateditemsfilter_fvrelateditemsheader AddRelatedItems => base.RelatedItemsFilter_fvRelatedItemsHeader;
        public c_allrelateditems_gridallrelateditems AllRelatedItems => base.Allrelateditems_gridallrelateditems;
        public c_otherrelateditems_gridotherrelateditems OtherRelatedItems => base.Otherrelateditems_gridotherrelateditems;
        public void VerifyStatusBar(decimal OnHand, decimal Available, decimal AvailableShipping, decimal Allocated = 0, string UOM = "PIECE")
        {
            DocumentDetails.Adjust();
            DocumentDetails.StatusBar.GetValue().VerifyEquals(string.Format("On Hand {1:F2} {0}, Available {2:F2} {0}, Available for Shipping {3:F2} {0}, Allocated {4:F2} {0}",
                UOM, OnHand, Available, AvailableShipping, Allocated));
        }

        public AddInvoiceForm_ex AddInvoiceForm
        {
            get
            {
                return _addInvoiceForm ?? (_addInvoiceForm = new AddInvoiceForm_ex(Addinvoicefilter_form4.Locator, Addinvoicefilter_form4.ControlName, Invoicesplits_grid4));
            }
        }

        public PoLinkForm PoLink
        {
            get { return new PoLinkForm(this); }
        }

        private void AwaitForCCOperation()
        {
            try
            {
                Wait.Wait.WaitForLongOperationToComplete();
            }
            catch (Exception exc)
            {
                if (Payments.Row.GetError().ToString().Contains("timed out"))
                {
                    Support.GetSite().RunBackup("CC_Operation_Timeout_" + DateTime.Now.ToFileTime());
                }
                else throw exc;
            }
        }

        public OrderSo()
        {
            FileName = "Sales Orders";

            ToolBar.EmailSalesOrder.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            ToolBar.CreateTransferOrder.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.PrintSalesOrder.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            RecalculateForm.Buttons.Ok.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            ToolBar.SaveTemplate.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            MatrixSummary.Buttons.Addandclose.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            MatrixEntryGrid.Buttons.Addandclose.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            ShipmentParameters.Buttons.Ok.WaitAction = Wait.Wait.WaitForPageToLoad;
            ImportPaymentForm.Buttons.ImportPaymentCreateButton.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            QuickProcessForm.Buttons.Ok.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            IntercompanyPurchase.IntercompanyPONbr.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            ServiceOrderParameters.Buttons.Ok.WaitAction = () => Wait.Wait.WaitForPageToLoad();
            ToolBar.CreateChildOrders.WaitAction = Wait.Wait.WaitForPageToLoad;

            ToolBar.PrepareInvoice.WaitAction = delegate
            {
                Wait.Wait.WaitForCallbackToComplete();
                Wait.Wait.WaitForPageToLoad();
            };

            ToolBar.ViewServiceOrder.WaitAction = Wait.Wait.WaitForNewWindowToOpen;

            Allocations.Row.RefNoteID.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);

            DocumentDetails.ToolBar.LineDetails.WaitAction = Wait.Wait.WaitForCallbackToComplete;
            DocumentDetails.ToolBar.AddInvoice.WaitAction = Wait.Wait.WaitForCallbackToComplete;
            DocumentDetails.ToolBar.AddItems.WaitAction = Wait.Wait.WaitForCallbackToComplete;

            CreatePaymentForm.Buttons.CreatePaymentAuthorizeButton.WaitAction = () => AwaitForCCOperation();
            CreatePaymentForm.Buttons.CreatePaymentCaptureButton.WaitAction = () => AwaitForCCOperation();
            Payments.ToolBar.VoidDocumentPayment.WaitAction = Wait.Wait.WaitForLongOperationToComplete;
            Payments.ToolBar.CaptureDocumentPayment.WaitAction = Wait.Wait.WaitForLongOperationToComplete;

            Payments.ToolBar.CreateOrderPrepayment.WaitAction = Wait.Wait.WaitForCallbackToComplete;
            Payments.ToolBar.CreateDocumentPayment.WaitAction = Wait.Wait.WaitForCallbackToComplete;
            Payments.Row.AdjgRefNbr.WaitAction = Wait.Wait.WaitForNewWindowToOpen;


            Action WaitAndMaximize = delegate
            {
                Wait.Wait.WaitForPageToLoad(true);
                MaximizeWindow();
            };

            Shipments.Row.ShippingRefNoteID.WaitAction = WaitAndMaximize;
            Shipments.Row.InvoiceNbr.WaitAction = WaitAndMaximize;
            Shipments.Row.InvtRefNbr.WaitAction = WaitAndMaximize;

            Taxes.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;

            ImportColumns.Buttons.Ok.WaitAction = () => Wait.Wait.WaitForLongOperationToComplete(Wait.Wait.LongTimeOut * 3);

            ShipmentParameters.Buttons.Ok.WaitAction = Wait.Wait.WaitForPageToLoad;

            ToolBar.EmailQuote.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.PrintQuote.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            ToolBar.MenuEditProj.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            QuickImport.LastRecord = LastRecordMethod.LastModified;
            QuickImport.Key = new[] { "SO", "SO003361" };
            QuickImport.SkipContainers = new[]
            {
                "LineDetails",
                "LineDetailsUnassignedQty",
                "PurchasingDetailsPurchasingSettings",
                "PaymentsPaymentTotal"
            };
            QuickImport.DisabledLines = new[]
            {
                "Details->OrderType",
                "Details->OrderNbr",
                "Details->LineNbr",
                "FinancialPaymentInformationOwnership->Workgroup",
                "FinancialFinancialInformation->TaxCalculationMode",
                "FinancialFinancialInformation->EntityUsageType"
            };
            QuickImport.ExcludeFields = new[]
            {
                "OrderSummary->OrderNbr",
                "OrderSummary->Status",
                "Totals->UnshippedQuantity",
                "Totals->UnshippedAmount",
                "Totals->UnbilledQuantity",
                "Totals->UnbilledAmount",
                "Totals->PaymentsTotal",
                "Totals->UnpaidBalance",
                "Details->OrderNbr",
                "Details->QtyOnShipments",
                "Details->OpenQty",
                "Details->UnbilledAmount",
                "Details->Completed",
                "Details->UnshippedQty",
                "InventoryLookupInventory->HistoryDate",
                "OrderSummary->ROTAndRUTDeductibleDocument",
                "Discounts->ManualDiscount",
                "Discounts->LineNbr",
                "OrderSummaryRateSelection->CurrRateTypeID",
                "OrderSummaryRateSelection->EffectiveDate",
                "ProcessOrder->CustomDate",
                "FinancialPaymentInformationOwnership->Workgroup",
                "Details->UnitCost",
                "FinancialFinancialInformation->EntityUsageType",
                "FinancialFinancialInformation->TaxCalculationMode"
            };
        }

        public void AddTransactionDetail(string InventoryID, string WarehouseID, decimal Qty, decimal UnitCost, string SubItemID = "")
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Enter new line - inventory id: " + InventoryID))
            {
                DocumentDetails.New();
                DocumentDetails.Row.InventoryID.Select(InventoryID);
                if (!string.IsNullOrEmpty(SubItemID)) DocumentDetails.Row.SubItemID.Type(SubItemID);
                DocumentDetails.Row.SiteID.Select(WarehouseID);
                DocumentDetails.Row.OrderQty.Type(Qty);
                DocumentDetails.Row.CuryUnitPrice.Type(UnitCost);
            }
        }

        public void ClickAllocations()
        {
            this.DocumentDetails.LineDetails();
        }

        public void ClickPoLink()
        {
            this.DocumentDetails.POSupplyOK();
        }

        public override void CreatePurchaseOrder()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Create purchase order"))
            {
                base.CreatePurchaseOrder();
                Wait.Wait.WaitForCallbackToComplete();
                Wait.Wait.WaitForPageToLoad();
            }
        }

        public void CreateShipmentIssue(string warehouse)
        {
            CreateShipmentIssue(new DateTime(), warehouse);
        }

        public void CreateShipmentIssue(DateTime shipmentDate, string warehouse, bool withLongWait = true)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Create shipment: " + shipmentDate + ", " + warehouse))
            {
                base.CreateShipmentIssue();

                if (shipmentDate != DateTime.MinValue) ShipmentParameters.ShipDate.Type(shipmentDate);
                if (warehouse != string.Empty) ShipmentParameters.SiteID.Select(warehouse);

                ShipmentParameters.Ok();
            }
        }

        public void CreateShipmentIssue(bool status, string message = "")
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Create shipment"))
            {
                base.CreateShipmentIssue();
                ShipmentParameters.Ok();
                if (status)
                {
                    Wait.Wait.WaitForPageToLoad();
                }
                else
                {
                    Wait.Wait.WaitForLongOperationToComplete(status, message);
                }
            }
        }

        public override void CreateShipmentIssue()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Create shipment"))
            {
                base.CreateShipmentIssue();
                if (ShipmentParameters.Buttons.Ok.IsEnabled()) ShipmentParameters.Ok();
                Wait.Wait.WaitForPageToLoad();
            }
        }

        public override void CreateShipmentReceipt()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Create receipt"))
            {
                base.CreateShipmentReceipt();
                ShipmentParameters.Ok();
                Wait.Wait.WaitForPageToLoad();
            }
        }

        public void CreateShipmentReceipt(DateTime shipmentDate, String warehouse)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Create receipt: " + shipmentDate + ", " + warehouse))
            {
                base.CreateShipmentReceipt();

                if (shipmentDate != DateTime.MinValue)
                {
                    ShipmentParameters.ShipDate.Type(shipmentDate);
                }

                ShipmentParameters.SiteID.Select(warehouse);

                ShipmentParameters.Ok();
            }
        }

        public void CreateShipmentReceipt(DateTime shipmentDate)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Create receipt: " + shipmentDate))
            {
                base.CreateShipmentReceipt();

                if (shipmentDate != DateTime.MinValue)
                {
                    ShipmentParameters.ShipDate.Type(shipmentDate);
                }

                ShipmentParameters.Ok();
                Wait.Wait.WaitForPageToLoad();
            }
        }

        public void AddInvoice(string refNbr, int lineNbr, int lastNumber = 0)
        {
            DocumentDetails.AddInvoice();
            AddInvoiceForm.RefNbr.Select(refNbr);
            for (int i = lineNbr; i <= Math.Max(lineNbr, lastNumber); ++i)
            {
                AddInvoiceForm.Grid.SelectRow(i);
                AddInvoiceForm.Grid.Row.Selected.SetTrue();
            }
            AddInvoiceForm.AddClose();
        }

        //public void Approve()
        //{
        //    base.DynamicControl<ToolBarButton>("Approve").Click();
        //}

        //public void Reject()
        //{
        //    base.DynamicControl<ToolBarButton>("Reject").Click();
        //}

        public class PoLinkForm
        {
            private readonly OrderSo _sorder;

            private Button cancel { get; set; }

            private Button save { get; set; }

            public PoLinkForm(OrderSo sorder)
            {
                _sorder = sorder;
                save = new Button("css=button[id$='_PXButton7']", null, null);
                cancel = new Button("css=button[id$='_PXButton8']", null, null);
            }

            public void Save()
            {
                save.Click();
            }

            public void Cancel()
            {
                cancel.Click();
            }

            public c_supplypolines_gridposupply Grid
            {
                get { return _sorder.SupplyPOLines_gridPOSupply; }
            }

            public c_posupply_gridposupplylegacy GridLegacy
            {
                get { return _sorder.Posupply_gridposupplylegacy; }
            }

            public c_solinedemand_formsolinedemand Filter
            {
                get { return _sorder.SOLineDemand_formSOLineDemand; }
            }
        }

        public class AddInvoiceForm_ex : c_addinvoicefilter_form4
        {
            public c_invoicesplits_grid4 Grid { get; private set; }
            public AddInvoiceForm_ex(string locator, string name, c_invoicesplits_grid4 grid)
                : base(locator, name)
            {
                Grid = grid;
            }
        }
    }
}
