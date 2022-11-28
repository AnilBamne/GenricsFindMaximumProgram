using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaximum222Batch
{
    internal class GenricClass<T> where T : IComparable<T>
    {
        //refactoring all three UCs in one generic class
        public static void FindMaxValue(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is greater", first);
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
