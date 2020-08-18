using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(20)]
        public string CustomerPhone { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerMessage { set; get; }

        public DateTime CreatedDate { set; get; }
        [Required]
        [MaxLength(100)]
        public string CreatedBy { set; get; }
        [Required]
        [MaxLength(100)]
        public string PaymentMothod { set; get; }
        [Required]
        [MaxLength(100)]
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
