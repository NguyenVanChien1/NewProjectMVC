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
        public string Name { set; get; }
        public string Content { set; get; }
        public string MeteKeyword { set; get; }
        public string MetaDescription { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}
