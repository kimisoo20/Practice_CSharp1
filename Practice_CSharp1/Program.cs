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
            //display user's input
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);

            //Using Operator 
            var a = 10;
            var b = 5;

            Console.WriteLine("\nPractice coding Using Operators");  
            Console.WriteLine("Addition is : " + (a + b));
            Console.WriteLine("Substraction is : " + (a - b));
            Console.WriteLine("Multiplication  is : " + (a * b));
            Console.WriteLine("Division is : " + (a / b));

            //Call class Anime
            var Anime = new anime();
            Anime.Series = "Jujutsu Kaisen";
            Anime.Movie = "Jujutsu Kaisen 0";
            //Call method
            Anime.Choices();

            //Call Class BMI
            var BMI = new BMI();
            BMI.BMI_Calculator();


            Console.WriteLine("\nArray Example");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("Your selected car is :"+cars[1]);

            Console.WriteLine("\nMore C# coding practice otw" );

 

        }
    }
}
