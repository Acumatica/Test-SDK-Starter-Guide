using System;
using Controls.CheckBox;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Input;
using Core;
using Core.Attributes;
using Core.Config;
using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Verifications;

namespace GeneratedWrappers.ISVTestSDK
{
    public class TestsAcumaticaExample : Check
    {
        private Box Box = new Box();
        private Tax Tax = new Tax();
        private User User = new User();
        private Branch Branch = new Branch();
        private ReceiptIn ReceiptIn = new ReceiptIn();
        private OrderSo OrderSo = new OrderSo();
        private SOShipment Shipment = new SOShipment();
        private SetupAp SetupAp = new SetupAp();
        private SetupAr SetupAr = new SetupAr();
        private SetupIn SetupIn = new SetupIn();
        private SetupSo SetupSo = new SetupSo();
        private SiteMap SiteMap = new SiteMap();
        private Account Account = new Account();
        private TaxZone TaxZone = new TaxZone();
        private Company Company = new Company();
        private Carrier Carrier = new Carrier();
        private ShipVia ShipVia = new ShipVia();
        private Employee Employee = new Employee();
        private readonly Discount Discount = new Discount();
        private readonly FobPoint FobPoint = new FobPoint();
        private readonly Features Features = new Features();
        private readonly StockItem StockItem = new StockItem();
        private readonly Warehouse Warehouse = new Warehouse();
        private readonly ItemClass ItemClass = new ItemClass();
        private readonly OrderType OrderType = new OrderType();
        private readonly Department Department = new Department();
        private readonly CustomerAr CustomerAr = new CustomerAr();
        private readonly Subaccount Subaccount = new Subaccount();
        private readonly Salesperson Salesperson = new Salesperson();
        private readonly CreditTerms CreditTerms = new CreditTerms();
        private readonly TaxCategory TaxCategory = new TaxCategory();
        private readonly CompanyTree CompanyTree = new CompanyTree();
        private readonly CurrencyRate CurrencyRate = new CurrencyRate();
        private readonly PostingClass PostingClass = new PostingClass();
        private readonly DiscountCode DiscountCode = new DiscountCode();
        private readonly NonStockItem NonStockItem = new NonStockItem();
        private readonly WorkCalendar WorkCalendar = new WorkCalendar();
        private readonly EmployeeClass EmployeeClass = new EmployeeClass();
        private readonly PaymentMethod PaymentMethod = new PaymentMethod();
        private readonly ShippingZones ShippingZones = new ShippingZones();
        private readonly ShipmentTerms ShipmentTerms = new ShipmentTerms();
        private readonly StatementCycle StatementCycle = new StatementCycle();
        private readonly LotSerialClass LotSerialClass = new LotSerialClass();
        private readonly UnitConversion UnitConversion = new UnitConversion();
        private readonly CustomerClassAr CustomerClassAr = new CustomerClassAr();
        private readonly AssignmentMapOld AssignmentMap = new AssignmentMapOld();
        private readonly CustomerLocation CustomerLocation = new CustomerLocation();
        private readonly ImportByScenario ImportByScenario = new ImportByScenario();
        private readonly CurrencyRatesHistory CurrencyRatesHistory = new CurrencyRatesHistory();
        private readonly FileUploadPreferences FileUploadPreferences = new FileUploadPreferences();
        private readonly AvailabilityCalculationRules AvailabilityCalculationRules = new AvailabilityCalculationRules();
        private readonly SitePreferences SitePreferences = new SitePreferences();
        private readonly GenericInquiry GenericInquiry = new GenericInquiry();

        public override void Execute()
        {
            PxLogin.LoginToDestinationSite();

            #region Test Case 1

            using (TestExecution.CreateTestCaseGroup("Features"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Configure features"))
                {
                    SitePreferences.OpenScreen();
                    SitePreferences.Summary.PersonNameFormat.Select("Eastern Modified");
                    SitePreferences.Save();

                    Features.OpenScreen();
                    Features.Insert();
                    Features.Summary.DistributionModule.SetTrue();
                    Features.Summary.IntegrationModule.SetTrue();
                    Features.Summary.AutoPackaging.SetTrue();
                    Features.Summary.Warehouse.SetTrue();
                    Features.Summary.WarehouseLocation.SetTrue();
                    Features.Summary.DropShipments.SetTrue();
                    Features.Summary.MultipleUnitMeasure.SetTrue();
                    Features.Summary.CarrierIntegration.SetTrue();
                    Features.Summary.LotSerialTracking.SetTrue();
                    Features.Summary.BlanketPO.SetTrue();
                    Features.Summary.VendorDiscounts.SetTrue();
                    Features.Summary.CustomerDiscounts.SetTrue();
                    Features.Summary.Commissions.SetTrue();
                    Features.Summary.KitAssemblies.SetTrue();
                    Features.Summary.AutomationModule.SetTrue();
                    Features.Summary.UserDefinedOrderTypes.SetTrue();
                    Features.Summary.Replenishment.SetTrue();
                    Features.Summary.AdvancedPhysicalCounts.SetTrue();
                    Features.Summary.PurchaseRequisitions.SetTrue();
                    Features.Summary.SOToPOLink.SetTrue();
                    Features.Summary.DistributionModule.SetTrue();
                    Features.Summary.Warehouse.SetTrue();
                    Features.Summary.WarehouseLocation.SetTrue();
                    Features.Summary.Inventory.SetTrue();
                    Features.Summary.FedExCarrierIntegration.SetTrue();
                    Features.Summary.UPSCarrierIntegration.SetTrue();
                    Features.Summary.StampsCarrierIntegration.SetTrue();
                    Features.Summary.ShipEngineCarrierIntegration.SetTrue();
                    Features.Summary.EasyPostCarrierIntegration.SetTrue();
                    Features.Summary.CustomCarrierIntegration.SetTrue();
                    Features.RequestValidation();
                }

                #endregion
            }

            #endregion

            #region Test Case 2

            using (TestExecution.CreateTestCaseGroup("Common settings"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Add *.TIF to upload settings"))
                {
                    FileUploadPreferences.OpenScreen();

                    if (!FileUploadPreferences.Details.Columns.FileExt.GetValues().VerifyAnyOfValuesEquals(".tif"))
                    {
                        FileUploadPreferences.Details.New();
                        FileUploadPreferences.Details.Row.FileExt.Type(".tif");
                        FileUploadPreferences.Save();
                    }
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Add html to upload settings"))
                {
                    FileUploadPreferences.OpenScreen();
                    FileUploadPreferences.Details.New();
                    FileUploadPreferences.Details.Row.FileExt.Type(".html");
                    FileUploadPreferences.Save();

                }

                #endregion

                #region Step 3

                using (TestExecution.CreateTestStepGroup("Create units of measure"))
                {
                    UnitConversion.OpenScreen();

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("UNIT");
                    UnitConversion.Details.Row.ToUnit.Type("UNIT");

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("POUND");
                    UnitConversion.Details.Row.ToUnit.Type("POUND");

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("POUND");
                    UnitConversion.Details.Row.ToUnit.Type("KG");
                    UnitConversion.Details.Row.UnitMultDiv.Select("D");
                    UnitConversion.Details.Row.UnitRate.Type(2.204623m);

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("UNIT");
                    UnitConversion.Details.Row.ToUnit.Type("KG");
                    UnitConversion.Details.Row.UnitRate.Type(2);

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("PIECE");
                    UnitConversion.Details.Row.ToUnit.Type("PACK");
                    UnitConversion.Details.Row.UnitRate.Type(15);

                    UnitConversion.Save();

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("INCH");
                    UnitConversion.Details.Row.ToUnit.Type("INCH");
                    UnitConversion.Save();

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("CM");
                    UnitConversion.Details.Row.ToUnit.Type("CM");
                    UnitConversion.Save();

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("INCH");
                    UnitConversion.Details.Row.ToUnit.Type("METER");
                    UnitConversion.Details.Row.UnitRate.Type(0.0254m);
                    UnitConversion.Save();

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("INCH");
                    UnitConversion.Details.Row.ToUnit.Type("CM");
                    UnitConversion.Details.Row.UnitRate.Type(2.54m);
                    UnitConversion.Save();

                    UnitConversion.New();
                    UnitConversion.Details.Row.FromUnit.Type("CM");
                    UnitConversion.Details.Row.ToUnit.Type("METER");
                    UnitConversion.Details.Row.UnitRate.Type(0.01m);
                    UnitConversion.Save();
                }

                #endregion

                #region Step 4

                using (TestExecution.CreateTestStepGroup("Add new accounts"))
                {
                    Account.OpenScreen();
                    Account.Upload();
                    Account.Details.UploadForm.SelectFile(@"C:\Users\aaron.beehoo\Downloads\ISVTestSDK\ISVTestSDK\ISVTestSDK\Configuration\Data\Cc110_Accounts.csv");
                    Account.Details.UploadForm.Upload();
                    Account.CsvImportSettings.Ok();
                    Account.Columns.Ok();
                    Account.Save();
                }

                #endregion

                //Tests.ControlAccountsHelper.SetControlAccounts();

                #region Step 5

                using (TestExecution.CreateTestStepGroup("Verify settings for the branch: MAIN"))
                {
                    Branch.OpenScreen();
                    Branch.Summary.AcctCD.Select("MAIN");
                    Branch.Accounts.CMPSalesSubID.IsEnabled().VerifyEquals(false);
                    Branch.Accounts.CMPSalesSubID.GetValue().VerifyEquals("SG-SSO-KR");
                    Branch.Accounts.CMPExpenseSubID.IsEnabled().VerifyEquals(false);
                    Branch.Accounts.CMPExpenseSubID.GetValue().VerifyEquals("SG-SSO-KR");
                    Branch.Accounts.CMPFreightSubID.IsEnabled().VerifyEquals(false);
                    Branch.Accounts.CMPFreightSubID.GetValue().VerifyEquals("SG-SSO-KR");
                    Branch.Accounts.CMPDiscountSubID.IsEnabled().VerifyEquals(false);
                    Branch.Accounts.CMPDiscountSubID.GetValue().VerifyEquals("SG-SSO-KR");
                    Branch.Accounts.CMPGainLossSubID.IsEnabled().VerifyEquals(false);
                    Branch.Accounts.CMPGainLossSubID.GetValue().VerifyEquals("SG-SSO-KR");
                }

                #endregion
            }

            #endregion

            #region Test Case 3

            using (TestExecution.CreateTestCaseGroup("Configuration: tax Categories, tax zones, taxes."))
            {
                #region Step 0

                using (TestExecution.CreateTestStepGroup("Configure accounts payable preferences"))
                {
                    SetupAp.OpenScreen();
                    SetupAp.Save();
                }

                #endregion

                #region Step 1

                using (TestExecution.CreateTestStepGroup("Import Tax using IS"))
                {
                    ImportByScenario.ImportEntities(Tax, "Cc110_Taxes.xlsx", 5);
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Create tax category EXEMPT - Exempt Tax Category"))
                {
                    TaxCategory.OpenScreen();

                    using (TestExecution.CreateGroup("EXEMPT - Exempt Tax Category"))
                    {
                        TaxCategory.Insert();
                        TaxCategory.Summary.TaxCategoryID.Type("EXEMPT");
                        TaxCategory.Summary.Descr.Type("Exempt Tax Category");
                        TaxCategory.Summary.Active.SetTrue();
                        TaxCategory.Save();
                    }

                    using (TestExecution.CreateGroup("STAX001"))
                    {
                        TaxCategory.Insert();
                        TaxCategory.Summary.TaxCategoryID.Type("STAX001");
                        TaxCategory.Summary.Descr.Type("Sales Tax Calc. On Document Amount");
                        TaxCategory.Summary.Active.SetTrue();


                        TaxCategory.Save();
                    }

                    using (TestExecution.CreateGroup("STAX002"))
                    {
                        TaxCategory.Insert();
                        TaxCategory.Summary.TaxCategoryID.Type("STAX002");
                        TaxCategory.Summary.Descr.Type("Sales Extract From Item Amount");
                        TaxCategory.Summary.Active.SetTrue();


                        TaxCategory.Save();
                    }

                    using (TestExecution.CreateGroup("STAX003"))
                    {
                        TaxCategory.Insert();
                        TaxCategory.Summary.TaxCategoryID.Type("STAX003");
                        TaxCategory.Summary.Descr.Type("Calc. On Item Amount");
                        TaxCategory.Summary.Active.SetTrue();


                        TaxCategory.Save();
                    }
                }

                #endregion

                #region Step 3

                using (TestExecution.CreateTestStepGroup("Create tax zone TAXABLE"))
                {
                    TaxZone.OpenScreen();
                    TaxZone.Insert();

                    TaxZone.Summary.TaxZoneID.Type("TAXABLE");
                    TaxZone.Summary.Descr.Type("TAXABLE");

                    TaxZone.Save();
                }

                #endregion
            }

            #endregion

            #region Test Case 4

            using (TestExecution.CreateTestCaseGroup("Inventory preferences"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Import reason codes using IS"))
                {
                    ImportByScenario.ImportEntities(new ReasonCode(), "Cc110_ReasonCodes.xlsx", 6);
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Create posting class DEFAULT"))
                {
                    PostingClass.OpenScreen();
                    PostingClass.Summary.PostClassID.Type("DEFAULT");
                    PostingClass.Summary.Descr.Type("DEFAULT");
                    PostingClass.GLAccounts.InvtAcctID.Select("120000");
                    PostingClass.GLAccounts.InvtSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.ReasonCodeSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.SalesAcctID.Select("400000");
                    PostingClass.GLAccounts.SalesSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.COGSAcctID.Select("520000");
                    PostingClass.GLAccounts.COGSSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstVarAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstVarSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstRevAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstRevSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.POAccrualAcctID.Select("211000");
                    PostingClass.GLAccounts.POAccrualSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.PPVAcctID.Select("588000");
                    PostingClass.GLAccounts.PPVSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.LCVarianceAcctID.Select("604000");
                    PostingClass.GLAccounts.LCVarianceSubID.Type("SGHNBCN");
                    PostingClass.Save();
                }

                #endregion

                #region Step 3

                using (TestExecution.CreateTestStepGroup("Create posting class CCLASS"))
                {
                    PostingClass.OpenScreen();
                    PostingClass.Summary.PostClassID.Type("CCLASS");
                    PostingClass.Summary.Descr.Type("Self-centered class");
                    PostingClass.GLAccounts.InvtAcctDefault.Select("P");
                    PostingClass.GLAccounts.SalesAcctDefault.Select("P");
                    PostingClass.GLAccounts.COGSAcctDefault.Select("P");
                    PostingClass.GLAccounts.StdCstVarAcctDefault.Select("P");
                    PostingClass.GLAccounts.StdCstRevAcctDefault.Select("P");
                    PostingClass.GLAccounts.POAccrualAcctDefault.Select("P");
                    PostingClass.GLAccounts.PPVAcctDefault.Select("P");
                    PostingClass.GLAccounts.LCVarianceAcctDefault.Select("P");
                    PostingClass.GLAccounts.InvtAcctID.Select("500000");
                    PostingClass.GLAccounts.InvtSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.ReasonCodeSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.SalesAcctID.Select("400000");
                    PostingClass.GLAccounts.SalesSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.COGSAcctID.Select("520000");
                    PostingClass.GLAccounts.COGSSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstVarAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstVarSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstRevAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstRevSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.POAccrualAcctID.Select("211000");
                    PostingClass.GLAccounts.POAccrualSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.PPVAcctID.Select("588000");
                    PostingClass.GLAccounts.PPVSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.LCVarianceAcctID.Select("604000");
                    PostingClass.GLAccounts.LCVarianceSubID.Type("SGHNBCN");
                    PostingClass.Save();
                }

                #endregion

                #region Step 4

                using (TestExecution.CreateTestStepGroup("Create posting class TST1"))
                {
                    PostingClass.OpenScreen();
                    PostingClass.Summary.PostClassID.Type("TST1");
                    PostingClass.Summary.Descr.Type("TST1: Inventory and COGS from Inventory");
                    PostingClass.GLAccounts.InvtAcctID.Select("120000");
                    PostingClass.GLAccounts.InvtSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.ReasonCodeSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.SalesAcctID.Select("400000");
                    PostingClass.GLAccounts.SalesSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.COGSAcctID.Select("520000");
                    PostingClass.GLAccounts.COGSSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstVarAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstVarSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstRevAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstRevSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.POAccrualAcctID.Select("211000");
                    PostingClass.GLAccounts.POAccrualSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.PPVAcctID.Select("588000");
                    PostingClass.GLAccounts.PPVSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.LCVarianceAcctID.Select("604000");
                    PostingClass.GLAccounts.LCVarianceSubID.Type("SGHNBCN");
                    PostingClass.Save();
                }

                #endregion

                #region Step 5

                using (TestExecution.CreateTestStepGroup("Create posting class TST2"))
                {
                    PostingClass.OpenScreen();
                    PostingClass.Summary.PostClassID.Type("TST2");
                    PostingClass.Summary.Descr.Type("TST2: Inventory and COGS from Warehouse");
                    PostingClass.GLAccounts.InvtAcctDefault.Select("W");
                    PostingClass.GLAccounts.COGSAcctDefault.Select("W");
                    PostingClass.GLAccounts.InvtAcctID.Select("120000");
                    PostingClass.GLAccounts.InvtSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.ReasonCodeSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.SalesAcctID.Select("400000");
                    PostingClass.GLAccounts.SalesSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.COGSAcctID.Select("520000");
                    PostingClass.GLAccounts.COGSSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstVarAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstVarSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstRevAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstRevSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.POAccrualAcctID.Select("211000");
                    PostingClass.GLAccounts.POAccrualSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.PPVAcctID.Select("588000");
                    PostingClass.GLAccounts.PPVSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.LCVarianceAcctID.Select("604000");
                    PostingClass.GLAccounts.LCVarianceSubID.Type("SGHNBCN");
                    PostingClass.Save();
                }

                #endregion

                #region Step 6

                using (TestExecution.CreateTestStepGroup("Create posting class TST3"))
                {
                    PostingClass.OpenScreen();
                    PostingClass.Summary.PostClassID.Type("TST3");
                    PostingClass.Summary.Descr.Type("TST3: Inventory and COGS from Posting Class");
                    PostingClass.GLAccounts.InvtAcctDefault.Select("P");
                    PostingClass.GLAccounts.COGSAcctDefault.Select("P");
                    PostingClass.GLAccounts.InvtAcctID.Select("120500");
                    PostingClass.GLAccounts.InvtSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.ReasonCodeSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.SalesAcctID.Select("400000");
                    PostingClass.GLAccounts.SalesSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.COGSAcctID.Select("520500");
                    PostingClass.GLAccounts.COGSSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstVarAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstVarSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.StdCstRevAcctID.Select("586000");
                    PostingClass.GLAccounts.StdCstRevSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.POAccrualAcctID.Select("211000");
                    PostingClass.GLAccounts.POAccrualSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.PPVAcctID.Select("588000");
                    PostingClass.GLAccounts.PPVSubID.Type("SGHNBCN");
                    PostingClass.GLAccounts.LCVarianceAcctID.Select("604000");
                    PostingClass.GLAccounts.LCVarianceSubID.Type("SGHNBCN");
                    PostingClass.Save();
                }

                #endregion

                #region Step 7

                using (TestExecution.CreateTestStepGroup("Create lot/serial class NN"))
                {
                    LotSerialClass.OpenScreen();
                    LotSerialClass.Summary.LotSerClassID.Type("NN");
                    LotSerialClass.Summary.Descr.Type("No lot or serial numbering");

                    LotSerialClass.Save();
                }

                #endregion

                #region Step 8

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOSRF"))
                {
                    LotSerialClass.OpenScreen();
                    LotSerialClass.Summary.LotSerClassID.Type("SOSRF");
                    LotSerialClass.Summary.Descr.Type("SO serial when received FIFO");

                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("F");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("00000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();
                    LotSerialClass.Summary.AutoSerialMaxCount.Type("99999");
                    LotSerialClass.Details.New();

                    LotSerialClass.Save();
                }

                #endregion

                #region Step 9

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOSRL"))
                {
                    LotSerialClass.OpenScreen();
                    LotSerialClass.Summary.LotSerClassID.Type("SOSRL");
                    LotSerialClass.Summary.Descr.Type("SO serial when received LIFO");
                    //
                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("L");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("00000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();
                    LotSerialClass.Summary.AutoSerialMaxCount.Type("99999");


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 10

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOSRS"))
                {
                    LotSerialClass.OpenScreen();
                    LotSerialClass.Summary.LotSerClassID.Type("SOSRS");
                    LotSerialClass.Summary.Descr.Type("SO serial when received sequential");
                    //
                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("S");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("00000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();
                    LotSerialClass.Summary.AutoSerialMaxCount.Type("99999");


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 11

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOSRE"))
                {
                    LotSerialClass.OpenScreen();
                    LotSerialClass.Summary.LotSerClassID.Type("SOSRE");
                    LotSerialClass.Summary.Descr.Type("SO serial when received expiration");
                    //
                    LotSerialClass.Summary.LotSerTrackExpiration.SetTrue();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("E");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("000000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();
                    LotSerialClass.Summary.AutoSerialMaxCount.Type("99999");


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 12

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOSUS"))
                {
                    LotSerialClass.OpenScreen();
                    LotSerialClass.Summary.LotSerClassID.Type("SOSUS");
                    LotSerialClass.Summary.Descr.Type("SO serial when used");
                    // 
                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("U");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("000000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();
                    LotSerialClass.Summary.AutoSerialMaxCount.Type("99999");


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 13

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOLRF"))
                {
                    LotSerialClass.OpenScreen();
                    LotSerialClass.Summary.LotSerClassID.Type("SOLRF");
                    LotSerialClass.Summary.Descr.Type("SO lot when received FIFO");

                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("F");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("000000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 14

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOLRL"))
                {
                    LotSerialClass.Insert();
                    LotSerialClass.Summary.LotSerClassID.Type("SOLRL");
                    LotSerialClass.Summary.Descr.Type("SO lot when received LIFO");

                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("L");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("000000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 15

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOLRS"))
                {
                    LotSerialClass.Insert();
                    LotSerialClass.Summary.LotSerClassID.Type("SOLRS");
                    LotSerialClass.Summary.Descr.Type("SO lot when received, Manual");

                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("S");
                    LotSerialClass.Summary.LotSerNumShared.SetFalse();
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 16

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOLRE"))
                {
                    LotSerialClass.Insert();
                    LotSerialClass.Summary.LotSerClassID.Type("SOLRE");
                    LotSerialClass.Summary.Descr.Type("Description, value: SO lot when received, Manual");

                    LotSerialClass.Summary.LotSerTrackExpiration.SetTrue();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("E");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("000000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 17

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOLRM"))
                {
                    LotSerialClass.Insert();
                    LotSerialClass.Summary.LotSerClassID.Type("SOLRM");
                    LotSerialClass.Summary.Descr.Type("SO lot when received, Manual");

                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("R");
                    LotSerialClass.Summary.LotSerIssueMethod.Select("U");
                    LotSerialClass.Summary.LotSerNumShared.SetFalse();
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 18

                using (TestExecution.CreateTestStepGroup("Create lot/serial class SOLUS"))
                {
                    LotSerialClass.Insert();
                    LotSerialClass.Summary.LotSerClassID.Type("SOLUS");
                    LotSerialClass.Summary.Descr.Type("SO lot when used");

                    LotSerialClass.Summary.LotSerTrackExpiration.SetFalse();
                    LotSerialClass.Summary.LotSerAssign.Select("U");
                    LotSerialClass.Summary.LotSerNumShared.SetTrue();
                    LotSerialClass.Summary.LotSerNumVal.Type("000000");
                    LotSerialClass.Summary.AutoNextNbr.SetTrue();


                    LotSerialClass.Save();
                }

                #endregion

                #region Step 19

                using (TestExecution.CreateTestStepGroup("Create item class DEFAULT."))
                {
                    AvailabilityCalculationRules.OpenScreen();
                    AvailabilityCalculationRules.Insert();
                    AvailabilityCalculationRules.GeneralSettings.AvailabilitySchemeID.Type("DEFAULT");
                    AvailabilityCalculationRules.GeneralSettings.Description.Type("DEFAULT");
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINIssues.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBooked.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipped.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipping.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblyDemand.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBackOrdered.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINReceipts.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyInTransit.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOReceipts.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOPrepared.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOOrders.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblySupply.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOReverse.Set(false);
                    AvailabilityCalculationRules.Save();

                    ItemClass.OpenScreen();
                    ItemClass.Insert();

                    ItemClass.Summary.ItemClassCD.Type("DEFAULT");
                    ItemClass.Summary.Descr.Type("DEFAULT");

                    ItemClass.GeneralSettings.StkItem.Set(true);
                    ItemClass.GeneralSettings.NegQty.Set(false);
                    ItemClass.GeneralSettings.ItemType.Select("Finished Good");
                    ItemClass.GeneralSettings.ValMethod.Select("Average");
                    ItemClass.GeneralSettings.TaxCategoryID.Select("EXEMPT");
                    ItemClass.GeneralSettings.PostClassID.Select("DEFAULT");
                    ItemClass.GeneralSettings.LotSerClassID.Select("NN");

                    ItemClass.GeneralSettings.BaseUnit.Select("PIECE");
                    ItemClass.GeneralSettings.SalesUnit.Select("PIECE");
                    ItemClass.GeneralSettings.PurchaseUnit.Select("PIECE");

                    ItemClass.GeneralSettings.AvailabilitySchemeID.Select("DEFAULT");

                    ItemClass.Save();
                }

                #endregion

                #region Step 20

                using (TestExecution.CreateTestStepGroup("Create item class MISC."))
                {
                    AvailabilityCalculationRules.OpenScreen();
                    AvailabilityCalculationRules.Insert();
                    AvailabilityCalculationRules.GeneralSettings.AvailabilitySchemeID.Type("MISC");
                    AvailabilityCalculationRules.GeneralSettings.Description.Type("MISC");
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINIssues.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBooked.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipped.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipping.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblyDemand.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBackOrdered.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINReceipts.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyInTransit.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOReceipts.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOPrepared.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOOrders.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblySupply.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOReverse.Set(true);
                    AvailabilityCalculationRules.Save();

                    ItemClass.OpenScreen();
                    ItemClass.Insert();

                    ItemClass.Summary.ItemClassCD.Type("MISC");
                    ItemClass.Summary.Descr.Type("Miscellaneous");

                    ItemClass.GeneralSettings.StkItem.Set(true);
                    ItemClass.GeneralSettings.NegQty.Set(false);
                    ItemClass.GeneralSettings.ItemType.Select("Finished Good");
                    ItemClass.GeneralSettings.ValMethod.Select("Average");
                    ItemClass.GeneralSettings.TaxCategoryID.Select("EXEMPT");
                    ItemClass.GeneralSettings.PostClassID.Select("CCLASS");
                    ItemClass.GeneralSettings.LotSerClassID.Select("NN");

                    ItemClass.GeneralSettings.BaseUnit.Select("PIECE");
                    ItemClass.GeneralSettings.SalesUnit.Select("PIECE");
                    ItemClass.GeneralSettings.PurchaseUnit.Select("PIECE");

                    ItemClass.GeneralSettings.AvailabilitySchemeID.Select("MISC");

                    ItemClass.Save();
                }

                #endregion

                #region Step 21

                using (TestExecution.CreateTestStepGroup("Create item class CHARGE."))
                {
                    AvailabilityCalculationRules.OpenScreen();
                    AvailabilityCalculationRules.Insert();
                    AvailabilityCalculationRules.GeneralSettings.AvailabilitySchemeID.Type("CHARGE");
                    AvailabilityCalculationRules.GeneralSettings.Description.Type("CHARGE");
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINIssues.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBooked.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipped.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipping.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblyDemand.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBackOrdered.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINReceipts.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyInTransit.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOReceipts.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOPrepared.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOOrders.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblySupply.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOReverse.Set(false);
                    AvailabilityCalculationRules.Save();

                    ItemClass.OpenScreen();
                    ItemClass.Insert();

                    ItemClass.Summary.ItemClassCD.Type("CHARGE");
                    ItemClass.Summary.Descr.Type("Miscellaneous charges");

                    ItemClass.GeneralSettings.StkItem.Set(false);
                    ItemClass.GeneralSettings.NegQty.Set(false);
                    ItemClass.GeneralSettings.ItemType.Select("Non-Stock Item");
                    ItemClass.GeneralSettings.ValMethod.GetValue().VerifyEquals("Standard");
                    ItemClass.GeneralSettings.TaxCategoryID.Select("EXEMPT");
                    ItemClass.GeneralSettings.PostClassID.Select("CCLASS");
                    ItemClass.GeneralSettings.LotSerClassID.IsEnabled().Equals(false);
                    ItemClass.GeneralSettings.AvailabilitySchemeID.IsEnabled().Equals(false);

                    ItemClass.GeneralSettings.BaseUnit.Select("HOUR");
                    ItemClass.GeneralSettings.SalesUnit.Select("HOUR");
                    ItemClass.GeneralSettings.PurchaseUnit.Select("HOUR");

                    ItemClass.Conversions.DoubleClickCell("MINUTE");
                    ItemClass.Conversions.Row.FromUnit.DynamicControl<Selector>().Type("MINUTE");
                    ItemClass.Conversions.Row.UnitMultDiv.Select("Multiply");
                    ItemClass.Conversions.Row.UnitRate.Type(0.016667m);

                    ItemClass.Save();
                }

                #endregion

                #region Step 22

                using (TestExecution.CreateTestStepGroup("Create item class SIFI."))
                {
                    AvailabilityCalculationRules.OpenScreen();
                    AvailabilityCalculationRules.Insert();
                    AvailabilityCalculationRules.GeneralSettings.AvailabilitySchemeID.Type("SIFI");
                    AvailabilityCalculationRules.GeneralSettings.Description.Type("SIFI");
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINIssues.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBooked.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipped.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipping.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblyDemand.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBackOrdered.Set(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINReceipts.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyInTransit.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOReceipts.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOPrepared.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOOrders.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblySupply.Set(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOReverse.Set(false);
                    AvailabilityCalculationRules.Save();

                    ItemClass.OpenScreen();
                    ItemClass.Insert();

                    ItemClass.Summary.ItemClassCD.Type("SIFI");
                    ItemClass.Summary.Descr.Type("Stock Item with FIFO");

                    ItemClass.GeneralSettings.StkItem.Set(true);
                    ItemClass.GeneralSettings.NegQty.Set(false);
                    ItemClass.GeneralSettings.ItemType.Select("Finished Good");
                    ItemClass.GeneralSettings.ValMethod.Select("FIFO");
                    ItemClass.GeneralSettings.PostClassID.Select("CCLASS");

                    ItemClass.GeneralSettings.BaseUnit.Select("PIECE");
                    ItemClass.GeneralSettings.SalesUnit.Select("PIECE");
                    ItemClass.GeneralSettings.PurchaseUnit.Select("PIECE");

                    ItemClass.GeneralSettings.AvailabilitySchemeID.Select("SIFI");

                    ItemClass.Save();
                }

                #endregion

                #region Step 23

                using (TestExecution.CreateTestStepGroup("Inventory preferences"))
                {


                    SetupIn.OpenScreen();
                    SetupIn.GeneralSettings.ARClearingAcctID.Select("102000");
                    SetupIn.GeneralSettings.ARClearingSubID.Type("EUHNBCA");
                    SetupIn.GeneralSettings.INTransitAcctID.Select("120200");
                    SetupIn.GeneralSettings.INTransitSubID.Type("EUHNBCA");
                    SetupIn.GeneralSettings.INProgressAcctID.Select("120200");
                    SetupIn.GeneralSettings.INProgressSubID.Type("EUHNBCA");
                    SetupIn.GeneralSettings.UpdateGL.SetTrue();
                    SetupIn.GeneralSettings.SummPost.GetValue().VerifyEquals(false);
                    SetupIn.GeneralSettings.AutoPost.SetTrue();
                    SetupIn.GeneralSettings.HoldEntry.SetTrue();
                    SetupIn.GeneralSettings.RequireControlTotal.SetFalse();
                    SetupIn.GeneralSettings.DfltStkItemClassID.Select("DEFAULT");
                    SetupIn.GeneralSettings.ReceiptReasonCode.Select("INRECEIPT");
                    SetupIn.GeneralSettings.IssuesReasonCode.Select("INISSUE");
                    SetupIn.GeneralSettings.AdjustmentReasonCode.Select("INADJUST");
                    SetupIn.GeneralSettings.PIReasonCode.Select("STOCKADJ");
                    SetupIn.Save();
                }

                #endregion
            }

            #endregion

            #region Test Case 5

            using (TestExecution.CreateTestCaseGroup("Sales orders preferences"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Setup order type SO"))
                {
                    OrderType.OpenScreen();
                    OrderType.Summary.OrderType.Select("SO");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.OrderNumberingID.Select("SOORDER");
                    OrderType.GeneralSettings.HoldEntry.SetTrue();
                    OrderType.GeneralSettings.CreditHoldEntry.SetTrue();
                    OrderType.GeneralSettings.RequireControlTotal.SetTrue();
                    OrderType.GeneralSettings.BillSeparately.SetTrue();
                    OrderType.GeneralSettings.ShipSeparately.SetFalse();
                    OrderType.GeneralSettings.CalculateFreight.SetTrue();
                    OrderType.GeneralSettings.InvoiceHoldEntry.SetFalse();
                    OrderType.GeneralSettings.FreightAcctID.Select("404002");
                    OrderType.GeneralSettings.FreightAcctDefault.Select("T");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.FreightSubMask.Type("TTTTTTT");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscAcctDefault.Select("T");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUH00CA");
                    OrderType.GeneralSettings.DiscSubMask.Type("TTTTTTT");
                    OrderType.Save();
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Setup order type TR"))
                {
                    OrderType.OpenScreen();
                    OrderType.Summary.OrderType.Select("TR");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.OrderNumberingID.Select("SOORDER");
                    OrderType.GeneralSettings.HoldEntry.SetFalse();
                    OrderType.GeneralSettings.CreditHoldEntry.SetFalse();
                    OrderType.GeneralSettings.RequireControlTotal.SetFalse();
                    OrderType.GeneralSettings.CalculateFreight.SetTrue();
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightAcctDefault.Select("T");
                    OrderType.GeneralSettings.FreightSubID.Type("SGHNBCN");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscAcctDefault.Select("T");
                    OrderType.GeneralSettings.DiscountSubID.Type("SGHNBCN");
                    OrderType.Save();
                }

                #endregion

                #region Step 3

                using (TestExecution.CreateTestStepGroup("Setup order type SA"))
                {
                    OrderType.OpenScreen();
                    OrderType.Summary.OrderType.Select("SA");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.CalculateFreight.SetFalse();
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightAcctDefault.Select("T");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.FreightSubMask.Type("TTTTTTT");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscAcctDefault.Select("T");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUH00CA");
                    OrderType.GeneralSettings.DiscSubMask.Type("TTTTTTT");
                    OrderType.Save();
                }

                #endregion

                #region Step 4

                using (TestExecution.CreateTestStepGroup("Setup order type RR"))
                {
                    OrderType.OpenScreen();
                    OrderType.Summary.OrderType.Select("RR");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.OrderNumberingID.Select("SOORDER");
                    OrderType.GeneralSettings.SalesSubMask.Type("IIIIIII");
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightAcctDefault.Select("T");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.FreightSubMask.Type("TTTTTTT");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscAcctDefault.Select("T");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUH00CA");
                    OrderType.GeneralSettings.DiscSubMask.Type("TTTTTTT");
                    OrderType.Save();
                }

                #endregion

                #region Step 5

                using (TestExecution.CreateTestStepGroup("Setup order type CM"))
                {
                    OrderType.Summary.OrderType.Select("CM");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.OrderNumberingID.Select("SOORDER");
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUHNBCN");
                    OrderType.Save();
                }

                #endregion

                #region Step 6

                using (TestExecution.CreateTestStepGroup("Setup order type CR"))
                {
                    OrderType.OpenScreen();
                    OrderType.Summary.OrderType.Select("CR");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUHNBCN");
                    OrderType.Save();
                }

                #endregion

                #region Step 7

                using (TestExecution.CreateTestStepGroup("Setup order type CS"))
                {
                    OrderType.Summary.OrderType.Select("CS");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.OrderNumberingID.Select("SOORDER");
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUHNBCN");
                    OrderType.Save();
                }

                #endregion

                #region Step 8

                using (TestExecution.CreateTestStepGroup("Setup order type IN"))
                {
                    OrderType.Summary.OrderType.Select("IN", "Order Type");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUHNBCN");
                    OrderType.Save();
                }

                #endregion

                #region Step 9

                using (TestExecution.CreateTestStepGroup("Setup order type QT"))
                {
                    OrderType.Summary.OrderType.Select("QT");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUH00CA");
                    OrderType.Save();
                }

                #endregion

                #region Step 10

                using (TestExecution.CreateTestStepGroup("Setup order type RC"))
                {
                    OrderType.Summary.OrderType.Select("RC");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.OrderNumberingID.Select("SOORDER");
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUH00CA");
                    OrderType.Save();
                }

                #endregion

                #region Step 11

                using (TestExecution.CreateTestStepGroup("Setup order type RM"))
                {
                    OrderType.Summary.OrderType.Select("RM");
                    OrderType.Summary.Active.SetTrue();
                    OrderType.GeneralSettings.OrderNumberingID.Select("SOORDER");
                    OrderType.GeneralSettings.FreightAcctID.Select("655000");
                    OrderType.GeneralSettings.FreightSubID.Type("EUHNBCN");
                    OrderType.GeneralSettings.DiscountAcctID.Select("490000");
                    OrderType.GeneralSettings.DiscountSubID.Type("EUHNBCN");
                    OrderType.Save();
                }

                #endregion

                #region Step 12

                using (TestExecution.CreateTestStepGroup("Setup sales orders preferences"))
                {
                    SetupSo.OpenScreen();
                    SetupSo.GeneralSettings.ShipmentNumberingID.GetValue().VerifyEquals("SOSHIPMENT", StringVerificationMask.SplitAndGetFirst);
                    SetupSo.GeneralSettings.HoldShipments.GetValue().VerifyEquals(true);
                    SetupSo.GeneralSettings.RequireShipmentTotal.GetValue().VerifyEquals(true);
                    SetupSo.GeneralSettings.CreditCheckError.SetTrue();
                    SetupSo.GeneralSettings.UseShipDateForInvoiceDate.SetTrue();
                    SetupSo.GeneralSettings.AutoReleaseIN.SetTrue();
                    SetupSo.Save();
                }

                #endregion
            }

            #endregion

            #region Test Case 6

            using (TestExecution.CreateTestCaseGroup("Boxes settings"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Create box LARGE"))
                {
                    Box.OpenScreen();
                    Box.New();
                    Box.Boxes.Row.BoxID.Type("LARGE");
                    Box.Boxes.Row.Description.Type("Large Box");
                    Box.Boxes.Row.MaxWeight.Type(10);
                    Box.Boxes.Row.CarrierBox.Type("Lg Flat Rate Box");
                    Box.Boxes.Row.ActiveByDefault.SetTrue();
                    Box.ToolBar.Save.Click();
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Create box MEDIUM"))
                {
                    Box.New();
                    Box.Boxes.Row.BoxID.Type("MEDIUM");
                    Box.Boxes.Row.Description.Type("Medium Box");
                    Box.Boxes.Row.MaxWeight.Type(5);
                    Box.Boxes.Row.CarrierBox.Type("Md Flat Rate Box");
                    Box.Boxes.Row.ActiveByDefault.SetTrue();
                    Box.ToolBar.Save.Click();
                }

                #endregion

                #region Step 3

                using (TestExecution.CreateTestStepGroup("Create box SMALL"))
                {
                    Box.New();
                    Box.Boxes.Row.BoxID.Type("SMALL");
                    Box.Boxes.Row.Description.Type("Small Box");
                    Box.Boxes.Row.MaxWeight.Type(1);
                    Box.Boxes.Row.CarrierBox.Type("Sm Flat Rate Box");
                    Box.Boxes.Row.ActiveByDefault.SetTrue();
                    Box.ToolBar.Save.Click();
                }

                #endregion
            }

            #endregion

            #region Test Case 7

            ////using (TestExecution.CreateTestCaseGroup("Carriers settings"))
            ////{
            ////    #region Step 7.1. Add new carrier UPS

            ////    using (TestExecution.CreateTestStepGroup("Add new carrier UPS"))
            ////    {
            ////        Carrier.OpenScreen();
            ////        Carrier.Insert();
            ////        Carrier.Summary.CarrierPluginID.Type("USPS");
            ////        Carrier.Summary.Description.Type("USPS Carrier");
            ////        Carrier.Summary.PluginTypeName.Select("PX.UpsCarrier.UpsCarrier");
            ////        Carrier.Summary.UnitType.Select("US Units (Pound/Inch)");
            ////        Carrier.Summary.PoundUOM.Select("POUND");
            ////        Carrier.Summary.InchUOM.Select("INCH");

            ////        Carrier.PluginParameters.SelectRow("ID", "ACCESSNUM");
            ////        Carrier.PluginParameters.Row.Value.Type(SecurityConfig.GetAccount("UPSCarrier").Accessnum);
            ////        Carrier.PluginParameters.SelectRow("ID", "ACCOUNTID");
            ////        Carrier.PluginParameters.Row.Value.Type(SecurityConfig.GetAccount("UPSCarrier").Accountid);
            ////        Carrier.PluginParameters.SelectRow("ID", "ENDPOINT");
            ////        Carrier.PluginParameters.Row.Value.Type(@"https://wwwcie.ups.com/webservices/Rate");
            ////        Carrier.PluginParameters.SelectRow("ID", "LABEL FORMAT");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<DropDown>().Select("GIF");
            ////        Carrier.PluginParameters.SelectRow("ID", "LOGIN");
            ////        Carrier.PluginParameters.Row.Value.Type(SecurityConfig.GetAccount("UPSCarrier").Login);
            ////        Carrier.PluginParameters.SelectRow("ID", "LOGTRACE");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<CheckBox>().SetTrue();
            ////        Carrier.PluginParameters.SelectRow("ID", "PASSWORD");
            ////        Carrier.PluginParameters.Row.Value.Type(SecurityConfig.GetAccount("UPSCarrier").Password);
            ////        Carrier.PluginParameters.SelectRow("ID", "PICKUP TYPE");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<DropDown>().Select("Daily Pickup");
            ////        Carrier.PluginParameters.SelectRow("ID", "NOTIFY");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<CheckBox>().SetTrue();
            ////        Carrier.PluginParameters.SelectRow("ID", "SHIP ENDPOINT");
            ////        Carrier.PluginParameters.Row.Value.Type(@"https://wwwcie.ups.com/webservices/Ship");
            ////        Carrier.PluginParameters.SelectRow("ID", "SHIPPER FROM");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<DropDown>().Select("Company Branch");
            ////        Carrier.PluginParameters.SelectRow("ID", "SIGNATURE");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<DropDown>().Select("Delivery Confirmation Adult Signature Required");
            ////        Carrier.PluginParameters.SelectRow("ID", "SUREPOST END");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<DropDown>().Select("Address Service Requested");
            ////        Carrier.PluginParameters.SelectRow("ID", "SUREPOST SUB");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<DropDown>().Select("Machinable");
            ////        Carrier.PluginParameters.SelectRow("ID", "TEST MODE");
            ////        Carrier.PluginParameters.Row.Value.DynamicControl<CheckBox>().SetTrue();
            ////        Carrier.PluginParameters.SelectRow("ID", "TNT ENDPOINT");
            ////        Carrier.PluginParameters.Row.Value.Type(@"https://wwwcie.ups.com/webservices/TimeInTransit");
            ////        Carrier.PluginParameters.SelectRow("ID", "VOID ENDPOINT");
            ////        Carrier.PluginParameters.Row.Value.Type(@"https://wwwcie.ups.com/webservices/Void");

            ////        Carrier.Save();
            ////    }

            ////    #endregion
            ////}

            #endregion

            #region Test Case 8

            using (TestExecution.CreateTestCaseGroup("Load a FOB Points"))
            {
                FobPoint.OpenScreen();
                FobPoint.Upload();
                FobPoint.Details.UploadForm.SelectFile(@"C:\Users\aaron.beehoo\Downloads\ISVTestSDK\ISVTestSDK\ISVTestSDK\Configuration\Data\Cc110_FobPoints.csv");
                FobPoint.Details.UploadForm.Upload();
                FobPoint.CsvImportSettings.Ok();
                FobPoint.ImportColumns.Ok();
                FobPoint.Save();
            }

            #endregion

            #region Test Case 9

            using (TestExecution.CreateTestCaseGroup("Cash management settings"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Configure payment method"))
                {
                    PaymentMethod.OpenScreen();
                    PaymentMethod.Summary.PaymentMethodID.Select("CHECK");
                    PaymentMethod.Summary.UseForAR.SetTrue();
                    PaymentMethod.CashAccounts.Row.ARIsDefault.SetTrue();
                    PaymentMethod.Save();
                }

                #endregion
            }

            #endregion

            #region Test Case 10

            using (TestExecution.CreateTestCaseGroup("Accounts receivable preferences"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Create statement cycle EOM"))
                {
                    StatementCycle.OpenScreen();
                    StatementCycle.ToolBar.Insert.Click();
                    StatementCycle.Summary.StatementCycleId.Type("EOM");
                    StatementCycle.Summary.Descr.Type("End Of Month");
                    StatementCycle.Summary.PrepareOn.Select("E");
                    StatementCycle.Summary.AgeDays00.Type(10);
                    StatementCycle.Summary.AgeMsg00.Type("0 to 10");
                    StatementCycle.Summary.AgeDays01.Type(30);
                    StatementCycle.Summary.AgeMsg01.Type("11 to 30");
                    StatementCycle.Summary.AgeDays02.Type(60);
                    StatementCycle.Summary.AgeMsg02.Type("31 to 60");
                    StatementCycle.Summary.AgeMsg03.Type("Over 60");
                    StatementCycle.Save();
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Create Credit Terms 07D"))
                {
                    CreditTerms.OpenScreen();
                    CreditTerms.Insert();
                    CreditTerms.Terms.TermsID.Type("07D");
                    CreditTerms.Terms.Descr.Type("7 Days");
                    CreditTerms.Terms.VisibleTo.Select("AL");
                    CreditTerms.Terms.DueType.Select("N");
                    CreditTerms.Terms.DayDue00.Type(7);
                    CreditTerms.Save();
                }

                #endregion

                #region Step 3

                using (TestExecution.CreateTestStepGroup("Create customer class DEFAULT"))
                {
                    CustomerClassAr.OpenScreen();
                    CustomerClassAr.Insert();
                    CustomerClassAr.Summary.CustomerClassID.Type("DEFAULT");
                    CustomerClassAr.Summary.Descr.Type("DEFAULT");
                    CustomerClassAr.GeneralSettings.CountryID.Select("US");
                    CustomerClassAr.GeneralSettings.ShipComplete.Select("L");
                    CustomerClassAr.GeneralSettings.CreditRule.Select("N");
                    CustomerClassAr.GeneralSettings.TermsID.Select("07D");
                    CustomerClassAr.GeneralSettings.StatementCycleId.Select("EOM");
                    CustomerClassAr.GeneralSettings.CuryID.Select("USD");
                    CustomerClassAr.GeneralSettings.ARAcctID.Select("110000");
                    CustomerClassAr.GeneralSettings.ARSubID.Type("EUH00CN");
                    CustomerClassAr.GeneralSettings.SalesAcctID.Select("400000");
                    CustomerClassAr.GeneralSettings.SalesSubID.Type("EUH00CN");
                    CustomerClassAr.GeneralSettings.DiscTakenAcctID.Select("595000");
                    CustomerClassAr.GeneralSettings.DiscTakenSubID.Type("EUH00CN");
                    CustomerClassAr.GeneralSettings.SavePaymentProfiles.Select("Always");
                    CustomerClassAr.Save();
                }

                #endregion

                #region Step 4

                using (TestExecution.CreateTestStepGroup("Create customer class CF"))
                {
                    CustomerClassAr.Insert();
                    CustomerClassAr.Summary.CustomerClassID.Type("CF");
                    CustomerClassAr.Summary.Descr.Type("Credit Limit Verification");
                    CustomerClassAr.GeneralSettings.CountryID.Select("US");
                    CustomerClassAr.GeneralSettings.CreditRule.Select("C");
                    CustomerClassAr.GeneralSettings.CreditLimit.Type(2000);
                    CustomerClassAr.GeneralSettings.OverLimitAmount.Type(500);
                    CustomerClassAr.GeneralSettings.TermsID.Select("07D");
                    CustomerClassAr.GeneralSettings.StatementCycleId.Select("EOM");
                    CustomerClassAr.GeneralSettings.CuryID.Select("USD");
                    CustomerClassAr.GeneralSettings.ARAcctID.Select("110000");
                    CustomerClassAr.GeneralSettings.ARSubID.Type("EUH00CN");
                    CustomerClassAr.GeneralSettings.SalesAcctID.Select("400000");
                    CustomerClassAr.GeneralSettings.SalesSubID.Type("EUH00CN");
                    CustomerClassAr.GeneralSettings.DiscTakenAcctID.Select("595000");
                    CustomerClassAr.GeneralSettings.DiscTakenSubID.Type("EUH00CN");
                    CustomerClassAr.Save();
                }

                #endregion

                #region Step 5

                using (TestExecution.CreateTestStepGroup("Configure accounts receivable preferences"))
                {
                    SetupAr.OpenScreen();
                    SetupAr.GeneralSettings.AutoPost.SetTrue();
                    SetupAr.GeneralSettings.SummaryPost.GetValue().VerifyEquals(false);
                    SetupAr.GeneralSettings.DfltCustomerClassID.Select("DEFAULT");
                    SetupAr.GeneralSettings.SalesSubMask.GetValue().VerifyEquals("LLLLLLL", StringVerificationMask.SubAccount);
                    SetupAr.GeneralSettings.HoldEntry.SetTrue();
                    SetupAr.GeneralSettings.RequireControlTotal.SetFalse();
                    SetupAr.Save();
                }

                #endregion
            }

            #endregion

            #region Test Case 11

            using (TestExecution.CreateTestCaseGroup("Create warehouses"))
            {
                #region Step 2

                using (TestExecution.CreateTestStepGroup("Import warehouses using IS"))
                {
                    ImportByScenario.ImportEntities(Warehouse, "Cc110_Warehouse.xlsx", 15);
                    Warehouse.OpenScreen();
                    Warehouse.Summary.SiteCD.Select("WHOLESALE");
                    Warehouse.DefaultLocations.ReturnLocationID.GetValue().VerifyEquals("RMA - RMA");
                }

                #endregion
            }

            #endregion

            #region Test Case 12

            using (TestExecution.CreateTestCaseGroup("Non-stock items"))
            {
                using (TestExecution.CreateTestStepGroup("Import Non-stock items using IS"))
                {
                    ImportByScenario.ImportEntities(NonStockItem, "Cc110_NonStockItem.xlsx", 11);
                }

                using (TestExecution.CreateTestStepGroup("Fix posting class"))
                {
                    PostingClass.OpenScreen();
                    PostingClass.Summary.PostClassID.Select("CCLASS");
                    //Unable to set this value from the begining becouse it is invalid for non-stock item and their Import fails
                    PostingClass.GLAccounts.InvtAcctID.Select("120000");
                    PostingClass.Save();
                }
            }

            #endregion

            #region Test Case 13

            using (TestExecution.CreateTestCaseGroup("Shipping zones"))
            {
                using (TestExecution.CreateTestStepGroup("Add shipping zones"))
                {
                    ShippingZones.OpenScreen();

                    ShippingZones.New();
                    ShippingZones.Details.Row.ZoneID.Type("SZ0001");
                    ShippingZones.Details.Row.Description.Type("Shipping Zone 0001");

                    ShippingZones.New();
                    ShippingZones.Details.Row.ZoneID.Type("SZ0002");
                    ShippingZones.Details.Row.Description.Type("Shipping Zone 0002");

                    ShippingZones.Save();
                }
            }

            #endregion

            #region Test Case 14

            using (TestExecution.CreateTestCaseGroup("Shipping terms"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Add new shipping terms: DEFAULT"))
                {
                    ShipmentTerms.OpenScreen();
                    ShipmentTerms.Insert();
                    ShipmentTerms.Summary.ShipTermsID.Type("DEFAULT");
                    ShipmentTerms.Summary.Description.Type("DEFAULT");
                    ShipmentTerms.Details.New();
                    ShipmentTerms.Details.Row.BreakAmount.Type(3000);
                    ShipmentTerms.Details.Row.FreightCostPercent.Type(3);
                    ShipmentTerms.Details.Row.InvoiceAmountPercent.Type(5);
                    ShipmentTerms.Details.Row.ShippingHandling.Type(300);
                    ShipmentTerms.Details.Row.LineHandling.Type(150);
                    ShipmentTerms.Details.New();
                    ShipmentTerms.Details.Row.BreakAmount.Type(5000);
                    ShipmentTerms.Details.Row.FreightCostPercent.Type(6);
                    ShipmentTerms.Details.Row.InvoiceAmountPercent.Type(8);
                    ShipmentTerms.Details.Row.ShippingHandling.Type(410);
                    ShipmentTerms.Details.Row.LineHandling.Type(230);
                    ShipmentTerms.Details.New();
                    ShipmentTerms.Details.Row.BreakAmount.Type(9000);
                    ShipmentTerms.Details.Row.FreightCostPercent.Type(9);
                    ShipmentTerms.Details.Row.InvoiceAmountPercent.Type(23);
                    ShipmentTerms.Details.Row.ShippingHandling.Type(510);
                    ShipmentTerms.Details.Row.LineHandling.Type(310);
                    ShipmentTerms.Save();
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Add new shipping terms: BASIC"))
                {
                    ShipmentTerms.Insert();
                    ShipmentTerms.Summary.ShipTermsID.Type("BASIC");
                    ShipmentTerms.Summary.Description.Type("BASIC");
                    ShipmentTerms.Details.New();
                    ShipmentTerms.Details.Row.BreakAmount.Type(0);
                    ShipmentTerms.Details.Row.FreightCostPercent.Type(100);
                    ShipmentTerms.Details.Row.InvoiceAmountPercent.Type(0);
                    ShipmentTerms.Details.Row.ShippingHandling.Type(0);
                    ShipmentTerms.Details.Row.LineHandling.Type(0);
                    ShipmentTerms.Save();
                }

                #endregion
            }

            #endregion

            #region Test Case 15

            using (TestExecution.CreateTestCaseGroup("Ship via settings"))
            {
                #region Step 1

                //UPS carrier for 
                using (TestExecution.CreateTestStepGroup("Add new ship via code: USPSPRIORITY"))
                {
                    ShipVia.OpenScreen();
                    ShipVia.Insert();
                    ShipVia.Summary.CarrierID.Type("USPSPRIORITY");
                    ShipVia.Summary.Description.Type("USPS Priority");
                    ShipVia.Summary.IsExternal.SetTrue();

                    ShipVia.CarrierDetails.CarrierPluginID.Select("USPS");
                    ShipVia.CarrierDetails.PluginMethod.Select("03");
                    ShipVia.CarrierDetails.IsCommonCarrier.SetTrue();
                    ShipVia.CarrierDetails.ConfirmationRequired.SetFalse();
                    ShipVia.CarrierDetails.PackageRequired.SetTrue();

                    ShipVia.CarrierDetails.TaxCategoryID.Select("EXEMPT");
                    ShipVia.CarrierDetails.FreightSalesAcctID.Select("575000");
                    ShipVia.CarrierDetails.FreightSalesSubID.Type("00-000-00");
                    ShipVia.CarrierDetails.FreightExpenseAcctID.Select("655000");
                    ShipVia.CarrierDetails.FreightExpenseSubID.Type("00-000-00");
                    ShipVia.Save();
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Add new ship via code: Ship Via: Per Unit"))
                {
                    ShipVia.Insert();
                    ShipVia.Summary.CarrierID.Type("SVPU");
                    ShipVia.Summary.Description.Type("Ship Via: Per Unit");

                    ShipVia.CarrierDetails.CalcMethod.Select("P");
                    ShipVia.CarrierDetails.BaseRate.Type(50);
                    ShipVia.CarrierDetails.TaxCategoryID.Select("EXEMPT");
                    ShipVia.CarrierDetails.FreightSalesAcctID.Select("404001");
                    ShipVia.CarrierDetails.FreightSalesSubID.Type("SGHNBCN");
                    ShipVia.CarrierDetails.FreightExpenseAcctID.Select("655000");
                    ShipVia.CarrierDetails.FreightExpenseSubID.Type("SGHNBCN");

                    ShipVia.FreightRates.New();
                    ShipVia.FreightRates.Row.Weight.Type(1);
                    ShipVia.FreightRates.Row.Volume.Type(0);
                    ShipVia.FreightRates.Row.ZoneID.Select("SZ0001");
                    ShipVia.FreightRates.Row.Rate.Type(3);
                    ShipVia.FreightRates.New();
                    ShipVia.FreightRates.Row.Weight.Type(1);
                    ShipVia.FreightRates.Row.Volume.Type(0);
                    ShipVia.FreightRates.Row.ZoneID.Select("SZ0002");
                    ShipVia.FreightRates.Row.Rate.Type(5);
                    ShipVia.FreightRates.New();
                    ShipVia.FreightRates.Row.Weight.Type(5);
                    ShipVia.FreightRates.Row.Volume.Type(0);
                    ShipVia.FreightRates.Row.ZoneID.Select("SZ0001");
                    ShipVia.FreightRates.Row.Rate.Type(12);
                    ShipVia.FreightRates.New();
                    ShipVia.FreightRates.Row.Weight.Type(5);
                    ShipVia.FreightRates.Row.Volume.Type(0);
                    ShipVia.FreightRates.Row.ZoneID.Select("SZ0002");
                    ShipVia.FreightRates.Row.Rate.Type(15);

                    ShipVia.Save();
                    ShipVia.CopyDocument();
                }

                #endregion

                #region Step 3

                using (TestExecution.CreateTestStepGroup("Add new ship via code: Ship Via: Manual"))
                {
                    ShipVia.Insert();
                    ShipVia.Summary.CarrierID.Type("SVMN");
                    ShipVia.PasteDocument();

                    ShipVia.Summary.Description.Type("Ship Via: Manual");
                    ShipVia.CarrierDetails.CalcMethod.Select("M");

                    ShipVia.FreightRates.SelectRow(1);
                    ShipVia.FreightRates.Row.Rate.Type(36);
                    ShipVia.FreightRates.SelectRow(2);
                    ShipVia.FreightRates.Row.Rate.Type(39);
                    ShipVia.FreightRates.SelectRow(3);
                    ShipVia.FreightRates.Row.Rate.Type(49);
                    ShipVia.FreightRates.SelectRow(4);
                    ShipVia.FreightRates.Row.Rate.Type(53);

                    ShipVia.Save();
                }

                #endregion

                #region Step 4

                using (TestExecution.CreateTestStepGroup("Add new ship via code: Ship Via: Net"))
                {
                    ShipVia.Insert();
                    ShipVia.Summary.CarrierID.Type("SVNT");
                    ShipVia.PasteDocument();

                    ShipVia.Summary.Description.Type("Ship Via: Net");
                    ShipVia.CarrierDetails.CalcMethod.Select("N");
                    ShipVia.CarrierDetails.BaseRate.Type(30);

                    ShipVia.FreightRates.SelectRow(1);
                    ShipVia.FreightRates.Row.Rate.Type(4);
                    ShipVia.FreightRates.SelectRow(2);
                    ShipVia.FreightRates.Row.Rate.Type(6);
                    ShipVia.FreightRates.SelectRow(3);
                    ShipVia.FreightRates.Row.Rate.Type(21);
                    ShipVia.FreightRates.SelectRow(4);
                    ShipVia.FreightRates.Row.Rate.Type(25);

                    ShipVia.Save();
                }

                #endregion
            }

            #endregion

            #region Test Case 16

            ////using (TestExecution.CreateTestCaseGroup("Create stock items"))
            ////{
            ////    using (TestExecution.CreateTestStepGroup("Import Stock items using IS"))
            ////    {
            ////        ImportByScenario.ImportEntities(StockItem, "Cc110_StockItem.xlsx", 26);
            ////    }
            ////}

            #endregion

            #region Test Case 17

            using (TestExecution.CreateTestCaseGroup("Create customers"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Create customer: SO00000009"))
                {
                    CustomerAr.OpenScreen();
                    CustomerAr.Insert();

                    CustomerAr.Summary.AcctCD.Type("SO00000009");
                    CustomerAr.GeneralSettings.AcctName.Type("SO customer #009");

                    CustomerAr.Accounts.CARAccountID.Select("110000");
                    CustomerAr.Accounts.CARSubID.Type("EUH00CN");
                    CustomerAr.Accounts.CSalesAcctID.Select("400000");
                    CustomerAr.Accounts.CSalesSubID.Type("EUH00CN");

                    CustomerAr.Save();
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Create customers using IS"))
                {
                    ImportByScenario.ImportEntities(CustomerAr, "Cc110_Customers.xlsx", 18);
                }

                #endregion
            }

            #endregion

            #region Test Case 18

            using (TestExecution.CreateTestCaseGroup("Check default settings"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Checking availability calculation in item class"))
                {
                    ItemClass.OpenScreen();
                    ItemClass.Insert();
                    ItemClass.GeneralSettings.StkItem.GetValue().VerifyEquals(true);
                    ItemClass.GeneralSettings.NegQty.GetValue().VerifyEquals(false);
                    ItemClass.GeneralSettings.ItemType.GetValue().VerifyEquals("Finished Good");
                    ItemClass.GeneralSettings.PostClassID.GetValue().VerifyEquals("DEFAULT", StringVerificationMask.SplitAndGetFirst);
                    ItemClass.GeneralSettings.ValMethod.GetValue().VerifyEquals("Average");
                    ItemClass.GeneralSettings.TaxCategoryID.GetValue().VerifyEquals("EXEMPT", StringVerificationMask.SplitAndGetFirst);
                    ItemClass.GeneralSettings.LotSerClassID.GetValue().VerifyEquals("NN", StringVerificationMask.SplitAndGetFirst);
                    ItemClass.GeneralSettings.BaseUnit.GetValue().VerifyEquals("PIECE");
                    ItemClass.GeneralSettings.SalesUnit.GetValue().VerifyEquals("PIECE");
                    ItemClass.GeneralSettings.PurchaseUnit.GetValue().VerifyEquals("PIECE");

                    AvailabilityCalculationRules.OpenScreen();
                    AvailabilityCalculationRules.Insert();
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINIssues.GetValue().VerifyEquals(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBooked.GetValue().VerifyEquals(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipped.GetValue().VerifyEquals(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOShipping.GetValue().VerifyEquals(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblyDemand.GetValue().VerifyEquals(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOBackOrdered.GetValue().VerifyEquals(true);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINReceipts.GetValue().VerifyEquals(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyInTransit.GetValue().VerifyEquals(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOReceipts.GetValue().VerifyEquals(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOPrepared.GetValue().VerifyEquals(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyPOOrders.GetValue().VerifyEquals(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtyINAssemblySupply.GetValue().VerifyEquals(false);
                    AvailabilityCalculationRules.GeneralSettings.InclQtySOReverse.GetValue().VerifyEquals(false);
                }

                #endregion
            }

            #endregion

            #region Test Case 19

            using (TestExecution.CreateTestCaseGroup("Customer location settings"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Change freight account for customer: SO00000001"))
                {
                    CustomerLocation.OpenScreen();
                    CustomerLocation.Summary.BAccountID.Select("SO00000001");
                    CustomerLocation.Accounts.CFreightAcctID.Select("404003");
                    CustomerLocation.Accounts.CFreightSubID.Type("USSERSG");
                    CustomerLocation.Save();
                }

                #endregion
            }

            #endregion



            #region Test Case 21

            using (TestExecution.CreateTestCaseGroup("Sales persons settings"))
            {
                #region SP1 - Sam Johnson

                using (TestExecution.CreateTestStepGroup("Create new salesperson : SP1 - Sam Johnson"))
                {
                    Salesperson.OpenScreen();
                    Salesperson.Insert();
                    Salesperson.Summary.SalesPersonCD.Type("SP1");
                    Salesperson.Summary.Descr.Type("Sam Johnson");
                    Salesperson.Summary.CommnPct.Type(3);
                    Salesperson.Summary.SalesSubID.Type("SPSPOSP");
                    Salesperson.Customers.New();
                    Salesperson.Customers.Row.BAccountID.Select("SO00000001");
                    Salesperson.Customers.Row.CommisionPct.Type(3);
                    Salesperson.Save();
                }

                #endregion

                #region SP2 - TST2

                using (TestExecution.CreateTestStepGroup("Create new salesperson : SP2 - TST2"))
                {
                    Salesperson.Insert();
                    Salesperson.Summary.SalesPersonCD.Type("SP2");
                    Salesperson.Summary.Descr.Type("TST2");
                    Salesperson.Summary.CommnPct.Type(3);
                    Salesperson.Summary.SalesSubID.Type("0000000");
                    Salesperson.Customers.New();
                    Salesperson.Customers.Row.BAccountID.Select("SO00000001");
                    Salesperson.Customers.Row.CommisionPct.Type(3);
                    Salesperson.Save();

                    Salesperson.CopyDocument();
                }

                #endregion

                #region SP3 - TST3

                using (TestExecution.CreateTestStepGroup("Create new salesperson : SP3 - TST3"))
                {
                    Salesperson.Insert();
                    Salesperson.Summary.SalesPersonCD.Type("SP3");
                    Salesperson.PasteDocument();

                    Salesperson.Summary.Descr.Type("TST3");
                    Salesperson.Save();
                }

                #endregion
            }

            #endregion

            #region Test Case 22

            using (TestExecution.CreateTestCaseGroup("Employee and Users"))
            {
                #region Step 1

                using (TestExecution.CreateTestStepGroup("Create employee class"))
                {
                    EmployeeClass.OpenScreen();
                    EmployeeClass.Insert();
                    EmployeeClass.Summary.VendorClassID.Type("EMP01");
                    EmployeeClass.Summary.Descr.Type("Test Employee Class");
                    EmployeeClass.GeneralSettings.DiscTakenAcctID.Select("595000");
                    EmployeeClass.GeneralSettings.DiscTakenSubID.Type("EMEMPEM");
                    EmployeeClass.GeneralSettings.SalesAcctID.Select("400006");
                    EmployeeClass.GeneralSettings.SalesSubID.Type("EMEMPEM");
                    EmployeeClass.Save();
                }

                #endregion

                #region Step 2

                using (TestExecution.CreateTestStepGroup("Create work calendar"))
                {
                    WorkCalendar.OpenScreen();
                    WorkCalendar.Insert();
                    WorkCalendar.Summary.CalendarID.Type("STD");
                    WorkCalendar.Summary.Description.Type("Standart calendar");
                    WorkCalendar.Save();
                }

                #endregion

                #region Step 3

                using (TestExecution.CreateTestStepGroup("Create departments"))
                {
                    Department.OpenScreen();

                    Department.New();
                    Department.Details.Row.DepartmentID.Type("MAIN");
                    Department.Details.Row.Description.Type("Main department");
                    Department.New();
                    Department.Details.Row.DepartmentID.Type("DEP2");
                    Department.Details.Row.Description.Type("Test Department 2");
                    Department.New();
                    Department.Details.Row.DepartmentID.Type("DEP3");
                    Department.Details.Row.Description.Type("Test Department 3");
                    Department.New();
                    Department.Details.Row.DepartmentID.Type("DEP4");
                    Department.Details.Row.Description.Type("Test Department 4");

                    Department.Save();
                }

                #endregion

                #region Step 4

                using (TestExecution.CreateTestStepGroup("Create new Employees"))
                {
                    using (TestExecution.CreateGroup("Import Employee using IS"))
                    {
                        ImportByScenario.ImportEntities(Employee, "Cc110_Employees.xlsx", 10);
                    }

                    using (TestExecution.CreateGroup("Change Settings Employee: TST3"))
                    {
                        Employee.OpenScreen();
                        Employee.Summary.AcctCD.Select("TST3");
                        Employee.EmployeeSettings.SupervisorID.Select("TST9");
                        Employee.EmployeeSettings.SalesPersonID.Select("SP3");
                        Employee.Save();

                        Employee.Address.CountryID.GetValue().VerifyEquals("US", StringVerificationMask.SplitAndGetFirst);
                        Employee.EmployeeSettings.VendorClassID.GetValue().VerifyEquals("EMP01", StringVerificationMask.SplitAndGetFirst);
                        Employee.EmployeeSettings.DepartmentID.GetValue().VerifyEquals("DEP3", StringVerificationMask.SplitAndGetFirst);
                        Employee.EmployeeSettings.CalendarID.GetValue().VerifyEquals("STD", StringVerificationMask.SplitAndGetFirst);
                        Employee.Contact.EMail.GetValue().VerifyEquals("tst@mail.con");
                        Employee.EmployeeSettings.ExpenseAcctID.GetValue().VerifyEquals("770000", StringVerificationMask.SplitAndGetFirst);
                        Employee.EmployeeSettings.ExpenseSubID.GetValue().VerifyEquals("EMEMPEM", StringVerificationMask.SubAccount);
                        Employee.EmployeeSettings.SalesSubID.GetValue().VerifyEquals("EMEMPEM", StringVerificationMask.SubAccount);
                    }
                }

                #endregion

                #region Step 5

                using (TestExecution.CreateTestStepGroup("Create new Users"))
                {
                    User.OpenScreen();

                    using (TestExecution.CreateGroup("Link employee with user: admin"))
                    {
                        User.Summary.Username.Select("admin");
                        User.Summary.ContactID.Select("TstLastName1, TstFirstName1");
                        User.Save();
                    }

                    for (int i = 2; i <= 10; ++i)
                        using (TestExecution.CreateGroup($"Create new User: USTST{i}"))
                        {
                            User.Insert();
                            User.Summary.Username.Type("USTST" + i);
                            User.Summary.ContactID.Select($"TstLastName{i}, TstFirstName{i}");

                            User.Roles.SelectRow(User.Roles.Columns.Rolename, "Administrator");
                            User.Roles.Row.Selected.SetTrue();
                            User.Save();

                            User.ResetPassword();
                            User.Summary.NewPassword.Reset();
                            User.Summary.NewPassword.Type("setup");
                            User.Summary.ConfirmPassword.Reset();
                            User.Summary.ConfirmPassword.Type("setup");
                            User.Summary.Ok();
                        }
                }

                #endregion
            }

            #endregion


        }
    }
}
