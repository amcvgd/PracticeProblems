using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumbersInCommon
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = HelperMethods.NumberGenerator.GetInteger(10, 0, 11, (int)DateTime.Now.Ticks); //Array # 1 of random integers
            int[] array2 = HelperMethods.NumberGenerator.GetInteger(10, 0, 11, (int)DateTime.Now.Ticks); //Array # 2 of random integers
            Dictionary<int, int> dict = new Dictionary<int, int>(); //will be used to determine if there are matching pairs between arrays
            Console.WriteLine("Array1: ");

            for(int i = 0; i < array1.Length; i++)//Loop adds all items of array1 to the dictonary using the integers themselves as the key
            {
                Console.Write(array1[i] + " ");
                try
                {
                    dict.Add(array1[i], 1);
                }
                catch
                {
                   /* if (dict.ContainsKey(array1[i]))
                    {
                        dict[array1[i]] += 1;

                    }*/

                }

            }
            Console.WriteLine();
            Console.WriteLine("Array1: ");
            for (int i = 0; i < array2.Length; i++)//This just prints the values of array 2
            {
                Console.Write(array2[i] + " ");
                

            }

            // Console.WriteLine("Array1: ");
            Console.WriteLine();
            Console.Write("Repeated items: ");
            for (int i = 0; i < array2.Length; i++)
            {
                
                    if (dict.ContainsKey(array2[i]))//if dictionary has the key then that means we've found a matching pair and we print it out but to avoid repetition we only do it if value is 1
                    {
                        if(dict[array2[i]] == 1)
                            Console.Write(array2[i] + " ");
                        
                        dict[array2[i]] += 1;

                    }

                

            }

            Console.ReadLine();




        }
    }
}
