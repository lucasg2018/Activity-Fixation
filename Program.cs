using System;
using System.Collections.Generic;
using Activity_Fixation.Entities;
using Activity_Fixation.Entities.Enums;

namespace Activity_Fixation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: \n");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            Console.WriteLine("\nBirth date (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, data);

            Console.WriteLine("Enter order data:");
            DateTime now = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(now, status, client);

            Product p = new Product();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("\nProduct price: ");
                double price = double.Parse(Console.ReadLine());
                Product pd = new Product(productName, price);

                Console.Write("\nQuantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, pd );
                order.AddItem(orderItem);

            }
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}
