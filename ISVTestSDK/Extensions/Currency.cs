using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class Currency : CM202000_CurrencyMaint
    {
        public const string DecimalPlacesChangingWarning =
            "Changing the precision of a currency in which transactions are recorded may lead to negative consequences, including the impossibility of processing documents in this currency. Do you want to continue?";

        public c_curylistrecords_newform Summary => base.CuryListRecords_newform;
        public c_curyrecords_roundinglimit RoundingLimit => base.CuryRecords_RoundingLimit;
        public c_curyrecords_formglaccounts Accounts => base.CuryRecords_formGLAccounts;
        public c_curyrecords_formroundingsettings RoundingSettings => base.CuryRecords_formRoundingSettings;

        public Currency()
        {
            FileName = "Currencies";
            QuickImport.Skip = true;
        }
    }
}
