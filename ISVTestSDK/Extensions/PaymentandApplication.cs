
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVTestSDK.Extensions
{
   public class PaymentandApplication: AR302000_ARPaymentEntry
    {
        public c_document_form Form => Document_form;
        public c_soadjustments_lv0 salesordertab => SOAdjustments_lv0;
        public c_adjustments_detgrid Grid => Adjustments_detgrid;
    }
}
