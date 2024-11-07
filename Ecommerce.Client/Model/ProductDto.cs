namespace Ecommerce.Client.Model;

public class ProductDto
{

    public Guid Id { get; set; }
    public string Name { get; set; }

    public Guid IdBrand { get; set; } // Thương hiệu của giày
    public string? Brand { get; set; }

    public string? Category { get; set; }
    public Guid IdCategory { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string SKU { get; set; }

    public bool IsAvailable { get; set; }

    public Guid IdGender { get; set; } // Giới tính (Nam, Nữ, Unisex)
    public string? Gender { get; set; } // e.g., "Men", "Women", "Unisex"

    public Guid IdMaterial { get; set; } // Chất liệu của giày
    public string? Material { get; set; }

    public Guid IdStyle { get; set; } // Phong cách (Thể thao, Thời trang, v.v.)
    public string? Style { get; set; } // e.g., "Sneakers", "Boots", "Sandals"

    public Guid IdModel { get; set; } // Mẫu mã của giày
    public string? ModelType { get; set; } // e.g., "Casual", "Formal", "Sports"

    public decimal? Weight { get; set; } // in grams

    //public string Season { get; set; } // e.g., "Summer", "Winter", "All-season"

    public Guid IdSoleType { get; set; } // Loại đế giày (Chunky, Flat, v.v.)
    public string? SoleType { get; set; } // e.g., "Waterproof", 
}