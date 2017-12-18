using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcesoShneider
{
    public class Gateway : Device
    {

        // Inherited from Device

        private int _id;
        private string _serial_number;
        private string _brand;
        private string _model; 

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string serial_number
        {
            get { return _serial_number; }
            set { _serial_number = value; }
        }

        public string brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string model
        {
            get { return _model; }
            set { _model = value; }
        }

        // Properties of this class

        string ip { get; set; }
        int port { get; set; }
    }
}