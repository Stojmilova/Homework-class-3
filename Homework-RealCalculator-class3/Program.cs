using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_RealCalculator_class3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] stringArray = new string[0] { };

                Console.WriteLine("Please enter arithmetic operation: +,-,/or *");
                string operand = Console.ReadLine();

                if (operand == "+" || operand == "-" || operand == "*" || operand == "/")
                {
                    Console.WriteLine("Enter the first number");
                    int firstNumber;
                    bool isSuccessFirstNum = int.TryParse(Console.ReadLine(), out firstNumber);

                    Console.WriteLine("Enter the second number");
                    int secondNumber;
                    bool isSuccesSecondNum = int.TryParse(Console.ReadLine(), out secondNumber);

                    if (isSuccessFirstNum && isSuccesSecondNum)
                    {
                        double result = 0;

                        if (operand == "+")
                        {
                            result = secondNumber + firstNumber;
                        }
                        else if (operand == "-" && secondNumber > firstNumber)
                        {
                            result = secondNumber - firstNumber;
                        }
                        else if (operand == "-" && firstNumber > secondNumber)
                        {
                            result = firstNumber - secondNumber;
                        }
                        else if (operand == "*")
                        {
                            result = firstNumber * secondNumber;
                        }
                        else if (operand == "/")
                        {
                            result = firstNumber / secondNumber;
                        }
                        else if (operand == "/" && secondNumber == 0)
                        {
                            Console.WriteLine("You can not divide by zero!");
                        }
                        Console.WriteLine("The result is: " + result);
                    }
                    else
                    {
                        Console.WriteLine("You entered invalid numbers!Please try again");
                        continue;
                    }


                    Array.Resize(ref stringArray, stringArray.Length + 1);
                    stringArray[stringArray.Length - 1] = "Operand:" + operand + "," + " " + "First Number:" + Convert.ToString(firstNumber) + "," + " " + "secondNumber:" + Convert.ToString(secondNumber);


                    Console.WriteLine("Do you want another calculation? Please enter Y / N");
                    string calculation = Console.ReadLine();
                    if (calculation.ToLower() == "n")
                    {
                        Console.WriteLine("The calculation process is finished:");
                        for (int i = 0; i < stringArray.Length; i++)
                        {
                            Console.WriteLine(stringArray[stringArray.Length - 1]);

                        }
                        Console.ReadLine();
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You entered invalid operands!Please try again");
                }

            }

        }
    }
}
