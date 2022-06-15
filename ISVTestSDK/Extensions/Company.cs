using Core.Exceptions;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public class Company : CS101500_OrganizationMaint
    {
        public class Type
        {
            public const string WithoutBranches = "Without Branches";
            public const string WithBranchesRequiringBalancing = "With Branches Requiring Balancing";
            public const string WithBranchesNotRequiringBalancing = "With Branches Not Requiring Balancing";
        }

        public c_baccount_pxformview1 Summary => base.BAccount_PXFormView1;
        public c_defcontact_defcontact DefaultContact => base.DefContact_DefContact;
        public c_defaddress_defaddress DefaultAddress => base.DefAddress_DefAddress;
        public c_organizationview_tab GeneralSettings => base.OrganizationView_tab;
        public c_organizationview_pxformview1 OrganizationSettings => base.OrganizationView_PXFormView1;
        public c_organizationview_orgpart10 Settings1099 => base.OrganizationView_OrgPart10;
        public c_organizationview_company BaseCurrency => base.OrganizationView_Company;
        public c_deflocation_frmdeflocationgl Accounts => base.DefLocation_frmDefLocationGL;
        public c_commonsetup_commonsettings CommonSettings => base.Commonsetup_commonsettings;
        public c_currentbaccount_tab TaxRegistrationSettings => base.CurrentBAccount_tab;
        public c_organizationledgerlinkwithledgerselect_grdledgerlinks Ledgers => base.OrganizationLedgerLinkWithLedgerSelect_grdLedgerLinks;
        public c_branchesview_grdbranches Branches => base.BranchesView_grdBranches;
        public c_employees_grdemployees Employees => base.Employees_grdEmployees;
        public c_organizationview_rutrotsettings RutRotSettings => base.OrganizationView_RUTROTSettings;
        public c_deflocation_frmdeflocation DeliveryDetails => base.DefLocation_frmDefLocation;
        public c_deflocationaddress_deflocationaddress DeliveryAddress => base.DefLocationAddress_DefLocationAddress;
        public c_deflocationcontact_deflocationcontact DeliveryContact => base.DefLocationContact_DefLocationContact;
        public c_organizationview_frmlogo LogoDetails => base.OrganizationView_frmLogo;
        public c_createledgerview_loform CreateLedgerPanel => base.CreateLedgerView_loform;
        public c_company_miscsettings MiscSettings => base.Company_MiscSettings;
        public c_changeiddialog_formchangeid SpecifyNewIDForm => base.ChangeIDDialog_formChangeID;
        public c_organizationview_configurationsettings ConfigurationSettings => base.OrganizationView_ConfigurationSettings;
        public c_groups_grid CompanyGroups => base.Groups_grid;
        public c_organizationview_formcarrierfacility CarrierFacility => OrganizationView_formCarrierFacility;
        public c_taxes_grdtaxes Taxes => base.Taxes_grdTaxes;

        public Company()
        {
            ResetAwaitingOnSave();

            Branches.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Employees.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;
            Ledgers.ToolBar.Export.WaitAction = Wait.Wait.WaitForFileDownloadComplete;

            BaseCurrency.Buttons.BaseCuryIDEdit.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
        }

        /// <summary>
        /// Reset WaitActions to default - await for page reloading
        /// </summary>
        public void ResetAwaitingOnSave()
        {
            ToolBar.Save.WaitAction = () =>
            {
                try
                {
                    Wait.Wait.WaitForPageToLoad(Wait.Wait.MediumTimeOut * 3);
                }
                catch (WaitTimeoutException) { }
            };

            Branches.ToolBar.AddBranch.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
            Employees.ToolBar.NewContact.WaitAction = Wait.Wait.WaitForNewWindowToOpen;
        }

        /// <summary>
        /// Creates Simple Company entry
        /// </summary>
        /// <param name="ID">branch ID</param>
        /// <param name="Name">branch name</param>
        /// <param name="Country">country</param>
        public void CreateSimple(string ID = "MAIN", string Name = "Main Branch", string Country = "US", string City = null)
        {
            using (TestExecution.TestExecution.CreateTestStepGroup("Create Company " + Name))
            {
                FillReqiredSettings(ID, Name, Country, City ?? string.Empty);
                OrganizationSettings.OrganizationType.GetValue().VerifyEquals(Type.WithoutBranches);
                SetDefaultCurrency();
            }
        }

        /// <summary>
        /// Creates Simple Company entry with branched type
        /// </summary>
        /// <param name="reqiringBalancing">select type with or without Balancing</param>
        /// <param name="ID">branch ID</param>
        /// <param name="Name">branch name</param>
        /// <param name="Country">country</param>
        public void CreateSimple(bool reqiringBalancing, string ID = "MAIN", string Name = "Main Branch", string Country = "US", string City = null)
        {
            using (TestExecution.TestExecution.CreateTestStepGroup("Create Company " + Name))
            {
                FillReqiredSettings(ID, Name, Country, City ?? string.Empty);
                OrganizationSettings.OrganizationType.Select(reqiringBalancing ? Type.WithBranchesRequiringBalancing : Type.WithBranchesNotRequiringBalancing);
                SetDefaultCurrency();
            }
        }

        public void FillReqiredSettings(string ID, string Name, string Country, string City)
        {
            if (Core.Browser.Browser.ScreenId != ScreenId) OpenScreen();
            if (ToolBar.Insert.IsVisible()) Insert();
            Summary.AcctCD.Type(ID);
            Summary.AcctName.Type(Name);
            DefaultAddress.CountryID.Select(Country);
            DefaultAddress.City.Type(City);
            ConfigurationSettings.CountryID.Select("US");
        }

        public void SetDefaultCurrency()
        {
            string currentValue = BaseCurrency.BaseCuryID.GetValue();
            if (currentValue.Split()[0] == "USD")
                BaseCurrency.BaseCuryID.IsEnabled().VerifyEquals(false);
            else
                BaseCurrency.BaseCuryID.Select("USD");
            Save();
        }
    }
}
