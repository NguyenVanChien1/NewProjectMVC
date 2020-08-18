using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//cách để nó tự tăng
        public int ID { set; get; }

        [Required]
        [MaxLength(100)]
        public string Name { set; get; }
        [Required]
        [MaxLength(100)]
        public string Content { set; get; }
        [Required]
        [MaxLength(100)]
        public string MeteKeyword { set; get; }
        [Required]
        [MaxLength(100)]
        public string MetaDescription { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}
