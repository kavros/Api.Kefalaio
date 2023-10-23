using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PGRAPH")]
    public partial class Pgraph
    {
        [Key]
        [Column("pgrFileId")]
        public int PgrFileId { get; set; }
        [Column("pgrDescr")]
        [StringLength(81)]
        public string PgrDescr { get; set; }
        [Column("pgrIdx1")]
        public int? PgrIdx1 { get; set; }
        [Column("pgrIdx2")]
        public int? PgrIdx2 { get; set; }
        [Column("pgrIdx3")]
        public int? PgrIdx3 { get; set; }
        [Column("pgrIdx4")]
        public int? PgrIdx4 { get; set; }
        [Column("pgrProgressive")]
        public short? PgrProgressive { get; set; }
        [Column("pgrStyle")]
        public int? PgrStyle { get; set; }
        [Column("pgrTheme")]
        public int? PgrTheme { get; set; }
    }
}
