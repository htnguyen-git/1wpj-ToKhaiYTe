using System.ComponentModel.DataAnnotations;

namespace ToKhaiYTe.Models.User
{
    public class RegisterUserViewModel
    {
        [Required]
        [Display(Name ="Tên đăng nhập hoặc email ")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = " Xác nhận Mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }

    }
}
