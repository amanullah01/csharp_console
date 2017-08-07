using System;

namespace classes_object_basic
{
    class Program
    {
        int versionNumber = 123;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Class and object!");

            //Console.WriteLine($"Version number is: {versionNumber}");
            var myProgram = new Program();
            Console.WriteLine(myProgram);

            Console.WriteLine($"Version number is: {myProgram.versionNumber}");
            Console.WriteLine(myProgram.ToString());
        }
    }
}
