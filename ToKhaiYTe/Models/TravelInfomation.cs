using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    public class TravelInfomation
    {
        [Display(Name = "Tàu bay")]
        public bool AirPlane { get; set; }
        [Display(Name = "Tàu thuyền")]
        public bool Ships { get; set; }
        [Display(Name = "Ô tô")]
        public bool Car { get; set; }
        [Display(Name = "Phương tiện di chuyển khác")]
        public string AnotherVerhicle { get; set; }
        [Display(Name = "Số hiệu phương tiện")]
        public string TransportStationNumber { get; set; }

        [Display(Name ="Số ghế")]
        public string SeatNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày khởi hành")]
        public string DepartureDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày nhập cảnh")]
        public string EntryDate { get; set; }
        [Required]
        [Display(Name = "Quốc gia khởi hành")]
        public string DepartureCountry { get; set; }
        [Required]
        [Display(Name = "Thành phố khởi hành")]
        public string DepartureProvince { get; set; }
        [Required]
        [Display(Name = "Quốc gia đến")]
        public string DestinyLocationCountry { get; set; }
        [Required]
        [Display(Name = "Thành phố đến")]
        public string DestinyLocationProvince { get; set; }

        public MedicalDeclarationForm MedicalDeclarationForm { get; set; }

        [ForeignKey("MedicalDeclarationForm")]
        [Key]
        public int MedicalDeclarationFormId { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    }
}
