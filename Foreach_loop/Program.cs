using System;
using System.Collections.Generic;

namespace Foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach looop");
            var my_list = new List<string>(){"Amanullah Aman", "Monnuzan Ahmed", "Armanul Hasan", "Mr. X", "Mrs. Y"};
            foreach (var item in my_list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
