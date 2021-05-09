using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SCOLORS")]
    [Index(nameof(SclCode), Name = "sclByCode", IsUnique = true)]
    public partial class Scolor
    {
        [Key]
        [Column("sclFileId")]
        public int SclFileId { get; set; }
        [Required]
        [Column("sclCode")]
        [StringLength(5)]
        public string SclCode { get; set; }
        [Column("sclDescr")]
        [StringLength(15)]
        public string SclDescr { get; set; }
    }
}
