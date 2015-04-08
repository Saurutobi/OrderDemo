using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class firstPart
    {
        static void Main(string[] args)
        {
            Order first = new Order(1, "first", 5);
            Order second = new Order(1, "second", 5);
            Order third = new Order(3, "third", 5);
            Order fourth = new Order(4, "fourth", 5);
            Order fifth = new Order(5, "fifth", 5);
            Order sixth = new Order(6, "sixth", 5);
            Order seventh = new Order(7, "seventh", 5);
            Order eigth = new Order(8, "eigth", 5);
            Order nineth = new Order(9, "nine", 5);
            Order tenth = new Order(10, "tenth", 5);

            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());
            Console.WriteLine(third.ToString());
            Console.WriteLine(fourth.ToString());
            Console.WriteLine(fifth.ToString());
            Console.WriteLine(sixth.ToString());
            Console.WriteLine(seventh.ToString());
            Console.WriteLine(eigth.ToString());
            Console.WriteLine(nineth.ToString());
            Console.WriteLine(tenth.ToString());

            CompareOrders(first, second);
            CompareOrders(third, fourth);
            CompareOrders(fifth, sixth);
            CompareOrders(seventh, eigth);
            CompareOrders(nineth, tenth);

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