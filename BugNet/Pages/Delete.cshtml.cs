using BugNet.Data;
using BugNet.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly BugDbContext _db;
        [BindProperty]
        public Bug? SelectedBug { get; set; }
        public DeleteModel(BugDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            SelectedBug = _db.Bugs.Find(id);
        }

        public IActionResult OnPost(int id)
        {
            var bug = _db.Bugs.Find(SelectedBug.Id);
            _db.Bugs.Remove(bug);
            _db.SaveChanges();

            return RedirectToPage("./index");
        }
    }
}
