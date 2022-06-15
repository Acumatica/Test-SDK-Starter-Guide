using GeneratedWrappers.Acumatica;

namespace Core
{
    public class Discount : AR209500_ARDiscountSequenceMaint
    {
        public c_sequence_form Summary => base.Sequence_form;
        public c_details_grid Details => base.Details_grid;
        public c_sites_sitesgrid Warehouses => base.Sites_sitesGrid;
        public c_customers_customersgrid Customers => base.Customers_customersGrid;
        public c_items_itemsgrid Items => base.Items_itemsGrid;
        public c_currentsequence_form2 FreeItem => base.CurrentSequence_form2;
        public c_inventorypriceclasses_inventorypriceclassgrid InventoryPriceClasses => base.InventoryPriceClasses_inventoryPriceClassGrid;
        public c_customerpriceclasses_customerpriceclassgrid CustomerPriceClasses => base.CustomerPriceClasses_customerPriceClassGrid;
        public c_branches_branchesgrid Branches => base.Branches_branchesGrid;
        public c_updatesettings_formupdatesettings UpdateSettings => base.UpdateSettings_formUpdateSettings;

        public Discount()
        {
            FileName = "Discounts";
            ToolBar.UpdateDiscounts.WaitAction = Wait.Wait.WaitForCallbackToComplete;
            Details.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Items.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
        }
    }
}
