using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    public class Province
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        public string Type { get; set; }

        public int? TelephoneCode { get; set; }

        public string ZipCode { get; set; }

        public string CountryCode { get; set; }

        public int? SortOrder { get; set; }

        public bool? IsPublished { get; set; }

        public bool? IsDeleted { get; set; }


        public Country Country { get; set; }
        public int CountryId { get; set; }

    }
}
