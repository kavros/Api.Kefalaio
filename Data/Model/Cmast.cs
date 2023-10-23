using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CMAST")]
    [Index(nameof(CVatno), nameof(CCountry), Name = "cByAFM")]
    [Index(nameof(C2Code), Name = "cByC2Code")]
    [Index(nameof(CCode), Name = "cByCode", IsUnique = true)]
    [Index(nameof(CNameSrt), Name = "cByName")]
    [Index(nameof(CRelCode), Name = "cByRelCode")]
    public partial class Cmast
    {
        public Cmast()
        {
            Contacts = new HashSet<Contact>();
            Ctrns = new HashSet<Ctrn>();
            Extexts = new HashSet<Extext>();
            Mmasts = new HashSet<Mmast>();
        }

        [Key]
        [Column("cFileId")]
        public int CFileId { get; set; }
        [Required]
        [Column("cCode")]
        [StringLength(15)]
        public string CCode { get; set; }
        [Column("cName")]
        [StringLength(39)]
        public string CName { get; set; }
        [Column("cName_srt")]
        [StringLength(39)]
        public string CNameSrt { get; set; }
        [Column("cRelCode")]
        [StringLength(15)]
        public string CRelCode { get; set; }
        [Column("cCountry")]
        [StringLength(3)]
        public string CCountry { get; set; }
        [Column("cVATNo")]
        [StringLength(15)]
        public string CVatno { get; set; }
        [Column("cFeatCode1")]
        [StringLength(3)]
        public string CFeatCode1 { get; set; }
        [Column("cFeatCode2")]
        [StringLength(3)]
        public string CFeatCode2 { get; set; }
        [Column("cAddress11")]
        [StringLength(29)]
        public string CAddress11 { get; set; }
        [Column("cAddress12")]
        [StringLength(29)]
        public string CAddress12 { get; set; }
        [Column("cZipCode1")]
        [StringLength(9)]
        public string CZipCode1 { get; set; }
        [Column("cArea1")]
        [StringLength(29)]
        public string CArea1 { get; set; }
        [Column("cManager")]
        [StringLength(19)]
        public string CManager { get; set; }
        [Column("cPhone1")]
        [StringLength(19)]
        public string CPhone1 { get; set; }
        [Column("cPhone2")]
        [StringLength(19)]
        public string CPhone2 { get; set; }
        [Column("cTelex")]
        [StringLength(19)]
        public string CTelex { get; set; }
        [Column("cAddress21")]
        [StringLength(29)]
        public string CAddress21 { get; set; }
        [Column("cAddress22")]
        [StringLength(29)]
        public string CAddress22 { get; set; }
        [Column("cZipCode2")]
        [StringLength(9)]
        public string CZipCode2 { get; set; }
        [Column("cArea2")]
        [StringLength(29)]
        public string CArea2 { get; set; }
        [Column("cBank1")]
        [StringLength(29)]
        public string CBank1 { get; set; }
        [Column("cBank2")]
        [StringLength(29)]
        public string CBank2 { get; set; }
        [Column("cGlCode")]
        [StringLength(25)]
        public string CGlCode { get; set; }
        [Column("cMHaveVAT")]
        public int? CMhaveVat { get; set; }
        [Column("cCredLimit")]
        public double? CCredLimit { get; set; }
        [Column("cDiscPcnt")]
        public double? CDiscPcnt { get; set; }
        [Column("cPrlstRange")]
        public int? CPrlstRange { get; set; }
        [Column("cSalesMan")]
        public int? CSalesMan { get; set; }
        [StringLength(3)]
        public string PayMode { get; set; }
        [StringLength(3)]
        public string DelivMode { get; set; }
        [Column("cDelivMan")]
        [StringLength(29)]
        public string CDelivMan { get; set; }
        [Column("cFrgnCurr")]
        [StringLength(3)]
        public string CFrgnCurr { get; set; }
        [Column("cImage")]
        [StringLength(39)]
        public string CImage { get; set; }
        [Column("cComment")]
        [StringLength(39)]
        public string CComment { get; set; }
        [Column("cInvDate", TypeName = "datetime")]
        public DateTime? CInvDate { get; set; }
        [Column("copenDeb")]
        public double? CopenDeb { get; set; }
        [Column("cmonthDeb")]
        public double? CmonthDeb { get; set; }
        [Column("cyearDeb")]
        public double? CyearDeb { get; set; }
        [Column("cCredDate", TypeName = "datetime")]
        public DateTime? CCredDate { get; set; }
        [Column("cOpenCred")]
        public double? COpenCred { get; set; }
        [Column("cmonthCred")]
        public double? CmonthCred { get; set; }
        [Column("cyearCred")]
        public double? CyearCred { get; set; }
        [Column("cFCopenDeb")]
        public double? CFcopenDeb { get; set; }
        [Column("cFCyearDeb")]
        public double? CFcyearDeb { get; set; }
        [Column("cFCopenCred")]
        public double? CFcopenCred { get; set; }
        [Column("cFCyearCred")]
        public double? CFcyearCred { get; set; }
        [Column("cStartDate", TypeName = "datetime")]
        public DateTime? CStartDate { get; set; }
        [Column("cLastOrder", TypeName = "datetime")]
        public DateTime? CLastOrder { get; set; }
        [Column("cRefUse", TypeName = "datetime")]
        public DateTime? CRefUse { get; set; }
        [Column("cPayBack")]
        public int? CPayBack { get; set; }
        [Column("cCalcDate", TypeName = "datetime")]
        public DateTime? CCalcDate { get; set; }
        [Column("cPayables")]
        public double? CPayables { get; set; }
        [Column("cNonPaid")]
        public double? CNonPaid { get; set; }
        [Column("cProfits")]
        public double? CProfits { get; set; }
        [Column("cPersales1")]
        public double? CPersales1 { get; set; }
        [Column("cPersales2")]
        public double? CPersales2 { get; set; }
        [Column("cPersales3")]
        public double? CPersales3 { get; set; }
        [Column("cPersales4")]
        public double? CPersales4 { get; set; }
        [Column("cPersales5")]
        public double? CPersales5 { get; set; }
        [Column("cPersales6")]
        public double? CPersales6 { get; set; }
        [Column("cPersales7")]
        public double? CPersales7 { get; set; }
        [Column("cPersales8")]
        public double? CPersales8 { get; set; }
        [Column("cPersales9")]
        public double? CPersales9 { get; set; }
        [Column("cPersales10")]
        public double? CPersales10 { get; set; }
        [Column("cPersales11")]
        public double? CPersales11 { get; set; }
        [Column("cPersales12")]
        public double? CPersales12 { get; set; }
        [Column("cPrevYearDb")]
        public double? CPrevYearDb { get; set; }
        [Column("cPerDeb1")]
        public double? CPerDeb1 { get; set; }
        [Column("cPerDeb2")]
        public double? CPerDeb2 { get; set; }
        [Column("cPerDeb3")]
        public double? CPerDeb3 { get; set; }
        [Column("cPerDeb4")]
        public double? CPerDeb4 { get; set; }
        [Column("cPerDeb5")]
        public double? CPerDeb5 { get; set; }
        [Column("cPerDeb6")]
        public double? CPerDeb6 { get; set; }
        [Column("cPerDeb7")]
        public double? CPerDeb7 { get; set; }
        [Column("cPerDeb8")]
        public double? CPerDeb8 { get; set; }
        [Column("cPerDeb9")]
        public double? CPerDeb9 { get; set; }
        [Column("cPerDeb10")]
        public double? CPerDeb10 { get; set; }
        [Column("cPerDeb11")]
        public double? CPerDeb11 { get; set; }
        [Column("cPerDeb12")]
        public double? CPerDeb12 { get; set; }
        [Column("cPrevYearCr")]
        public double? CPrevYearCr { get; set; }
        [Column("cPerCred1")]
        public double? CPerCred1 { get; set; }
        [Column("cPerCred2")]
        public double? CPerCred2 { get; set; }
        [Column("cPerCred3")]
        public double? CPerCred3 { get; set; }
        [Column("cPerCred4")]
        public double? CPerCred4 { get; set; }
        [Column("cPerCred5")]
        public double? CPerCred5 { get; set; }
        [Column("cPerCred6")]
        public double? CPerCred6 { get; set; }
        [Column("cPerCred7")]
        public double? CPerCred7 { get; set; }
        [Column("cPerCred8")]
        public double? CPerCred8 { get; set; }
        [Column("cPerCred9")]
        public double? CPerCred9 { get; set; }
        [Column("cPerCred10")]
        public double? CPerCred10 { get; set; }
        [Column("cPerCred11")]
        public double? CPerCred11 { get; set; }
        [Column("cPerCred12")]
        public double? CPerCred12 { get; set; }
        [Column("cPYSales1")]
        public double? CPysales1 { get; set; }
        [Column("cPYSales2")]
        public double? CPysales2 { get; set; }
        [Column("cPYSales3")]
        public double? CPysales3 { get; set; }
        [Column("cPYSales4")]
        public double? CPysales4 { get; set; }
        [Column("cPYSales5")]
        public double? CPysales5 { get; set; }
        [Column("cPYSales6")]
        public double? CPysales6 { get; set; }
        [Column("cPYSales7")]
        public double? CPysales7 { get; set; }
        [Column("cPYSales8")]
        public double? CPysales8 { get; set; }
        [Column("cPYSales9")]
        public double? CPysales9 { get; set; }
        [Column("cPYSales10")]
        public double? CPysales10 { get; set; }
        [Column("cPYSales11")]
        public double? CPysales11 { get; set; }
        [Column("cPYSales12")]
        public double? CPysales12 { get; set; }
        [Column("cForSales1")]
        public double? CForSales1 { get; set; }
        [Column("cForSales2")]
        public double? CForSales2 { get; set; }
        [Column("cForSales3")]
        public double? CForSales3 { get; set; }
        [Column("cForSales4")]
        public double? CForSales4 { get; set; }
        [Column("cForSales5")]
        public double? CForSales5 { get; set; }
        [Column("cForSales6")]
        public double? CForSales6 { get; set; }
        [Column("cForSales7")]
        public double? CForSales7 { get; set; }
        [Column("cForSales8")]
        public double? CForSales8 { get; set; }
        [Column("cForSales9")]
        public double? CForSales9 { get; set; }
        [Column("cForSales10")]
        public double? CForSales10 { get; set; }
        [Column("cForSales11")]
        public double? CForSales11 { get; set; }
        [Column("cForSales12")]
        public double? CForSales12 { get; set; }
        [Column("cForDeb1")]
        public double? CForDeb1 { get; set; }
        [Column("cForDeb2")]
        public double? CForDeb2 { get; set; }
        [Column("cForDeb3")]
        public double? CForDeb3 { get; set; }
        [Column("cForDeb4")]
        public double? CForDeb4 { get; set; }
        [Column("cForDeb5")]
        public double? CForDeb5 { get; set; }
        [Column("cForDeb6")]
        public double? CForDeb6 { get; set; }
        [Column("cForDeb7")]
        public double? CForDeb7 { get; set; }
        [Column("cForDeb8")]
        public double? CForDeb8 { get; set; }
        [Column("cForDeb9")]
        public double? CForDeb9 { get; set; }
        [Column("cForDeb10")]
        public double? CForDeb10 { get; set; }
        [Column("cForDeb11")]
        public double? CForDeb11 { get; set; }
        [Column("cForDeb12")]
        public double? CForDeb12 { get; set; }
        [Column("cForCred1")]
        public double? CForCred1 { get; set; }
        [Column("cForCred2")]
        public double? CForCred2 { get; set; }
        [Column("cForCred3")]
        public double? CForCred3 { get; set; }
        [Column("cForCred4")]
        public double? CForCred4 { get; set; }
        [Column("cForCred5")]
        public double? CForCred5 { get; set; }
        [Column("cForCred6")]
        public double? CForCred6 { get; set; }
        [Column("cForCred7")]
        public double? CForCred7 { get; set; }
        [Column("cForCred8")]
        public double? CForCred8 { get; set; }
        [Column("cForCred9")]
        public double? CForCred9 { get; set; }
        [Column("cForCred10")]
        public double? CForCred10 { get; set; }
        [Column("cForCred11")]
        public double? CForCred11 { get; set; }
        [Column("cForCred12")]
        public double? CForCred12 { get; set; }
        [Column("cUsrStrs1")]
        [StringLength(39)]
        public string CUsrStrs1 { get; set; }
        [Column("cUsrStrs2")]
        [StringLength(39)]
        public string CUsrStrs2 { get; set; }
        [Column("cUsrStrs3")]
        [StringLength(39)]
        public string CUsrStrs3 { get; set; }
        [Column("cUsrStrs4")]
        [StringLength(39)]
        public string CUsrStrs4 { get; set; }
        [Column("cUsrDates1", TypeName = "datetime")]
        public DateTime? CUsrDates1 { get; set; }
        [Column("cUsrDates2", TypeName = "datetime")]
        public DateTime? CUsrDates2 { get; set; }
        [Column("cUsrDates3", TypeName = "datetime")]
        public DateTime? CUsrDates3 { get; set; }
        [Column("cUsrTable1")]
        public int? CUsrTable1 { get; set; }
        [Column("cUsrTable2")]
        public int? CUsrTable2 { get; set; }
        [Column("cUsrTable3")]
        public int? CUsrTable3 { get; set; }
        [Column("cUsrNums1")]
        public double? CUsrNums1 { get; set; }
        [Column("cUsrNums2")]
        public double? CUsrNums2 { get; set; }
        [Column("cUsrNums3")]
        public double? CUsrNums3 { get; set; }
        [Column("cUsrNums4")]
        public double? CUsrNums4 { get; set; }
        [Column("cUsrNums5")]
        public double? CUsrNums5 { get; set; }
        [Column("cUsrNums6")]
        public double? CUsrNums6 { get; set; }
        [Column("cUsrCnts1")]
        public double? CUsrCnts1 { get; set; }
        [Column("cUsrCnts2")]
        public double? CUsrCnts2 { get; set; }
        [Column("cUsrCnts3")]
        public double? CUsrCnts3 { get; set; }
        [Column("cUsrCnts4")]
        public double? CUsrCnts4 { get; set; }
        [Column("cUsrCnts5")]
        public double? CUsrCnts5 { get; set; }
        [Column("cUsrCnts6")]
        public double? CUsrCnts6 { get; set; }
        [Column("cUsrCnts7")]
        public double? CUsrCnts7 { get; set; }
        [Column("cUsrCnts8")]
        public double? CUsrCnts8 { get; set; }
        [Column("cInvNo1")]
        public int? CInvNo1 { get; set; }
        [Column("cInvVal1")]
        public double? CInvVal1 { get; set; }
        [Column("cInvNo")]
        public int? CInvNo { get; set; }
        [Column("cInvVal")]
        public double? CInvVal { get; set; }
        [Column("cTxtHndl")]
        public int? CTxtHndl { get; set; }
        [Column("cUserId")]
        public int? CUserId { get; set; }
        [Column("cAgeDays")]
        public int? CAgeDays { get; set; }
        [Column("cFirstDays")]
        public int? CFirstDays { get; set; }
        [Column("cInvNo0")]
        public int? CInvNo0 { get; set; }
        [Column("cInvVal0")]
        public double? CInvVal0 { get; set; }
        [Column("cEdi")]
        public short? CEdi { get; set; }
        [Column("cEdiCode")]
        [StringLength(15)]
        public string CEdiCode { get; set; }
        [Column("cEdiPCode")]
        [StringLength(15)]
        public string CEdiPcode { get; set; }
        [Column("cOthExp1")]
        public int? COthExp1 { get; set; }
        [Column("cOthExp2")]
        public int? COthExp2 { get; set; }
        [Column("cMEfkIn")]
        public int? CMefkIn { get; set; }
        [Column("cSenCredit")]
        public int? CSenCredit { get; set; }
        [Column("cSpPrice")]
        public int? CSpPrice { get; set; }
        [Column("cRepCode")]
        [StringLength(15)]
        public string CRepCode { get; set; }
        [Column("cEuro")]
        public double? CEuro { get; set; }
        [Column("c2Code")]
        [StringLength(25)]
        public string C2Code { get; set; }
        [Column("cEmail")]
        [StringLength(59)]
        public string CEmail { get; set; }
        [Column("cKepyoCategory")]
        public int? CKepyoCategory { get; set; }
        [Column("cProfession")]
        [StringLength(39)]
        public string CProfession { get; set; }
        [Column("cSolvency")]
        public int? CSolvency { get; set; }
        [Column("cTxtHndl1")]
        public int? CTxtHndl1 { get; set; }
        [Column("cHouseCateg")]
        [StringLength(1)]
        public string CHouseCateg { get; set; }
        [Column("cKEPYOExcl")]
        public short? CKepyoexcl { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdDate { get; set; }
        [Column("cTaxKind")]
        public int? CTaxKind { get; set; }
        [Column("cEInvActive")]
        public int? CEinvActive { get; set; }
        [Column("cEInvEmail")]
        [StringLength(59)]
        public string CEinvEmail { get; set; }
        [Column("cEInvEncKey")]
        [StringLength(39)]
        public string CEinvEncKey { get; set; }
        [Column("cDOY")]
        [StringLength(39)]
        public string CDoy { get; set; }
        [Column("cMobile")]
        [StringLength(19)]
        public string CMobile { get; set; }
        [Column("cVehicle")]
        [StringLength(19)]
        public string CVehicle { get; set; }
        [Column("cWebsite")]
        [StringLength(39)]
        public string CWebsite { get; set; }
        [Column("cDOYCode")]
        [StringLength(4)]
        public string CDoycode { get; set; }
        [Column("cPointsActive")]
        public short? CPointsActive { get; set; }
        [Column("cPointsApografi")]
        public int? CPointsApografi { get; set; }
        [Column("cPointsEarned")]
        public int? CPointsEarned { get; set; }
        [Column("cPointsUsed")]
        public int? CPointsUsed { get; set; }
        [Column("cPointsUsedValue")]
        public double? CPointsUsedValue { get; set; }
        [Column("cPointsApogrUsed")]
        public int? CPointsApogrUsed { get; set; }
        [Column("cNoFpaArticle")]
        public int? CNoFpaArticle { get; set; }
        [Column("cPointsUseWay")]
        public int? CPointsUseWay { get; set; }
        [Column("cPointsFactor")]
        public double? CPointsFactor { get; set; }
        [Column("cStopDate", TypeName = "datetime")]
        public DateTime? CStopDate { get; set; }
        [Column("cPerifereia")]
        [StringLength(5)]
        public string CPerifereia { get; set; }
        [Column("cDimos")]
        [StringLength(5)]
        public string CDimos { get; set; }
        [Column("cIndividual")]
        public int? CIndividual { get; set; }

        [InverseProperty(nameof(Contact.CncFile))]
        public virtual ICollection<Contact> Contacts { get; set; }
        [InverseProperty(nameof(Ctrn.CFile))]
        public virtual ICollection<Ctrn> Ctrns { get; set; }
        [InverseProperty(nameof(Extext.CFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
        [InverseProperty(nameof(Mmast.CFile))]
        public virtual ICollection<Mmast> Mmasts { get; set; }
    }
}
