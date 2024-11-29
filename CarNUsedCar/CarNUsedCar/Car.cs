using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNUsedCar
{
    public class Car
    {//properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        // Public static list to hold cars
        public static List<Car> carList = new List<Car>();

        public Car()
        {
            Make = "Toyota";
            Model = "4Runner";
            Year = DateTime.Now.Year;
            //Year = 2013;
            Price = 60000;
        }

        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        // method
        public override string ToString()
        {
            return $"{Make}\t{Model}\t{Year}\t${Price}";
        }
    }
}
