using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesoShneider.Tests
{
    class DevicesExceptions : Exception
    {

        // 2 devices are similar if their serial numbers are similar.
        public void TwoDevicesEquals(Device d1, Device d2)
        {
            if(d1.serial_number == d2.serial_number)
            {
                string msg = "This device has been registered.";
            }
        }

    }
}
