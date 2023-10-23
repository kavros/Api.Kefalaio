using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ITVRTLCATEGORY")]
    [Index(nameof(SrtlcatId), Name = "itvrByCode", IsUnique = true)]
    public partial class Itvrtlcategory
    {
        [Key]
        [Column("srtlFileId")]
        public int SrtlFileId { get; set; }
        [Required]
        [Column("srtlcatId")]
        [StringLength(3)]
        public string SrtlcatId { get; set; }
        [Column("srtlcatDescription")]
        [StringLength(39)]
        public string SrtlcatDescription { get; set; }
        [Column("srtlcatColorId")]
        public int? SrtlcatColorId { get; set; }
        [Column("srtlcatImage")]
        [StringLength(255)]
        public string SrtlcatImage { get; set; }
    }
}
