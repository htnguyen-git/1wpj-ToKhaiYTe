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
        [Display(Name ="Tên đầy đủ")]
        public string Fullname { get; set; }
        [Required]
        [Range(1890,2020)]
        [Display(Name ="Năm sinh")]
        public int DoB { get; set; }
        [Required]
        [Display(Name = "Giới tính")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Quốc tịch")]
        public string National { get; set; }
        [Required]
        [Display(Name = "CMND/ Giấy căn cước công dân")]
        public string CMND { get; set; }
        [Required]
        [Display(Name = "Danh sách các thành phố đã đi qua")]
        public string ListCountryhasGoneThrough { get; set; }
        [Required]
        [Display(Name = "Thành phố hiện sống")]
        public string CurrentAddressProvince { get; set; }
        [Required]
        [Display(Name = "Quận huyện hiện sống")]
        public string CurrentAddressDistrict { get; set; }
        [Display(Name = "Phường xã hiện sống")]
        [Required]
        public string CurrentAddressWard { get; set; }
        [Display(Name = "Địa chỉ hiện tại")]
        [Required]
        public string CurrentAddressStreet { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        [Display(Name = "Danh sách vắc - xin đã sử dụng")]
        public string UsedVaccineList { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

    }
}
