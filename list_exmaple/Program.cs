using System;
using System.Collections.Generic;

namespace list_exmaple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add and remove item from your bag! Please read the instruction very carefully.\n1. + for add item\n2. - for remove item\n3. 'x' for clear and out from the shop");

            List<string> my_cart = new List<string>(){};
            string userInput = "0";
            while(userInput.ToLower() != "x"){
                Console.WriteLine("Please enter your item:");
                userInput = Console.ReadLine();
                if(userInput.Split(" ")[0]=="+"){
                    my_cart.Insert(0,userInput.Replace("+"," "));
                    Console.WriteLine("Current Items:");
                    my_cart.ForEach(Console.WriteLine);
                }else if(userInput.Split(" ")[0]=="-"){
                    Console.WriteLine("Item Removed");
                    my_cart.RemoveAll(c => c.Contains(userInput.Replace("-"," ")));
                    my_cart.ForEach(Console.WriteLine);
                }else{
                    Console.WriteLine("Bill Paid for total "+ my_cart.Count +" items");
                    my_cart.ForEach(Console.WriteLine);
                }
            }
            Console.WriteLine("Thank you for shopping with us.");
        }
    }
}
