using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string df = CreateGreating();
            Console.WriteLine($"Default: {df}");

            string para = CreateGreating("Amanullah Aman");
            Console.WriteLine($"Default: {para}");
        }

        static string CreateGreating(){
            return CreateGreating("You");
        }

        static string CreateGreating(string name){
            return $"Hello {name}";
        }
    }
}
