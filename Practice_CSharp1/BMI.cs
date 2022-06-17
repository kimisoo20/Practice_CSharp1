using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CSharp1
{
    class BMI
    {

        public void BMI_Calculator()
        {
            Console.WriteLine("\nExample BMI Calculator Coding");
            Console.WriteLine("===========");
           

            //ask user to enter Weight
            Console.WriteLine("Weight in kg: ");
            //declare kg in double
            double kg;
            kg = Convert.ToDouble(Console.ReadLine());
            //ask user to enter Height
            Console.WriteLine("Height in meter: ");
            //declare m in double
            double m;
            m = Convert.ToDouble(Console.ReadLine());
            //ask user to ender Gender M = Male and F = Female
            Console.WriteLine("Gender (M/F):");
            string Gender = Console.ReadLine();

            //declare variable BMI in double
            double BMI;
            BMI = kg / (m * m);

            //display user diplay output
            Console.WriteLine("Your Bmi is " + BMI);
            //set conditions for female BMI categories 
            if (BMI < 19 & Gender == "F")
            { Console.WriteLine("-> Underweight"); }

            if (BMI >= 19 & BMI <= 24 & Gender == "F")
            { Console.WriteLine("-> Normal"); }

            if (BMI > 24 & Gender == "F")
            { Console.WriteLine("-> Overweight"); }

            //set conditions for male BMI categories 
            if (BMI < 20 & Gender == "M")
            { Console.WriteLine("-> Underweight"); }

            if (BMI >= 20 & BMI <= 25 & Gender == "M")
            { Console.WriteLine("-> Normal"); }

            if (BMI > 25 & Gender == "M")
            { Console.WriteLine("-> Overweight"); }

            Console.ReadLine();

        }
    }
}
