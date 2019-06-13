using System;
using System.Linq;

namespace ThreeTuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personAdressTown = Console.ReadLine()
                .Split()
                .ToArray();

            string personName = personAdressTown[0] + " " + personAdressTown[1];
            string adress = personAdressTown[2];
            string town = personAdressTown[3];

            if (personAdressTown.Length > 4)
            {
                town = personAdressTown[3] + " " + personAdressTown[4];
            }

            string[] nameBeerDrunk = Console.ReadLine()
                .Split()
                .ToArray();

            string name = nameBeerDrunk[0];
            int liters = int.Parse(nameBeerDrunk[1]);
            bool isDrunk = false;
            if (nameBeerDrunk[2] == "drunk")
            {
                isDrunk = true;
            }

            string[] nameBankAccount = Console.ReadLine()
                .Split()
                .ToArray();

            string names = nameBankAccount[0];
            double balance = double.Parse(nameBankAccount[1]);
            string bankName = nameBankAccount[2];

            var personAdressTownTuple = new ThreeTuple<string, string, string>(personName, adress, town);
            var nameBeerDrunkTuple = new ThreeTuple<string, int, bool>(name, liters, isDrunk);
            var nameBankAccountTuple = new ThreeTuple<string, double, string>(names, balance, bankName);

            Console.WriteLine(personAdressTownTuple.PrintItems(personName, adress, town));
            Console.WriteLine(nameBeerDrunkTuple.PrintItems(name, liters, isDrunk));
            Console.WriteLine(nameBankAccountTuple.PrintItems(names, balance, bankName));
        }

    }
}

