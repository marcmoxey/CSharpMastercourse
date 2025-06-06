using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMessageWall.Pages
{
    public class MessageWallModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();
        public void OnGet()
        {
            // read from a database
        }

        public IActionResult OnPost()
        {
            // post to database
            Messages.Add(Message);
            return Page();
        }
    }
}
