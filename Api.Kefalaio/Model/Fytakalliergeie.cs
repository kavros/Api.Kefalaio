using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FYTAKALLIERGEIES")]
    [Index(nameof(KalCode), Name = "kalByCode", IsUnique = true)]
    public partial class Fytakalliergeie
    {
        [Key]
        [Column("kalFileId")]
        public int KalFileId { get; set; }
        [Required]
        [Column("kalCode")]
        [StringLength(5)]
        public string KalCode { get; set; }
        [Column("kalDescr")]
        [StringLength(39)]
        public string KalDescr { get; set; }
    }
}
