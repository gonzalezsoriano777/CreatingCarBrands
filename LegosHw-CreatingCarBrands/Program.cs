using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegosHw_CreatingCarBrands
{
    public class Cars : CarOne
    {    
        static void Main(string[] args)
        {
            Cars myCar = new Cars();
            CarOne Car1 = new CarOne();

            

        }
    }

    public class CarOne
    {

        public CarOne(){
        }

        public string Colour { get; set; }
        public string manufacturer { get; set; }

    }

    public class SaloonCar : CarOne
    {
        
        public SaloonCar(){
        }

        public int numberofSeats { get; set; }


    }
}
