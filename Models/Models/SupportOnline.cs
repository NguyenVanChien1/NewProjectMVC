using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//cách để nó tự tăng
        public int ID { set; get; }
        [Required]
        [MaxLength(250)]
        public string Name { set; get; }
        [Required]
        [MaxLength(250)]
        public string Department { set; get; }
        [Required]
        [MaxLength(100)]
        public string Skype { set; get; }
        [Required]
        [MaxLength(50)]
        public string Phone { set; get; }
        [Required]
        [MaxLength(100)]
        public string Email { set; get; }
        [Required]
        [MaxLength(100)]
        public string Facebook { set; get; }
        public bool Status { set; get; }

    }
}
