using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.EazyCartModel
{
    public partial class UserAddress
    {
        public int UserAddressId { get; set; }
        public int? UserId { get; set; }
        public string Uaddress { get; set; }
        public string City { get; set; }
        public int? PostCode { get; set; }
        public string Country { get; set; }
        public int? Phone { get; set; }

        public virtual UserAccount User { get; set; }
    }
}
