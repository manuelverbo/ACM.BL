using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Entity to represent -> Customer 
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Istanzia un oggetto customer vuoto
        /// </summary>
        public Customer()
        {

        }
        /// <summary>
        /// Istanzia un oggetto customer con ID identificativo
        /// </summary>
        /// <param name="customerId"></param>
        public Customer(int customerId)
        {
            this.CustomerID = customerId;
        }
        public int CustomerID { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int InstanceCount { get; set; }
        /// <summary>
        /// Nome completo dell'entity Customer. Imposto la proprietà in sola lettura. 
        /// </summary>
        public string FullName { get; }
        /// <summary>
        /// Validate customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;

        }
    }
}
