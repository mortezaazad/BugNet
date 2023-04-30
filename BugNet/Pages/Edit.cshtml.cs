using BugNet.Data;
using BugNet.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages
{
    public class EditModel : PageModel
    {
        private readonly BugDbContext _db;
        [BindProperty]
        public Bug? SelectedBug { get; set; }
        public EditModel(BugDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            SelectedBug = _db.Bugs.Find(id); 
        }

        public IActionResult OnPost(int id)
        {
            var bug= _db.Bugs.Find(SelectedBug.Id);
            bug.Name= SelectedBug.Name;
            bug.Description= SelectedBug.Description;
            bug.IsDone= SelectedBug.IsDone;
            _db.SaveChanges();

            return RedirectToPage("./index");
        }
    }
}
