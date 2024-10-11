using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Mvc_.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        public string DoctorName { get; set; }

        [Range(22, 50)]
        public int DoctorAge { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        public string Address { get; set; }

        public bool IsActive { get; set; }

    }
}
