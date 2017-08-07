using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Array!");

            //Hold 3 elements in this array.
            int[] a = new int[3];
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);

            //Init the values of array
            int[] b = new int[]{1,2,3,4,5};
            Console.WriteLine(b[0]);
            Console.WriteLine(b[3]);

            //We can ommit int before array value set
            int[] c = new []{66,67,76,54};

            Console.WriteLine(c[0]);
            Console.WriteLine(c[3]);

            /*Multidimensional Array */
            int[,] eggCartoon = new int[2,6];
            Console.WriteLine(eggCartoon[0,0]);
            Console.WriteLine(eggCartoon[1,5]);

            /*Set values in multidimensiona array */
            int[,] table = {{1,2,3}, {4,5,6}};
            Console.WriteLine(table[0,0]);
            Console.WriteLine(table[1,2]);

            /*Jagged arrays */
            Console.WriteLine("Jagged Arrays:");

            int[][] jagged = new int[5][];
            jagged[0] = new int[3]{1,2,3};
            Console.WriteLine(jagged[0][0]);
            Console.WriteLine(jagged[0][2]);

            jagged[4] = new int[4]{1,2,3,4};
            Console.WriteLine(jagged[4][0]);
            Console.WriteLine(jagged[4][3]);

            /*Working with arrays */
            Console.WriteLine("Working with arrays");
            int[] someInt = {1,2,3};
            int x = 1 + someInt[0];
            int y = 2 * someInt[2];
            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");
            Console.WriteLine($"someInt[2]: {someInt[2]}");
            someInt[2] = y;
            Console.WriteLine($"Now someInt[2]: {someInt[2]}");

            //now it will thorw an exception
            // someInt[3] = 3;
            // Console.WriteLine($"someInt[3]: {someInt[3]}");
            Console.WriteLine($"Array length is: {someInt.Length}");

            /*String to Array convert */
            Console.WriteLine("String to Array conversion");
            string input = "Blue,Red,Yellow,Green";
            Console.WriteLine("Input string is: "+input);
            string[] colors = input.Split(','); //here , is separetor.
            Console.WriteLine("1st color is:"+colors[0]);
            Console.WriteLine("2nd color is:"+colors[1]);

            Console.WriteLine("Join colors array");
            string output = String.Join("|",colors);
            Console.WriteLine(output);
        }
    }
}
