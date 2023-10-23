using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRGMASKS")]
    public partial class Prgmask
    {
        [Key]
        [Column("pgmFileId")]
        public int PgmFileId { get; set; }
        [Column("pgmCodeMask")]
        [StringLength(25)]
        public string PgmCodeMask { get; set; }
        [Column("pgmGrpLen1")]
        public int? PgmGrpLen1 { get; set; }
        [Column("pgmGrpLen2")]
        public int? PgmGrpLen2 { get; set; }
        [Column("pgmGrpLen3")]
        public int? PgmGrpLen3 { get; set; }
        [Column("pgmGrpLen4")]
        public int? PgmGrpLen4 { get; set; }
        [Column("pgmGrpLen5")]
        public int? PgmGrpLen5 { get; set; }
        [Column("pgmGrpLen6")]
        public int? PgmGrpLen6 { get; set; }
        [Column("pgmGrpLen7")]
        public int? PgmGrpLen7 { get; set; }
        [Column("pgmGrpLen8")]
        public int? PgmGrpLen8 { get; set; }
        [Column("pgmGrpLen9")]
        public int? PgmGrpLen9 { get; set; }
        [Column("pgmGrpLen10")]
        public int? PgmGrpLen10 { get; set; }
    }
}
