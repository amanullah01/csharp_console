using System;

namespace loop_k
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While loop");

            int[] abc = new int[]{1,2,3,4,5};

            int i = 0;
            while (i < abc.Length)
            {
                Console.Write(" {0}",abc[i]);
                i++;
            }

            Console.WriteLine("\n\aFor loop");

            for(int j =0; j<abc.Length; j++){
                Console.Write(" "+abc[j]);
            }

            Console.WriteLine("\n\aForeach loop");

            foreach (int k in abc)
            {
                Console.Write(" "+k);
            }
        }
    }
}
