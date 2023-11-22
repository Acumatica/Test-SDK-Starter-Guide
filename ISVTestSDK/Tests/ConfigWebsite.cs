using Controls.CheckBox;
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

        SM204505_ProjectList CustomizationProjects = new SM204505_ProjectList();
        SM203520_CompanyMaint Companies = new SM203520_CompanyMaint();
        CS100000_FeaturesMaint Features = new CS100000_FeaturesMaint();
        SM201510_LicensingSetup licensing = new SM201510_LicensingSetup();

        public void CreateBackup()
        {
            PxLogin.LoginToDestinationSite();
            Companies.OpenScreen();
            Companies.ExportSnapshotCommand();
            Companies.MessageBox.GetValue().VerifyEquals("The snapshot may contain corrupted data because you are not in maintenance mode.");
            Companies.MessageBox.Ok();
            Companies.ExportSnapshotPanel_frmExportSnapshot.Description.Type(GetType().Name);
            Companies.ExportSnapshotPanel_frmExportSnapshot.Ok();
        }
        public void RestoreBackup()
        {
            PxLogin.LoginToDestinationSite();
            Companies.OpenScreen();
            Companies.Snapshots_gridSnapshots.SelectRow(0);
            Companies.ImportSnapshotCommand();
            Companies.MessageBox.Yes();
            Companies.ImportSnapshotPanel_ftmImportSnapshot.Ok();
            PxLogin.LoginToDestinationSite();
        }
        public void ConfigForWrapperGeneration()
        {
            //Before Generating the Wrappers, all screens must be accessable at minimum for success.
            //The starting state of wrapper generation is SalesDemo data + your customization published.
            //Any aditional steps to enable the custom screens or features must be done before Wrapper generation.
            CS100000_FeaturesMaint Features = new CS100000_FeaturesMaint();
            Features.OpenScreen();
            Features.Insert();
            Features.Features_form.SalesQuotes.SetTrue();
            Features.Features_form.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
            Features.RequestValidation();
        }
        public void ConfigWebsiteFromSalesDemo()
        {
            // We assume the test starts from a blank salesdemo data + your customization published again.
            // If you had test steps running for wrapper generation, they must be run again here before the test.
            Features.OpenScreen();
            Features.Insert();
            Features.Features_form.SalesQuotes.SetTrue();
            Features.Features_form.DynamicControl<CheckBox>("Multicurrency Accounting").SetTrue();
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
