using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STORFEAT2")]
    [Index(nameof(SFeature2), Name = "ts2BysFeature", IsUnique = true)]
    public partial class Storfeat2
    {
        [Key]
        [Column("sFeatureId")]
        public int SFeatureId { get; set; }
        [Required]
        [Column("sFeature2")]
        [StringLength(3)]
        public string SFeature2 { get; set; }
        [Column("tsDescr2")]
        [StringLength(29)]
        public string TsDescr2 { get; set; }
    }
}
