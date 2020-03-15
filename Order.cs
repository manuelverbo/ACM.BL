using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderID = orderId;
        }
        public int OrderID { get; private set; }
        DateTimeOffset? OrderDate { get; set; }
        public bool Validate()
        {
            bool isValid = false;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
        /// <summary>
        /// retrieve an order
        /// </summary>
        /// <param name="orderId"></param>
        public Order Retrieve(int orderId)
        {

            return new Order();
        }

        public bool Save()
        {
            return true;
        }
    }
}
