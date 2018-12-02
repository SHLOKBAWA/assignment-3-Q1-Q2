using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3shlokbawaP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            string operation;
            int res;
            try
            {
            again:
                Console.Write("Enter the first number : ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number : ");
                Num2 = Convert.ToInt32(Console.ReadLine());
            num:
                Console.Write("Enter the operation(addition,subraction,multiplication,division) ");
                operation = Console.ReadLine();
                if (operation == "multiplication")
                {
                    res = Num1 * Num2;
                    Console.WriteLine("producr of " + Num1 + " & " + Num2 + " is " + res);
                    goto again;
                }
                else if (operation == "div")
                {
                    res = Num1 / Num2;
                    Console.WriteLine("The division of " + Num1 + " & " + Num2 + " is " + res);
                    goto again;
                }
                else if (operation == "add")
                {
                    res = Num1 + Num2;
                    Console.WriteLine("The addition of " + Num1 + " & " + Num2 + " is " + res);
                    goto again;
                }
                if (operation == "sub")
                {
                    res = Num1 - Num2;
                    Console.WriteLine("the subtraction of " + Num1 + " & " + Num2 + " is " + res);
                    goto again;
                }
                else
                {
                    Console.WriteLine("Enter a valid operation");
                    goto num;
                }

            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Enter a valid expression");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid format");
            }
        }
    }
}
