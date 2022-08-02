using GeneratedWrappers.Acumatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PaymentM: CA204000_PaymentMethodMaint
    {
        public c_paymentmethod_form Form => PaymentMethod_form;
        public c_cashaccounts_grdcashaccounts Allowedcashtab => CashAccounts_grdCashAccounts;
        public c_processingcenters_grdproccenters Processingcenterstab => ProcessingCenters_grdProcCenters;
    }
}
