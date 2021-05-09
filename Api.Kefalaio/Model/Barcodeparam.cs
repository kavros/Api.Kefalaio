using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BARCODEPARAMS")]
    public partial class Barcodeparam
    {
        [Key]
        [Column("bcpFileId")]
        public int BcpFileId { get; set; }
        [Column("bcprefix")]
        [StringLength(4)]
        public string Bcprefix { get; set; }
        [Column("bcode1")]
        [StringLength(25)]
        public string Bcode1 { get; set; }
        [Column("facto1")]
        public double? Facto1 { get; set; }
        [Column("praxi1")]
        [StringLength(1)]
        public string Praxi1 { get; set; }
        [Column("bcode2")]
        [StringLength(25)]
        public string Bcode2 { get; set; }
        [Column("facto2")]
        public double? Facto2 { get; set; }
        [Column("praxi2")]
        [StringLength(1)]
        public string Praxi2 { get; set; }
        [Column("bcode3")]
        [StringLength(25)]
        public string Bcode3 { get; set; }
        [Column("facto3")]
        public double? Facto3 { get; set; }
        [Column("praxi3")]
        [StringLength(1)]
        public string Praxi3 { get; set; }
        [Column("bcode4")]
        [StringLength(25)]
        public string Bcode4 { get; set; }
        [Column("facto4")]
        public double? Facto4 { get; set; }
        [Column("praxi4")]
        [StringLength(1)]
        public string Praxi4 { get; set; }
        [Column("bcode5")]
        [StringLength(25)]
        public string Bcode5 { get; set; }
        [Column("facto5")]
        public double? Facto5 { get; set; }
        [Column("praxi5")]
        [StringLength(1)]
        public string Praxi5 { get; set; }
        [Column("bcode6")]
        [StringLength(25)]
        public string Bcode6 { get; set; }
        [Column("facto6")]
        public double? Facto6 { get; set; }
        [Column("praxi6")]
        [StringLength(1)]
        public string Praxi6 { get; set; }
        [Column("bcode7")]
        [StringLength(25)]
        public string Bcode7 { get; set; }
        [Column("facto7")]
        public double? Facto7 { get; set; }
        [Column("praxi7")]
        [StringLength(1)]
        public string Praxi7 { get; set; }
        [Column("bcode8")]
        [StringLength(25)]
        public string Bcode8 { get; set; }
        [Column("facto8")]
        public double? Facto8 { get; set; }
        [Column("praxi8")]
        [StringLength(1)]
        public string Praxi8 { get; set; }
        [Column("bcode9")]
        [StringLength(25)]
        public string Bcode9 { get; set; }
        [Column("facto9")]
        public double? Facto9 { get; set; }
        [Column("praxi9")]
        [StringLength(1)]
        public string Praxi9 { get; set; }
        [Column("bcode10")]
        [StringLength(25)]
        public string Bcode10 { get; set; }
        [Column("facto10")]
        public double? Facto10 { get; set; }
        [Column("praxi10")]
        [StringLength(1)]
        public string Praxi10 { get; set; }
        [Column("changeline")]
        public short? Changeline { get; set; }
        [Column("ean13")]
        public short? Ean13 { get; set; }
        [Column("ean13cl")]
        public short? Ean13cl { get; set; }
        [Column("eanquant")]
        public double? Eanquant { get; set; }
        [Column("bccode")]
        public short? Bccode { get; set; }
        [Column("bcline")]
        public short? Bcline { get; set; }
        [Column("price")]
        public double? Price { get; set; }
        [Column("quant")]
        public double? Quant { get; set; }
        [Column("praxi0")]
        [StringLength(1)]
        public string Praxi0 { get; set; }
        [Column("facto0")]
        public double? Facto0 { get; set; }
        public int? Method { get; set; }
    }
}
