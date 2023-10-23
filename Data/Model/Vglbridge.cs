using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VGLBRIDGE")]
    public partial class Vglbridge
    {
        [Key]
        [Column("vgbFileId")]
        public int VgbFileId { get; set; }
        [Column("vgbGCode")]
        [StringLength(39)]
        public string VgbGcode { get; set; }
        [Column("vgbGKind")]
        public int? VgbGkind { get; set; }
        [Column("vgbToton")]
        public short? VgbToton { get; set; }
        [Column("vgbFrcost")]
        public short? VgbFrcost { get; set; }
        [Column("vgbCpCode")]
        [StringLength(39)]
        public string VgbCpCode { get; set; }
    }
}
