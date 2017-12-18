using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // For required properties ID and Serial Number

namespace ProcesoShneider
{
    interface Device
    {
        // parameters

        [Required(ErrorMessage ="ID is required.")]
        int id { get; set; }

        [Required(ErrorMessage ="Serial Number is required.")]
        string serial_number { get; set; } // example: 12AB345CDE

        string brand { get; set; }

        string model { get; set; }
    }
}
