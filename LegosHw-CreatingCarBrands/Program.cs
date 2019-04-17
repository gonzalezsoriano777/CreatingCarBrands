using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegosHw_CreatingCarBrands
{
    class Cars
    {
        public string color = "Red";
        public string brand = "Toyota";

        static void Main(string[] args)
        {
            Cars Car1 = new Cars();
            
            Console.WriteLine("Hello, MyCar");
            Console.WriteLine(Car1.color);
            Console.WriteLine(Car1.brand);
        }
    }
}
