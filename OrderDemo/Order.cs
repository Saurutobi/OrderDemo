using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Order
    {
        public int OrderNumber
        {
            get;
            set;
        }

        public string CustomerName
        {
            get;
            set;
        }

        public int QuantityOrdered
        {
            get;
            set;
        }

        public double Price
        {
            get
            {
                return 19.95;
            }
        }

        public Order(int orderNumber, string customerName, int quantityOrdered)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            QuantityOrdered = quantityOrdered;
        }

        public bool Equals(Order comparator)
        {
            if (OrderNumber == comparator.OrderNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return OrderNumber;
        }

        public override string ToString()
        {
            return OrderNumber + ", " + CustomerName + ", " + QuantityOrdered + ", " + Price;
        }
    }
}
