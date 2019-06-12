using System;
using System.Linq;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var item = new EqualityScale<int>(10, 7);
            var anotherItem = new EqualityScale<string>("Ivan","Ivan");

            Console.WriteLine(item.AreEqual());
            Console.WriteLine(anotherItem.AreEqual());
        }
    }
}
