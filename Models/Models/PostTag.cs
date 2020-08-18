using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { set; get; }
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
        [Key]
        public string TagID { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}
