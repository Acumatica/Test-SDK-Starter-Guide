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

    /* 
     * This class is optional to use, it provides reusable methods to backup/restore your website to the testing starting state (fresh salesdemo data)
     * It also has methods that can be modified to do the initial configuration if needed, but customization plug-in .zip package is recomended for data setup of non acumatica fields.
     */
    internal class ConfigWebsite
    {
        IEnumerable<string> packages;

        SM204505ProjectList CustomizationProjects = new SM204505ProjectList();
        SM203520CompanyMaint Companies = new SM203520CompanyMaint();
        CS100000FeaturesMaint Features = new CS100000FeaturesMaint();
        SM201510LicensingSetup licensing = new SM201510LicensingSetup();

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
            CustomizationProjects.GridList.SetTrue();
            CustomizationProjects.GridList.SetFalse();
            CustomizationProjects.Save();
            CustomizationProjects.Projects.RemoveAllRows();
            CustomizationProjects.Save();
            GetPackages();
            Log.Screenshot();
            foreach (var customization in this.packages) //Import and save checked to publish later
            {
                Log.Information("Importing: " + customization.ToString());
                CustomizationProjects.ActionImport();
                CustomizationProjects.cOpenPackage.SelectFile(customization.ToString());
                CustomizationProjects.cOpenPackage.Upload();
                CustomizationProjects.GridList.SetTrue();
                CustomizationProjects.Save();
            }
        }

        public void PublishCustomization()
        {
            #region Step 5
            using (TestExecution.CreateTestStepGroup("Publish customization projects."))
            {
                CustomizationProjects.OpenScreen();
                CustomizationProjects.cCompilationPanel.WaitAction = () => Wait.WaitForLongOperationToComplete(Wait.LongTimeOut * 2);
                CustomizationProjects.ActionPublish();
                try
                {
                    CustomizationProjects.cCompilationPanel.Validate(true, Constants.ValidationSuccessfully);
                    CustomizationProjects.cCompilationPanel.Publish();
                }
                catch
                {
                    CustomizationProjects.cCompilationPanel.Close();
                }
                CustomizationProjects.RefreshScreen(true);
                Log.Screenshot();
                Log.Information("Published multiple Customizations");
            }
            #endregion
        }

        /* Used if you want to use wrappers directly, note this may cause you to have to update tests more frequently when code changes happen.
        May also cause severe performance issues 
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
        }*/
    }
}
