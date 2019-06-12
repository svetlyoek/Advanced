using System;

namespace GenericBoxOfIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());

                var box = new Box<int>(number);

                Console.WriteLine(number.GetType() + ":" + " " + box.Value);
            }
        }
    }
}
