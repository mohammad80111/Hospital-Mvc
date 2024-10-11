using Hospital_Mvc_.Models;
using Hospital_Mvc_.Repositry;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Mvc_.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepositry _doctorRepositry;

        public DoctorController(IDoctorRepositry doctorRepositry)
        {
            _doctorRepositry = doctorRepositry; 
            
        }
        //list all doctors
        [HttpGet]
        public ActionResult Index()
        {
            List<Doctor> lista = _doctorRepositry.GetAllDoctor();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

       
        public ActionResult Create(Doctor doctor)
        {
            _doctorRepositry.Create(doctor);
            List<Doctor> lista = _doctorRepositry.GetAllDoctor();
            return View("Index", lista);
        }

        public ViewResult Delete(int id)
        {
            _doctorRepositry.Delete(id);
            List<Doctor> lista = _doctorRepositry.GetAllDoctor();
            return View("Index",lista);
        }
    }
}
