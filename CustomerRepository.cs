using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// In base all'ID del customer restituisco un oggetto completo delle sue proprietà popolate
        /// </summary>
        /// <param name="customerId">Id del Customer</param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        /// <summary>
        /// Salva in memoria il Customer 
        /// </summary>
        /// <param name="customer">oggetto da salvare si potrebbe anche valutare la Cache</param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {

            return true;
        }
    }
}
