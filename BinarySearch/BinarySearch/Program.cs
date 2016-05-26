using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of integers
            int[] array = { 1, 3, 5, 7, 8, 23, 26, 28, 30, 32, 60, 67, 75, 84, 94, 100, 101, 200, 205, 230, 260, 1000, 2900, 7980 };
            int toBeFound = 8000;//number to be found in array



            Search(array,toBeFound, 0, array.Length - 1);//recursive binary search
            Console.ReadLine();


        }

        public static void Search(int[] array, int target, int start, int end)
        {

            int mid = (end - start) / 2 + start; //gets the index of the middle of array
            
            if (array[mid] == target)//if the element at the middle is our target, then finish searching
            {
                Console.WriteLine("Target " + target + "  found at index " + mid);
                return;
            }
            if(mid == start || mid == end)//if element in the middle is the start or end of array then element was not found.
            {

                Console.WriteLine("Target not found");
                return;

            }
            if(array[mid] > target)//If element at middle is greater than target then we proceed to search only on the right side of the array
            {
                Search(array, target, start, mid);

            }
            else//else we search on the left side of array
            {
                Search(array, target, mid + 1, end);

            }

        }
    }
}
