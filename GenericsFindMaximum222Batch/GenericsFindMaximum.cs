using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaximum222Batch
{
    internal class GenericsFindMaximum
    {
        //refactoring all three UCs in one generic method
        public static void FindMaxValue<T>(T first, T second, T third) where T:IComparable  
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is greater",first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is greater", second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("{0} is greater", third);
            }
            else
                Console.WriteLine("All are equal. ");
        }
    }
}
