using DataAccess1.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace WebAppUI.Controllers
{
    public class HomeController : Controller
    {
        //depends injection 
        //prosesin adi invergn of control
        public AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.SlideItems);//ienumerable tipinden slide item gelir(select edirikse bu ienumerebldi,query yaziriqsa bu iquerybledi)
        }
        //public IActionResult Test()
        //{
        //    return View();
        //}
       
    }
}
