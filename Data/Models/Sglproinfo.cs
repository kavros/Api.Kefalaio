using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SGLPROINFO")]
    public partial class Sglproinfo
    {
        [Key]
        [Column("sgiFileId")]
        public int SgiFileId { get; set; }
        [Column("sgiKind")]
        public int? SgiKind { get; set; }
        [Column("sgiLogd")]
        [StringLength(39)]
        public string SgiLogd { get; set; }
        [Column("sgiLogc")]
        [StringLength(39)]
        public string SgiLogc { get; set; }
        [Column("sgiTots")]
        public short? SgiTots { get; set; }
        [Column("sgiMTots")]
        public short? SgiMtots { get; set; }
    }
}
