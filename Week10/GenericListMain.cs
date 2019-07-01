using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10.GenericList;

namespace Week10
{
    class GenericListMain
    {       
        static void Main(string[] args)
        {
            //New integer list
            GenericList<int> integerCheck = new GenericList<int>(5);

            //Add elements in list
            integerCheck.AddElement(5);
            integerCheck.AddElement(8);
            integerCheck.AddElement(6);
            integerCheck.AddElement(9);
            integerCheck.AddElement(11);

            //Print the elements after they were added
            integerCheck.ToString();

            //Min and max in the list:
            int minIntegerElement = integerCheck.Min();
            int maxIntegerElement = integerCheck.Max();
            Console.WriteLine("\nThe min element is {0}" , minIntegerElement);
            Console.WriteLine("The max integer element is {0}",maxIntegerElement);
            Console.WriteLine("Integer list after cleared out:");
            integerCheck.ClearList();
            integerCheck.ToString();

            Console.ReadKey();
        }
    }
}
