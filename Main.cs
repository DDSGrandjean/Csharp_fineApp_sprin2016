using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineApp
{
    class Main
    {
        static void Main(string[] args)
        {
            Fine aFine = new Fine();
            Console.Write("Enter name: ");
            aFine.Name = Console.ReadLine();

            Console.Write("Enter speed: ");
            aFine.Speed = int.Parse(Console.ReadLine());

            Console.Write("Enter speed limit: ");
            aFine.SpeedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter offense number: ");
            aFine.Offense = char.Parse(Console.ReadLine());

            Console.WriteLine("\n******************************\n" + aFine.ToString());
            Console.Read();
        }
    }
}
