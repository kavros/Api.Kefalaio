using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("COSTOSTABLE")]
    public partial class Costostable
    {
        [Key]
        [Column("ctcCostId")]
        public int CtcCostId { get; set; }
        [Column("ctcDescr")]
        [StringLength(19)]
        public string CtcDescr { get; set; }
        [Column("ctcVat")]
        [StringLength(3)]
        public string CtcVat { get; set; }
        [Column("ctcTt")]
        public int? CtcTt { get; set; }
        [Column("ctcLogGt")]
        [StringLength(25)]
        public string CtcLogGt { get; set; }
        [Column("ctcVatGt")]
        [StringLength(25)]
        public string CtcVatGt { get; set; }
        [Column("ctcFlags1")]
        public int? CtcFlags1 { get; set; }
        [Column("ctcFlags2")]
        public int? CtcFlags2 { get; set; }
        [Column("ctcFlags3")]
        public int? CtcFlags3 { get; set; }
        [Column("ctcFlags4")]
        public int? CtcFlags4 { get; set; }
        [Column("ctcDbKind")]
        public int? CtcDbKind { get; set; }
        [Column("ctcCrKind")]
        public int? CtcCrKind { get; set; }
        [Column("ctcOpenGL")]
        public int? CtcOpenGl { get; set; }
        [Column("ctcFlagsNew")]
        [StringLength(64)]
        public string CtcFlagsNew { get; set; }
    }
}
