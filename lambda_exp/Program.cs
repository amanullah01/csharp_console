using System;

namespace lambda_exp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lambda expression!");

            const int four = 4;
            Func<int,int> addOne = x => x + 1 ;
            Func<int,int,int> calc = (x,y) => x * y ;
            Func<int> twentyFive = () => calc(addOne(four), addOne(four));
            Console.WriteLine(twentyFive());
        }
    }
}
