using System;

namespace GenericsFindMaximum222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics find maximum program");
            Console.WriteLine("Enter the use case to execute\n1:UC1 find max of three integers\n2:UC2 find max of three floats\n3:UC3 find max of three strings\n4:Refactor all three in one generic method\n5:Refactor2 Geneeric class" +
                "\n6:Extend MaxMethod to Generic methos");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1 :
                    ThreeIntegers.FindMaxValue();
                    break;
                case 2 :
                    ThreeFloatValues.FindMaxValue();
                    break;
                case 3:
                    ThreeStrings.FindMaxValue();
                    break;
                case 4:
                    GenericsFindMaximum.FindMaxValue<int>(12,43,11);
                    GenericsFindMaximum.FindMaxValue<double>(10.3,4.3,33.1);
                    GenericsFindMaximum.FindMaxValue<String>("John","Roman","Goldberg");
                    break;
                case 5:
                    GenricClass<int>.FindMaxValue(20,20,22);
                    GenricClass<double>.FindMaxValue(21.5,10.3,21.51);
                    GenricClass<string>.FindMaxValue("Bidar","Gulbarga","Bengaluru");
                    break;
                case 6:
                    GenericMaximum<int> max = new GenericMaximum<int>(20,30,40);
                    GenericMaximum<double> max1 = new GenericMaximum<double>(20.5,32.02,40.2);
                    GenericMaximum<string> max2 = new GenericMaximum<string>("Bidar", "Gulbarga", "Bengaluru");
                    max.MaxMethod();
                    max1.MaxMethod();
                    max2.MaxMethod();
                    break;
                default:
                    Console.WriteLine("Invalid option , Please provide a valid input");
                    break;
            }

        }
    }
}
