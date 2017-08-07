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

            // Parse and TryParse

            string s ="100";
            int i2 = int.Parse(s);
            Console.WriteLine("Parse methode . String to int:"+i2);

            //TryParse Conversion
            Console.WriteLine("Try pass conversion");
            string strNumber = "9987";
            int result = 0;
            bool IsConversionIsTrue = int.TryParse(strNumber, out result);

            if(IsConversionIsTrue){
                Console.WriteLine("Result is : "+result);
            }else{
                Console.WriteLine("Please enter valid number");
            }
        }
    }
}
