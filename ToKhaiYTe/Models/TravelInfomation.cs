using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    public class TravelInfomation
    {
        [ForeignKey("MedicalDeclarationForm")]
        public int Id { get; set; }
        
        public bool AirPlane { get; set; }
        public bool Ships { get; set; }
        public bool Car { get; set; }
        public string AnotherVerhicle { get; set; }

        public string TransportStationNumber { get; set; }
        public string SeatNumber { get; set; }
        [Required]
        public string DepartureDate { get; set; }
        [Required]
        public string EntryDate { get; set; }
        [Required]
        public string DepartureCountry { get; set; }
        [Required]
        public string DepartureProvince { get; set; }
        [Required]
        public string DestinyLocationCountry { get; set; }
        [Required]
        public string DestinyLocationProvince { get; set; }

        public MedicalDeclarationForm MedicalDeclarationForm { get; set; }
        public int MedicalDeclarationFormId { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    }
}
