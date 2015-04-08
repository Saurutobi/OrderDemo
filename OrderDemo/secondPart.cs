using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class secondPart
    {
        static void Mainasdf(string[] args)
        {
            List<Order> orders = new List<Order>();

            while(orders.Count != 5)
            {
                string input = "";
                bool exist = false;
                int orderNumber = 0;
                string customerName = "";
                int quantity = 0;

                Console.WriteLine("Please enter an ordernumber");
                input = Console.ReadLine();
                orderNumber = Int32.Parse(input);

                foreach(Order existing in orders)
                {
                    if (existing.OrderNumber == orderNumber)
                    {
                        exist = true;
                    };
                }

                if (!exist)
                {
                    Console.WriteLine("Please enter a Customer Name");
                    customerName = Console.ReadLine();
                    Console.WriteLine("Please enter a Quantity ordere");
                    quantity = Int32.Parse(Console.ReadLine());
                    Order newOrder = new Order(orderNumber, customerName, quantity);
                    orders.Add(newOrder);
                }
                else
                {
                    Console.WriteLine("You entered an existing Order Number. Please try again.");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            double quant = 0;
            foreach(Order order in orders)
            {
                Console.WriteLine(order.OrderNumber + ", " + order.CustomerName + ", " + order.QuantityOrdered + ", " + order.Price);
                quant += order.QuantityOrdered;
            }
            Console.WriteLine("Total orders: " + quant);

            Console.WriteLine();
            Console.WriteLine();

            Console.Read();
        }

        protected static void CompareOrders(Order first, Order second)
        {
            if (first.Equals(second))
            {
                Console.WriteLine("These guys are equal: " + first.CustomerName + " & " + second.CustomerName);
            }
        }
    }

}
