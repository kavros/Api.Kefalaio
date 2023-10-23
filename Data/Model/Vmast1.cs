using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VMAST1")]
    [Index(nameof(SdChainFirst), nameof(SdChainCount), Name = "sdByChain")]
    [Index(nameof(CFileId), nameof(SdDate), nameof(SdInsDate), nameof(SdTime), Name = "sdByCust")]
    [Index(nameof(SdDate), nameof(CFileId), nameof(SdInsDate), nameof(SdTime), Name = "sdByDate")]
    [Index(nameof(SdDocum), nameof(SdChainCount), Name = "sdByDocum", IsUnique = true)]
    [Index(nameof(SdDueDate), nameof(CFileId), nameof(SdInsDate), nameof(SdTime), Name = "sdByDueDate")]
    public partial class Vmast1
    {
        public Vmast1()
        {
            Ctrns = new HashSet<Ctrn>();
            Extexts = new HashSet<Extext>();
            Strns = new HashSet<Strn>();
        }

        [Key]
        [Column("sdFileId")]
        public int SdFileId { get; set; }
        [Column("sdDate", TypeName = "datetime")]
        public DateTime SdDate { get; set; }
        [Column("cFileId")]
        public int CFileId { get; set; }
        [Required]
        [Column("sdDocum")]
        [StringLength(15)]
        public string SdDocum { get; set; }
        [Column("sdTransKind")]
        public int? SdTransKind { get; set; }
        [Column("sdTrNumsId")]
        public int? SdTrNumsId { get; set; }
        [Column("sdAddress")]
        [StringLength(29)]
        public string SdAddress { get; set; }
        [Column("sdDueDate", TypeName = "datetime")]
        public DateTime? SdDueDate { get; set; }
        [Column("sdSalesman")]
        public int? SdSalesman { get; set; }
        [Column("sdPayMode")]
        [StringLength(3)]
        public string SdPayMode { get; set; }
        [Column("sdDelivMode")]
        [StringLength(3)]
        public string SdDelivMode { get; set; }
        [Column("sdPrinted")]
        public short? SdPrinted { get; set; }
        [Column("sdStatus")]
        [StringLength(1)]
        public string SdStatus { get; set; }
        [Column("sdRelDoc")]
        [StringLength(9)]
        public string SdRelDoc { get; set; }
        [Column("sdSubsCode")]
        [StringLength(5)]
        public string SdSubsCode { get; set; }
        [Column("sdForCrncy")]
        [StringLength(3)]
        public string SdForCrncy { get; set; }
        [Column("sdCurrncy")]
        public double? SdCurrncy { get; set; }
        [Column("sdComment")]
        [StringLength(63)]
        public string SdComment { get; set; }
        [Column("sdGrossVal")]
        public double? SdGrossVal { get; set; }
        [Column("sdPerDiscnt")]
        public double? SdPerDiscnt { get; set; }
        [Column("sdDiscnt")]
        public double? SdDiscnt { get; set; }
        [Column("sdNetValue")]
        public double? SdNetValue { get; set; }
        [Column("sdExpKind1")]
        public int? SdExpKind1 { get; set; }
        [Column("sdExpenses1")]
        public double? SdExpenses1 { get; set; }
        [Column("sdExpKind2")]
        public int? SdExpKind2 { get; set; }
        [Column("sdExpenses2")]
        public double? SdExpenses2 { get; set; }
        [Column("sdVATVal")]
        public double? SdVatval { get; set; }
        [Column("sdTotVal")]
        public double? SdTotVal { get; set; }
        [Column("sdCostVal")]
        public double? SdCostVal { get; set; }
        [Column("sdCommision")]
        public double? SdCommision { get; set; }
        [Column("sdVATVl1")]
        public double? SdVatvl1 { get; set; }
        [Column("sdVATVl2")]
        public double? SdVatvl2 { get; set; }
        [Column("sdVATVl3")]
        public double? SdVatvl3 { get; set; }
        [Column("sdVATVl4")]
        public double? SdVatvl4 { get; set; }
        [Column("sdVATVl5")]
        public double? SdVatvl5 { get; set; }
        [Column("sdVATVl6")]
        public double? SdVatvl6 { get; set; }
        [Column("sdVATVl7")]
        public double? SdVatvl7 { get; set; }
        [Column("sdVATVl8")]
        public double? SdVatvl8 { get; set; }
        [Column("sdVATVl9")]
        public double? SdVatvl9 { get; set; }
        [Column("sdVATVl10")]
        public double? SdVatvl10 { get; set; }
        [Column("sdVATVl11")]
        public double? SdVatvl11 { get; set; }
        [Column("sdVATVl12")]
        public double? SdVatvl12 { get; set; }
        [Column("sdVATVl13")]
        public double? SdVatvl13 { get; set; }
        [Column("sdVATVl14")]
        public double? SdVatvl14 { get; set; }
        [Column("sdVATVl15")]
        public double? SdVatvl15 { get; set; }
        [Column("sdVATVl16")]
        public double? SdVatvl16 { get; set; }
        [Column("sdVATVl17")]
        public double? SdVatvl17 { get; set; }
        [Column("sdVATVl18")]
        public double? SdVatvl18 { get; set; }
        [Column("sdVATVl19")]
        public double? SdVatvl19 { get; set; }
        [Column("sdVATVl20")]
        public double? SdVatvl20 { get; set; }
        [Column("sdVATVl21")]
        public double? SdVatvl21 { get; set; }
        [Column("sdVATVl22")]
        public double? SdVatvl22 { get; set; }
        [Column("sdVATVl23")]
        public double? SdVatvl23 { get; set; }
        [Column("sdVATVl24")]
        public double? SdVatvl24 { get; set; }
        [Column("sdVATVl25")]
        public double? SdVatvl25 { get; set; }
        [Column("sdVATVl26")]
        public double? SdVatvl26 { get; set; }
        [Column("sdVATVl27")]
        public double? SdVatvl27 { get; set; }
        [Column("sdVATVl28")]
        public double? SdVatvl28 { get; set; }
        [Column("sdVATVl29")]
        public double? SdVatvl29 { get; set; }
        [Column("sdVATVl30")]
        public double? SdVatvl30 { get; set; }
        [Column("sdVATVl31")]
        public double? SdVatvl31 { get; set; }
        [Column("sdVATVl32")]
        public double? SdVatvl32 { get; set; }
        [Column("sdVATVl33")]
        public double? SdVatvl33 { get; set; }
        [Column("sdVATVl34")]
        public double? SdVatvl34 { get; set; }
        [Column("sdVATVl35")]
        public double? SdVatvl35 { get; set; }
        [Column("sdVATVl36")]
        public double? SdVatvl36 { get; set; }
        [Column("sdVATVl37")]
        public double? SdVatvl37 { get; set; }
        [Column("sdVATVl38")]
        public double? SdVatvl38 { get; set; }
        [Column("sdVATVl39")]
        public double? SdVatvl39 { get; set; }
        [Column("sdVATVl40")]
        public double? SdVatvl40 { get; set; }
        [Column("sdVlPrVAT1")]
        public double? SdVlPrVat1 { get; set; }
        [Column("sdVlPrVAT2")]
        public double? SdVlPrVat2 { get; set; }
        [Column("sdVlPrVAT3")]
        public double? SdVlPrVat3 { get; set; }
        [Column("sdVlPrVAT4")]
        public double? SdVlPrVat4 { get; set; }
        [Column("sdVlPrVAT5")]
        public double? SdVlPrVat5 { get; set; }
        [Column("sdVlPrVAT6")]
        public double? SdVlPrVat6 { get; set; }
        [Column("sdVlPrVAT7")]
        public double? SdVlPrVat7 { get; set; }
        [Column("sdVlPrVAT8")]
        public double? SdVlPrVat8 { get; set; }
        [Column("sdVlPrVAT9")]
        public double? SdVlPrVat9 { get; set; }
        [Column("sdVlPrVAT10")]
        public double? SdVlPrVat10 { get; set; }
        [Column("sdVlPrVAT11")]
        public double? SdVlPrVat11 { get; set; }
        [Column("sdVlPrVAT12")]
        public double? SdVlPrVat12 { get; set; }
        [Column("sdVlPrVAT13")]
        public double? SdVlPrVat13 { get; set; }
        [Column("sdVlPrVAT14")]
        public double? SdVlPrVat14 { get; set; }
        [Column("sdVlPrVAT15")]
        public double? SdVlPrVat15 { get; set; }
        [Column("sdVlPrVAT16")]
        public double? SdVlPrVat16 { get; set; }
        [Column("sdVlPrVAT17")]
        public double? SdVlPrVat17 { get; set; }
        [Column("sdVlPrVAT18")]
        public double? SdVlPrVat18 { get; set; }
        [Column("sdVlPrVAT19")]
        public double? SdVlPrVat19 { get; set; }
        [Column("sdVlPrVAT20")]
        public double? SdVlPrVat20 { get; set; }
        [Column("sdVlPrVAT21")]
        public double? SdVlPrVat21 { get; set; }
        [Column("sdVlPrVAT22")]
        public double? SdVlPrVat22 { get; set; }
        [Column("sdVlPrVAT23")]
        public double? SdVlPrVat23 { get; set; }
        [Column("sdVlPrVAT24")]
        public double? SdVlPrVat24 { get; set; }
        [Column("sdVlPrVAT25")]
        public double? SdVlPrVat25 { get; set; }
        [Column("sdVlPrVAT26")]
        public double? SdVlPrVat26 { get; set; }
        [Column("sdVlPrVAT27")]
        public double? SdVlPrVat27 { get; set; }
        [Column("sdVlPrVAT28")]
        public double? SdVlPrVat28 { get; set; }
        [Column("sdVlPrVAT29")]
        public double? SdVlPrVat29 { get; set; }
        [Column("sdVlPrVAT30")]
        public double? SdVlPrVat30 { get; set; }
        [Column("sdVlPrVAT31")]
        public double? SdVlPrVat31 { get; set; }
        [Column("sdVlPrVAT32")]
        public double? SdVlPrVat32 { get; set; }
        [Column("sdVlPrVAT33")]
        public double? SdVlPrVat33 { get; set; }
        [Column("sdVlPrVAT34")]
        public double? SdVlPrVat34 { get; set; }
        [Column("sdVlPrVAT35")]
        public double? SdVlPrVat35 { get; set; }
        [Column("sdVlPrVAT36")]
        public double? SdVlPrVat36 { get; set; }
        [Column("sdVlPrVAT37")]
        public double? SdVlPrVat37 { get; set; }
        [Column("sdVlPrVAT38")]
        public double? SdVlPrVat38 { get; set; }
        [Column("sdVlPrVAT39")]
        public double? SdVlPrVat39 { get; set; }
        [Column("sdVlPrVAT40")]
        public double? SdVlPrVat40 { get; set; }
        [Column("sdCovered")]
        public double? SdCovered { get; set; }
        [Column("sdPayIds1")]
        public int? SdPayIds1 { get; set; }
        [Column("sdPayIds2")]
        public int? SdPayIds2 { get; set; }
        [Column("sdPayIds3")]
        public int? SdPayIds3 { get; set; }
        [Column("sdPayIds4")]
        public int? SdPayIds4 { get; set; }
        [Column("sdPayIds5")]
        public int? SdPayIds5 { get; set; }
        [Column("sdNonVAT")]
        public short? SdNonVat { get; set; }
        [Column("sdTrading")]
        public int? SdTrading { get; set; }
        [Column("sdLocation")]
        public int? SdLocation { get; set; }
        [Column("sdEECCrncy")]
        public double? SdEeccrncy { get; set; }
        [Column("sdCountry")]
        [StringLength(3)]
        public string SdCountry { get; set; }
        [Column("sdEECKind")]
        [StringLength(3)]
        public string SdEeckind { get; set; }
        [Column("sdEECDeliv")]
        [StringLength(3)]
        public string SdEecdeliv { get; set; }
        [Column("sdText")]
        [StringLength(192)]
        public string SdText { get; set; }
        [Column("sdInsDate", TypeName = "datetime")]
        public DateTime? SdInsDate { get; set; }
        [Column("sdUserId")]
        public int? SdUserId { get; set; }
        [Column("sdSentToId")]
        public int? SdSentToId { get; set; }
        [Column("sdTime", TypeName = "datetime")]
        public DateTime? SdTime { get; set; }
        [Column("sdFromFile")]
        public int? SdFromFile { get; set; }
        [Column("sdFromId")]
        public int? SdFromId { get; set; }
        [Column("sdToFile")]
        public int? SdToFile { get; set; }
        [Column("sdToId")]
        public int? SdToId { get; set; }
        [Column("sdEECExp")]
        public double? SdEecexp { get; set; }
        [Column("sdConvFrom", TypeName = "datetime")]
        public DateTime? SdConvFrom { get; set; }
        [Column("sdConvTo", TypeName = "datetime")]
        public DateTime? SdConvTo { get; set; }
        [Column("sdEECDate", TypeName = "datetime")]
        public DateTime? SdEecdate { get; set; }
        [Column("sdGLUpdated")]
        public short? SdGlupdated { get; set; }
        [Column("sdEDISent")]
        public short? SdEdisent { get; set; }
        [Column("sdEDICode")]
        [StringLength(15)]
        public string SdEdicode { get; set; }
        [Column("sdTotEta")]
        public double? SdTotEta { get; set; }
        [Column("sdVehicle")]
        [StringLength(19)]
        public string SdVehicle { get; set; }
        [Column("sdGrossWeight")]
        public double? SdGrossWeight { get; set; }
        [Column("sdDeadWeight")]
        public double? SdDeadWeight { get; set; }
        [Column("sdReceivable")]
        public double? SdReceivable { get; set; }
        public int? CreditFlag { get; set; }
        public int? DebitFlag { get; set; }
        public int? SalesFlag { get; set; }
        [StringLength(64)]
        public string FlagsSet { get; set; }
        [Column("sdTextHandle")]
        public int? SdTextHandle { get; set; }
        [Column("vPointsMode")]
        public int? VPointsMode { get; set; }
        [Column("sdChainFirst")]
        public int? SdChainFirst { get; set; }
        [Column("sdChainCount")]
        public int? SdChainCount { get; set; }
        [Column("sdTaxCard")]
        [StringLength(19)]
        public string SdTaxCard { get; set; }
        [Column("sdNoFpaLaws")]
        public int? SdNoFpaLaws { get; set; }
        [Column("sdIntraTransType")]
        public int? SdIntraTransType { get; set; }
        [Column("sdSentToShop")]
        [StringLength(5)]
        public string SdSentToShop { get; set; }
        [Column("sdFytaStatus")]
        public int? SdFytaStatus { get; set; }
        [Column("sdAFM")]
        [StringLength(15)]
        public string SdAfm { get; set; }
        [Column("sdTaxAgentSign")]
        [StringLength(81)]
        public string SdTaxAgentSign { get; set; }
        [Column("sdTaxAgentCopiesSign1")]
        [StringLength(81)]
        public string SdTaxAgentCopiesSign1 { get; set; }
        [Column("sdTaxAgentCopiesSign2")]
        [StringLength(81)]
        public string SdTaxAgentCopiesSign2 { get; set; }
        [Column("sdTaxAgentCopiesSign3")]
        [StringLength(81)]
        public string SdTaxAgentCopiesSign3 { get; set; }
        [Column("sdTaxAgentCopiesSign4")]
        [StringLength(81)]
        public string SdTaxAgentCopiesSign4 { get; set; }
        [Column("sdLinesPos", TypeName = "text")]
        public string SdLinesPos { get; set; }

        [ForeignKey(nameof(SdTrNumsId))]
        [InverseProperty(nameof(Trnum.Vmast1s))]
        public virtual Trnum SdTrNums { get; set; }
        [InverseProperty(nameof(Ctrn.CtVm1originNavigation))]
        public virtual ICollection<Ctrn> Ctrns { get; set; }
        [InverseProperty(nameof(Extext.SdFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
        [InverseProperty(nameof(Strn.StVm1originNavigation))]
        public virtual ICollection<Strn> Strns { get; set; }
    }
}
