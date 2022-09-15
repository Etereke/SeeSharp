using System;

namespace ConsoleApp1
{
    class GCTest
    {
        static int numOfThis = 0;
        public static int maxNumOfThis = 0;
        public GCTest()
        {
            numOfThis++;
            Console.WriteLine(GCTest.numOfThis);
            if (numOfThis > maxNumOfThis)
            {
                maxNumOfThis = numOfThis;
            }
        }

        ~GCTest()
        {
            numOfThis--;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 500000; i++)
            {
                new GCTest();
            }
            //while (true)
            //{
            //    new GCTest();
            //}
            Console.WriteLine("The garbage collector started at object #" + GCTest.maxNumOfThis);
        }
    }
}
