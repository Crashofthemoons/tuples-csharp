using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>()
            {
                ("Hammer", 25, 1),
                ("Nails", 20, 3)
            };
                transactions.Add(("Bandaids", 10, 5));
                (string product, double amount, int quantity) shovel = ("Shovel", 20, 1);
                (string product, double amount, int quantity) staples = ("Staples", 17, 20);

                transactions.Add(shovel);
                transactions.Add(staples);


                int TotalProductsSold = 0;
                double TotalRevenue = 0;
                foreach ((string product, double amount, int quantity) item in transactions)
                {
                    TotalProductsSold += item.quantity;
                    TotalRevenue += item.quantity * item.amount;
                }
                Console.WriteLine($"We sold {TotalProductsSold} products for a total revenue of ${TotalRevenue}");
        }
    }
}
