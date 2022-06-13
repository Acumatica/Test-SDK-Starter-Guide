using GeneratedWrappers.Acumatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratedWrappers.VYAPAY
{
   public class Invoice: SO303000_SOInvoiceEntry
    {
        public c_document_form Form =>Document_form;
        public c_adjustments_detgrid grid => Adjustments_detgrid;
        public c_quickpayment_createpaymentformview popup1 => QuickPayment_CreatePaymentFormView;
    }
}
