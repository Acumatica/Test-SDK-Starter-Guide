
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVTestSDK.Extensions
{
   public class SOShipment: SO302000_SOShipmentEntry
    {
        public c_document_form Form => Document_form;
        public c_packages_gridpackages PackageTab => Packages_gridPackages;
    }
}
