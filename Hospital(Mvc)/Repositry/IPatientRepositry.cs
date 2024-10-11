using Hospital_Mvc_.Models;

namespace Hospital_Mvc_.Repositry
{
    public interface IPatientRepositry
    {
        public List<Patient> GetAllPatient();

        public void Create(Patient patient);

        public void Delete(int id);
    }
}
