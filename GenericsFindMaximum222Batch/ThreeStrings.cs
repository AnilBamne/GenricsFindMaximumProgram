using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaximum222Batch
{
    internal class ThreeStrings
    {
        //Taking input of three Strings and finding maximum of them.
        //using CompareTo method.
        public static void FindMaxValue()
        {
            Console.WriteLine("Enter three Strings");
            String string1 = Console.ReadLine();
            String string2 = Console.ReadLine();
            String string3 = Console.ReadLine();
            if (string1.CompareTo(string2) > 0 && string1.CompareTo(string3) > 0)
            {
                Console.WriteLine("{0} is greater", string1);
            }
            else if (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0)
            {
                Console.WriteLine("{0} is greater", string2);
            }
            else if (string3.CompareTo(string1) > 0 && string3.CompareTo(string2) > 0)
            {
                Console.WriteLine("{0} is greater", string3);
            }
            else
                Console.WriteLine("All the strings are Equal ");
        }
    }
}
