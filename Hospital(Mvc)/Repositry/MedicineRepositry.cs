using Hospital_Mvc_.Controllers;
using Hospital_Mvc_.Models;

namespace Hospital_Mvc_.Repositry
{
    public class MedicineRepositry : IMedicineRepositry
    {
        private readonly ApplicationDbContext _context;

        public MedicineRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;
            
        }
        public void Create(Medicine mediicine)
        {
           _context.Medicines.Add(mediicine);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Medicine M1=(from med in _context.Medicines
                         where med.MedicineId == id 
                         select med).FirstOrDefault();
            _context.Medicines.Remove(M1);
            _context.SaveChanges();
        }

        public List<Medicine> GetAllMedicine()
        {
            List<Medicine> lista=(from  med in _context.Medicines
                                  select med).ToList();
            return lista;
        }
    }
}
