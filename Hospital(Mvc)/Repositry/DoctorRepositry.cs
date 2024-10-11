using Hospital_Mvc_.Controllers;
using Hospital_Mvc_.Models;

namespace Hospital_Mvc_.Repositry
{
    public class DoctorRepositry : IDoctorRepositry
    {
        private readonly ApplicationDbContext _context;
        public DoctorRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;
            
        }
        public void Create(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
           Doctor D1=(from dor in _context.Doctors
                      where dor.DoctorId==id
                      select dor).FirstOrDefault();
            _context.Doctors.Remove(D1);    
            _context.SaveChanges(); 
        }

        public List<Doctor> GetAllDoctor()
        {
            List<Doctor> lista=(from dor in _context.Doctors
                                select dor).ToList();
            return lista;
        }
    }
}
