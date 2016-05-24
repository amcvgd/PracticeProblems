using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUniqueInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = HelperMethods.NumberGenerator.GetInteger(10, 1, 10);//Generates random array of int
            List<int> uniqueIntegers = new List<int>();
            Dictionary<int, int> isRepeated = new Dictionary<int, int>();//list that will contain all elements that are not repeated
            Console.WriteLine("Array to be Processed: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                try
                {
                    isRepeated.Add(array[i], 1);//if element already exists in dictionary then it will throw an error and we remove it from list of integers not repeated
                    uniqueIntegers.Add(array[i]);//Otherwise we add it to the list
                    

                }
                catch
                {
                    if (isRepeated.ContainsKey(array[i]))
                    {
                        isRepeated[array[i]] += 1;//this step is unncesary but counts how many times an element is repeated
                        uniqueIntegers.Remove(array[i]);//removes element from list
                    }

                }

            }
            Console.WriteLine();
            Console.WriteLine("Non repeated integers: ");
            foreach(int i in uniqueIntegers)
            {
                Console.Write(i + " ");
            }
           // Console.WriteLine();
            Console.ReadLine();

        }
    }
}
