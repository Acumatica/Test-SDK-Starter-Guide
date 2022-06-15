using Controls.Editors.DateSelector;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class WorkCalendar : CS209000_CSCalendarMaint
    {
        public c_calendar_frmheader Summary
        {
            get { return base.Calendar_frmHeader; }
            
        }

        public c_calendardetails_tab GeneralSettings
        {
            get { return base.CalendarDetails_tab; }
            
        }

        public c_cscalendarexceptions_gridexceptions Exceptions
        {
            get { return base.CSCalendarExceptions_gridExceptions; }
            
        }

        public c_amcalendarbreaktimes_gridbreaktimes BreakTimes => AMCalendarBreakTimes_gridBreakTimes;

        public WorkCalendar()
        {
            
        }

        public static void SetUTCTimeZoneSystemWide() => Support.GetSite().RunSqlScript("update CSCalendar set TimeZone = 'GMTE0000U'; update UserPreferences set TimeZone = 'GMTE0000U';");

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Create calendar: " + Summary.CalendarID.Value))
            {
                OpenScreen();
                Insert();
                Summary.CalendarID.Type();
                Process();
                Save();
            }
        }

        
        public void Update()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Create calendar: " + Summary.CalendarID.Value))
            {
                OpenScreen();
                Summary.CalendarID.Select();
                Process();
                Save();
            }
        }

        private void Process()
        {
            Summary.Description.Type();

            #region Sunday

            GeneralSettings.SunWorkDay.Set();
            if (GeneralSettings.SunWorkDay.Value)
            {
                GeneralSettings.SunStartTime.Type(DateSelector.Options.Time);
                GeneralSettings.SunEndTime.Type(DateSelector.Options.Time);
            }
            GeneralSettings.SunGoodsMoves.Set();

            #endregion

            #region Monday

            GeneralSettings.MonWorkDay.Set();
            if (GeneralSettings.MonWorkDay.Value)
            {
                GeneralSettings.MonStartTime.Type(DateSelector.Options.Time);
                GeneralSettings.MonEndTime.Type(DateSelector.Options.Time);
            }
            GeneralSettings.MonGoodsMoves.Set();

            #endregion

            #region Tuesday

            GeneralSettings.TueWorkDay.Set(GeneralSettings.TueWorkDay.Value);
            if (GeneralSettings.TueWorkDay.Value)
            {
                GeneralSettings.TueStartTime.Type(GeneralSettings.TueStartTime.Value, DateSelector.Options.Time);
                GeneralSettings.TueEndTime.Type(GeneralSettings.TueEndTime.Value, DateSelector.Options.Time);
            }
            GeneralSettings.TueGoodsMoves.Set(GeneralSettings.TueGoodsMoves.Value);

            #endregion

            #region Wednesday

            GeneralSettings.WedWorkDay.Set(GeneralSettings.WedWorkDay.Value);
            if (GeneralSettings.WedWorkDay.Value)
            {
                GeneralSettings.WedStartTime.Type(GeneralSettings.WedStartTime.Value, DateSelector.Options.Time);
                GeneralSettings.WedEndTime.Type(GeneralSettings.WedEndTime.Value, DateSelector.Options.Time);
            }
            GeneralSettings.WedGoodsMoves.Set(GeneralSettings.WedGoodsMoves.Value);

            #endregion

            #region Thursday

            GeneralSettings.ThuWorkDay.Set(GeneralSettings.ThuWorkDay.Value);
            if (GeneralSettings.ThuWorkDay.Value)
            {
                GeneralSettings.ThuStartTime.Type(GeneralSettings.ThuStartTime.Value, DateSelector.Options.Time);
                GeneralSettings.ThuEndTime.Type(GeneralSettings.ThuEndTime.Value, DateSelector.Options.Time);
            }
            GeneralSettings.ThuGoodsMoves.Set(GeneralSettings.ThuGoodsMoves.Value);

            #endregion

            #region Friday

            GeneralSettings.FriWorkDay.Set(GeneralSettings.FriWorkDay.Value);
            if (GeneralSettings.ThuWorkDay.Value)
            {
                GeneralSettings.FriStartTime.Type(GeneralSettings.FriStartTime.Value, DateSelector.Options.Time);
                GeneralSettings.FriEndTime.Type(GeneralSettings.FriEndTime.Value, DateSelector.Options.Time);
            }
            GeneralSettings.FriGoodsMoves.Set(GeneralSettings.FriGoodsMoves.Value);

            #endregion

            #region Saturday

            GeneralSettings.SatWorkDay.Set(GeneralSettings.SatWorkDay.Value);
            if (GeneralSettings.SatWorkDay.Value)
            {
                GeneralSettings.SatStartTime.Type(GeneralSettings.SatStartTime.Value, DateSelector.Options.Time);
                GeneralSettings.SatEndTime.Type(GeneralSettings.SatEndTime.Value, DateSelector.Options.Time);
            }
            GeneralSettings.SatGoodsMoves.Set(GeneralSettings.SatGoodsMoves.Value);

            #endregion

            if (Exceptions.HasRows())
            {
                Exceptions.SelectAllRecords();
                Exceptions.Delete();
            }

            foreach (c_cscalendarexceptions_gridexceptions.c_grid_row exception in Exceptions.Rows)
            {
                Exceptions.New();
                AddException(exception);
            }
        }

        private void AddException(c_cscalendarexceptions_gridexceptions.c_grid_row current)
        {
            current.Date.Type();
            current.Description.Type();
            current.WorkDay.Set();
            current.StartTime.Type(DateSelector.Options.Time);
            current.EndTime.Type(DateSelector.Options.Time);
            current.GoodsMoved.Set();
        }
    }
}
