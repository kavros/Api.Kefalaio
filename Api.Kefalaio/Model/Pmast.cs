using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PMAST")]
    [Index(nameof(PVatno), nameof(PCountry), Name = "pByAFM")]
    [Index(nameof(P2Code), Name = "pByC2Code")]
    [Index(nameof(PCode), Name = "pByCode", IsUnique = true)]
    [Index(nameof(PNameSrt), Name = "pByName")]
    [Index(nameof(PRelCode), Name = "pByRelCode")]
    public partial class Pmast
    {
        public Pmast()
        {
            Contacts = new HashSet<Contact>();
            Extexts = new HashSet<Extext>();
            Mmasts = new HashSet<Mmast>();
            Ptrns = new HashSet<Ptrn>();
            Smcodes = new HashSet<Smcode>();
        }

        [Key]
        [Column("pFileId")]
        public int PFileId { get; set; }
        [Required]
        [Column("pCode")]
        [StringLength(15)]
        public string PCode { get; set; }
        [Column("pName")]
        [StringLength(39)]
        public string PName { get; set; }
        [Column("pName_srt")]
        [StringLength(39)]
        public string PNameSrt { get; set; }
        [Column("pRelCode")]
        [StringLength(15)]
        public string PRelCode { get; set; }
        [Column("pCountry")]
        [StringLength(3)]
        public string PCountry { get; set; }
        [Column("pVATNo")]
        [StringLength(15)]
        public string PVatno { get; set; }
        [Column("pFeatCode1")]
        [StringLength(3)]
        public string PFeatCode1 { get; set; }
        [Column("pFeatCode2")]
        [StringLength(3)]
        public string PFeatCode2 { get; set; }
        [Column("pAddres11")]
        [StringLength(29)]
        public string PAddres11 { get; set; }
        [Column("pAddres12")]
        [StringLength(29)]
        public string PAddres12 { get; set; }
        [Column("pZipCode1")]
        [StringLength(9)]
        public string PZipCode1 { get; set; }
        [Column("pArea1")]
        [StringLength(29)]
        public string PArea1 { get; set; }
        [Column("pManager")]
        [StringLength(19)]
        public string PManager { get; set; }
        [Column("pTel1")]
        [StringLength(19)]
        public string PTel1 { get; set; }
        [Column("pTel2")]
        [StringLength(19)]
        public string PTel2 { get; set; }
        [Column("pTelex")]
        [StringLength(19)]
        public string PTelex { get; set; }
        [Column("paddres21")]
        [StringLength(29)]
        public string Paddres21 { get; set; }
        [Column("paddres22")]
        [StringLength(29)]
        public string Paddres22 { get; set; }
        [Column("pZipCode2")]
        [StringLength(9)]
        public string PZipCode2 { get; set; }
        [Column("pArea2")]
        [StringLength(29)]
        public string PArea2 { get; set; }
        [Column("pBank1")]
        [StringLength(29)]
        public string PBank1 { get; set; }
        [Column("pBank2")]
        [StringLength(29)]
        public string PBank2 { get; set; }
        [Column("pGLCode")]
        [StringLength(25)]
        public string PGlcode { get; set; }
        [Column("pMHaveVAT")]
        public int? PMhaveVat { get; set; }
        [Column("pCredLim")]
        public double? PCredLim { get; set; }
        [Column("pDiscount")]
        public double? PDiscount { get; set; }
        [Column("pSalesman")]
        [StringLength(17)]
        public string PSalesman { get; set; }
        [StringLength(3)]
        public string PayMode { get; set; }
        [StringLength(3)]
        public string DelivMode { get; set; }
        [Column("pCarrier")]
        [StringLength(29)]
        public string PCarrier { get; set; }
        [Column("pFCncycode")]
        [StringLength(3)]
        public string PFcncycode { get; set; }
        [Column("pImage")]
        [StringLength(39)]
        public string PImage { get; set; }
        [Column("pComment")]
        [StringLength(39)]
        public string PComment { get; set; }
        [Column("pDebDate", TypeName = "datetime")]
        public DateTime? PDebDate { get; set; }
        [Column("pOpenDebit")]
        public double? POpenDebit { get; set; }
        [Column("pMonthDebit")]
        public double? PMonthDebit { get; set; }
        [Column("pYearDebit")]
        public double? PYearDebit { get; set; }
        [Column("pCredDate", TypeName = "datetime")]
        public DateTime? PCredDate { get; set; }
        [Column("pOpenCredit")]
        public double? POpenCredit { get; set; }
        [Column("pMnthCredit")]
        public double? PMnthCredit { get; set; }
        [Column("pYearCredit")]
        public double? PYearCredit { get; set; }
        [Column("pFCOpenDeb")]
        public double? PFcopenDeb { get; set; }
        [Column("pFCYearDeb")]
        public double? PFcyearDeb { get; set; }
        [Column("pFCOpnCred")]
        public double? PFcopnCred { get; set; }
        [Column("pFCYrCred")]
        public double? PFcyrCred { get; set; }
        [Column("pInsDate", TypeName = "datetime")]
        public DateTime? PInsDate { get; set; }
        [Column("pLastOrder", TypeName = "datetime")]
        public DateTime? PLastOrder { get; set; }
        [Column("pPayDays")]
        public int? PPayDays { get; set; }
        [Column("pCalcDate", TypeName = "datetime")]
        public DateTime? PCalcDate { get; set; }
        [Column("pPayables")]
        public double? PPayables { get; set; }
        [Column("pNonPaid")]
        public double? PNonPaid { get; set; }
        [Column("pPersales1")]
        public double? PPersales1 { get; set; }
        [Column("pPersales2")]
        public double? PPersales2 { get; set; }
        [Column("pPersales3")]
        public double? PPersales3 { get; set; }
        [Column("pPersales4")]
        public double? PPersales4 { get; set; }
        [Column("pPersales5")]
        public double? PPersales5 { get; set; }
        [Column("pPersales6")]
        public double? PPersales6 { get; set; }
        [Column("pPersales7")]
        public double? PPersales7 { get; set; }
        [Column("pPersales8")]
        public double? PPersales8 { get; set; }
        [Column("pPersales9")]
        public double? PPersales9 { get; set; }
        [Column("pPersales10")]
        public double? PPersales10 { get; set; }
        [Column("pPersales11")]
        public double? PPersales11 { get; set; }
        [Column("pPersales12")]
        public double? PPersales12 { get; set; }
        [Column("pPrevYearDb")]
        public double? PPrevYearDb { get; set; }
        [Column("pPerDeb1")]
        public double? PPerDeb1 { get; set; }
        [Column("pPerDeb2")]
        public double? PPerDeb2 { get; set; }
        [Column("pPerDeb3")]
        public double? PPerDeb3 { get; set; }
        [Column("pPerDeb4")]
        public double? PPerDeb4 { get; set; }
        [Column("pPerDeb5")]
        public double? PPerDeb5 { get; set; }
        [Column("pPerDeb6")]
        public double? PPerDeb6 { get; set; }
        [Column("pPerDeb7")]
        public double? PPerDeb7 { get; set; }
        [Column("pPerDeb8")]
        public double? PPerDeb8 { get; set; }
        [Column("pPerDeb9")]
        public double? PPerDeb9 { get; set; }
        [Column("pPerDeb10")]
        public double? PPerDeb10 { get; set; }
        [Column("pPerDeb11")]
        public double? PPerDeb11 { get; set; }
        [Column("pPerDeb12")]
        public double? PPerDeb12 { get; set; }
        [Column("pPrevYearCr")]
        public double? PPrevYearCr { get; set; }
        [Column("pPerCred1")]
        public double? PPerCred1 { get; set; }
        [Column("pPerCred2")]
        public double? PPerCred2 { get; set; }
        [Column("pPerCred3")]
        public double? PPerCred3 { get; set; }
        [Column("pPerCred4")]
        public double? PPerCred4 { get; set; }
        [Column("pPerCred5")]
        public double? PPerCred5 { get; set; }
        [Column("pPerCred6")]
        public double? PPerCred6 { get; set; }
        [Column("pPerCred7")]
        public double? PPerCred7 { get; set; }
        [Column("pPerCred8")]
        public double? PPerCred8 { get; set; }
        [Column("pPerCred9")]
        public double? PPerCred9 { get; set; }
        [Column("pPerCred10")]
        public double? PPerCred10 { get; set; }
        [Column("pPerCred11")]
        public double? PPerCred11 { get; set; }
        [Column("pPerCred12")]
        public double? PPerCred12 { get; set; }
        [Column("pPYSales1")]
        public double? PPysales1 { get; set; }
        [Column("pPYSales2")]
        public double? PPysales2 { get; set; }
        [Column("pPYSales3")]
        public double? PPysales3 { get; set; }
        [Column("pPYSales4")]
        public double? PPysales4 { get; set; }
        [Column("pPYSales5")]
        public double? PPysales5 { get; set; }
        [Column("pPYSales6")]
        public double? PPysales6 { get; set; }
        [Column("pPYSales7")]
        public double? PPysales7 { get; set; }
        [Column("pPYSales8")]
        public double? PPysales8 { get; set; }
        [Column("pPYSales9")]
        public double? PPysales9 { get; set; }
        [Column("pPYSales10")]
        public double? PPysales10 { get; set; }
        [Column("pPYSales11")]
        public double? PPysales11 { get; set; }
        [Column("pPYSales12")]
        public double? PPysales12 { get; set; }
        [Column("pForSales1")]
        public double? PForSales1 { get; set; }
        [Column("pForSales2")]
        public double? PForSales2 { get; set; }
        [Column("pForSales3")]
        public double? PForSales3 { get; set; }
        [Column("pForSales4")]
        public double? PForSales4 { get; set; }
        [Column("pForSales5")]
        public double? PForSales5 { get; set; }
        [Column("pForSales6")]
        public double? PForSales6 { get; set; }
        [Column("pForSales7")]
        public double? PForSales7 { get; set; }
        [Column("pForSales8")]
        public double? PForSales8 { get; set; }
        [Column("pForSales9")]
        public double? PForSales9 { get; set; }
        [Column("pForSales10")]
        public double? PForSales10 { get; set; }
        [Column("pForSales11")]
        public double? PForSales11 { get; set; }
        [Column("pForSales12")]
        public double? PForSales12 { get; set; }
        [Column("pForDeb1")]
        public double? PForDeb1 { get; set; }
        [Column("pForDeb2")]
        public double? PForDeb2 { get; set; }
        [Column("pForDeb3")]
        public double? PForDeb3 { get; set; }
        [Column("pForDeb4")]
        public double? PForDeb4 { get; set; }
        [Column("pForDeb5")]
        public double? PForDeb5 { get; set; }
        [Column("pForDeb6")]
        public double? PForDeb6 { get; set; }
        [Column("pForDeb7")]
        public double? PForDeb7 { get; set; }
        [Column("pForDeb8")]
        public double? PForDeb8 { get; set; }
        [Column("pForDeb9")]
        public double? PForDeb9 { get; set; }
        [Column("pForDeb10")]
        public double? PForDeb10 { get; set; }
        [Column("pForDeb11")]
        public double? PForDeb11 { get; set; }
        [Column("pForDeb12")]
        public double? PForDeb12 { get; set; }
        [Column("pForCred1")]
        public double? PForCred1 { get; set; }
        [Column("pForCred2")]
        public double? PForCred2 { get; set; }
        [Column("pForCred3")]
        public double? PForCred3 { get; set; }
        [Column("pForCred4")]
        public double? PForCred4 { get; set; }
        [Column("pForCred5")]
        public double? PForCred5 { get; set; }
        [Column("pForCred6")]
        public double? PForCred6 { get; set; }
        [Column("pForCred7")]
        public double? PForCred7 { get; set; }
        [Column("pForCred8")]
        public double? PForCred8 { get; set; }
        [Column("pForCred9")]
        public double? PForCred9 { get; set; }
        [Column("pForCred10")]
        public double? PForCred10 { get; set; }
        [Column("pForCred11")]
        public double? PForCred11 { get; set; }
        [Column("pForCred12")]
        public double? PForCred12 { get; set; }
        [Column("pUsrStrs1")]
        [StringLength(39)]
        public string PUsrStrs1 { get; set; }
        [Column("pUsrStrs2")]
        [StringLength(39)]
        public string PUsrStrs2 { get; set; }
        [Column("pUsrStrs3")]
        [StringLength(39)]
        public string PUsrStrs3 { get; set; }
        [Column("pUsrStrs4")]
        [StringLength(39)]
        public string PUsrStrs4 { get; set; }
        [Column("pUsrDates1", TypeName = "datetime")]
        public DateTime? PUsrDates1 { get; set; }
        [Column("pUsrDates2", TypeName = "datetime")]
        public DateTime? PUsrDates2 { get; set; }
        [Column("pUsrDates3", TypeName = "datetime")]
        public DateTime? PUsrDates3 { get; set; }
        [Column("pUsrTable1")]
        public int? PUsrTable1 { get; set; }
        [Column("pUsrTable2")]
        public int? PUsrTable2 { get; set; }
        [Column("pUsrTable3")]
        public int? PUsrTable3 { get; set; }
        [Column("pUsrNums1")]
        public double? PUsrNums1 { get; set; }
        [Column("pUsrNums2")]
        public double? PUsrNums2 { get; set; }
        [Column("pUsrNums3")]
        public double? PUsrNums3 { get; set; }
        [Column("pUsrNums4")]
        public double? PUsrNums4 { get; set; }
        [Column("pUsrNums5")]
        public double? PUsrNums5 { get; set; }
        [Column("pUsrNums6")]
        public double? PUsrNums6 { get; set; }
        [Column("pUsrCnts1")]
        public double? PUsrCnts1 { get; set; }
        [Column("pUsrCnts2")]
        public double? PUsrCnts2 { get; set; }
        [Column("pUsrCnts3")]
        public double? PUsrCnts3 { get; set; }
        [Column("pUsrCnts4")]
        public double? PUsrCnts4 { get; set; }
        [Column("pUsrCnts5")]
        public double? PUsrCnts5 { get; set; }
        [Column("pUsrCnts6")]
        public double? PUsrCnts6 { get; set; }
        [Column("pUsrCnts7")]
        public double? PUsrCnts7 { get; set; }
        [Column("pUsrCnts8")]
        public double? PUsrCnts8 { get; set; }
        [Column("pInvNum")]
        public int? PInvNum { get; set; }
        [Column("pInvVal")]
        public double? PInvVal { get; set; }
        [Column("pInvNum1")]
        public int? PInvNum1 { get; set; }
        [Column("pInvVal1")]
        public double? PInvVal1 { get; set; }
        [Column("ptthndl")]
        public int? Ptthndl { get; set; }
        [Column("pUserid")]
        public int? PUserid { get; set; }
        [Column("pAgeDays")]
        public int? PAgeDays { get; set; }
        [Column("pFirstDays")]
        public int? PFirstDays { get; set; }
        [Column("pInvNum0")]
        public int? PInvNum0 { get; set; }
        [Column("pInvVal0")]
        public double? PInvVal0 { get; set; }
        [Column("pEDI")]
        public short? PEdi { get; set; }
        [Column("pEDICode")]
        [StringLength(15)]
        public string PEdicode { get; set; }
        [Column("pEDICCode")]
        [StringLength(15)]
        public string PEdiccode { get; set; }
        [Column("pSenCredit")]
        public int? PSenCredit { get; set; }
        [Column("pRepCode")]
        [StringLength(15)]
        public string PRepCode { get; set; }
        [Column("pEuro")]
        public double? PEuro { get; set; }
        [Column("p2Code")]
        [StringLength(25)]
        public string P2Code { get; set; }
        [Column("pEmail")]
        [StringLength(59)]
        public string PEmail { get; set; }
        [Column("pKepyoCategory")]
        public int? PKepyoCategory { get; set; }
        [Column("pProfession")]
        [StringLength(39)]
        public string PProfession { get; set; }
        [Column("pSolvency")]
        public int? PSolvency { get; set; }
        [Column("ptthndl1")]
        public int? Ptthndl1 { get; set; }
        [Column("pKepyoExcl")]
        public short? PKepyoExcl { get; set; }
        [Column("pothexp1")]
        public int? Pothexp1 { get; set; }
        [Column("pothexp2")]
        public int? Pothexp2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdDate { get; set; }
        [Column("pTaxKind")]
        public int? PTaxKind { get; set; }
        [Column("pDOY")]
        [StringLength(39)]
        public string PDoy { get; set; }
        [Column("pMobile")]
        [StringLength(19)]
        public string PMobile { get; set; }
        [Column("pWebsite")]
        [StringLength(39)]
        public string PWebsite { get; set; }
        [Column("pDOYCode")]
        [StringLength(4)]
        public string PDoycode { get; set; }
        [Column("pNoFpaArticle")]
        public int? PNoFpaArticle { get; set; }
        [Column("pVehicle")]
        [StringLength(19)]
        public string PVehicle { get; set; }
        [Column("pTrustPercentage")]
        public double? PTrustPercentage { get; set; }
        [Column("pFpaCommision")]
        [StringLength(3)]
        public string PFpaCommision { get; set; }
        [Column("pStopDate", TypeName = "datetime")]
        public DateTime? PStopDate { get; set; }
        [Column("pIsVatSpecial")]
        public short? PIsVatSpecial { get; set; }
        [Column("pIndividual")]
        public int? PIndividual { get; set; }

        [InverseProperty(nameof(Contact.CnpFile))]
        public virtual ICollection<Contact> Contacts { get; set; }
        [InverseProperty(nameof(Extext.PFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
        [InverseProperty(nameof(Mmast.PFile))]
        public virtual ICollection<Mmast> Mmasts { get; set; }
        [InverseProperty(nameof(Ptrn.PFile))]
        public virtual ICollection<Ptrn> Ptrns { get; set; }
        [InverseProperty(nameof(Smcode.SmcpFile))]
        public virtual ICollection<Smcode> Smcodes { get; set; }
    }
}
