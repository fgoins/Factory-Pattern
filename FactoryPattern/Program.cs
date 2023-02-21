namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the Steak House " );
            Console.WriteLine("getting starte what would you like to drink we have red wine or coke products?");

            string UserInput = Console.ReadLine();

            ISteakHouse Menu = SteakHouseFactory.Order(UserInput);

            Menu.Order();
        }
    }
}
