using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NETRN")]
    [Index(nameof(NetrnDate), nameof(NetrnTime), Name = "netrnByDate")]
    [Index(nameof(NetrnGetDoc), nameof(NetrnLine), Name = "netrnByDoc")]
    [Index(nameof(NetrnemPos), nameof(NetrnDate), nameof(NetrnTime), Name = "netrnByEmPos")]
    [Index(nameof(NetrnemPos), nameof(NetrnDate), nameof(NetrnInsda), nameof(NetrnTime), Name = "netrnByEmPos2")]
    [Index(nameof(NetrnNelmPos), nameof(NetrnLine), Name = "netrnByNelmPos")]
    [Index(nameof(NetrnowType), nameof(NetrncpPos), Name = "netrnByOwType")]
    [Index(nameof(NetrnDate), nameof(NetrnType), Name = "netrnByType")]
    public partial class Netrn
    {
        [Key]
        [Column("netFileId")]
        public int NetFileId { get; set; }
        [Column("netrnDate", TypeName = "datetime")]
        public DateTime NetrnDate { get; set; }
        [Column("netrnemPos")]
        public int NetrnemPos { get; set; }
        [Column("netrnKind")]
        public int? NetrnKind { get; set; }
        [Column("netrnGetDoc")]
        [StringLength(9)]
        public string NetrnGetDoc { get; set; }
        [Column("netrnLine")]
        public int? NetrnLine { get; set; }
        [Column("netrnexn")]
        [StringLength(3)]
        public string Netrnexn { get; set; }
        [Column("netrnexnAma")]
        public double? NetrnexnAma { get; set; }
        [Column("netrnAmoun1")]
        public double? NetrnAmoun1 { get; set; }
        [Column("netrnAmount")]
        public double? NetrnAmount { get; set; }
        [Column("netrnComme")]
        [StringLength(39)]
        public string NetrnComme { get; set; }
        [Column("netrnComme1")]
        [StringLength(39)]
        public string NetrnComme1 { get; set; }
        [Column("netrnowType")]
        public int? NetrnowType { get; set; }
        [Column("netrnThrdName")]
        [StringLength(39)]
        public string NetrnThrdName { get; set; }
        [Column("netrnThrdAddr")]
        [StringLength(29)]
        public string NetrnThrdAddr { get; set; }
        [Column("netrnThrdTel")]
        [StringLength(19)]
        public string NetrnThrdTel { get; set; }
        [Column("netrnThrdVATNo")]
        [StringLength(15)]
        public string NetrnThrdVatno { get; set; }
        [Column("netGtUpdate")]
        public int? NetGtUpdate { get; set; }
        [Column("netrn_Flag1")]
        public int? NetrnFlag1 { get; set; }
        [Column("netrn_Flag2")]
        public int? NetrnFlag2 { get; set; }
        [Column("netrn_Flag3")]
        public int? NetrnFlag3 { get; set; }
        [Column("netrncpPos")]
        public int? NetrncpPos { get; set; }
        [Column("netrtrmPos")]
        public int? NetrtrmPos { get; set; }
        [Column("netrntrowP")]
        public int? NetrntrowP { get; set; }
        [Column("netrnGlDeb")]
        [StringLength(25)]
        public string NetrnGlDeb { get; set; }
        [Column("netrnGlCred")]
        [StringLength(25)]
        public string NetrnGlCred { get; set; }
        [Column("netrnTime", TypeName = "datetime")]
        public DateTime? NetrnTime { get; set; }
        [Column("netrnInsda", TypeName = "datetime")]
        public DateTime? NetrnInsda { get; set; }
        [Column("netrnId")]
        public int? NetrnId { get; set; }
        [Column("netrnStatus")]
        public int? NetrnStatus { get; set; }
        [Column("netrnPrinted")]
        public short? NetrnPrinted { get; set; }
        [Column("netrnNelmPos")]
        public int? NetrnNelmPos { get; set; }
        [Column("netrnShop")]
        [StringLength(5)]
        public string NetrnShop { get; set; }
        [Column("netrnType")]
        public int? NetrnType { get; set; }
    }
}
