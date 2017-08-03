using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
        //Vars for f/name & l/name
        var Fname = "";
        var Lname = "";
        //Print Asking for f/name
        Console.WriteLine("What is your First Name?");
        //fname to store user input
        Fname = Console.ReadLine();
        //Print results for f/name.
        Console.WriteLine($"First Name is: {Fname}");
        //Print Asking for l/name
        Console.WriteLine("What is your Last Name?");
        //lname to store user input
        Lname = Console.ReadLine();
        //Print results for l/name.
        Console.WriteLine($"Last Name is: {Lname}");
        //Print results for f/name and l/name
        Console.WriteLine($"Full Name is: {Fname} {Lname}");
        //Closing
        Console.ReadKey();
        }
    }
}
