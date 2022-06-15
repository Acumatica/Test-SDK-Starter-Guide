
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVTestSDK.Extensions
{
   public class CashSale: AR304000_ARCashSaleEntry
    {
        public c_document_form Form => Document_form;
        public c_transactions_grid Grid => Transactions_grid;
        public c_currentdocument_tab Financial => CurrentDocument_tab;
    }
}
