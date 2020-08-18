using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//cách để nó tự tăng
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string URl { set; get; }
        public int? DisplayOrder { set; get; }

        [Required]
        public int GroupID { set; get; }
        [ForeignKey("GroupID")]//đặt tên khóa ngoại chỉ đến
        public virtual MenuGroup MenuGroup { set; get; }//cách trỏ đến khóa ngoại
        public string Target { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}
