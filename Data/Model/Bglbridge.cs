using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BGLBRIDGE")]
    public partial class Bglbridge
    {
        [Key]
        [Column("bgbFileId")]
        public int BgbFileId { get; set; }
        [Column("bgbGCode")]
        [StringLength(39)]
        public string BgbGcode { get; set; }
        [Column("bgbGKind")]
        public int? BgbGkind { get; set; }
        [Column("bgbToton")]
        public short? BgbToton { get; set; }
        [Column("bgbFrcost")]
        public short? BgbFrcost { get; set; }
        [Column("bgbCpCode")]
        [StringLength(39)]
        public string BgbCpCode { get; set; }
    }
}
