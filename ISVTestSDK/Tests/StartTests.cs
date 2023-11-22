using Core.Login;
using Core.TestExecution;

//namespace of all tests, extensions, wrappers, and helper files
//should be the same as below, with SOLUTIONNAME being your registered solution name
//in all capitals from the ISV Solutions page of the Acumatica Partner Portal.
namespace GeneratedWrappers.SOLUTIONNAME
{
    internal class StartTests
    {
        public void Execute() // launch your tests in order from this method
        {
            PxLogin.LoginToDestinationSite();
            using (TestExecution.CreateTestStepGroup("Config site to the test start state"))
            {
                //Assumed Start State is fresh install of Acumatica Sales Demo Data
                //plus your customization published
                ConfigWebsite configWebsite = new ConfigWebsite();
                configWebsite.ConfigForWrapperGeneration();
                configWebsite.ConfigWebsiteFromSalesDemo();
            }
            using (TestExecution.CreateTestStepGroup("Main Tests"))
            {
                BasicExampleTests basicExampleTests = new BasicExampleTests();
                basicExampleTests.BasicTest();
                basicExampleTests.GenericInquiryViewExample();

                ExcelExample excelExample = new ExcelExample();
                excelExample.ExcelDataEntryExample();
            }
        }
    }
}
