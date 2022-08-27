using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActrosController : Controller
    {
        private readonly AppDbContext _context;

        public ActrosController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
