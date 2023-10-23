using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CEXTRAFIELDS")]
    public partial class Cextrafield
    {
        [Key]
        [Column("cxfFileId")]
        public int CxfFileId { get; set; }
        [Column("cxfName")]
        [StringLength(13)]
        public string CxfName { get; set; }
        [Column("cxfRequired")]
        public short? CxfRequired { get; set; }
    }
}
