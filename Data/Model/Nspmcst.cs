using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSPMCST")]
    [Index(nameof(PrcSpLevel), Name = "prcBySpLevel")]
    [Index(nameof(SFileId), Name = "prcBysFileId", IsUnique = true)]
    public partial class Nspmcst
    {
        [Key]
        [Column("prcFileId")]
        public int PrcFileId { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Column("prcSpLevel")]
        public int? PrcSpLevel { get; set; }
        [Column("prcScCateg1")]
        public int? PrcScCateg1 { get; set; }
        [Column("prcScAllocMeth1")]
        public int? PrcScAllocMeth1 { get; set; }
        [Column("prcScExpCode1")]
        public int? PrcScExpCode1 { get; set; }
        [Column("prcScFactor1")]
        public double? PrcScFactor1 { get; set; }
        [Column("prcScCateg2")]
        public int? PrcScCateg2 { get; set; }
        [Column("prcScAllocMeth2")]
        public int? PrcScAllocMeth2 { get; set; }
        [Column("prcScExpCode2")]
        public int? PrcScExpCode2 { get; set; }
        [Column("prcScFactor2")]
        public double? PrcScFactor2 { get; set; }
        [Column("prcScCateg3")]
        public int? PrcScCateg3 { get; set; }
        [Column("prcScAllocMeth3")]
        public int? PrcScAllocMeth3 { get; set; }
        [Column("prcScExpCode3")]
        public int? PrcScExpCode3 { get; set; }
        [Column("prcScFactor3")]
        public double? PrcScFactor3 { get; set; }
        [Column("prcScCateg4")]
        public int? PrcScCateg4 { get; set; }
        [Column("prcScAllocMeth4")]
        public int? PrcScAllocMeth4 { get; set; }
        [Column("prcScExpCode4")]
        public int? PrcScExpCode4 { get; set; }
        [Column("prcScFactor4")]
        public double? PrcScFactor4 { get; set; }
        [Column("prcScCateg5")]
        public int? PrcScCateg5 { get; set; }
        [Column("prcScAllocMeth5")]
        public int? PrcScAllocMeth5 { get; set; }
        [Column("prcScExpCode5")]
        public int? PrcScExpCode5 { get; set; }
        [Column("prcScFactor5")]
        public double? PrcScFactor5 { get; set; }
        [Column("prcScCateg6")]
        public int? PrcScCateg6 { get; set; }
        [Column("prcScAllocMeth6")]
        public int? PrcScAllocMeth6 { get; set; }
        [Column("prcScExpCode6")]
        public int? PrcScExpCode6 { get; set; }
        [Column("prcScFactor6")]
        public double? PrcScFactor6 { get; set; }
        [Column("prcScCateg7")]
        public int? PrcScCateg7 { get; set; }
        [Column("prcScAllocMeth7")]
        public int? PrcScAllocMeth7 { get; set; }
        [Column("prcScExpCode7")]
        public int? PrcScExpCode7 { get; set; }
        [Column("prcScFactor7")]
        public double? PrcScFactor7 { get; set; }
        [Column("prcScCateg8")]
        public int? PrcScCateg8 { get; set; }
        [Column("prcScAllocMeth8")]
        public int? PrcScAllocMeth8 { get; set; }
        [Column("prcScExpCode8")]
        public int? PrcScExpCode8 { get; set; }
        [Column("prcScFactor8")]
        public double? PrcScFactor8 { get; set; }
        [Column("prcScCateg9")]
        public int? PrcScCateg9 { get; set; }
        [Column("prcScAllocMeth9")]
        public int? PrcScAllocMeth9 { get; set; }
        [Column("prcScExpCode9")]
        public int? PrcScExpCode9 { get; set; }
        [Column("prcScFactor9")]
        public double? PrcScFactor9 { get; set; }
        [Column("prcScCateg10")]
        public int? PrcScCateg10 { get; set; }
        [Column("prcScAllocMeth10")]
        public int? PrcScAllocMeth10 { get; set; }
        [Column("prcScExpCode10")]
        public int? PrcScExpCode10 { get; set; }
        [Column("prcScFactor10")]
        public double? PrcScFactor10 { get; set; }
        [Column("prcScCateg11")]
        public int? PrcScCateg11 { get; set; }
        [Column("prcScAllocMeth11")]
        public int? PrcScAllocMeth11 { get; set; }
        [Column("prcScExpCode11")]
        public int? PrcScExpCode11 { get; set; }
        [Column("prcScFactor11")]
        public double? PrcScFactor11 { get; set; }
        [Column("prcScCateg12")]
        public int? PrcScCateg12 { get; set; }
        [Column("prcScAllocMeth12")]
        public int? PrcScAllocMeth12 { get; set; }
        [Column("prcScExpCode12")]
        public int? PrcScExpCode12 { get; set; }
        [Column("prcScFactor12")]
        public double? PrcScFactor12 { get; set; }
        [Column("prcScCateg13")]
        public int? PrcScCateg13 { get; set; }
        [Column("prcScAllocMeth13")]
        public int? PrcScAllocMeth13 { get; set; }
        [Column("prcScExpCode13")]
        public int? PrcScExpCode13 { get; set; }
        [Column("prcScFactor13")]
        public double? PrcScFactor13 { get; set; }
        [Column("prcScCateg14")]
        public int? PrcScCateg14 { get; set; }
        [Column("prcScAllocMeth14")]
        public int? PrcScAllocMeth14 { get; set; }
        [Column("prcScExpCode14")]
        public int? PrcScExpCode14 { get; set; }
        [Column("prcScFactor14")]
        public double? PrcScFactor14 { get; set; }
        [Column("prcScCateg15")]
        public int? PrcScCateg15 { get; set; }
        [Column("prcScAllocMeth15")]
        public int? PrcScAllocMeth15 { get; set; }
        [Column("prcScExpCode15")]
        public int? PrcScExpCode15 { get; set; }
        [Column("prcScFactor15")]
        public double? PrcScFactor15 { get; set; }
        [Column("prcScCateg16")]
        public int? PrcScCateg16 { get; set; }
        [Column("prcScAllocMeth16")]
        public int? PrcScAllocMeth16 { get; set; }
        [Column("prcScExpCode16")]
        public int? PrcScExpCode16 { get; set; }
        [Column("prcScFactor16")]
        public double? PrcScFactor16 { get; set; }
        [Column("prcScCateg17")]
        public int? PrcScCateg17 { get; set; }
        [Column("prcScAllocMeth17")]
        public int? PrcScAllocMeth17 { get; set; }
        [Column("prcScExpCode17")]
        public int? PrcScExpCode17 { get; set; }
        [Column("prcScFactor17")]
        public double? PrcScFactor17 { get; set; }
        [Column("prcScCateg18")]
        public int? PrcScCateg18 { get; set; }
        [Column("prcScAllocMeth18")]
        public int? PrcScAllocMeth18 { get; set; }
        [Column("prcScExpCode18")]
        public int? PrcScExpCode18 { get; set; }
        [Column("prcScFactor18")]
        public double? PrcScFactor18 { get; set; }
        [Column("prcScCateg19")]
        public int? PrcScCateg19 { get; set; }
        [Column("prcScAllocMeth19")]
        public int? PrcScAllocMeth19 { get; set; }
        [Column("prcScExpCode19")]
        public int? PrcScExpCode19 { get; set; }
        [Column("prcScFactor19")]
        public double? PrcScFactor19 { get; set; }
        [Column("prcScCateg20")]
        public int? PrcScCateg20 { get; set; }
        [Column("prcScAllocMeth20")]
        public int? PrcScAllocMeth20 { get; set; }
        [Column("prcScExpCode20")]
        public int? PrcScExpCode20 { get; set; }
        [Column("prcScFactor20")]
        public double? PrcScFactor20 { get; set; }
        [Column("prcScCateg21")]
        public int? PrcScCateg21 { get; set; }
        [Column("prcScAllocMeth21")]
        public int? PrcScAllocMeth21 { get; set; }
        [Column("prcScExpCode21")]
        public int? PrcScExpCode21 { get; set; }
        [Column("prcScFactor21")]
        public double? PrcScFactor21 { get; set; }
        [Column("prcScCateg22")]
        public int? PrcScCateg22 { get; set; }
        [Column("prcScAllocMeth22")]
        public int? PrcScAllocMeth22 { get; set; }
        [Column("prcScExpCode22")]
        public int? PrcScExpCode22 { get; set; }
        [Column("prcScFactor22")]
        public double? PrcScFactor22 { get; set; }
        [Column("prcScCateg23")]
        public int? PrcScCateg23 { get; set; }
        [Column("prcScAllocMeth23")]
        public int? PrcScAllocMeth23 { get; set; }
        [Column("prcScExpCode23")]
        public int? PrcScExpCode23 { get; set; }
        [Column("prcScFactor23")]
        public double? PrcScFactor23 { get; set; }
        [Column("prcScCateg24")]
        public int? PrcScCateg24 { get; set; }
        [Column("prcScAllocMeth24")]
        public int? PrcScAllocMeth24 { get; set; }
        [Column("prcScExpCode24")]
        public int? PrcScExpCode24 { get; set; }
        [Column("prcScFactor24")]
        public double? PrcScFactor24 { get; set; }
        [Column("prcScCateg25")]
        public int? PrcScCateg25 { get; set; }
        [Column("prcScAllocMeth25")]
        public int? PrcScAllocMeth25 { get; set; }
        [Column("prcScExpCode25")]
        public int? PrcScExpCode25 { get; set; }
        [Column("prcScFactor25")]
        public double? PrcScFactor25 { get; set; }
        [Column("prcScCateg26")]
        public int? PrcScCateg26 { get; set; }
        [Column("prcScAllocMeth26")]
        public int? PrcScAllocMeth26 { get; set; }
        [Column("prcScExpCode26")]
        public int? PrcScExpCode26 { get; set; }
        [Column("prcScFactor26")]
        public double? PrcScFactor26 { get; set; }
        [Column("prcScCateg27")]
        public int? PrcScCateg27 { get; set; }
        [Column("prcScAllocMeth27")]
        public int? PrcScAllocMeth27 { get; set; }
        [Column("prcScExpCode27")]
        public int? PrcScExpCode27 { get; set; }
        [Column("prcScFactor27")]
        public double? PrcScFactor27 { get; set; }
        [Column("prcScCateg28")]
        public int? PrcScCateg28 { get; set; }
        [Column("prcScAllocMeth28")]
        public int? PrcScAllocMeth28 { get; set; }
        [Column("prcScExpCode28")]
        public int? PrcScExpCode28 { get; set; }
        [Column("prcScFactor28")]
        public double? PrcScFactor28 { get; set; }
        [Column("prcScCateg29")]
        public int? PrcScCateg29 { get; set; }
        [Column("prcScAllocMeth29")]
        public int? PrcScAllocMeth29 { get; set; }
        [Column("prcScExpCode29")]
        public int? PrcScExpCode29 { get; set; }
        [Column("prcScFactor29")]
        public double? PrcScFactor29 { get; set; }
        [Column("prcScCateg30")]
        public int? PrcScCateg30 { get; set; }
        [Column("prcScAllocMeth30")]
        public int? PrcScAllocMeth30 { get; set; }
        [Column("prcScExpCode30")]
        public int? PrcScExpCode30 { get; set; }
        [Column("prcScFactor30")]
        public double? PrcScFactor30 { get; set; }
        [Column("prcScCateg31")]
        public int? PrcScCateg31 { get; set; }
        [Column("prcScAllocMeth31")]
        public int? PrcScAllocMeth31 { get; set; }
        [Column("prcScExpCode31")]
        public int? PrcScExpCode31 { get; set; }
        [Column("prcScFactor31")]
        public double? PrcScFactor31 { get; set; }
        [Column("prcScCateg32")]
        public int? PrcScCateg32 { get; set; }
        [Column("prcScAllocMeth32")]
        public int? PrcScAllocMeth32 { get; set; }
        [Column("prcScExpCode32")]
        public int? PrcScExpCode32 { get; set; }
        [Column("prcScFactor32")]
        public double? PrcScFactor32 { get; set; }
        [Column("prcScCateg33")]
        public int? PrcScCateg33 { get; set; }
        [Column("prcScAllocMeth33")]
        public int? PrcScAllocMeth33 { get; set; }
        [Column("prcScExpCode33")]
        public int? PrcScExpCode33 { get; set; }
        [Column("prcScFactor33")]
        public double? PrcScFactor33 { get; set; }
        [Column("prcScCateg34")]
        public int? PrcScCateg34 { get; set; }
        [Column("prcScAllocMeth34")]
        public int? PrcScAllocMeth34 { get; set; }
        [Column("prcScExpCode34")]
        public int? PrcScExpCode34 { get; set; }
        [Column("prcScFactor34")]
        public double? PrcScFactor34 { get; set; }
        [Column("prcScCateg35")]
        public int? PrcScCateg35 { get; set; }
        [Column("prcScAllocMeth35")]
        public int? PrcScAllocMeth35 { get; set; }
        [Column("prcScExpCode35")]
        public int? PrcScExpCode35 { get; set; }
        [Column("prcScFactor35")]
        public double? PrcScFactor35 { get; set; }
        [Column("prcScCateg36")]
        public int? PrcScCateg36 { get; set; }
        [Column("prcScAllocMeth36")]
        public int? PrcScAllocMeth36 { get; set; }
        [Column("prcScExpCode36")]
        public int? PrcScExpCode36 { get; set; }
        [Column("prcScFactor36")]
        public double? PrcScFactor36 { get; set; }
        [Column("prcScCateg37")]
        public int? PrcScCateg37 { get; set; }
        [Column("prcScAllocMeth37")]
        public int? PrcScAllocMeth37 { get; set; }
        [Column("prcScExpCode37")]
        public int? PrcScExpCode37 { get; set; }
        [Column("prcScFactor37")]
        public double? PrcScFactor37 { get; set; }
        [Column("prcScCateg38")]
        public int? PrcScCateg38 { get; set; }
        [Column("prcScAllocMeth38")]
        public int? PrcScAllocMeth38 { get; set; }
        [Column("prcScExpCode38")]
        public int? PrcScExpCode38 { get; set; }
        [Column("prcScFactor38")]
        public double? PrcScFactor38 { get; set; }
        [Column("prcScCateg39")]
        public int? PrcScCateg39 { get; set; }
        [Column("prcScAllocMeth39")]
        public int? PrcScAllocMeth39 { get; set; }
        [Column("prcScExpCode39")]
        public int? PrcScExpCode39 { get; set; }
        [Column("prcScFactor39")]
        public double? PrcScFactor39 { get; set; }
        [Column("prcScCateg40")]
        public int? PrcScCateg40 { get; set; }
        [Column("prcScAllocMeth40")]
        public int? PrcScAllocMeth40 { get; set; }
        [Column("prcScExpCode40")]
        public int? PrcScExpCode40 { get; set; }
        [Column("prcScFactor40")]
        public double? PrcScFactor40 { get; set; }
        [Column("prcScCateg41")]
        public int? PrcScCateg41 { get; set; }
        [Column("prcScAllocMeth41")]
        public int? PrcScAllocMeth41 { get; set; }
        [Column("prcScExpCode41")]
        public int? PrcScExpCode41 { get; set; }
        [Column("prcScFactor41")]
        public double? PrcScFactor41 { get; set; }
        [Column("prcScCateg42")]
        public int? PrcScCateg42 { get; set; }
        [Column("prcScAllocMeth42")]
        public int? PrcScAllocMeth42 { get; set; }
        [Column("prcScExpCode42")]
        public int? PrcScExpCode42 { get; set; }
        [Column("prcScFactor42")]
        public double? PrcScFactor42 { get; set; }
        [Column("prcScCateg43")]
        public int? PrcScCateg43 { get; set; }
        [Column("prcScAllocMeth43")]
        public int? PrcScAllocMeth43 { get; set; }
        [Column("prcScExpCode43")]
        public int? PrcScExpCode43 { get; set; }
        [Column("prcScFactor43")]
        public double? PrcScFactor43 { get; set; }
        [Column("prcScCateg44")]
        public int? PrcScCateg44 { get; set; }
        [Column("prcScAllocMeth44")]
        public int? PrcScAllocMeth44 { get; set; }
        [Column("prcScExpCode44")]
        public int? PrcScExpCode44 { get; set; }
        [Column("prcScFactor44")]
        public double? PrcScFactor44 { get; set; }
        [Column("prcScCateg45")]
        public int? PrcScCateg45 { get; set; }
        [Column("prcScAllocMeth45")]
        public int? PrcScAllocMeth45 { get; set; }
        [Column("prcScExpCode45")]
        public int? PrcScExpCode45 { get; set; }
        [Column("prcScFactor45")]
        public double? PrcScFactor45 { get; set; }
        [Column("prcScCateg46")]
        public int? PrcScCateg46 { get; set; }
        [Column("prcScAllocMeth46")]
        public int? PrcScAllocMeth46 { get; set; }
        [Column("prcScExpCode46")]
        public int? PrcScExpCode46 { get; set; }
        [Column("prcScFactor46")]
        public double? PrcScFactor46 { get; set; }
        [Column("prcScCateg47")]
        public int? PrcScCateg47 { get; set; }
        [Column("prcScAllocMeth47")]
        public int? PrcScAllocMeth47 { get; set; }
        [Column("prcScExpCode47")]
        public int? PrcScExpCode47 { get; set; }
        [Column("prcScFactor47")]
        public double? PrcScFactor47 { get; set; }
        [Column("prcScCateg48")]
        public int? PrcScCateg48 { get; set; }
        [Column("prcScAllocMeth48")]
        public int? PrcScAllocMeth48 { get; set; }
        [Column("prcScExpCode48")]
        public int? PrcScExpCode48 { get; set; }
        [Column("prcScFactor48")]
        public double? PrcScFactor48 { get; set; }
        [Column("prcScCateg49")]
        public int? PrcScCateg49 { get; set; }
        [Column("prcScAllocMeth49")]
        public int? PrcScAllocMeth49 { get; set; }
        [Column("prcScExpCode49")]
        public int? PrcScExpCode49 { get; set; }
        [Column("prcScFactor49")]
        public double? PrcScFactor49 { get; set; }
        [Column("prcScCateg50")]
        public int? PrcScCateg50 { get; set; }
        [Column("prcScAllocMeth50")]
        public int? PrcScAllocMeth50 { get; set; }
        [Column("prcScExpCode50")]
        public int? PrcScExpCode50 { get; set; }
        [Column("prcScFactor50")]
        public double? PrcScFactor50 { get; set; }
        [Column("prcScCateg51")]
        public int? PrcScCateg51 { get; set; }
        [Column("prcScAllocMeth51")]
        public int? PrcScAllocMeth51 { get; set; }
        [Column("prcScExpCode51")]
        public int? PrcScExpCode51 { get; set; }
        [Column("prcScFactor51")]
        public double? PrcScFactor51 { get; set; }
        [Column("prcScCateg52")]
        public int? PrcScCateg52 { get; set; }
        [Column("prcScAllocMeth52")]
        public int? PrcScAllocMeth52 { get; set; }
        [Column("prcScExpCode52")]
        public int? PrcScExpCode52 { get; set; }
        [Column("prcScFactor52")]
        public double? PrcScFactor52 { get; set; }
        [Column("prcScCateg53")]
        public int? PrcScCateg53 { get; set; }
        [Column("prcScAllocMeth53")]
        public int? PrcScAllocMeth53 { get; set; }
        [Column("prcScExpCode53")]
        public int? PrcScExpCode53 { get; set; }
        [Column("prcScFactor53")]
        public double? PrcScFactor53 { get; set; }
        [Column("prcScCateg54")]
        public int? PrcScCateg54 { get; set; }
        [Column("prcScAllocMeth54")]
        public int? PrcScAllocMeth54 { get; set; }
        [Column("prcScExpCode54")]
        public int? PrcScExpCode54 { get; set; }
        [Column("prcScFactor54")]
        public double? PrcScFactor54 { get; set; }
        [Column("prcScCateg55")]
        public int? PrcScCateg55 { get; set; }
        [Column("prcScAllocMeth55")]
        public int? PrcScAllocMeth55 { get; set; }
        [Column("prcScExpCode55")]
        public int? PrcScExpCode55 { get; set; }
        [Column("prcScFactor55")]
        public double? PrcScFactor55 { get; set; }
        [Column("prcScCateg56")]
        public int? PrcScCateg56 { get; set; }
        [Column("prcScAllocMeth56")]
        public int? PrcScAllocMeth56 { get; set; }
        [Column("prcScExpCode56")]
        public int? PrcScExpCode56 { get; set; }
        [Column("prcScFactor56")]
        public double? PrcScFactor56 { get; set; }
        [Column("prcScCateg57")]
        public int? PrcScCateg57 { get; set; }
        [Column("prcScAllocMeth57")]
        public int? PrcScAllocMeth57 { get; set; }
        [Column("prcScExpCode57")]
        public int? PrcScExpCode57 { get; set; }
        [Column("prcScFactor57")]
        public double? PrcScFactor57 { get; set; }
        [Column("prcScCateg58")]
        public int? PrcScCateg58 { get; set; }
        [Column("prcScAllocMeth58")]
        public int? PrcScAllocMeth58 { get; set; }
        [Column("prcScExpCode58")]
        public int? PrcScExpCode58 { get; set; }
        [Column("prcScFactor58")]
        public double? PrcScFactor58 { get; set; }
        [Column("prcScCateg59")]
        public int? PrcScCateg59 { get; set; }
        [Column("prcScAllocMeth59")]
        public int? PrcScAllocMeth59 { get; set; }
        [Column("prcScExpCode59")]
        public int? PrcScExpCode59 { get; set; }
        [Column("prcScFactor59")]
        public double? PrcScFactor59 { get; set; }
        [Column("prcScCateg60")]
        public int? PrcScCateg60 { get; set; }
        [Column("prcScAllocMeth60")]
        public int? PrcScAllocMeth60 { get; set; }
        [Column("prcScExpCode60")]
        public int? PrcScExpCode60 { get; set; }
        [Column("prcScFactor60")]
        public double? PrcScFactor60 { get; set; }
        [Column("prcScCateg61")]
        public int? PrcScCateg61 { get; set; }
        [Column("prcScAllocMeth61")]
        public int? PrcScAllocMeth61 { get; set; }
        [Column("prcScExpCode61")]
        public int? PrcScExpCode61 { get; set; }
        [Column("prcScFactor61")]
        public double? PrcScFactor61 { get; set; }
        [Column("prcScCateg62")]
        public int? PrcScCateg62 { get; set; }
        [Column("prcScAllocMeth62")]
        public int? PrcScAllocMeth62 { get; set; }
        [Column("prcScExpCode62")]
        public int? PrcScExpCode62 { get; set; }
        [Column("prcScFactor62")]
        public double? PrcScFactor62 { get; set; }
        [Column("prcScCateg63")]
        public int? PrcScCateg63 { get; set; }
        [Column("prcScAllocMeth63")]
        public int? PrcScAllocMeth63 { get; set; }
        [Column("prcScExpCode63")]
        public int? PrcScExpCode63 { get; set; }
        [Column("prcScFactor63")]
        public double? PrcScFactor63 { get; set; }
        [Column("prcScCateg64")]
        public int? PrcScCateg64 { get; set; }
        [Column("prcScAllocMeth64")]
        public int? PrcScAllocMeth64 { get; set; }
        [Column("prcScExpCode64")]
        public int? PrcScExpCode64 { get; set; }
        [Column("prcScFactor64")]
        public double? PrcScFactor64 { get; set; }
        [Column("prcScCateg65")]
        public int? PrcScCateg65 { get; set; }
        [Column("prcScAllocMeth65")]
        public int? PrcScAllocMeth65 { get; set; }
        [Column("prcScExpCode65")]
        public int? PrcScExpCode65 { get; set; }
        [Column("prcScFactor65")]
        public double? PrcScFactor65 { get; set; }
        [Column("prcScCateg66")]
        public int? PrcScCateg66 { get; set; }
        [Column("prcScAllocMeth66")]
        public int? PrcScAllocMeth66 { get; set; }
        [Column("prcScExpCode66")]
        public int? PrcScExpCode66 { get; set; }
        [Column("prcScFactor66")]
        public double? PrcScFactor66 { get; set; }
        [Column("prcScCateg67")]
        public int? PrcScCateg67 { get; set; }
        [Column("prcScAllocMeth67")]
        public int? PrcScAllocMeth67 { get; set; }
        [Column("prcScExpCode67")]
        public int? PrcScExpCode67 { get; set; }
        [Column("prcScFactor67")]
        public double? PrcScFactor67 { get; set; }
        [Column("prcScCateg68")]
        public int? PrcScCateg68 { get; set; }
        [Column("prcScAllocMeth68")]
        public int? PrcScAllocMeth68 { get; set; }
        [Column("prcScExpCode68")]
        public int? PrcScExpCode68 { get; set; }
        [Column("prcScFactor68")]
        public double? PrcScFactor68 { get; set; }
        [Column("prcScCateg69")]
        public int? PrcScCateg69 { get; set; }
        [Column("prcScAllocMeth69")]
        public int? PrcScAllocMeth69 { get; set; }
        [Column("prcScExpCode69")]
        public int? PrcScExpCode69 { get; set; }
        [Column("prcScFactor69")]
        public double? PrcScFactor69 { get; set; }
        [Column("prcScCateg70")]
        public int? PrcScCateg70 { get; set; }
        [Column("prcScAllocMeth70")]
        public int? PrcScAllocMeth70 { get; set; }
        [Column("prcScExpCode70")]
        public int? PrcScExpCode70 { get; set; }
        [Column("prcScFactor70")]
        public double? PrcScFactor70 { get; set; }
        [Column("prcScCateg71")]
        public int? PrcScCateg71 { get; set; }
        [Column("prcScAllocMeth71")]
        public int? PrcScAllocMeth71 { get; set; }
        [Column("prcScExpCode71")]
        public int? PrcScExpCode71 { get; set; }
        [Column("prcScFactor71")]
        public double? PrcScFactor71 { get; set; }
        [Column("prcScCateg72")]
        public int? PrcScCateg72 { get; set; }
        [Column("prcScAllocMeth72")]
        public int? PrcScAllocMeth72 { get; set; }
        [Column("prcScExpCode72")]
        public int? PrcScExpCode72 { get; set; }
        [Column("prcScFactor72")]
        public double? PrcScFactor72 { get; set; }
        [Column("prcScCateg73")]
        public int? PrcScCateg73 { get; set; }
        [Column("prcScAllocMeth73")]
        public int? PrcScAllocMeth73 { get; set; }
        [Column("prcScExpCode73")]
        public int? PrcScExpCode73 { get; set; }
        [Column("prcScFactor73")]
        public double? PrcScFactor73 { get; set; }
        [Column("prcScCateg74")]
        public int? PrcScCateg74 { get; set; }
        [Column("prcScAllocMeth74")]
        public int? PrcScAllocMeth74 { get; set; }
        [Column("prcScExpCode74")]
        public int? PrcScExpCode74 { get; set; }
        [Column("prcScFactor74")]
        public double? PrcScFactor74 { get; set; }
        [Column("prcScCateg75")]
        public int? PrcScCateg75 { get; set; }
        [Column("prcScAllocMeth75")]
        public int? PrcScAllocMeth75 { get; set; }
        [Column("prcScExpCode75")]
        public int? PrcScExpCode75 { get; set; }
        [Column("prcScFactor75")]
        public double? PrcScFactor75 { get; set; }
        [Column("prcScCateg76")]
        public int? PrcScCateg76 { get; set; }
        [Column("prcScAllocMeth76")]
        public int? PrcScAllocMeth76 { get; set; }
        [Column("prcScExpCode76")]
        public int? PrcScExpCode76 { get; set; }
        [Column("prcScFactor76")]
        public double? PrcScFactor76 { get; set; }
        [Column("prcScCateg77")]
        public int? PrcScCateg77 { get; set; }
        [Column("prcScAllocMeth77")]
        public int? PrcScAllocMeth77 { get; set; }
        [Column("prcScExpCode77")]
        public int? PrcScExpCode77 { get; set; }
        [Column("prcScFactor77")]
        public double? PrcScFactor77 { get; set; }
        [Column("prcScCateg78")]
        public int? PrcScCateg78 { get; set; }
        [Column("prcScAllocMeth78")]
        public int? PrcScAllocMeth78 { get; set; }
        [Column("prcScExpCode78")]
        public int? PrcScExpCode78 { get; set; }
        [Column("prcScFactor78")]
        public double? PrcScFactor78 { get; set; }
        [Column("prcScCateg79")]
        public int? PrcScCateg79 { get; set; }
        [Column("prcScAllocMeth79")]
        public int? PrcScAllocMeth79 { get; set; }
        [Column("prcScExpCode79")]
        public int? PrcScExpCode79 { get; set; }
        [Column("prcScFactor79")]
        public double? PrcScFactor79 { get; set; }
        [Column("prcScCateg80")]
        public int? PrcScCateg80 { get; set; }
        [Column("prcScAllocMeth80")]
        public int? PrcScAllocMeth80 { get; set; }
        [Column("prcScExpCode80")]
        public int? PrcScExpCode80 { get; set; }
        [Column("prcScFactor80")]
        public double? PrcScFactor80 { get; set; }
        [Column("prcScCateg81")]
        public int? PrcScCateg81 { get; set; }
        [Column("prcScAllocMeth81")]
        public int? PrcScAllocMeth81 { get; set; }
        [Column("prcScExpCode81")]
        public int? PrcScExpCode81 { get; set; }
        [Column("prcScFactor81")]
        public double? PrcScFactor81 { get; set; }
        [Column("prcScCateg82")]
        public int? PrcScCateg82 { get; set; }
        [Column("prcScAllocMeth82")]
        public int? PrcScAllocMeth82 { get; set; }
        [Column("prcScExpCode82")]
        public int? PrcScExpCode82 { get; set; }
        [Column("prcScFactor82")]
        public double? PrcScFactor82 { get; set; }
        [Column("prcScCateg83")]
        public int? PrcScCateg83 { get; set; }
        [Column("prcScAllocMeth83")]
        public int? PrcScAllocMeth83 { get; set; }
        [Column("prcScExpCode83")]
        public int? PrcScExpCode83 { get; set; }
        [Column("prcScFactor83")]
        public double? PrcScFactor83 { get; set; }
        [Column("prcScCateg84")]
        public int? PrcScCateg84 { get; set; }
        [Column("prcScAllocMeth84")]
        public int? PrcScAllocMeth84 { get; set; }
        [Column("prcScExpCode84")]
        public int? PrcScExpCode84 { get; set; }
        [Column("prcScFactor84")]
        public double? PrcScFactor84 { get; set; }
        [Column("prcScCateg85")]
        public int? PrcScCateg85 { get; set; }
        [Column("prcScAllocMeth85")]
        public int? PrcScAllocMeth85 { get; set; }
        [Column("prcScExpCode85")]
        public int? PrcScExpCode85 { get; set; }
        [Column("prcScFactor85")]
        public double? PrcScFactor85 { get; set; }
        [Column("prcScCateg86")]
        public int? PrcScCateg86 { get; set; }
        [Column("prcScAllocMeth86")]
        public int? PrcScAllocMeth86 { get; set; }
        [Column("prcScExpCode86")]
        public int? PrcScExpCode86 { get; set; }
        [Column("prcScFactor86")]
        public double? PrcScFactor86 { get; set; }
        [Column("prcScCateg87")]
        public int? PrcScCateg87 { get; set; }
        [Column("prcScAllocMeth87")]
        public int? PrcScAllocMeth87 { get; set; }
        [Column("prcScExpCode87")]
        public int? PrcScExpCode87 { get; set; }
        [Column("prcScFactor87")]
        public double? PrcScFactor87 { get; set; }
        [Column("prcScCateg88")]
        public int? PrcScCateg88 { get; set; }
        [Column("prcScAllocMeth88")]
        public int? PrcScAllocMeth88 { get; set; }
        [Column("prcScExpCode88")]
        public int? PrcScExpCode88 { get; set; }
        [Column("prcScFactor88")]
        public double? PrcScFactor88 { get; set; }
        [Column("prcScCateg89")]
        public int? PrcScCateg89 { get; set; }
        [Column("prcScAllocMeth89")]
        public int? PrcScAllocMeth89 { get; set; }
        [Column("prcScExpCode89")]
        public int? PrcScExpCode89 { get; set; }
        [Column("prcScFactor89")]
        public double? PrcScFactor89 { get; set; }
        [Column("prcScCateg90")]
        public int? PrcScCateg90 { get; set; }
        [Column("prcScAllocMeth90")]
        public int? PrcScAllocMeth90 { get; set; }
        [Column("prcScExpCode90")]
        public int? PrcScExpCode90 { get; set; }
        [Column("prcScFactor90")]
        public double? PrcScFactor90 { get; set; }
        [Column("prcScCateg91")]
        public int? PrcScCateg91 { get; set; }
        [Column("prcScAllocMeth91")]
        public int? PrcScAllocMeth91 { get; set; }
        [Column("prcScExpCode91")]
        public int? PrcScExpCode91 { get; set; }
        [Column("prcScFactor91")]
        public double? PrcScFactor91 { get; set; }
        [Column("prcScCateg92")]
        public int? PrcScCateg92 { get; set; }
        [Column("prcScAllocMeth92")]
        public int? PrcScAllocMeth92 { get; set; }
        [Column("prcScExpCode92")]
        public int? PrcScExpCode92 { get; set; }
        [Column("prcScFactor92")]
        public double? PrcScFactor92 { get; set; }
        [Column("prcScCateg93")]
        public int? PrcScCateg93 { get; set; }
        [Column("prcScAllocMeth93")]
        public int? PrcScAllocMeth93 { get; set; }
        [Column("prcScExpCode93")]
        public int? PrcScExpCode93 { get; set; }
        [Column("prcScFactor93")]
        public double? PrcScFactor93 { get; set; }
        [Column("prcScCateg94")]
        public int? PrcScCateg94 { get; set; }
        [Column("prcScAllocMeth94")]
        public int? PrcScAllocMeth94 { get; set; }
        [Column("prcScExpCode94")]
        public int? PrcScExpCode94 { get; set; }
        [Column("prcScFactor94")]
        public double? PrcScFactor94 { get; set; }
        [Column("prcScCateg95")]
        public int? PrcScCateg95 { get; set; }
        [Column("prcScAllocMeth95")]
        public int? PrcScAllocMeth95 { get; set; }
        [Column("prcScExpCode95")]
        public int? PrcScExpCode95 { get; set; }
        [Column("prcScFactor95")]
        public double? PrcScFactor95 { get; set; }
        [Column("prcScCateg96")]
        public int? PrcScCateg96 { get; set; }
        [Column("prcScAllocMeth96")]
        public int? PrcScAllocMeth96 { get; set; }
        [Column("prcScExpCode96")]
        public int? PrcScExpCode96 { get; set; }
        [Column("prcScFactor96")]
        public double? PrcScFactor96 { get; set; }
        [Column("prcScCateg97")]
        public int? PrcScCateg97 { get; set; }
        [Column("prcScAllocMeth97")]
        public int? PrcScAllocMeth97 { get; set; }
        [Column("prcScExpCode97")]
        public int? PrcScExpCode97 { get; set; }
        [Column("prcScFactor97")]
        public double? PrcScFactor97 { get; set; }
        [Column("prcScCateg98")]
        public int? PrcScCateg98 { get; set; }
        [Column("prcScAllocMeth98")]
        public int? PrcScAllocMeth98 { get; set; }
        [Column("prcScExpCode98")]
        public int? PrcScExpCode98 { get; set; }
        [Column("prcScFactor98")]
        public double? PrcScFactor98 { get; set; }
        [Column("prcScCateg99")]
        public int? PrcScCateg99 { get; set; }
        [Column("prcScAllocMeth99")]
        public int? PrcScAllocMeth99 { get; set; }
        [Column("prcScExpCode99")]
        public int? PrcScExpCode99 { get; set; }
        [Column("prcScFactor99")]
        public double? PrcScFactor99 { get; set; }
        [Column("prcScCateg100")]
        public int? PrcScCateg100 { get; set; }
        [Column("prcScAllocMeth100")]
        public int? PrcScAllocMeth100 { get; set; }
        [Column("prcScExpCode100")]
        public int? PrcScExpCode100 { get; set; }
        [Column("prcScFactor100")]
        public double? PrcScFactor100 { get; set; }
        [Column("prcId")]
        public int? PrcId { get; set; }
        [Column("prcInsDate", TypeName = "datetime")]
        public DateTime? PrcInsDate { get; set; }
    }
}
