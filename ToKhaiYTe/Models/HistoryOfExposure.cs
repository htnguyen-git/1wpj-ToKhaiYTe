using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    public class HistoryOfExposure
    {
        [ForeignKey("MedicalDeclarationForm")]
        public int Id { get; set; }
        
        public virtual MedicalDeclarationForm MedicalDeclarationForm { get; set; }
        public int MedicalDeclarationFormId { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

    }
}
