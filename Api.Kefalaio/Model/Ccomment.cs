using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CCOMMENTS")]
    [Index(nameof(CcmCode), Name = "ccmByCode", IsUnique = true)]
    public partial class Ccomment
    {
        [Key]
        [Column("ccmFileId")]
        public int CcmFileId { get; set; }
        [Required]
        [Column("ccmCode")]
        [StringLength(3)]
        public string CcmCode { get; set; }
        [Column("ccmData")]
        [StringLength(39)]
        public string CcmData { get; set; }
    }
}
