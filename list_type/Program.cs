using System;
using System.Collections.Generic;

namespace list_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello List!");
            List<int> someInts = new List<int>();
            someInts.Add(2);
            Console.WriteLine($"someInts[0]: {someInts[0]}");

            List<int> moreInt = new List<int>(){1,2,3,4,5};
            Console.WriteLine($"moreInt[0]: {moreInt[0]}");
            Console.WriteLine($"moreInt[3]: {moreInt[3]}");

            string[] colors = "Red,Green,Blue,Purple".Split(',');
            List<string> moreSt = new List<string>(colors);
            Console.WriteLine($"moreSt[3]: {moreSt[3]}");

            double[] d = new double[]{1,2,2.4,9.09};
            List<double> moreDouble = new List<double>(d);
            Console.WriteLine($"moreDouble[3]: {moreDouble[3]}");


            List<string> colors_b = new List<string>(){"black","red","green"}; 
            Console.WriteLine("Colors_b length:"+colors_b.Count);
            Console.WriteLine("Colors_b[0]:"+colors_b[0]);
            colors_b.Remove("black");
            Console.WriteLine("Colors_b length:"+colors_b.Count);
            colors_b.Insert(0,"Orange");
            Console.WriteLine("Colors_b[0]:"+colors_b[0]);
            colors_b.RemoveAll(c=>c.Contains("d"));
            Console.WriteLine("Colors_b[1]:"+colors_b[1]);
            colors_b.RemoveAt(0);
            Console.WriteLine("Colors_b[0]:"+colors_b[0]);
            Console.WriteLine("Colors_b size:"+colors_b.Count);

            colors_b.Clear();
            Console.WriteLine("Colors_b size:"+colors_b.Count);

            /*Foreach */
            var colors_c = new List<string>(){"White", "Green", "Blue", "Black"};
            colors_c.ForEach(Console.WriteLine);
            Console.WriteLine($"colors_c length in array {colors_c.ToArray().Length}");
        }
    }
}
