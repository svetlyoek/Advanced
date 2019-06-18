using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var myLinkedList = new DoublyLinkedList<string>();

            myLinkedList.AddLast("Pesho");
            myLinkedList.AddFirst("666");
            myLinkedList.AddLast("That's awesome!");

            foreach (var word in myLinkedList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
