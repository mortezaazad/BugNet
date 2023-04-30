using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Current year is:" + DateTime.Now.Year.ToString();
        }
    }
}
