using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LEXTRAFIELDS")]
    public partial class Lextrafield
    {
        [Key]
        [Column("lxfFileId")]
        public int LxfFileId { get; set; }
        [Column("lxfName")]
        [StringLength(13)]
        public string LxfName { get; set; }
        [Column("lxfRequired")]
        public short? LxfRequired { get; set; }
    }
}
