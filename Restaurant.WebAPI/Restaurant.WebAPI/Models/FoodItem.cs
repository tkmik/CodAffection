using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WevAPI.Models
{
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string ItemName { get; set; }
        public decimal Price { get; set; }
    }
}
