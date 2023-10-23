using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SUPLFEAT1")]
    [Index(nameof(PFeature1), Name = "pt1BycFeature", IsUnique = true)]
    public partial class Suplfeat1
    {
        [Key]
        [Column("pFeatureId")]
        public int PFeatureId { get; set; }
        [Required]
        [Column("pFeature1")]
        [StringLength(3)]
        public string PFeature1 { get; set; }
        [Column("pTDescr1")]
        [StringLength(29)]
        public string PTdescr1 { get; set; }
    }
}
