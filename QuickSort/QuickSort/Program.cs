using HelperMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = NumberGenerator.GetInteger(100000, 1, 10000000);

            int[] sortedNumbers = QuickSort.Sort(numbers);

            Console.WriteLine();

        }
    }
}
