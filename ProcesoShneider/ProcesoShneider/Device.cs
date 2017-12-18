using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesoShneider
{
    interface Device
    {
        // parameters

        int id { get; set; }
        string serial_number { get; set; } // example: 12AB345CDE
        string brand { get; set; }
        string model { get; set; }
    }
}
