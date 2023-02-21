using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class KindOfSteak : ISteakHouse
    {
        public string filet { get; set; } = "filet";
        public string newYorkStrip { get; set; } = "New York Strip";
        public string tommahoak { get; set; } = "Tommahock";

        public void Order()
        {
            Console.WriteLine(filet);
            Console.WriteLine(newYorkStrip);
            Console.WriteLine(tommahoak);
        }
    }
}
