using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GMASTA")]
    [Index(nameof(GCode), Name = "goByCode", IsUnique = true)]
    [Index(nameof(GMother), Name = "goByMother")]
    [Index(nameof(GNameSrt), Name = "goByName")]
    [Index(nameof(GVatno), nameof(GCountry), Name = "goByVatNo")]
    public partial class Gmastum
    {
        public Gmastum()
        {
            Extexts = new HashSet<Extext>();
            Gtrnas = new HashSet<Gtrna>();
        }

        [Key]
        [Column("gFileId")]
        public int GFileId { get; set; }
        [Required]
        [Column("gCode")]
        [StringLength(25)]
        public string GCode { get; set; }
        [Column("gName")]
        [StringLength(39)]
        public string GName { get; set; }
        [Column("gName_srt")]
        [StringLength(39)]
        public string GNameSrt { get; set; }
        [Column("gKind")]
        public int? GKind { get; set; }
        [Column("gTransOk")]
        public short? GTransOk { get; set; }
        [Column("gMoveOK")]
        public short? GMoveOk { get; set; }
        [Column("gAnalOk")]
        public short? GAnalOk { get; set; }
        [Column("gType")]
        public int? GType { get; set; }
        [Column("gComment")]
        [StringLength(39)]
        public string GComment { get; set; }
        [Column("gForCrncy")]
        [StringLength(3)]
        public string GForCrncy { get; set; }
        [Column("gVATKind")]
        public int? GVatkind { get; set; }
        [Column("gOperator")]
        public int? GOperator { get; set; }
        [Column("gPrYrsDeb1")]
        public double? GPrYrsDeb1 { get; set; }
        [Column("gPrYrsDeb2")]
        public double? GPrYrsDeb2 { get; set; }
        [Column("gPrYrsCrd1")]
        public double? GPrYrsCrd1 { get; set; }
        [Column("gPrYrsCrd2")]
        public double? GPrYrsCrd2 { get; set; }
        [Column("gDebDate", TypeName = "datetime")]
        public DateTime? GDebDate { get; set; }
        [Column("gOpenDebit")]
        public double? GOpenDebit { get; set; }
        [Column("gYearDebit")]
        public double? GYearDebit { get; set; }
        [Column("gCreDate", TypeName = "datetime")]
        public DateTime? GCreDate { get; set; }
        [Column("gOpenCredit")]
        public double? GOpenCredit { get; set; }
        [Column("gYearCredit")]
        public double? GYearCredit { get; set; }
        [Column("gPerDebit1")]
        public double? GPerDebit1 { get; set; }
        [Column("gPerDebit2")]
        public double? GPerDebit2 { get; set; }
        [Column("gPerDebit3")]
        public double? GPerDebit3 { get; set; }
        [Column("gPerDebit4")]
        public double? GPerDebit4 { get; set; }
        [Column("gPerDebit5")]
        public double? GPerDebit5 { get; set; }
        [Column("gPerDebit6")]
        public double? GPerDebit6 { get; set; }
        [Column("gPerDebit7")]
        public double? GPerDebit7 { get; set; }
        [Column("gPerDebit8")]
        public double? GPerDebit8 { get; set; }
        [Column("gPerDebit9")]
        public double? GPerDebit9 { get; set; }
        [Column("gPerDebit10")]
        public double? GPerDebit10 { get; set; }
        [Column("gPerDebit11")]
        public double? GPerDebit11 { get; set; }
        [Column("gPerDebit12")]
        public double? GPerDebit12 { get; set; }
        [Column("gPerCred1")]
        public double? GPerCred1 { get; set; }
        [Column("gPerCred2")]
        public double? GPerCred2 { get; set; }
        [Column("gPerCred3")]
        public double? GPerCred3 { get; set; }
        [Column("gPerCred4")]
        public double? GPerCred4 { get; set; }
        [Column("gPerCred5")]
        public double? GPerCred5 { get; set; }
        [Column("gPerCred6")]
        public double? GPerCred6 { get; set; }
        [Column("gPerCred7")]
        public double? GPerCred7 { get; set; }
        [Column("gPerCred8")]
        public double? GPerCred8 { get; set; }
        [Column("gPerCred9")]
        public double? GPerCred9 { get; set; }
        [Column("gPerCred10")]
        public double? GPerCred10 { get; set; }
        [Column("gPerCred11")]
        public double? GPerCred11 { get; set; }
        [Column("gPerCred12")]
        public double? GPerCred12 { get; set; }
        [Column("gFCOpenDeb")]
        public double? GFcopenDeb { get; set; }
        [Column("gFCYearDeb")]
        public double? GFcyearDeb { get; set; }
        [Column("gFCOpenCred")]
        public double? GFcopenCred { get; set; }
        [Column("gFCYearCred")]
        public double? GFcyearCred { get; set; }
        [Column("gBalanceDeb")]
        public double? GBalanceDeb { get; set; }
        [Column("gBalanceCrd")]
        public double? GBalanceCrd { get; set; }
        [Column("gMother")]
        public int? GMother { get; set; }
        [Column("gInvNumber")]
        public double? GInvNumber { get; set; }
        [Column("gInvValue")]
        public double? GInvValue { get; set; }
        [Column("gForeDeb1")]
        public double? GForeDeb1 { get; set; }
        [Column("gForeDeb2")]
        public double? GForeDeb2 { get; set; }
        [Column("gForeDeb3")]
        public double? GForeDeb3 { get; set; }
        [Column("gForeDeb4")]
        public double? GForeDeb4 { get; set; }
        [Column("gForeDeb5")]
        public double? GForeDeb5 { get; set; }
        [Column("gForeDeb6")]
        public double? GForeDeb6 { get; set; }
        [Column("gForeDeb7")]
        public double? GForeDeb7 { get; set; }
        [Column("gForeDeb8")]
        public double? GForeDeb8 { get; set; }
        [Column("gForeDeb9")]
        public double? GForeDeb9 { get; set; }
        [Column("gForeDeb10")]
        public double? GForeDeb10 { get; set; }
        [Column("gForeDeb11")]
        public double? GForeDeb11 { get; set; }
        [Column("gForeDeb12")]
        public double? GForeDeb12 { get; set; }
        [Column("gForeCred1")]
        public double? GForeCred1 { get; set; }
        [Column("gForeCred2")]
        public double? GForeCred2 { get; set; }
        [Column("gForeCred3")]
        public double? GForeCred3 { get; set; }
        [Column("gForeCred4")]
        public double? GForeCred4 { get; set; }
        [Column("gForeCred5")]
        public double? GForeCred5 { get; set; }
        [Column("gForeCred6")]
        public double? GForeCred6 { get; set; }
        [Column("gForeCred7")]
        public double? GForeCred7 { get; set; }
        [Column("gForeCred8")]
        public double? GForeCred8 { get; set; }
        [Column("gForeCred9")]
        public double? GForeCred9 { get; set; }
        [Column("gForeCred10")]
        public double? GForeCred10 { get; set; }
        [Column("gForeCred11")]
        public double? GForeCred11 { get; set; }
        [Column("gForeCred12")]
        public double? GForeCred12 { get; set; }
        [Column("gPrYrDeb1")]
        public double? GPrYrDeb1 { get; set; }
        [Column("gPrYrDeb2")]
        public double? GPrYrDeb2 { get; set; }
        [Column("gPrYrDeb3")]
        public double? GPrYrDeb3 { get; set; }
        [Column("gPrYrDeb4")]
        public double? GPrYrDeb4 { get; set; }
        [Column("gPrYrDeb5")]
        public double? GPrYrDeb5 { get; set; }
        [Column("gPrYrDeb6")]
        public double? GPrYrDeb6 { get; set; }
        [Column("gPrYrDeb7")]
        public double? GPrYrDeb7 { get; set; }
        [Column("gPrYrDeb8")]
        public double? GPrYrDeb8 { get; set; }
        [Column("gPrYrDeb9")]
        public double? GPrYrDeb9 { get; set; }
        [Column("gPrYrDeb10")]
        public double? GPrYrDeb10 { get; set; }
        [Column("gPrYrDeb11")]
        public double? GPrYrDeb11 { get; set; }
        [Column("gPrYrDeb12")]
        public double? GPrYrDeb12 { get; set; }
        [Column("gPrYrCrd1")]
        public double? GPrYrCrd1 { get; set; }
        [Column("gPrYrCrd2")]
        public double? GPrYrCrd2 { get; set; }
        [Column("gPrYrCrd3")]
        public double? GPrYrCrd3 { get; set; }
        [Column("gPrYrCrd4")]
        public double? GPrYrCrd4 { get; set; }
        [Column("gPrYrCrd5")]
        public double? GPrYrCrd5 { get; set; }
        [Column("gPrYrCrd6")]
        public double? GPrYrCrd6 { get; set; }
        [Column("gPrYrCrd7")]
        public double? GPrYrCrd7 { get; set; }
        [Column("gPrYrCrd8")]
        public double? GPrYrCrd8 { get; set; }
        [Column("gPrYrCrd9")]
        public double? GPrYrCrd9 { get; set; }
        [Column("gPrYrCrd10")]
        public double? GPrYrCrd10 { get; set; }
        [Column("gPrYrCrd11")]
        public double? GPrYrCrd11 { get; set; }
        [Column("gPrYrCrd12")]
        public double? GPrYrCrd12 { get; set; }
        [Column("gUsrStrs1")]
        [StringLength(39)]
        public string GUsrStrs1 { get; set; }
        [Column("gUsrStrs2")]
        [StringLength(39)]
        public string GUsrStrs2 { get; set; }
        [Column("gUsrStrs3")]
        [StringLength(39)]
        public string GUsrStrs3 { get; set; }
        [Column("gUsrStrs4")]
        [StringLength(39)]
        public string GUsrStrs4 { get; set; }
        [Column("gUsrDates1", TypeName = "datetime")]
        public DateTime? GUsrDates1 { get; set; }
        [Column("gUsrDates2", TypeName = "datetime")]
        public DateTime? GUsrDates2 { get; set; }
        [Column("gUsrDates3", TypeName = "datetime")]
        public DateTime? GUsrDates3 { get; set; }
        [Column("gUsrTable1")]
        public int? GUsrTable1 { get; set; }
        [Column("gUsrTable2")]
        public int? GUsrTable2 { get; set; }
        [Column("gUsrTable3")]
        public int? GUsrTable3 { get; set; }
        [Column("gUsrNums1")]
        public double? GUsrNums1 { get; set; }
        [Column("gUsrNums2")]
        public double? GUsrNums2 { get; set; }
        [Column("gUsrNums3")]
        public double? GUsrNums3 { get; set; }
        [Column("gUsrNums4")]
        public double? GUsrNums4 { get; set; }
        [Column("gUsrNums5")]
        public double? GUsrNums5 { get; set; }
        [Column("gUsrNums6")]
        public double? GUsrNums6 { get; set; }
        [Column("gUsrCnts1")]
        public double? GUsrCnts1 { get; set; }
        [Column("gUsrCnts2")]
        public double? GUsrCnts2 { get; set; }
        [Column("gUsrCnts3")]
        public double? GUsrCnts3 { get; set; }
        [Column("gUsrCnts4")]
        public double? GUsrCnts4 { get; set; }
        [Column("gUsrCnts5")]
        public double? GUsrCnts5 { get; set; }
        [Column("gUsrCnts6")]
        public double? GUsrCnts6 { get; set; }
        [Column("gUsrCnts7")]
        public double? GUsrCnts7 { get; set; }
        [Column("gUsrCnts8")]
        public double? GUsrCnts8 { get; set; }
        [Column(TypeName = "text")]
        public string DetailFile { get; set; }
        [Column("gCompName")]
        [StringLength(39)]
        public string GCompName { get; set; }
        [Column("gCountry")]
        [StringLength(3)]
        public string GCountry { get; set; }
        [Column("gVatno")]
        [StringLength(15)]
        public string GVatno { get; set; }
        [Column("gAddress")]
        [StringLength(29)]
        public string GAddress { get; set; }
        [Column("gZipCode")]
        [StringLength(9)]
        public string GZipCode { get; set; }
        [Column("gArea")]
        [StringLength(29)]
        public string GArea { get; set; }
        [Column("gTel")]
        [StringLength(19)]
        public string GTel { get; set; }
        [Column("gTelex")]
        [StringLength(19)]
        public string GTelex { get; set; }
        [Column("gManager")]
        [StringLength(19)]
        public string GManager { get; set; }
        [Column("gBank")]
        [StringLength(29)]
        public string GBank { get; set; }
        [Column("gTxtHndl_old")]
        public int? GTxtHndlOld { get; set; }
        [Column("gUserId")]
        public int? GUserId { get; set; }
        [Column("gTaxOffice")]
        [StringLength(39)]
        public string GTaxOffice { get; set; }
        [Column("gmyf")]
        public int? Gmyf { get; set; }
        [Column("gOpenInvNum")]
        public double? GOpenInvNum { get; set; }
        [Column("gOpenInvVal")]
        public double? GOpenInvVal { get; set; }
        [Column("gAnalType")]
        public int? GAnalType { get; set; }
        [Column("gSpecial1")]
        public short? GSpecial1 { get; set; }
        [Column("gSpecial2")]
        public short? GSpecial2 { get; set; }
        [Column("gOpenTmpdeb")]
        public double? GOpenTmpdeb { get; set; }
        [Column("gOpenTmpCrd")]
        public double? GOpenTmpCrd { get; set; }
        [Column("gPerTmpDb1")]
        public double? GPerTmpDb1 { get; set; }
        [Column("gPerTmpDb2")]
        public double? GPerTmpDb2 { get; set; }
        [Column("gPerTmpDb3")]
        public double? GPerTmpDb3 { get; set; }
        [Column("gPerTmpDb4")]
        public double? GPerTmpDb4 { get; set; }
        [Column("gPerTmpDb5")]
        public double? GPerTmpDb5 { get; set; }
        [Column("gPerTmpDb6")]
        public double? GPerTmpDb6 { get; set; }
        [Column("gPerTmpDb7")]
        public double? GPerTmpDb7 { get; set; }
        [Column("gPerTmpDb8")]
        public double? GPerTmpDb8 { get; set; }
        [Column("gPerTmpDb9")]
        public double? GPerTmpDb9 { get; set; }
        [Column("gPerTmpDb10")]
        public double? GPerTmpDb10 { get; set; }
        [Column("gPerTmpDb11")]
        public double? GPerTmpDb11 { get; set; }
        [Column("gPerTmpDb12")]
        public double? GPerTmpDb12 { get; set; }
        [Column("gPerTmpCr1")]
        public double? GPerTmpCr1 { get; set; }
        [Column("gPerTmpCr2")]
        public double? GPerTmpCr2 { get; set; }
        [Column("gPerTmpCr3")]
        public double? GPerTmpCr3 { get; set; }
        [Column("gPerTmpCr4")]
        public double? GPerTmpCr4 { get; set; }
        [Column("gPerTmpCr5")]
        public double? GPerTmpCr5 { get; set; }
        [Column("gPerTmpCr6")]
        public double? GPerTmpCr6 { get; set; }
        [Column("gPerTmpCr7")]
        public double? GPerTmpCr7 { get; set; }
        [Column("gPerTmpCr8")]
        public double? GPerTmpCr8 { get; set; }
        [Column("gPerTmpCr9")]
        public double? GPerTmpCr9 { get; set; }
        [Column("gPerTmpCr10")]
        public double? GPerTmpCr10 { get; set; }
        [Column("gPerTmpCr11")]
        public double? GPerTmpCr11 { get; set; }
        [Column("gPerTmpCr12")]
        public double? GPerTmpCr12 { get; set; }
        [Column("gFCOpTmpDeb")]
        public double? GFcopTmpDeb { get; set; }
        [Column("gFCYrTmpDeb")]
        public double? GFcyrTmpDeb { get; set; }
        [Column("gFCOpTmpCrd")]
        public double? GFcopTmpCrd { get; set; }
        [Column("gFCYrTmpCrd")]
        public double? GFcyrTmpCrd { get; set; }
        [Column("gBalTmpDeb")]
        public double? GBalTmpDeb { get; set; }
        [Column("gBalTmpCrd")]
        public double? GBalTmpCrd { get; set; }
        [Column("gSpecial3")]
        public short? GSpecial3 { get; set; }
        [Column("gSpecial4")]
        public short? GSpecial4 { get; set; }
        [Column("gMs")]
        public int? GMs { get; set; }
        [Column("gmfpa")]
        public int? Gmfpa { get; set; }
        [Column("gmgrp")]
        public int? Gmgrp { get; set; }
        [Column("gmSTB")]
        public short? GmStb { get; set; }
        [Column("gmEuro")]
        public double? GmEuro { get; set; }
        [Column("gmKEPYOExcl")]
        public short? GmKepyoexcl { get; set; }
        [Column("gTxtHndl")]
        public int? GTxtHndl { get; set; }
        [Column("cBankAccount")]
        [StringLength(29)]
        public string CBankAccount { get; set; }
        [Column("gCodeGrade")]
        public int? GCodeGrade { get; set; }
        [Column("gDoyCode")]
        [StringLength(4)]
        public string GDoyCode { get; set; }
        [Column("gReformCateg")]
        [StringLength(3)]
        public string GReformCateg { get; set; }
        [Column("gcpMobile")]
        [StringLength(19)]
        public string GcpMobile { get; set; }
        [Column("gcpemail")]
        [StringLength(59)]
        public string Gcpemail { get; set; }
        [Column("gMyfVAT")]
        public short? GMyfVat { get; set; }
        [Column("gCashregID")]
        public int? GCashregId { get; set; }
        [Column("gE20E21")]
        public int? GE20e21 { get; set; }
        [Column("gcpStopDate", TypeName = "datetime")]
        public DateTime? GcpStopDate { get; set; }
        [Column("gPol1214Acc")]
        public int? GPol1214Acc { get; set; }
        [Column("gElpBalanceSheet")]
        public int? GElpBalanceSheet { get; set; }
        [Column("gElpBalanceSheetOper")]
        public int? GElpBalanceSheetOper { get; set; }
        [Column("gElpBalanceSheetGroup")]
        public int? GElpBalanceSheetGroup { get; set; }
        [Column("gElpProfitLoss")]
        public int? GElpProfitLoss { get; set; }
        [Column("gElpProfitLossOper")]
        public int? GElpProfitLossOper { get; set; }
        [Column("gElpProfitLossGroup")]
        public int? GElpProfitLossGroup { get; set; }
        [Column("gElpNetWorth")]
        public int? GElpNetWorth { get; set; }
        [Column("gElpNetWorthOper")]
        public int? GElpNetWorthOper { get; set; }
        [Column("gElpNetWorthGroup")]
        public int? GElpNetWorthGroup { get; set; }
        [Column("gElpCashFlow")]
        public int? GElpCashFlow { get; set; }
        [Column("gElpCashFlowOper")]
        public int? GElpCashFlowOper { get; set; }
        [Column("gElpCashFlowGroup")]
        public int? GElpCashFlowGroup { get; set; }
        [Column("gExcludeVatDebit1")]
        public double? GExcludeVatDebit1 { get; set; }
        [Column("gExcludeVatDebit2")]
        public double? GExcludeVatDebit2 { get; set; }
        [Column("gExcludeVatDebit3")]
        public double? GExcludeVatDebit3 { get; set; }
        [Column("gExcludeVatDebit4")]
        public double? GExcludeVatDebit4 { get; set; }
        [Column("gExcludeVatDebit5")]
        public double? GExcludeVatDebit5 { get; set; }
        [Column("gExcludeVatDebit6")]
        public double? GExcludeVatDebit6 { get; set; }
        [Column("gExcludeVatDebit7")]
        public double? GExcludeVatDebit7 { get; set; }
        [Column("gExcludeVatDebit8")]
        public double? GExcludeVatDebit8 { get; set; }
        [Column("gExcludeVatDebit9")]
        public double? GExcludeVatDebit9 { get; set; }
        [Column("gExcludeVatDebit10")]
        public double? GExcludeVatDebit10 { get; set; }
        [Column("gExcludeVatDebit11")]
        public double? GExcludeVatDebit11 { get; set; }
        [Column("gExcludeVatDebit12")]
        public double? GExcludeVatDebit12 { get; set; }
        [Column("gExcludeVatCredit1")]
        public double? GExcludeVatCredit1 { get; set; }
        [Column("gExcludeVatCredit2")]
        public double? GExcludeVatCredit2 { get; set; }
        [Column("gExcludeVatCredit3")]
        public double? GExcludeVatCredit3 { get; set; }
        [Column("gExcludeVatCredit4")]
        public double? GExcludeVatCredit4 { get; set; }
        [Column("gExcludeVatCredit5")]
        public double? GExcludeVatCredit5 { get; set; }
        [Column("gExcludeVatCredit6")]
        public double? GExcludeVatCredit6 { get; set; }
        [Column("gExcludeVatCredit7")]
        public double? GExcludeVatCredit7 { get; set; }
        [Column("gExcludeVatCredit8")]
        public double? GExcludeVatCredit8 { get; set; }
        [Column("gExcludeVatCredit9")]
        public double? GExcludeVatCredit9 { get; set; }
        [Column("gExcludeVatCredit10")]
        public double? GExcludeVatCredit10 { get; set; }
        [Column("gExcludeVatCredit11")]
        public double? GExcludeVatCredit11 { get; set; }
        [Column("gExcludeVatCredit12")]
        public double? GExcludeVatCredit12 { get; set; }
        [Column("gExcludeIsolDebit")]
        public double? GExcludeIsolDebit { get; set; }
        [Column("gExcludeIsolCredit")]
        public double? GExcludeIsolCredit { get; set; }
        [Column("gOpenAccount")]
        [StringLength(25)]
        public string GOpenAccount { get; set; }
        [Column("gTaxDiffAccount")]
        public int? GTaxDiffAccount { get; set; }
        [Column("gElpProfitLoss21")]
        public int? GElpProfitLoss21 { get; set; }
        [Column("gElpProfitLoss21Oper")]
        public int? GElpProfitLoss21Oper { get; set; }
        [Column("gElpProfitLoss22")]
        public int? GElpProfitLoss22 { get; set; }
        [Column("gElpProfitLoss22Oper")]
        public int? GElpProfitLoss22Oper { get; set; }
        [Column("gVatAccID")]
        public int? GVatAccId { get; set; }
        [Column("gElpE3")]
        public int? GElpE3 { get; set; }
        [Column("gElpE3Oper")]
        public int? GElpE3oper { get; set; }
        [Column("gIndividual")]
        public int? GIndividual { get; set; }

        [InverseProperty(nameof(Extext.GFileIdOldNavigation))]
        public virtual ICollection<Extext> Extexts { get; set; }
        [InverseProperty(nameof(Gtrna.GmFile))]
        public virtual ICollection<Gtrna> Gtrnas { get; set; }
    }
}
