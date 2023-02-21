using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class SteakHouseFactory
    {
        public static ISteakHouse Order(string UserInput)
        {
            switch (UserInput)
            {
                case "Wine":
                    return new Drink();
                case "Sprite":
                    return new Drink();
                case "Coke":
                    return new Drink();
                case "Filet":
                    return new KindOfSteak();
                case "New York Strip":
                    return new KindOfSteak();
                case "Tommahock":
                    return new KindOfSteak();
                case "6oz":
                    return new SizeOfSteak();
                case "8oz":
                    return new SizeOfSteak();
                case "10oz":
                    return new SizeOfSteak();
                default:
                    return new Drink();
            }

        }
    }
}
