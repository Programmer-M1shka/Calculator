using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("       🧮 C# Console Calculator");
            Console.WriteLine("==================================\n");



            Console.Write("Enter the first number :) ");
            double number1 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Choose an operator: +, -, *, /");
            Console.Write("Enter Operator");
            char gg = Console.ReadKey().KeyChar;
            Console.WriteLine();




            Console.Write("Enter the second number :) ");
            double number2 = Convert.ToDouble((Console.ReadLine()));


            


            double shedegi = 0;                                                            
            bool validuri = true;

            switch (gg)
            {
                case '+':
                    shedegi = number1 + number2;
                    break;

                case '-':
                    shedegi = number1 - number2;
                    break;

                case '*':
                    shedegi = number1 * number2;
                    break;

                case '/':
                   if (number2 != 0)
                    {
                        shedegi = number1 / number2;
                    }
                    else
                    {
                        validuri = false;
                    }
                    break;
            }
            if (validuri)
            {
                Console.WriteLine($"Result Calculate: {number1} {gg} {number2} = {shedegi}");
            }
            Console.WriteLine("BYE.");
            Console.ReadKey();
        }
    }
}
