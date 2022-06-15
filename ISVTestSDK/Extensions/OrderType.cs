using ISVTestSDK.Extensions;

namespace Core
{
    public partial class OrderType : SO201000_SOOrderTypeMaint
    {
        public c_soordertype_form Summary => base.Soordertype_form;
        public c_currentordertype_tab GeneralSettings => base.Currentordertype_tab;
        public c_operations_grid Operations => base.Operations_grid;
        public c_currentordertype_tab TemplateSettings => base.Currentordertype_tab;

        public OrderType()
        {
            QuickImport.ExcludeFields = new[]
            {
                "GeneralSettingsPostingSettings->CombineCOGSSubFrom"
            };
        }
    }
}