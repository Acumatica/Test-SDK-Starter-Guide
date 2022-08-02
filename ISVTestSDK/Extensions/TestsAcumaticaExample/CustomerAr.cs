using Controls.SmartPanel;
using Core.Core.Browser;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class CustomerAr : AR303000_CustomerMaint
    {
        public c_baccount_baccount Summary => base.BAccount_BAccount;
        public c_childaccounts_gridchildaccounts ChildAccounts => base.ChildAccounts_gridChildAccounts;
        public c_customerbalance_customerbalance Balance => base.CustomerBalance_CustomerBalance;
        public c_defcontact_defcontact1 Contact => base.DefContact_DefContact1;
        public c_primarycontactcurrent_frmprimarycontact PrimaryContact => base.PrimaryContactCurrent_frmPrimaryContact;
        public c_defaddress_defaddress Address => base.DefAddress_DefAddress;
        public c_changeiddialog_formchangeid SpecifyNewIDForm => base.ChangeIDDialog_formChangeID;
        public c_currentcustomer_tab GeneralSettings => base.CurrentCustomer_tab;
        public c_deflocation_deflocation DeliverySettings => base.DefLocation_DefLocation;
        public c_defpaymentmethodinstance_defpaymentmethodinstance PaymentSettings
            => base.DefPaymentMethodInstance_DefPaymentMethodInstance;
        public c_billcontact_billcontact BillingContact => base.BillContact_BillContact;
        public c_deflocationcontact_deflocationcontact DeliveryContact => base.DefLocationContact_DefLocationContact;
        public c_deflocationaddress_deflocationaddress DeliveryAddress => base.DefLocationAddress_DefLocationAddress;
        public c_billaddress_billaddress BillingAddress => base.BillAddress_BillAddress;
        public c_defpaymentmethodinstancedetails_grdpminstancedetails PaymentMethodDetails
            => base.DefPaymentMethodInstanceDetails_grdPMInstanceDetails;
        public c_locations_grdlocations Locations => base.Locations_grdLocations;
        public c_contacts_grdcontacts Contacts => base.Contacts_grdContacts;
        public c_salespersons_pxgrid1 Salespersons => base.SalesPersons_PXGrid1;
        public c_balances_pxgrid1 BalancesTab => base.Balances_PXGrid1;
        public c_paymentmethods_grdpaymentmethods PaymentMethods => base.PaymentMethods_grdPaymentMethods;
        public c_answers_pxgridanswers AttributesGrid => base.Answers_PXGridAnswers;
        public c_activities_activities_grid Activities => base.Activities_Activities_grid;
        public c_deflocation_deflocationaccount Accounts => base.DefLocation_DefLocationAccount;
        public c_deflocation_formretainage AccountsRetainage => base.DefLocation_formRetainage;
        public c_notificationsources_gridns Notifications => base.NotificationSources_gridNS;
        public c_notificationrecipients_gridnr Recipients => base.NotificationRecipients_gridNR;
        public c_ondemandstatementdialog_formondemandstatement OnDemandStatementDialog
            => base.OnDemandStatementDialog_formOnDemandStatement;
        public c_userlist_usergrid UserList => base.UserList_userGrid;
        public c_compliancedocuments_grdcompliancedocuments Compliance => base.ComplianceDocuments_grdComplianceDocuments;
        public c_contactinfo_formcreatecontact ContactInfoCreateContactForm => base.ContactInfo_formCreateContact;
        public c_contactinfoattributes_grdcontactinfoattributes ContactAttributesCreateContactForm => base.ContactInfoAttributes_grdContactInfoAttributes;
        public c_contactinfo_tabcreatecontact CreateContactForm => base.ContactInfo_tabCreateContact;
        public c_currentcustomer_deflocation RelatedItems => base.CurrentCustomer_DefLocation;
        public c_addresslookupfilter_addresslookuppanelformaddress AutocompletePanel => AddressLookupFilter_AddressLookupPanelformAddress;
        public c_currentcustomer_tab CustomerBillingCycle => CurrentCustomer_tab;
        public c_customerbillingcycles_gridbillingcycles ServiceBilling => CustomerBillingCycles_gridBillingCycles;
        public c_carriers_pxgridaccounts CarriersGrid => Carriers_PXGridAccounts;
        public c_currentcustomer_referencenbr ReferenceNbr => CurrentCustomer_ReferenceNbr;

        public CustomerAr()
        {
            FileName = "Customers";
            QuickImport.ReplaceKey = "QIC";
            QuickImport.Key = new[]
            {
                "GOLDRIVER"
            };
            QuickImport.SkipContainers = new[]
            {
                "ChildAccounts",
                "Contacts",
                "ServicesBilling",
                "Activities"
            };
            QuickImport.ExcludeFields = new[]
            {
                "CustomerSummary->CustomerID",
                "MailingPrintingMailings->Overridden",
                "CustomerSummaryBalance->Balance",
                "CustomerSummaryBalance->ConsolidatedBalance",
                "CustomerSummaryBalance->PrepaymentBalance",
                "CustomerSummaryBalance->RetainageBalance",
                "CustomerSummaryBalance->RetainedBalance",
                "DeliverySettingsDefaultLocationSettings->TaxCalculationMode",
                "DeliverySettingsDefaultLocationSettings->EntityUsageType",
                "GenerateOnDemandStatement->StatementDate"
            };

            QuickImport.DisabledLines = new[]
            {
                "ShippingTaxSettings->EntityUsageType",
                "ShippingTaxSettings->TaxCalculationMode"
            };

            ToolBar.NewInvoiceMemo.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.ViewBusnessAccount.WaitAction = Wait.Wait.WaitForPageToLoad;

            PaymentMethods.ToolBar.AddPaymentMethod.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);

            PaymentMethods.ToolBar.ViewPaymentMethod.WaitAction = delegate
            {
                if (MessageBox.Buttons.Ok.IsVisible()) MessageBox.Ok();
                Wait.Wait.WaitForPageToLoad(true);
            };

            ChildAccounts.Row.CustomerID.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Locations.ToolBar.NewLocation.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Locations.Row.LocationCD.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Contacts.ToolBar.CreateContactToolBar.WaitAction = Wait.Wait.WaitForPageToLoad;
            Contacts.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Contacts.Row.DisplayName.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            GeneralSettings.CreditLimit.WaitAction = Wait.Wait.WaitForCallbackToComplete;
            ToolBar.CustomerDocuments.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.NewSalesOrder.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.SalesPrice.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.ViewRestrictionGroups.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.ExtendToVendor.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.WriteOffBalance.WaitAction = Wait.Wait.WaitForPageToLoad;
            ToolBar.ManageCustomizations.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            ToolBar.MenuEditProj.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.CreateTask.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.CreateEvent.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.CreateEmail.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.NewActivityC.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.NewActivityN.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.NewActivityM.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.NewActivityP.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.NewActivityW.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Activities.Row.Subject.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            ToolBar.CreateContact.WaitAction = () => CreateContactForm.Buttons.Create.IsVisible();
            CreateContactForm.Buttons.Createandreview.WaitAction = Wait.Wait.WaitForPageToLoad;
            CreateContactForm.Buttons.Create.WaitAction = Wait.Wait.WaitForLongOperationToComplete;

            Locations.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Contacts.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Activities.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
        }

        #region Set Billing Cycle for Customer Method

        public void SetBillingCycle(string billingCycle, string customer = "ABARTENDE")
        {
            if (!Browser.ScreenId.Equals(ScreenId))
            {
                OpenScreen();
            }

            Summary.AcctCD.Select(customer);
            CustomerBillingCycle.BillingCycleID.Select(billingCycle);
            Save();
        }

        #endregion

        public void Activate()
        {
            Summary.Status.Select("Active");
            Save();
        }

        public void Deactivate()
        {
            Summary.Status.Select("Inactive");
            Save();
        }

        public void PutOnCreditHold()
        {
            Summary.Status.Select("Credit Hold");
            Save();
        }

        public void PutOnHold()
        {
            Summary.Status.Select("On Hold");
            Save();
        }

        public void SetAsOneTime()
        {
            Summary.Status.Select("One-Time");
            Save();
        }
    }
}
