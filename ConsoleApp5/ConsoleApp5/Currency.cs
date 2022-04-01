using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Currency
    {
        public double Amount { get; set; }
        public double ToAznRate { get; set; } = 1;
        public double ToUsdRate { get; set; } = 1;
        public double ToEurRate { get; set; } = 1;

        public void PrintConversion()
        {
            Console.WriteLine("to Azn = "+ Amount * ToAznRate);
            Console.WriteLine("to Usd = "+ Amount * ToUsdRate);
            Console.WriteLine("to Eur = "+ Amount * ToEurRate);

        }
    }
}
