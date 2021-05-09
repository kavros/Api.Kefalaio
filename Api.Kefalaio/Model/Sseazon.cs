using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SSEAZON")]
    public partial class Sseazon
    {
        [Key]
        [Column("sseFileId")]
        public int SseFileId { get; set; }
        [Column("sseDescr")]
        [StringLength(17)]
        public string SseDescr { get; set; }
    }
}
