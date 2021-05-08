using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required()]
        [Column(TypeName = "NVARCHAR(50)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(10)")]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(100)")]
        public string Position { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
