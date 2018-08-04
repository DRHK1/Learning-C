using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1; //First Number
            int Num2; //Second Number
            int NumResult; //Result of the two numbers

            //Selecting what happens to the numbers
            Console.WriteLine("Welcome to the Calculator1\n\n Would you like to <Add>,<Subtract> or <Multiply>?");
            
            Console.WriteLine("What is the first number?");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the second number?");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your Answer is: ");
            Console.WriteLine(Num1 * Num2);
            Console.WriteLine("\n Press anything to exit");
            Console.ReadKey();
            
        }
    }
}
