using Api;
using GeneratedWrappers.Acumatica;
using System;
using System.Linq;

namespace Core
{
    public partial class Employee : EP203000_EmployeeMaint
    {
        private Features features;

        public c_deflocation_pxformview1 DefLocation => base.DefLocation_PXFormView1;

        public c_employee_form Summary => base.Employee_form;

        public c_employeepositions_gridpositions EmploymentHistory => base.EmployeePositions_gridPositions;

        public c_gentimecardfilter_gentcform GenerateTimeCardsForm => base.GenTimeCardFilter_gentcform;

        public c_wingman_companytreegrid Wingman => base.Wingman_companyTreeGrid;

        public c_contact_personalinfo PersonalInfo => base.Contact_PersonalInfo;

        public c_currentemployee_tab EmployeeSettings => base.CurrentEmployee_tab;

        public c_contact_contactinfo Contact => base.Contact_ContactInfo;
        
        public c_contact_frmemployeecontact ContactDetails => base.Contact_frmEmployeeContact;

        public c_address_addressinfo Address => base.Address_AddressInfo;

        public c_paymentdetails_pxgrid1 PaymentInstructions => base.PaymentDetails_PXGrid1;

        public c_deflocation_frmpmtdeflocation Accounts => base.DefLocation_frmPmtDefLocation;

        public c_activities_activities_grid Activities => base.Activities_Activities_grid;

        public c_deflocation_pxformview3 PaymentSettings => base.DefLocation_PXFormView3;

        public c_companytree_companytreegrid CompanyTree => CompanyTree_companyTreeGrid;

        public c_employeecorpcards_gridcorpcards CorpCards => EmployeeCorpCards_gridCorpCards;

        //public c_employeerates_gridemployeerates EmployeeRates
        //{
        //    get { return base.EmployeeRates_gridEmployeeRates; }
        //}

        //public c_employeeratesbyproject_gridemployeeratesbyproject ProjectRates
        //{
        //    get { return base.EmployeeRatesByProject_gridEmployeeRatesByProject; }
        //}

        public c_labormatrix_laborclassesgrid LaborClassesOverride => LaborMatrix_LaborClassesGrid;

        public c_nwatchers_gridnc Notifications => base.NWatchers_gridNC;

        public c_user_frmlogin UserInfo => base.User_frmLogin;

        public c_user_frmresetparams PasswordReset => base.User_frmResetParams;

        public c_roles_gridroles UserRoles => base.Roles_gridRoles;

        public c_answers_pxgridanswers Attributes => base.Answers_PXGridAnswers;

        public c_employeeskills_gridemployeeskills Skills =>  base.EmployeeSkills_gridEmployeeSkills;

        public c_employeegeozones_gridemployeegeozones GeoZones => base.EmployeeGeoZones_gridEmployeeGeoZones;

        public c_employeelicenses_gridemployeelicenses Licenses => base.EmployeeLicenses_gridEmployeeLicenses;

        public Employee()
        {
            FileName = "Employees";

            QuickImport.SkipContainers = new[]
            {
                "CompanyTreeMember",
                "CompanyTreeInfo",
                "UserInfoSelected",
                "UserInfoChangePasswordResetPassword",
                "UserInfo",
                "UserInfo_",
                "Licenses"
            };

            QuickImport.ExcludeFields = new[]
            {
                "GeneralInfoEmployeeSettings->EmployeeLogin"
            };

            Activities.ToolBar.NewActivityC.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
            Activities.ToolBar.NewActivityW.WaitAction = () => Wait.Wait.WaitForPageToLoad(true);
        }


        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE,
                "Create employee: " + EmployeeSettings.UserID.Value))
            {
                OpenScreen();
                Insert();
                Summary.AcctCD.Type();
                Process();
                Save();
            }
        }


        public void Update()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE,
                "Update employee: " + EmployeeSettings.UserID.Value))
            {

                OpenScreen();
                Summary.AcctCD.Select();
                Process();
                Save();
            }
        }

        private void Process()
        {
            features = new Features();
            features.ReadOne(ApiConnection.ApiConnection.Destination, string.Empty);
            Summary.VStatus.Select();
            ProcessGeneralContactInfomation();
            ProcessGeneralEmployeeSettings();
            ProcessEmployeeAccounts();
            ProcessEmployeePaymentSettings();
            ProcessNotifications();
            ProcessLaborClassesOverride();
            //ProcessEmployeeRates();
            ProcessCompanyTreeMemeber();
        }

        private void ProcessGeneralContactInfomation()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Define general contact information for employee: "
                + Summary.AcctCD.Value + " - " + Contact.LastName.Value + " " + Contact.FirstName.Value))
            {
                Contact.Title.Select();
                Contact.FirstName.Type();
                Contact.MidName.Type();
                Contact.LastName.Type();
                Contact.Phone1Type.Select();
                Contact.Phone1.Type();
                Contact.Phone2Type.Select();
                Contact.Phone2.Type();
                Contact.Phone3Type.Select();
                Contact.Phone3.Type();
                Contact.FaxType.Select();
                Contact.Fax.Type();
                Contact.EMail.Type();
                Contact.WebSite.Type();
                Address.AddressLine1.Type();
                Address.AddressLine2.Type();
                Address.City.Type();
                Address.CountryID.Select();
                Address.State.Select();
                Address.PostalCode.Type();
            }
        }

        private void ProcessGeneralEmployeeSettings()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Define general settings for employee: " 
                + Summary.AcctCD.Value + " - " + Contact.LastName.Value + " " + Contact.FirstName.Value))
            {
                EmployeeSettings.AcctReferenceNbr.Type();
                EmployeeSettings.VendorClassID.Select();
                EmployeeSettings.DepartmentID.Select();
                EmployeeSettings.CalendarID.Select();

                if (!String.IsNullOrEmpty(EmployeeSettings.SupervisorID.Value))
                {
                    Employee superVisor = ApiFactory.Get<Employee>(ApiConnection.ApiConnection.Destination).ReadOne(EmployeeSettings.SupervisorID.Value);

                    if (!String.IsNullOrEmpty(superVisor.Contact.LastName.Value))
                    {
                        EmployeeSettings.SupervisorID.Select();
                    }
                }

                if (!String.IsNullOrEmpty(EmployeeSettings.SalesPersonID.Value))
                {
                    Salesperson salesperson = ApiFactory.Get<Salesperson>(ApiConnection.ApiConnection.Source)
                        .ReadOne(EmployeeSettings.SalesPersonID.Value);

                    if (salesperson != null)
                    {
                        if (!String.IsNullOrEmpty(salesperson.Summary.Descr.Value))
                        {
                            EmployeeSettings.SalesPersonID.Select(salesperson.Summary.Descr.Value, "Name");
                        }
                    }
                }
                if (features.Summary.Multicurrency.Value)
                {
                    //EmployeeSettings.CuryID.Type();
                    //EmployeeSettings.CuryID.PressTab();
                    EmployeeSettings.CuryID.Select();
                    EmployeeSettings.AllowOverrideCury.Set();
                    EmployeeSettings.CuryRateTypeID.Select();
                    EmployeeSettings.AllowOverrideRate.Set();
                }
                else Log.Log.Information("Multi currency feature is disabled.");

                if (!String.IsNullOrEmpty(EmployeeSettings.LabourItemID.Value))
                {
                    NonStockItem labourItemId = ApiFactory.Get<NonStockItem>(ApiConnection.ApiConnection.Destination).ReadOne(EmployeeSettings.LabourItemID.Value);

                    if (!String.IsNullOrEmpty(labourItemId.Summary.Descr.Value))
                    {
                        EmployeeSettings.LabourItemID.Select();
                    }
                }

                EmployeeSettings.RouteEmails.Set();
                EmployeeSettings.TimeCardRequired.Set();
            }
        }

        private void ProcessEmployeeAccounts()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Define GL accounts for employee: "
                + Summary.AcctCD.Value + " - " + Contact.LastName.Value + " " + Contact.FirstName.Value))
            {
                Accounts.VAPAccountID.Select();
                EmployeeSettings.PrepaymentAcctID.Select();
                EmployeeSettings.ExpenseAcctID.Select();
                EmployeeSettings.SalesAcctID.Select();
                EmployeeSettings.TermsID.Select();
                if (features.Summary.SubAccount.Value)
                {
                    Accounts.VAPSubID.Type();
                    EmployeeSettings.PrepaymentSubID.Type();
                    EmployeeSettings.ExpenseSubID.Type();
                    EmployeeSettings.SalesSubID.Type();
                }
                else Log.Log.Information("Subaccount feature is disabled.");
            }
        }

        private void ProcessEmployeePaymentSettings()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Define payment settings for employee: " 
                + Summary.AcctCD.Value + " - " + Contact.LastName.Value + " " + Contact.FirstName.Value))
            {
                PaymentSettings.VCashAccountID.Select();
                PaymentSettings.VPaymentMethodID.Select();
            }
        }

        private void ProcessLaborClassesOverride()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Configure contract labor classes for: " 
                + Summary.AcctCD.Value + " - " + Contact.LastName.Value + " " + Contact.FirstName.Value))
            {
                LaborClassesOverride.Refresh();
            }
        }

        private void ProcessNotifications()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Configure notifications for: "
                + Summary.AcctCD.Value + " - " + Contact.LastName.Value + " " + Contact.FirstName.Value))
            {
                Notifications.Refresh();
            }
        }

        //private void ProcessEmployeeRates()
        //{
        //    using (
        //        TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION,
        //                                                "Configure default employee rates for: " + Summary.AcctCD.Value +
        //                                                " - " +
        //                                                Contact.LastName.Value + " " + Contact.FirstName.Value))
        //    {
        //        EmployeeRates.Refresh();

        //        if (EmployeeRates.HasRows())
        //        {
        //            EmployeeRates.RemoveAllRows();
        //        }

        //        foreach (c_employeerates_gridemployeerates.c_grid_row row in EmployeeRates.Rows)
        //        {
        //            EmployeeRates.New();
        //            row.EffectiveDate.Type();
        //            row.RateType.Select();
        //            row.RegularHours.Type();
        //            row.HourlyRate.Type();
        //        }
        //    }
        //}

        private void ProcessCompanyTreeMemeber()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Configure company tree memeber for: " 
                + Summary.AcctCD.Value + " - " + Contact.LastName.Value + " " + Contact.FirstName.Value))
            {
                CompanyTree.Refresh();
            }
        }

        public override void DetachUser()
        {
            base.DetachUser();
            MessageBox.Ok();
        }

        public override void ConfigureImportScenario()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Configure import scenario: " + ImportScenarioName))
            {
                var importScenario = new ImportScenario();
                importScenario.OpenScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);
                importScenario.Save();
                importScenario.Mapping.Adjust();
                bool laborItem;

                try
                {
                    laborItem = new ExtendedBiObject<NonStockItem>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    laborItem = false;
                }
                importScenario.Mapping.ClickCell("LaborClass");
                importScenario.Mapping.Row.IsActive.Set(laborItem);
                importScenario.Mapping.ClickCell("Labor Item");
                importScenario.Mapping.Row.IsActive.Set(laborItem);
                importScenario.Save();

                bool workgrpoupId;

                try
                {
                    workgrpoupId = new ExtendedBiObject<Employee>(ApiConnection.ApiConnection.Destination).ReadOne("EP00000001").CompanyTree.Rows.Count > 0;
                }
                catch (Exception)
                {
                    workgrpoupId = false;
                }

                importScenario.Mapping.ClickCell("Active_CompanyTreeMember");
                importScenario.Mapping.Row.IsActive.Set(workgrpoupId);

                importScenario.Save();
                importScenario.RefreshScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);

                importScenario.Mapping.ClickCell("Owner");
                importScenario.Mapping.Row.IsActive.Set(workgrpoupId);

                importScenario.Save();
                importScenario.RefreshScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);

                importScenario.Mapping.ClickCell("WaitTime");
                importScenario.Mapping.Row.IsActive.Set(workgrpoupId);

                importScenario.Save();
                importScenario.RefreshScreen();
                importScenario.Summary.Name.Select(ImportScenarioName);
                importScenario.Mapping.WhatToShow.Select(importScenario.Mapping.WhatToShow.Items["1"]);

                importScenario.Mapping.ClickCell("Workgroup ID");
                importScenario.Mapping.Row.IsActive.Set(workgrpoupId);
                importScenario.Save();
                bool reportsTo;

                try
                {
                    reportsTo = new ExtendedBiObject<Employee>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    reportsTo = false;
                }

                importScenario.Mapping.ClickCell("ReportsTo");
                importScenario.Mapping.Row.IsActive.Set(reportsTo);
                importScenario.Save();

                bool salesPerson;

                try
                {
                    salesPerson = new ExtendedBiObject<Salesperson>(ApiConnection.ApiConnection.Destination).ExportKeys().Any();
                }
                catch (Exception)
                {
                    salesPerson = false;
                }

                importScenario.Mapping.ClickCell("Salesperson");
                importScenario.Mapping.Row.IsActive.Set(salesPerson);
                importScenario.Save();
            }
        }
    }
}
