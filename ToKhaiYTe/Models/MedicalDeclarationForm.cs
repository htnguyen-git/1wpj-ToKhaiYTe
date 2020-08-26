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
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual TravelInfomation TravelInfomation { get; set; }
        public int TravelInfomationId { get; set; }

        public virtual PhatologicalSign PhatologicalSign { get; set; }
        public int PhatologicalSignId { get; set; }

        public string UsedVaccineList { get; set; }

        public HistoryOfExposure HistoryOfExposure { get; set; }
        public int HistoryOfExposureId { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

    }
}
