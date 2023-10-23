using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SCPPRIC")]
    [Index(nameof(ScpcpFileId), nameof(ScpMode), nameof(ScpItemCode), Name = "scpByItemCode")]
    [Index(nameof(ScpcpFileId), nameof(ScpMode), nameof(ScpsFileId), Name = "scpBycpFileId")]
    [Index(nameof(ScpsFileId), nameof(ScpMode), nameof(ScpcpFileId), Name = "scpBysFileId")]
    public partial class Scppric
    {
        [Key]
        [Column("scpFileId")]
        public int ScpFileId { get; set; }
        [Column("scpsFileId")]
        public int ScpsFileId { get; set; }
        [Column("scpcpFileId")]
        public int? ScpcpFileId { get; set; }
        [Column("scpMode")]
        public int? ScpMode { get; set; }
        [Column("scpPrice")]
        public double? ScpPrice { get; set; }
        [Column("scpFC")]
        [StringLength(3)]
        public string ScpFc { get; set; }
        [Column("scpMinQuant")]
        public double? ScpMinQuant { get; set; }
        [Column("scpLeadTime")]
        public int? ScpLeadTime { get; set; }
        [Column("scpItemCode")]
        [StringLength(15)]
        public string ScpItemCode { get; set; }
        [Column("scpMinDate", TypeName = "datetime")]
        public DateTime? ScpMinDate { get; set; }
        [Column("scpRtlPrice")]
        public double? ScpRtlPrice { get; set; }
        [Column("scpDiscount")]
        public double? ScpDiscount { get; set; }
        [Column("scpDiscVal")]
        public double? ScpDiscVal { get; set; }
        [Column("scpExclusive")]
        public short? ScpExclusive { get; set; }
        [Column("scpDiscount2")]
        public double? ScpDiscount2 { get; set; }
        [Column("scpComment")]
        [StringLength(39)]
        public string ScpComment { get; set; }
        [Column("cFileId")]
        public int? CFileId { get; set; }
        [Column("pFileId")]
        public int? PFileId { get; set; }
    }
}
