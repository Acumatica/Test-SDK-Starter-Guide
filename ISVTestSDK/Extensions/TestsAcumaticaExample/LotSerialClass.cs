using Api;
using GeneratedWrappers.Acumatica;
using System;

namespace Core
{
    public partial class LotSerialClass : IN207000_INLotSerClassMaint
    {
        public c_lotserclass_form Summary
        {
            get { return base.Lotserclass_form; }
        }

        public c_lotsersegments_grid Details
        {
            get { return base.Lotsersegments_grid; }
        }

        public LotSerialClass()
        {
            
        }

        public void Select()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Select Lot Serial Class"))
            {
                OpenScreen();
                Summary.LotSerClassID.Select();
            }
        }

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Add Lot Serial Class"))
            {
                OpenScreen();
                Insert();
                Summary.LotSerClassID.Type();
                AddSummary();
                AddDetails();
                Save();
            }
        }

        public void Update()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Update Lot Serial Class"))
            {
                Select();
                AddSummary();
                AddDetails();
                Save();
            }
        }

        private void AddSummary()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Add Summary"))
            {
                Summary.Descr.Type();
                if (Summary.LotSerTrack.IsEnabled()) Summary.LotSerTrack.Select();
                Summary.LotSerTrackExpiration.Set();
                Summary.LotSerAssign.Select();

                if (Summary.LotSerAssign.Value == "R" || Summary.LotSerAssign.Value == Summary.LotSerAssign.Items["R"])
                    Summary.LotSerIssueMethod.Select();

                Summary.LotSerNumShared.Set();

                if (Summary.LotSerNumShared.Value)
                {
                    Summary.LotSerNumVal.Type();
                }

                Summary.LotSerNumShared.Set();
            }
        }

        private void AddDetails()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Add Details"))
            {
                if (Details.HasRows())
                {
                    Details.SelectAllRecords();
                    Details.Delete();
                }

                Details.New();

                foreach (var row in Details.Rows)
                {
                    if (Details.ToolBar.New.IsEnabled())
                    {
                        Details.New();
                    }

                    row.SegmentType.Select();

                    if (row.SegmentType.Value.Equals("C") || row.SegmentType.Value.Equals("D"))
                    {
                        row.SegmentValue.Type();
                        row.SegmentValue.PressEnter();
                    }
                    else
                    {
                        row.SegmentType.PressEnter();
                    }
                }
            }
        }

        public void SetAutoIncrementalValue(String Value)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Set auto-incremental value: " + Value))
            {
                Select();
                Summary.LotSerNumShared.SetTrue();
                Summary.LotSerNumVal.Type(Value);
                Summary.LotSerNumShared.Set();
                Save();
            }
        }
    }
}
