using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CUSTFEAT1")]
    [Index(nameof(CFeature1), Name = "ct1BycFeature", IsUnique = true)]
    public partial class Custfeat1
    {
        [Key]
        [Column("cFeatureId")]
        public int CFeatureId { get; set; }
        [Required]
        [Column("cFeature1")]
        [StringLength(3)]
        public string CFeature1 { get; set; }
        [Column("cTDescr1")]
        [StringLength(29)]
        public string CTdescr1 { get; set; }
    }
}
