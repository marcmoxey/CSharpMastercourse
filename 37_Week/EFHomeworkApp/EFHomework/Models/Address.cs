using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework.Models
{
   public  class Address
    {
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string StreetAddress { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        public string State { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string ZipCode { get; set; }

    }
}
