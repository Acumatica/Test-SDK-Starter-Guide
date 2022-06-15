using GeneratedWrappers.Acumatica;
using Api;

namespace Core
{
    public partial class PostingClass : IN206000_INPostClassMaint
    {
        public c_postclass_form Summary => base.Postclass_form;

        public c_postclassaccounts_tab GLAccounts => base.Postclassaccounts_tab;

        public PostingClass()
        {
            QuickImport.ExcludeFields = new[]
            {
                "PostingSettings->UseCOGSExpenseAccountFrom",
                "PostingSettings->UseStdCostVarianceAccountFrom"
            };
        }

        public void Select()
        {
            OpenScreen();
            Summary.PostClassID.Select();
        }

        public void Add()
        {
            OpenScreen();
            Insert();
            Summary.PostClassID.Type();
            Summary.Descr.Type();
            FillPostingSettings();
            FillGLAccounts();
            Save();
        }

        public void Update()
        {
            Select();
            FillPostingSettings();
            FillGLAccounts();
            Save();
        }

        public void FillPostingSettings()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Posting GeneralSettings"))
            {
                GLAccounts.InvtAcctDefault.Select();
                GLAccounts.InvtSubMask.Type();
                GLAccounts.SalesAcctDefault.Select();
                GLAccounts.SalesSubMask.Type();
                GLAccounts.COGSAcctDefault.Select();
                GLAccounts.COGSSubFromSales.Set();
                if (!GLAccounts.COGSSubFromSales.Value)
                {
                    GLAccounts.COGSSubMask.Type();
                }
                GLAccounts.StdCstRevAcctDefault.Select();
                GLAccounts.StdCstRevSubMask.Type();
                GLAccounts.StdCstVarAcctDefault.Select();
                GLAccounts.StdCstVarSubMask.Type();
            }
        }

        public void FillGLAccounts()
        {
            using (TestExecution.TestExecution.CreateGroup(Log.Log.OPERATION, "Accounts"))
            {
                GLAccounts.InvtAcctID.Select();
                GLAccounts.InvtSubID.Type();
                GLAccounts.ReasonCodeSubID.Type();
                GLAccounts.SalesAcctID.Select();
                GLAccounts.SalesSubID.Type();
                GLAccounts.COGSAcctID.Select();
                GLAccounts.COGSSubID.Type();
                GLAccounts.StdCstVarAcctID.Select();
                GLAccounts.StdCstVarSubID.Type();
                GLAccounts.StdCstRevAcctID.Select();
                GLAccounts.StdCstRevSubID.Type();
                GLAccounts.POAccrualAcctID.Select();
                GLAccounts.POAccrualSubID.Type();
                GLAccounts.PPVAcctID.Select();
                GLAccounts.PPVSubID.Type();
                GLAccounts.LCVarianceAcctID.Select();
                GLAccounts.LCVarianceSubID.Type();
            }
        }
    }
}
