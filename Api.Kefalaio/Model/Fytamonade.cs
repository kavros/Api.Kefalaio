using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FYTAMONADES")]
    [Index(nameof(MonCode), Name = "monByCode", IsUnique = true)]
    public partial class Fytamonade
    {
        [Key]
        [Column("monFileId")]
        public int MonFileId { get; set; }
        [Required]
        [Column("monCode")]
        [StringLength(5)]
        public string MonCode { get; set; }
        [Column("monDescr")]
        [StringLength(39)]
        public string MonDescr { get; set; }
        [Column("monActive")]
        public short? MonActive { get; set; }
    }
}
