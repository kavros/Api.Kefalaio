using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SMCS")]
    [Index(nameof(SFileId), nameof(SmcsPlace), nameof(SmcsSource), Name = "smcsByPos", IsUnique = true)]
    public partial class Smc
    {
        [Key]
        [Column("smcsFileId")]
        public int SmcsFileId { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Column("smcsPlace")]
        public int SmcsPlace { get; set; }
        [Column("smcsSource")]
        public int SmcsSource { get; set; }
        [Column("smcsSize1Colour1")]
        public double? SmcsSize1Colour1 { get; set; }
        [Column("smcsSize1Colour2")]
        public double? SmcsSize1Colour2 { get; set; }
        [Column("smcsSize1Colour3")]
        public double? SmcsSize1Colour3 { get; set; }
        [Column("smcsSize1Colour4")]
        public double? SmcsSize1Colour4 { get; set; }
        [Column("smcsSize1Colour5")]
        public double? SmcsSize1Colour5 { get; set; }
        [Column("smcsSize1Colour6")]
        public double? SmcsSize1Colour6 { get; set; }
        [Column("smcsSize1Colour7")]
        public double? SmcsSize1Colour7 { get; set; }
        [Column("smcsSize1Colour8")]
        public double? SmcsSize1Colour8 { get; set; }
        [Column("smcsSize1Colour9")]
        public double? SmcsSize1Colour9 { get; set; }
        [Column("smcsSize1Colour10")]
        public double? SmcsSize1Colour10 { get; set; }
        [Column("smcsSize1Colour11")]
        public double? SmcsSize1Colour11 { get; set; }
        [Column("smcsSize1Colour12")]
        public double? SmcsSize1Colour12 { get; set; }
        [Column("smcsSize1Colour13")]
        public double? SmcsSize1Colour13 { get; set; }
        [Column("smcsSize1Colour14")]
        public double? SmcsSize1Colour14 { get; set; }
        [Column("smcsSize1Colour15")]
        public double? SmcsSize1Colour15 { get; set; }
        [Column("smcsSize1Colour16")]
        public double? SmcsSize1Colour16 { get; set; }
        [Column("smcsSize1Colour17")]
        public double? SmcsSize1Colour17 { get; set; }
        [Column("smcsSize1Colour18")]
        public double? SmcsSize1Colour18 { get; set; }
        [Column("smcsSize1Colour19")]
        public double? SmcsSize1Colour19 { get; set; }
        [Column("smcsSize1Colour20")]
        public double? SmcsSize1Colour20 { get; set; }
        [Column("smcsSize1Colour21")]
        public double? SmcsSize1Colour21 { get; set; }
        [Column("smcsSize1Colour22")]
        public double? SmcsSize1Colour22 { get; set; }
        [Column("smcsSize1Colour23")]
        public double? SmcsSize1Colour23 { get; set; }
        [Column("smcsSize1Colour24")]
        public double? SmcsSize1Colour24 { get; set; }
        [Column("smcsSize2Colour1")]
        public double? SmcsSize2Colour1 { get; set; }
        [Column("smcsSize2Colour2")]
        public double? SmcsSize2Colour2 { get; set; }
        [Column("smcsSize2Colour3")]
        public double? SmcsSize2Colour3 { get; set; }
        [Column("smcsSize2Colour4")]
        public double? SmcsSize2Colour4 { get; set; }
        [Column("smcsSize2Colour5")]
        public double? SmcsSize2Colour5 { get; set; }
        [Column("smcsSize2Colour6")]
        public double? SmcsSize2Colour6 { get; set; }
        [Column("smcsSize2Colour7")]
        public double? SmcsSize2Colour7 { get; set; }
        [Column("smcsSize2Colour8")]
        public double? SmcsSize2Colour8 { get; set; }
        [Column("smcsSize2Colour9")]
        public double? SmcsSize2Colour9 { get; set; }
        [Column("smcsSize2Colour10")]
        public double? SmcsSize2Colour10 { get; set; }
        [Column("smcsSize2Colour11")]
        public double? SmcsSize2Colour11 { get; set; }
        [Column("smcsSize2Colour12")]
        public double? SmcsSize2Colour12 { get; set; }
        [Column("smcsSize2Colour13")]
        public double? SmcsSize2Colour13 { get; set; }
        [Column("smcsSize2Colour14")]
        public double? SmcsSize2Colour14 { get; set; }
        [Column("smcsSize2Colour15")]
        public double? SmcsSize2Colour15 { get; set; }
        [Column("smcsSize2Colour16")]
        public double? SmcsSize2Colour16 { get; set; }
        [Column("smcsSize2Colour17")]
        public double? SmcsSize2Colour17 { get; set; }
        [Column("smcsSize2Colour18")]
        public double? SmcsSize2Colour18 { get; set; }
        [Column("smcsSize2Colour19")]
        public double? SmcsSize2Colour19 { get; set; }
        [Column("smcsSize2Colour20")]
        public double? SmcsSize2Colour20 { get; set; }
        [Column("smcsSize2Colour21")]
        public double? SmcsSize2Colour21 { get; set; }
        [Column("smcsSize2Colour22")]
        public double? SmcsSize2Colour22 { get; set; }
        [Column("smcsSize2Colour23")]
        public double? SmcsSize2Colour23 { get; set; }
        [Column("smcsSize2Colour24")]
        public double? SmcsSize2Colour24 { get; set; }
        [Column("smcsSize3Colour1")]
        public double? SmcsSize3Colour1 { get; set; }
        [Column("smcsSize3Colour2")]
        public double? SmcsSize3Colour2 { get; set; }
        [Column("smcsSize3Colour3")]
        public double? SmcsSize3Colour3 { get; set; }
        [Column("smcsSize3Colour4")]
        public double? SmcsSize3Colour4 { get; set; }
        [Column("smcsSize3Colour5")]
        public double? SmcsSize3Colour5 { get; set; }
        [Column("smcsSize3Colour6")]
        public double? SmcsSize3Colour6 { get; set; }
        [Column("smcsSize3Colour7")]
        public double? SmcsSize3Colour7 { get; set; }
        [Column("smcsSize3Colour8")]
        public double? SmcsSize3Colour8 { get; set; }
        [Column("smcsSize3Colour9")]
        public double? SmcsSize3Colour9 { get; set; }
        [Column("smcsSize3Colour10")]
        public double? SmcsSize3Colour10 { get; set; }
        [Column("smcsSize3Colour11")]
        public double? SmcsSize3Colour11 { get; set; }
        [Column("smcsSize3Colour12")]
        public double? SmcsSize3Colour12 { get; set; }
        [Column("smcsSize3Colour13")]
        public double? SmcsSize3Colour13 { get; set; }
        [Column("smcsSize3Colour14")]
        public double? SmcsSize3Colour14 { get; set; }
        [Column("smcsSize3Colour15")]
        public double? SmcsSize3Colour15 { get; set; }
        [Column("smcsSize3Colour16")]
        public double? SmcsSize3Colour16 { get; set; }
        [Column("smcsSize3Colour17")]
        public double? SmcsSize3Colour17 { get; set; }
        [Column("smcsSize3Colour18")]
        public double? SmcsSize3Colour18 { get; set; }
        [Column("smcsSize3Colour19")]
        public double? SmcsSize3Colour19 { get; set; }
        [Column("smcsSize3Colour20")]
        public double? SmcsSize3Colour20 { get; set; }
        [Column("smcsSize3Colour21")]
        public double? SmcsSize3Colour21 { get; set; }
        [Column("smcsSize3Colour22")]
        public double? SmcsSize3Colour22 { get; set; }
        [Column("smcsSize3Colour23")]
        public double? SmcsSize3Colour23 { get; set; }
        [Column("smcsSize3Colour24")]
        public double? SmcsSize3Colour24 { get; set; }
        [Column("smcsSize4Colour1")]
        public double? SmcsSize4Colour1 { get; set; }
        [Column("smcsSize4Colour2")]
        public double? SmcsSize4Colour2 { get; set; }
        [Column("smcsSize4Colour3")]
        public double? SmcsSize4Colour3 { get; set; }
        [Column("smcsSize4Colour4")]
        public double? SmcsSize4Colour4 { get; set; }
        [Column("smcsSize4Colour5")]
        public double? SmcsSize4Colour5 { get; set; }
        [Column("smcsSize4Colour6")]
        public double? SmcsSize4Colour6 { get; set; }
        [Column("smcsSize4Colour7")]
        public double? SmcsSize4Colour7 { get; set; }
        [Column("smcsSize4Colour8")]
        public double? SmcsSize4Colour8 { get; set; }
        [Column("smcsSize4Colour9")]
        public double? SmcsSize4Colour9 { get; set; }
        [Column("smcsSize4Colour10")]
        public double? SmcsSize4Colour10 { get; set; }
        [Column("smcsSize4Colour11")]
        public double? SmcsSize4Colour11 { get; set; }
        [Column("smcsSize4Colour12")]
        public double? SmcsSize4Colour12 { get; set; }
        [Column("smcsSize4Colour13")]
        public double? SmcsSize4Colour13 { get; set; }
        [Column("smcsSize4Colour14")]
        public double? SmcsSize4Colour14 { get; set; }
        [Column("smcsSize4Colour15")]
        public double? SmcsSize4Colour15 { get; set; }
        [Column("smcsSize4Colour16")]
        public double? SmcsSize4Colour16 { get; set; }
        [Column("smcsSize4Colour17")]
        public double? SmcsSize4Colour17 { get; set; }
        [Column("smcsSize4Colour18")]
        public double? SmcsSize4Colour18 { get; set; }
        [Column("smcsSize4Colour19")]
        public double? SmcsSize4Colour19 { get; set; }
        [Column("smcsSize4Colour20")]
        public double? SmcsSize4Colour20 { get; set; }
        [Column("smcsSize4Colour21")]
        public double? SmcsSize4Colour21 { get; set; }
        [Column("smcsSize4Colour22")]
        public double? SmcsSize4Colour22 { get; set; }
        [Column("smcsSize4Colour23")]
        public double? SmcsSize4Colour23 { get; set; }
        [Column("smcsSize4Colour24")]
        public double? SmcsSize4Colour24 { get; set; }
        [Column("smcsSize5Colour1")]
        public double? SmcsSize5Colour1 { get; set; }
        [Column("smcsSize5Colour2")]
        public double? SmcsSize5Colour2 { get; set; }
        [Column("smcsSize5Colour3")]
        public double? SmcsSize5Colour3 { get; set; }
        [Column("smcsSize5Colour4")]
        public double? SmcsSize5Colour4 { get; set; }
        [Column("smcsSize5Colour5")]
        public double? SmcsSize5Colour5 { get; set; }
        [Column("smcsSize5Colour6")]
        public double? SmcsSize5Colour6 { get; set; }
        [Column("smcsSize5Colour7")]
        public double? SmcsSize5Colour7 { get; set; }
        [Column("smcsSize5Colour8")]
        public double? SmcsSize5Colour8 { get; set; }
        [Column("smcsSize5Colour9")]
        public double? SmcsSize5Colour9 { get; set; }
        [Column("smcsSize5Colour10")]
        public double? SmcsSize5Colour10 { get; set; }
        [Column("smcsSize5Colour11")]
        public double? SmcsSize5Colour11 { get; set; }
        [Column("smcsSize5Colour12")]
        public double? SmcsSize5Colour12 { get; set; }
        [Column("smcsSize5Colour13")]
        public double? SmcsSize5Colour13 { get; set; }
        [Column("smcsSize5Colour14")]
        public double? SmcsSize5Colour14 { get; set; }
        [Column("smcsSize5Colour15")]
        public double? SmcsSize5Colour15 { get; set; }
        [Column("smcsSize5Colour16")]
        public double? SmcsSize5Colour16 { get; set; }
        [Column("smcsSize5Colour17")]
        public double? SmcsSize5Colour17 { get; set; }
        [Column("smcsSize5Colour18")]
        public double? SmcsSize5Colour18 { get; set; }
        [Column("smcsSize5Colour19")]
        public double? SmcsSize5Colour19 { get; set; }
        [Column("smcsSize5Colour20")]
        public double? SmcsSize5Colour20 { get; set; }
        [Column("smcsSize5Colour21")]
        public double? SmcsSize5Colour21 { get; set; }
        [Column("smcsSize5Colour22")]
        public double? SmcsSize5Colour22 { get; set; }
        [Column("smcsSize5Colour23")]
        public double? SmcsSize5Colour23 { get; set; }
        [Column("smcsSize5Colour24")]
        public double? SmcsSize5Colour24 { get; set; }
        [Column("smcsSize6Colour1")]
        public double? SmcsSize6Colour1 { get; set; }
        [Column("smcsSize6Colour2")]
        public double? SmcsSize6Colour2 { get; set; }
        [Column("smcsSize6Colour3")]
        public double? SmcsSize6Colour3 { get; set; }
        [Column("smcsSize6Colour4")]
        public double? SmcsSize6Colour4 { get; set; }
        [Column("smcsSize6Colour5")]
        public double? SmcsSize6Colour5 { get; set; }
        [Column("smcsSize6Colour6")]
        public double? SmcsSize6Colour6 { get; set; }
        [Column("smcsSize6Colour7")]
        public double? SmcsSize6Colour7 { get; set; }
        [Column("smcsSize6Colour8")]
        public double? SmcsSize6Colour8 { get; set; }
        [Column("smcsSize6Colour9")]
        public double? SmcsSize6Colour9 { get; set; }
        [Column("smcsSize6Colour10")]
        public double? SmcsSize6Colour10 { get; set; }
        [Column("smcsSize6Colour11")]
        public double? SmcsSize6Colour11 { get; set; }
        [Column("smcsSize6Colour12")]
        public double? SmcsSize6Colour12 { get; set; }
        [Column("smcsSize6Colour13")]
        public double? SmcsSize6Colour13 { get; set; }
        [Column("smcsSize6Colour14")]
        public double? SmcsSize6Colour14 { get; set; }
        [Column("smcsSize6Colour15")]
        public double? SmcsSize6Colour15 { get; set; }
        [Column("smcsSize6Colour16")]
        public double? SmcsSize6Colour16 { get; set; }
        [Column("smcsSize6Colour17")]
        public double? SmcsSize6Colour17 { get; set; }
        [Column("smcsSize6Colour18")]
        public double? SmcsSize6Colour18 { get; set; }
        [Column("smcsSize6Colour19")]
        public double? SmcsSize6Colour19 { get; set; }
        [Column("smcsSize6Colour20")]
        public double? SmcsSize6Colour20 { get; set; }
        [Column("smcsSize6Colour21")]
        public double? SmcsSize6Colour21 { get; set; }
        [Column("smcsSize6Colour22")]
        public double? SmcsSize6Colour22 { get; set; }
        [Column("smcsSize6Colour23")]
        public double? SmcsSize6Colour23 { get; set; }
        [Column("smcsSize6Colour24")]
        public double? SmcsSize6Colour24 { get; set; }
        [Column("smcsSize7Colour1")]
        public double? SmcsSize7Colour1 { get; set; }
        [Column("smcsSize7Colour2")]
        public double? SmcsSize7Colour2 { get; set; }
        [Column("smcsSize7Colour3")]
        public double? SmcsSize7Colour3 { get; set; }
        [Column("smcsSize7Colour4")]
        public double? SmcsSize7Colour4 { get; set; }
        [Column("smcsSize7Colour5")]
        public double? SmcsSize7Colour5 { get; set; }
        [Column("smcsSize7Colour6")]
        public double? SmcsSize7Colour6 { get; set; }
        [Column("smcsSize7Colour7")]
        public double? SmcsSize7Colour7 { get; set; }
        [Column("smcsSize7Colour8")]
        public double? SmcsSize7Colour8 { get; set; }
        [Column("smcsSize7Colour9")]
        public double? SmcsSize7Colour9 { get; set; }
        [Column("smcsSize7Colour10")]
        public double? SmcsSize7Colour10 { get; set; }
        [Column("smcsSize7Colour11")]
        public double? SmcsSize7Colour11 { get; set; }
        [Column("smcsSize7Colour12")]
        public double? SmcsSize7Colour12 { get; set; }
        [Column("smcsSize7Colour13")]
        public double? SmcsSize7Colour13 { get; set; }
        [Column("smcsSize7Colour14")]
        public double? SmcsSize7Colour14 { get; set; }
        [Column("smcsSize7Colour15")]
        public double? SmcsSize7Colour15 { get; set; }
        [Column("smcsSize7Colour16")]
        public double? SmcsSize7Colour16 { get; set; }
        [Column("smcsSize7Colour17")]
        public double? SmcsSize7Colour17 { get; set; }
        [Column("smcsSize7Colour18")]
        public double? SmcsSize7Colour18 { get; set; }
        [Column("smcsSize7Colour19")]
        public double? SmcsSize7Colour19 { get; set; }
        [Column("smcsSize7Colour20")]
        public double? SmcsSize7Colour20 { get; set; }
        [Column("smcsSize7Colour21")]
        public double? SmcsSize7Colour21 { get; set; }
        [Column("smcsSize7Colour22")]
        public double? SmcsSize7Colour22 { get; set; }
        [Column("smcsSize7Colour23")]
        public double? SmcsSize7Colour23 { get; set; }
        [Column("smcsSize7Colour24")]
        public double? SmcsSize7Colour24 { get; set; }
        [Column("smcsSize8Colour1")]
        public double? SmcsSize8Colour1 { get; set; }
        [Column("smcsSize8Colour2")]
        public double? SmcsSize8Colour2 { get; set; }
        [Column("smcsSize8Colour3")]
        public double? SmcsSize8Colour3 { get; set; }
        [Column("smcsSize8Colour4")]
        public double? SmcsSize8Colour4 { get; set; }
        [Column("smcsSize8Colour5")]
        public double? SmcsSize8Colour5 { get; set; }
        [Column("smcsSize8Colour6")]
        public double? SmcsSize8Colour6 { get; set; }
        [Column("smcsSize8Colour7")]
        public double? SmcsSize8Colour7 { get; set; }
        [Column("smcsSize8Colour8")]
        public double? SmcsSize8Colour8 { get; set; }
        [Column("smcsSize8Colour9")]
        public double? SmcsSize8Colour9 { get; set; }
        [Column("smcsSize8Colour10")]
        public double? SmcsSize8Colour10 { get; set; }
        [Column("smcsSize8Colour11")]
        public double? SmcsSize8Colour11 { get; set; }
        [Column("smcsSize8Colour12")]
        public double? SmcsSize8Colour12 { get; set; }
        [Column("smcsSize8Colour13")]
        public double? SmcsSize8Colour13 { get; set; }
        [Column("smcsSize8Colour14")]
        public double? SmcsSize8Colour14 { get; set; }
        [Column("smcsSize8Colour15")]
        public double? SmcsSize8Colour15 { get; set; }
        [Column("smcsSize8Colour16")]
        public double? SmcsSize8Colour16 { get; set; }
        [Column("smcsSize8Colour17")]
        public double? SmcsSize8Colour17 { get; set; }
        [Column("smcsSize8Colour18")]
        public double? SmcsSize8Colour18 { get; set; }
        [Column("smcsSize8Colour19")]
        public double? SmcsSize8Colour19 { get; set; }
        [Column("smcsSize8Colour20")]
        public double? SmcsSize8Colour20 { get; set; }
        [Column("smcsSize8Colour21")]
        public double? SmcsSize8Colour21 { get; set; }
        [Column("smcsSize8Colour22")]
        public double? SmcsSize8Colour22 { get; set; }
        [Column("smcsSize8Colour23")]
        public double? SmcsSize8Colour23 { get; set; }
        [Column("smcsSize8Colour24")]
        public double? SmcsSize8Colour24 { get; set; }
        [Column("smcsSize9Colour1")]
        public double? SmcsSize9Colour1 { get; set; }
        [Column("smcsSize9Colour2")]
        public double? SmcsSize9Colour2 { get; set; }
        [Column("smcsSize9Colour3")]
        public double? SmcsSize9Colour3 { get; set; }
        [Column("smcsSize9Colour4")]
        public double? SmcsSize9Colour4 { get; set; }
        [Column("smcsSize9Colour5")]
        public double? SmcsSize9Colour5 { get; set; }
        [Column("smcsSize9Colour6")]
        public double? SmcsSize9Colour6 { get; set; }
        [Column("smcsSize9Colour7")]
        public double? SmcsSize9Colour7 { get; set; }
        [Column("smcsSize9Colour8")]
        public double? SmcsSize9Colour8 { get; set; }
        [Column("smcsSize9Colour9")]
        public double? SmcsSize9Colour9 { get; set; }
        [Column("smcsSize9Colour10")]
        public double? SmcsSize9Colour10 { get; set; }
        [Column("smcsSize9Colour11")]
        public double? SmcsSize9Colour11 { get; set; }
        [Column("smcsSize9Colour12")]
        public double? SmcsSize9Colour12 { get; set; }
        [Column("smcsSize9Colour13")]
        public double? SmcsSize9Colour13 { get; set; }
        [Column("smcsSize9Colour14")]
        public double? SmcsSize9Colour14 { get; set; }
        [Column("smcsSize9Colour15")]
        public double? SmcsSize9Colour15 { get; set; }
        [Column("smcsSize9Colour16")]
        public double? SmcsSize9Colour16 { get; set; }
        [Column("smcsSize9Colour17")]
        public double? SmcsSize9Colour17 { get; set; }
        [Column("smcsSize9Colour18")]
        public double? SmcsSize9Colour18 { get; set; }
        [Column("smcsSize9Colour19")]
        public double? SmcsSize9Colour19 { get; set; }
        [Column("smcsSize9Colour20")]
        public double? SmcsSize9Colour20 { get; set; }
        [Column("smcsSize9Colour21")]
        public double? SmcsSize9Colour21 { get; set; }
        [Column("smcsSize9Colour22")]
        public double? SmcsSize9Colour22 { get; set; }
        [Column("smcsSize9Colour23")]
        public double? SmcsSize9Colour23 { get; set; }
        [Column("smcsSize9Colour24")]
        public double? SmcsSize9Colour24 { get; set; }
        [Column("smcsSize10Colour1")]
        public double? SmcsSize10Colour1 { get; set; }
        [Column("smcsSize10Colour2")]
        public double? SmcsSize10Colour2 { get; set; }
        [Column("smcsSize10Colour3")]
        public double? SmcsSize10Colour3 { get; set; }
        [Column("smcsSize10Colour4")]
        public double? SmcsSize10Colour4 { get; set; }
        [Column("smcsSize10Colour5")]
        public double? SmcsSize10Colour5 { get; set; }
        [Column("smcsSize10Colour6")]
        public double? SmcsSize10Colour6 { get; set; }
        [Column("smcsSize10Colour7")]
        public double? SmcsSize10Colour7 { get; set; }
        [Column("smcsSize10Colour8")]
        public double? SmcsSize10Colour8 { get; set; }
        [Column("smcsSize10Colour9")]
        public double? SmcsSize10Colour9 { get; set; }
        [Column("smcsSize10Colour10")]
        public double? SmcsSize10Colour10 { get; set; }
        [Column("smcsSize10Colour11")]
        public double? SmcsSize10Colour11 { get; set; }
        [Column("smcsSize10Colour12")]
        public double? SmcsSize10Colour12 { get; set; }
        [Column("smcsSize10Colour13")]
        public double? SmcsSize10Colour13 { get; set; }
        [Column("smcsSize10Colour14")]
        public double? SmcsSize10Colour14 { get; set; }
        [Column("smcsSize10Colour15")]
        public double? SmcsSize10Colour15 { get; set; }
        [Column("smcsSize10Colour16")]
        public double? SmcsSize10Colour16 { get; set; }
        [Column("smcsSize10Colour17")]
        public double? SmcsSize10Colour17 { get; set; }
        [Column("smcsSize10Colour18")]
        public double? SmcsSize10Colour18 { get; set; }
        [Column("smcsSize10Colour19")]
        public double? SmcsSize10Colour19 { get; set; }
        [Column("smcsSize10Colour20")]
        public double? SmcsSize10Colour20 { get; set; }
        [Column("smcsSize10Colour21")]
        public double? SmcsSize10Colour21 { get; set; }
        [Column("smcsSize10Colour22")]
        public double? SmcsSize10Colour22 { get; set; }
        [Column("smcsSize10Colour23")]
        public double? SmcsSize10Colour23 { get; set; }
        [Column("smcsSize10Colour24")]
        public double? SmcsSize10Colour24 { get; set; }
        [Column("smcsSize11Colour1")]
        public double? SmcsSize11Colour1 { get; set; }
        [Column("smcsSize11Colour2")]
        public double? SmcsSize11Colour2 { get; set; }
        [Column("smcsSize11Colour3")]
        public double? SmcsSize11Colour3 { get; set; }
        [Column("smcsSize11Colour4")]
        public double? SmcsSize11Colour4 { get; set; }
        [Column("smcsSize11Colour5")]
        public double? SmcsSize11Colour5 { get; set; }
        [Column("smcsSize11Colour6")]
        public double? SmcsSize11Colour6 { get; set; }
        [Column("smcsSize11Colour7")]
        public double? SmcsSize11Colour7 { get; set; }
        [Column("smcsSize11Colour8")]
        public double? SmcsSize11Colour8 { get; set; }
        [Column("smcsSize11Colour9")]
        public double? SmcsSize11Colour9 { get; set; }
        [Column("smcsSize11Colour10")]
        public double? SmcsSize11Colour10 { get; set; }
        [Column("smcsSize11Colour11")]
        public double? SmcsSize11Colour11 { get; set; }
        [Column("smcsSize11Colour12")]
        public double? SmcsSize11Colour12 { get; set; }
        [Column("smcsSize11Colour13")]
        public double? SmcsSize11Colour13 { get; set; }
        [Column("smcsSize11Colour14")]
        public double? SmcsSize11Colour14 { get; set; }
        [Column("smcsSize11Colour15")]
        public double? SmcsSize11Colour15 { get; set; }
        [Column("smcsSize11Colour16")]
        public double? SmcsSize11Colour16 { get; set; }
        [Column("smcsSize11Colour17")]
        public double? SmcsSize11Colour17 { get; set; }
        [Column("smcsSize11Colour18")]
        public double? SmcsSize11Colour18 { get; set; }
        [Column("smcsSize11Colour19")]
        public double? SmcsSize11Colour19 { get; set; }
        [Column("smcsSize11Colour20")]
        public double? SmcsSize11Colour20 { get; set; }
        [Column("smcsSize11Colour21")]
        public double? SmcsSize11Colour21 { get; set; }
        [Column("smcsSize11Colour22")]
        public double? SmcsSize11Colour22 { get; set; }
        [Column("smcsSize11Colour23")]
        public double? SmcsSize11Colour23 { get; set; }
        [Column("smcsSize11Colour24")]
        public double? SmcsSize11Colour24 { get; set; }
        [Column("smcsSize12Colour1")]
        public double? SmcsSize12Colour1 { get; set; }
        [Column("smcsSize12Colour2")]
        public double? SmcsSize12Colour2 { get; set; }
        [Column("smcsSize12Colour3")]
        public double? SmcsSize12Colour3 { get; set; }
        [Column("smcsSize12Colour4")]
        public double? SmcsSize12Colour4 { get; set; }
        [Column("smcsSize12Colour5")]
        public double? SmcsSize12Colour5 { get; set; }
        [Column("smcsSize12Colour6")]
        public double? SmcsSize12Colour6 { get; set; }
        [Column("smcsSize12Colour7")]
        public double? SmcsSize12Colour7 { get; set; }
        [Column("smcsSize12Colour8")]
        public double? SmcsSize12Colour8 { get; set; }
        [Column("smcsSize12Colour9")]
        public double? SmcsSize12Colour9 { get; set; }
        [Column("smcsSize12Colour10")]
        public double? SmcsSize12Colour10 { get; set; }
        [Column("smcsSize12Colour11")]
        public double? SmcsSize12Colour11 { get; set; }
        [Column("smcsSize12Colour12")]
        public double? SmcsSize12Colour12 { get; set; }
        [Column("smcsSize12Colour13")]
        public double? SmcsSize12Colour13 { get; set; }
        [Column("smcsSize12Colour14")]
        public double? SmcsSize12Colour14 { get; set; }
        [Column("smcsSize12Colour15")]
        public double? SmcsSize12Colour15 { get; set; }
        [Column("smcsSize12Colour16")]
        public double? SmcsSize12Colour16 { get; set; }
        [Column("smcsSize12Colour17")]
        public double? SmcsSize12Colour17 { get; set; }
        [Column("smcsSize12Colour18")]
        public double? SmcsSize12Colour18 { get; set; }
        [Column("smcsSize12Colour19")]
        public double? SmcsSize12Colour19 { get; set; }
        [Column("smcsSize12Colour20")]
        public double? SmcsSize12Colour20 { get; set; }
        [Column("smcsSize12Colour21")]
        public double? SmcsSize12Colour21 { get; set; }
        [Column("smcsSize12Colour22")]
        public double? SmcsSize12Colour22 { get; set; }
        [Column("smcsSize12Colour23")]
        public double? SmcsSize12Colour23 { get; set; }
        [Column("smcsSize12Colour24")]
        public double? SmcsSize12Colour24 { get; set; }
        [Column("smcsSize13Colour1")]
        public double? SmcsSize13Colour1 { get; set; }
        [Column("smcsSize13Colour2")]
        public double? SmcsSize13Colour2 { get; set; }
        [Column("smcsSize13Colour3")]
        public double? SmcsSize13Colour3 { get; set; }
        [Column("smcsSize13Colour4")]
        public double? SmcsSize13Colour4 { get; set; }
        [Column("smcsSize13Colour5")]
        public double? SmcsSize13Colour5 { get; set; }
        [Column("smcsSize13Colour6")]
        public double? SmcsSize13Colour6 { get; set; }
        [Column("smcsSize13Colour7")]
        public double? SmcsSize13Colour7 { get; set; }
        [Column("smcsSize13Colour8")]
        public double? SmcsSize13Colour8 { get; set; }
        [Column("smcsSize13Colour9")]
        public double? SmcsSize13Colour9 { get; set; }
        [Column("smcsSize13Colour10")]
        public double? SmcsSize13Colour10 { get; set; }
        [Column("smcsSize13Colour11")]
        public double? SmcsSize13Colour11 { get; set; }
        [Column("smcsSize13Colour12")]
        public double? SmcsSize13Colour12 { get; set; }
        [Column("smcsSize13Colour13")]
        public double? SmcsSize13Colour13 { get; set; }
        [Column("smcsSize13Colour14")]
        public double? SmcsSize13Colour14 { get; set; }
        [Column("smcsSize13Colour15")]
        public double? SmcsSize13Colour15 { get; set; }
        [Column("smcsSize13Colour16")]
        public double? SmcsSize13Colour16 { get; set; }
        [Column("smcsSize13Colour17")]
        public double? SmcsSize13Colour17 { get; set; }
        [Column("smcsSize13Colour18")]
        public double? SmcsSize13Colour18 { get; set; }
        [Column("smcsSize13Colour19")]
        public double? SmcsSize13Colour19 { get; set; }
        [Column("smcsSize13Colour20")]
        public double? SmcsSize13Colour20 { get; set; }
        [Column("smcsSize13Colour21")]
        public double? SmcsSize13Colour21 { get; set; }
        [Column("smcsSize13Colour22")]
        public double? SmcsSize13Colour22 { get; set; }
        [Column("smcsSize13Colour23")]
        public double? SmcsSize13Colour23 { get; set; }
        [Column("smcsSize13Colour24")]
        public double? SmcsSize13Colour24 { get; set; }
        [Column("smcsSize14Colour1")]
        public double? SmcsSize14Colour1 { get; set; }
        [Column("smcsSize14Colour2")]
        public double? SmcsSize14Colour2 { get; set; }
        [Column("smcsSize14Colour3")]
        public double? SmcsSize14Colour3 { get; set; }
        [Column("smcsSize14Colour4")]
        public double? SmcsSize14Colour4 { get; set; }
        [Column("smcsSize14Colour5")]
        public double? SmcsSize14Colour5 { get; set; }
        [Column("smcsSize14Colour6")]
        public double? SmcsSize14Colour6 { get; set; }
        [Column("smcsSize14Colour7")]
        public double? SmcsSize14Colour7 { get; set; }
        [Column("smcsSize14Colour8")]
        public double? SmcsSize14Colour8 { get; set; }
        [Column("smcsSize14Colour9")]
        public double? SmcsSize14Colour9 { get; set; }
        [Column("smcsSize14Colour10")]
        public double? SmcsSize14Colour10 { get; set; }
        [Column("smcsSize14Colour11")]
        public double? SmcsSize14Colour11 { get; set; }
        [Column("smcsSize14Colour12")]
        public double? SmcsSize14Colour12 { get; set; }
        [Column("smcsSize14Colour13")]
        public double? SmcsSize14Colour13 { get; set; }
        [Column("smcsSize14Colour14")]
        public double? SmcsSize14Colour14 { get; set; }
        [Column("smcsSize14Colour15")]
        public double? SmcsSize14Colour15 { get; set; }
        [Column("smcsSize14Colour16")]
        public double? SmcsSize14Colour16 { get; set; }
        [Column("smcsSize14Colour17")]
        public double? SmcsSize14Colour17 { get; set; }
        [Column("smcsSize14Colour18")]
        public double? SmcsSize14Colour18 { get; set; }
        [Column("smcsSize14Colour19")]
        public double? SmcsSize14Colour19 { get; set; }
        [Column("smcsSize14Colour20")]
        public double? SmcsSize14Colour20 { get; set; }
        [Column("smcsSize14Colour21")]
        public double? SmcsSize14Colour21 { get; set; }
        [Column("smcsSize14Colour22")]
        public double? SmcsSize14Colour22 { get; set; }
        [Column("smcsSize14Colour23")]
        public double? SmcsSize14Colour23 { get; set; }
        [Column("smcsSize14Colour24")]
        public double? SmcsSize14Colour24 { get; set; }
        [Column("smcsSize15Colour1")]
        public double? SmcsSize15Colour1 { get; set; }
        [Column("smcsSize15Colour2")]
        public double? SmcsSize15Colour2 { get; set; }
        [Column("smcsSize15Colour3")]
        public double? SmcsSize15Colour3 { get; set; }
        [Column("smcsSize15Colour4")]
        public double? SmcsSize15Colour4 { get; set; }
        [Column("smcsSize15Colour5")]
        public double? SmcsSize15Colour5 { get; set; }
        [Column("smcsSize15Colour6")]
        public double? SmcsSize15Colour6 { get; set; }
        [Column("smcsSize15Colour7")]
        public double? SmcsSize15Colour7 { get; set; }
        [Column("smcsSize15Colour8")]
        public double? SmcsSize15Colour8 { get; set; }
        [Column("smcsSize15Colour9")]
        public double? SmcsSize15Colour9 { get; set; }
        [Column("smcsSize15Colour10")]
        public double? SmcsSize15Colour10 { get; set; }
        [Column("smcsSize15Colour11")]
        public double? SmcsSize15Colour11 { get; set; }
        [Column("smcsSize15Colour12")]
        public double? SmcsSize15Colour12 { get; set; }
        [Column("smcsSize15Colour13")]
        public double? SmcsSize15Colour13 { get; set; }
        [Column("smcsSize15Colour14")]
        public double? SmcsSize15Colour14 { get; set; }
        [Column("smcsSize15Colour15")]
        public double? SmcsSize15Colour15 { get; set; }
        [Column("smcsSize15Colour16")]
        public double? SmcsSize15Colour16 { get; set; }
        [Column("smcsSize15Colour17")]
        public double? SmcsSize15Colour17 { get; set; }
        [Column("smcsSize15Colour18")]
        public double? SmcsSize15Colour18 { get; set; }
        [Column("smcsSize15Colour19")]
        public double? SmcsSize15Colour19 { get; set; }
        [Column("smcsSize15Colour20")]
        public double? SmcsSize15Colour20 { get; set; }
        [Column("smcsSize15Colour21")]
        public double? SmcsSize15Colour21 { get; set; }
        [Column("smcsSize15Colour22")]
        public double? SmcsSize15Colour22 { get; set; }
        [Column("smcsSize15Colour23")]
        public double? SmcsSize15Colour23 { get; set; }
        [Column("smcsSize15Colour24")]
        public double? SmcsSize15Colour24 { get; set; }
        [Column("smcsSize16Colour1")]
        public double? SmcsSize16Colour1 { get; set; }
        [Column("smcsSize16Colour2")]
        public double? SmcsSize16Colour2 { get; set; }
        [Column("smcsSize16Colour3")]
        public double? SmcsSize16Colour3 { get; set; }
        [Column("smcsSize16Colour4")]
        public double? SmcsSize16Colour4 { get; set; }
        [Column("smcsSize16Colour5")]
        public double? SmcsSize16Colour5 { get; set; }
        [Column("smcsSize16Colour6")]
        public double? SmcsSize16Colour6 { get; set; }
        [Column("smcsSize16Colour7")]
        public double? SmcsSize16Colour7 { get; set; }
        [Column("smcsSize16Colour8")]
        public double? SmcsSize16Colour8 { get; set; }
        [Column("smcsSize16Colour9")]
        public double? SmcsSize16Colour9 { get; set; }
        [Column("smcsSize16Colour10")]
        public double? SmcsSize16Colour10 { get; set; }
        [Column("smcsSize16Colour11")]
        public double? SmcsSize16Colour11 { get; set; }
        [Column("smcsSize16Colour12")]
        public double? SmcsSize16Colour12 { get; set; }
        [Column("smcsSize16Colour13")]
        public double? SmcsSize16Colour13 { get; set; }
        [Column("smcsSize16Colour14")]
        public double? SmcsSize16Colour14 { get; set; }
        [Column("smcsSize16Colour15")]
        public double? SmcsSize16Colour15 { get; set; }
        [Column("smcsSize16Colour16")]
        public double? SmcsSize16Colour16 { get; set; }
        [Column("smcsSize16Colour17")]
        public double? SmcsSize16Colour17 { get; set; }
        [Column("smcsSize16Colour18")]
        public double? SmcsSize16Colour18 { get; set; }
        [Column("smcsSize16Colour19")]
        public double? SmcsSize16Colour19 { get; set; }
        [Column("smcsSize16Colour20")]
        public double? SmcsSize16Colour20 { get; set; }
        [Column("smcsSize16Colour21")]
        public double? SmcsSize16Colour21 { get; set; }
        [Column("smcsSize16Colour22")]
        public double? SmcsSize16Colour22 { get; set; }
        [Column("smcsSize16Colour23")]
        public double? SmcsSize16Colour23 { get; set; }
        [Column("smcsSize16Colour24")]
        public double? SmcsSize16Colour24 { get; set; }
        [Column("smcsSize17Colour1")]
        public double? SmcsSize17Colour1 { get; set; }
        [Column("smcsSize17Colour2")]
        public double? SmcsSize17Colour2 { get; set; }
        [Column("smcsSize17Colour3")]
        public double? SmcsSize17Colour3 { get; set; }
        [Column("smcsSize17Colour4")]
        public double? SmcsSize17Colour4 { get; set; }
        [Column("smcsSize17Colour5")]
        public double? SmcsSize17Colour5 { get; set; }
        [Column("smcsSize17Colour6")]
        public double? SmcsSize17Colour6 { get; set; }
        [Column("smcsSize17Colour7")]
        public double? SmcsSize17Colour7 { get; set; }
        [Column("smcsSize17Colour8")]
        public double? SmcsSize17Colour8 { get; set; }
        [Column("smcsSize17Colour9")]
        public double? SmcsSize17Colour9 { get; set; }
        [Column("smcsSize17Colour10")]
        public double? SmcsSize17Colour10 { get; set; }
        [Column("smcsSize17Colour11")]
        public double? SmcsSize17Colour11 { get; set; }
        [Column("smcsSize17Colour12")]
        public double? SmcsSize17Colour12 { get; set; }
        [Column("smcsSize17Colour13")]
        public double? SmcsSize17Colour13 { get; set; }
        [Column("smcsSize17Colour14")]
        public double? SmcsSize17Colour14 { get; set; }
        [Column("smcsSize17Colour15")]
        public double? SmcsSize17Colour15 { get; set; }
        [Column("smcsSize17Colour16")]
        public double? SmcsSize17Colour16 { get; set; }
        [Column("smcsSize17Colour17")]
        public double? SmcsSize17Colour17 { get; set; }
        [Column("smcsSize17Colour18")]
        public double? SmcsSize17Colour18 { get; set; }
        [Column("smcsSize17Colour19")]
        public double? SmcsSize17Colour19 { get; set; }
        [Column("smcsSize17Colour20")]
        public double? SmcsSize17Colour20 { get; set; }
        [Column("smcsSize17Colour21")]
        public double? SmcsSize17Colour21 { get; set; }
        [Column("smcsSize17Colour22")]
        public double? SmcsSize17Colour22 { get; set; }
        [Column("smcsSize17Colour23")]
        public double? SmcsSize17Colour23 { get; set; }
        [Column("smcsSize17Colour24")]
        public double? SmcsSize17Colour24 { get; set; }
        [Column("smcsSize18Colour1")]
        public double? SmcsSize18Colour1 { get; set; }
        [Column("smcsSize18Colour2")]
        public double? SmcsSize18Colour2 { get; set; }
        [Column("smcsSize18Colour3")]
        public double? SmcsSize18Colour3 { get; set; }
        [Column("smcsSize18Colour4")]
        public double? SmcsSize18Colour4 { get; set; }
        [Column("smcsSize18Colour5")]
        public double? SmcsSize18Colour5 { get; set; }
        [Column("smcsSize18Colour6")]
        public double? SmcsSize18Colour6 { get; set; }
        [Column("smcsSize18Colour7")]
        public double? SmcsSize18Colour7 { get; set; }
        [Column("smcsSize18Colour8")]
        public double? SmcsSize18Colour8 { get; set; }
        [Column("smcsSize18Colour9")]
        public double? SmcsSize18Colour9 { get; set; }
        [Column("smcsSize18Colour10")]
        public double? SmcsSize18Colour10 { get; set; }
        [Column("smcsSize18Colour11")]
        public double? SmcsSize18Colour11 { get; set; }
        [Column("smcsSize18Colour12")]
        public double? SmcsSize18Colour12 { get; set; }
        [Column("smcsSize18Colour13")]
        public double? SmcsSize18Colour13 { get; set; }
        [Column("smcsSize18Colour14")]
        public double? SmcsSize18Colour14 { get; set; }
        [Column("smcsSize18Colour15")]
        public double? SmcsSize18Colour15 { get; set; }
        [Column("smcsSize18Colour16")]
        public double? SmcsSize18Colour16 { get; set; }
        [Column("smcsSize18Colour17")]
        public double? SmcsSize18Colour17 { get; set; }
        [Column("smcsSize18Colour18")]
        public double? SmcsSize18Colour18 { get; set; }
        [Column("smcsSize18Colour19")]
        public double? SmcsSize18Colour19 { get; set; }
        [Column("smcsSize18Colour20")]
        public double? SmcsSize18Colour20 { get; set; }
        [Column("smcsSize18Colour21")]
        public double? SmcsSize18Colour21 { get; set; }
        [Column("smcsSize18Colour22")]
        public double? SmcsSize18Colour22 { get; set; }
        [Column("smcsSize18Colour23")]
        public double? SmcsSize18Colour23 { get; set; }
        [Column("smcsSize18Colour24")]
        public double? SmcsSize18Colour24 { get; set; }
        [Column("smcsSize19Colour1")]
        public double? SmcsSize19Colour1 { get; set; }
        [Column("smcsSize19Colour2")]
        public double? SmcsSize19Colour2 { get; set; }
        [Column("smcsSize19Colour3")]
        public double? SmcsSize19Colour3 { get; set; }
        [Column("smcsSize19Colour4")]
        public double? SmcsSize19Colour4 { get; set; }
        [Column("smcsSize19Colour5")]
        public double? SmcsSize19Colour5 { get; set; }
        [Column("smcsSize19Colour6")]
        public double? SmcsSize19Colour6 { get; set; }
        [Column("smcsSize19Colour7")]
        public double? SmcsSize19Colour7 { get; set; }
        [Column("smcsSize19Colour8")]
        public double? SmcsSize19Colour8 { get; set; }
        [Column("smcsSize19Colour9")]
        public double? SmcsSize19Colour9 { get; set; }
        [Column("smcsSize19Colour10")]
        public double? SmcsSize19Colour10 { get; set; }
        [Column("smcsSize19Colour11")]
        public double? SmcsSize19Colour11 { get; set; }
        [Column("smcsSize19Colour12")]
        public double? SmcsSize19Colour12 { get; set; }
        [Column("smcsSize19Colour13")]
        public double? SmcsSize19Colour13 { get; set; }
        [Column("smcsSize19Colour14")]
        public double? SmcsSize19Colour14 { get; set; }
        [Column("smcsSize19Colour15")]
        public double? SmcsSize19Colour15 { get; set; }
        [Column("smcsSize19Colour16")]
        public double? SmcsSize19Colour16 { get; set; }
        [Column("smcsSize19Colour17")]
        public double? SmcsSize19Colour17 { get; set; }
        [Column("smcsSize19Colour18")]
        public double? SmcsSize19Colour18 { get; set; }
        [Column("smcsSize19Colour19")]
        public double? SmcsSize19Colour19 { get; set; }
        [Column("smcsSize19Colour20")]
        public double? SmcsSize19Colour20 { get; set; }
        [Column("smcsSize19Colour21")]
        public double? SmcsSize19Colour21 { get; set; }
        [Column("smcsSize19Colour22")]
        public double? SmcsSize19Colour22 { get; set; }
        [Column("smcsSize19Colour23")]
        public double? SmcsSize19Colour23 { get; set; }
        [Column("smcsSize19Colour24")]
        public double? SmcsSize19Colour24 { get; set; }
        [Column("smcsSize20Colour1")]
        public double? SmcsSize20Colour1 { get; set; }
        [Column("smcsSize20Colour2")]
        public double? SmcsSize20Colour2 { get; set; }
        [Column("smcsSize20Colour3")]
        public double? SmcsSize20Colour3 { get; set; }
        [Column("smcsSize20Colour4")]
        public double? SmcsSize20Colour4 { get; set; }
        [Column("smcsSize20Colour5")]
        public double? SmcsSize20Colour5 { get; set; }
        [Column("smcsSize20Colour6")]
        public double? SmcsSize20Colour6 { get; set; }
        [Column("smcsSize20Colour7")]
        public double? SmcsSize20Colour7 { get; set; }
        [Column("smcsSize20Colour8")]
        public double? SmcsSize20Colour8 { get; set; }
        [Column("smcsSize20Colour9")]
        public double? SmcsSize20Colour9 { get; set; }
        [Column("smcsSize20Colour10")]
        public double? SmcsSize20Colour10 { get; set; }
        [Column("smcsSize20Colour11")]
        public double? SmcsSize20Colour11 { get; set; }
        [Column("smcsSize20Colour12")]
        public double? SmcsSize20Colour12 { get; set; }
        [Column("smcsSize20Colour13")]
        public double? SmcsSize20Colour13 { get; set; }
        [Column("smcsSize20Colour14")]
        public double? SmcsSize20Colour14 { get; set; }
        [Column("smcsSize20Colour15")]
        public double? SmcsSize20Colour15 { get; set; }
        [Column("smcsSize20Colour16")]
        public double? SmcsSize20Colour16 { get; set; }
        [Column("smcsSize20Colour17")]
        public double? SmcsSize20Colour17 { get; set; }
        [Column("smcsSize20Colour18")]
        public double? SmcsSize20Colour18 { get; set; }
        [Column("smcsSize20Colour19")]
        public double? SmcsSize20Colour19 { get; set; }
        [Column("smcsSize20Colour20")]
        public double? SmcsSize20Colour20 { get; set; }
        [Column("smcsSize20Colour21")]
        public double? SmcsSize20Colour21 { get; set; }
        [Column("smcsSize20Colour22")]
        public double? SmcsSize20Colour22 { get; set; }
        [Column("smcsSize20Colour23")]
        public double? SmcsSize20Colour23 { get; set; }
        [Column("smcsSize20Colour24")]
        public double? SmcsSize20Colour24 { get; set; }
    }
}
