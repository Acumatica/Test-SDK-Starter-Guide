using GeneratedWrappers.Acumatica;

namespace Core
{
    public class StatementCycle : AR202800_ARStatementMaint
    {
        public c_arstatementcyclerecord_form Summary => base.ARStatementCycleRecord_form;

        public StatementCycle()
        {
            FileName = "Statement Cycles";

            QuickImport.ExcludeFields = new string[]
            {
                "StatementCycleGeneralSettings->DayOfMonth",
                "StatementCycleGeneralSettings->DayOfMonth1",
                "StatementCycleGeneralSettings->DayOfMonth2",
                "StatementCycleGeneralSettings->LastStatementDate",
                "StatementCycleAgingSettingsAgingSettings->AgeMessage0"
            };
        }
    }
}