using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsThatAddUpTo10
{
    class Program
    {
        static void Main(string[] args)
        {

            int capacity = 1000;
            int addTo = 67;
            //Array of randomly chosen integers
            int[] integers = HelperMethods.NumberGenerator.GetInteger(capacity, 1, addTo);
           
            //Dictionary will tell whether a number has a matching pair that adds to a number n or not.
            Dictionary<int,int> dict = new Dictionary<int,int>();  


            foreach(int i in integers)
            {
                int tempSum = addTo - i;//this will be used as the key for the dictionary
                try
                {
                    if (tempSum >= 0 || dict[tempSum] >= 1)//if the sum is a key that already exists in dictionary then we've found a matching pair
                        Console.WriteLine("Pair: [" + i + "," + tempSum + "]");

                    dict.Add(i, 1);//add integer to dictionary and set value to 1.

                }
                catch
                {


                }




            }

            Console.ReadLine();

            //1,2,3,4,5     6,7,8,9

        }
    }
}
