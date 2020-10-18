using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasFood.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key, Column(Order = 0)]
        public int OrderID { get; set; }
        [Key, Column(Order = 1)]
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public virtual Order Orders { get; set; }
        public virtual Product Products { get; set; }
    }
}
