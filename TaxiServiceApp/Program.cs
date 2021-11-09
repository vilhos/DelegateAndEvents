using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiServiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.EventDel += Info;
            car.EventDel += Charge;
            car.Consumption(Charge);
            Console.ReadLine();
        }
        static void Info()
        {
            Console.WriteLine("Charge is low");
        }
        static void Charge()
        {
            TaxiService.AddCharge();
            Console.WriteLine("Car is Charged");
        }
    }
}