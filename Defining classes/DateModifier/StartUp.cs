using System;
using System.Linq;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            string[] firstDate = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string[] secondDate = Console.ReadLine()
                .Split(" ")
                .ToArray();

            var date = new DateModifier(firstDate, secondDate);

            date.CalculateDifference(firstDate, secondDate);
        }

    }
}
