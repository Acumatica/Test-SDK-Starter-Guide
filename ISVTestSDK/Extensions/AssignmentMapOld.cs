using Core.Core.Browser;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public partial class AssignmentMapOld : EP205000_EPAssignmentMaint
    {
        public override void OpenScreen(bool forceReopen = false) => Browser.Instance.Open(ScreenId);

        public c_assigmentmap_mapform Summary
        {
            get { return base.AssigmentMap_mapForm; }
        }

        public c_currentitem_formruletype RuleType
        {
            get { return base.CurrentItem_formRuleType; }
        }

        public c_items_topgrid Nodes
        {
            get { return base.Items_topGrid; }
        }

        public c_rules_bottomgrid Rules
        {
            get { return base.Rules_bottomGrid; }
        }

        public new c_tree Tree
        {
            get { return base.Tree; }
        }

        public AssignmentMapOld()
        {
            FileName = "Assignment And Approval Maps";
        }

        public void Select()
        {
            OpenScreen();
            Summary.AssignmentMapID.Select(Summary.Name.Value);
        }

        public static void GuiTest() { }

        protected override void AutoTest() { }

        protected override void DependencyTest() { }
    }
}
