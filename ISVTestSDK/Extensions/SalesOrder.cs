using GeneratedWrappers.Acumatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeneratedWrappers.VYAPAY
{
   public class SalesOrder: SO301000_SOOrderEntry
    {
        public c_document_form Form => Document_form;
        public c_transactions_grid Grid => Transactions_grid;
        public c_currentdocument_formfinancialinformation Financial => CurrentDocument_formFinancialInformation;
        public c_currentdocument_formdeliverysettings shipvia => CurrentDocument_formDeliverySettings;
        public c_addinvoicefilter_form4 AddInvoice => Addinvoicefilter_form4;
        public c_invoicesplits_grid4 AddInvoice1 => Invoicesplits_grid4;
        public c_adjustments_detgrid Payment => Adjustments_detgrid;
        public c_addinvoicefilter_form4 popup1 => Addinvoicefilter_form4;



           public c_soparamfilter_formcreateshipment PanelPopup => Soparamfilter_formcreateshipment;
           public c_quickpayment_createpaymentformview popup => QuickPayment_CreatePaymentFormView;
    }
}
