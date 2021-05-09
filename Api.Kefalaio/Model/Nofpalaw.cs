using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NOFPALAWS")]
    public partial class Nofpalaw
    {
        [Key]
        [Column("nflFileId")]
        public int NflFileId { get; set; }
        [Column("nflCode")]
        [StringLength(3)]
        public string NflCode { get; set; }
        [Column("nflDescr")]
        [StringLength(39)]
        public string NflDescr { get; set; }
        [Column("nflIsClassAccount")]
        public short? NflIsClassAccount { get; set; }
    }
}
