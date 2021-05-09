using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SUPLFEAT2")]
    [Index(nameof(PFeature2), Name = "pt2BycFeature", IsUnique = true)]
    public partial class Suplfeat2
    {
        [Key]
        [Column("pFeatureId")]
        public int PFeatureId { get; set; }
        [Required]
        [Column("pFeature2")]
        [StringLength(3)]
        public string PFeature2 { get; set; }
        [Column("pTDescr2")]
        [StringLength(29)]
        public string PTdescr2 { get; set; }
    }
}
