using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BGLINFO")]
    public partial class Bglinfo
    {
        [Key]
        [Column("bgliFileId")]
        public int BgliFileId { get; set; }
        [Column("bgliOrder1")]
        public int? BgliOrder1 { get; set; }
        [Column("bgliOrder2")]
        public int? BgliOrder2 { get; set; }
        [Column("bgliOrder3")]
        public int? BgliOrder3 { get; set; }
        [Column("bgliOrder4")]
        public int? BgliOrder4 { get; set; }
        [Column("bgliOrder5")]
        public int? BgliOrder5 { get; set; }
        [Column("bgliOrder6")]
        public int? BgliOrder6 { get; set; }
        [Column("bgliOrder7")]
        public int? BgliOrder7 { get; set; }
        [Column("bgliOrder8")]
        public int? BgliOrder8 { get; set; }
        [Column("bgliOrder9")]
        public int? BgliOrder9 { get; set; }
        [Column("bgliOrder10")]
        public int? BgliOrder10 { get; set; }
        [Column("bgliNoVATCode")]
        [StringLength(15)]
        public string BgliNoVatcode { get; set; }
        [Column("bgliEFKCode")]
        [StringLength(15)]
        public string BgliEfkcode { get; set; }
    }
}
