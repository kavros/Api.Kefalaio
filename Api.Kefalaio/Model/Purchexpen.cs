using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PURCHEXPEN")]
    public partial class Purchexpen
    {
        [Key]
        [Column("paFileIdNo")]
        public int PaFileIdNo { get; set; }
        [Column("paData")]
        [StringLength(19)]
        public string PaData { get; set; }
        [Column("paExpense")]
        public double? PaExpense { get; set; }
        [Column("paVatType")]
        [StringLength(3)]
        public string PaVatType { get; set; }
        [Column("paVatUse")]
        public int? PaVatUse { get; set; }
        [Column("paGLCode")]
        [StringLength(25)]
        public string PaGlcode { get; set; }
        [Column("paVatGLCo")]
        [StringLength(25)]
        public string PaVatGlco { get; set; }
        [Column("paFlags")]
        [StringLength(32)]
        public string PaFlags { get; set; }
        [Column("paConstVal")]
        public double? PaConstVal { get; set; }
        [Column("paCalcType")]
        public int? PaCalcType { get; set; }
        [Column("paSpGLCode")]
        [StringLength(25)]
        public string PaSpGlcode { get; set; }
        [Column("paSpVatGLCo")]
        [StringLength(25)]
        public string PaSpVatGlco { get; set; }
    }
}
