using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework.Models
{
    public class Person
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Employer> Employers { get; set; } = new List<Employer>();
    }
}
