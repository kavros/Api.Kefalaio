using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PEXTRAFIELDS")]
    public partial class Pextrafield
    {
        [Key]
        [Column("pxfFileId")]
        public int PxfFileId { get; set; }
        [Column("pxfName")]
        [StringLength(13)]
        public string PxfName { get; set; }
        [Column("pxfRequired")]
        public short? PxfRequired { get; set; }
    }
}
