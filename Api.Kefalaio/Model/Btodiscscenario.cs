using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BTODISCSCENARIO")]
    public partial class Btodiscscenario
    {
        [Key]
        [Column("bdsFileId")]
        public int BdsFileId { get; set; }
        [Column("bdsDescr")]
        [StringLength(39)]
        public string BdsDescr { get; set; }
        [Column("bdsLimit1")]
        public double? BdsLimit1 { get; set; }
        [Column("bdsPrc1")]
        public double? BdsPrc1 { get; set; }
        [Column("bdsLimit2")]
        public double? BdsLimit2 { get; set; }
        [Column("bdsPrc2")]
        public double? BdsPrc2 { get; set; }
        [Column("bdsLimit3")]
        public double? BdsLimit3 { get; set; }
        [Column("bdsPrc3")]
        public double? BdsPrc3 { get; set; }
        [Column("bdsLimit4")]
        public double? BdsLimit4 { get; set; }
        [Column("bdsPrc4")]
        public double? BdsPrc4 { get; set; }
        [Column("bdsLimit5")]
        public double? BdsLimit5 { get; set; }
        [Column("bdsPrc5")]
        public double? BdsPrc5 { get; set; }
        [Column("bdsLimit6")]
        public double? BdsLimit6 { get; set; }
        [Column("bdsPrc6")]
        public double? BdsPrc6 { get; set; }
        [Column("bdsLimit7")]
        public double? BdsLimit7 { get; set; }
        [Column("bdsPrc7")]
        public double? BdsPrc7 { get; set; }
        [Column("bdsLimit8")]
        public double? BdsLimit8 { get; set; }
        [Column("bdsPrc8")]
        public double? BdsPrc8 { get; set; }
        [Column("bdsLimit9")]
        public double? BdsLimit9 { get; set; }
        [Column("bdsPrc9")]
        public double? BdsPrc9 { get; set; }
        [Column("bdsLimit10")]
        public double? BdsLimit10 { get; set; }
        [Column("bdsPrc10")]
        public double? BdsPrc10 { get; set; }
    }
}
