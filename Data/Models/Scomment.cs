using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SCOMMENTS")]
    [Index(nameof(ScmCode), Name = "scmByCode", IsUnique = true)]
    public partial class Scomment
    {
        [Key]
        [Column("scmFileId")]
        public int ScmFileId { get; set; }
        [Required]
        [Column("scmCode")]
        [StringLength(3)]
        public string ScmCode { get; set; }
        [Column("scmData")]
        [StringLength(39)]
        public string ScmData { get; set; }
    }
}
