using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SNOTRN")]
    [Index(nameof(SomFileId), Name = "sotBysomFileId")]
    public partial class Snotrn
    {
        [Key]
        [Column("sotFileId")]
        public int SotFileId { get; set; }
        [Column("somFileId")]
        public int? SomFileId { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
    }
}
