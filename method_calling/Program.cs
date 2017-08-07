using System;

namespace method_calling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method calling....");
            Display();

            Console.WriteLine($"Default: {CreateWelcome()}");
            string with_name = CreateWelcome("Amanullah");
            Console.WriteLine($"With name: {with_name}");
        }

        static string CreateGreetings(string name ="You"){
            return $"Hi {name}";
        }
        static void Display(){
            Console.WriteLine(CreateGreetings("Aman"));
        }

        static string CreateWelcome(string name1="Khan"){
            return $"Hi {name1}";
        } 

    }
}
