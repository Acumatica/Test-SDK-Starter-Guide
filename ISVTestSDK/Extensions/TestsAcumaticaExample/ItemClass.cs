using System;
using GeneratedWrappers.Acumatica;
using OpenQA.Selenium;

namespace Core
{
    public partial class ItemClass : IN201000_INItemClassMaint
    {
        public c_replenishment_repgrid ReplenishmentSettings
        {
            get { return base.Replenishment_repgrid; }

        }

        public c_itemclasscurysettings_curysettingsformdefaultsite DefSiteSettings => base.Itemclasscurysettings_curysettingsformdefaultsite;

        public c_itemclasssettings_pxformview3 ReplenishmentSettingsDemandCalculation
        {
            get { return base.Itemclasssettings_pxformview3; }

        }

        public c_classunits_gridunits Conversions
        {
            get { return base.Classunits_gridunits; }

        }

        public c_groups_grid SubitemAndRestrictionGroups
        {
            get { return base.Groups_grid; }

        }

        public c_itemclass_form Summary
        {
            get { return base.Itemclass_form; }

        }

        public c_itemclasstree ItemClassesTree
        {
            get { return base.ItemClassTree; }

        }

        public c_mapping_attributesgrid Attributes
        {
            get { return base.Mapping_AttributesGrid; }

        }

        public c_itemclasssettings_tab GeneralSettings
        {
            get { return base.Itemclasssettings_tab; }

        }

        public c_changeiddialog_formchangeid ChangeIdDialog
        {
            get { return base.ChangeIDDialog_formChangeID; }
        }

        public c_itemclasssettings_formequipment ServiceManagementSettings
        {
            get { return Itemclasssettings_formequipment; }
        }

        public c_modeltemplatecomponentrecords_modeltemplatecomponents ModelTemplateComponents
        {
            get { return ModelTemplateComponentRecords_ModelTemplateComponents; }
        }

        public ItemClass()
        {
            QuickImport.SkipContainers = new[]
             {
                "ItemClassNodes",
                "Path"
            };

            QuickImport.ExcludeFields = new[]
            {
                "ItemClassNodes->Path",
                "ItemClassNodes->Text",
                "ItemClassNodes->Value",
                "GeneralGeneralSettings->TaxCalculationMode",
                "GeneralGeneralSettings->ExportToExternalSystem",
            };

            QuickImport.DisabledLines = new[]
            {
                "GeneralGeneralSettings->TaxCalculationMode",
                "GeneralGeneralSettings->ExportToExternalSystem",
            };
        }
    }
}
