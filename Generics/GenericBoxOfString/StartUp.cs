using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string text = Console.ReadLine();

                var box = new Box<string>(text).ToString();

                Console.WriteLine(box);
            }
        }
    }
}
