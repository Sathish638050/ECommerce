using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.KaniniModel
{
    public partial class UserPayment
    {
        public int PayId { get; set; }
        public int UserId { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public int? OrderId { get; set; }

        public virtual OrderDetail Order { get; set; }
        public virtual UserAccount User { get; set; }
    }
}
