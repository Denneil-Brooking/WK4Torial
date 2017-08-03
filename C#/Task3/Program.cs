using System;
using System.Collections.Generic;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create var
            var Fruits = new string[5];
            //Loop start
            var count = 5;
            for (var i = 0; i < count; i++)
            {
                //Fruits = i + 1;
            //User input
            Console.WriteLine("Pick a Fruit");
            Fruits = Console.ReadLine();
            }
           

            //Print In Ascending Order
            Array.Sort(Fruits);
            Console.WriteLine(string.Join(",",Fruits));

            //Print in Descending Order.
            Array.Reverse(Fruits);
            Console.WriteLine(String.Join(",", Fruits));

            //Close
            Console.ReadKey();
        }
    }
}
