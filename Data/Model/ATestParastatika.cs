using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Keyless]
    public partial class ATestParastatika
    {
        [Column("sfactCode")]
        [StringLength(25)]
        public string SfactCode { get; set; }
        [Column("sname")]
        [StringLength(39)]
        public string Sname { get; set; }
        [Column("stFileId")]
        public int StFileId { get; set; }
        [Column("stDate", TypeName = "datetime")]
        public DateTime StDate { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Column("stTransKind")]
        public int StTransKind { get; set; }
        [Column("stDoc")]
        [StringLength(9)]
        public string StDoc { get; set; }
        [Column("stLocation")]
        public int StLocation { get; set; }
        [Column("stCustSuppl")]
        [StringLength(15)]
        public string StCustSuppl { get; set; }
        [Column("stQuant")]
        public double? StQuant { get; set; }
        [Column("stQuant2")]
        public double? StQuant2 { get; set; }
        [Column("stPrice")]
        public double? StPrice { get; set; }
        [Column("stDiscount")]
        public double? StDiscount { get; set; }
        [Column("stValue")]
        public double? StValue { get; set; }
        [Column("stComment")]
        [StringLength(39)]
        public string StComment { get; set; }
        [Column("stComment2")]
        [StringLength(39)]
        public string StComment2 { get; set; }
        [Column("stSalesman")]
        public int? StSalesman { get; set; }
        [Column("stForCncy")]
        [StringLength(3)]
        public string StForCncy { get; set; }
        [Column("stFCPrice")]
        public double? StFcprice { get; set; }
        [Column("stFCValue")]
        public double? StFcvalue { get; set; }
        [Column("stFromFile")]
        public int? StFromFile { get; set; }
        [Column("stPrinted")]
        public int? StPrinted { get; set; }
        [Column("stVATid")]
        public int? StVatid { get; set; }
        [Column("stFromGroup")]
        public int? StFromGroup { get; set; }
        [Column("stDocOrigin")]
        public int? StDocOrigin { get; set; }
        [Column("stInsDate", TypeName = "datetime")]
        public DateTime? StInsDate { get; set; }
        [Column("stUserId")]
        public int? StUserId { get; set; }
        [Column("stGLUpdated")]
        public int? StGlupdated { get; set; }
        [Column("stLotDelete")]
        public int? StLotDelete { get; set; }
        [Column("stThirdPart")]
        public int? StThirdPart { get; set; }
        [Column("stFiller1")]
        public int? StFiller1 { get; set; }
        [Column("stLotCode")]
        [StringLength(15)]
        public string StLotCode { get; set; }
        [Column("stLotDate", TypeName = "datetime")]
        public DateTime? StLotDate { get; set; }
        [Column("strcost")]
        public double? Strcost { get; set; }
        [Column("stTime", TypeName = "datetime")]
        public DateTime? StTime { get; set; }
        [Column("stOtherExp")]
        public double? StOtherExp { get; set; }
        [Column("stWeight")]
        public double? StWeight { get; set; }
        [Column("stVolume")]
        public double? StVolume { get; set; }
        [Column("stImpClass")]
        public int? StImpClass { get; set; }
        [Column("stEFK")]
        public double? StEfk { get; set; }
        [Column("stDocLine")]
        public int? StDocLine { get; set; }
        [Column("stDocOthEx")]
        public double? StDocOthEx { get; set; }
        [Column("stFCDocOEx")]
        public double? StFcdocOex { get; set; }
        [Column("stMarkupg")]
        public double? StMarkupg { get; set; }
        [Column("stMarkupr")]
        public double? StMarkupr { get; set; }
        [Column("stProdId")]
        public int? StProdId { get; set; }
        [Column("stFpaVal")]
        public double? StFpaVal { get; set; }
        [Column("strSearchCode")]
        [StringLength(25)]
        public string StrSearchCode { get; set; }
        [Column("stTextHandle")]
        public int? StTextHandle { get; set; }
        [Column("stVM1Origin")]
        public int? StVm1origin { get; set; }
        [Column("stBM1Origin")]
        public int? StBm1origin { get; set; }
        [Column("stNmCostOrigin")]
        public int? StNmCostOrigin { get; set; }
        [Column("stNmSpInvOrigin")]
        public int? StNmSpInvOrigin { get; set; }
        [Column("stNtSpInvOrigin")]
        public int? StNtSpInvOrigin { get; set; }
        [Column("stInputQuantFlag")]
        public int? StInputQuantFlag { get; set; }
        [Column("stInputValFlag")]
        public int? StInputValFlag { get; set; }
        [Column("stOutputQuantFlag")]
        public int? StOutputQuantFlag { get; set; }
        [Column("stOutputValFlag")]
        public int? StOutputValFlag { get; set; }
        [Column("stCancelledFlag")]
        public int? StCancelledFlag { get; set; }
        [Column("stCancelFlag")]
        public int? StCancelFlag { get; set; }
        [StringLength(64)]
        public string FlagsSet { get; set; }
        [Column("stXYCoeff")]
        public double? StXycoeff { get; set; }
        [Column("stYgrCoeff")]
        public double? StYgrCoeff { get; set; }
        [Column("stPckg")]
        public double? StPckg { get; set; }
        [Column("stPckgWeight")]
        public double? StPckgWeight { get; set; }
        [Column("stPckg2")]
        public double? StPckg2 { get; set; }
        [Column("stPckgWeight2")]
        public double? StPckgWeight2 { get; set; }
        [Column("stSetGroupPos")]
        public int? StSetGroupPos { get; set; }
        [Column("stSetGroupVM1")]
        public int? StSetGroupVm1 { get; set; }
        [Column("stPerifereia")]
        [StringLength(5)]
        public string StPerifereia { get; set; }
        [Column("stDimos")]
        [StringLength(5)]
        public string StDimos { get; set; }
        [Column("stKalliergeia")]
        [StringLength(5)]
        public string StKalliergeia { get; set; }
        [Column("stAitia")]
        [StringLength(5)]
        public string StAitia { get; set; }
        [Column("stCmpShop")]
        public int? StCmpShop { get; set; }
        [Column("stPrescID")]
        [StringLength(15)]
        public string StPrescId { get; set; }
        [Column("stPrescLineID")]
        [StringLength(15)]
        public string StPrescLineId { get; set; }
        [Column("stCertOper")]
        [StringLength(9)]
        public string StCertOper { get; set; }
        [Column("stQuanPsekDial")]
        [StringLength(39)]
        public string StQuanPsekDial { get; set; }
        [Column("stPressureApplied")]
        [StringLength(39)]
        public string StPressureApplied { get; set; }
        [Column("stDosage")]
        [StringLength(39)]
        public string StDosage { get; set; }
        [Column("stAnamoni")]
        [StringLength(39)]
        public string StAnamoni { get; set; }
        [Column("stCombined")]
        [StringLength(39)]
        public string StCombined { get; set; }
        [Column("stFreeText")]
        [StringLength(39)]
        public string StFreeText { get; set; }
        [Column("stStadio")]
        [StringLength(39)]
        public string StStadio { get; set; }
        [Column("stInSpray")]
        [StringLength(39)]
        public string StInSpray { get; set; }
        [Column("stPrescriber")]
        [StringLength(5)]
        public string StPrescriber { get; set; }
        [Column("stDrastiki")]
        [StringLength(7)]
        public string StDrastiki { get; set; }
    }
}
