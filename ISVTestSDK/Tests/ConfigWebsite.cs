﻿using Controls.CheckBox;
using Core.Config;
using Core.Exceptions;
using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace GeneratedWrappers.SOLUTIONNAME
{
    internal class ConfigWebsite
    {
        IEnumerable<string> packages;

        SM204505ProjectList CustomizationProjects = new SM204505ProjectList();
        SM203520CompanyMaint Companies = new SM203520CompanyMaint();
        CS100000FeaturesMaint Features = new CS100000FeaturesMaint();
        SM201510LicensingSetup licensing = new SM201510LicensingSetup();


        public void GenerateWrappers(string physicalSitePath)
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
            //configWebsite.MakePrivateFieldsPublic(); //uncomment to use wrappers directly with no extension (not recomended)
            // You must create an extension file for each wrapper you have generated.
            // Documentation/How to Create Extension Files.docx is a very useful guide to create extensions.
        }
        public void CreateBackup()
        {
            PxLogin.LoginToDestinationSite();
            Companies.OpenScreen();
            Companies.ExportSnapshotCommand();
            Companies.MessageBox.GetValue().VerifyEquals("The snapshot may contain corrupted data because you are not in maintenance mode.");
            Companies.MessageBox.Ok();
            Companies.ExportSnapshotPanel.Description.Type(GetType().Name);
            Companies.ExportSnapshotPanel.Ok();
        }
        public void RestoreBackup()
        {
            PxLogin.LoginToDestinationSite();
            Companies.OpenScreen();
            Companies.Snapshots.SelectRow(0);
            Companies.ImportSnapshotCommand();
            Companies.MessageBox.Yes();
            Companies.ImportSnapshotPanel.Ok();
            PxLogin.LoginToDestinationSite();
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
        public void ConfigWebsiteFromSalesDemo()
        {
            // We assume the test starts from a blank salesdemo data + your customization published again.
            // If you had test steps running for wrapper generation, they must be run again here before the test.
            CS100000FeaturesMaint Features = new CS100000FeaturesMaint();
            Features.OpenScreen();
            Features.Insert();
            Features.Summary.SalesQuotes.SetTrue();
            Features.Summary.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
            Features.RequestValidation();
            // Use TestSDK code to enter any data required for the following tests to run.
            // eg. Configure numbering sequences, Enableing features, checkboxes on screens, setting up items
            // with newly added attributes.
        }
        public IEnumerable<string> GetPackages()
        {
            var packagesPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\CustomizationPackages\";
            if (!Directory.Exists(packagesPath)) throw new AutotestException($"{packagesPath} directory does not exist");
            this.packages = Directory.GetFiles(packagesPath);
            return this.packages;
        }
        public void ImportCustomization()
        {
            //Remove license for ISV packages due to licensing restrictions on some projects.
            //licensing.OpenScreen();
            //licensing.DeleteLicense();

            Log.Screenshot();
            CustomizationProjects.OpenScreen();
            CustomizationProjects.ActionUndoPublish(); //clear out old packages
            CustomizationProjects.GridList_gridGrid.SetTrue();
            CustomizationProjects.GridList_gridGrid.SetFalse();
            CustomizationProjects.Save();
            CustomizationProjects.Projects_grid.RemoveAllRows();
            CustomizationProjects.Save();
            GetPackages();
            Log.Screenshot();
            foreach (var customization in this.packages) //Import and save checked to publish later
            {
                Log.Information("Importing: " + customization.ToString());
                CustomizationProjects.ActionImport();
                CustomizationProjects.OpenPackage.SelectFile(customization.ToString());
                CustomizationProjects.OpenPackage.Upload();
                CustomizationProjects.Projects_grid.SetTrue();
                CustomizationProjects.Save();
            }
        }

        public void PublishCustomization()
        {
            #region Step 5
            using (TestExecution.CreateTestStepGroup("Publish customization projects."))
            {
                CustomizationProjects.OpenScreen();
                CustomizationProjects.CompilationPanel.WaitAction = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 2);
                CustomizationProjects.ActionPublish();
                try
                {
                    CustomizationProjects.CompilationPanel.Validate(true, Constants.ValidationSuccessfully);
                    CustomizationProjects.CompilationPanel.Publish();
                }
                catch
                {
                    CustomizationProjects.CompilationPanel.Close();
                }
                CustomizationProjects.RefreshScreen(true);
                Log.Screenshot();
                Log.Information("Published multiple Customizations");
            }
            #endregion
        }

        public void MakePrivateFieldsPublic()
        {
            var packagesPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Wrappers\";
            // Check if the directory exists
            if (!Directory.Exists(packagesPath))
            {
                Console.WriteLine("Wrappers directory not found.");
                return;
            }
            // Get all .cs files in the directory
            string[] csFiles = Directory.GetFiles(packagesPath, "*.cs", SearchOption.AllDirectories);

            foreach (var file in csFiles)
            {
                // Read the contents of the file
                string content = File.ReadAllText(file);
                // Replace 'private' with 'public' - considering the indentation
                string modifiedContent = Regex.Replace(content, @"\bprotected\b", "public");
                // Write the modified content back to the file
                File.WriteAllText(file, modifiedContent);
                Console.WriteLine($"Updated {file}");
            }
        }
    }
}
