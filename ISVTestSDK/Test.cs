using ClassGenerator;
using Core.Login;
using Core.TestExecution;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace GeneratedWrappers.SOLUTIONNAME
{
    public class Test : Check
    {
        // Ensure to follow the readme.md steps for this project before running as to properly configure it.
        // https://github.com/Acumatica/Test-SDK-Starter-Guide/blob/master/README.md
        const string physicalSitePath = @"C:\AcumaticaSites\23r2";        
        public override void Execute()
        {
            PxLogin.LoginToDestinationSite();

            ConfigWebsite configWebsite = new ConfigWebsite();
            configWebsite.CreateBackup();
            //configWebsite.RestoreBackup();

            configWebsite.ImportCustomization(); //imports all packages to be in /CustomizationPackages folder
            configWebsite.PublishCustomization();
            configWebsite.ConfigForWrapperGeneration();
            
            // GenerateWrappers takes 10-30 minutes to run,
            // Do not close it manually or else you will need to replace your site web.config with the backup
            configWebsite.GenerateWrappers(physicalSitePath); // Wrappers are version specific.

            // All Tests will be placed inside the Tests Folder ans executed by StartTests.Execute(). This is a strict requirement.
            StartTests startTests = new StartTests();
            startTests.Execute();
        }
    }
}
