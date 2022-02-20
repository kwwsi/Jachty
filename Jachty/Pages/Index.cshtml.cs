using Jachty.Data;
using Jachty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Jachty.Pages
{
    public class IndexModel : PageModel
    {
        private readonly JachtyContext db;
        public IndexModel(JachtyContext db) => this.db = db;
        public List<Jacht> Jachts { get; set; } = new List<Jacht>();
        public Jacht FeaturedProduct { get; set; }
        public async Task OnGetAsync()
        {
            Jachts = await db.Jachts.ToListAsync();
            FeaturedProduct = Jachts.ElementAt(new Random().Next(Jachts.Count));
        }
    }

}