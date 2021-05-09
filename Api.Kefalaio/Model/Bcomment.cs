using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BCOMMENTS")]
    [Index(nameof(BcmCode), Name = "bcmByCode", IsUnique = true)]
    public partial class Bcomment
    {
        [Key]
        [Column("bcmFileId")]
        public int BcmFileId { get; set; }
        [Required]
        [Column("bcmCode")]
        [StringLength(3)]
        public string BcmCode { get; set; }
        [Column("bcmData")]
        [StringLength(61)]
        public string BcmData { get; set; }
    }
}
