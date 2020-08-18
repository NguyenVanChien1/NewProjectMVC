using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("OderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
        [Key]
        public int ProductID { set; get; }
        public int Quantity { set; get; }

        [ForeignKey("ProductID")]
        public virtual ProductCategory ProductCategory { set; get; }
       
    }
}
