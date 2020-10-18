using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasFood.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        public string URL { get; set; }
        public int DisplayOrder { get; set; }
        public bool Status { get; set; }
        public int SlideGroupID { get; set; }
        [ForeignKey("SlideGroupID")]
        public virtual SlideGroup SlideGroups { get; set; }
    }
}
