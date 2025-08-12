using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesHomework.Pages
{

    public class PersonEntryModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string LastName { get; set; }

        public List<string> People { get; set; } = new List<string>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string fullName = $"Hi {FirstName} {LastName}";
            People.Add(fullName);
            return Page();
        }
    }
}
