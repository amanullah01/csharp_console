using System;
using System.Collections.Generic;

namespace For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop with list");

            var my_list = new List<int>(){10,20,30,40};
            for(int i = 0; i < my_list.Count ; i++){
                Console.WriteLine(my_list[i]);
            }

            Console.WriteLine("For Loop with Array");

            int[] numbers = new int[]{33,44,55,66,77};
            int sum = 0;
            for(int j = 0; j < numbers.Length ; j++){
                Console.WriteLine(numbers[j]);
                sum += numbers[j];
            }
            Console.WriteLine($"Total sum: {sum}");
        }
    }
}
