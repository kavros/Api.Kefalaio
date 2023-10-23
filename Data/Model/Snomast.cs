using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SNOMAST")]
    [Index(nameof(SomCode), Name = "somByCode", IsUnique = true)]
    [Index(nameof(SomDescr), Name = "somByDescr")]
    public partial class Snomast
    {
        [Key]
        [Column("somFileId")]
        public int SomFileId { get; set; }
        [Required]
        [Column("somCode")]
        [StringLength(15)]
        public string SomCode { get; set; }
        [Column("somDescr")]
        [StringLength(39)]
        public string SomDescr { get; set; }
    }
}
