using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//cách để nó tự tăng
        public int ID { set; get; }
        [Required]
        [MaxLength(100)]
        public string Code { set; get; }
        [Required]
        [MaxLength(100)]
        public string ValuesString { set; get; }
        public int ValuenInt { set; get; }
    }
}
