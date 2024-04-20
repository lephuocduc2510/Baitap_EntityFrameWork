using BAITAP_EF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;  
namespace BAITAP_EF.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext db;
        public HomeController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            try
            {
                var listStudents = db.Students.Where(p=>p.Age >=18 && p.Age <=20 && p.Class.Faculty.FacultyName== "Cong Nghe So").OrderBy(p => p.Id).ToList();
                ViewBag.listStudents = listStudents;
                return View();
            }
            catch(Exception x)
            {
                return Content(x.Message);
            }
        }
    }
}
