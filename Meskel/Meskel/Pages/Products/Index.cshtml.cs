using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Meskel.Data;
using Meskel.Models;

namespace Meskel.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Meskel.Data.MeskelContext _context;

        public IndexModel(Meskel.Data.MeskelContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
       
        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./Product/Details?id=3");
        }
  
    }
}
