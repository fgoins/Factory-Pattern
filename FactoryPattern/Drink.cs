using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Drink : ISteakHouse
    {
        public string wine { get; set; } = "red wine";
        public string soda { get; set; } = " Coke products ";
        public void Order()
        {
            Console.WriteLine(wine);
            Console.WriteLine(soda);
        }
    }
}
