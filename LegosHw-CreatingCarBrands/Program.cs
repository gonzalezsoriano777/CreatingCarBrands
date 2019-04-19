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

            SaloonCar saloonCarOne = new SaloonCar(2);
            Console.WriteLine("SaloonCarOne: {0}", saloonCarOne.NumberOfSeats);

            SaloonCar saloonCarTwo = new SaloonCar(3, "Nissan");
            Console.WriteLine("SaloonCarTwo: has {0} seats and is a {1}", saloonCarTwo.NumberOfSeats, saloonCarTwo.Manufacturer);

            SaloonCar saloonCarThree = new SaloonCar(4, "Ford", "Purple");
            Console.WriteLine("SaloonCarThree: has {0} seats and is a {1} and is {2}", saloonCarThree.NumberOfSeats, saloonCarThree.Manufacturer, saloonCarThree.Colour);

        }
    }


    public class SaloonCar : Cars
    {
        public int NumberOfSeats;


        public SaloonCar()
        {

        }

        //C1
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
