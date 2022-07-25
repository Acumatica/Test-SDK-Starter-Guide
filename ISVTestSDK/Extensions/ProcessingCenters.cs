using GeneratedWrappers.Acumatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public  class ProcessingCenters: CA205000_CCProcessingCenterMaint
    {
        public c_processingcenter_form Form => ProcessingCenter_form;
        public c_filterworkingproject_formselectproject NewCenter => FilterWorkingProject_FormSelectProject;
       // public c_details_grddetails details => Details_grdDetails;
        public c_details_grddetails details => base.Details_grdDetails;
    }
}
