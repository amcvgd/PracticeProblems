using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    public class NumberGenerator
    {

        /// <summary>
        /// Creates an array of random integers
        /// </summary>
        /// <param name="sizeOfArray">Size of array</param>
        /// <param name="min">Inclusive minumum integer value</param>
        /// <param name="max">Exlusive maximum integer value</param>
        /// <returns></returns>
        public static int[] GetInteger(int sizeOfArray, int min, int max)
        {

            Random random = new Random();
            int[] result = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {

                result[i] = random.Next(min, max);
            }

            return result;
        }


    }
}
