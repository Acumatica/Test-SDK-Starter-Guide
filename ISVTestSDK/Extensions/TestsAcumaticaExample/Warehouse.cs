using Api;
using GeneratedWrappers.Acumatica;
using System;
using System.Linq;

namespace Core
{
    public partial class Warehouse : IN204000_INSiteMaint
    {
        public c_siteaccounts_tab WarehouseManufacturingTab => Siteaccounts_tab;

        public c_contact_colform Contact
        {
            get { return base.Contact_colForm; }
        }

        public c_location_importxlsxsettings_frmimportxlsxsettings ExcelImportSettings
        {
            get { return base.Location_importxlsxsettings_frmimportxlsxsettings; }
        }

        public c_location_importcolumns_grdimportcolumn ImportColumns
        {
            get { return base.Location_importcolumns_grdimportcolumn; }
        }

        public c_address_addrform Address
        {
            get { return base.Address_addrForm; }
        }

        public c_siteaccounts_tab DefaultLocations
        {
            get { return base.Siteaccounts_tab; }
        }

        public c_location_grid Locations
        {
            get { return base.Location_grid; }
        }

        public c_carts_gridcarts Carts
        {
            get { return base.Carts_gridcarts; }
        }
        public c_totes_gridtotes Totes
        {
            get { return base.Totes_gridtotes; }
        }
        public c_site_form Summary
        {
            get { return base.Site_form; }
        }

        public c_siteaccounts_tab Accounts
        {
            get { return base.Siteaccounts_tab; }
        }

        public c_siteaccounts_buildform Buildings
        {
            get { return base.Siteaccounts_buildform; }
        }

        public c_addresslookupfilter_addresslookuppanelformaddress AutocompletePanel => AddressLookupFilter_AddressLookupPanelformAddress;
        public c_siteaccounts_formcarrierfacility CarrierFacility => Siteaccounts_formcarrierfacility;

        public Warehouse()
        {
            FileName = "Warehouse";

            QuickImport.SkipContainers = new[]
            {
                "LocationsLocationTable"
            };
        }

        public void Select()
        {
            OpenScreen();
            Summary.SiteCD.Select();
        }

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Create warehouse: " + Summary.SiteCD.Value))
            {
                OpenScreen();
                Insert();
                Summary.SiteCD.Type();
                Process();
            }
        }


        public void Update()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Update warehouse: " + Summary.SiteCD.Value))
            {
                Select();
                Process();
            }
        }

        private void Process()
        {
            AddSummary();
            AddLocations();
            AddGlAccounts();
            AddAddress();
            AddContact();
            Save();
            AddDefaultLocations();
            Save();
        }

        public override void Delete()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Delete warehouse: " + Summary.SiteCD.Value))
            {
                Select();
                try
                {
                    base.Delete();
                }
                catch (OpenQA.Selenium.UnhandledAlertException exc)
                when (exc.Message.Contains("PX.Objects.IN.INSite cannot be deleted because it is referenced in the following record: Inventory Item"))
                {
                    Log.Log.Information(exc.ToString());
                    return;
                }

                try
                {
                    Select();
                    Log.Log.Error("Failed to delete warehouse: " + Summary.SiteCD.Value);
                }
                catch
                {
                    Log.Log.Information("Warehouse was deleted: " + Summary.SiteCD.Value);
                }
            }
        }

        private void AddSummary()
        {
            Summary.LocationValid.Select();
            Summary.ReplenishmentClassID.Select();
            Summary.Descr.Type();
            Summary.AvgDefaultCost.Select();
            Summary.FIFODefaultCost.Select();
        }

        private void AddDefaultLocations()
        {
            DefaultLocations.ReceiptLocationID.Select();
            DefaultLocations.ShipLocationID.Select();
            DefaultLocations.ReturnLocationID.Select();
            DefaultLocations.DropShipLocationID.Select();
        }

        private void AddLocations()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Add Locations"))
            {
                Locations.Refresh();
                Locations.Adjust();
                if (Locations.HasRows())
                {
                    Locations.New();
                    Locations.Row.LocationCD.Type("TESTLOC");
                    Locations.Row.Descr.Type("Test Location");
                    Save();
                    Locations.SelectRow(Locations.Columns.LocationCD, "TESTLOC");
                    Locations.Delete();
                    Save();
                    /*
                    int rnd = new Random().Next(0, Locations.RowsCount() - 1);

                    if (Locations.PageIndex() != 0)
                    {
                        Locations.PageFirst();
                    }

                    for (int pageNbr = 0; pageNbr < Locations.PageCount(); pageNbr++)
                    {


                        try
                        {
                            Locations.ClickCell(Locations.Rows[rnd].LocationCD.Value.Trim());
                            Locations.Delete();
                            break;
                        }
                        catch
                        {
                            if (Locations.ToolBar.PageNext.IsEnabled())
                            {
                                Locations.PageNext();
                            }
                            else
                            {
                                Log.Log.Error("Failed to find location: " + Locations.Rows[rnd]);
                            }
                        }
                    }

                    Save();
                    AddLocation(Locations.Rows[rnd]);
                    Save();
                    */
                }
                else
                {
                    foreach (c_location_grid.c_grid_row location in Locations.Rows)
                    {
                        try
                        {
                            AddLocation(location);
                        }
                        catch
                        {
                            AddLocation(location);
                        }
                    }
                }
            }
        }

        public void AddLocation(c_location_grid.c_grid_row location)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Add location: " + location.LocationCD.Value))
            {
                Boolean locationExists = false;

                if (Locations.PageIndex() != 0)
                {
                    Locations.PageFirst();
                }

                for (int pageNbr = 0; pageNbr < Locations.PageCount(); pageNbr++)
                {
                    try
                    {
                        Locations.ClickCell(location.LocationCD.Value.Trim());
                        locationExists = true;
                        break;
                    }
                    catch
                    {
                        if (Locations.ToolBar.PageNext.IsEnabled())
                        {
                            Locations.PageNext();
                        }
                    }
                }

                if (!locationExists)
                {
                    Locations.New();
                    location.LocationCD.Type();
                }

                location.Descr.Type();
                location.InclQtyAvail.Set();
                location.IsCosted.Set();
                location.SalesValid.Set();
                location.ReceiptsValid.Set();
                location.TransfersValid.Set();
                location.PrimaryItemValid.Select();
                location.PickPriority.Type();

                try
                {
                    location.PrimaryItemID.Select();

                    if (location.PrimaryItemID.GetValue() != location.PrimaryItemID.Value.Trim())
                    {
                        location.PrimaryItemID.Type();
                    }
                }
                catch
                {
                }

                location.PrimaryItemClassID.Select();
            }
        }

        public void AddGlAccounts()
        {
            Accounts.InvtAcctID.Select();
            //Accounts.InvtAcctIDEdit();
            //CloseWindow();
            Accounts.SalesAcctID.Select();
            //Accounts.SalesAcctIDEdit();
            //CloseWindow();
            Accounts.COGSAcctID.Select();
            //Accounts.COGSAcctIDEdit();
            //CloseWindow();
            Accounts.StdCstRevAcctID.Select();
            //Accounts.StdCstRevAcctIDEdit();
            //CloseWindow();
            Accounts.StdCstVarAcctID.Select();
            //Accounts.StdCstVarAcctIDEdit();
            //CloseWindow();
            Accounts.POAccrualAcctID.Select();
            //Accounts.POAccrualAcctIDEdit();
            //CloseWindow();
            Accounts.PPVAcctID.Select();
            //Accounts.PPVAcctIDEdit();
            //CloseWindow();
            Accounts.LCVarianceAcctID.Select();
            //Accounts.LCVarianceAcctIDEdit();
            //CloseWindow();
            AddGlSubAccounts();
        }

        private void AddGlSubAccounts()
        {
            Accounts.InvtSubID.Type();
            Accounts.ReasonCodeSubID.Type();
            Accounts.SalesSubID.Type();
            Accounts.COGSSubID.Type();
            Accounts.StdCstVarSubID.Type();
            Accounts.StdCstRevSubID.Type();
            Accounts.POAccrualSubID.Type();
            Accounts.PPVSubID.Type();
            Accounts.LCVarianceSubID.Type();
        }

        private void AddContact()
        {
            Contact.FullName.Type();
            Contact.Attention.Type();
            Contact.EMail.Type();
            Contact.WebSite.Type();
            Contact.Phone1.Type();
            Contact.Phone2.Type();
            Contact.Fax.Type();
        }

        public void AddAddress()
        {
            Address.AddressLine1.Type();
            Address.AddressLine2.Type();
            Address.City.Type();
            Address.CountryID.Select();
            Address.State.Select();
            Address.PostalCode.Type();
        }

        public void SetPickPriority(string location, int priority)
        {
            for (int i = 1; i <= Locations.PageCount(); i++)
            {
                Locations.SelectRow(Locations.Columns.LocationCD, location);
            }
        }

        public override void ConfigureImportScenario()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION,
                "Configure import scenario: " + ImportScenarioName))
            {
                var importScenario = new ImportScenario();
                importScenario.OpenScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);
                importScenario.Save();
                importScenario.Mapping.Adjust();
                bool updateReplenishmentClass;

                try
                {
                    updateReplenishmentClass =
                        new ExtendedBiObject<ReplenishmentClass>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    updateReplenishmentClass = false;
                }

                importScenario.Mapping.ClickCell("Replenishment Class");
                importScenario.Mapping.Row.IsActive.Set(updateReplenishmentClass);
                importScenario.Save();

                bool updatePrimaryItem;

                try
                {
                    updatePrimaryItem =
                        new ExtendedBiObject<StockItem>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    updatePrimaryItem = false;
                }

                importScenario.Mapping.ClickCell("Primary Item");
                importScenario.Mapping.Row.IsActive.Set(updatePrimaryItem);
                importScenario.Save();
            }
        }
    }
}
