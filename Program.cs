using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                new InstanceCounter();
            }
            //TaskFactory f = new TaskFactory();
            //f.StartNew(() =>
            //{
            //    while (true)
            //    {
            //        new InstanceCounter();
            //    }
            //});
            //f.StartNew(() =>
            //{
            //    while (true)
            //    {
            //        new InstanceCounter();
            //    }
            //});

            Console.ReadLine();
        }
    }
}