using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaximum222Batch
{
    internal class ThreeFloatValues
    {
        //Taking input of three Floats and finding maximum of them.
        //using CompareTo method.
        public static void FindMaxValue()
        {
            Console.WriteLine("Enter three Float values");
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                Console.WriteLine("{0} is greater", firstNum);
            }
            else if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                Console.WriteLine("{0} is greater", secondNum);
            }
            else if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                Console.WriteLine("{0} is greater", thirdNum);
            }
            else
                Console.WriteLine("All the mumbers are Equal ");
        }
    }
}
