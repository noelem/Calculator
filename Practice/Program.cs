using System;
using System.Collections.Generic;
using System.Threading;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            while (runProgram)
            {

                double firstNumber, secondNumber, result;
                int op;

                /*
                if (double.TryParse(n, out firstNumber)) {

                }*/


                Console.WriteLine("Type in the first number");
                firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Type in the second number");
                secondNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select opration type?");
                Console.WriteLine("\n1: + \n2: -\n3: *\n4: /");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                switch (op)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}\n");
                        ComputeAgain();
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result}\n");
                        ComputeAgain();
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}\n");
                        ComputeAgain();
                        break;
                    case 4:
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}\n");
                        ComputeAgain();
                        break;
                    default:
                        Console.WriteLine("Thats not an option");
                        Console.WriteLine("1: Quit \n2: Compute again");
                        int answer = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (answer == 1)
                        {
                            Console.WriteLine("Goodbye :) ");
                            Thread.Sleep(1000);
                            runProgram = false;
                            break;
                        }
                        else continue;
                }

                void ComputeAgain() {
                    Console.WriteLine("Pres any key to compute again");
                    Console.ReadKey();
                    Console.Clear();
                }


            } //while
        }
    }
}
