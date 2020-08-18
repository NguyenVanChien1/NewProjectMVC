using Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("PostCategories")]
    public class PostCategorie:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//cách để nó tự tăng
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }
        public string Description { set; get; }
        public int ParentID { set; get; }
        public int DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool HomeFlag { set; get; }
        public virtual IEnumerable<Post> Posts { set; get; }
    }
}
