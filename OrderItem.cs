using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int OrderItemId { get; private set; }

        public bool Validate()
        {
            bool isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
        public void Retrieve()
        {

        }
        public bool Save()
        {
            return true;
        }
    }
}
