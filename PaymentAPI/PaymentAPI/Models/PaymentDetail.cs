using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(100)")]
        public string CardOrderName { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(16)")]
        public string CardNumber { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(5)")]
        public string ExpirationDate { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(3)")]
        public string SecurityCode { get; set; }
    }
}
