using System;
using System.Collections.Generic;
using ArrayArea;

namespace educationOne
{
    class Program
    {
        static void Main(string[] args)
        {
             if (args.Length > 0)
            {
                Console.WriteLine($"arguments : {args[0]}");
            }
            else
            {
                Console.WriteLine("=== Education one ====");
            }
            // arrays
            double[] arr = new double[] { 10.33, 52.22, 55.69 };
            ArrayWorking arrW = new ArrayWorking();
            arrW.loop();

            // list
            List<int> lll = new List<int> { 55, 66, 77, 88 };
            ListWorking lw = new ListWorking(lll);
            lll.Add(99);
            lll.Add(34);
            lll.Add(384);
            lw.print();
        }
    }
}
