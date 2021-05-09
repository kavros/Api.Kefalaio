using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CGRAPH")]
    public partial class Cgraph
    {
        [Key]
        [Column("cgrFileId")]
        public int CgrFileId { get; set; }
        [Column("cgrDescr")]
        [StringLength(81)]
        public string CgrDescr { get; set; }
        [Column("cgrIdx1")]
        public int? CgrIdx1 { get; set; }
        [Column("cgrIdx2")]
        public int? CgrIdx2 { get; set; }
        [Column("cgrIdx3")]
        public int? CgrIdx3 { get; set; }
        [Column("cgrIdx4")]
        public int? CgrIdx4 { get; set; }
        [Column("cgrProgressive")]
        public short? CgrProgressive { get; set; }
        [Column("cgrStyle")]
        public int? CgrStyle { get; set; }
        [Column("cgrTheme")]
        public int? CgrTheme { get; set; }
    }
}
