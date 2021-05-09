using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STORFEAT1")]
    [Index(nameof(SFeature1), Name = "ts1BysFeature", IsUnique = true)]
    public partial class Storfeat1
    {
        [Key]
        [Column("sFeatureId")]
        public int SFeatureId { get; set; }
        [Required]
        [Column("sFeature1")]
        [StringLength(3)]
        public string SFeature1 { get; set; }
        [Column("tsDescr1")]
        [StringLength(29)]
        public string TsDescr1 { get; set; }
    }
}
