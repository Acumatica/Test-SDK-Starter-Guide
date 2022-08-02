using Api;
using Controls.Editors.DateSelector;
using GeneratedWrappers.Acumatica;

namespace Core
{
    public class AccountGroup : PM201000_AccountGroupMaint
    {
        public c_accountgroup_form Summary => base.AccountGroup_form;
        public c_accounts_accountgrid Accounts => base.Accounts_AccountGrid;
        public c_accountgroupproperties_tab ItemTypes => base.AccountGroupProperties_tab;
        public c_answers_pxgridanswers Attributes => base.Answers_PXGridAnswers;
        public c_accountgroupproperties_tab Settings => base.AccountGroupProperties_tab;

        public AccountGroup()
        {
            FileName = "Account Groups";
        }

        public void AddAccount()
        {
            Insert();
            Summary.GroupCD.Select(Summary.GroupCD.Value);
            if (Summary.Type.IsEnabled()) Summary.Type.Select();
            Summary.Description.Type();
        }

        public void Add()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.TESTCASE, "Add Account group " + Summary.GroupCD.Value))
            {
                OpenScreen();
                Insert();
                Summary.GroupCD.Type();
                Summary.Type.Select();
                Summary.Description.Type();

                foreach (var acc in Accounts.Rows)
                {
                    Accounts.New();
                    acc.AccountID.Select();
                }

                for (int i = 0; i < Attributes.Rows.Count; i++)
                {
                    Attributes.SelectRow(i + 1);
                    Attributes.Rows[i].Value.DynamicControl<DateSelector>().Type(Attributes.Rows[i].Value.Value);
                }

                Save();
            }
        }
    }
}
