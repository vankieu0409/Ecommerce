using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products
{
    public class Products : EntityAuditBase<Guid>
    {
        public Guid IdCategory { get; set; }
        public string Name { get; set; } // Tên của giày

        public string? Description { get; set; } // Mô tả của giày
        public Guid IdBrand { get; set; } // Thương hiệu của giày
        public Guid IdModel { get; set; } // Mẫu mã của giày
        public Guid IdMaterial { get; set; } // Chất liệu của giày
        public Guid IdGender { get; set; } // Giới tính (Nam, Nữ, Unisex)
        public Guid IdStyle { get; set; } // Phong cách (Thể thao, Thời trang, v.v.)
        public Guid IdSoleType { get; set; } // Loại đế giày (Chunky, Flat, v.v.)
        public DateTime ReleaseDate { get; set; } // Ngày phát hành của giày
        public decimal Price { get; set; }


        //Navigation
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ModelTypes ModelType { get; set; }
        public virtual Styles Style { get; set; }
        public virtual Materials Material { get; set; }
        public virtual SoleTypes SoleType { get; set; }

        public virtual Collection<Variants> Variants { get; set; } // Danh sách các biến thể của giày
    }
}
