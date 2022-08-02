using Controls.Alert;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class CustomerClassAr : AR201000_CustomerClassMaint
    {
        public c_customerclassrecord_form Summary => base.CustomerClassRecord_form;
        public c_mapping_grid Attributes => base.Mapping_grid;
        public c_curcustomerclassrecord_tab GeneralSettings => base.CurCustomerClassRecord_tab;
        public c_notificationrecipients_gridnr Recipients => base.NotificationRecipients_gridNR;
        public c_notificationsources_gridns Notifications => base.NotificationSources_gridNS;

        public CustomerClassAr()
        {
            FileName = "Customer Classes";

            ToolBar.Delete.WaitAction = Alert.AlertToException;

            QuickImport.ExcludeFields = new[]
            {
                "GeneralDefaultServiceManagementSettings->BillToAddress",
                "GeneralDefaultServiceManagementSettings->ShipToAddress",
                "GeneralDefaultGeneralSettings->TaxCalculationMode",
                "GeneralDefaultGeneralSettings->EntityUsageType"
            };

            QuickImport.DisabledLines = new[]
            {
                "MailingPrintingRecipients->ContactType",
                "MailingPrintingRecipients->ContactID",
                "MailingPrintingRecipients->Format",
                "MailingPrintingRecipients->Active",
                "MailingPrintingRecipients->AddTo",
                "GeneralDefaultGeneralSettings->RequireEntityUsageType",
                "GeneralDefaultGeneralSettings->TaxCalculationMode",
                "GeneralDefaultGeneralSettings->EntityUsageType"
            };
        }
    }
}
