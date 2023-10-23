using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SGLBRIDGE")]
    public partial class Sglbridge
    {
        [Key]
        [Column("sgbFileId")]
        public int SgbFileId { get; set; }
        [Column("sgbKind")]
        public int? SgbKind { get; set; }
        [Column("sgbLogd")]
        [StringLength(39)]
        public string SgbLogd { get; set; }
        [Column("sgbOrdd1")]
        public int? SgbOrdd1 { get; set; }
        [Column("sgbOrdd2")]
        public int? SgbOrdd2 { get; set; }
        [Column("sgbLogc")]
        [StringLength(39)]
        public string SgbLogc { get; set; }
        [Column("sgbOrdc1")]
        public int? SgbOrdc1 { get; set; }
        [Column("sgbOrdc2")]
        public int? SgbOrdc2 { get; set; }
        [Column("sgbTots")]
        public short? SgbTots { get; set; }
    }
}
