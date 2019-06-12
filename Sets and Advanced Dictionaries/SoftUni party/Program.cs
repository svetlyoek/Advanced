using System;
using System.Collections.Generic;

namespace SoftUni_party
{
    class Program
    {
        static void Main(string[] args)
        {
            string guests = string.Empty;
            string listGuests = string.Empty;
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
          

            while ((guests = Console.ReadLine()) != "PARTY")
            {
                if (guests.StartsWith('1') || guests.StartsWith('2') || guests.StartsWith('3') || guests.StartsWith('4')
                    || guests.StartsWith('5') || guests.StartsWith('6') || guests.StartsWith('7')
                    || guests.StartsWith('8') || guests.StartsWith('9'))
                {
                    vipGuests.Add(guests);
                }

                else
                {
                    regularGuests.Add(guests);
                }
            }

            while ((listGuests = Console.ReadLine()) != "END")
            {
                if (listGuests.StartsWith('1') || listGuests.StartsWith('2') || listGuests.StartsWith('3') || listGuests.StartsWith('4')
                   || listGuests.StartsWith('5') || listGuests.StartsWith('6') || listGuests.StartsWith('7')
                   || listGuests.StartsWith('8') || listGuests.StartsWith('9'))
                {
                    if (vipGuests.Contains(listGuests))
                    {
                        vipGuests.Remove(listGuests);
                    }
                }
                else
                {
                    if(regularGuests.Contains(listGuests))
                    {
                        regularGuests.Remove(listGuests);
                    }
                }

            }

            Console.WriteLine($"{vipGuests.Count + regularGuests.Count}");
           
            foreach(var vip in vipGuests)
            {
                Console.WriteLine($"{vip}");
            }

            foreach(var regular in regularGuests)
            {
                Console.WriteLine($"{regular}");
            }
        }
    }
}


