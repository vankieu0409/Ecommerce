namespace Ecommerce.Client.Model
{
    public class AddProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Category { get; set; }
        public string? Description { get; set; } // Mô tả của giày
        public Guid Brand { get; set; } // Thương hiệu của giày
        public Guid Model { get; set; } // Mẫu mã của giày
        public Guid Material { get; set; } // Chất liệu của giày
        public Guid Gender { get; set; } // Giới tính (Nam, Nữ, Unisex)
        public Guid Style { get; set; } // Phong cách (Thể thao, Thời trang, v.v.)
        public Guid SoleType { get; set; } // Loại đế giày (Chunky, Flat, v.v.)
        public DateTime ReleaseDate { get; set; } // Ngày phát hành của giày
        public string SKU { get; set; } // Mã SKU của giày
        public decimal Price { get; set; } // Giá của giày
    }
}
