using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleUI.Models
{
    public class Email
    {
        public int Id { get; set; }
        [Required]
        public int ContactId { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")] // not code to swap out for differnt database type
        public string EmailAddress { get; set; }
    }
}
