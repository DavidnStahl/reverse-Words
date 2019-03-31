using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversesentenceNY
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(InputReversed(UserInput()));

            Console.ReadLine();
        }
        public static string UserInput()
        {
            Console.Write("Write a sentence and it will reverse: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string InputReversed(string userInput)
        {
           string inputReversed = "";

           foreach (var word in userInput.Split(' '))
            {
                string spacing = " ";
                foreach (var character in word.ToCharArray())
                {
                    spacing = character + spacing;
                }
                inputReversed = inputReversed + spacing + "";
            }

            return inputReversed;
        }
       
        
        
    }
}
