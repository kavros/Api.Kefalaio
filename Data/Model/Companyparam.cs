using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("COMPANYPARAMS")]
    public partial class Companyparam
    {
        [Key]
        public int FileId { get; set; }
        [Column("vBarCodeSrc")]
        public int? VBarCodeSrc { get; set; }
        public int? CodePos { get; set; }
        public int? CodeLength { get; set; }
        public int? ColorPos { get; set; }
        public int? ColorLenght { get; set; }
        public int? SizePos { get; set; }
        public int? SizeLength { get; set; }
        public short? CorespCs { get; set; }
        [Column("aqCS_Decimals")]
        public int? AqCsDecimals { get; set; }
        [Column("aCSExistColors")]
        public short? ACsexistColors { get; set; }
        [Column("aPrintColorDescr")]
        public short? APrintColorDescr { get; set; }
        [Column("aCustAttrib")]
        public int? ACustAttrib { get; set; }
        [Column("aPrevPriceComp")]
        public int? APrevPriceComp { get; set; }
        [Column("aPrevPriceMin")]
        public int? APrevPriceMin { get; set; }
        [Column("SUnitRequired")]
        public short? SunitRequired { get; set; }
        public short? SiFpaGroupRequired { get; set; }
        [Column("CSellerRequired")]
        public short? CsellerRequired { get; set; }
        [Column("vTradingRequired")]
        public short? VTradingRequired { get; set; }
        [Column("vSellerRequired")]
        public short? VSellerRequired { get; set; }
        [Column("vPaymodeRequired")]
        public short? VPaymodeRequired { get; set; }
        [Column("b1default")]
        [StringLength(3)]
        public string B1default { get; set; }
        [Column("b2default")]
        [StringLength(3)]
        public string B2default { get; set; }
        [Column("CSSizeColWidth")]
        public int? CssizeColWidth { get; set; }
        public short? AutoCalcRetFrmWhl { get; set; }
        [Column("gFreeText")]
        public short? GFreeText { get; set; }
        [Column("EanBCPrefix")]
        [StringLength(7)]
        public string EanBcprefix { get; set; }
        public int? AutoCreateEan { get; set; }
        [Column("CRemBrowser")]
        public short? CremBrowser { get; set; }
        [Column("PRemBrowser")]
        public short? PremBrowser { get; set; }
        [Column("ChkCInvDate")]
        public short? ChkCinvDate { get; set; }
        [Column("ChkPInvDate")]
        public short? ChkPinvDate { get; set; }
        [Column("bParagSpaceNOTChk")]
        public short? BParagSpaceNotchk { get; set; }
        [Column("bParagItmValChk")]
        public short? BParagItmValChk { get; set; }
        [Column("bParagItmLotChk")]
        public short? BParagItmLotChk { get; set; }
        [Column("vParagSpaceNOTChk")]
        public short? VParagSpaceNotchk { get; set; }
        [Column("vParagItmValChk")]
        public short? VParagItmValChk { get; set; }
        [Column("vParagItmLotChk")]
        public short? VParagItmLotChk { get; set; }
        [Column("CAFMRequired")]
        public short? Cafmrequired { get; set; }
        [Column("CZipRequired")]
        public short? CzipRequired { get; set; }
        [Column("CGLCodeRequired")]
        public short? CglcodeRequired { get; set; }
        [Column("CPaymodeRequired")]
        public short? CpaymodeRequired { get; set; }
        [Column("CSendRequired")]
        public short? CsendRequired { get; set; }
        [Column("PAFMRequired")]
        public short? Pafmrequired { get; set; }
        [Column("PZipRequired")]
        public short? PzipRequired { get; set; }
        [Column("PGLCodeRequired")]
        public short? PglcodeRequired { get; set; }
        [Column("PPaymodeRequired")]
        public short? PpaymodeRequired { get; set; }
        [Column("PSendRequired")]
        public short? PsendRequired { get; set; }
        [Column("vbNoPackSizes")]
        public short? VbNoPackSizes { get; set; }
        public short? GtrnOnlineStrn { get; set; }
        public short? GtrnOnlineCtrn { get; set; }
        public short? GtrnOnlinePtrn { get; set; }
        public short? GtrnOnLineNtrn { get; set; }
        public short? GtrnOnLineVmast { get; set; }
        [Column("GtrnOnLineBMast")]
        public short? GtrnOnLineBmast { get; set; }
        public short? GtrnOnLineCost { get; set; }
        public int? GtrnDeletionCheck { get; set; }
        [Column("SS2CodeRequired")]
        public short? Ss2codeRequired { get; set; }
        [Column("SS1FeatRequired")]
        public short? Ss1featRequired { get; set; }
        [Column("SS2FeatRequired")]
        public short? Ss2featRequired { get; set; }
        [Column("SSCommentsRequired")]
        public short? SscommentsRequired { get; set; }
        [Column("CSPrintAllMatrix")]
        public short? CsprintAllMatrix { get; set; }
        public int? ParagSortType { get; set; }
        [Column("SRemBrowser")]
        public short? SremBrowser { get; set; }
        [Column("S2CodeUnique")]
        public int? S2codeUnique { get; set; }
        [Column("vVehicleRequired")]
        public short? VVehicleRequired { get; set; }
        [Column("vVehicleListCount")]
        public int? VVehicleListCount { get; set; }
        [Column("bVehicleListCount")]
        public int? BVehicleListCount { get; set; }
        [Column("vRtlFastEntry")]
        public short? VRtlFastEntry { get; set; }
        [Column("vRtlValidInvoicesSet", TypeName = "text")]
        public string VRtlValidInvoicesSet { get; set; }
        [Column("alFromDoUpdate")]
        public int? AlFromDoUpdate { get; set; }
        [Column("alToDoUpdate")]
        public int? AlToDoUpdate { get; set; }
        [Column("alFromUnDoUpdate")]
        public int? AlFromUnDoUpdate { get; set; }
        [Column("alToUnDoUpdate")]
        public int? AlToUnDoUpdate { get; set; }
        [Column("bComputeCost")]
        public int? BComputeCost { get; set; }
        [Column("vSentmodeRequired")]
        public short? VSentmodeRequired { get; set; }
        [Column("bTradingRequired")]
        public short? BTradingRequired { get; set; }
        [Column("bPaymodeRequired")]
        public short? BPaymodeRequired { get; set; }
        [Column("bSentmodeRequired")]
        public short? BSentmodeRequired { get; set; }
        [Column("bVehicleRequired")]
        public short? BVehicleRequired { get; set; }
        [Column("NewItemsActiveCS")]
        public short? NewItemsActiveCs { get; set; }
        public int? WghtDecimals { get; set; }
        public int? VlmDecimals { get; set; }
        [Column("snFreeText")]
        public short? SnFreeText { get; set; }
        [Column("loFreeText")]
        public short? LoFreeText { get; set; }
        public short? LotEndDateRequired { get; set; }
        [Column("SmCopyCmpEAN")]
        public short? SmCopyCmpEan { get; set; }
        [Column(TypeName = "text")]
        public string SmCopyToOtherComps { get; set; }
        [Column(TypeName = "text")]
        public string CmCopyToOtherComps { get; set; }
        [Column(TypeName = "text")]
        public string PmCopyToOtherComps { get; set; }
        public short? ExclSrvCodePrint { get; set; }
        [Column("vCheckCost")]
        public int? VCheckCost { get; set; }
        public short? ColorDescrMatrix { get; set; }
        [Column("LabelsCSSort")]
        public int? LabelsCssort { get; set; }
        [Column("vShowPartialOrdrsQ")]
        public int? VShowPartialOrdrsQ { get; set; }
        [Column("vDelFullExecuted")]
        public int? VDelFullExecuted { get; set; }
        [Column("bDelFullExecuted")]
        public int? BDelFullExecuted { get; set; }
        [Column("smShowAnamDesmInBr")]
        public short? SmShowAnamDesmInBr { get; set; }
        [Column("vPurchasePriceInfo")]
        public short? VPurchasePriceInfo { get; set; }
        [Column("sModifyItemColors")]
        public short? SModifyItemColors { get; set; }
        [Column("gCheckUnbalance")]
        public short? GCheckUnbalance { get; set; }
        [Column("gGetDescrText")]
        public short? GGetDescrText { get; set; }
        [Column("cOtherExp1Required")]
        public short? COtherExp1Required { get; set; }
        [Column("cOtherExp2Required")]
        public short? COtherExp2Required { get; set; }
        [Column("gCheckGtDoc")]
        public int? GCheckGtDoc { get; set; }
        [Column("EShopEnabled")]
        public short? EshopEnabled { get; set; }
        public int? Customize { get; set; }
        [Column("vFullPriceInfo")]
        public short? VFullPriceInfo { get; set; }
        [Column("bFullPriceInfo")]
        public short? BFullPriceInfo { get; set; }
        [Column("vZeroPrice")]
        public int? VZeroPrice { get; set; }
        [Column("vRtlRollBackDefaultCode")]
        public short? VRtlRollBackDefaultCode { get; set; }
        [Column("vChkInvSubs")]
        public int? VChkInvSubs { get; set; }
        [Column("bChkInvSubs")]
        public int? BChkInvSubs { get; set; }
        [Column("sGLCode1Required")]
        public short? SGlcode1Required { get; set; }
        [Column("sGLCode2Required")]
        public short? SGlcode2Required { get; set; }
        [Column("vSrvsFastEntry")]
        public short? VSrvsFastEntry { get; set; }
        [Column("vValLimitCheck")]
        public int? VValLimitCheck { get; set; }
        [Column("bValLimitCheck")]
        public int? BValLimitCheck { get; set; }
        [Column("sWeightFactor")]
        public int? SWeightFactor { get; set; }
        [Column("sVolumeFactor")]
        public int? SVolumeFactor { get; set; }
        [Column("vEInvPrintAfter")]
        public short? VEinvPrintAfter { get; set; }
        [Column("vEInvExclude", TypeName = "text")]
        public string VEinvExclude { get; set; }
        public int? BackupCheckDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BackupLastDate { get; set; }
        [Column("vExclCashInvPlafon")]
        public short? VExclCashInvPlafon { get; set; }
        [Column("cMXPendNotesOn")]
        public short? CMxpendNotesOn { get; set; }
        [Column("pMXPendNotesOn")]
        public short? PMxpendNotesOn { get; set; }
        [Column("cEMailRequired")]
        public short? CEmailRequired { get; set; }
        [Column("cManagerRequired")]
        public short? CManagerRequired { get; set; }
        [Column("pEMailRequired")]
        public short? PEmailRequired { get; set; }
        [Column("pManagerRequired")]
        public short? PManagerRequired { get; set; }
        [Column("sSupplierSearch")]
        public short? SSupplierSearch { get; set; }
        [Column("gCheckBudgetLimit")]
        public int? GCheckBudgetLimit { get; set; }
        [Column("gInclTemp")]
        public int? GInclTemp { get; set; }
        [Column("gReformKK")]
        public int? GReformKk { get; set; }
        [Column("gShowReformInfo")]
        public int? GShowReformInfo { get; set; }
        [Column("EuroPDecimals")]
        public int? EuroPdecimals { get; set; }
        [Column("EuroVDecimals")]
        public int? EuroVdecimals { get; set; }
        public int? MainCurrency { get; set; }
        [Column("vbPrevPricesDepth")]
        public int? VbPrevPricesDepth { get; set; }
        [Column("nspCheckInvSubs")]
        public int? NspCheckInvSubs { get; set; }
        [Column("vApplyDiscount")]
        public short? VApplyDiscount { get; set; }
        public short? PrchsLineFeed { get; set; }
        [Column("bApplyDiscount")]
        public short? BApplyDiscount { get; set; }
        [Column("cMendSaveAccArtcl")]
        public short? CMendSaveAccArtcl { get; set; }
        [Column("pMendSaveAccArtcl")]
        public short? PMendSaveAccArtcl { get; set; }
        [Column("vSearchCustOnLines")]
        public int? VSearchCustOnLines { get; set; }
        [Column("sKKApografis")]
        public int? SKkapografis { get; set; }
        [Column("sSearchRel")]
        public short? SSearchRel { get; set; }
        [Column("sDefaultKey")]
        public int? SDefaultKey { get; set; }
        [Column("sAutoQuant")]
        public double? SAutoQuant { get; set; }
        public short? LotWaitingPlus { get; set; }
        public short? LotOrderedMinus { get; set; }
        [Column("v1WaitingPlus")]
        public short? V1WaitingPlus { get; set; }
        [Column("v1OrderedMinus")]
        public short? V1OrderedMinus { get; set; }
        [Column("v2WaitingPlus")]
        public short? V2WaitingPlus { get; set; }
        [Column("v2OrderedMinus")]
        public short? V2OrderedMinus { get; set; }
        [Column("b1WaitingPlus")]
        public short? B1WaitingPlus { get; set; }
        [Column("b1OrderedMinus")]
        public short? B1OrderedMinus { get; set; }
        [Column("sWholePriceRequired")]
        public short? SWholePriceRequired { get; set; }
        [Column("sRetailPriceRequired")]
        public short? SRetailPriceRequired { get; set; }
        [Column("gShowTxt")]
        public short? GShowTxt { get; set; }
        [Column("gCheckGtDocMode")]
        public int? GCheckGtDocMode { get; set; }
        [Column("GLPagExportCmp")]
        public int? GlpagExportCmp { get; set; }
        [StringLength(81)]
        public string GlPagExportPath { get; set; }
        [Column("gLastTransNum")]
        public int? GLastTransNum { get; set; }
        [Column("sCostBookCode")]
        public int? SCostBookCode { get; set; }
        [Column("gtTrnUpdCheckType")]
        public int? GtTrnUpdCheckType { get; set; }
        [Column("gKFASAutoNum")]
        public short? GKfasautoNum { get; set; }
        [Column("gKFASDenyNumEdit")]
        public short? GKfasdenyNumEdit { get; set; }
        [Column("gKFASGLUpdType")]
        public int? GKfasglupdType { get; set; }
        [Column("vRtlSearchCustKey")]
        public int? VRtlSearchCustKey { get; set; }
        [Column("cPhone1Required")]
        public short? CPhone1Required { get; set; }
        [Column("cPhone2Required")]
        public short? CPhone2Required { get; set; }
        [Column("cMobileRequired")]
        public short? CMobileRequired { get; set; }
        [Column("pPhone1Required")]
        public short? PPhone1Required { get; set; }
        [Column("pPhone2Required")]
        public short? PPhone2Required { get; set; }
        [Column("pMobileRequired")]
        public short? PMobileRequired { get; set; }
        [Column("gtrDocRequired")]
        public short? GtrDocRequired { get; set; }
        [Column("gtrComm1Required")]
        public short? GtrComm1Required { get; set; }
        [Column("gtrComm2Required")]
        public short? GtrComm2Required { get; set; }
        [Column("sCostBookAX")]
        public short? SCostBookAx { get; set; }
        [Column("vInvoicesLimit")]
        public double? VInvoicesLimit { get; set; }
        [Column("vInvoicesLimitSet", TypeName = "text")]
        public string VInvoicesLimitSet { get; set; }
        [Column("bInvoicesLimit")]
        public double? BInvoicesLimit { get; set; }
        [Column("bInvoicesLimitSet", TypeName = "text")]
        public string BInvoicesLimitSet { get; set; }
        [Column("ggpsenabled")]
        public short? Ggpsenabled { get; set; }
        [Column("vPrintedInvMod")]
        public int? VPrintedInvMod { get; set; }
        [Column("bPrintedInvMod")]
        public int? BPrintedInvMod { get; set; }
        [Column("cSearchAFM")]
        public short? CSearchAfm { get; set; }
        [Column("pSearchAFM")]
        public short? PSearchAfm { get; set; }
        [Column("SDefGroup")]
        public int? SdefGroup { get; set; }
        [Column("CDefGroup")]
        public int? CdefGroup { get; set; }
        [Column("PDefGroup")]
        public int? PdefGroup { get; set; }
        [Column("LDefGroup")]
        public int? LdefGroup { get; set; }
        [Column("gVATAccount")]
        [StringLength(25)]
        public string GVataccount { get; set; }
        [Column("lnPagSaleDateMethod")]
        public int? LnPagSaleDateMethod { get; set; }
        [Column("vbTransCreateCancelInv")]
        public short? VbTransCreateCancelInv { get; set; }
        [Column("GsisAFMServUserName")]
        [StringLength(29)]
        public string GsisAfmservUserName { get; set; }
        [Column("GsisAFMServPassword")]
        [StringLength(29)]
        public string GsisAfmservPassword { get; set; }
        public int? UpDateStopDate { get; set; }
        [Column("vLabelsQFrom")]
        public int? VLabelsQfrom { get; set; }
        [Column("bLabelsQFrom")]
        public int? BLabelsQfrom { get; set; }
        [Column("sLotExpireDays")]
        public int? SLotExpireDays { get; set; }
        [Column("vInvoicesLimitType")]
        public int? VInvoicesLimitType { get; set; }
        [Column("bInvoicesLimitType")]
        public int? BInvoicesLimitType { get; set; }
        [Column("bLotSame")]
        public int? BLotSame { get; set; }
        [Column("bLotCheckSuppl")]
        public short? BLotCheckSuppl { get; set; }
        public short? SelectWinPrinter { get; set; }
        [Column("vZeroPriceType")]
        public int? VZeroPriceType { get; set; }
        [Column("vZeroPriceInvoices", TypeName = "text")]
        public string VZeroPriceInvoices { get; set; }
        [Column("MinagricPrtID")]
        public int? MinagricPrtId { get; set; }
        public int? MinagricPtrMode { get; set; }
        [Column("vDenyZeroValDocs")]
        public int? VDenyZeroValDocs { get; set; }
        [Column("bDenyZeroValDocs")]
        public int? BDenyZeroValDocs { get; set; }
        [Column("vCheckNegativeQuantsOnDocLines")]
        public int? VCheckNegativeQuantsOnDocLines { get; set; }
        [Column("MinagricVInvSet", TypeName = "text")]
        public string MinagricVinvSet { get; set; }
        [Column("sSolvencyHide")]
        public short? SSolvencyHide { get; set; }
        [Column("cSolvencyHide")]
        public short? CSolvencyHide { get; set; }
        [Column("pSolvencyHide")]
        public short? PSolvencyHide { get; set; }
        [Column("v2VehicleList")]
        public short? V2VehicleList { get; set; }
        [Column("b2VehicleList")]
        public short? B2VehicleList { get; set; }
        public int? MinagricMedCropMode { get; set; }
        [Column("gIsTaxDiff")]
        public short? GIsTaxDiff { get; set; }
        [Column("rtrlAltColumns")]
        public short? RtrlAltColumns { get; set; }
        public int? MinagricPtrCopies { get; set; }
        public int? Transmittingfuel { get; set; }
    }
}
