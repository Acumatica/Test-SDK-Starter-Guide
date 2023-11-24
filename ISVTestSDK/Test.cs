using ClassGenerator;
using Core.Login;
using Core.TestExecution;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace GeneratedWrappers.SOLUTIONNAME
{
    //Do not rename Test.cs - It is referenced in <Check Name="Test"/> in the config.xml. and launchSettings.json
    public class Test : Check
    {
        // Ensure to follow the readme steps for this project before running as to properly configure it.
        // https://github.com/Acumatica/Test-SDK-Starter-Guide/blob/master/README.md
        const string physicalSitePath = @"C:\AcumaticaSites\23r2";

        ConfigWebsite configWebsite = new ConfigWebsite();

        public void GenerateWrappers()
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string wrapperPath = String.Format(projectPath + @"\Wrappers\");

            PxLogin.LoginToDestinationSite();
            //You must config the website to enable all screens before running Wrapper Generation

            ClassGenerator.ClassGenerator classGenerator = new ClassGenerator.ClassGenerator(physicalSitePath, wrapperPath);
            classGenerator.Username = "admin"; // If multi company = admin@Company 2
            // Replace SOLUTIONNAME with your registered solution name from the Partner Portal in all capitals.
            classGenerator.Namespace = "GeneratedWrappers.SOLUTIONNAME";

            // PL and GI screens are added like this, get the "URL" from the site map screen.
            classGenerator.Screens.Add("IN2025PL", "~/GenericInquiry/GenericInquiry.aspx?id=e4352bbd-a53a-42c4-9b96-e9f0fda070c7");
            // Add all screens here you use in your test below, except PL screens are added as above.
            classGenerator.Run("SM201510,SM204505,SM203520,CA306000,CS100000,SO301000,SO303000,SO302000");
            // You can also use regex such as:
            // classGenerator.Run("SO, AR5*"); // generates all SO screens and all AR5***** screens
            // more example screens : R201000,AR202000,AR209500,AR303000,CS205000,IN101000,IN201000,IN202000,IN202500,IN204060,IN301000,SM205020,SM208000,SM302000,SO201000,SO301000,SO302000
               //configWebsite.MakePrivateFieldsPublic();
            // You must create an extension file for each wrapper you have generated.
            // Documentation/How to Create Extension Files.docx is a very useful guide to create extensions.
        }

        public override void Execute()
        {
            PxLogin.LoginToDestinationSite();

            //  *+*+* Use these to easily reconfig your site *+*+*  \\
              configWebsite.CreateBackup();
            //configWebsite.RestoreBackup();
            //configWebsite.ImportCustomization(); //imports all packages to be in /CustomizationPackages folder
            //configWebsite.PublishCustomization();
            //configWebsite.ConfigForWrapperGeneration();
            //GenerateWrappers();

            // GenerateWrappers takes 5-20 minutes to run, do not close it manually or else you will need to fix your web.config
            // The wrappers are exact version specific due to small possible changes.

            // All Tests will be placed inside the Tests Folder. This is a strict requirement.
            // You must use StartTest.cs to execute all your tests in order.
            StartTests startTests = new StartTests();
            startTests.Execute();
        }
    }
}
