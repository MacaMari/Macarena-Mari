using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimerParcialMacarena.Data;
using PrimerParcialMacarena.Models;
using System.Diagnostics;

namespace PrimerParcialMacarena.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var favoritos = await _context.Productos.Include(p => p.Categoria).Where(p => p.Favorito).ToListAsync();
            return View(favoritos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
