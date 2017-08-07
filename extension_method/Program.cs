using System;

namespace extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension method!");
            int result = 5.MultiFive();
            Console.WriteLine(result);
        }
    }

    public static class ExtensionMethod{
        public static int MultiFive(this int input){
            return input * 5;
        }
    }
}
