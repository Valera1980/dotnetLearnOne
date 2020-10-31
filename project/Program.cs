using System;
using System.Collections.Generic;
using System.Linq;
using ArrayArea;
using Cars;
using DelegatesExamples;
using Education;
using LinqEducation;

namespace educationOne
{
    class Program
    {
        static void Main(string[] args)
        {

            // LINQ
            FileReader reader = new FileReader("fuel.csv");
            List<Car> cars = reader.read();
            System.Console.WriteLine(cars.Count());


            var best = cars.OrderByDescending(c => c.Combined).ThenBy(c => c.Name).Take(10);
            foreach (var b in best)
            {
                System.Console.WriteLine(b.toString());
            }



            //**********************************************************
            //**********************************************************
            //**********************************************************
            // {
            //     Console.WriteLine($"arguments : {args[0]}");
            // }
            // else
            // {
            //     Console.WriteLine("=== Education one ====");
            // }
            // arrays
            // double[] arr = new double[] { 10.33, 52.22, 55.69 };
            // ArrayWorking arrW = new ArrayWorking();
            // arrW.loop();

            // list
            // List<int> lll = new List<int> { 55,99 };
            // ListWorking lw = new ListWorking(lll);
            // lll.Add(99);
            // lll.Add(34);
            // lll.Add(384);
            // lw.print();

            // delegate
            // LoggerWithDelegate lg = new LoggerWithDelegate();
            // string msg = lg.getMessage("today it is rainy");
            // System.Console.WriteLine(msg);
        }
    }
}
