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
        public string CustomerName { set; get; }

        [Required]
        public string CustomerAddress { set; get; }

        [Required]
        public string CustomerEmail { set; get; }

        [Required]
        public string CustomerPhone { set; get; }

        [Required]
        public string CustomerMessage { set; get; }

        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentMothod { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
