using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LNTRN")]
    [Index(nameof(Ltdate), nameof(Insdate), nameof(Lttime), Name = "LtByltDate")]
    [Index(nameof(Ltmpos), nameof(Ltdate), nameof(Insdate), nameof(Lttime), Name = "ltByLmFileId1")]
    [Index(nameof(Ltmpos), nameof(Ltbuyid), nameof(Ltdate), nameof(Ltdateid), Name = "ltByLmFileId2")]
    [Index(nameof(Ltmpos), nameof(Ltbuyid), nameof(Ltdate), nameof(Ltkind), Name = "ltByLmFileId3")]
    [Index(nameof(Ltmpos), nameof(Ltdate), nameof(Ltdateid), Name = "ltByLmFileId4")]
    public partial class Lntrn
    {
        public Lntrn()
        {
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("ltFileId")]
        public int LtFileId { get; set; }
        [Column("ltdate", TypeName = "datetime")]
        public DateTime Ltdate { get; set; }
        [Column("ltmpos")]
        public int Ltmpos { get; set; }
        [Column("insdate", TypeName = "datetime")]
        public DateTime? Insdate { get; set; }
        [Column("lttime", TypeName = "datetime")]
        public DateTime? Lttime { get; set; }
        [Column("ltbuyid")]
        public int? Ltbuyid { get; set; }
        [Column("ltstartd", TypeName = "datetime")]
        public DateTime? Ltstartd { get; set; }
        [Column("ltdateid")]
        public int? Ltdateid { get; set; }
        [Column("ltcause")]
        [StringLength(39)]
        public string Ltcause { get; set; }
        [Column("ltkind")]
        public int Ltkind { get; set; }
        [Column("ltdoc")]
        [StringLength(9)]
        public string Ltdoc { get; set; }
        [Column("ltenddate", TypeName = "datetime")]
        public DateTime? Ltenddate { get; set; }
        [Column("ltcalced11")]
        public double? Ltcalced11 { get; set; }
        [Column("ltcalced21")]
        public double? Ltcalced21 { get; set; }
        [Column("ltcalced12")]
        public double? Ltcalced12 { get; set; }
        [Column("ltcalced22")]
        public double? Ltcalced22 { get; set; }
        [Column("ltcalced13")]
        public double? Ltcalced13 { get; set; }
        [Column("ltcalced23")]
        public double? Ltcalced23 { get; set; }
        [Column("ltcalced14")]
        public double? Ltcalced14 { get; set; }
        [Column("ltcalced24")]
        public double? Ltcalced24 { get; set; }
        [Column("ltcalced15")]
        public double? Ltcalced15 { get; set; }
        [Column("ltcalced25")]
        public double? Ltcalced25 { get; set; }
        [Column("ltcalced16")]
        public double? Ltcalced16 { get; set; }
        [Column("ltcalced26")]
        public double? Ltcalced26 { get; set; }
        [Column("ltcalced17")]
        public double? Ltcalced17 { get; set; }
        [Column("ltcalced27")]
        public double? Ltcalced27 { get; set; }
        [Column("ltcalced18")]
        public double? Ltcalced18 { get; set; }
        [Column("ltcalced28")]
        public double? Ltcalced28 { get; set; }
        [Column("ltcalced19")]
        public double? Ltcalced19 { get; set; }
        [Column("ltcalced29")]
        public double? Ltcalced29 { get; set; }
        [Column("ltcalced110")]
        public double? Ltcalced110 { get; set; }
        [Column("ltcalced210")]
        public double? Ltcalced210 { get; set; }
        [Column("ltcalced111")]
        public double? Ltcalced111 { get; set; }
        [Column("ltcalced211")]
        public double? Ltcalced211 { get; set; }
        [Column("ltcalced112")]
        public double? Ltcalced112 { get; set; }
        [Column("ltcalced212")]
        public double? Ltcalced212 { get; set; }
        [Column("ltbuykind")]
        public int? Ltbuykind { get; set; }
        [Column("ltthirdv1")]
        public double? Ltthirdv1 { get; set; }
        [Column("ltthirdv2")]
        public double? Ltthirdv2 { get; set; }
        [Column("ltthirdd1")]
        public double? Ltthirdd1 { get; set; }
        [Column("ltthirdd2")]
        public double? Ltthirdd2 { get; set; }
        [Column("ltacause")]
        public int? Ltacause { get; set; }
        [Column("ltfact")]
        public double? Ltfact { get; set; }
        [Column("ltcomm")]
        [StringLength(39)]
        public string Ltcomm { get; set; }
        [Column("ltfpa")]
        [StringLength(3)]
        public string Ltfpa { get; set; }
        [Column("ltsupcode")]
        [StringLength(15)]
        public string Ltsupcode { get; set; }
        [Column("ltsuppl")]
        [StringLength(39)]
        public string Ltsuppl { get; set; }
        [Column("ltxn")]
        [StringLength(3)]
        public string Ltxn { get; set; }
        [Column("ltquant")]
        public double? Ltquant { get; set; }
        [Column("lttaxval")]
        public double? Lttaxval { get; set; }
        [Column("lttaxxnv")]
        public double? Lttaxxnv { get; set; }
        [Column("ltvalue")]
        public double? Ltvalue { get; set; }
        [Column("ltxnvalu")]
        public double? Ltxnvalu { get; set; }
        [Column("lttollval")]
        public double? Lttollval { get; set; }
        [Column("lttollxnV")]
        public double? LttollxnV { get; set; }
        [Column("ltgcodes1")]
        [StringLength(25)]
        public string Ltgcodes1 { get; set; }
        [Column("ltgcodes2")]
        [StringLength(25)]
        public string Ltgcodes2 { get; set; }
        [Column("ltgcodes3")]
        [StringLength(25)]
        public string Ltgcodes3 { get; set; }
        [Column("ltstartqu")]
        public double? Ltstartqu { get; set; }
        [Column("ltstartV1")]
        public double? LtstartV1 { get; set; }
        [Column("ltstartV2")]
        public double? LtstartV2 { get; set; }
        [Column("ltprevv1")]
        public double? Ltprevv1 { get; set; }
        [Column("ltprevv2")]
        public double? Ltprevv2 { get; set; }
        [Column("ltbuyquant")]
        public double? Ltbuyquant { get; set; }
        [Column("ltbuyval1")]
        public double? Ltbuyval1 { get; set; }
        [Column("ltbuyval2")]
        public double? Ltbuyval2 { get; set; }
        [Column("ltdeprVa1")]
        public double? LtdeprVa1 { get; set; }
        [Column("ltdeprVa2")]
        public double? LtdeprVa2 { get; set; }
        [Column("ltpagupd", TypeName = "datetime")]
        public DateTime? Ltpagupd { get; set; }
        [Column("ltprevv11")]
        public double? Ltprevv11 { get; set; }
        [Column("ltprevv12")]
        public double? Ltprevv12 { get; set; }
        [Column("ltisoldate", TypeName = "datetime")]
        public DateTime? Ltisoldate { get; set; }
        [Column("ltMaKthsV1")]
        public double? LtMaKthsV1 { get; set; }
        [Column("ltMaKthsV2")]
        public double? LtMaKthsV2 { get; set; }
        [Column("ltMaAposV1")]
        public double? LtMaAposV1 { get; set; }
        [Column("ltMaAposV2")]
        public double? LtMaAposV2 { get; set; }
        [Column("ltMAposV11")]
        public double? LtMaposV11 { get; set; }
        [Column("ltMAposV12")]
        public double? LtMaposV12 { get; set; }
        [Column("ltMAposV21")]
        public double? LtMaposV21 { get; set; }
        [Column("ltMAposV22")]
        public double? LtMaposV22 { get; set; }
        [Column("ltFromFile")]
        public int? LtFromFile { get; set; }
        [Column("ltPrinted")]
        public int? LtPrinted { get; set; }
        [Column("ltVATid")]
        public int? LtVatid { get; set; }
        [Column("ltFromGrp")]
        public int? LtFromGrp { get; set; }
        [Column("ltperiodSt", TypeName = "datetime")]
        public DateTime? LtperiodSt { get; set; }
        [Column("ltcppos")]
        public int? Ltcppos { get; set; }
        [Column("ltcptrpos1")]
        public int? Ltcptrpos1 { get; set; }
        [Column("ltcptrpos2")]
        public int? Ltcptrpos2 { get; set; }
        [Column("ltcptrpos3")]
        public int? Ltcptrpos3 { get; set; }
        [Column("ltprice")]
        public double? Ltprice { get; set; }
        [Column("ltxnprice")]
        public double? Ltxnprice { get; set; }
        [Column("ltidle1")]
        public short? Ltidle1 { get; set; }
        [Column("ltidle2")]
        public short? Ltidle2 { get; set; }
        [Column("ltnotavail")]
        public short? Ltnotavail { get; set; }
        [Column("ltid")]
        public int? Ltid { get; set; }
        [Column("ltEuroValue")]
        public double? LtEuroValue { get; set; }
        [Column("ltEuroDepr")]
        public double? LtEuroDepr { get; set; }

        [ForeignKey(nameof(Ltkind))]
        [InverseProperty(nameof(Assettrndesc.Lntrns))]
        public virtual Assettrndesc LtkindNavigation { get; set; }
        [ForeignKey(nameof(Ltmpos))]
        [InverseProperty(nameof(Lnmast.Lntrns))]
        public virtual Lnmast LtmposNavigation { get; set; }
        [InverseProperty(nameof(Extext.LtFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
