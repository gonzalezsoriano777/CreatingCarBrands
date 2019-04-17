using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegosHw_CreatingCarBrands
{
    class Cars
    {    

        public Cars(string _color, string _manufacturer)
        {
            this.colour = _color;
            this.manufacturer = _manufacturer;
        }

        public string colour { get; set; }
        public string manufacturer { get; set; }

        static void Main(string[] args)
        {
            Cars Car1 = new Cars("Red", "Toyota");
            

            Console.WriteLine("MyCar is " + Car1.colour + " And is a " + Car1.manufacturer);
           
           

        }
    }
}
