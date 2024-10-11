using Hospital_Mvc_.Models;
using Hospital_Mvc_.Repositry;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Mvc_.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IMedicineRepositry _medicineRepositry;

        public MedicineController(IMedicineRepositry medicineRepositry)
        {
            _medicineRepositry = medicineRepositry; 
            
        }
        //list all Medicine
        [HttpGet]
        public ActionResult Index()
        {
            List<Medicine> lista = _medicineRepositry.GetAllMedicine();
            return View(lista);
        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Medicine medicine)
        {
            _medicineRepositry.Create(medicine);
            List<Medicine> lista = _medicineRepositry.GetAllMedicine();
            return View("Index",lista);
        }

        public ViewResult Delete(int id)
        {
            _medicineRepositry.Delete(id);
            List<Medicine> lista = _medicineRepositry.GetAllMedicine();
            return View("Index", lista);
        }
    }
}
