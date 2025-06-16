using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMiniProject.Pages
{
    public class AddressEntryModel : PageModel
    {
        [BindProperty]
        public string StreetAddress { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string State { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        public List<string> Addresses { get; set; } = new List<string>();
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            string fullAddress = $"{StreetAddress}{City}, {State} {ZipCode}";
            Addresses.Add(fullAddress);
            return Page();
        }
    }
}
