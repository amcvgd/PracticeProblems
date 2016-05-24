using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsArrayRotated
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = HelperMethods.NumberGenerator.GetInteger(100, 0, 100);
            int[] array2 = HelperMethods.NumberGenerator.RotateArray(array1, 23);//rotates array by n spaces


            List<int> indexList = new List<int>();//This list will have the index of the first element of array 1. Since there might be multiple equal numbers in array 2 we will track the index of all numbers that are equal to array1[0]

            //Gets index of all the numbers from array2 that are equal to array1[0]
            for (int i = 0; i < array2.Length; i++)
            {
                if(array1[0] == array2[i])
                {
                    indexList.Add(i);

                }

            }
            bool found = true;
            int rotatedBy = 0; 
            foreach (int index in indexList)
            {

                for (int i = 1; i < array1.Length; i++)
                {
                    int tempindex = i + index;//offsets the current index by the index of the first elements of array1 in array2.

                    if (tempindex >= array2.Length)//index can't be higher or equal to length of array so this restarts index at 0 if that happens
                        tempindex = tempindex - array2.Length;

                    if (array1[i] == array2[tempindex])//if values are the same we might have found a correct sequence but we still gotta check all the elements of array2.
                        found = true;
                    else
                    {
                        found = false;
                        break;
                    }

                }
                if(found == true)
                {
                    rotatedBy = index;
                    break;
                }
            }
            Console.WriteLine("Array 2 is a rotated array version of first array and it was rotated by " + rotatedBy + " spaces.");
            Console.ReadLine();


        }
    }
}
