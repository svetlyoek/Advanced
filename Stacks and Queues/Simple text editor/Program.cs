using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_text_editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            for(int i=0;i<counter;i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string command = commands[0];
                switch(command)
                {
                    case "1":
                        string textToAppend = commands[1];
                        stack.Push(text.ToString());
                        text.Append(textToAppend);
                        break;
                    case "2":
                        int countToRemove =int.Parse(commands[1]);
                        stack.Push(text.ToString());
                        text.Remove(text.Length - countToRemove, countToRemove);
                        break;
                    case "3":
                        int index = int.Parse(commands[1])-1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":

                        text.Clear();
                        text.Append(stack.Pop());
                        break;
                }
            }
        }
    }
}
