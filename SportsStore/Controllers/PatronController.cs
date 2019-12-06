using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class PatronController:Controller
    {
        private readonly AppLoyaltyDbContext _context;
        public PatronController(AppLoyaltyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(
            [Bind("Id, FirstName, LastName,Telephone,CardId")] Patron patron)
        {
            if(ModelState.IsValid)
            {
                _context.Add(patron);
                await _context.SaveChangesAsync();
                return RedirectToRoute(new
                {
                    Controller="Product",
                    Action="List"
                });
            }
            return View(patron);
        }
    }
}
