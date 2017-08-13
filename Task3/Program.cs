using System;
using System.Collections.Generic;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clear Console to set anew
            Console.Clear();
            //Create var
            var Fruits = new string[5];
            var count = 5;
            string[] step = {"1st", "2nd", "3rd", "4th", "5th"};
            
            //Create for loop 
            for (var i = 0; i < count; i++)
            {
                //Ask for a Fruit
                foreach(string value in step)
                {
                Console.WriteLine($"Pick your {value} Fruit");
            
            //User input
            Fruits[i] = Console.ReadLine();
            //Inform user of data input
           Console.WriteLine($"You picked {Fruits}");
                }
            }

            //Print in Ascending Order
            Array.Sort(Fruits);
            Console.WriteLine(string.Join(",",Fruits));

            //Print in Descending Order.
            Array.Reverse(Fruits);
            Console.WriteLine(String.Join(",", Fruits));

            //Close program
            Console.ReadKey();
        }
    }
}
