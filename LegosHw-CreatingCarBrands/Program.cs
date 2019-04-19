using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LegosHw_CreatingCarBrands
{
    public class Cars
    {
        public string Colour;
        public string Manufacturer;

        public void CarOne()
        {
            Console.WriteLine("Hello, my car is {0} and is a {1} ", Colour, Manufacturer);
        }


        static void Main(string[] args)
        {
            Cars carOne = new Cars();
            carOne.Colour = "Red";
            carOne.Manufacturer = "Toyota";
            carOne.CarOne();
        }
    }
}
