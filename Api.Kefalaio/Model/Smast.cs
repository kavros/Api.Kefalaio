using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SMAST")]
    [Index(nameof(SCode), Name = "sfxByCode", IsUnique = true)]
    [Index(nameof(SFactCode), Name = "sfxByFactCode")]
    [Index(nameof(SNameSrt), Name = "sfxByName")]
    [Index(nameof(SRelCode), Name = "sfxByRelCode")]
    [Index(nameof(SSuplCode), Name = "sfxBySuplCode")]
    [Index(nameof(SSupplier), Name = "sfxBySupplier")]
    public partial class Smast
    {
        public Smast()
        {
            Extexts = new HashSet<Extext>();
            Smcodes = new HashSet<Smcode>();
            Strninvs = new HashSet<Strninv>();
            Strns = new HashSet<Strn>();
        }

        [Key]
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Required]
        [Column("sCode")]
        [StringLength(15)]
        public string SCode { get; set; }
        [Column("sName")]
        [StringLength(39)]
        public string SName { get; set; }
        [Column("sName_srt")]
        [StringLength(39)]
        public string SNameSrt { get; set; }
        [Column("sRelCode")]
        [StringLength(15)]
        public string SRelCode { get; set; }
        [Column("sFactCode")]
        [StringLength(25)]
        public string SFactCode { get; set; }
        [Column("sFeature1")]
        [StringLength(3)]
        public string SFeature1 { get; set; }
        [Column("sFeature2")]
        [StringLength(3)]
        public string SFeature2 { get; set; }
        [Column("sPlace")]
        [StringLength(9)]
        public string SPlace { get; set; }
        [Column("sInsDate", TypeName = "datetime")]
        public DateTime? SInsDate { get; set; }
        [Column("sLeadTime")]
        public int? SLeadTime { get; set; }
        [Column("sSafety")]
        public double? SSafety { get; set; }
        [Column("sReorder")]
        public double? SReorder { get; set; }
        [Column("sUnitOM")]
        [StringLength(3)]
        public string SUnitOm { get; set; }
        [Column("sUnitOM2")]
        [StringLength(3)]
        public string SUnitOm2 { get; set; }
        [Column("sUnitsRel")]
        public double? SUnitsRel { get; set; }
        [Column("sSupplier")]
        [StringLength(15)]
        public string SSupplier { get; set; }
        [Column("sSuplCode")]
        [StringLength(15)]
        public string SSuplCode { get; set; }
        [Column("sFlagOld")]
        public int? SFlagOld { get; set; }
        [Column("sImage")]
        [StringLength(39)]
        public string SImage { get; set; }
        [Column("sWhsalePr")]
        public double? SWhsalePr { get; set; }
        [Column("sRetailPr")]
        public double? SRetailPr { get; set; }
        [Column("sWhsMarkup")]
        public double? SWhsMarkup { get; set; }
        [Column("sRetMarkup")]
        public double? SRetMarkup { get; set; }
        [Column("sPriceList")]
        public int? SPriceList { get; set; }
        [Column("sCommClass")]
        public int? SCommClass { get; set; }
        [Column("sVATCode")]
        [StringLength(3)]
        public string SVatcode { get; set; }
        [Column("sGLCode1")]
        [StringLength(25)]
        public string SGlcode1 { get; set; }
        [Column("sGLCode2")]
        [StringLength(25)]
        public string SGlcode2 { get; set; }
        [Column("sCCCode1")]
        [StringLength(25)]
        public string SCccode1 { get; set; }
        [Column("sCCCode2")]
        [StringLength(25)]
        public string SCccode2 { get; set; }
        [Column("sForCncy")]
        [StringLength(3)]
        public string SForCncy { get; set; }
        [Column("sCharge")]
        public double? SCharge { get; set; }
        [Column("sFCpurchPr")]
        public double? SFcpurchPr { get; set; }
        [Column("sFCsalePr")]
        public double? SFcsalePr { get; set; }
        [Column("sComments")]
        [StringLength(39)]
        public string SComments { get; set; }
        [Column("sInOpenQnt")]
        public double? SInOpenQnt { get; set; }
        [Column("sInYearQnt")]
        public double? SInYearQnt { get; set; }
        [Column("sOrderQnt")]
        public double? SOrderQnt { get; set; }
        [Column("sOutYrQnt")]
        public double? SOutYrQnt { get; set; }
        [Column("sAllocQnt")]
        public double? SAllocQnt { get; set; }
        [Column("sInNInvQ")]
        public double? SInNinvQ { get; set; }
        [Column("sOutNInvQ")]
        public double? SOutNinvQ { get; set; }
        [Column("sInDate", TypeName = "datetime")]
        public DateTime? SInDate { get; set; }
        [Column("sInOpenVal")]
        public double? SInOpenVal { get; set; }
        [Column("sInYearVal")]
        public double? SInYearVal { get; set; }
        [Column("sLastPrcPr")]
        public double? SLastPrcPr { get; set; }
        [Column("sAverCstPr")]
        public double? SAverCstPr { get; set; }
        [Column("sMAvCostPr")]
        public double? SMavCostPr { get; set; }
        [Column("sFifoCstPr")]
        public double? SFifoCstPr { get; set; }
        [Column("sLifoCstPr")]
        public double? SLifoCstPr { get; set; }
        [Column("sCalcPrDate", TypeName = "datetime")]
        public DateTime? SCalcPrDate { get; set; }
        [Column("sOutDate", TypeName = "datetime")]
        public DateTime? SOutDate { get; set; }
        [Column("sOutYrVal")]
        public double? SOutYrVal { get; set; }
        [Column("sLastSlPr")]
        public double? SLastSlPr { get; set; }
        [Column("sAverSlPr")]
        public double? SAverSlPr { get; set; }
        [Column("sPrvYrInQn")]
        public double? SPrvYrInQn { get; set; }
        [Column("sPerInQ1")]
        public double? SPerInQ1 { get; set; }
        [Column("sPerInQ2")]
        public double? SPerInQ2 { get; set; }
        [Column("sPerInQ3")]
        public double? SPerInQ3 { get; set; }
        [Column("sPerInQ4")]
        public double? SPerInQ4 { get; set; }
        [Column("sPerInQ5")]
        public double? SPerInQ5 { get; set; }
        [Column("sPerInQ6")]
        public double? SPerInQ6 { get; set; }
        [Column("sPerInQ7")]
        public double? SPerInQ7 { get; set; }
        [Column("sPerInQ8")]
        public double? SPerInQ8 { get; set; }
        [Column("sPerInQ9")]
        public double? SPerInQ9 { get; set; }
        [Column("sPerInQ10")]
        public double? SPerInQ10 { get; set; }
        [Column("sPerInQ11")]
        public double? SPerInQ11 { get; set; }
        [Column("sPerInQ12")]
        public double? SPerInQ12 { get; set; }
        [Column("sPrvYInVal")]
        public double? SPrvYinVal { get; set; }
        [Column("sPerInV1")]
        public double? SPerInV1 { get; set; }
        [Column("sPerInV2")]
        public double? SPerInV2 { get; set; }
        [Column("sPerInV3")]
        public double? SPerInV3 { get; set; }
        [Column("sPerInV4")]
        public double? SPerInV4 { get; set; }
        [Column("sPerInV5")]
        public double? SPerInV5 { get; set; }
        [Column("sPerInV6")]
        public double? SPerInV6 { get; set; }
        [Column("sPerInV7")]
        public double? SPerInV7 { get; set; }
        [Column("sPerInV8")]
        public double? SPerInV8 { get; set; }
        [Column("sPerInV9")]
        public double? SPerInV9 { get; set; }
        [Column("sPerInV10")]
        public double? SPerInV10 { get; set; }
        [Column("sPerInV11")]
        public double? SPerInV11 { get; set; }
        [Column("sPerInV12")]
        public double? SPerInV12 { get; set; }
        [Column("sPrYrOtQn")]
        public double? SPrYrOtQn { get; set; }
        [Column("sPerOutQ1")]
        public double? SPerOutQ1 { get; set; }
        [Column("sPerOutQ2")]
        public double? SPerOutQ2 { get; set; }
        [Column("sPerOutQ3")]
        public double? SPerOutQ3 { get; set; }
        [Column("sPerOutQ4")]
        public double? SPerOutQ4 { get; set; }
        [Column("sPerOutQ5")]
        public double? SPerOutQ5 { get; set; }
        [Column("sPerOutQ6")]
        public double? SPerOutQ6 { get; set; }
        [Column("sPerOutQ7")]
        public double? SPerOutQ7 { get; set; }
        [Column("sPerOutQ8")]
        public double? SPerOutQ8 { get; set; }
        [Column("sPerOutQ9")]
        public double? SPerOutQ9 { get; set; }
        [Column("sPerOutQ10")]
        public double? SPerOutQ10 { get; set; }
        [Column("sPerOutQ11")]
        public double? SPerOutQ11 { get; set; }
        [Column("sPerOutQ12")]
        public double? SPerOutQ12 { get; set; }
        [Column("sPrYrOtVal")]
        public double? SPrYrOtVal { get; set; }
        [Column("sPerOutV1")]
        public double? SPerOutV1 { get; set; }
        [Column("sPerOutV2")]
        public double? SPerOutV2 { get; set; }
        [Column("sPerOutV3")]
        public double? SPerOutV3 { get; set; }
        [Column("sPerOutV4")]
        public double? SPerOutV4 { get; set; }
        [Column("sPerOutV5")]
        public double? SPerOutV5 { get; set; }
        [Column("sPerOutV6")]
        public double? SPerOutV6 { get; set; }
        [Column("sPerOutV7")]
        public double? SPerOutV7 { get; set; }
        [Column("sPerOutV8")]
        public double? SPerOutV8 { get; set; }
        [Column("sPerOutV9")]
        public double? SPerOutV9 { get; set; }
        [Column("sPerOutV10")]
        public double? SPerOutV10 { get; set; }
        [Column("sPerOutV11")]
        public double? SPerOutV11 { get; set; }
        [Column("sPerOutV12")]
        public double? SPerOutV12 { get; set; }
        [Column("sForeInQ1")]
        public double? SForeInQ1 { get; set; }
        [Column("sForeInQ2")]
        public double? SForeInQ2 { get; set; }
        [Column("sForeInQ3")]
        public double? SForeInQ3 { get; set; }
        [Column("sForeInQ4")]
        public double? SForeInQ4 { get; set; }
        [Column("sForeInQ5")]
        public double? SForeInQ5 { get; set; }
        [Column("sForeInQ6")]
        public double? SForeInQ6 { get; set; }
        [Column("sForeInQ7")]
        public double? SForeInQ7 { get; set; }
        [Column("sForeInQ8")]
        public double? SForeInQ8 { get; set; }
        [Column("sForeInQ9")]
        public double? SForeInQ9 { get; set; }
        [Column("sForeInQ10")]
        public double? SForeInQ10 { get; set; }
        [Column("sForeInQ11")]
        public double? SForeInQ11 { get; set; }
        [Column("sForeInQ12")]
        public double? SForeInQ12 { get; set; }
        [Column("sForeInV1")]
        public double? SForeInV1 { get; set; }
        [Column("sForeInV2")]
        public double? SForeInV2 { get; set; }
        [Column("sForeInV3")]
        public double? SForeInV3 { get; set; }
        [Column("sForeInV4")]
        public double? SForeInV4 { get; set; }
        [Column("sForeInV5")]
        public double? SForeInV5 { get; set; }
        [Column("sForeInV6")]
        public double? SForeInV6 { get; set; }
        [Column("sForeInV7")]
        public double? SForeInV7 { get; set; }
        [Column("sForeInV8")]
        public double? SForeInV8 { get; set; }
        [Column("sForeInV9")]
        public double? SForeInV9 { get; set; }
        [Column("sForeInV10")]
        public double? SForeInV10 { get; set; }
        [Column("sForeInV11")]
        public double? SForeInV11 { get; set; }
        [Column("sForeInV12")]
        public double? SForeInV12 { get; set; }
        [Column("sForeOutQ1")]
        public double? SForeOutQ1 { get; set; }
        [Column("sForeOutQ2")]
        public double? SForeOutQ2 { get; set; }
        [Column("sForeOutQ3")]
        public double? SForeOutQ3 { get; set; }
        [Column("sForeOutQ4")]
        public double? SForeOutQ4 { get; set; }
        [Column("sForeOutQ5")]
        public double? SForeOutQ5 { get; set; }
        [Column("sForeOutQ6")]
        public double? SForeOutQ6 { get; set; }
        [Column("sForeOutQ7")]
        public double? SForeOutQ7 { get; set; }
        [Column("sForeOutQ8")]
        public double? SForeOutQ8 { get; set; }
        [Column("sForeOutQ9")]
        public double? SForeOutQ9 { get; set; }
        [Column("sForeOutQ10")]
        public double? SForeOutQ10 { get; set; }
        [Column("sForeOutQ11")]
        public double? SForeOutQ11 { get; set; }
        [Column("sForeOutQ12")]
        public double? SForeOutQ12 { get; set; }
        [Column("sForeOutV1")]
        public double? SForeOutV1 { get; set; }
        [Column("sForeOutV2")]
        public double? SForeOutV2 { get; set; }
        [Column("sForeOutV3")]
        public double? SForeOutV3 { get; set; }
        [Column("sForeOutV4")]
        public double? SForeOutV4 { get; set; }
        [Column("sForeOutV5")]
        public double? SForeOutV5 { get; set; }
        [Column("sForeOutV6")]
        public double? SForeOutV6 { get; set; }
        [Column("sForeOutV7")]
        public double? SForeOutV7 { get; set; }
        [Column("sForeOutV8")]
        public double? SForeOutV8 { get; set; }
        [Column("sForeOutV9")]
        public double? SForeOutV9 { get; set; }
        [Column("sForeOutV10")]
        public double? SForeOutV10 { get; set; }
        [Column("sForeOutV11")]
        public double? SForeOutV11 { get; set; }
        [Column("sForeOutV12")]
        public double? SForeOutV12 { get; set; }
        [Column("sPrYInQs1")]
        public double? SPrYinQs1 { get; set; }
        [Column("sPrYInQs2")]
        public double? SPrYinQs2 { get; set; }
        [Column("sPrYInQs3")]
        public double? SPrYinQs3 { get; set; }
        [Column("sPrYInQs4")]
        public double? SPrYinQs4 { get; set; }
        [Column("sPrYInQs5")]
        public double? SPrYinQs5 { get; set; }
        [Column("sPrYInQs6")]
        public double? SPrYinQs6 { get; set; }
        [Column("sPrYInQs7")]
        public double? SPrYinQs7 { get; set; }
        [Column("sPrYInQs8")]
        public double? SPrYinQs8 { get; set; }
        [Column("sPrYInQs9")]
        public double? SPrYinQs9 { get; set; }
        [Column("sPrYInQs10")]
        public double? SPrYinQs10 { get; set; }
        [Column("sPrYInQs11")]
        public double? SPrYinQs11 { get; set; }
        [Column("sPrYInQs12")]
        public double? SPrYinQs12 { get; set; }
        [Column("sPrYInVs1")]
        public double? SPrYinVs1 { get; set; }
        [Column("sPrYInVs2")]
        public double? SPrYinVs2 { get; set; }
        [Column("sPrYInVs3")]
        public double? SPrYinVs3 { get; set; }
        [Column("sPrYInVs4")]
        public double? SPrYinVs4 { get; set; }
        [Column("sPrYInVs5")]
        public double? SPrYinVs5 { get; set; }
        [Column("sPrYInVs6")]
        public double? SPrYinVs6 { get; set; }
        [Column("sPrYInVs7")]
        public double? SPrYinVs7 { get; set; }
        [Column("sPrYInVs8")]
        public double? SPrYinVs8 { get; set; }
        [Column("sPrYInVs9")]
        public double? SPrYinVs9 { get; set; }
        [Column("sPrYInVs10")]
        public double? SPrYinVs10 { get; set; }
        [Column("sPrYInVs11")]
        public double? SPrYinVs11 { get; set; }
        [Column("sPrYInVs12")]
        public double? SPrYinVs12 { get; set; }
        [Column("sPrYOutQs1")]
        public double? SPrYoutQs1 { get; set; }
        [Column("sPrYOutQs2")]
        public double? SPrYoutQs2 { get; set; }
        [Column("sPrYOutQs3")]
        public double? SPrYoutQs3 { get; set; }
        [Column("sPrYOutQs4")]
        public double? SPrYoutQs4 { get; set; }
        [Column("sPrYOutQs5")]
        public double? SPrYoutQs5 { get; set; }
        [Column("sPrYOutQs6")]
        public double? SPrYoutQs6 { get; set; }
        [Column("sPrYOutQs7")]
        public double? SPrYoutQs7 { get; set; }
        [Column("sPrYOutQs8")]
        public double? SPrYoutQs8 { get; set; }
        [Column("sPrYOutQs9")]
        public double? SPrYoutQs9 { get; set; }
        [Column("sPrYOutQs10")]
        public double? SPrYoutQs10 { get; set; }
        [Column("sPrYOutQs11")]
        public double? SPrYoutQs11 { get; set; }
        [Column("sPrYOutQs12")]
        public double? SPrYoutQs12 { get; set; }
        [Column("sPrYOutVs1")]
        public double? SPrYoutVs1 { get; set; }
        [Column("sPrYOutVs2")]
        public double? SPrYoutVs2 { get; set; }
        [Column("sPrYOutVs3")]
        public double? SPrYoutVs3 { get; set; }
        [Column("sPrYOutVs4")]
        public double? SPrYoutVs4 { get; set; }
        [Column("sPrYOutVs5")]
        public double? SPrYoutVs5 { get; set; }
        [Column("sPrYOutVs6")]
        public double? SPrYoutVs6 { get; set; }
        [Column("sPrYOutVs7")]
        public double? SPrYoutVs7 { get; set; }
        [Column("sPrYOutVs8")]
        public double? SPrYoutVs8 { get; set; }
        [Column("sPrYOutVs9")]
        public double? SPrYoutVs9 { get; set; }
        [Column("sPrYOutVs10")]
        public double? SPrYoutVs10 { get; set; }
        [Column("sPrYOutVs11")]
        public double? SPrYoutVs11 { get; set; }
        [Column("sPrYOutVs12")]
        public double? SPrYoutVs12 { get; set; }
        [Column("sUsrStrs1")]
        [StringLength(39)]
        public string SUsrStrs1 { get; set; }
        [Column("sUsrStrs2")]
        [StringLength(39)]
        public string SUsrStrs2 { get; set; }
        [Column("sUsrStrs3")]
        [StringLength(39)]
        public string SUsrStrs3 { get; set; }
        [Column("sUsrStrs4")]
        [StringLength(39)]
        public string SUsrStrs4 { get; set; }
        [Column("sUsrDates1", TypeName = "datetime")]
        public DateTime? SUsrDates1 { get; set; }
        [Column("sUsrDates2", TypeName = "datetime")]
        public DateTime? SUsrDates2 { get; set; }
        [Column("sUsrDates3", TypeName = "datetime")]
        public DateTime? SUsrDates3 { get; set; }
        [Column("sUsrTbl1")]
        public int? SUsrTbl1 { get; set; }
        [Column("sUsrTbl2")]
        public int? SUsrTbl2 { get; set; }
        [Column("sUsrTbl3")]
        public int? SUsrTbl3 { get; set; }
        [Column("sUsrNums1")]
        public double? SUsrNums1 { get; set; }
        [Column("sUsrNums2")]
        public double? SUsrNums2 { get; set; }
        [Column("sUsrNums3")]
        public double? SUsrNums3 { get; set; }
        [Column("sUsrNums4")]
        public double? SUsrNums4 { get; set; }
        [Column("sUsrNums5")]
        public double? SUsrNums5 { get; set; }
        [Column("sUsrNums6")]
        public double? SUsrNums6 { get; set; }
        [Column("sUsrCnts1")]
        public double? SUsrCnts1 { get; set; }
        [Column("sUsrCnts2")]
        public double? SUsrCnts2 { get; set; }
        [Column("sUsrCnts3")]
        public double? SUsrCnts3 { get; set; }
        [Column("sUsrCnts4")]
        public double? SUsrCnts4 { get; set; }
        [Column("sUsrCnts5")]
        public double? SUsrCnts5 { get; set; }
        [Column("sUsrCnts6")]
        public double? SUsrCnts6 { get; set; }
        [Column("sUsrCnts7")]
        public double? SUsrCnts7 { get; set; }
        [Column("sUsrCnts8")]
        public double? SUsrCnts8 { get; set; }
        [Column("stxthndl")]
        public int? Stxthndl { get; set; }
        [Column("sUserid")]
        public int? SUserid { get; set; }
        [Column("sWghtFact")]
        public double? SWghtFact { get; set; }
        [Column("sVolFact")]
        public double? SVolFact { get; set; }
        [Column("sStandcost")]
        public double? SStandcost { get; set; }
        [Column("sEECcode")]
        public int? SEeccode { get; set; }
        [Column("sEECunit")]
        public int? SEecunit { get; set; }
        [Column("sImpclass")]
        public int? SImpclass { get; set; }
        [Column("sEFKtax")]
        public double? SEfktax { get; set; }
        [Column("sChngPrice", TypeName = "datetime")]
        public DateTime? SChngPrice { get; set; }
        [Column("sMaxdisc")]
        public double? SMaxdisc { get; set; }
        [Column("sAlCode")]
        [StringLength(25)]
        public string SAlCode { get; set; }
        [Column("sFpaGroup")]
        public int? SFpaGroup { get; set; }
        [Column("sMonThpr")]
        public double? SMonThpr { get; set; }
        [Column("sFlag")]
        public int? SFlag { get; set; }
        [Column("sFiller")]
        [StringLength(25)]
        public string SFiller { get; set; }
        [Column("sStd96")]
        [StringLength(25)]
        public string SStd96 { get; set; }
        [Column("sEuro")]
        public double? SEuro { get; set; }
        [Column("shTTADate", TypeName = "datetime")]
        public DateTime? ShTtadate { get; set; }
        [Column("shVBPos")]
        public int? ShVbpos { get; set; }
        [Column("shValue")]
        public double? ShValue { get; set; }
        [Column("sTTAChanDat", TypeName = "datetime")]
        public DateTime? STtachanDat { get; set; }
        [Column("sDefDisc")]
        public double? SDefDisc { get; set; }
        [Column("sETA")]
        public double? SEta { get; set; }
        [Column("sSolvency")]
        public int? SSolvency { get; set; }
        [Column("sSeason")]
        public int? SSeason { get; set; }
        [Column("sOrigin")]
        [StringLength(15)]
        public string SOrigin { get; set; }
        [Column("sSizes")]
        public int? SSizes { get; set; }
        [Column("sColorDscr1")]
        [StringLength(5)]
        public string SColorDscr1 { get; set; }
        [Column("sColorDscr2")]
        [StringLength(5)]
        public string SColorDscr2 { get; set; }
        [Column("sColorDscr3")]
        [StringLength(5)]
        public string SColorDscr3 { get; set; }
        [Column("sColorDscr4")]
        [StringLength(5)]
        public string SColorDscr4 { get; set; }
        [Column("sColorDscr5")]
        [StringLength(5)]
        public string SColorDscr5 { get; set; }
        [Column("sColorDscr6")]
        [StringLength(5)]
        public string SColorDscr6 { get; set; }
        [Column("sColorDscr7")]
        [StringLength(5)]
        public string SColorDscr7 { get; set; }
        [Column("sColorDscr8")]
        [StringLength(5)]
        public string SColorDscr8 { get; set; }
        [Column("sColorDscr9")]
        [StringLength(5)]
        public string SColorDscr9 { get; set; }
        [Column("sColorDscr10")]
        [StringLength(5)]
        public string SColorDscr10 { get; set; }
        [Column("sColorDscr11")]
        [StringLength(5)]
        public string SColorDscr11 { get; set; }
        [Column("sColorDscr12")]
        [StringLength(5)]
        public string SColorDscr12 { get; set; }
        [Column("sColorDscr13")]
        [StringLength(5)]
        public string SColorDscr13 { get; set; }
        [Column("sColorDscr14")]
        [StringLength(5)]
        public string SColorDscr14 { get; set; }
        [Column("sColorDscr15")]
        [StringLength(5)]
        public string SColorDscr15 { get; set; }
        [Column("sColorDscr16")]
        [StringLength(5)]
        public string SColorDscr16 { get; set; }
        [Column("sColorDscr17")]
        [StringLength(5)]
        public string SColorDscr17 { get; set; }
        [Column("sColorDscr18")]
        [StringLength(5)]
        public string SColorDscr18 { get; set; }
        [Column("sColorDscr19")]
        [StringLength(5)]
        public string SColorDscr19 { get; set; }
        [Column("sColorDscr20")]
        [StringLength(5)]
        public string SColorDscr20 { get; set; }
        [Column("sColorDscr21")]
        [StringLength(5)]
        public string SColorDscr21 { get; set; }
        [Column("sColorDscr22")]
        [StringLength(5)]
        public string SColorDscr22 { get; set; }
        [Column("sColorDscr23")]
        [StringLength(5)]
        public string SColorDscr23 { get; set; }
        [Column("sColorDscr24")]
        [StringLength(5)]
        public string SColorDscr24 { get; set; }
        [Column("sStartWHS")]
        public int? SStartWhs { get; set; }
        [Column("sStepWHS")]
        public int? SStepWhs { get; set; }
        [Column("sIncWHS")]
        public double? SIncWhs { get; set; }
        [Column("sStartRTL")]
        public int? SStartRtl { get; set; }
        [Column("sStepRTL")]
        public int? SStepRtl { get; set; }
        [Column("sIncRTL")]
        public double? SIncRtl { get; set; }
        [Column("sStart1")]
        public int? SStart1 { get; set; }
        [Column("sStep1")]
        public int? SStep1 { get; set; }
        [Column("sInc1")]
        public double? SInc1 { get; set; }
        [Column("sStart2")]
        public int? SStart2 { get; set; }
        [Column("sStep2")]
        public int? SStep2 { get; set; }
        [Column("sInc2")]
        public double? SInc2 { get; set; }
        [Column("sStart3")]
        public int? SStart3 { get; set; }
        [Column("sStep3")]
        public int? SStep3 { get; set; }
        [Column("sInc3")]
        public double? SInc3 { get; set; }
        [Column("sStart4")]
        public int? SStart4 { get; set; }
        [Column("sStep4")]
        public int? SStep4 { get; set; }
        [Column("sInc4")]
        public double? SInc4 { get; set; }
        [Column("sStart5")]
        public int? SStart5 { get; set; }
        [Column("sStep5")]
        public int? SStep5 { get; set; }
        [Column("sInc5")]
        public double? SInc5 { get; set; }
        [Column("sStart6")]
        public int? SStart6 { get; set; }
        [Column("sStep6")]
        public int? SStep6 { get; set; }
        [Column("sInc6")]
        public double? SInc6 { get; set; }
        [Column("sTxtHndl1")]
        public int? STxtHndl1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdDate { get; set; }
        [Column("sDepartment")]
        public int? SDepartment { get; set; }
        [Column("sDefSalesQty")]
        public double? SDefSalesQty { get; set; }
        [Column("sAvgStoreDays")]
        public double? SAvgStoreDays { get; set; }
        [Column("sAvgItemAge")]
        public double? SAvgItemAge { get; set; }
        [Column("sOpenAvgItemAge")]
        public double? SOpenAvgItemAge { get; set; }
        [Column("sCalcAvgDate", TypeName = "datetime")]
        public DateTime? SCalcAvgDate { get; set; }
        [Column("sPointsActive")]
        public int? SPointsActive { get; set; }
        [Column("sPointsFactor")]
        public double? SPointsFactor { get; set; }
        [Column("sFarmako")]
        [StringLength(15)]
        public string SFarmako { get; set; }
        [Column("sMonada")]
        [StringLength(5)]
        public string SMonada { get; set; }
        [Column("sPrescription")]
        public short? SPrescription { get; set; }
        [Column("sDrastiki")]
        [StringLength(7)]
        public string SDrastiki { get; set; }

        [InverseProperty(nameof(Extext.SFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
        [InverseProperty(nameof(Smcode.SmcsFile))]
        public virtual ICollection<Smcode> Smcodes { get; set; }
        [InverseProperty(nameof(Strninv.SFile))]
        public virtual ICollection<Strninv> Strninvs { get; set; }
        [InverseProperty(nameof(Strn.SFile))]
        public virtual ICollection<Strn> Strns { get; set; }
    }
}
