using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TRANSFOR")]
    [Index(nameof(TrfDestFile), nameof(TrfDestPos), nameof(TrfSourceCode), Name = "trfByDestCode")]
    [Index(nameof(TrfDestFile), nameof(TrfDestPos), nameof(TrfSourceDate), nameof(TrfSourceCode), Name = "trfByDestDate")]
    [Index(nameof(TrfSourceFile), nameof(TrfSourcePos), nameof(TrfDestCode), Name = "trfBySourceCode")]
    [Index(nameof(TrfSourceFile), nameof(TrfSourcePos), nameof(TrfDestDate), nameof(TrfDestCode), Name = "trfBySourceDate")]
    public partial class Transfor
    {
        [Key]
        [Column("trfFileID")]
        public int TrfFileId { get; set; }
        [Column("trfSourceFile")]
        public int TrfSourceFile { get; set; }
        [Column("trfSourcePos")]
        public int TrfSourcePos { get; set; }
        [Column("trfSourceCode")]
        [StringLength(15)]
        public string TrfSourceCode { get; set; }
        [Column("trfSourceDate", TypeName = "datetime")]
        public DateTime? TrfSourceDate { get; set; }
        [Column("trfDestFile")]
        public int TrfDestFile { get; set; }
        [Column("trfDestPos")]
        public int TrfDestPos { get; set; }
        [Column("trfDestCode")]
        [StringLength(15)]
        public string TrfDestCode { get; set; }
        [Column("trfDestDate", TypeName = "datetime")]
        public DateTime? TrfDestDate { get; set; }
        [Column("trfRecKind")]
        public int? TrfRecKind { get; set; }
    }
}
