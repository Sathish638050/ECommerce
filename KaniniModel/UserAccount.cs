using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.KaniniModel
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            UserAddresses = new HashSet<UserAddress>();
            UserPayments = new HashSet<UserPayment>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserPayment> UserPayments { get; set; }
    }
}
