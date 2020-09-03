using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models.ViewModel
{
    public class ManagerSearchViewModel
    {
        [Display(Name ="Thành phố / tỉnh")]
        public bool Province { get; set; }
        [Display(Name="Quận/ huyện")]
        public bool District { get; set; }
        [Display(Name = "Phường/ xã")]
        public bool Ward { get; set; }
        [Display(Name = "Họ tên")]
        public bool Name { get; set; }
        [Display(Name = "Số điện thoại")]
        public bool PhoneNumber { get; set; }
        [Display(Name = "")]
        public string SearchString { get; set; }
    }
}
