using BugNet.Data;
using BugNet.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages
{
    
    public class IndexModel : PageModel
    {
        private readonly BugDbContext _db;
        public IndexModel(BugDbContext db)
        {
            _db = db;
        }
        public IList<Bug> BugList { get; set; }
        public void OnGet()
        {
            BugList= _db.Bugs.ToList();
        }
    }
}
