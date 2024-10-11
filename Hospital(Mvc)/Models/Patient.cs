using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Mvc_.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        public string PatientName { get; set; }


        public int PatientAge { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        public string City { get; set; }


        //here DoctorId forignkey
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }


        //here Medicineid forignkey
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }

        [Range(1, 5)]
        public int HowManyTimsDay { get; set; }
    }
}
