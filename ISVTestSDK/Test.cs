using Controls.CheckBox;
using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using GeneratedWrappers.SOLUTIONNAME;
using System;
using System.IO;

namespace ISVTestSDK
{
    public class Test : Check
    {
        // Ensure to follow the readme steps for this project before running to properly configure it.
        // https://github.com/Acumatica/Test-SDK-Starter-Guide/blob/master/README.md
        const string physicalSitePath = @"C:\AcumaticaSites\23r200pre1";
        public override void Execute()
        {
            PxLogin.LoginToDestinationSite();
            ConfigForWrapperGeneration();//Before Generating the Wrappers, all screens must be accessable at minimum for success.
            GenerateWrappers();
            // GenerateWrappers() Only needs to be run once after updating the Acumatica version or editing your customization project.
            // It takes 5-20 minutes to run, do not close it manually or else you will need to fix your web.config

            // Run tests like this, there should be a single test.cs file that executes all your tests
            // in the proper order if there is more than 1 test.cs file.
            Test1 Test1 = new Test1();
            Test1.Execute();
        }
        public void GenerateWrappers()
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string wrapperPath = String.Format(projectPath + @"\Wrappers\");

            ClassGenerator.ClassGenerator classGenerator = new ClassGenerator.ClassGenerator(physicalSitePath, wrapperPath);
            classGenerator.Username = "admin";
            // Replace SOLUTIONNAME with your registered solution name from the Partner Portal in all capitals.
            classGenerator.Namespace = "GeneratedWrappers.SOLUTIONNAME";

            // PL and GI screens are added like this, get the "URL" from the site map screen.
            classGenerator.Screens.Add("IN2025PL", "~/GenericInquiry/GenericInquiry.aspx?id=e4352bbd-a53a-42c4-9b96-e9f0fda070c7");
            // Add all screens here you use in your test below, except PL screens are added as above.
            classGenerator.Run("SO301000, CA306000, CS100000");

            // All wrappers will need an extension file created to access the UI elements of the screen wrapper.
            // The namespace of your Extension.cs, test, and any other files will be
            // exactly "namespace GeneratedWrappers.SOLUTIONNAME"
            // How to Create Extension Files.docx is a very useful guide to create these extensions.
        }
        public void ConfigForWrapperGeneration()
        {
            //Before Generating the Wrappers, all screens must be accessable at minimum for success.
            //The starting state of wrapper generation is SalesDemo data + your customization published.
            //Any aditional steps to enable the custom screens or features must be done before Wrapper generation.

            CS100000FeaturesMaint Features = new CS100000FeaturesMaint();
            Features.OpenScreen();
            Features.Insert();
            Features.Summary.SalesQuotes.SetTrue();
            Features.Summary.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
            Features.RequestValidation();
        }

    }
}