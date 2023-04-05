using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Final_project1
{
    internal class Cable : Device
    {
        private string length;
        private string usbType;


        public Cable(string name, string length, string color, string usbType, string price) :  base(name, price, color)
        {
            this.length = length;
            this.usbType=usbType;
        }
        public string getLength()
        {
            return this.length;
        }
        public string getUsbType()
        {
            return this.usbType;
        }
    }
}
