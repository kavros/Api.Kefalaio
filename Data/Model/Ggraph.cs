using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GGRAPH")]
    public partial class Ggraph
    {
        [Key]
        [Column("ggrFileId")]
        public int GgrFileId { get; set; }
        [Column("ggrDescr")]
        [StringLength(81)]
        public string GgrDescr { get; set; }
        [Column("ggrIdx1")]
        public int? GgrIdx1 { get; set; }
        [Column("ggrIdx2")]
        public int? GgrIdx2 { get; set; }
        [Column("ggrIdx3")]
        public int? GgrIdx3 { get; set; }
        [Column("ggrIdx4")]
        public int? GgrIdx4 { get; set; }
        [Column("ggrProgressive")]
        public short? GgrProgressive { get; set; }
        [Column("ggrStyle")]
        public int? GgrStyle { get; set; }
        [Column("ggrTheme")]
        public int? GgrTheme { get; set; }
    }
}
