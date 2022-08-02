using Api;
using GeneratedWrappers.Acumatica;
using System;
using System.Linq;

namespace Core
{
    public partial class NonStockItem : IN202000_NonStockItemMaint
    {
        public c_item_form Summary => base.Item_form;
        public c_itemsettings_tab GeneralSettings => base.ItemSettings_tab;
        public c_curysettings_inventoryitem_curysettingsform BasePrice => base.CurySettings_InventoryItem_curySettingsForm;
        public c_curysettings_inventoryitem_curysettingsform2 StdPrice => base.CurySettings_InventoryItem_curySettingsForm2;
        public c_itemunits_gridunits Conversions => base.Itemunits_gridunits;
        public c_components_pxgridcomponents Components => Components_PXGridComponents;
        public c_itemsettings_formdr DeferredRevenue => base.ItemSettings_formDR;
        public c_vendoritems_pxgridvendoritems VendorDetails => base.VendorItems_PXGridVendorItems;
        public c_answers_pxgridanswers Attributes => base.Answers_PXGridAnswers;
        public c_category_pxgridcategory SalesCategory => base.Category_PXGridCategory;
        public c_itemsettings_tab Tabs => base.ItemSettings_tab;
        public c_itemxrefrecords_crossgrid CrossReference => base.Itemxrefrecords_crossgrid;
        public c_relateditems_relateditemsgrid RelatedItems => base.RelatedItems_relatedItemsGrid;
        public c_relateditems_importxlsxsettings_frmimportxlsxsettings RelatedItemsExcelImportSettings => base.RelatedItems_ImportXLSXSettings_frmImportXLSXSettings;
        public c_relateditems_importcsvsettings_frmimportcsvsettings RelatedItemsCsvImportSettings => base.RelatedItems_ImportCSVSettings_frmImportCSVSettings;
        public c_relateditems_importcolumns_grdimportcolumn RelatedItemsImportColumns => base.RelatedItems_ImportColumns_grdImportColumn;
        public c_syncrecs_syncgrid SyncStatus => base.SyncRecs_syncGrid;
        public c_inventoryfileurls_gridinventoryfileurls MediaURLS => base.InventoryFileUrls_gridInventoryFileUrls;
        public c_itemsettings_tab CostAccrual => ItemSettings_tab;
        public c_curysettings_inventoryitem_curysettingsformdefaultsite DefSite => CurySettings_InventoryItem_CurySettingsFormDefaultSite;
        public c_curysettings_inventoryitem_curysettingsform2 InventoryitemSettings => CurySettings_InventoryItem_curySettingsForm2;
        public c_serviceskills_gridserviceskills Skills => base.ServiceSkills_gridServiceSkills;
        public c_servicelicensetypes_gridservicelicensetypes LicenseTypes => base.ServiceLicenseTypes_gridServiceLicenseTypes;
        public c_serviceequipmenttypes_gridserviceequipmenttypes ResourceEquipmentTypes => base.ServiceEquipmentTypes_gridServiceEquipmentTypes;
        public c_serviceinventoryitems_gridpickdeliver PickupDeliveryItems => base.ServiceInventoryItems_gridPickDeliver;

        public NonStockItem()
        {
            RelatedItems.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            FileName = "Non-Stock Items";

            QuickImport.Key = new[]
            {
                "ACCOMODATE"
            };

            QuickImport.SkipContainers = new[]
            {
                "Vendors"
            };

            QuickImport.ExcludeFields = new[]
            {
                "PriceCostRUTandRUTSettings->TypeRUTROTType",
                "PriceCostRUTandRUTSettings->ROTOrRUTDeductibleItem",
                "GeneralItemDefaults->TaxCalculationMode",
        };

            QuickImport.DisabledLines = new[]
            {
                "GeneralItemDefaults->TaxCalculationMode",
                "ECommerce->ExportToExternalSystem",
            };
        }

        public override void Save()
        {
            string ExpenseAccrualAccount = Tabs.InvtAcctID.GetValue();

            if (ExpenseAccrualAccount.Split().First().Equals("120000"))
            {
                Tabs.InvtAcctID.Select("500000");
            }

            base.Save();
        }

        public override void ConfigureImportScenario()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Configure import scenario: " + ImportScenarioName))
            {
                var importScenario = new ImportScenario();
                importScenario.OpenScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);
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

                importScenario.Mapping.ClickCell("ProductWorkgroup");
                importScenario.Mapping.Row.IsActive.Set(workgrpoupId);
                importScenario.Mapping.ClickCell("PriceWorkgroup");
                importScenario.Mapping.Row.IsActive.Set(workgrpoupId);
                importScenario.Save();

                bool manager;

                try
                {
                    manager = new ExtendedBiObject<Employee>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    manager = false;
                }

                importScenario.Mapping.ClickCell("ProductManager");
                importScenario.Mapping.Row.IsActive.Set(manager);
                importScenario.Mapping.ClickCell("PriceManager");
                importScenario.Mapping.Row.IsActive.Set(manager);
                importScenario.Save();

                bool deferalCode;

                try
                {
                    deferalCode = new ExtendedBiObject<DeferredCode>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    deferalCode = false;
                }

                importScenario.Mapping.ClickCell("DeferralCode");
                importScenario.Mapping.Row.IsActive.Set(deferalCode);
                importScenario.Mapping.ClickCell("DeferralCode_DeferredRevenueRevenueComponents");
                importScenario.Mapping.Row.IsActive.Set(deferalCode);
                importScenario.Save();

                bool warehouses;

                try
                {
                    warehouses = new ExtendedBiObject<Warehouse>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    warehouses = false;
                }

                importScenario.Mapping.ClickCell("DefaultWarehouse");
                importScenario.Mapping.Row.IsActive.Set(warehouses);
                importScenario.Save();
            }
        }
    }
}
