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
        [Range(1900,2020)]
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
        [Display(Name ="Máy bay")]
        public bool AirPlane { get; set; }
        [Display(Name ="Tàu thuyền")]
        public bool Ships { get; set; }
        [Display(Name = "Ô tô")]
        public bool Car { get; set; }
        [Display(Name = "Phương tiện khác")]
        public string AnotherVerhicle { get; set; }
        [Display(Name = "Số hiệu phương tiện")]
        public string TransportStationNumber { get; set; }
        [Display(Name = "Số ghế")]
        public string SeatNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Ngày khởi hành")]
        public string DepartureDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày nhập cảnh")]
        public string EntryDate { get; set; }
        [Required]
        [Display(Name ="Quốc gia / vùng lãnh thổ đi")]
        public string DepartureCountry { get; set; }
        [Required]
        [Display(Name ="Tỉnh đi")]
        public string DepartureProvince { get; set; }
        [Required]
        [Display(Name = "Quốc gia / vùng lãnh thổ đến")]
        public string DestinyLocationCountry { get; set; }
        [Required]
        [Display(Name = "Tỉnh đến")]
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
        [Display(Name ="Sốt")]
        public bool Fever { get; set; }
        [Required]
        [Display(Name = "Ho")]
        public bool Cough { get; set; }
        [Required]
        [Display(Name = "Khó thở")]
        public bool DifficultOfBreathing { get; set; }
        [Required]
        [Display(Name = "Đau họng")]
        public bool SoreThroat { get; set; }
        [Required]
        [Display(Name = "Nôn / buồn nôn")]
        public bool Vomiting { get; set; }
        [Required]
        [Display(Name = "Tiêu chảy")]
        public bool Diarrhea { get; set; }
        [Required]
        [Display(Name = "Xuất huyết ngoài da")]
        public bool SkinHaemorrhage { get; set; }
        [Required]
        [Display(Name = "Nổi ban ngoài da")]
        public bool Rash { get; set; }




        [Display(Name = "Danh sách vắc-xin hoặc sinh phẩm được sử dụng")]
        public string UsedVaccineList { get; set; }




        //Lich su phoi nhiem
        [Required]
        [Display(Name = "Đến trang trại chăn nuôi / chợ buôn bán động vật sống / cơ sở giết mổ động vật / tiếp xúc động vật")]
        public bool ContactToAnimal { get; set; }
        [Required]
        [Display(Name = "Tiếp xúc gần (<2m) với người mắc bệnh viêm đường hô hấp do nCoV")]
        public bool ContactWithSickPeople { get; set; }



    }
}
