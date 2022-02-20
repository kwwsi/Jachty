using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Jachty.Data;
using Jachty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Jachty.Pages
{
    public class OrderModel : PageModel
    {
        private JachtyContext db;
        public OrderModel(JachtyContext db) => this.db = db;
        [BindProperty(SupportsGet =true)]
        public int Id  { get; set; }
        public Jacht Jacht { get; set; }
        [BindProperty,Required, Display(Name = "Imie")]
        public string Imie { get; set; }
        [BindProperty, EmailAddress, Required, Display(Name = "Email")]
        public string OrderEmail { get; set; }
        [BindProperty, Required, Display(Name = "Numer Telefonu")]
        public string Telefon { get; set; }
        [BindProperty, Required, DataType(DataType.Date)]
        public DateTime CzasStart { get; set; }
        [BindProperty, Required, DataType(DataType.Date)]
        public DateTime CzasKoniec { get; set; }
        public async Task OnGetAsync() => Jacht = await db.Jachts.FindAsync(Id);

        public async Task<IActionResult> OnPostAsync()
        {
            Jacht = await db.Jachts.FindAsync(Id);
            if (ModelState.IsValid)
            {
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }

   
}
