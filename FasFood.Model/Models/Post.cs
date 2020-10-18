using FasFood.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasFood.Model.Models
{
    [Table("Posts")]
    public class Post:Auditable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]      
        public string Description { get; set; }
        public string Content { get; set; }
        public int PostCategoryID { get; set; }
        [ForeignKey("PostCategoryID")]
        public virtual PosCategory PosCategories { get; set; }
    }
}
