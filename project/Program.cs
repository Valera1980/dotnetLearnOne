using System;
using System.Collections.Generic;
using System.Linq;
using ArrayArea;
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
            IEnumerable<User> users = new List<User> { new User("1171", "111", 22), new User("222", "222", 33) };

            LinqOne lqOne = new LinqOne();
            var res = lqOne.getUserQuerySyntax(users);
            var res1 = lqOne.getUserMethodSyntax(users);
            System.Console.WriteLine(res);
            res1.print();
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
