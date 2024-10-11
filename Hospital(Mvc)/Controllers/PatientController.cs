using Hospital_Mvc_.Models;
using Hospital_Mvc_.Repositry;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Mvc_.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepositry _patientRepositry;
        private readonly IMedicineRepositry _medicineRepositry; 
        private readonly IDoctorRepositry _odctorRepositry; 
        public PatientController(IPatientRepositry patientRepositry, IMedicineRepositry medicineRepositry, IDoctorRepositry odctorRepositry)
        {
            _patientRepositry = patientRepositry;
            _medicineRepositry = medicineRepositry;
            _odctorRepositry = odctorRepositry;
        }
        //list all Patient
        [HttpGet]
        public ActionResult Index()
        {
            List<Patient> listo = _patientRepositry.GetAllPatient();
            return View(listo);
        }


        [HttpGet]
        public ActionResult Create()
        {
            DoctorMediciVM doctorMediciVM = new DoctorMediciVM();
            doctorMediciVM.DoctorsVM = _odctorRepositry.GetAllDoctor();
            doctorMediciVM.medicinesVM=_medicineRepositry.GetAllMedicine();

            return View(doctorMediciVM);
        }

        [HttpPost]
     
        public ActionResult Create(Patient patient)
        {
            _patientRepositry.Create(patient);
            List<Patient> listo = _patientRepositry.GetAllPatient();
            return View("Index", listo);
        }


        public ViewResult Delete(int id)
        {
            _patientRepositry.Delete(id);
            List<Patient> listo = _patientRepositry.GetAllPatient();
            return View("Index",listo);
        }

    }
}
