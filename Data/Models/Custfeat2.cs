using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CUSTFEAT2")]
    [Index(nameof(CFeature2), Name = "ct2BycFeature", IsUnique = true)]
    public partial class Custfeat2
    {
        [Key]
        [Column("cFeatureId")]
        public int CFeatureId { get; set; }
        [Required]
        [Column("cFeature2")]
        [StringLength(3)]
        public string CFeature2 { get; set; }
        [Column("cTDescr2")]
        [StringLength(29)]
        public string CTdescr2 { get; set; }
    }
}
