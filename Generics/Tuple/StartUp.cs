using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main()
        {
            string[] personAdress = Console.ReadLine()
                .Split()
                .ToArray();

            string personName = personAdress[0] + " " + personAdress[1];
            string adress = personAdress[2];

            string[] nameBeer = Console.ReadLine()
                .Split()
                .ToArray();

            string name = nameBeer[0];
            int liters = int.Parse(nameBeer[1]);

            string[] integerDouble = Console.ReadLine()
                .Split()
                .ToArray();

            int integer = int.Parse(integerDouble[0]);
            double myDouble = double.Parse(integerDouble[1]);

            var personNameTuple = new Tuple<string, string>(personName, adress);
            var nameBeerTuple = new Tuple<string, int>(name, liters);
            var integerDoublesTuple = new Tuple<int, double>(integer, myDouble);

            Console.WriteLine(personNameTuple.PrintItems(personName, adress));
            Console.WriteLine(nameBeerTuple.PrintItems(name, liters));
            Console.WriteLine(integerDoublesTuple.PrintItems(integer, myDouble));
        }
    }
}
