using System;
using System.Collections.Generic;
using System.Threading;

namespace Q2_Akbor_Rengin_Ozgun_Hw2
{
    class Program
    {

        class Container
        {

            public static List<int> fibseries = new List<int>();

        }

        public static void CreateFibSeries()

        {
            int i;
      
            Container.fibseries.Add(0);
            Container.fibseries.Add(1);
   
            for (i = 2; i < 10; ++i)
                Container.fibseries.Insert(i, Container.fibseries[i - 1] + Container.fibseries[i - 2]);
        }

        public static void thread1()
        {
            CreateFibSeries(); // create list for one time
            int[] series;
            series = Container.fibseries.ToArray();  // Get the series to an array
            Console.Write("Fibonacci Series:"); 
            for (int i = 0; i < series.Length; i++)
            {
                Console.Write(series[i] + " ");
                Thread.Sleep(500);  // Wait for 5 seconds = 500 miliseconds
            }
        }

        public static void thread2()//second thread
        {  
 
            int[] series;
            series = Container.fibseries.ToArray(); // Get the series to an array
            int[] reverse=series;
            Array.Reverse(reverse); // reverse the thread
            Console.Write("\n Reversed Series: "); 
            for(int i=0; i < reverse.Length; i++) // print the thread
            {
                Console.Write(reverse[i] + " ");
            Thread.Sleep(500); // Wait for 5 seconds = 500 miliseconds
            }
           
         
        }

        static void Main(string[] args)
            
        {
            Thread t1 = new Thread(thread1);
            Thread t2 = new Thread(thread2);
            t1.Start();
            Thread.Sleep(10000); // Fırst thread waits with 10 seconds == 10000miliseconds
            t2.Start();
           
        }

    }



}
