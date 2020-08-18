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
    [Table("Posts")]
    public class Post:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//cách để nó tự tăng
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }

        [Required]
        [MaxLength(100)]
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PostCategorie PostCategorie { set; get; }
        [Required]
        [MaxLength(100)]
        public string Description { set; get; }
        [Required]
        [MaxLength(100)]
        public string Content { set; get; }
        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public int ViewCount { set; get; }
        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}
