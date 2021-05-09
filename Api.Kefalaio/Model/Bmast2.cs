using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BMAST2")]
    [Index(nameof(PoChainFirst), nameof(PoChainCount), Name = "pofxByChain")]
    [Index(nameof(PoDate), nameof(PFileId), nameof(PoInsDate), nameof(PoTime), Name = "pofxByDate")]
    [Index(nameof(PoDocum), nameof(PoChainCount), Name = "pofxByDocum")]
    [Index(nameof(PoDueDate), nameof(PFileId), nameof(PoInsDate), nameof(PoTime), Name = "pofxByDueDate")]
    [Index(nameof(PFileId), nameof(PoDate), nameof(PoInsDate), nameof(PoTime), Name = "pofxBySupl")]
    public partial class Bmast2
    {
        public Bmast2()
        {
            Extexts = new HashSet<Extext>();
            Ptrns = new HashSet<Ptrn>();
        }

        [Key]
        [Column("poFileId")]
        public int PoFileId { get; set; }
        [Column("poDate", TypeName = "datetime")]
        public DateTime PoDate { get; set; }
        [Column("pFileId")]
        public int PFileId { get; set; }
        [Column("poDocum")]
        [StringLength(15)]
        public string PoDocum { get; set; }
        [Column("poTransKind")]
        public int? PoTransKind { get; set; }
        [Column("poTrNumsId")]
        public int? PoTrNumsId { get; set; }
        [Column("poAddress")]
        [StringLength(29)]
        public string PoAddress { get; set; }
        [Column("poDueDate", TypeName = "datetime")]
        public DateTime? PoDueDate { get; set; }
        [Column("poSalesman")]
        public int? PoSalesman { get; set; }
        [Column("poPayMode")]
        [StringLength(3)]
        public string PoPayMode { get; set; }
        [Column("poDelivMode")]
        [StringLength(3)]
        public string PoDelivMode { get; set; }
        [Column("poPrinted")]
        public short? PoPrinted { get; set; }
        [Column("poStatus")]
        [StringLength(1)]
        public string PoStatus { get; set; }
        [Column("poRelDoc")]
        [StringLength(9)]
        public string PoRelDoc { get; set; }
        [Column("poSubsCode")]
        [StringLength(5)]
        public string PoSubsCode { get; set; }
        [Column("poForCrncy")]
        [StringLength(3)]
        public string PoForCrncy { get; set; }
        [Column("poCurrncy")]
        public double? PoCurrncy { get; set; }
        [Column("poComment")]
        [StringLength(63)]
        public string PoComment { get; set; }
        [Column("poGrossVal")]
        public double? PoGrossVal { get; set; }
        [Column("poPerDiscnt")]
        public double? PoPerDiscnt { get; set; }
        [Column("poDiscnt")]
        public double? PoDiscnt { get; set; }
        [Column("poNetValue")]
        public double? PoNetValue { get; set; }
        [Column("poExpKind1")]
        public int? PoExpKind1 { get; set; }
        [Column("poExpenses1")]
        public double? PoExpenses1 { get; set; }
        [Column("poExpKind2")]
        public int? PoExpKind2 { get; set; }
        [Column("poExpenses2")]
        public double? PoExpenses2 { get; set; }
        [Column("poVATVal")]
        public double? PoVatval { get; set; }
        [Column("poTotVal")]
        public double? PoTotVal { get; set; }
        [Column("poCostVal")]
        public double? PoCostVal { get; set; }
        [Column("poCommision")]
        public double? PoCommision { get; set; }
        [Column("poVATVl1")]
        public double? PoVatvl1 { get; set; }
        [Column("poVATVl2")]
        public double? PoVatvl2 { get; set; }
        [Column("poVATVl3")]
        public double? PoVatvl3 { get; set; }
        [Column("poVATVl4")]
        public double? PoVatvl4 { get; set; }
        [Column("poVATVl5")]
        public double? PoVatvl5 { get; set; }
        [Column("poVATVl6")]
        public double? PoVatvl6 { get; set; }
        [Column("poVATVl7")]
        public double? PoVatvl7 { get; set; }
        [Column("poVATVl8")]
        public double? PoVatvl8 { get; set; }
        [Column("poVATVl9")]
        public double? PoVatvl9 { get; set; }
        [Column("poVATVl10")]
        public double? PoVatvl10 { get; set; }
        [Column("poVATVl11")]
        public double? PoVatvl11 { get; set; }
        [Column("poVATVl12")]
        public double? PoVatvl12 { get; set; }
        [Column("poVATVl13")]
        public double? PoVatvl13 { get; set; }
        [Column("poVATVl14")]
        public double? PoVatvl14 { get; set; }
        [Column("poVATVl15")]
        public double? PoVatvl15 { get; set; }
        [Column("poVATVl16")]
        public double? PoVatvl16 { get; set; }
        [Column("poVATVl17")]
        public double? PoVatvl17 { get; set; }
        [Column("poVATVl18")]
        public double? PoVatvl18 { get; set; }
        [Column("poVATVl19")]
        public double? PoVatvl19 { get; set; }
        [Column("poVATVl20")]
        public double? PoVatvl20 { get; set; }
        [Column("poVATVl21")]
        public double? PoVatvl21 { get; set; }
        [Column("poVATVl22")]
        public double? PoVatvl22 { get; set; }
        [Column("poVATVl23")]
        public double? PoVatvl23 { get; set; }
        [Column("poVATVl24")]
        public double? PoVatvl24 { get; set; }
        [Column("poVATVl25")]
        public double? PoVatvl25 { get; set; }
        [Column("poVATVl26")]
        public double? PoVatvl26 { get; set; }
        [Column("poVATVl27")]
        public double? PoVatvl27 { get; set; }
        [Column("poVATVl28")]
        public double? PoVatvl28 { get; set; }
        [Column("poVATVl29")]
        public double? PoVatvl29 { get; set; }
        [Column("poVATVl30")]
        public double? PoVatvl30 { get; set; }
        [Column("poVATVl31")]
        public double? PoVatvl31 { get; set; }
        [Column("poVATVl32")]
        public double? PoVatvl32 { get; set; }
        [Column("poVATVl33")]
        public double? PoVatvl33 { get; set; }
        [Column("poVATVl34")]
        public double? PoVatvl34 { get; set; }
        [Column("poVATVl35")]
        public double? PoVatvl35 { get; set; }
        [Column("poVATVl36")]
        public double? PoVatvl36 { get; set; }
        [Column("poVATVl37")]
        public double? PoVatvl37 { get; set; }
        [Column("poVATVl38")]
        public double? PoVatvl38 { get; set; }
        [Column("poVATVl39")]
        public double? PoVatvl39 { get; set; }
        [Column("poVATVl40")]
        public double? PoVatvl40 { get; set; }
        [Column("poVlPrVAT1")]
        public double? PoVlPrVat1 { get; set; }
        [Column("poVlPrVAT2")]
        public double? PoVlPrVat2 { get; set; }
        [Column("poVlPrVAT3")]
        public double? PoVlPrVat3 { get; set; }
        [Column("poVlPrVAT4")]
        public double? PoVlPrVat4 { get; set; }
        [Column("poVlPrVAT5")]
        public double? PoVlPrVat5 { get; set; }
        [Column("poVlPrVAT6")]
        public double? PoVlPrVat6 { get; set; }
        [Column("poVlPrVAT7")]
        public double? PoVlPrVat7 { get; set; }
        [Column("poVlPrVAT8")]
        public double? PoVlPrVat8 { get; set; }
        [Column("poVlPrVAT9")]
        public double? PoVlPrVat9 { get; set; }
        [Column("poVlPrVAT10")]
        public double? PoVlPrVat10 { get; set; }
        [Column("poVlPrVAT11")]
        public double? PoVlPrVat11 { get; set; }
        [Column("poVlPrVAT12")]
        public double? PoVlPrVat12 { get; set; }
        [Column("poVlPrVAT13")]
        public double? PoVlPrVat13 { get; set; }
        [Column("poVlPrVAT14")]
        public double? PoVlPrVat14 { get; set; }
        [Column("poVlPrVAT15")]
        public double? PoVlPrVat15 { get; set; }
        [Column("poVlPrVAT16")]
        public double? PoVlPrVat16 { get; set; }
        [Column("poVlPrVAT17")]
        public double? PoVlPrVat17 { get; set; }
        [Column("poVlPrVAT18")]
        public double? PoVlPrVat18 { get; set; }
        [Column("poVlPrVAT19")]
        public double? PoVlPrVat19 { get; set; }
        [Column("poVlPrVAT20")]
        public double? PoVlPrVat20 { get; set; }
        [Column("poVlPrVAT21")]
        public double? PoVlPrVat21 { get; set; }
        [Column("poVlPrVAT22")]
        public double? PoVlPrVat22 { get; set; }
        [Column("poVlPrVAT23")]
        public double? PoVlPrVat23 { get; set; }
        [Column("poVlPrVAT24")]
        public double? PoVlPrVat24 { get; set; }
        [Column("poVlPrVAT25")]
        public double? PoVlPrVat25 { get; set; }
        [Column("poVlPrVAT26")]
        public double? PoVlPrVat26 { get; set; }
        [Column("poVlPrVAT27")]
        public double? PoVlPrVat27 { get; set; }
        [Column("poVlPrVAT28")]
        public double? PoVlPrVat28 { get; set; }
        [Column("poVlPrVAT29")]
        public double? PoVlPrVat29 { get; set; }
        [Column("poVlPrVAT30")]
        public double? PoVlPrVat30 { get; set; }
        [Column("poVlPrVAT31")]
        public double? PoVlPrVat31 { get; set; }
        [Column("poVlPrVAT32")]
        public double? PoVlPrVat32 { get; set; }
        [Column("poVlPrVAT33")]
        public double? PoVlPrVat33 { get; set; }
        [Column("poVlPrVAT34")]
        public double? PoVlPrVat34 { get; set; }
        [Column("poVlPrVAT35")]
        public double? PoVlPrVat35 { get; set; }
        [Column("poVlPrVAT36")]
        public double? PoVlPrVat36 { get; set; }
        [Column("poVlPrVAT37")]
        public double? PoVlPrVat37 { get; set; }
        [Column("poVlPrVAT38")]
        public double? PoVlPrVat38 { get; set; }
        [Column("poVlPrVAT39")]
        public double? PoVlPrVat39 { get; set; }
        [Column("poVlPrVAT40")]
        public double? PoVlPrVat40 { get; set; }
        [Column("poCovered")]
        public double? PoCovered { get; set; }
        [Column("poPayIds1")]
        public int? PoPayIds1 { get; set; }
        [Column("poPayIds2")]
        public int? PoPayIds2 { get; set; }
        [Column("poPayIds3")]
        public int? PoPayIds3 { get; set; }
        [Column("poPayIds4")]
        public int? PoPayIds4 { get; set; }
        [Column("poPayIds5")]
        public int? PoPayIds5 { get; set; }
        [Column("poNonVAT")]
        public short? PoNonVat { get; set; }
        [Column("poTrading")]
        public int? PoTrading { get; set; }
        [Column("poLocation")]
        public int? PoLocation { get; set; }
        [Column("poEECCrncy")]
        public double? PoEeccrncy { get; set; }
        [Column("poCountry")]
        [StringLength(3)]
        public string PoCountry { get; set; }
        [Column("poEECKind")]
        [StringLength(3)]
        public string PoEeckind { get; set; }
        [Column("poEECDeliv")]
        [StringLength(3)]
        public string PoEecdeliv { get; set; }
        [Column("poText")]
        [StringLength(192)]
        public string PoText { get; set; }
        [Column("poInsDate", TypeName = "datetime")]
        public DateTime? PoInsDate { get; set; }
        [Column("poUserId")]
        public int? PoUserId { get; set; }
        [Column("poSentToId")]
        public int? PoSentToId { get; set; }
        [Column("poTime", TypeName = "datetime")]
        public DateTime? PoTime { get; set; }
        [Column("poFromFile")]
        public int? PoFromFile { get; set; }
        [Column("poFromId")]
        public int? PoFromId { get; set; }
        [Column("poToFile")]
        public int? PoToFile { get; set; }
        [Column("poToId")]
        public int? PoToId { get; set; }
        [Column("poEECExp")]
        public double? PoEecexp { get; set; }
        [Column("poConvFrom", TypeName = "datetime")]
        public DateTime? PoConvFrom { get; set; }
        [Column("poConvTo", TypeName = "datetime")]
        public DateTime? PoConvTo { get; set; }
        [Column("poEECDate", TypeName = "datetime")]
        public DateTime? PoEecdate { get; set; }
        [Column("poGLUpdated")]
        public short? PoGlupdated { get; set; }
        [Column("poEDISent")]
        public short? PoEdisent { get; set; }
        [Column("poEDICode")]
        [StringLength(15)]
        public string PoEdicode { get; set; }
        [Column("poTotEta")]
        public double? PoTotEta { get; set; }
        [Column("poVehicle")]
        [StringLength(19)]
        public string PoVehicle { get; set; }
        [Column("poGrossWeight")]
        public double? PoGrossWeight { get; set; }
        [Column("poDeadWeight")]
        public double? PoDeadWeight { get; set; }
        [Column("poReceivable")]
        public double? PoReceivable { get; set; }
        public int? CreditFlag { get; set; }
        public int? DebitFlag { get; set; }
        public int? SalesFlag { get; set; }
        [StringLength(64)]
        public string FlagsSet { get; set; }
        [Column("poTextHandle")]
        public int? PoTextHandle { get; set; }
        [Column("poPointsMode")]
        public int? PoPointsMode { get; set; }
        [Column("poChainFirst")]
        public int? PoChainFirst { get; set; }
        [Column("poChainCount")]
        public int? PoChainCount { get; set; }
        [Column("poTaxCard")]
        [StringLength(19)]
        public string PoTaxCard { get; set; }
        [Column("poNoFpaLaws")]
        public int? PoNoFpaLaws { get; set; }
        [Column("poIntraTransType")]
        public int? PoIntraTransType { get; set; }
        [Column("poSentToShop")]
        [StringLength(5)]
        public string PoSentToShop { get; set; }
        [Column("poFytaStatus")]
        public int? PoFytaStatus { get; set; }
        [Column("poAFM")]
        [StringLength(15)]
        public string PoAfm { get; set; }
        [Column("poTaxAgentSign")]
        [StringLength(81)]
        public string PoTaxAgentSign { get; set; }
        [Column("poTaxAgentCopiesSign1")]
        [StringLength(81)]
        public string PoTaxAgentCopiesSign1 { get; set; }
        [Column("poTaxAgentCopiesSign2")]
        [StringLength(81)]
        public string PoTaxAgentCopiesSign2 { get; set; }
        [Column("poTaxAgentCopiesSign3")]
        [StringLength(81)]
        public string PoTaxAgentCopiesSign3 { get; set; }
        [Column("poTaxAgentCopiesSign4")]
        [StringLength(81)]
        public string PoTaxAgentCopiesSign4 { get; set; }

        [ForeignKey(nameof(PoTrNumsId))]
        [InverseProperty(nameof(Trnum.Bmast2s))]
        public virtual Trnum PoTrNums { get; set; }
        [InverseProperty(nameof(Extext.PoFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
        [InverseProperty(nameof(Ptrn.PtBm2originNavigation))]
        public virtual ICollection<Ptrn> Ptrns { get; set; }
    }
}
