using Hospital_Mvc_.Models;

namespace Hospital_Mvc_.Repositry
{
    public interface IMedicineRepositry
    {
        public List<Medicine> GetAllMedicine();

        public void Create(Medicine mediicine);

        public void Delete(int id);
           
        


        }

    }

