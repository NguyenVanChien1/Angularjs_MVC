using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasFood.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        public int DisplayOrder { get; set; }
        [Required]
        public string Target { get; set; }
        public bool Status { get; set; }
        [Required]
        public int MenuGroupID { get; set; }
        [ForeignKey("MenuGroupID")]
        public virtual MenuGroup MenuGroups { get; set; }
    }
}
