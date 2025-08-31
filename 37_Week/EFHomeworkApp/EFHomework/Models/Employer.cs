using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework.Models
{
    public class Employer
    {
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string EmployerName { get; set; }
    }
}
