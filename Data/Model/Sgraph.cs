using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SGRAPH")]
    public partial class Sgraph
    {
        [Key]
        [Column("sgrFileId")]
        public int SgrFileId { get; set; }
        [Column("sgrDescr")]
        [StringLength(81)]
        public string SgrDescr { get; set; }
        [Column("sgrIdx1")]
        public int? SgrIdx1 { get; set; }
        [Column("sgrIdx2")]
        public int? SgrIdx2 { get; set; }
        [Column("sgrIdx3")]
        public int? SgrIdx3 { get; set; }
        [Column("sgrIdx4")]
        public int? SgrIdx4 { get; set; }
        [Column("sgrProgressive")]
        public short? SgrProgressive { get; set; }
        [Column("sgrStyle")]
        public int? SgrStyle { get; set; }
        [Column("sgrTheme")]
        public int? SgrTheme { get; set; }
    }
}
