using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLVAT")]
    public partial class Glvat
    {
        [Key]
        [Column("glvFileId")]
        public int GlvFileId { get; set; }
        [Column("glvCode1")]
        [StringLength(39)]
        public string GlvCode1 { get; set; }
        [Column("glvCode2")]
        [StringLength(39)]
        public string GlvCode2 { get; set; }
        [Column("glvVSellCode")]
        [StringLength(39)]
        public string GlvVsellCode { get; set; }
        [Column("glvBSellCode")]
        [StringLength(39)]
        public string GlvBsellCode { get; set; }
        [Column("glvEokc1")]
        [StringLength(39)]
        public string GlvEokc1 { get; set; }
        [Column("gvlEokc2")]
        [StringLength(39)]
        public string GvlEokc2 { get; set; }
        [Column("glvEokAlc1")]
        [StringLength(39)]
        public string GlvEokAlc1 { get; set; }
        [Column("glvEokAlc2")]
        [StringLength(39)]
        public string GlvEokAlc2 { get; set; }
        [Column("glvFcc1")]
        [StringLength(39)]
        public string GlvFcc1 { get; set; }
        [Column("glvFcc2")]
        [StringLength(39)]
        public string GlvFcc2 { get; set; }
        [Column("glvVat11")]
        [StringLength(39)]
        public string GlvVat11 { get; set; }
        [Column("glvVat12")]
        [StringLength(39)]
        public string GlvVat12 { get; set; }
        [Column("glvVat13")]
        [StringLength(39)]
        public string GlvVat13 { get; set; }
        [Column("glvVat21")]
        [StringLength(39)]
        public string GlvVat21 { get; set; }
        [Column("glvVat22")]
        [StringLength(39)]
        public string GlvVat22 { get; set; }
        [Column("glvVat23")]
        [StringLength(39)]
        public string GlvVat23 { get; set; }
        [Column("glvVat31")]
        [StringLength(39)]
        public string GlvVat31 { get; set; }
        [Column("glvVat32")]
        [StringLength(39)]
        public string GlvVat32 { get; set; }
        [Column("glvVat33")]
        [StringLength(39)]
        public string GlvVat33 { get; set; }
        [Column("glvVSPSellCode")]
        [StringLength(39)]
        public string GlvVspsellCode { get; set; }
        [Column("glvBSPSellCode")]
        [StringLength(39)]
        public string GlvBspsellCode { get; set; }
        [Column("glvSPCode1")]
        [StringLength(39)]
        public string GlvSpcode1 { get; set; }
        [Column("glvSPCode2")]
        [StringLength(39)]
        public string GlvSpcode2 { get; set; }
    }
}
