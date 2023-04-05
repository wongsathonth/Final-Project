using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Final_project1
{
    internal class Mouse : Device
    {
        private string connect;

        public Mouse(string name, string color, string connect, string price) : base(name, price, color)
        {
            this.connect = connect;
        }
        public string getConnect()
        {
            return this.connect;
        }
    }
}
