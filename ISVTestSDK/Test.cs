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
        const string physicalSitePath = @"C:\AcumaticaSites\23r203";
        public override void Execute()
        {
            PxLogin.LoginToDestinationSite();

            // GenerateWrappers takes 10-30 minutes to run,
            // Do not close it manually or else you will need to replace your site web.config with the backup
            // Only needs to be run after updating your customization package or your acumatica version

            GenerateWrappers(physicalSitePath); // Wrappers are version specific.

            // All Tests must be placed inside the Tests Folder and executed by StartTests.Execute(). This is a strict requirement.
            StartTests startTests = new StartTests();
            startTests.Execute();
        }
        public void GenerateWrappers(string physicalSitePath)
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string wrapperPath = String.Format(projectPath + @"\Wrappers\");

            PxLogin.LoginToDestinationSite();

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
            //configWebsite.MakePrivateFieldsPublic(); //uncomment to use wrappers directly with no extension (not recomended)
            // You must create an extension file for each wrapper you have generated.
            // Documentation/How to Create Extension Files.docx is a very useful guide to create extensions.
        }
    }
}
