namespace ModelEF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }
        //[Display(Name = "ID")]

        [StringLength(250)]
        public string Name { get; set; }
        //[Display(Name = "Tên Sản phẩm")]
        public decimal? UnitCost { get; set; }
        //[Display(Name = "Đơn giá")]
        public int? Quantity { get; set; }
        //[Display(Name = "Số Lượng")]
        [StringLength(250)]
        public string Image { get; set; }
        //[Display(Name = "Ảnh")]
        [StringLength(255)]
        public string Description { get; set; }
        //[Display(Name = "Mô Tả")]
        public int? Status { get; set; }
        //[Display(Name = "Thao Tác")]
        public long? ProductType { get; set; }
        //[Display(Name = "LoaiSP_ID")]
        public virtual Category Category { get; set; }
    }
}
