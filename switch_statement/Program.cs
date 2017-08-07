using System;

namespace switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("******Welcome to our coffee shop*******");
            Console.WriteLine("***************************************");

            int price = 0;
            Start:
            Console.WriteLine("1 - for small\n2 - for medium\n3 - for large");
            
            int Choice = int.Parse(Console.ReadLine());
            

            switch (Choice)
            {
                case 1:
                    price +=1;
                    break;
                case 2:
                    price +=2;
                    break;
                case 3:
                    price +=3;
                    break;
                
                default:
                    Console.WriteLine("Your choice {0} is invalid.",Choice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to buy another coffe - yes or no");
            string decision = Console.ReadLine();

            switch(decision.ToLower()){
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Your choice is invalid.");
                    goto Decide;
            }


            Console.WriteLine("Thank you for shopping with us. Total bill is: {0}",price);
        }
    }
}
