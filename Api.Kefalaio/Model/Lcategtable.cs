using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LCATEGTABLE")]
    [Index(nameof(LcCode), Name = "lcByCode", IsUnique = true)]
    public partial class Lcategtable
    {
        [Key]
        public int LcFileId { get; set; }
        [Required]
        [Column("lcCode")]
        [StringLength(3)]
        public string LcCode { get; set; }
        [Column("lcName")]
        [StringLength(39)]
        public string LcName { get; set; }
        [Column("lcMeth")]
        public int? LcMeth { get; set; }
        [Column("lcF1")]
        public double? LcF1 { get; set; }
        [Column("lcF2")]
        public double? LcF2 { get; set; }
        [Column("lcMFact")]
        public double? LcMfact { get; set; }
    }
}
