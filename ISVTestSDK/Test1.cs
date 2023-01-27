using Core.Log;
using Core.Login;
using Core.TestExecution;
using Core.Wait;
using GeneratedWrappers.Acumatica;
using GeneratedWrappers.ISVNAME;
using System;
using System.Collections.Generic;
using System.IO;

namespace ISVTestSDK
{
    public class Test1 : Check
    {

        public CA306000CABankTransactions CABankTransactionsMaint = new CA306000CABankTransactions();
        public override void Execute()
        {
            using (TestExecution.CreateTestStepGroup("Test 1 - Open Screen"))
            {
                CABankTransactionsMaint.OpenScreen();
                CABankTransactionsMaint.Filter.CashAccountID.Type("10200");
                CABankTransactionsMaint.Filter.CashAccountID.GetValue().VerifyContains("10200").Assert();
                CABankTransactionsMaint.Filter.CashAccountID.Type("10400");
            }
        }
    }
}
