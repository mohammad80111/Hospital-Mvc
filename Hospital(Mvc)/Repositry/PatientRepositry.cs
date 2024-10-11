using Hospital_Mvc_.Controllers;
using Hospital_Mvc_.Models;

namespace Hospital_Mvc_.Repositry
{
    public class PatientRepositry : IPatientRepositry
    {
        private readonly ApplicationDbContext _context;
        public PatientRepositry(ApplicationDbContext applicationDb)
        {
            
            _context = applicationDb;
        }
        public void Create(Patient patient)
        {
          _context.Patients.Add(patient);   
            _context.SaveChanges(); 
        }

        public void Delete(int id)
        {
            Patient p1 = (from pat in _context.Patients
                          where pat.PatientId == id 
                          select pat).FirstOrDefault();

            _context.Patients.Remove(p1);
            _context.SaveChanges(); 
        }

        public List<Patient> GetAllPatient()
        {
            List<Patient> lita=(from pat in _context.Patients
                                select pat).ToList();   
            return lita;
        }
    }
}
