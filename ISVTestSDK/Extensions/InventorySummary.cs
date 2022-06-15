
using Core.Core.Browser;
using ISVTestSDK.Extensions;
using System;

namespace Core
{
    public class InventorySummary : IN401000_InventorySummaryEnq
    {
        public c_filter_form Summary
        {
            get { return base.Filter_form; }
        }

        public c_iserecords_grid Details
        {
            get { return base.ISERecords_grid; }
        }

        public InventorySummary()
        {
            Details.Row.InventoryID.WaitAction = Wait.Wait.WaitForPageToLoad;
        }

        public void SetFilter()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Set filter"))
            {
                OpenScreen();

                if (!Summary.InventoryID.GetValue().Equals(Summary.InventoryID.Value))
                {
                    try
                    {
                        Summary.InventoryID.Select();
                    }
                    catch
                    {
                        Log.Log.Information("Failed to select value: " + Summary.InventoryID.Value + ", in selector: " +
                                        Summary.InventoryID.ControlName);
                        Summary.InventoryID.Type();
                    }
                }

                if (Summary.SubItemCD.IsVisible())
                {
                    if (!Summary.SubItemCD.GetValue().Equals(Summary.SubItemCD.Value))
                    {
                        if (String.IsNullOrEmpty(Summary.SubItemCD.Value))
                        {
                            Summary.SubItemCD.Reset();
                        }
                        else
                        {
                            Summary.SubItemCD.Type();
                        }
                    }
                }

                if (!Summary.SiteID.GetValue().Equals(Summary.SiteID.Value))
                {
                    if (String.IsNullOrEmpty(Summary.SiteID.Value))
                    {
                        Summary.SiteID.Reset();
                    }
                    else
                    {
                        Summary.SiteID.Select();
                    }
                }

                if (!Summary.LocationID.GetValue().Equals(Summary.LocationID.Value))
                {
                    if (!String.IsNullOrEmpty(Summary.LocationID.GetValue()) && Summary.LocationID.Value == null)
                    {
                        Summary.LocationID.Reset();
                        Summary.LocationID.PressEnter();
                    }
                    else
                    {
                        Summary.LocationID.Select();
                    }
                }

                Summary.SubItemCD.Type();

                if (!Summary.ExpandByLotSerialNbr.GetValue().Equals(Summary.ExpandByLotSerialNbr.Value))
                {
                    Summary.ExpandByLotSerialNbr.Set();
                }
                Details.ResetColumnFilters();
            }
        }

        public void SetFilter(string inventoryId, string warehouseId, string locationId, bool expand, string subItem)
        {
            Summary.InventoryID.Value = inventoryId;
            Summary.SiteID.Value = warehouseId;
            Summary.LocationID.Value = locationId;
            Summary.ExpandByLotSerialNbr.Value = expand;
            Summary.SubItemCD.Value = subItem;
            Details.Row.InventoryID.WaitAction = () => Wait.Wait.WaitForPageToLoad(Wait.Wait.LongTimeOut * 3, true);
            SetFilter();
        }

        public void CheckDetailsData()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Check Details Data"))
            {
                Adjust();
                Boolean result = false;
                String message = String.Empty;
                int position = 1, finish = Details.RowsCount();
                Boolean trigger = false;

                foreach (c_iserecords_grid.c_grid_row row in Details.Rows)
                {
                    using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Current inventory summary detail"))
                    {
                    Start:

                        for (int i = position; i <= finish; i++)
                        {
                            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Looking for current inventory summary detail"))
                            {
                                message = "to find detail. ";
                                result = true;
                                Details.SelectRow(i);

                                #region Inventory ID

                                if (!String.IsNullOrEmpty(row.InventoryID.Value))
                                {
                                    if (!Details.Row.InventoryID.GetValue().
                                                 Equals(row.InventoryID.Value.Trim()))
                                    {
                                        result = result && false;
                                    }
                                    message = message + Details.Columns.InventoryID.ControlName
                                              + ": " + row.InventoryID.Value.Trim() + "; ";
                                }

                                #endregion

                                #region Warehouse ID

                                if (!String.IsNullOrEmpty(row.SiteID.Value))
                                {
                                    if (!Details.Row.SiteID.GetValue().
                                                 Equals(row.SiteID.Value.Trim()))
                                    {
                                        result = result && false;
                                    }
                                    message = message + Details.Columns.SiteID.ControlName
                                              + ": " + row.SiteID.Value.Trim() + "; ";
                                }

                                #endregion

                                #region Location ID

                                if (!String.IsNullOrEmpty(row.LocationID.Value))
                                {
                                    if (!Details.Row.LocationID.GetValue().
                                                 Equals(row.LocationID.Value.Trim()))
                                    {
                                        result = result && false;
                                    }
                                    message = message + Details.Columns.LocationID.ControlName
                                              + ": " + row.LocationID.Value.Trim() + "; ";
                                }

                                #endregion

                                #region Quantity On Hand

                                if (!String.IsNullOrEmpty(row.QtyOnHand.Value))
                                {
                                    if (Convert.ToDecimal(Details.Row.QtyOnHand.GetValue())
                                        != Convert.ToDecimal(row.QtyOnHand.Value))
                                    {
                                        result = result && false;
                                    }
                                    message = message + Details.Columns.QtyOnHand.ControlName
                                              + ": " + row.QtyOnHand.Value.Trim() + "; ";
                                }

                                #endregion

                                #region Unit Cost Estimated

                                if (!String.IsNullOrEmpty(row.UnitCost.Value))
                                {
                                    if (Convert.ToDecimal(Details.Row.UnitCost.GetValue())
                                        != Convert.ToDecimal(row.UnitCost.Value))
                                    {
                                        result = result && false;
                                    }
                                    message = message + Details.Columns.UnitCost.ControlName
                                              + ": " + row.UnitCost.Value.Trim() + "; ";
                                }

                                #endregion

                                #region Cost Total Estimated

                                if (!String.IsNullOrEmpty(row.TotalCost.Value))
                                {
                                    if (Convert.ToDecimal(Details.Row.TotalCost.GetValue())
                                        != Convert.ToDecimal(row.TotalCost.Value))
                                    {
                                        result = result && false;
                                    }
                                    message = message + Details.Columns.TotalCost.ControlName
                                              + ": " + row.TotalCost.Value.Trim() + "; ";
                                }

                                #endregion

                                #region Lot/Serial NumberNbr

                                if (!String.IsNullOrEmpty(row.LotSerialNbr.Value))
                                {
                                    if (!Details.Row.LotSerialNbr.GetValue().Equals(row.LotSerialNbr.Value))
                                    {
                                        result = result && false;
                                    }
                                    message = message + Details.Columns.LotSerialNbr.ControlName
                                              + ": " + row.LotSerialNbr.Value.Trim() + "; ";
                                }

                                #endregion

                                if (result)
                                {
                                    Log.Log.Information("Succed " + message);
                                    position = i + 1;
                                    break;
                                }
                            }
                        }

                        if (!result)
                        {
                            if (trigger)
                            {
                                Log.Log.Error("Failed " + message);
                                trigger = false;
                                finish = Details.RowsCount();
                            }
                            else
                            {
                                trigger = true;
                                finish = position;
                                position = 1;
                                goto Start;
                            }
                        }
                    }
                }

                Details.Rows.Clear();
            }
        }
    }
}
