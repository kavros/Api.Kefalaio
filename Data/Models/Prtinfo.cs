using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRTINFO")]
    public partial class Prtinfo
    {
        [Key]
        [Column("prtFileId")]
        public int PrtFileId { get; set; }
        [Column("prtc", TypeName = "text")]
        public string Prtc { get; set; }
        [Column("prtt")]
        [StringLength(39)]
        public string Prtt { get; set; }
        [Column("prtn")]
        [StringLength(13)]
        public string Prtn { get; set; }
        [Column("prtLen1")]
        public int? PrtLen1 { get; set; }
        [Column("prtLen2")]
        public int? PrtLen2 { get; set; }
        [Column("prtDriver")]
        [StringLength(13)]
        public string PrtDriver { get; set; }
    }
}
