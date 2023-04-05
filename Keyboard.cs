using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final_project1
{
    internal class Keyboard : Device
    {
        private string size;

        public Keyboard(string name, string color, string size, string price) : base(name, price, color) 
        {
            this.size = size;

        }
        public string getSize()
        {
            return this.size;
        }
    }
}
