using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaximum222Batch
{
    internal class ThreeIntegers
    {
        //Taking input of three integers and finding maximum of them.
        //using CompareTo method.
        public static void FindMaxValue()       
        {
            Console.WriteLine("Enter three Integer values");
            int firstNum=int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
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
