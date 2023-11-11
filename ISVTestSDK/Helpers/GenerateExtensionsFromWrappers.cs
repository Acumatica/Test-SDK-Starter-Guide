using Core.TestExecution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeneratedWrappers.SOLUTIONNAME
{
        
    internal class GenerateExtensionsFromWrappers
        {
            public void Execute(string namespaceString)
            {
            string input = namespaceString;
            string prefix = "GeneratedWrappers.";

            if (!input.StartsWith(prefix))
            {
                Console.WriteLine("namespaceString must be 'GeneratedWrappers.SOLUTIONNAME' - SOLUTIONNAME being your Registered solution name on portal.acumatica.com");
            }
            else
            {            
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string wrappersFolderPath = String.Format(projectPath + @"\Wrappers\");
            string extensionsFolderPath = String.Format(projectPath + @"\Extensions\");

            // Ensure the extensions folder exists
            Directory.CreateDirectory(extensionsFolderPath);

            // Get all .cs files in the wrappers folder
            string[] wrapperFiles = Directory.GetFiles(wrappersFolderPath, "*.cs", SearchOption.AllDirectories);

            foreach (var wrapperFilePath in wrapperFiles)
            {
                string wrapperFileName = Path.GetFileNameWithoutExtension(wrapperFilePath);
                string extensionFileName = $"{wrapperFileName}Extension.cs";
                string extensionFilePath = Path.Combine(extensionsFolderPath, extensionFileName);

                // Read the content of the wrapper file
                string wrapperContent = File.ReadAllText(wrapperFilePath);

                // Regex to match the protected properties
                var matches = Regex.Matches(wrapperContent, @"protected\s+(\w+)\s+(\w+)\s*{\s*get;\s*}\s*=\s*new\s+\1\(");

                // Start writing the extension file
                using (StreamWriter sw = new StreamWriter(extensionFilePath))
                {
                    sw.WriteLine("using Controls.Uploader;");
                    sw.WriteLine("namespace GeneratedWrappers.SOLUTIONNAME");
                    sw.WriteLine("{");
                    sw.WriteLine($"    class {wrapperFileName}Extension : {wrapperFileName}");
                    sw.WriteLine("    {");

                    foreach (Match match in matches)
                    {
                        string returnType = match.Groups[1].Value;
                        string propertyName = match.Groups[2].Value;
                        string extensionPropertyName = Char.ToLowerInvariant(propertyName[0]) + propertyName.Substring(1);

                        sw.WriteLine($"        public {returnType} {extensionPropertyName} => {propertyName};");
                    }

                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                }

                Console.WriteLine($"Extension file created: {extensionFilePath}");
            }
        }
        }
    }
}

