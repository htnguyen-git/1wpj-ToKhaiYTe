using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models.ViewModel
{
    public class ManagerIndexViewModel
    {
        public int MedicalDelcarationFormId { get; set; }
        [Display(Name="Cửa khẩu")]
        public string Gate { get; set; }
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }
        [Display(Name = "Giới tính")]
        public string Gender { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Quốc tịch")]
        public string National { get; set; }

        [Display(Name = "Thành phố")]
        public string Province { get; set; }

        [Display(Name = "Quận / huyện")]
        public string District { get; set; }

        [Display(Name = "Phường/ xã")]
        public string Ward { get; set; }

    }
}
