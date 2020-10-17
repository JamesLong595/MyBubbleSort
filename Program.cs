using System;
using System.IO;
using System.Diagnostics;

namespace MyBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] BigArr = new int[10000];
            Random RanGen = new Random();
            for (int i = 0; i < BigArr.Length; i++)
            {
                BigArr[i] = RanGen.Next(0, 100000);
            }
            Console.WriteLine("Press any key to view the unsorted array.");
            Console.ReadKey();
            Console.WriteLine("\n");
            for (int i = 0; i < BigArr.Length; i++)
            {
                if (i < BigArr.Length - 1)
                {
                    Console.Write(BigArr[i] + ", ");
                }
                else
                {
                    Console.Write(BigArr[i]);
                }
            }
            Stopwatch timer = Stopwatch.StartNew();
            BubSort(BigArr, BigArr.Length);
            timer.Stop();
            long algTime = timer.ElapsedMilliseconds;
            Console.WriteLine("\n\nBubble sort algorithm took " + algTime + " milliseconds.\n");
            Console.WriteLine("Press any key to view the sorted array.\n");
            Console.ReadKey();
            for (int i = 0; i < BigArr.Length; i++)
            {
                if (i < BigArr.Length - 1)
                {
                    Console.Write(BigArr[i] + ", ");
                }
                else
                {
                    Console.Write(BigArr[i]);
                }
            }
            Console.WriteLine("\n\nPress any key to end the program."); 
            Console.ReadKey();
        } // end of method Main
        static int[] BubSort(int[] Arr, int n)
        {
            int hold;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        hold = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = hold;
                    }
                }
            }
            return Arr;
        } // end of method BubSort
    } // end of class Program
} // end of namspace MyBubbleSort
