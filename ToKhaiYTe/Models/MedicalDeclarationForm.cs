using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    public class MedicalDeclarationForm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Gate Gate { get; set; }
        [Required]
        public int GateId { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        [Range(1890,2020)]
        public int DoB { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string National { get; set; }
        [Required]
        public string CMND { get; set; }
        [Required]
        public string ListCountryhasGoneThrough { get; set; }
        [Required]
        public string CurrentAddressProvince { get; set; }
        [Required]
        public string CurrentAddressDistrict { get; set; }
        [Required]
        public string CurrentAddressWard { get; set; }
        [Required]
        public string CurrentAddressStreet { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string UsedVaccineList { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

    }
}
