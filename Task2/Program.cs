using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clear Console to set anew
            Console.Clear();
            //create var
            var favnum = "";
            var inputnum = 0;
           
            //Ask for fav number
            Console.WriteLine("What is your fav number?");
            //User input of number.
            favnum = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            //Input write
            Console.WriteLine($"Your Fav Number is {favnum}");
            //loop it 
            var isNumber = int.TryParse(favnum, out inputnum);
            for (var table = 0; table <= 12; table++)
            {
             
             //Print input times table up to 12  
             Console.WriteLine(inputnum*table);  
            }
            Console.WriteLine(Environment.NewLine);
           for (var table = 0; table <= 12; table++)
            { 
            
            //Print the stages
            Console.WriteLine("Stage {0}*{1}={2}", favnum, table, inputnum*table); 
            }
            //Close
            Console.ReadKey();
        }
    }
}
