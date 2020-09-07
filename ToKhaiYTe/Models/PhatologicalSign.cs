using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    public class PhatologicalSign
    {

        public MedicalDeclarationForm MedicalDeclarationForm { get; set; }
        [Key]
        [ForeignKey("MedicalDeclarationForm")]
        public int MedicalDeclarationFormId { get; set; }
        [Required]
        [Display(Name ="Sốt")]
        public bool Fever { get; set; }
        [Required]
        [Display(Name ="Ho")]
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
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

    }
}
