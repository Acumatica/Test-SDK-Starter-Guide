using GeneratedWrappers.Acumatica;
using Api;
using Core.Attributes;
using Core.Exceptions;
using System;

namespace Core
{
    public partial class ReplenishmentClass : IN208800_INReplenishmentClassMaint
    {
        public c_classes_grid Details
        {
            get { return base.Classes_grid; }

        }

        
        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Create replenishment class: "
                                                                             +
                                                                             Details.Rows[0].ReplenishmentClassID.Value +
                                                                             " - " +
                                                                             Details.Rows[0].Descr.Value))
            {
                OpenScreen();
                Adjust();

                foreach (c_classes_grid.c_grid_row row in Details.Rows)
                {
                    // If class with this id is already exist, delete it
                    var exists = false;
                    try
                    {
                        Details.SelectRow("Class ID", row.ReplenishmentClassID.Value);
                        exists = true;
                    }
                    catch { }
                    if (exists)
                        Delete();

                    New();
                    row.ReplenishmentClassID.Type();
                    row.Descr.Type();
                    row.ReplenishmentSource.Select();
                }

                Save();
            }
        }

        
        public void Update()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Update replenishment class: "
                                                                             +
                                                                             Details.Rows[0].ReplenishmentClassID.Value +
                                                                             " - " +
                                                                             Details.Rows[0].Descr.Value))
            {
                OpenScreen();
                Adjust();

                foreach (c_classes_grid.c_grid_row row in Details.Rows)
                {
                    Details.ClickCell(Details.Rows[0].ReplenishmentClassID.Value);
                    row.Descr.Type();
                    row.ReplenishmentSource.Select();
                }

                Save();
            }
        }

        
        public void NegativeTest()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Negative test for replenishment class: "
                                                                             +
                                                                             Details.Rows[0].ReplenishmentClassID.Value +
                                                                             " - " +
                                                                             Details.Rows[0].Descr.Value))
            {
                try
                {
                    OpenScreen();
                    New();

                    foreach (c_classes_grid.c_grid_row row in Details.Rows)
                    {
                        row.ReplenishmentClassID.Type();
                        row.Descr.Type();
                        row.ReplenishmentSource.Select();
                    }

                    New();
                    Cancel();
                }
                catch (Exception e)
                {
                    if (e is AutotestException)
                    {
                        Cancel();
                    }
                    else
                    {
                        Log.Log.Screenshot();
                    }
                }
            }
        }

        
        public override void Delete()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Delete replenishment class: "
                                                                             +
                                                                             Details.Rows[0].ReplenishmentClassID.Value +
                                                                             " - " +
                                                                             Details.Rows[0].Descr.Value))
            {
                Details.ClickCell(Details.Rows[0].ReplenishmentClassID.Value);
                base.Delete();
                Save();
                Cancel();

                try
                {
                    Details.ClickCell(Details.Rows[0].ReplenishmentClassID.Value);
                    Log.Log.Error("Failed to delete replenishment class: " + Details.Rows[0].ReplenishmentClassID.Value);
                }
                catch
                {
                    Log.Log.Information("Replenishment class was removed: " + Details.Rows[0].ReplenishmentClassID.Value);
                }
            }
        }
    }
}
