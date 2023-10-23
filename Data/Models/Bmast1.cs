using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BMAST1")]
    [Index(nameof(PdChainFirst), nameof(PdChainCount), Name = "pdByChain")]
    [Index(nameof(PdDate), nameof(PFileId), nameof(PdInsDate), nameof(PdTime), Name = "pdByDate")]
    [Index(nameof(PdDocum), nameof(PdChainCount), Name = "pdByDocum")]
    [Index(nameof(PdDueDate), nameof(PFileId), nameof(PdInsDate), nameof(PdTime), Name = "pdByDueDate")]
    [Index(nameof(PFileId), nameof(PdDate), nameof(PdInsDate), nameof(PdTime), Name = "pdBySupl")]
    public partial class Bmast1
    {
        public Bmast1()
        {
            Extexts = new HashSet<Extext>();
            Ptrns = new HashSet<Ptrn>();
            Strns = new HashSet<Strn>();
        }

        [Key]
        [Column("pdFileId")]
        public int PdFileId { get; set; }
        [Column("pdDate", TypeName = "datetime")]
        public DateTime PdDate { get; set; }
        [Column("pFileId")]
        public int PFileId { get; set; }
        [Column("pdDocum")]
        [StringLength(15)]
        public string PdDocum { get; set; }
        [Column("pdTransKind")]
        public int? PdTransKind { get; set; }
        [Column("pdTrNumsId")]
        public int? PdTrNumsId { get; set; }
        [Column("pdAddress")]
        [StringLength(29)]
        public string PdAddress { get; set; }
        [Column("pdDueDate", TypeName = "datetime")]
        public DateTime? PdDueDate { get; set; }
        [Column("pdSalesman")]
        public int? PdSalesman { get; set; }
        [Column("pdPayMode")]
        [StringLength(3)]
        public string PdPayMode { get; set; }
        [Column("pdDelivMode")]
        [StringLength(3)]
        public string PdDelivMode { get; set; }
        [Column("pdPrinted")]
        public short? PdPrinted { get; set; }
        [Column("pdStatus")]
        [StringLength(1)]
        public string PdStatus { get; set; }
        [Column("pdRelDoc")]
        [StringLength(9)]
        public string PdRelDoc { get; set; }
        [Column("pdSubsCode")]
        [StringLength(5)]
        public string PdSubsCode { get; set; }
        [Column("pdForCrncy")]
        [StringLength(3)]
        public string PdForCrncy { get; set; }
        [Column("pdCurrncy")]
        public double? PdCurrncy { get; set; }
        [Column("pdComment")]
        [StringLength(63)]
        public string PdComment { get; set; }
        [Column("pdGrossVal")]
        public double? PdGrossVal { get; set; }
        [Column("pdPerDiscnt")]
        public double? PdPerDiscnt { get; set; }
        [Column("pdDiscnt")]
        public double? PdDiscnt { get; set; }
        [Column("pdNetValue")]
        public double? PdNetValue { get; set; }
        [Column("pdExpKind1")]
        public int? PdExpKind1 { get; set; }
        [Column("pdExpenses1")]
        public double? PdExpenses1 { get; set; }
        [Column("pdExpKind2")]
        public int? PdExpKind2 { get; set; }
        [Column("pdExpenses2")]
        public double? PdExpenses2 { get; set; }
        [Column("pdVATVal")]
        public double? PdVatval { get; set; }
        [Column("pdTotVal")]
        public double? PdTotVal { get; set; }
        [Column("pdCostVal")]
        public double? PdCostVal { get; set; }
        [Column("pdCommision")]
        public double? PdCommision { get; set; }
        [Column("pdVATVl1")]
        public double? PdVatvl1 { get; set; }
        [Column("pdVATVl2")]
        public double? PdVatvl2 { get; set; }
        [Column("pdVATVl3")]
        public double? PdVatvl3 { get; set; }
        [Column("pdVATVl4")]
        public double? PdVatvl4 { get; set; }
        [Column("pdVATVl5")]
        public double? PdVatvl5 { get; set; }
        [Column("pdVATVl6")]
        public double? PdVatvl6 { get; set; }
        [Column("pdVATVl7")]
        public double? PdVatvl7 { get; set; }
        [Column("pdVATVl8")]
        public double? PdVatvl8 { get; set; }
        [Column("pdVATVl9")]
        public double? PdVatvl9 { get; set; }
        [Column("pdVATVl10")]
        public double? PdVatvl10 { get; set; }
        [Column("pdVATVl11")]
        public double? PdVatvl11 { get; set; }
        [Column("pdVATVl12")]
        public double? PdVatvl12 { get; set; }
        [Column("pdVATVl13")]
        public double? PdVatvl13 { get; set; }
        [Column("pdVATVl14")]
        public double? PdVatvl14 { get; set; }
        [Column("pdVATVl15")]
        public double? PdVatvl15 { get; set; }
        [Column("pdVATVl16")]
        public double? PdVatvl16 { get; set; }
        [Column("pdVATVl17")]
        public double? PdVatvl17 { get; set; }
        [Column("pdVATVl18")]
        public double? PdVatvl18 { get; set; }
        [Column("pdVATVl19")]
        public double? PdVatvl19 { get; set; }
        [Column("pdVATVl20")]
        public double? PdVatvl20 { get; set; }
        [Column("pdVATVl21")]
        public double? PdVatvl21 { get; set; }
        [Column("pdVATVl22")]
        public double? PdVatvl22 { get; set; }
        [Column("pdVATVl23")]
        public double? PdVatvl23 { get; set; }
        [Column("pdVATVl24")]
        public double? PdVatvl24 { get; set; }
        [Column("pdVATVl25")]
        public double? PdVatvl25 { get; set; }
        [Column("pdVATVl26")]
        public double? PdVatvl26 { get; set; }
        [Column("pdVATVl27")]
        public double? PdVatvl27 { get; set; }
        [Column("pdVATVl28")]
        public double? PdVatvl28 { get; set; }
        [Column("pdVATVl29")]
        public double? PdVatvl29 { get; set; }
        [Column("pdVATVl30")]
        public double? PdVatvl30 { get; set; }
        [Column("pdVATVl31")]
        public double? PdVatvl31 { get; set; }
        [Column("pdVATVl32")]
        public double? PdVatvl32 { get; set; }
        [Column("pdVATVl33")]
        public double? PdVatvl33 { get; set; }
        [Column("pdVATVl34")]
        public double? PdVatvl34 { get; set; }
        [Column("pdVATVl35")]
        public double? PdVatvl35 { get; set; }
        [Column("pdVATVl36")]
        public double? PdVatvl36 { get; set; }
        [Column("pdVATVl37")]
        public double? PdVatvl37 { get; set; }
        [Column("pdVATVl38")]
        public double? PdVatvl38 { get; set; }
        [Column("pdVATVl39")]
        public double? PdVatvl39 { get; set; }
        [Column("pdVATVl40")]
        public double? PdVatvl40 { get; set; }
        [Column("pdVlPrVAT1")]
        public double? PdVlPrVat1 { get; set; }
        [Column("pdVlPrVAT2")]
        public double? PdVlPrVat2 { get; set; }
        [Column("pdVlPrVAT3")]
        public double? PdVlPrVat3 { get; set; }
        [Column("pdVlPrVAT4")]
        public double? PdVlPrVat4 { get; set; }
        [Column("pdVlPrVAT5")]
        public double? PdVlPrVat5 { get; set; }
        [Column("pdVlPrVAT6")]
        public double? PdVlPrVat6 { get; set; }
        [Column("pdVlPrVAT7")]
        public double? PdVlPrVat7 { get; set; }
        [Column("pdVlPrVAT8")]
        public double? PdVlPrVat8 { get; set; }
        [Column("pdVlPrVAT9")]
        public double? PdVlPrVat9 { get; set; }
        [Column("pdVlPrVAT10")]
        public double? PdVlPrVat10 { get; set; }
        [Column("pdVlPrVAT11")]
        public double? PdVlPrVat11 { get; set; }
        [Column("pdVlPrVAT12")]
        public double? PdVlPrVat12 { get; set; }
        [Column("pdVlPrVAT13")]
        public double? PdVlPrVat13 { get; set; }
        [Column("pdVlPrVAT14")]
        public double? PdVlPrVat14 { get; set; }
        [Column("pdVlPrVAT15")]
        public double? PdVlPrVat15 { get; set; }
        [Column("pdVlPrVAT16")]
        public double? PdVlPrVat16 { get; set; }
        [Column("pdVlPrVAT17")]
        public double? PdVlPrVat17 { get; set; }
        [Column("pdVlPrVAT18")]
        public double? PdVlPrVat18 { get; set; }
        [Column("pdVlPrVAT19")]
        public double? PdVlPrVat19 { get; set; }
        [Column("pdVlPrVAT20")]
        public double? PdVlPrVat20 { get; set; }
        [Column("pdVlPrVAT21")]
        public double? PdVlPrVat21 { get; set; }
        [Column("pdVlPrVAT22")]
        public double? PdVlPrVat22 { get; set; }
        [Column("pdVlPrVAT23")]
        public double? PdVlPrVat23 { get; set; }
        [Column("pdVlPrVAT24")]
        public double? PdVlPrVat24 { get; set; }
        [Column("pdVlPrVAT25")]
        public double? PdVlPrVat25 { get; set; }
        [Column("pdVlPrVAT26")]
        public double? PdVlPrVat26 { get; set; }
        [Column("pdVlPrVAT27")]
        public double? PdVlPrVat27 { get; set; }
        [Column("pdVlPrVAT28")]
        public double? PdVlPrVat28 { get; set; }
        [Column("pdVlPrVAT29")]
        public double? PdVlPrVat29 { get; set; }
        [Column("pdVlPrVAT30")]
        public double? PdVlPrVat30 { get; set; }
        [Column("pdVlPrVAT31")]
        public double? PdVlPrVat31 { get; set; }
        [Column("pdVlPrVAT32")]
        public double? PdVlPrVat32 { get; set; }
        [Column("pdVlPrVAT33")]
        public double? PdVlPrVat33 { get; set; }
        [Column("pdVlPrVAT34")]
        public double? PdVlPrVat34 { get; set; }
        [Column("pdVlPrVAT35")]
        public double? PdVlPrVat35 { get; set; }
        [Column("pdVlPrVAT36")]
        public double? PdVlPrVat36 { get; set; }
        [Column("pdVlPrVAT37")]
        public double? PdVlPrVat37 { get; set; }
        [Column("pdVlPrVAT38")]
        public double? PdVlPrVat38 { get; set; }
        [Column("pdVlPrVAT39")]
        public double? PdVlPrVat39 { get; set; }
        [Column("pdVlPrVAT40")]
        public double? PdVlPrVat40 { get; set; }
        [Column("pdCovered")]
        public double? PdCovered { get; set; }
        [Column("pdPayIds1")]
        public int? PdPayIds1 { get; set; }
        [Column("pdPayIds2")]
        public int? PdPayIds2 { get; set; }
        [Column("pdPayIds3")]
        public int? PdPayIds3 { get; set; }
        [Column("pdPayIds4")]
        public int? PdPayIds4 { get; set; }
        [Column("pdPayIds5")]
        public int? PdPayIds5 { get; set; }
        [Column("pdNonVAT")]
        public short? PdNonVat { get; set; }
        [Column("pdTrading")]
        public int? PdTrading { get; set; }
        [Column("pdLocation")]
        public int? PdLocation { get; set; }
        [Column("pdEECCrncy")]
        public double? PdEeccrncy { get; set; }
        [Column("pdCountry")]
        [StringLength(3)]
        public string PdCountry { get; set; }
        [Column("pdEECKind")]
        [StringLength(3)]
        public string PdEeckind { get; set; }
        [Column("pdEECDeliv")]
        [StringLength(3)]
        public string PdEecdeliv { get; set; }
        [Column("pdText")]
        [StringLength(192)]
        public string PdText { get; set; }
        [Column("pdInsDate", TypeName = "datetime")]
        public DateTime? PdInsDate { get; set; }
        [Column("pdUserId")]
        public int? PdUserId { get; set; }
        [Column("pdSentToId")]
        public int? PdSentToId { get; set; }
        [Column("pdTime", TypeName = "datetime")]
        public DateTime? PdTime { get; set; }
        [Column("pdFromFile")]
        public int? PdFromFile { get; set; }
        [Column("pdFromId")]
        public int? PdFromId { get; set; }
        [Column("pdToFile")]
        public int? PdToFile { get; set; }
        [Column("pdToId")]
        public int? PdToId { get; set; }
        [Column("pdEECExp")]
        public double? PdEecexp { get; set; }
        [Column("pdConvFrom", TypeName = "datetime")]
        public DateTime? PdConvFrom { get; set; }
        [Column("pdConvTo", TypeName = "datetime")]
        public DateTime? PdConvTo { get; set; }
        [Column("pdEECDate", TypeName = "datetime")]
        public DateTime? PdEecdate { get; set; }
        [Column("pdGLUpdated")]
        public short? PdGlupdated { get; set; }
        [Column("pdEDISent")]
        public short? PdEdisent { get; set; }
        [Column("pdEDICode")]
        [StringLength(15)]
        public string PdEdicode { get; set; }
        [Column("pdTotEta")]
        public double? PdTotEta { get; set; }
        [Column("pdVehicle")]
        [StringLength(19)]
        public string PdVehicle { get; set; }
        [Column("pdGrossWeight")]
        public double? PdGrossWeight { get; set; }
        [Column("pdDeadWeight")]
        public double? PdDeadWeight { get; set; }
        [Column("pdReceivable")]
        public double? PdReceivable { get; set; }
        public int? CreditFlag { get; set; }
        public int? DebitFlag { get; set; }
        public int? SalesFlag { get; set; }
        [StringLength(64)]
        public string FlagsSet { get; set; }
        [Column("pdTextHandle")]
        public int? PdTextHandle { get; set; }
        [Column("pdPointsMode")]
        public int? PdPointsMode { get; set; }
        [Column("pdChainFirst")]
        public int? PdChainFirst { get; set; }
        [Column("pdChainCount")]
        public int? PdChainCount { get; set; }
        [Column("pdTaxCard")]
        [StringLength(19)]
        public string PdTaxCard { get; set; }
        [Column("pdNoFpaLaws")]
        public int? PdNoFpaLaws { get; set; }
        [Column("pdIntraTransType")]
        public int? PdIntraTransType { get; set; }
        [Column("pdSentToShop")]
        [StringLength(5)]
        public string PdSentToShop { get; set; }
        [Column("pdFytaStatus")]
        public int? PdFytaStatus { get; set; }
        [Column("pdAFM")]
        [StringLength(15)]
        public string PdAfm { get; set; }
        [Column("pdTaxAgentSign")]
        [StringLength(81)]
        public string PdTaxAgentSign { get; set; }
        [Column("pdTaxAgentCopiesSign1")]
        [StringLength(81)]
        public string PdTaxAgentCopiesSign1 { get; set; }
        [Column("pdTaxAgentCopiesSign2")]
        [StringLength(81)]
        public string PdTaxAgentCopiesSign2 { get; set; }
        [Column("pdTaxAgentCopiesSign3")]
        [StringLength(81)]
        public string PdTaxAgentCopiesSign3 { get; set; }
        [Column("pdTaxAgentCopiesSign4")]
        [StringLength(81)]
        public string PdTaxAgentCopiesSign4 { get; set; }
        [Column("pdDetailFile", TypeName = "text")]
        public string PdDetailFile { get; set; }

        [ForeignKey(nameof(PdTrNumsId))]
        [InverseProperty(nameof(Trnum.Bmast1s))]
        public virtual Trnum PdTrNums { get; set; }
        [InverseProperty(nameof(Extext.PdFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
        [InverseProperty(nameof(Ptrn.PtBm1originNavigation))]
        public virtual ICollection<Ptrn> Ptrns { get; set; }
        [InverseProperty(nameof(Strn.StBm1originNavigation))]
        public virtual ICollection<Strn> Strns { get; set; }
    }
}
