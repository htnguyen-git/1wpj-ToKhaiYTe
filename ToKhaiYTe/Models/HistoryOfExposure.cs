using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    
    public class HistoryOfExposure
    {
        [Key]
        [ForeignKey("MedicalDeclarationForm")]
        public int MedicalDeclarationFormId { get; set; }
        public bool ContactToAnimal { get; set; }
        public bool ContactWithSickPeople { get; set; }
        public virtual MedicalDeclarationForm MedicalDeclarationForm { get; set; }
        
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

    }
}
