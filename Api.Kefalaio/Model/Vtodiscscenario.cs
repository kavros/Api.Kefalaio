using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VTODISCSCENARIO")]
    public partial class Vtodiscscenario
    {
        [Key]
        [Column("vdsFileId")]
        public int VdsFileId { get; set; }
        [Column("vdsDescr")]
        [StringLength(39)]
        public string VdsDescr { get; set; }
        [Column("vdsLimit1")]
        public double? VdsLimit1 { get; set; }
        [Column("vdsPrc1")]
        public double? VdsPrc1 { get; set; }
        [Column("vdsLimit2")]
        public double? VdsLimit2 { get; set; }
        [Column("vdsPrc2")]
        public double? VdsPrc2 { get; set; }
        [Column("vdsLimit3")]
        public double? VdsLimit3 { get; set; }
        [Column("vdsPrc3")]
        public double? VdsPrc3 { get; set; }
        [Column("vdsLimit4")]
        public double? VdsLimit4 { get; set; }
        [Column("vdsPrc4")]
        public double? VdsPrc4 { get; set; }
        [Column("vdsLimit5")]
        public double? VdsLimit5 { get; set; }
        [Column("vdsPrc5")]
        public double? VdsPrc5 { get; set; }
        [Column("vdsLimit6")]
        public double? VdsLimit6 { get; set; }
        [Column("vdsPrc6")]
        public double? VdsPrc6 { get; set; }
        [Column("vdsLimit7")]
        public double? VdsLimit7 { get; set; }
        [Column("vdsPrc7")]
        public double? VdsPrc7 { get; set; }
        [Column("vdsLimit8")]
        public double? VdsLimit8 { get; set; }
        [Column("vdsPrc8")]
        public double? VdsPrc8 { get; set; }
        [Column("vdsLimit9")]
        public double? VdsLimit9 { get; set; }
        [Column("vdsPrc9")]
        public double? VdsPrc9 { get; set; }
        [Column("vdsLimit10")]
        public double? VdsLimit10 { get; set; }
        [Column("vdsPrc10")]
        public double? VdsPrc10 { get; set; }
    }
}
