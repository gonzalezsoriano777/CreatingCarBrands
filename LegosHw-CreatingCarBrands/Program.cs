using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LegosHw_CreatingCarBrands
{
    public class Cars
    {
        public string color;
        public string manufacturer;

        public void CarOne()
        {
            Console.WriteLine("Hello, my car is {0} and is a {1}", color, manufacturer);
        }

        static void Main(string[] args)
        {
            Cars myCar = new Cars();
            myCar.color = "Red";
            myCar.manufacturer = "Toyota";
            myCar.CarOne();


            
            

            

        }
    }



    public class SaloonCar : Cars
    {

        public int NumberOfSeats;
        public string Manufacturer;
        public string Colour;

        // C1
        public SaloonCar(int numberOfSeats)
        {
            this.NumberOfSeats = numberOfSeats;
        }

        //C2
        public SaloonCar(int numberOfSeats, string manufacturer)
        {
            this.NumberOfSeats = numberOfSeats;
            this.Manufacturer = manufacturer;
        }

        //C3
        public SaloonCar(int numberOfSeats, string manufacturer, string colour)
        {
            this.NumberOfSeats = numberOfSeats;
            this.Manufacturer = manufacturer;
            this.Colour = colour;
        }

        


    }
}
