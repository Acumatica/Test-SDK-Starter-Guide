using Api;
using Controls.Alert;
using Controls.DefaultControl;
using Controls.Editors.Selector;
using Controls.Input;
using Controls.SmartPanel;
using Core.Attributes;
using Core.Exceptions;
using GeneratedWrappers.Acumatica;
using System;

namespace Core
{
    public partial class StockItem : IN202500_InventoryItemMaint
    {
        private readonly Lazy<Features> _featureLazy = new Lazy<Features>(() =>
        {
            var features = new Features();
            features.ReadOne(ApiConnection.ApiConnection.Destination, string.Empty);
            return features;
        });

        private Features features => _featureLazy.Value;

        public c_vendorinventory_updateprice_formeffectivedate UpdateEffectiveVendorPrices
        {
            get { return base.VendorInventory_UpdatePrice_formEffectiveDate; }
        }

        public c_vendoritems_pxgridvendoritems VendorDetails
        {
            get { return base.VendorItems_PXGridVendorItems; }
        }

        public c_replenishment_repgrid ReplenishmentParameters
        {
            get { return base.Replenishment_repgrid; }
        }

        public c_answers_pxgridanswers Attributes
        {
            get { return base.Answers_PXGridAnswers; }
        }

        public c_category_pxgridcategory SalesCategory
        {
            get { return base.Category_PXGridCategory; }
        }

        public c_groups_grid3 SubitemGroups
        {
            get { return base.Groups_grid3; }
        }

        public c_item_form Summary
        {
            get { return base.Item_form; }
        }

        public c_itemsettings_tab Tabs
        {
            get { return base.ItemSettings_tab; }
        }

        public c_itemunits_gridunits_ex Conversions { get; set; }

        public c_itemsiterecords_grid2 WarehouseDetails
        {
            get { return base.Itemsiterecords_grid2; }
        }

        public c_itemxrefrecords_crossgrid CrossReference
        {
            get { return base.Itemxrefrecords_crossgrid; }
        }

        public c_vendoritems_pxgridvendoritems ReplenishmentInformation
        {
            get { return base.VendorItems_PXGridVendorItems; }
        }

        public c_components_pxgridcomponents Components
        {
            get { return Components_PXGridComponents; }
        }

        public c_itemsettings_formdr DeferredRevenue
        {
            get { return base.ItemSettings_formDR; }
        }

        public c_groups_grid3 RestrictionGroups
        {
            get { return base.Groups_grid3; }
        }

        public c_boxes_pxgridboxes Boxes
        {
            get { return base.Boxes_PXGridBoxes; }
        }

        public c_subitem_1_gridsubitem0 MainCostLayer
        {
            get { return base.SubItem_1_gridSubItem0; }
        }

        public c_subitem_2_gridsubitem1 CostSublayer
        {
            get { return base.SubItem_2_gridSubItem1; }
        }

        public c_itemcosts_formcoststats ItemCosts
        {
            get { return base.Itemcosts_formcoststats; }
        }

        public c_inventoryfileurls_gridinventoryfileurls MediaURLS
        {
            get { return base.InventoryFileUrls_gridInventoryFileUrls; }
        }

        public c_itemsettings_formsm ServiceManagement
        {
            get { return ItemSettings_formSM; }
        }

        public c_modelcomponents_gridcomponents ComponentsGrid
        {
            get { return ModelComponents_gridComponents; }
        }

        public c_relateditems_relateditemsgrid RelatedItems => base.RelatedItems_relatedItemsGrid;
        public c_relateditems_importxlsxsettings_frmimportxlsxsettings RelatedItemsExcelImportSettings => base.RelatedItems_ImportXLSXSettings_frmImportXLSXSettings;
        public c_relateditems_importcsvsettings_frmimportcsvsettings RelatedItemsCsvImportSettings => base.RelatedItems_ImportCSVSettings_frmImportCSVSettings;
        public c_relateditems_importcolumns_grdimportcolumn RelatedItemsImportColumns => base.RelatedItems_ImportColumns_grdImportColumn;
        public c_changeiddialog_formchangeid ChangeIDMenu => base.ChangeIDDialog_formChangeID;

        public c_curysettings_inventoryitem_curysettingsform PriceSettings => CurySettings_InventoryItem_curySettingsForm;
        public c_curysettings_inventoryitem_curysettingsformdefaultsite DefSite => CurySettings_InventoryItem_CurySettingsFormDefaultSite;
        public c_curysettings_inventoryitem_curysettingsform2 StandardCost => CurySettings_InventoryItem_curySettingsForm2;

        public c_syncrecs_syncgrid SyncStatus => base.SyncRecs_syncGrid;
        public c_itemunits_gridunits Units => base.Itemunits_gridunits;
        public c_itemsettings_tab GLAccounts => ItemSettings_tab;

        public StockItem()
        {
            FileName = "Stock Items";
            Conversions = new c_itemunits_gridunits_ex(Itemunits_gridunits.Locator, Itemunits_gridunits.ControlName);
            ToolBar.ViewSummary.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            ToolBar.ViewTransactionDetails.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            ToolBar.ViewTransactionHistory.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            ToolBar.Save.ConfirmAction = Alert.AlertToException;
            ToolBar.ViewAllocationDetails.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            ToolBar.ManageCustomizations.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            RelatedItems.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;

            QuickImport.ReplaceKey = "STQI";
            QuickImport.SkipContainers = new[]
            {
                "Vendors",
                "Warehouses"
            };
            QuickImport.ExcludeFields = new[]
            {
                "PriceCostCostStatistics->LastCost",
                "PriceCostCostStatistics->AverageCost",
                "PriceCostCostStatistics->MinCost",
                "PriceCostCostStatistics->MaxCost"
            };
            QuickImport.DisabledLines = new[]
            {
                "GeneralItemDefaults->DefaultSubitem",
                "GeneralItemDefaults->UseOnEntry",
                "CrossReference->Subitem",
                "ECommerce->ExportToExternalSystem",
            };
        }

        #region Nested type: c_itemunits_gridunits_ex

        public class c_itemunits_gridunits_ex : c_itemunits_gridunits
        {
            public c_itemunits_gridunits_ex(String locator, String name)
                : base(locator, name)
            {
            }

            public override void New()
            {
                ClickAndAddNewRow();
            }
        }

        #endregion

        public override void ConfigureImportScenario()
        {
            var importScenario = new ImportScenario();
            importScenario.OpenScreen();
            importScenario.Summary.Name.Select(ImportScenarioName);
            importScenario.Save();
            importScenario.Mapping.Adjust();

            bool workgrpoupId;

            try
            {
                workgrpoupId = new ExtendedBiObject<Employee>(ApiConnection.ApiConnection.Destination).ReadOne("EP00000001").CompanyTree.Rows.Count > 0;
            }
            catch (Exception)
            {
                workgrpoupId = false;
            }

            importScenario.Mapping.Columns.Value.Contains("WorkGroup");
            for (int i = 1; i <= 2; ++i)
            {
                importScenario.Mapping.SelectRow(i);
                importScenario.Mapping.Row.IsActive.Set(workgrpoupId);
            }
            importScenario.Save();
            importScenario.Mapping.Columns.Value.ClearFilter();

            var features = new Features();
            features.ReadOne(ApiConnection.ApiConnection.Destination, string.Empty);
            importScenario.Mapping.Columns.FieldName.StartsWith("LotSer");
            importScenario.Mapping.SelectRow("Field / Action Name", "LotSerClassID");
            importScenario.Mapping.Row.ObjectName.Select("General -> Item Defaults");
            importScenario.Mapping.Row.IsActive.Set(features.Summary.LotSerialTracking.Value);
            importScenario.Save();
        }
    }
}
