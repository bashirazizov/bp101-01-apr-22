using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }

        public Car(string Model, string Make)
        {
            this.Model = Model;
            this.Make = Make;
        }

        public override string ToString()
        {
            return $"{Model} - {Make}";
        }
    }
}
