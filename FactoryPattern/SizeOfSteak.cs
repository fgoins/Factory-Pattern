using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class SizeOfSteak : ISteakHouse
    {
        public string size1 { get; set; } = "6oz";
        public string size2 { get; set; } = "8oz";
        public string size3 { get; set; } = "10oz";

        public void Order()
        {
            Console.WriteLine(size1);
            Console.WriteLine(size2); 
            Console.WriteLine(size3);
        }
    }
}
