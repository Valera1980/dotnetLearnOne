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
            // FileReader reader = new FileReader("fuel.csv");
            List<Car> cars = FileReader.readCars("fuel.csv");
            List<Manufacturer> manufacturers = FileReader.readManufactures("manufacturers.csv");
            System.Console.WriteLine(cars.Count());
            System.Console.WriteLine(manufacturers.Count());


            // var res = cars.OrderByDescending(c => c.Combined).ThenBy(c => c.Name).Take(10);
            // var res = cars.All(c => c.Manufacturer == "Ford");
            // System.Console.WriteLine(res);
            // foreach (var b in res)
            // {
            //     System.Console.WriteLine(b.toString());
            // }

            //************** JOINING *******************
            var joinRes = cars.Join(
                manufacturers,
                c => c.Manufacturer,
                m => m.Name,
                (c, m) => new { m.Headquarters, c.Name, c.Combined }
            )
            .OrderByDescending(c => c.Combined);

            foreach (var i in joinRes)
            {
                System.Console.WriteLine(i);
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
