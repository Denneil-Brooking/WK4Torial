using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
      //Clear Console to set anew
       Console.Clear();
        //Vars for f/name & l/name
        var Fname = "";
        var Lname = "";
        //Print Asking for f/name
        Console.WriteLine("What is your First Name?");
        //fname to store user input
        Fname = Console.ReadLine();
        Console.WriteLine(Environment.NewLine);
        //Print results for f/name.
        Console.WriteLine($"Your First Name is: {Fname}");
       Console.WriteLine(Environment.NewLine);
       //Print Asking for l/name
        Console.WriteLine("What is your Last Name?");
        //lname to store user input
        Lname = Console.ReadLine();
        Console.WriteLine(Environment.NewLine);
        //Print results for l/name.
        Console.WriteLine($"Your Last Name is: {Lname}");
        Console.WriteLine(Environment.NewLine);
        //Print results for f/name and l/name
        Console.WriteLine($"Your Full Name is: {Fname} {Lname}");
        //Closing
        Console.ReadKey();
        }
    }
}
