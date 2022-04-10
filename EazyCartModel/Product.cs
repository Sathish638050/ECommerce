﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.EazyCartModel
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
