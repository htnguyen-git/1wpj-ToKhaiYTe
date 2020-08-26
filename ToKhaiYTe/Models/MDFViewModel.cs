using System.ComponentModel.DataAnnotations;

namespace ToKhaiYTe.Models
{
    public class MDFViewModel
    {

        [Required]
        [Display(Name ="Cửa khẩu")]
        public int GateId { get; set; }
        [Required]
        [Display(Name ="Họ tên")]
        public string Fullname { get; set; }
        [Required]
        [Display(Name ="Năm sinh")]
        public int DoB { get; set; }
        [Required]
        [Display(Name ="Giới tính")]
        public string Gender { get; set; }
        [Required]
        [Display(Name ="Quốc tịch")]
        public string National { get; set; }
        [Required]
        [Display(Name ="Sổ hộ chiếu hoặc giấy thông hành hợp pháp khác")]
        public string CMND { get; set; }




        // travel infomation 
        public bool AirPlane { get; set; }
        public bool Ships { get; set; }
        public bool Car { get; set; }
        public string AnotherVerhicle { get; set; }

        public string TransportStationNumber { get; set; }
        public string SeatNumber { get; set; }
        [Required]
        public int DepartureDate_date { get; set; }
        [Required]
        public int DepartureDate_month { get; set; }
        [Required]
        public int DepartureDate_year { get; set; }
        [Required]
        public int EntryDate_date { get; set; }
        [Required]
        public int EntryDate_month { get; set; }
        [Required]
        public int EntryDate_year { get; set; }
        [Required]
        public string DepartureCountry { get; set; }
        [Required]
        public string DepartureProvince { get; set; }
        [Required]
        public string DestinyLocationCountry { get; set; }
        [Required]
        public string DestinyLocationProvince { get; set; }






        [Required]
        [Display(Name = "Trong vòng 21 ngày qua, Anh/Chị có đến quốc gia/vùng lãnh thổ nào?")]
        public string ListCountryhasGoneThrough { get; set; }
        [Required]
        [Display(Name ="Tỉnh thành ")]
        public string CurrentAddressProvince { get; set; }
        [Required]
        [Display(Name = "Quận / huyện ")]
        public string CurrentAddressDistrict { get; set; }
        [Required]
        [Display(Name = "Phường / xã ")]
        public string CurrentAddressWard { get; set; }
        [Required]
        [Display(Name = "Địa chỉ nơi ở tại Việt Nam ")]
        public string CurrentAddressStreet { get; set; }
        [Required]
        [Display(Name = "Điện thoại ")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        



        // Dau hieu benh ly
        [Required]
        
        public bool Fever { get; set; }
        [Required]
        public bool Cough { get; set; }
        [Required]
        public bool DifficultOfBreathing { get; set; }
        [Required]
        public bool SoreThroat { get; set; }
        [Required]
        public bool Vomiting { get; set; }
        [Required]
        public bool Diarrhea { get; set; }
        [Required]
        public bool SkinHaemorrhage { get; set; }
        [Required]
        public bool Rash { get; set; }




        [Display(Name = "Danh sách vắc-xin hoặc sinh phẩm được sử dụng")]
        public string UsedVaccineList { get; set; }




        //Lich su phoi nhiem
        [Required]
        public bool ContactToAnimal { get; set; }
        [Required]
        public bool ContactWithSickPeople { get; set; }



    }
}
