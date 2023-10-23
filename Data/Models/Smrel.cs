using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SMREL")]
    [Index(nameof(SmrCode2), nameof(SmrCode1), Name = "smrByCode2", IsUnique = true)]
    [Index(nameof(SmrCode1), nameof(SmrCode2), Name = "smtByCode1", IsUnique = true)]
    public partial class Smrel
    {
        [Key]
        [Column("smrFileId")]
        public int SmrFileId { get; set; }
        [Required]
        [Column("smrCode1")]
        [StringLength(25)]
        public string SmrCode1 { get; set; }
        [Required]
        [Column("smrCode2")]
        [StringLength(25)]
        public string SmrCode2 { get; set; }
        [Column("smrQuant")]
        public double? SmrQuant { get; set; }
        [Column("smrColorPos")]
        public int? SmrColorPos { get; set; }
        [Column("smrSizePos")]
        public int? SmrSizePos { get; set; }
    }
}
