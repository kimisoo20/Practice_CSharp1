using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CSharp1
{

  class Program
    {
        static void Main(string[] args)
        {

            //Declare string message 
            string message = "Hello There, Welcome to C# Coding !!";
            //call ouput message
            Console.WriteLine(message);

            //ask user to enter name
            Console.WriteLine("Enter Name:");
            Console.WriteLine("Enter age:");

            //read user's input
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            //display user input
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);

            //Using Operator 
            var a = 10;
            var b = 5;

            Console.WriteLine("\nAddition is : " + (a + b));
            Console.WriteLine("Substraction is : " + (a - b));
            Console.WriteLine("Multiplication  is : " + (a * b));
            Console.WriteLine("Division is : " + (a / b));

            var KIMI = new anime();
            KIMI.Series = "Jujutsu Kaisen";
            KIMI.Movie = "Jujutsu Kaisen 0";
            KIMI.Choices();


        }
    }
}
