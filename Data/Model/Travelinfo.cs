using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TRAVELINFO")]
    public partial class Travelinfo
    {
        [Key]
        [Column("tifFileId")]
        public int TifFileId { get; set; }
        [Column("tifKeyId")]
        [StringLength(2)]
        public string TifKeyId { get; set; }
        [Column("tifName")]
        [StringLength(38)]
        public string TifName { get; set; }
        [Column("tifMethod")]
        public int? TifMethod { get; set; }
        [Column("tifApo")]
        public int? TifApo { get; set; }
    }
}
