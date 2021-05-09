using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SALESEXPEN")]
    public partial class Salesexpen
    {
        [Key]
        [Column("seFileIdNo")]
        public int SeFileIdNo { get; set; }
        [Column("seData")]
        [StringLength(19)]
        public string SeData { get; set; }
        [Column("seExpense")]
        public double? SeExpense { get; set; }
        [Column("seVatType")]
        [StringLength(3)]
        public string SeVatType { get; set; }
        [Column("seVatUse")]
        public int? SeVatUse { get; set; }
        [Column("seGLCode")]
        [StringLength(25)]
        public string SeGlcode { get; set; }
        [Column("seVatGLCo")]
        [StringLength(25)]
        public string SeVatGlco { get; set; }
        [Column("seFlags")]
        [StringLength(32)]
        public string SeFlags { get; set; }
        [Column("seConstVal")]
        public double? SeConstVal { get; set; }
        [Column("seCalcType")]
        public int? SeCalcType { get; set; }
        [Column("seSpGLCode")]
        [StringLength(25)]
        public string SeSpGlcode { get; set; }
        [Column("seSpVatGLCo")]
        [StringLength(25)]
        public string SeSpVatGlco { get; set; }
    }
}
