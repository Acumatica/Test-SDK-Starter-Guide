using System;
using System.Linq;
using Controls.CheckBox;
using GeneratedWrappers.Acumatica;
using Test.Utils;

namespace Core
{
    public partial class Features : CS100000_FeaturesMaint
    {
        public c_features_form Summary => base.Features_form;

        /// <summary>
        /// Deactivates all features on the site.
        /// </summary>
        public void DeactivateFeatures() => Process(false);

        private void Process(bool state)
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Process features"))
            {
                OpenScreen();
                Insert();

                foreach (CheckBox checkBox in Summary.GetFields().OfType<CheckBox>().Except(new[] { Summary.InvoiceRounding, Summary.ContactDuplicate }))
                {
                    try
                    {
                        checkBox.Set(state);
                    }
                    catch (Exception e)
                    {
                        Log.Log.Error(e);
                    }
                }

                RequestValidation();
            }
        }
    }
}
