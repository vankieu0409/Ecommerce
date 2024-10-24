namespace Ecommerce.Client.Model;

public class ProductDto
{

    public Guid Id { get; set; }
    public string Name { get; set; }

    public string Brand { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string SKU { get; set; }

    public bool IsAvailable { get; set; }

    public string Gender { get; set; } // e.g., "Men", "Women", "Unisex"

    public string Material { get; set; }

    public string Style { get; set; } // e.g., "Sneakers", "Boots", "Sandals"

    public string ModelType { get; set; } // e.g., "Casual", "Formal", "Sports"

    public decimal? Weight { get; set; } // in grams

    public string Season { get; set; } // e.g., "Summer", "Winter", "All-season"

    public string SoleType { get; set; } // e.g., "Waterproof", 
}