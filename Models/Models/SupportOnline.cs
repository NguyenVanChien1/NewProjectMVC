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
        public string Name { set; get; }
        public string Department { set; get; }
        public string Skype { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Facebook { set; get; }
        public bool Status { set; get; }

    }
}
