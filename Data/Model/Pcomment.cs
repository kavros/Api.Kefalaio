using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PCOMMENTS")]
    [Index(nameof(PcmCode), Name = "pcmByCode", IsUnique = true)]
    public partial class Pcomment
    {
        [Key]
        [Column("pcmFileId")]
        public int PcmFileId { get; set; }
        [Required]
        [Column("pcmCode")]
        [StringLength(3)]
        public string PcmCode { get; set; }
        [Column("pcmData")]
        [StringLength(39)]
        public string PcmData { get; set; }
    }
}
