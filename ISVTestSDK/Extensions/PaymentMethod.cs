using GeneratedWrappers.Acumatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratedWrappers.VYAPAY
{
  public  class PaymentMethod: AR303010_CustomerPaymentMethodMaint
    {
        public c_customerpaymentmethod_form Form => CustomerPaymentMethod_form;
        public c_details_grid Grid => Details_grid;

        public c_details_grid details => base.Details_grid;

    }
}
