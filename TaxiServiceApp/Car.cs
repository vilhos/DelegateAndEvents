using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiServiceApp
{
    public delegate void NotificDelegate();
    public class Car
    {
        public event NotificDelegate EventDel;
        public static int charge = 100;

        public void Consumption(NotificDelegate notific)
        {
            while (true)
            {
                charge--;

                if (charge < 5)
                {
                    EventDel?.Invoke();
                    break;
                }
            }
        }
    }
}