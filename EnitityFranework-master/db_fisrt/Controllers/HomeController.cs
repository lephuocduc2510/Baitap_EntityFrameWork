using db_fisrt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace db_fisrt.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentsContext db;
        public HomeController(StudentsContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            try
            {
                var listStudents = db.Students.Where(p => p.Age >= 18 && p.Age <= 20 && p.Class.Faculty.FacultyName == "Cong Nghe So").OrderBy(p => p.Id).ToList();
                ViewBag.listStudents = listStudents;
                return View();
            }
            catch (Exception x)
            {
                return Content(x.Message);
            }
        }
        }
}
