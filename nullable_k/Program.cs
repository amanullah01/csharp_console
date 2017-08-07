using System;

namespace nullable_k
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int? tikcetOnSale = 100;
            int availableTicket;

            if(tikcetOnSale == null){
                availableTicket = 0;
            }else{
                availableTicket = (int)tikcetOnSale;
                //availableTicket = tikcetOnSale.Value;
            }

            Console.WriteLine($"Available ticket = {availableTicket}");

            int? tikcetOnSale1 = 40;
            int availableTicket1 = tikcetOnSale1 ?? 0;
            Console.WriteLine($"Available ticket = {availableTicket1}");


        }
    }
}
