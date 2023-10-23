using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LNMAST")]
    [Index(nameof(LCode), Name = "LnBylCode", IsUnique = true)]
    [Index(nameof(LNameSrt), Name = "LnBylName")]
    [Index(nameof(LConnect), Name = "LnByllConnect")]
    public partial class Lnmast
    {
        public Lnmast()
        {
            Extexts = new HashSet<Extext>();
            Lntrns = new HashSet<Lntrn>();
        }

        [Key]
        [Column("lFileId")]
        public int LFileId { get; set; }
        [Required]
        [Column("lCode")]
        [StringLength(15)]
        public string LCode { get; set; }
        [Column("lName")]
        [StringLength(39)]
        public string LName { get; set; }
        [Column("lName_srt")]
        [StringLength(39)]
        public string LNameSrt { get; set; }
        [Column("lConnect")]
        [StringLength(15)]
        public string LConnect { get; set; }
        [Column("lNumber")]
        [StringLength(9)]
        public string LNumber { get; set; }
        [Column("lSerial")]
        [StringLength(19)]
        public string LSerial { get; set; }
        [Column("lInstCode")]
        [StringLength(15)]
        public string LInstCode { get; set; }
        [Column("lCateg")]
        [StringLength(3)]
        public string LCateg { get; set; }
        [Column("lDepart")]
        [StringLength(3)]
        public string LDepart { get; set; }
        [Column("lPosit")]
        [StringLength(3)]
        public string LPosit { get; set; }
        [Column("lDepr")]
        public short? LDepr { get; set; }
        [Column("lActive")]
        public short? LActive { get; set; }
        [Column("lComment")]
        [StringLength(39)]
        public string LComment { get; set; }
        [Column("lDeprmeth")]
        public int? LDeprmeth { get; set; }
        [Column("lFacts1")]
        public double? LFacts1 { get; set; }
        [Column("lFacts2")]
        public double? LFacts2 { get; set; }
        [Column("lFacts3")]
        public double? LFacts3 { get; set; }
        [Column("lYpolimat")]
        public double? LYpolimat { get; set; }
        [Column("lOrio")]
        public short? LOrio { get; set; }
        [Column("lAfapothema")]
        public int? LAfapothema { get; set; }
        [Column("lOper")]
        public short? LOper { get; set; }
        [Column("lEpixor")]
        public double? LEpixor { get; set; }
        [Column("lStartadran", TypeName = "datetime")]
        public DateTime? LStartadran { get; set; }
        [Column("lStopadran", TypeName = "datetime")]
        public DateTime? LStopadran { get; set; }
        [Column("lBuyDate", TypeName = "datetime")]
        public DateTime? LBuyDate { get; set; }
        [Column("lQuant")]
        public double? LQuant { get; set; }
        [Column("lInCost")]
        public double? LInCost { get; set; }
        [Column("lStartCalc", TypeName = "datetime")]
        public DateTime? LStartCalc { get; set; }
        [Column("lStopCalc", TypeName = "datetime")]
        public DateTime? LStopCalc { get; set; }
        [Column("lCommitVal")]
        public double? LCommitVal { get; set; }
        [Column("lTaxValue")]
        public double? LTaxValue { get; set; }
        [Column("lConvDate", TypeName = "datetime")]
        public DateTime? LConvDate { get; set; }
        [Column("lIsolDate", TypeName = "datetime")]
        public DateTime? LIsolDate { get; set; }
        [Column("lQuant1")]
        public double? LQuant1 { get; set; }
        [Column("lLastUpDate", TypeName = "datetime")]
        public DateTime? LLastUpDate { get; set; }
        [Column("lLastGlUpd", TypeName = "datetime")]
        public DateTime? LLastGlUpd { get; set; }
        [Column("lLastlnvUpd", TypeName = "datetime")]
        public DateTime? LLastlnvUpd { get; set; }
        [Column("lRepair")]
        public double? LRepair { get; set; }
        [Column("lService")]
        public double? LService { get; set; }
        [Column("lInstVal")]
        public double? LInstVal { get; set; }
        [Column("lStandh")]
        public int? LStandh { get; set; }
        [Column("lDeprinfo11")]
        public double? LDeprinfo11 { get; set; }
        [Column("lDeprinfo12")]
        public double? LDeprinfo12 { get; set; }
        [Column("lDeprinfo13")]
        public double? LDeprinfo13 { get; set; }
        [Column("lDeprinfo14")]
        public double? LDeprinfo14 { get; set; }
        [Column("lDeprinfo15")]
        public double? LDeprinfo15 { get; set; }
        [Column("lDeprinfo16")]
        public double? LDeprinfo16 { get; set; }
        [Column("lDeprinfo17")]
        public double? LDeprinfo17 { get; set; }
        [Column("lDeprinfo18")]
        public double? LDeprinfo18 { get; set; }
        [Column("lDeprinfo19")]
        public double? LDeprinfo19 { get; set; }
        [Column("lDeprinfo110")]
        public double? LDeprinfo110 { get; set; }
        [Column("lDeprinfo111")]
        public double? LDeprinfo111 { get; set; }
        [Column("lDeprinfo112")]
        public double? LDeprinfo112 { get; set; }
        [Column("lDeprinfo113")]
        public double? LDeprinfo113 { get; set; }
        [Column("lDeprinfo114")]
        public double? LDeprinfo114 { get; set; }
        [Column("lDeprinfo115")]
        public double? LDeprinfo115 { get; set; }
        [Column("lDeprinfo21")]
        public double? LDeprinfo21 { get; set; }
        [Column("lDeprinfo22")]
        public double? LDeprinfo22 { get; set; }
        [Column("lDeprinfo23")]
        public double? LDeprinfo23 { get; set; }
        [Column("lDeprinfo24")]
        public double? LDeprinfo24 { get; set; }
        [Column("lDeprinfo25")]
        public double? LDeprinfo25 { get; set; }
        [Column("lDeprinfo26")]
        public double? LDeprinfo26 { get; set; }
        [Column("lDeprinfo27")]
        public double? LDeprinfo27 { get; set; }
        [Column("lDeprinfo28")]
        public double? LDeprinfo28 { get; set; }
        [Column("lDeprinfo29")]
        public double? LDeprinfo29 { get; set; }
        [Column("lDeprinfo210")]
        public double? LDeprinfo210 { get; set; }
        [Column("lDeprinfo211")]
        public double? LDeprinfo211 { get; set; }
        [Column("lDeprinfo212")]
        public double? LDeprinfo212 { get; set; }
        [Column("lDeprinfo213")]
        public double? LDeprinfo213 { get; set; }
        [Column("lDeprinfo214")]
        public double? LDeprinfo214 { get; set; }
        [Column("lDeprinfo215")]
        public double? LDeprinfo215 { get; set; }
        [Column("lCalced1")]
        public double? LCalced1 { get; set; }
        [Column("lCalced2")]
        public double? LCalced2 { get; set; }
        [Column("lCalced3")]
        public double? LCalced3 { get; set; }
        [Column("lCalced4")]
        public double? LCalced4 { get; set; }
        [Column("lCalced5")]
        public double? LCalced5 { get; set; }
        [Column("lCalced6")]
        public double? LCalced6 { get; set; }
        [Column("lCalced7")]
        public double? LCalced7 { get; set; }
        [Column("lCalced8")]
        public double? LCalced8 { get; set; }
        [Column("lCalced9")]
        public double? LCalced9 { get; set; }
        [Column("lCalced10")]
        public double? LCalced10 { get; set; }
        [Column("lCalced11")]
        public double? LCalced11 { get; set; }
        [Column("lCalced12")]
        public double? LCalced12 { get; set; }
        [Column("lCalced13")]
        public double? LCalced13 { get; set; }
        [Column("lCalced14")]
        public double? LCalced14 { get; set; }
        [Column("lCalced15")]
        public double? LCalced15 { get; set; }
        [Column("lCalced16")]
        public double? LCalced16 { get; set; }
        [Column("lCalced17")]
        public double? LCalced17 { get; set; }
        [Column("lCalced18")]
        public double? LCalced18 { get; set; }
        [Column("lCalced19")]
        public double? LCalced19 { get; set; }
        [Column("lCalced20")]
        public double? LCalced20 { get; set; }
        [Column("lCalced21")]
        public double? LCalced21 { get; set; }
        [Column("lCalced22")]
        public double? LCalced22 { get; set; }
        [Column("lCalced23")]
        public double? LCalced23 { get; set; }
        [Column("lCalced24")]
        public double? LCalced24 { get; set; }
        [Column("lCalced25")]
        public double? LCalced25 { get; set; }
        [Column("lCalced26")]
        public double? LCalced26 { get; set; }
        [Column("lCalced27")]
        public double? LCalced27 { get; set; }
        [Column("lCalced28")]
        public double? LCalced28 { get; set; }
        [Column("lCalced29")]
        public double? LCalced29 { get; set; }
        [Column("lCalced30")]
        public double? LCalced30 { get; set; }
        [Column("lCalced31")]
        public double? LCalced31 { get; set; }
        [Column("lCalced32")]
        public double? LCalced32 { get; set; }
        [Column("lCalced33")]
        public double? LCalced33 { get; set; }
        [Column("lCalced34")]
        public double? LCalced34 { get; set; }
        [Column("lCalced35")]
        public double? LCalced35 { get; set; }
        [Column("lCalced36")]
        public double? LCalced36 { get; set; }
        [Column("lCalced37")]
        public double? LCalced37 { get; set; }
        [Column("lCalced38")]
        public double? LCalced38 { get; set; }
        [Column("lCalced39")]
        public double? LCalced39 { get; set; }
        [Column("lCalced40")]
        public double? LCalced40 { get; set; }
        [Column("lCalced41")]
        public double? LCalced41 { get; set; }
        [Column("lCalced42")]
        public double? LCalced42 { get; set; }
        [Column("lCalced43")]
        public double? LCalced43 { get; set; }
        [Column("lCalced44")]
        public double? LCalced44 { get; set; }
        [Column("lCalced45")]
        public double? LCalced45 { get; set; }
        [Column("lCalced46")]
        public double? LCalced46 { get; set; }
        [Column("lCalced47")]
        public double? LCalced47 { get; set; }
        [Column("lCalced48")]
        public double? LCalced48 { get; set; }
        [Column("lUsrStrs1")]
        [StringLength(39)]
        public string LUsrStrs1 { get; set; }
        [Column("lUsrStrs2")]
        [StringLength(39)]
        public string LUsrStrs2 { get; set; }
        [Column("lUsrStrs3")]
        [StringLength(39)]
        public string LUsrStrs3 { get; set; }
        [Column("lUsrStrs4")]
        [StringLength(39)]
        public string LUsrStrs4 { get; set; }
        [Column("lUsrDates1", TypeName = "datetime")]
        public DateTime? LUsrDates1 { get; set; }
        [Column("lUsrDates2", TypeName = "datetime")]
        public DateTime? LUsrDates2 { get; set; }
        [Column("lUsrDates3", TypeName = "datetime")]
        public DateTime? LUsrDates3 { get; set; }
        [Column("lUsrTable1")]
        public int? LUsrTable1 { get; set; }
        [Column("lUsrTable2")]
        public int? LUsrTable2 { get; set; }
        [Column("lUsrTable3")]
        public int? LUsrTable3 { get; set; }
        [Column("lUsrNums1")]
        public double? LUsrNums1 { get; set; }
        [Column("lUsrNums2")]
        public double? LUsrNums2 { get; set; }
        [Column("lUsrNums3")]
        public double? LUsrNums3 { get; set; }
        [Column("lUsrNums4")]
        public double? LUsrNums4 { get; set; }
        [Column("lUsrNums5")]
        public double? LUsrNums5 { get; set; }
        [Column("lUsrNums6")]
        public double? LUsrNums6 { get; set; }
        [Column("lUsrCnts1")]
        public double? LUsrCnts1 { get; set; }
        [Column("lUsrCnts2")]
        public double? LUsrCnts2 { get; set; }
        [Column("lUsrCnts3")]
        public double? LUsrCnts3 { get; set; }
        [Column("lUsrCnts4")]
        public double? LUsrCnts4 { get; set; }
        [Column("lUsrCnts5")]
        public double? LUsrCnts5 { get; set; }
        [Column("lUsrCnts6")]
        public double? LUsrCnts6 { get; set; }
        [Column("lUsrCnts7")]
        public double? LUsrCnts7 { get; set; }
        [Column("lUsrCnts8")]
        public double? LUsrCnts8 { get; set; }
        [Column("linsvalue1")]
        public double? Linsvalue1 { get; set; }
        [Column("linscomp1")]
        [StringLength(21)]
        public string Linscomp1 { get; set; }
        [Column("linsno1")]
        [StringLength(15)]
        public string Linsno1 { get; set; }
        [Column("linsend1", TypeName = "datetime")]
        public DateTime? Linsend1 { get; set; }
        [Column("linskind1")]
        [StringLength(9)]
        public string Linskind1 { get; set; }
        [Column("linsvalue2")]
        public double? Linsvalue2 { get; set; }
        [Column("linscomp2")]
        [StringLength(21)]
        public string Linscomp2 { get; set; }
        [Column("linsno2")]
        [StringLength(15)]
        public string Linsno2 { get; set; }
        [Column("linsend2", TypeName = "datetime")]
        public DateTime? Linsend2 { get; set; }
        [Column("linskind2")]
        [StringLength(9)]
        public string Linskind2 { get; set; }
        [Column("linsvalue3")]
        public double? Linsvalue3 { get; set; }
        [Column("linscomp3")]
        [StringLength(21)]
        public string Linscomp3 { get; set; }
        [Column("linsno3")]
        [StringLength(15)]
        public string Linsno3 { get; set; }
        [Column("linsend3", TypeName = "datetime")]
        public DateTime? Linsend3 { get; set; }
        [Column("linskind3")]
        [StringLength(9)]
        public string Linskind3 { get; set; }
        [Column("linsvalue4")]
        public double? Linsvalue4 { get; set; }
        [Column("linscomp4")]
        [StringLength(21)]
        public string Linscomp4 { get; set; }
        [Column("linsno4")]
        [StringLength(15)]
        public string Linsno4 { get; set; }
        [Column("linsend4", TypeName = "datetime")]
        public DateTime? Linsend4 { get; set; }
        [Column("linskind4")]
        [StringLength(9)]
        public string Linskind4 { get; set; }
        [Column("lGCodes1")]
        [StringLength(25)]
        public string LGcodes1 { get; set; }
        [Column("lGCodes2")]
        [StringLength(25)]
        public string LGcodes2 { get; set; }
        [Column("lGCodes3")]
        [StringLength(25)]
        public string LGcodes3 { get; set; }
        [Column("lGCodes4")]
        [StringLength(25)]
        public string LGcodes4 { get; set; }
        [Column("lGCodes5")]
        [StringLength(25)]
        public string LGcodes5 { get; set; }
        [Column("lGCodes6")]
        [StringLength(25)]
        public string LGcodes6 { get; set; }
        [Column("lGCodes7")]
        [StringLength(25)]
        public string LGcodes7 { get; set; }
        [Column("lGCodes8")]
        [StringLength(25)]
        public string LGcodes8 { get; set; }
        [Column("lGCodes9")]
        [StringLength(25)]
        public string LGcodes9 { get; set; }
        [Column("lGCodes10")]
        [StringLength(25)]
        public string LGcodes10 { get; set; }
        [Column("lGCodes11")]
        [StringLength(25)]
        public string LGcodes11 { get; set; }
        [Column("lGCodes12")]
        [StringLength(25)]
        public string LGcodes12 { get; set; }
        [Column("lAnalCode0")]
        [StringLength(25)]
        public string LAnalCode0 { get; set; }
        [Column("lPerCent0")]
        public double? LPerCent0 { get; set; }
        [Column("lAnalCode1")]
        [StringLength(25)]
        public string LAnalCode1 { get; set; }
        [Column("lPerCent1")]
        public double? LPerCent1 { get; set; }
        [Column("lAnalCode2")]
        [StringLength(25)]
        public string LAnalCode2 { get; set; }
        [Column("lPerCent2")]
        public double? LPerCent2 { get; set; }
        [Column("lAnalCode3")]
        [StringLength(25)]
        public string LAnalCode3 { get; set; }
        [Column("lPerCent3")]
        public double? LPerCent3 { get; set; }
        [Column("lAnalCode4")]
        [StringLength(25)]
        public string LAnalCode4 { get; set; }
        [Column("lPerCent4")]
        public double? LPerCent4 { get; set; }
        [Column("lAnalCode5")]
        [StringLength(25)]
        public string LAnalCode5 { get; set; }
        [Column("lPerCent5")]
        public double? LPerCent5 { get; set; }
        [Column("lAnalCode6")]
        [StringLength(25)]
        public string LAnalCode6 { get; set; }
        [Column("lPerCent6")]
        public double? LPerCent6 { get; set; }
        [Column("lAnalCode7")]
        [StringLength(25)]
        public string LAnalCode7 { get; set; }
        [Column("lPerCent7")]
        public double? LPerCent7 { get; set; }
        [Column("lAnalCode8")]
        [StringLength(25)]
        public string LAnalCode8 { get; set; }
        [Column("lPerCent8")]
        public double? LPerCent8 { get; set; }
        [Column("lAnalCode9")]
        [StringLength(25)]
        public string LAnalCode9 { get; set; }
        [Column("lPerCent9")]
        public double? LPerCent9 { get; set; }
        [Column("lAnalCode10")]
        [StringLength(25)]
        public string LAnalCode10 { get; set; }
        [Column("lPerCent10")]
        public double? LPerCent10 { get; set; }
        [Column("lInsDate", TypeName = "datetime")]
        public DateTime? LInsDate { get; set; }
        [Column("lId")]
        public int? LId { get; set; }
        [Column("lHandle")]
        public short? LHandle { get; set; }
        [Column("lGCodes_1")]
        [StringLength(25)]
        public string LGcodes13 { get; set; }
        [Column("lGCodes_2")]
        [StringLength(25)]
        public string LGcodes21 { get; set; }
        [Column("lUtlAccount")]
        [StringLength(25)]
        public string LUtlAccount { get; set; }
        [Column("lTextHandle1")]
        public int? LTextHandle1 { get; set; }
        [Column("lEuroValue")]
        public double? LEuroValue { get; set; }
        [Column("lEuroDepr")]
        public double? LEuroDepr { get; set; }
        [Column("lTextHandle")]
        public int? LTextHandle { get; set; }

        [InverseProperty(nameof(Extext.LFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
        [InverseProperty(nameof(Lntrn.LtmposNavigation))]
        public virtual ICollection<Lntrn> Lntrns { get; set; }
    }
}
