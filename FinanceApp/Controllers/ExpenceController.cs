using FinanceApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ExpenceController : Controller
    {
        private readonly FinanceAppContext _context;
        public ExpenceController(FinanceAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
