using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VMAST2")]
    [Index(nameof(SoChainFirst), nameof(SoChainCount), Name = "sofxByChain")]
    [Index(nameof(CFileId), nameof(SoDate), nameof(SoInsDate), nameof(SoTime), Name = "sofxByCust")]
    [Index(nameof(SoDate), nameof(CFileId), nameof(SoInsDate), nameof(SoTime), Name = "sofxByDate")]
    [Index(nameof(SoDocum), nameof(SoChainCount), Name = "sofxByDocum", IsUnique = true)]
    [Index(nameof(SoDueDate), nameof(CFileId), nameof(SoInsDate), nameof(SoTime), Name = "sofxByDueDate")]
    public partial class Vmast2
    {
        public Vmast2()
        {
            Ctrns = new HashSet<Ctrn>();
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("soFileId")]
        public int SoFileId { get; set; }
        [Column("soDate", TypeName = "datetime")]
        public DateTime SoDate { get; set; }
        [Column("cFileId")]
        public int CFileId { get; set; }
        [Required]
        [Column("soDocum")]
        [StringLength(15)]
        public string SoDocum { get; set; }
        [Column("soTransKind")]
        public int? SoTransKind { get; set; }
        [Column("soTrNumsId")]
        public int? SoTrNumsId { get; set; }
        [Column("soAddress")]
        [StringLength(29)]
        public string SoAddress { get; set; }
        [Column("soDueDate", TypeName = "datetime")]
        public DateTime? SoDueDate { get; set; }
        [Column("soSalesman")]
        public int? SoSalesman { get; set; }
        [Column("soPayMode")]
        [StringLength(3)]
        public string SoPayMode { get; set; }
        [Column("soDelivMode")]
        [StringLength(3)]
        public string SoDelivMode { get; set; }
        [Column("soPrinted")]
        public short? SoPrinted { get; set; }
        [Column("soStatus")]
        [StringLength(1)]
        public string SoStatus { get; set; }
        [Column("soRelDoc")]
        [StringLength(9)]
        public string SoRelDoc { get; set; }
        [Column("soSubsCode")]
        [StringLength(5)]
        public string SoSubsCode { get; set; }
        [Column("soForCrncy")]
        [StringLength(3)]
        public string SoForCrncy { get; set; }
        [Column("soCurrncy")]
        public double? SoCurrncy { get; set; }
        [Column("soComment")]
        [StringLength(63)]
        public string SoComment { get; set; }
        [Column("soGrossVal")]
        public double? SoGrossVal { get; set; }
        [Column("soPerDiscnt")]
        public double? SoPerDiscnt { get; set; }
        [Column("soDiscnt")]
        public double? SoDiscnt { get; set; }
        [Column("soNetValue")]
        public double? SoNetValue { get; set; }
        [Column("soExpKind1")]
        public int? SoExpKind1 { get; set; }
        [Column("soExpenses1")]
        public double? SoExpenses1 { get; set; }
        [Column("soExpKind2")]
        public int? SoExpKind2 { get; set; }
        [Column("soExpenses2")]
        public double? SoExpenses2 { get; set; }
        [Column("soVATVal")]
        public double? SoVatval { get; set; }
        [Column("soTotVal")]
        public double? SoTotVal { get; set; }
        [Column("soCostVal")]
        public double? SoCostVal { get; set; }
        [Column("soCommision")]
        public double? SoCommision { get; set; }
        [Column("soVATVals1")]
        public double? SoVatvals1 { get; set; }
        [Column("soVATVals2")]
        public double? SoVatvals2 { get; set; }
        [Column("soVATVals3")]
        public double? SoVatvals3 { get; set; }
        [Column("soVATVals4")]
        public double? SoVatvals4 { get; set; }
        [Column("soVATVals5")]
        public double? SoVatvals5 { get; set; }
        [Column("soVATVals6")]
        public double? SoVatvals6 { get; set; }
        [Column("soVATVals7")]
        public double? SoVatvals7 { get; set; }
        [Column("soVATVals8")]
        public double? SoVatvals8 { get; set; }
        [Column("soVATVals9")]
        public double? SoVatvals9 { get; set; }
        [Column("soVATVals10")]
        public double? SoVatvals10 { get; set; }
        [Column("soVATVals11")]
        public double? SoVatvals11 { get; set; }
        [Column("soVATVals12")]
        public double? SoVatvals12 { get; set; }
        [Column("soVATVals13")]
        public double? SoVatvals13 { get; set; }
        [Column("soVATVals14")]
        public double? SoVatvals14 { get; set; }
        [Column("soVATVals15")]
        public double? SoVatvals15 { get; set; }
        [Column("soVATVals16")]
        public double? SoVatvals16 { get; set; }
        [Column("soVATVals17")]
        public double? SoVatvals17 { get; set; }
        [Column("soVATVals18")]
        public double? SoVatvals18 { get; set; }
        [Column("soVATVals19")]
        public double? SoVatvals19 { get; set; }
        [Column("soVATVals20")]
        public double? SoVatvals20 { get; set; }
        [Column("soVATVals21")]
        public double? SoVatvals21 { get; set; }
        [Column("soVATVals22")]
        public double? SoVatvals22 { get; set; }
        [Column("soVATVals23")]
        public double? SoVatvals23 { get; set; }
        [Column("soVATVals24")]
        public double? SoVatvals24 { get; set; }
        [Column("soVATVals25")]
        public double? SoVatvals25 { get; set; }
        [Column("soVATVals26")]
        public double? SoVatvals26 { get; set; }
        [Column("soVATVals27")]
        public double? SoVatvals27 { get; set; }
        [Column("soVATVals28")]
        public double? SoVatvals28 { get; set; }
        [Column("soVATVals29")]
        public double? SoVatvals29 { get; set; }
        [Column("soVATVals30")]
        public double? SoVatvals30 { get; set; }
        [Column("soVATVals31")]
        public double? SoVatvals31 { get; set; }
        [Column("soVATVals32")]
        public double? SoVatvals32 { get; set; }
        [Column("soVATVals33")]
        public double? SoVatvals33 { get; set; }
        [Column("soVATVals34")]
        public double? SoVatvals34 { get; set; }
        [Column("soVATVals35")]
        public double? SoVatvals35 { get; set; }
        [Column("soVATVals36")]
        public double? SoVatvals36 { get; set; }
        [Column("soVATVals37")]
        public double? SoVatvals37 { get; set; }
        [Column("soVATVals38")]
        public double? SoVatvals38 { get; set; }
        [Column("soVATVals39")]
        public double? SoVatvals39 { get; set; }
        [Column("soVATVals40")]
        public double? SoVatvals40 { get; set; }
        [Column("soVlPrVAT1")]
        public double? SoVlPrVat1 { get; set; }
        [Column("soVlPrVAT2")]
        public double? SoVlPrVat2 { get; set; }
        [Column("soVlPrVAT3")]
        public double? SoVlPrVat3 { get; set; }
        [Column("soVlPrVAT4")]
        public double? SoVlPrVat4 { get; set; }
        [Column("soVlPrVAT5")]
        public double? SoVlPrVat5 { get; set; }
        [Column("soVlPrVAT6")]
        public double? SoVlPrVat6 { get; set; }
        [Column("soVlPrVAT7")]
        public double? SoVlPrVat7 { get; set; }
        [Column("soVlPrVAT8")]
        public double? SoVlPrVat8 { get; set; }
        [Column("soVlPrVAT9")]
        public double? SoVlPrVat9 { get; set; }
        [Column("soVlPrVAT10")]
        public double? SoVlPrVat10 { get; set; }
        [Column("soVlPrVAT11")]
        public double? SoVlPrVat11 { get; set; }
        [Column("soVlPrVAT12")]
        public double? SoVlPrVat12 { get; set; }
        [Column("soVlPrVAT13")]
        public double? SoVlPrVat13 { get; set; }
        [Column("soVlPrVAT14")]
        public double? SoVlPrVat14 { get; set; }
        [Column("soVlPrVAT15")]
        public double? SoVlPrVat15 { get; set; }
        [Column("soVlPrVAT16")]
        public double? SoVlPrVat16 { get; set; }
        [Column("soVlPrVAT17")]
        public double? SoVlPrVat17 { get; set; }
        [Column("soVlPrVAT18")]
        public double? SoVlPrVat18 { get; set; }
        [Column("soVlPrVAT19")]
        public double? SoVlPrVat19 { get; set; }
        [Column("soVlPrVAT20")]
        public double? SoVlPrVat20 { get; set; }
        [Column("soVlPrVAT21")]
        public double? SoVlPrVat21 { get; set; }
        [Column("soVlPrVAT22")]
        public double? SoVlPrVat22 { get; set; }
        [Column("soVlPrVAT23")]
        public double? SoVlPrVat23 { get; set; }
        [Column("soVlPrVAT24")]
        public double? SoVlPrVat24 { get; set; }
        [Column("soVlPrVAT25")]
        public double? SoVlPrVat25 { get; set; }
        [Column("soVlPrVAT26")]
        public double? SoVlPrVat26 { get; set; }
        [Column("soVlPrVAT27")]
        public double? SoVlPrVat27 { get; set; }
        [Column("soVlPrVAT28")]
        public double? SoVlPrVat28 { get; set; }
        [Column("soVlPrVAT29")]
        public double? SoVlPrVat29 { get; set; }
        [Column("soVlPrVAT30")]
        public double? SoVlPrVat30 { get; set; }
        [Column("soVlPrVAT31")]
        public double? SoVlPrVat31 { get; set; }
        [Column("soVlPrVAT32")]
        public double? SoVlPrVat32 { get; set; }
        [Column("soVlPrVAT33")]
        public double? SoVlPrVat33 { get; set; }
        [Column("soVlPrVAT34")]
        public double? SoVlPrVat34 { get; set; }
        [Column("soVlPrVAT35")]
        public double? SoVlPrVat35 { get; set; }
        [Column("soVlPrVAT36")]
        public double? SoVlPrVat36 { get; set; }
        [Column("soVlPrVAT37")]
        public double? SoVlPrVat37 { get; set; }
        [Column("soVlPrVAT38")]
        public double? SoVlPrVat38 { get; set; }
        [Column("soVlPrVAT39")]
        public double? SoVlPrVat39 { get; set; }
        [Column("soVlPrVAT40")]
        public double? SoVlPrVat40 { get; set; }
        [Column("soCovered")]
        public double? SoCovered { get; set; }
        [Column("soPayIds1")]
        public int? SoPayIds1 { get; set; }
        [Column("soPayIds2")]
        public int? SoPayIds2 { get; set; }
        [Column("soPayIds3")]
        public int? SoPayIds3 { get; set; }
        [Column("soPayIds4")]
        public int? SoPayIds4 { get; set; }
        [Column("soPayIds5")]
        public int? SoPayIds5 { get; set; }
        [Column("soNonVAT")]
        public short? SoNonVat { get; set; }
        [Column("soTrading")]
        public int? SoTrading { get; set; }
        [Column("soLocation")]
        public int? SoLocation { get; set; }
        [Column("soEECCrncy")]
        public double? SoEeccrncy { get; set; }
        [Column("soCountry")]
        [StringLength(3)]
        public string SoCountry { get; set; }
        [Column("soEECKind")]
        [StringLength(3)]
        public string SoEeckind { get; set; }
        [Column("soEECDeliv")]
        [StringLength(3)]
        public string SoEecdeliv { get; set; }
        [Column("soText")]
        [StringLength(192)]
        public string SoText { get; set; }
        [Column("soInsDate", TypeName = "datetime")]
        public DateTime? SoInsDate { get; set; }
        [Column("soUserId")]
        public int? SoUserId { get; set; }
        [Column("soSentToId")]
        public int? SoSentToId { get; set; }
        [Column("soTime", TypeName = "datetime")]
        public DateTime? SoTime { get; set; }
        [Column("soFromFile")]
        public int? SoFromFile { get; set; }
        [Column("soFromId")]
        public int? SoFromId { get; set; }
        [Column("soToFile")]
        public int? SoToFile { get; set; }
        [Column("soToId")]
        public int? SoToId { get; set; }
        [Column("soEECExp")]
        public double? SoEecexp { get; set; }
        [Column("soConvFrom", TypeName = "datetime")]
        public DateTime? SoConvFrom { get; set; }
        [Column("soConvTo", TypeName = "datetime")]
        public DateTime? SoConvTo { get; set; }
        [Column("soEECDate", TypeName = "datetime")]
        public DateTime? SoEecdate { get; set; }
        [Column("soGLUpdated")]
        public short? SoGlupdated { get; set; }
        [Column("soEDISent")]
        public short? SoEdisent { get; set; }
        [Column("soEDICode")]
        [StringLength(15)]
        public string SoEdicode { get; set; }
        [Column("soTotEta")]
        public double? SoTotEta { get; set; }
        [Column("soVehicle")]
        [StringLength(19)]
        public string SoVehicle { get; set; }
        [Column("soGrossWeight")]
        public double? SoGrossWeight { get; set; }
        [Column("soDeadWeight")]
        public double? SoDeadWeight { get; set; }
        [Column("soReceivable")]
        public double? SoReceivable { get; set; }
        public int? CreditFlag { get; set; }
        public int? DebitFlag { get; set; }
        public int? SalesFlag { get; set; }
        [StringLength(64)]
        public string FlagsSet { get; set; }
        [Column("soTextHandle")]
        public int? SoTextHandle { get; set; }
        [Column("soPointsMode")]
        public int? SoPointsMode { get; set; }
        [Column("soChainFirst")]
        public int? SoChainFirst { get; set; }
        [Column("soChainCount")]
        public int? SoChainCount { get; set; }
        [Column("soTaxCard")]
        [StringLength(19)]
        public string SoTaxCard { get; set; }
        [Column("soNoFpaLaws")]
        public int? SoNoFpaLaws { get; set; }
        [Column("soIntraTransType")]
        public int? SoIntraTransType { get; set; }
        [Column("soSentToShop")]
        [StringLength(5)]
        public string SoSentToShop { get; set; }
        [Column("soFytaStatus")]
        public int? SoFytaStatus { get; set; }
        [Column("soAFM")]
        [StringLength(15)]
        public string SoAfm { get; set; }
        [Column("soTaxAgentSign")]
        [StringLength(81)]
        public string SoTaxAgentSign { get; set; }
        [Column("soTaxAgentCopiesSign1")]
        [StringLength(81)]
        public string SoTaxAgentCopiesSign1 { get; set; }
        [Column("soTaxAgentCopiesSign2")]
        [StringLength(81)]
        public string SoTaxAgentCopiesSign2 { get; set; }
        [Column("soTaxAgentCopiesSign3")]
        [StringLength(81)]
        public string SoTaxAgentCopiesSign3 { get; set; }
        [Column("soTaxAgentCopiesSign4")]
        [StringLength(81)]
        public string SoTaxAgentCopiesSign4 { get; set; }

        [ForeignKey(nameof(SoTrNumsId))]
        [InverseProperty(nameof(Trnum.Vmast2s))]
        public virtual Trnum SoTrNums { get; set; }
        [InverseProperty(nameof(Ctrn.CtVm2originNavigation))]
        public virtual ICollection<Ctrn> Ctrns { get; set; }
        [InverseProperty(nameof(Extext.SoFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
