using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project1
{
    internal class Device
    {
        private string name;
        private string color;
        private string price;

        public Device(string name, string price, string color)
        {
            this.name = name;
            this.price = price;
            this.color = color;
        }
        public string getName()
        { 
            return name; 
        }
        public string getPrice()
        {
            return price;
        }
        public string getColor()
        {
            return color;
        }
    }
}
