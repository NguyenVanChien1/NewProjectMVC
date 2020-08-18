﻿using Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("ProductCategories")]
    public class ProductCategory:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//cách để nó tự tăng
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Required]
        [MaxLength(100)]
        public string Alias { set; get; }
        [Required]
        [MaxLength(250)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int?DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool?HomeFlag { set; get; }
        public virtual IEnumerable<Product> Products { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
