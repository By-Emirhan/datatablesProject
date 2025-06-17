using Microsoft.AspNetCore.Mvc;

namespace datatablesProject.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext DB;

        public CompanyController (ApplicationDbContext _DB)
        {
            DB = _DB;
        }

        public IActionResult Index()
        {
            var carihesaplar = DB.CariHesaplar.ToList();
            return View(carihesaplar);
        }
    }
}
