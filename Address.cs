using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            this.AddressId = addressId;
        }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string Province{ get; set; }
        public string State { get; set; }
        public int PostalCode{ get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }
        public int AddressId { get; private set; }
        public bool Validate()
        {
            bool isValid = true;

            if(PostalCode == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
