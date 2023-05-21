using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program      
    {
        static void Main(string[] args)
        {
            CarFactory factory = null;
            Console.WriteLine("Which car you would like to build?");
            string car = Console.ReadLine();
            if (car == "toyota")
                factory = new ToyotaFactory("Corolla", 130);
            else
                factory = new SuzukiFactory("Swift", 110);

            new CarAssembler().AssembleCar(factory);

            // Wait for user
            Console.ReadKey();
        }
    }
}
