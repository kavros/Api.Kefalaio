using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VCOMMENTS")]
    [Index(nameof(VcmCode), Name = "vcmByCode", IsUnique = true)]
    public partial class Vcomment
    {
        [Key]
        [Column("vcmFileId")]
        public int VcmFileId { get; set; }
        [Required]
        [Column("vcmCode")]
        [StringLength(3)]
        public string VcmCode { get; set; }
        [Column("vcmData")]
        [StringLength(61)]
        public string VcmData { get; set; }
    }
}
