using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNUsedCar
{
    public class UsedCar: Car
    {
        //properties
        public double Mileage { get; set; }

        //constructor
        public UsedCar(string make, string model, int year, double price, double mileage)
            : base(make, model, year, price)
        {
            Mileage = mileage;
        }

        public override string ToString()
        {
            return $"{Make}\t{Model}\t{Year}\t${Price}\t(Used) {Mileage} miles";
        }

    }
}
