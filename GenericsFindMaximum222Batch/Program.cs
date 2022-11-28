using System;

namespace GenericsFindMaximum222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics find maximum program");
            Console.WriteLine("Enter the use case to execute\n1:UC1 find max of three integers\n2:UC2 find max of three floats\n3:UC3 find max of three strings\n4:Refactor all three in one generic method\n");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1 :
                    ThreeIntegers.FindMaxValue();
                    break;
                case 2 :
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid option , Please provide a valid input");
                    break;
            }

        }
    }
}
