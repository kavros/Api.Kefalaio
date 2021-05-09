using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GCOMMENTS")]
    [Index(nameof(GcmCode), Name = "gcmByCode", IsUnique = true)]
    public partial class Gcomment
    {
        [Key]
        [Column("gcmFileId")]
        public int GcmFileId { get; set; }
        [Required]
        [Column("gcmCode")]
        [StringLength(3)]
        public string GcmCode { get; set; }
        [Column("gcmData")]
        [StringLength(39)]
        public string GcmData { get; set; }
    }
}
