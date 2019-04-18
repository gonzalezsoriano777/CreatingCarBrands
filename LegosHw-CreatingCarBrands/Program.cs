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
            Console.WriteLine("Hello, my car is " + color + " And is a " + manufacturer);
        }

        static void Main(string[] args)
        {
            Cars myCar = new Cars();
            myCar.color = "Red";
            myCar.manufacturer = "Toyota";
            myCar.CarOne();

            SaloonCar NewBrand = new SaloonCar();
            

            

        }
    }



    public class SaloonCar : Cars
    {
        
        public SaloonCar(){
        }

        public int numberofSeats { get; set; }


    }
}
