using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Aurora
{
    public class Bematech
    {
        public static bool ImprimirCupom(string texto, string nomedaImpressora)
        {
            return RawPrinterHelper.SendStringToPrinter(nomedaImpressora, texto);
        }
    }
}
