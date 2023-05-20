using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    internal class product
    {
        public string description { get; set; }
        public double cost { get; set; }
        public int numberordered { get; set; }

        public product(string d, double c)
        {
            this.description = d;
            this.cost = c;
            numberordered = 0;
        }

    }
}
namespace E_Commerce
{
    internal class productsize
    {
        public int size { get; set; }
        public int sizeordered { get; set; }


        public productsize(int d)
        {
            this.size = d;
            sizeordered = 0;

        }

    }

}