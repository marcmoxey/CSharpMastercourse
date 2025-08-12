using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppMiniProject.Models
{
    public class AddressModel
    {
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 5)]
        public string ZipCode { get; set; }     
    }
}
