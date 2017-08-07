using System;

namespace do_while_k
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("******Welcome do while loop************");
            Console.WriteLine("***************************************");

            string str = "";
            do{
                Console.WriteLine("Enter your choice.");
                int UserChoice = int.Parse(Console.ReadLine());

                int start = 0;

                while(start <= UserChoice){
                    Console.WriteLine(start);
                    start +=2;
                }
                

            
                do{
                    Console.WriteLine("Do you want to continue? Yes/No");
                    str = Console.ReadLine();
                    if(str.ToLower() != "yes" && str.ToLower() != "no"){
                        Console.WriteLine("Invalid choice. Please enter only Yes or No");
                    }
                }while(str.ToLower() != "yes" && str.ToLower() != "no");
            }while(str.ToLower() == "yes");
        }
    }
}
