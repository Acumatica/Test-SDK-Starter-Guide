using Core.Login;
using Core.TestExecution;
using System;
using System.IO;

namespace GeneratedWrappers.SOLUTIONNAME
{
    //Do not rename Test.cs - It is referenced in <Check Name="Test"/> in the config.xml. and launchSettings.json
    public class Test : Check
    {
        // Ensure to follow the readme steps for this project before running as to properly configure it.
        // https://github.com/Acumatica/Test-SDK-Starter-Guide/blob/master/README.md
        const string physicalSitePath = @"C:\AcumaticaSites\23r201";

        public void GenerateWrappers()
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string wrapperPath = String.Format(projectPath + @"\Wrappers\");

            PxLogin.LoginToDestinationSite();
            //You must config the website to enable all screens before running Wrapper Generation
            ConfigWebsite configWebsite = new ConfigWebsite();
            configWebsite.ConfigForWrapperGeneration();

            ClassGenerator.ClassGenerator classGenerator = new ClassGenerator.ClassGenerator(physicalSitePath, wrapperPath);
            classGenerator.Username = "admin";
            // Replace SOLUTIONNAME with your registered solution name from the Partner Portal in all capitals.
            classGenerator.Namespace = "GeneratedWrappers.SOLUTIONNAME";

            // PL and GI screens are added like this, get the "URL" from the site map screen.
            classGenerator.Screens.Add("IN2025PL", "~/GenericInquiry/GenericInquiry.aspx?id=e4352bbd-a53a-42c4-9b96-e9f0fda070c7");
            // Add all screens here you use in your test below, except PL screens are added as above.
            classGenerator.Run("SO301000, CA306000, CS100000");
            // All wrappers will need an extension file created to access the UI elements of the screen wrapper.
            // The namespace of your Extension.cs, test, and all other .cs files will be
            // exactly "namespace GeneratedWrappers.SOLUTIONNAME"
            // How to Create Extension Files.docx is a very useful guide to create these extensions.
        }
        public override void Execute() //Do not modify this method
        { 
            GenerateWrappers();
            // GenerateWrappers() Only needs to be run once after updating the Acumatica version or editing your customization project.
            // It takes 5-20 minutes to run, do not close it manually or else you will need to fix your web.config
            // The wrappers are exact version specific.

            // All Tests will be placed inside the Tests Folder. This is a strict requirement.
            // You must use StartTest.cs to execute all your tests in order.
            StartTests startTests = new StartTests();
            startTests.Execute();
        }
    }
}