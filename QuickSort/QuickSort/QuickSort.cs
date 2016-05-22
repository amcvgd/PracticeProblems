using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{


    class QuickSort
    {

        /// <summary>
        /// Call This if you want to sort an Array. It will convert it to a List.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Sort(int[] array)
        {
            

            return Sort(array.ToList()).ToArray();

        }

        /// <summary>
        /// Sorts a List of integers
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> Sort(List<int> list)
        {
            //If list has only one item that means we have reached the end of one of the previous partitions so we just return the list itself
            if (list.Count <= 1)
                return list;

            //We get the pivot that will be used to create partition. Pivot is the last item of List
            int pivot = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            List<int> sortedList = new List<int>();

            //Partition1 will have items less than or equal to pivot
            List<int> partition1;
            //Partition2 will have items greater than pivot
            List<int> partition2;

            //Partition list into two using pivot
            partitionArray(list, out partition1, out partition2, pivot);

            //Sort partitions using recursive method
            partition1 = Sort(partition1);
            partition2 = Sort(partition2);
            //Merge partitions but first add pivot integer between two partitions
            partition1.Add(pivot);
            partition1.AddRange(partition2);
            sortedList = partition1;


            return sortedList;

        }

        private static void partitionArray(List<int> list, out List<int> partition1, out List<int> partition2, int pivot)
        {
            
            partition1 = new List<int>();
            partition2 = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= pivot)
                {

                    partition1.Add(list[i]);

                }
                else
                {
                    partition2.Add(list[i]);

                }

            }
          
        }
    }
}
