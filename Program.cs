using System;

namespace AgeCalculator
{
    class Program
    {
        // will share his 
        static void Main(string[] args)
        {
            //declare 
            decimal number1 = 0;
            decimal number2 = 0;
            string options = "";

            Console.WriteLine("Enter a number ");
            number1 = decimal.Parse(Console.ReadLine());
            //pass
            Console.WriteLine("Enter another number");
            number2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Select an option ");
            // options = Console.ReadLine();

            //Add, Subtract, Divide, Multiply
            Console.WriteLine("\t a - Add");
            Console.WriteLine("\t s - Subtract");
            Console.WriteLine("\t d - Divide");
            Console.WriteLine("\t m - Multiply");
            options = Console.ReadLine();
            if (options == "a") // codition here
            {
                //action
                Console.WriteLine($"Your results are: + {number1} + {number2} =" + (number1 + number2) );
            }
            else if(options == "d")
            {
                Console.WriteLine($"Your results are: + {number1} / {number2} =" + (number1 / number2));

            }
            else if(options == "s")
            {
                Console.WriteLine($"Your results are: + {number1} - {number2} =" + (number1 - number2));

            }
            else if(options == "m")
            {
                Console.WriteLine($"Your results are: + {number1} * {number2} =" + (number1 * number2));

            }
            else
            {
                Console.WriteLine("What you picked is not on the options list");
            }
            Console.WriteLine("Press Enter to end the program");
            Console.ReadKey();

        }
    }
}
