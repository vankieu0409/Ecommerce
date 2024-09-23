using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products
{
    public class Products : EntityAuditBase<long>
    {
        public int IdCategory { get; set; }
        public string Name { get; set; } // Tên của giày
        public string Description { get; set; } // Mô tả của giày
        public string Brand { get; set; } // Thương hiệu của giày
        public string Model { get; set; } // Mẫu mã của giày
        public string Material { get; set; } // Chất liệu của giày
        public string Gender { get; set; } // Giới tính (Nam, Nữ, Unisex)
        public string Style { get; set; } // Phong cách (Thể thao, Thời trang, v.v.)
        public string SoleType { get; set; } // Loại đế giày (Chunky, Flat, v.v.)
        public string ReleaseDate { get; set; } // Ngày phát hành của giày
        public List<string>? Images { get; set; }

        public virtual Collection<Variants> Variants { get; set; } // Danh sách các biến thể của giày
    }
}
