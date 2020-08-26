using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    public class PhatologicalSign
    {
        [ForeignKey("MedicalDeclarationForm")]
        public int Id { get; set; }
        public MedicalDeclarationForm MedicalDeclarationForm { get; set; }
        public int MedicalDeclarationFormId { get; set; }
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
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

    }
}
