using System;
using System.Collections.Generic;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            var print = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == '(')
                {

                    stack.Push(text[i].ToString());
                }
                else if (text[i] == ')')
                {
                    var openBracket = stack.Pop();
                    int openBracketIndex = text.IndexOf(openBracket);
                    int length = i - openBracketIndex + 1;
                    print = text.Substring(openBracketIndex, length);
                    Console.WriteLine(print);
                }

            }

        }
    }
}