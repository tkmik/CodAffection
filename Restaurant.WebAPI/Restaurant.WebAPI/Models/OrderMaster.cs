using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WevAPI.Models
{
    public class OrderMaster
    {
        [Key]
        public long Id { get; set; }
        [Column(TypeName ="NVARCHAR(75)")]
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Column(TypeName = "NVARCHAR(75)")]
        public string PMethod { get; set; }
        public decimal GTotal { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
