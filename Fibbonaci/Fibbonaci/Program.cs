using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonaci
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Sequential();
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: " + stopwatch.Elapsed.ToString());

            Console.WriteLine("Recursive:");
            stopwatch.Start();
            Console.Write("0,1,");
            Recursive(0,1,3, 20);
            Console.WriteLine("Time elapsed: " + stopwatch.Elapsed.ToString());
            stopwatch.Stop();
            Console.ReadLine();



        }

        private static void Recursive(int n, int n1, int curr, int max)
        {
            if (curr <= max)
            {
                Console.Write((n + n1).ToString()+",");

                Recursive(n1, n + n1, ++curr, max);
            }
           
               
        }

        private static void Sequential()
        {
            int limit = 20;

            string sequence = "0,1";//Sequence will always start with these numbers
            int n = 0;//First element of sequence
            int n1 = 1;//Second element of sequence
            List<int> fibonnaci = new List<int>() { 0, 1 };//Adds first two elements to sequence

            for (int i = 0; i < limit - 2; i++)
            {

                //adds the last two elements and adds the result to list
                fibonnaci.Add(fibonnaci[n] + fibonnaci[n1]);
                //update index
                n++;
                n1++;
                //update result string for sequence
                sequence += "," + (fibonnaci[n1]).ToString();

            }

            Console.WriteLine(sequence);
            
        }

        
    }
}
