using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SEXTRAFIELDS")]
    public partial class Sextrafield
    {
        [Key]
        [Column("sxfFileId")]
        public int SxfFileId { get; set; }
        [Column("sxfName")]
        [StringLength(13)]
        public string SxfName { get; set; }
        [Column("sxfRequired")]
        public short? SxfRequired { get; set; }
    }
}
