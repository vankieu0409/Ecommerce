﻿using Ecommerce.Domain.Entities.Author;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Cart
{
    public class CartItemEntity : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid VariantId { get; set; }
        public int Quantity { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public Variants Variant { get; set; }
    }
}