using System;
using System.Linq;
using System.Collections.Generic;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Create vard
            int num = 5;
            var i = 0;
            
            //start loop
            do
            {
            var a = i + 1;
            var x = a.Sum();
            //Ask for a number
            Console.WriteLine("Please type in a Number");
            //User Input
            x = Console.ReadLine();
            //Summon the Input
            Console.WriteLine($"You Picked {x}");
            //Check if it is a Number

            i++;
            
            //Save to num

            //Print Sum of numbers.
            Console.WriteLine();
            //Print Avarage of numbers
            Console.WriteLine();

            }while (i < num);
            //Close
            Console.ReadKey();
        }
    }
}
