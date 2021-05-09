using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FYTAAITIES")]
    [Index(nameof(AitCode), Name = "aitByCode", IsUnique = true)]
    public partial class Fytaaity
    {
        [Key]
        [Column("aitFileId")]
        public int AitFileId { get; set; }
        [Required]
        [Column("aitCode")]
        [StringLength(5)]
        public string AitCode { get; set; }
        [Column("aitDescr")]
        [StringLength(39)]
        public string AitDescr { get; set; }
        [Column("aitActive")]
        public short? AitActive { get; set; }
    }
}
