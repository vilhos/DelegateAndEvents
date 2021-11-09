using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp
{
    public delegate void PriceHandler(int price);
    class Exchange
    {
        public void ShowPrice(PriceHandler handler)
        {
            for (int i = 0; i < 10; i++)
            {
                int dollarPrice = new Random().Next(450, 550);
                handler(dollarPrice);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exchange exchange = new Exchange();
            exchange.ShowPrice(Info);

            Console.ReadLine();
        }
        static void Info(int price)
        {
            Console.WriteLine($"{DateTime.Now} Price {price}");
        }
    }
}
