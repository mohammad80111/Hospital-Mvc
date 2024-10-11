using Hospital_Mvc_.Models;

namespace Hospital_Mvc_.Repositry
{
    public interface IDoctorRepositry
    {
        public List<Doctor> GetAllDoctor();

        public void Create(Doctor doctor);

        public void Delete(int id);
    }
}
