using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NEPARTPAY")]
    public partial class Nepartpay
    {
        [Key]
        [Column("nepFileId")]
        public int NepFileId { get; set; }
        [Column("nepMinPart")]
        public double? NepMinPart { get; set; }
        [Column("nepRndPart")]
        public double? NepRndPart { get; set; }
        [Column("nepDiffRnd")]
        public int? NepDiffRnd { get; set; }
        [Column("nepMaxParts")]
        public int? NepMaxParts { get; set; }
        [Column("nepSplitBy")]
        public int? NepSplitBy { get; set; }
        [Column("nepDSet")]
        [StringLength(256)]
        public string NepDset { get; set; }
    }
}
