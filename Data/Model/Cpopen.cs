using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CPOPEN")]
    [Index(nameof(CpoMode), nameof(CpoDate), Name = "cpoByDate")]
    [Index(nameof(CpoMode), nameof(CpoDiamartPos), Name = "cpoByDiamartPos")]
    [Index(nameof(CpoMode), nameof(CpoTrPos1), nameof(CpoTrPos2), Name = "cpoByTrPos1")]
    [Index(nameof(CpoMode), nameof(CpoTrPos2), nameof(CpoTrPos1), Name = "cpoByTrPos2")]
    public partial class Cpopen
    {
        [Key]
        [Column("cpoFileId")]
        public int CpoFileId { get; set; }
        [Column("cpoMode")]
        public int? CpoMode { get; set; }
        [Column("cpoTrPos1")]
        public int? CpoTrPos1 { get; set; }
        [Column("cpoTrPos2")]
        public int? CpoTrPos2 { get; set; }
        [Column("cpoCoverage")]
        public double? CpoCoverage { get; set; }
        [Column("cpoDrCover")]
        public double? CpoDrCover { get; set; }
        [Column("cpoFlag")]
        public int? CpoFlag { get; set; }
        [Column("cpoDate", TypeName = "datetime")]
        public DateTime? CpoDate { get; set; }
        [Column("cpoDiamartPos")]
        public int? CpoDiamartPos { get; set; }
    }
}
