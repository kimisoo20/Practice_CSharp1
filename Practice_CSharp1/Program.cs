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
            string message = "Hello World!!";
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






        }
    }
}
