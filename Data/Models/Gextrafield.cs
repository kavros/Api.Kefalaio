using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GEXTRAFIELDS")]
    public partial class Gextrafield
    {
        [Key]
        [Column("gxfFileId")]
        public int GxfFileId { get; set; }
        [Column("gxfName")]
        [StringLength(13)]
        public string GxfName { get; set; }
        [Column("gxfRequired")]
        public short? GxfRequired { get; set; }
    }
}
