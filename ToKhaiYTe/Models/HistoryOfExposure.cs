using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    
    public class HistoryOfExposure
    {
        [Key]
        [ForeignKey("MedicalDeclarationForm")]
        public int MedicalDeclarationFormId { get; set; }
        [Display(Name = "Có tiếp xúc với động vật")]
        public bool ContactToAnimal { get; set; }
        [Display(Name = "Có tiếp xúc với người bệnh")]
        public bool ContactWithSickPeople { get; set; }
        public virtual MedicalDeclarationForm MedicalDeclarationForm { get; set; }
        
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

    }
}
