using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCDataEntry.Models
{
    public class PersonModel
    {
        [Required]
        [Display(Name = "First Name" )]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Active User")]
        public bool IsActive { get; set; }
    }
}
