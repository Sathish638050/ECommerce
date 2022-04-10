using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.KaniniModel
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            UserPayments = new HashSet<UserPayment>();
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<UserPayment> UserPayments { get; set; }
    }
}
