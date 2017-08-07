using System;

namespace y_datatype_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicite and Explecite conversion");

            int i = 1040;
            float f = i;
            Console.WriteLine($"Implecite Conversion done: {f}");

            float f1 = 467574.05F;
            //int i1 = (int)f1;
            int i1 = Convert.ToInt32(f1);
            Console.WriteLine($"Explecite Conversion done: {i1}");
        }
    }
}
