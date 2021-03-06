﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToKhaiYTe.Models
{
    public class Ward
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        public string Type { get; set; }

        public string LatiLongTude { get; set; }

        public int SortOrder { get; set; }

        public bool? IsPublished { get; set; }

        public bool? IsDeleted { get; set; }
        public District District { get; set; }
        public int DistrictID { get; set; }
    }
}
