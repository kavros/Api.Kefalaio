using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TRADE")]
    public partial class Trade
    {
        [Key]
        [Column("REC_ID")]
        public int RecId { get; set; }
        [Column("RECSTATUS")]
        public int? Recstatus { get; set; }
        [Column("RECSTATUSDESCR")]
        [StringLength(255)]
        public string Recstatusdescr { get; set; }
        [Column("RECPOSITION")]
        public int? Recposition { get; set; }
        public int? TrdFileType { get; set; }
        public int? TrdSpecialEvent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrdDate { get; set; }
        [StringLength(15)]
        public string TrdcCode { get; set; }
        [StringLength(15)]
        public string TrdDocum { get; set; }
        [StringLength(29)]
        public string TrdAddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrdDueDate { get; set; }
        [StringLength(15)]
        public string TrdSalesmanCode { get; set; }
        [StringLength(3)]
        public string TrdPayMode { get; set; }
        [StringLength(3)]
        public string TrdDelivMode { get; set; }
        public short? TrdPrinted { get; set; }
        [StringLength(1)]
        public string TrdStatus { get; set; }
        [StringLength(9)]
        public string TrdRelDoc { get; set; }
        [StringLength(5)]
        public string TrdSubsCode { get; set; }
        [StringLength(3)]
        public string TrdForCrncy { get; set; }
        public double? TrdCurrncy { get; set; }
        [StringLength(63)]
        public string TrdComment { get; set; }
        public double? TrdPerDiscnt { get; set; }
        public int? TrdExpKind1 { get; set; }
        public double? TrdExpenses1 { get; set; }
        public int? TrdExpKind2 { get; set; }
        public double? TrdExpenses2 { get; set; }
        [Column("TrdNonVAT")]
        public short? TrdNonVat { get; set; }
        public int? TrdTradingCode { get; set; }
        public int? TrdLocation { get; set; }
        [StringLength(3)]
        public string TrdCountry { get; set; }
        [StringLength(64)]
        public string TrdText1 { get; set; }
        [StringLength(64)]
        public string TrdText2 { get; set; }
        [StringLength(64)]
        public string TrdText3 { get; set; }
        [StringLength(64)]
        public string TrdText4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrdInsDate { get; set; }
        public int? TrdUserId { get; set; }
        [StringLength(15)]
        public string TrdSendToCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrdTime { get; set; }
        [Column("TrdGLUpdated")]
        public short? TrdGlupdated { get; set; }
        public int? TrdCpKind1 { get; set; }
        public int? TrdCpKind2 { get; set; }
        public int? TrdCpKind3 { get; set; }
        public int? TrdCpKind4 { get; set; }
        public double? TrdCpVal1 { get; set; }
        public double? TrdCpVal2 { get; set; }
        public double? TrdCpVal3 { get; set; }
        public double? TrdCpVal4 { get; set; }
        public double? TrdIntrastatVal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrdIntrastatDate { get; set; }
        public double? TrdGrossWeight { get; set; }
        public double? TrdDeadWeight { get; set; }
        public int? TrdDoPrint { get; set; }
        [StringLength(11)]
        public string TrdVehicle { get; set; }
        [Column("TrdVDiscnt")]
        public double? TrdVdiscnt { get; set; }
    }
}
