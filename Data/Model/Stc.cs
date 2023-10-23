using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STCS")]
    [Index(nameof(StFileId), Name = "stcsByPos", IsUnique = true)]
    public partial class Stc
    {
        [Key]
        [Column("stcsFileId")]
        public int StcsFileId { get; set; }
        [Column("stFileId")]
        public int StFileId { get; set; }
        [Column("stcsSize1Colour1")]
        public double? StcsSize1Colour1 { get; set; }
        [Column("stcsSize1Colour2")]
        public double? StcsSize1Colour2 { get; set; }
        [Column("stcsSize1Colour3")]
        public double? StcsSize1Colour3 { get; set; }
        [Column("stcsSize1Colour4")]
        public double? StcsSize1Colour4 { get; set; }
        [Column("stcsSize1Colour5")]
        public double? StcsSize1Colour5 { get; set; }
        [Column("stcsSize1Colour6")]
        public double? StcsSize1Colour6 { get; set; }
        [Column("stcsSize1Colour7")]
        public double? StcsSize1Colour7 { get; set; }
        [Column("stcsSize1Colour8")]
        public double? StcsSize1Colour8 { get; set; }
        [Column("stcsSize1Colour9")]
        public double? StcsSize1Colour9 { get; set; }
        [Column("stcsSize1Colour10")]
        public double? StcsSize1Colour10 { get; set; }
        [Column("stcsSize1Colour11")]
        public double? StcsSize1Colour11 { get; set; }
        [Column("stcsSize1Colour12")]
        public double? StcsSize1Colour12 { get; set; }
        [Column("stcsSize1Colour13")]
        public double? StcsSize1Colour13 { get; set; }
        [Column("stcsSize1Colour14")]
        public double? StcsSize1Colour14 { get; set; }
        [Column("stcsSize1Colour15")]
        public double? StcsSize1Colour15 { get; set; }
        [Column("stcsSize1Colour16")]
        public double? StcsSize1Colour16 { get; set; }
        [Column("stcsSize1Colour17")]
        public double? StcsSize1Colour17 { get; set; }
        [Column("stcsSize1Colour18")]
        public double? StcsSize1Colour18 { get; set; }
        [Column("stcsSize1Colour19")]
        public double? StcsSize1Colour19 { get; set; }
        [Column("stcsSize1Colour20")]
        public double? StcsSize1Colour20 { get; set; }
        [Column("stcsSize1Colour21")]
        public double? StcsSize1Colour21 { get; set; }
        [Column("stcsSize1Colour22")]
        public double? StcsSize1Colour22 { get; set; }
        [Column("stcsSize1Colour23")]
        public double? StcsSize1Colour23 { get; set; }
        [Column("stcsSize1Colour24")]
        public double? StcsSize1Colour24 { get; set; }
        [Column("stcsSize2Colour1")]
        public double? StcsSize2Colour1 { get; set; }
        [Column("stcsSize2Colour2")]
        public double? StcsSize2Colour2 { get; set; }
        [Column("stcsSize2Colour3")]
        public double? StcsSize2Colour3 { get; set; }
        [Column("stcsSize2Colour4")]
        public double? StcsSize2Colour4 { get; set; }
        [Column("stcsSize2Colour5")]
        public double? StcsSize2Colour5 { get; set; }
        [Column("stcsSize2Colour6")]
        public double? StcsSize2Colour6 { get; set; }
        [Column("stcsSize2Colour7")]
        public double? StcsSize2Colour7 { get; set; }
        [Column("stcsSize2Colour8")]
        public double? StcsSize2Colour8 { get; set; }
        [Column("stcsSize2Colour9")]
        public double? StcsSize2Colour9 { get; set; }
        [Column("stcsSize2Colour10")]
        public double? StcsSize2Colour10 { get; set; }
        [Column("stcsSize2Colour11")]
        public double? StcsSize2Colour11 { get; set; }
        [Column("stcsSize2Colour12")]
        public double? StcsSize2Colour12 { get; set; }
        [Column("stcsSize2Colour13")]
        public double? StcsSize2Colour13 { get; set; }
        [Column("stcsSize2Colour14")]
        public double? StcsSize2Colour14 { get; set; }
        [Column("stcsSize2Colour15")]
        public double? StcsSize2Colour15 { get; set; }
        [Column("stcsSize2Colour16")]
        public double? StcsSize2Colour16 { get; set; }
        [Column("stcsSize2Colour17")]
        public double? StcsSize2Colour17 { get; set; }
        [Column("stcsSize2Colour18")]
        public double? StcsSize2Colour18 { get; set; }
        [Column("stcsSize2Colour19")]
        public double? StcsSize2Colour19 { get; set; }
        [Column("stcsSize2Colour20")]
        public double? StcsSize2Colour20 { get; set; }
        [Column("stcsSize2Colour21")]
        public double? StcsSize2Colour21 { get; set; }
        [Column("stcsSize2Colour22")]
        public double? StcsSize2Colour22 { get; set; }
        [Column("stcsSize2Colour23")]
        public double? StcsSize2Colour23 { get; set; }
        [Column("stcsSize2Colour24")]
        public double? StcsSize2Colour24 { get; set; }
        [Column("stcsSize3Colour1")]
        public double? StcsSize3Colour1 { get; set; }
        [Column("stcsSize3Colour2")]
        public double? StcsSize3Colour2 { get; set; }
        [Column("stcsSize3Colour3")]
        public double? StcsSize3Colour3 { get; set; }
        [Column("stcsSize3Colour4")]
        public double? StcsSize3Colour4 { get; set; }
        [Column("stcsSize3Colour5")]
        public double? StcsSize3Colour5 { get; set; }
        [Column("stcsSize3Colour6")]
        public double? StcsSize3Colour6 { get; set; }
        [Column("stcsSize3Colour7")]
        public double? StcsSize3Colour7 { get; set; }
        [Column("stcsSize3Colour8")]
        public double? StcsSize3Colour8 { get; set; }
        [Column("stcsSize3Colour9")]
        public double? StcsSize3Colour9 { get; set; }
        [Column("stcsSize3Colour10")]
        public double? StcsSize3Colour10 { get; set; }
        [Column("stcsSize3Colour11")]
        public double? StcsSize3Colour11 { get; set; }
        [Column("stcsSize3Colour12")]
        public double? StcsSize3Colour12 { get; set; }
        [Column("stcsSize3Colour13")]
        public double? StcsSize3Colour13 { get; set; }
        [Column("stcsSize3Colour14")]
        public double? StcsSize3Colour14 { get; set; }
        [Column("stcsSize3Colour15")]
        public double? StcsSize3Colour15 { get; set; }
        [Column("stcsSize3Colour16")]
        public double? StcsSize3Colour16 { get; set; }
        [Column("stcsSize3Colour17")]
        public double? StcsSize3Colour17 { get; set; }
        [Column("stcsSize3Colour18")]
        public double? StcsSize3Colour18 { get; set; }
        [Column("stcsSize3Colour19")]
        public double? StcsSize3Colour19 { get; set; }
        [Column("stcsSize3Colour20")]
        public double? StcsSize3Colour20 { get; set; }
        [Column("stcsSize3Colour21")]
        public double? StcsSize3Colour21 { get; set; }
        [Column("stcsSize3Colour22")]
        public double? StcsSize3Colour22 { get; set; }
        [Column("stcsSize3Colour23")]
        public double? StcsSize3Colour23 { get; set; }
        [Column("stcsSize3Colour24")]
        public double? StcsSize3Colour24 { get; set; }
        [Column("stcsSize4Colour1")]
        public double? StcsSize4Colour1 { get; set; }
        [Column("stcsSize4Colour2")]
        public double? StcsSize4Colour2 { get; set; }
        [Column("stcsSize4Colour3")]
        public double? StcsSize4Colour3 { get; set; }
        [Column("stcsSize4Colour4")]
        public double? StcsSize4Colour4 { get; set; }
        [Column("stcsSize4Colour5")]
        public double? StcsSize4Colour5 { get; set; }
        [Column("stcsSize4Colour6")]
        public double? StcsSize4Colour6 { get; set; }
        [Column("stcsSize4Colour7")]
        public double? StcsSize4Colour7 { get; set; }
        [Column("stcsSize4Colour8")]
        public double? StcsSize4Colour8 { get; set; }
        [Column("stcsSize4Colour9")]
        public double? StcsSize4Colour9 { get; set; }
        [Column("stcsSize4Colour10")]
        public double? StcsSize4Colour10 { get; set; }
        [Column("stcsSize4Colour11")]
        public double? StcsSize4Colour11 { get; set; }
        [Column("stcsSize4Colour12")]
        public double? StcsSize4Colour12 { get; set; }
        [Column("stcsSize4Colour13")]
        public double? StcsSize4Colour13 { get; set; }
        [Column("stcsSize4Colour14")]
        public double? StcsSize4Colour14 { get; set; }
        [Column("stcsSize4Colour15")]
        public double? StcsSize4Colour15 { get; set; }
        [Column("stcsSize4Colour16")]
        public double? StcsSize4Colour16 { get; set; }
        [Column("stcsSize4Colour17")]
        public double? StcsSize4Colour17 { get; set; }
        [Column("stcsSize4Colour18")]
        public double? StcsSize4Colour18 { get; set; }
        [Column("stcsSize4Colour19")]
        public double? StcsSize4Colour19 { get; set; }
        [Column("stcsSize4Colour20")]
        public double? StcsSize4Colour20 { get; set; }
        [Column("stcsSize4Colour21")]
        public double? StcsSize4Colour21 { get; set; }
        [Column("stcsSize4Colour22")]
        public double? StcsSize4Colour22 { get; set; }
        [Column("stcsSize4Colour23")]
        public double? StcsSize4Colour23 { get; set; }
        [Column("stcsSize4Colour24")]
        public double? StcsSize4Colour24 { get; set; }
        [Column("stcsSize5Colour1")]
        public double? StcsSize5Colour1 { get; set; }
        [Column("stcsSize5Colour2")]
        public double? StcsSize5Colour2 { get; set; }
        [Column("stcsSize5Colour3")]
        public double? StcsSize5Colour3 { get; set; }
        [Column("stcsSize5Colour4")]
        public double? StcsSize5Colour4 { get; set; }
        [Column("stcsSize5Colour5")]
        public double? StcsSize5Colour5 { get; set; }
        [Column("stcsSize5Colour6")]
        public double? StcsSize5Colour6 { get; set; }
        [Column("stcsSize5Colour7")]
        public double? StcsSize5Colour7 { get; set; }
        [Column("stcsSize5Colour8")]
        public double? StcsSize5Colour8 { get; set; }
        [Column("stcsSize5Colour9")]
        public double? StcsSize5Colour9 { get; set; }
        [Column("stcsSize5Colour10")]
        public double? StcsSize5Colour10 { get; set; }
        [Column("stcsSize5Colour11")]
        public double? StcsSize5Colour11 { get; set; }
        [Column("stcsSize5Colour12")]
        public double? StcsSize5Colour12 { get; set; }
        [Column("stcsSize5Colour13")]
        public double? StcsSize5Colour13 { get; set; }
        [Column("stcsSize5Colour14")]
        public double? StcsSize5Colour14 { get; set; }
        [Column("stcsSize5Colour15")]
        public double? StcsSize5Colour15 { get; set; }
        [Column("stcsSize5Colour16")]
        public double? StcsSize5Colour16 { get; set; }
        [Column("stcsSize5Colour17")]
        public double? StcsSize5Colour17 { get; set; }
        [Column("stcsSize5Colour18")]
        public double? StcsSize5Colour18 { get; set; }
        [Column("stcsSize5Colour19")]
        public double? StcsSize5Colour19 { get; set; }
        [Column("stcsSize5Colour20")]
        public double? StcsSize5Colour20 { get; set; }
        [Column("stcsSize5Colour21")]
        public double? StcsSize5Colour21 { get; set; }
        [Column("stcsSize5Colour22")]
        public double? StcsSize5Colour22 { get; set; }
        [Column("stcsSize5Colour23")]
        public double? StcsSize5Colour23 { get; set; }
        [Column("stcsSize5Colour24")]
        public double? StcsSize5Colour24 { get; set; }
        [Column("stcsSize6Colour1")]
        public double? StcsSize6Colour1 { get; set; }
        [Column("stcsSize6Colour2")]
        public double? StcsSize6Colour2 { get; set; }
        [Column("stcsSize6Colour3")]
        public double? StcsSize6Colour3 { get; set; }
        [Column("stcsSize6Colour4")]
        public double? StcsSize6Colour4 { get; set; }
        [Column("stcsSize6Colour5")]
        public double? StcsSize6Colour5 { get; set; }
        [Column("stcsSize6Colour6")]
        public double? StcsSize6Colour6 { get; set; }
        [Column("stcsSize6Colour7")]
        public double? StcsSize6Colour7 { get; set; }
        [Column("stcsSize6Colour8")]
        public double? StcsSize6Colour8 { get; set; }
        [Column("stcsSize6Colour9")]
        public double? StcsSize6Colour9 { get; set; }
        [Column("stcsSize6Colour10")]
        public double? StcsSize6Colour10 { get; set; }
        [Column("stcsSize6Colour11")]
        public double? StcsSize6Colour11 { get; set; }
        [Column("stcsSize6Colour12")]
        public double? StcsSize6Colour12 { get; set; }
        [Column("stcsSize6Colour13")]
        public double? StcsSize6Colour13 { get; set; }
        [Column("stcsSize6Colour14")]
        public double? StcsSize6Colour14 { get; set; }
        [Column("stcsSize6Colour15")]
        public double? StcsSize6Colour15 { get; set; }
        [Column("stcsSize6Colour16")]
        public double? StcsSize6Colour16 { get; set; }
        [Column("stcsSize6Colour17")]
        public double? StcsSize6Colour17 { get; set; }
        [Column("stcsSize6Colour18")]
        public double? StcsSize6Colour18 { get; set; }
        [Column("stcsSize6Colour19")]
        public double? StcsSize6Colour19 { get; set; }
        [Column("stcsSize6Colour20")]
        public double? StcsSize6Colour20 { get; set; }
        [Column("stcsSize6Colour21")]
        public double? StcsSize6Colour21 { get; set; }
        [Column("stcsSize6Colour22")]
        public double? StcsSize6Colour22 { get; set; }
        [Column("stcsSize6Colour23")]
        public double? StcsSize6Colour23 { get; set; }
        [Column("stcsSize6Colour24")]
        public double? StcsSize6Colour24 { get; set; }
        [Column("stcsSize7Colour1")]
        public double? StcsSize7Colour1 { get; set; }
        [Column("stcsSize7Colour2")]
        public double? StcsSize7Colour2 { get; set; }
        [Column("stcsSize7Colour3")]
        public double? StcsSize7Colour3 { get; set; }
        [Column("stcsSize7Colour4")]
        public double? StcsSize7Colour4 { get; set; }
        [Column("stcsSize7Colour5")]
        public double? StcsSize7Colour5 { get; set; }
        [Column("stcsSize7Colour6")]
        public double? StcsSize7Colour6 { get; set; }
        [Column("stcsSize7Colour7")]
        public double? StcsSize7Colour7 { get; set; }
        [Column("stcsSize7Colour8")]
        public double? StcsSize7Colour8 { get; set; }
        [Column("stcsSize7Colour9")]
        public double? StcsSize7Colour9 { get; set; }
        [Column("stcsSize7Colour10")]
        public double? StcsSize7Colour10 { get; set; }
        [Column("stcsSize7Colour11")]
        public double? StcsSize7Colour11 { get; set; }
        [Column("stcsSize7Colour12")]
        public double? StcsSize7Colour12 { get; set; }
        [Column("stcsSize7Colour13")]
        public double? StcsSize7Colour13 { get; set; }
        [Column("stcsSize7Colour14")]
        public double? StcsSize7Colour14 { get; set; }
        [Column("stcsSize7Colour15")]
        public double? StcsSize7Colour15 { get; set; }
        [Column("stcsSize7Colour16")]
        public double? StcsSize7Colour16 { get; set; }
        [Column("stcsSize7Colour17")]
        public double? StcsSize7Colour17 { get; set; }
        [Column("stcsSize7Colour18")]
        public double? StcsSize7Colour18 { get; set; }
        [Column("stcsSize7Colour19")]
        public double? StcsSize7Colour19 { get; set; }
        [Column("stcsSize7Colour20")]
        public double? StcsSize7Colour20 { get; set; }
        [Column("stcsSize7Colour21")]
        public double? StcsSize7Colour21 { get; set; }
        [Column("stcsSize7Colour22")]
        public double? StcsSize7Colour22 { get; set; }
        [Column("stcsSize7Colour23")]
        public double? StcsSize7Colour23 { get; set; }
        [Column("stcsSize7Colour24")]
        public double? StcsSize7Colour24 { get; set; }
        [Column("stcsSize8Colour1")]
        public double? StcsSize8Colour1 { get; set; }
        [Column("stcsSize8Colour2")]
        public double? StcsSize8Colour2 { get; set; }
        [Column("stcsSize8Colour3")]
        public double? StcsSize8Colour3 { get; set; }
        [Column("stcsSize8Colour4")]
        public double? StcsSize8Colour4 { get; set; }
        [Column("stcsSize8Colour5")]
        public double? StcsSize8Colour5 { get; set; }
        [Column("stcsSize8Colour6")]
        public double? StcsSize8Colour6 { get; set; }
        [Column("stcsSize8Colour7")]
        public double? StcsSize8Colour7 { get; set; }
        [Column("stcsSize8Colour8")]
        public double? StcsSize8Colour8 { get; set; }
        [Column("stcsSize8Colour9")]
        public double? StcsSize8Colour9 { get; set; }
        [Column("stcsSize8Colour10")]
        public double? StcsSize8Colour10 { get; set; }
        [Column("stcsSize8Colour11")]
        public double? StcsSize8Colour11 { get; set; }
        [Column("stcsSize8Colour12")]
        public double? StcsSize8Colour12 { get; set; }
        [Column("stcsSize8Colour13")]
        public double? StcsSize8Colour13 { get; set; }
        [Column("stcsSize8Colour14")]
        public double? StcsSize8Colour14 { get; set; }
        [Column("stcsSize8Colour15")]
        public double? StcsSize8Colour15 { get; set; }
        [Column("stcsSize8Colour16")]
        public double? StcsSize8Colour16 { get; set; }
        [Column("stcsSize8Colour17")]
        public double? StcsSize8Colour17 { get; set; }
        [Column("stcsSize8Colour18")]
        public double? StcsSize8Colour18 { get; set; }
        [Column("stcsSize8Colour19")]
        public double? StcsSize8Colour19 { get; set; }
        [Column("stcsSize8Colour20")]
        public double? StcsSize8Colour20 { get; set; }
        [Column("stcsSize8Colour21")]
        public double? StcsSize8Colour21 { get; set; }
        [Column("stcsSize8Colour22")]
        public double? StcsSize8Colour22 { get; set; }
        [Column("stcsSize8Colour23")]
        public double? StcsSize8Colour23 { get; set; }
        [Column("stcsSize8Colour24")]
        public double? StcsSize8Colour24 { get; set; }
        [Column("stcsSize9Colour1")]
        public double? StcsSize9Colour1 { get; set; }
        [Column("stcsSize9Colour2")]
        public double? StcsSize9Colour2 { get; set; }
        [Column("stcsSize9Colour3")]
        public double? StcsSize9Colour3 { get; set; }
        [Column("stcsSize9Colour4")]
        public double? StcsSize9Colour4 { get; set; }
        [Column("stcsSize9Colour5")]
        public double? StcsSize9Colour5 { get; set; }
        [Column("stcsSize9Colour6")]
        public double? StcsSize9Colour6 { get; set; }
        [Column("stcsSize9Colour7")]
        public double? StcsSize9Colour7 { get; set; }
        [Column("stcsSize9Colour8")]
        public double? StcsSize9Colour8 { get; set; }
        [Column("stcsSize9Colour9")]
        public double? StcsSize9Colour9 { get; set; }
        [Column("stcsSize9Colour10")]
        public double? StcsSize9Colour10 { get; set; }
        [Column("stcsSize9Colour11")]
        public double? StcsSize9Colour11 { get; set; }
        [Column("stcsSize9Colour12")]
        public double? StcsSize9Colour12 { get; set; }
        [Column("stcsSize9Colour13")]
        public double? StcsSize9Colour13 { get; set; }
        [Column("stcsSize9Colour14")]
        public double? StcsSize9Colour14 { get; set; }
        [Column("stcsSize9Colour15")]
        public double? StcsSize9Colour15 { get; set; }
        [Column("stcsSize9Colour16")]
        public double? StcsSize9Colour16 { get; set; }
        [Column("stcsSize9Colour17")]
        public double? StcsSize9Colour17 { get; set; }
        [Column("stcsSize9Colour18")]
        public double? StcsSize9Colour18 { get; set; }
        [Column("stcsSize9Colour19")]
        public double? StcsSize9Colour19 { get; set; }
        [Column("stcsSize9Colour20")]
        public double? StcsSize9Colour20 { get; set; }
        [Column("stcsSize9Colour21")]
        public double? StcsSize9Colour21 { get; set; }
        [Column("stcsSize9Colour22")]
        public double? StcsSize9Colour22 { get; set; }
        [Column("stcsSize9Colour23")]
        public double? StcsSize9Colour23 { get; set; }
        [Column("stcsSize9Colour24")]
        public double? StcsSize9Colour24 { get; set; }
        [Column("stcsSize10Colour1")]
        public double? StcsSize10Colour1 { get; set; }
        [Column("stcsSize10Colour2")]
        public double? StcsSize10Colour2 { get; set; }
        [Column("stcsSize10Colour3")]
        public double? StcsSize10Colour3 { get; set; }
        [Column("stcsSize10Colour4")]
        public double? StcsSize10Colour4 { get; set; }
        [Column("stcsSize10Colour5")]
        public double? StcsSize10Colour5 { get; set; }
        [Column("stcsSize10Colour6")]
        public double? StcsSize10Colour6 { get; set; }
        [Column("stcsSize10Colour7")]
        public double? StcsSize10Colour7 { get; set; }
        [Column("stcsSize10Colour8")]
        public double? StcsSize10Colour8 { get; set; }
        [Column("stcsSize10Colour9")]
        public double? StcsSize10Colour9 { get; set; }
        [Column("stcsSize10Colour10")]
        public double? StcsSize10Colour10 { get; set; }
        [Column("stcsSize10Colour11")]
        public double? StcsSize10Colour11 { get; set; }
        [Column("stcsSize10Colour12")]
        public double? StcsSize10Colour12 { get; set; }
        [Column("stcsSize10Colour13")]
        public double? StcsSize10Colour13 { get; set; }
        [Column("stcsSize10Colour14")]
        public double? StcsSize10Colour14 { get; set; }
        [Column("stcsSize10Colour15")]
        public double? StcsSize10Colour15 { get; set; }
        [Column("stcsSize10Colour16")]
        public double? StcsSize10Colour16 { get; set; }
        [Column("stcsSize10Colour17")]
        public double? StcsSize10Colour17 { get; set; }
        [Column("stcsSize10Colour18")]
        public double? StcsSize10Colour18 { get; set; }
        [Column("stcsSize10Colour19")]
        public double? StcsSize10Colour19 { get; set; }
        [Column("stcsSize10Colour20")]
        public double? StcsSize10Colour20 { get; set; }
        [Column("stcsSize10Colour21")]
        public double? StcsSize10Colour21 { get; set; }
        [Column("stcsSize10Colour22")]
        public double? StcsSize10Colour22 { get; set; }
        [Column("stcsSize10Colour23")]
        public double? StcsSize10Colour23 { get; set; }
        [Column("stcsSize10Colour24")]
        public double? StcsSize10Colour24 { get; set; }
        [Column("stcsSize11Colour1")]
        public double? StcsSize11Colour1 { get; set; }
        [Column("stcsSize11Colour2")]
        public double? StcsSize11Colour2 { get; set; }
        [Column("stcsSize11Colour3")]
        public double? StcsSize11Colour3 { get; set; }
        [Column("stcsSize11Colour4")]
        public double? StcsSize11Colour4 { get; set; }
        [Column("stcsSize11Colour5")]
        public double? StcsSize11Colour5 { get; set; }
        [Column("stcsSize11Colour6")]
        public double? StcsSize11Colour6 { get; set; }
        [Column("stcsSize11Colour7")]
        public double? StcsSize11Colour7 { get; set; }
        [Column("stcsSize11Colour8")]
        public double? StcsSize11Colour8 { get; set; }
        [Column("stcsSize11Colour9")]
        public double? StcsSize11Colour9 { get; set; }
        [Column("stcsSize11Colour10")]
        public double? StcsSize11Colour10 { get; set; }
        [Column("stcsSize11Colour11")]
        public double? StcsSize11Colour11 { get; set; }
        [Column("stcsSize11Colour12")]
        public double? StcsSize11Colour12 { get; set; }
        [Column("stcsSize11Colour13")]
        public double? StcsSize11Colour13 { get; set; }
        [Column("stcsSize11Colour14")]
        public double? StcsSize11Colour14 { get; set; }
        [Column("stcsSize11Colour15")]
        public double? StcsSize11Colour15 { get; set; }
        [Column("stcsSize11Colour16")]
        public double? StcsSize11Colour16 { get; set; }
        [Column("stcsSize11Colour17")]
        public double? StcsSize11Colour17 { get; set; }
        [Column("stcsSize11Colour18")]
        public double? StcsSize11Colour18 { get; set; }
        [Column("stcsSize11Colour19")]
        public double? StcsSize11Colour19 { get; set; }
        [Column("stcsSize11Colour20")]
        public double? StcsSize11Colour20 { get; set; }
        [Column("stcsSize11Colour21")]
        public double? StcsSize11Colour21 { get; set; }
        [Column("stcsSize11Colour22")]
        public double? StcsSize11Colour22 { get; set; }
        [Column("stcsSize11Colour23")]
        public double? StcsSize11Colour23 { get; set; }
        [Column("stcsSize11Colour24")]
        public double? StcsSize11Colour24 { get; set; }
        [Column("stcsSize12Colour1")]
        public double? StcsSize12Colour1 { get; set; }
        [Column("stcsSize12Colour2")]
        public double? StcsSize12Colour2 { get; set; }
        [Column("stcsSize12Colour3")]
        public double? StcsSize12Colour3 { get; set; }
        [Column("stcsSize12Colour4")]
        public double? StcsSize12Colour4 { get; set; }
        [Column("stcsSize12Colour5")]
        public double? StcsSize12Colour5 { get; set; }
        [Column("stcsSize12Colour6")]
        public double? StcsSize12Colour6 { get; set; }
        [Column("stcsSize12Colour7")]
        public double? StcsSize12Colour7 { get; set; }
        [Column("stcsSize12Colour8")]
        public double? StcsSize12Colour8 { get; set; }
        [Column("stcsSize12Colour9")]
        public double? StcsSize12Colour9 { get; set; }
        [Column("stcsSize12Colour10")]
        public double? StcsSize12Colour10 { get; set; }
        [Column("stcsSize12Colour11")]
        public double? StcsSize12Colour11 { get; set; }
        [Column("stcsSize12Colour12")]
        public double? StcsSize12Colour12 { get; set; }
        [Column("stcsSize12Colour13")]
        public double? StcsSize12Colour13 { get; set; }
        [Column("stcsSize12Colour14")]
        public double? StcsSize12Colour14 { get; set; }
        [Column("stcsSize12Colour15")]
        public double? StcsSize12Colour15 { get; set; }
        [Column("stcsSize12Colour16")]
        public double? StcsSize12Colour16 { get; set; }
        [Column("stcsSize12Colour17")]
        public double? StcsSize12Colour17 { get; set; }
        [Column("stcsSize12Colour18")]
        public double? StcsSize12Colour18 { get; set; }
        [Column("stcsSize12Colour19")]
        public double? StcsSize12Colour19 { get; set; }
        [Column("stcsSize12Colour20")]
        public double? StcsSize12Colour20 { get; set; }
        [Column("stcsSize12Colour21")]
        public double? StcsSize12Colour21 { get; set; }
        [Column("stcsSize12Colour22")]
        public double? StcsSize12Colour22 { get; set; }
        [Column("stcsSize12Colour23")]
        public double? StcsSize12Colour23 { get; set; }
        [Column("stcsSize12Colour24")]
        public double? StcsSize12Colour24 { get; set; }
        [Column("stcsSize13Colour1")]
        public double? StcsSize13Colour1 { get; set; }
        [Column("stcsSize13Colour2")]
        public double? StcsSize13Colour2 { get; set; }
        [Column("stcsSize13Colour3")]
        public double? StcsSize13Colour3 { get; set; }
        [Column("stcsSize13Colour4")]
        public double? StcsSize13Colour4 { get; set; }
        [Column("stcsSize13Colour5")]
        public double? StcsSize13Colour5 { get; set; }
        [Column("stcsSize13Colour6")]
        public double? StcsSize13Colour6 { get; set; }
        [Column("stcsSize13Colour7")]
        public double? StcsSize13Colour7 { get; set; }
        [Column("stcsSize13Colour8")]
        public double? StcsSize13Colour8 { get; set; }
        [Column("stcsSize13Colour9")]
        public double? StcsSize13Colour9 { get; set; }
        [Column("stcsSize13Colour10")]
        public double? StcsSize13Colour10 { get; set; }
        [Column("stcsSize13Colour11")]
        public double? StcsSize13Colour11 { get; set; }
        [Column("stcsSize13Colour12")]
        public double? StcsSize13Colour12 { get; set; }
        [Column("stcsSize13Colour13")]
        public double? StcsSize13Colour13 { get; set; }
        [Column("stcsSize13Colour14")]
        public double? StcsSize13Colour14 { get; set; }
        [Column("stcsSize13Colour15")]
        public double? StcsSize13Colour15 { get; set; }
        [Column("stcsSize13Colour16")]
        public double? StcsSize13Colour16 { get; set; }
        [Column("stcsSize13Colour17")]
        public double? StcsSize13Colour17 { get; set; }
        [Column("stcsSize13Colour18")]
        public double? StcsSize13Colour18 { get; set; }
        [Column("stcsSize13Colour19")]
        public double? StcsSize13Colour19 { get; set; }
        [Column("stcsSize13Colour20")]
        public double? StcsSize13Colour20 { get; set; }
        [Column("stcsSize13Colour21")]
        public double? StcsSize13Colour21 { get; set; }
        [Column("stcsSize13Colour22")]
        public double? StcsSize13Colour22 { get; set; }
        [Column("stcsSize13Colour23")]
        public double? StcsSize13Colour23 { get; set; }
        [Column("stcsSize13Colour24")]
        public double? StcsSize13Colour24 { get; set; }
        [Column("stcsSize14Colour1")]
        public double? StcsSize14Colour1 { get; set; }
        [Column("stcsSize14Colour2")]
        public double? StcsSize14Colour2 { get; set; }
        [Column("stcsSize14Colour3")]
        public double? StcsSize14Colour3 { get; set; }
        [Column("stcsSize14Colour4")]
        public double? StcsSize14Colour4 { get; set; }
        [Column("stcsSize14Colour5")]
        public double? StcsSize14Colour5 { get; set; }
        [Column("stcsSize14Colour6")]
        public double? StcsSize14Colour6 { get; set; }
        [Column("stcsSize14Colour7")]
        public double? StcsSize14Colour7 { get; set; }
        [Column("stcsSize14Colour8")]
        public double? StcsSize14Colour8 { get; set; }
        [Column("stcsSize14Colour9")]
        public double? StcsSize14Colour9 { get; set; }
        [Column("stcsSize14Colour10")]
        public double? StcsSize14Colour10 { get; set; }
        [Column("stcsSize14Colour11")]
        public double? StcsSize14Colour11 { get; set; }
        [Column("stcsSize14Colour12")]
        public double? StcsSize14Colour12 { get; set; }
        [Column("stcsSize14Colour13")]
        public double? StcsSize14Colour13 { get; set; }
        [Column("stcsSize14Colour14")]
        public double? StcsSize14Colour14 { get; set; }
        [Column("stcsSize14Colour15")]
        public double? StcsSize14Colour15 { get; set; }
        [Column("stcsSize14Colour16")]
        public double? StcsSize14Colour16 { get; set; }
        [Column("stcsSize14Colour17")]
        public double? StcsSize14Colour17 { get; set; }
        [Column("stcsSize14Colour18")]
        public double? StcsSize14Colour18 { get; set; }
        [Column("stcsSize14Colour19")]
        public double? StcsSize14Colour19 { get; set; }
        [Column("stcsSize14Colour20")]
        public double? StcsSize14Colour20 { get; set; }
        [Column("stcsSize14Colour21")]
        public double? StcsSize14Colour21 { get; set; }
        [Column("stcsSize14Colour22")]
        public double? StcsSize14Colour22 { get; set; }
        [Column("stcsSize14Colour23")]
        public double? StcsSize14Colour23 { get; set; }
        [Column("stcsSize14Colour24")]
        public double? StcsSize14Colour24 { get; set; }
        [Column("stcsSize15Colour1")]
        public double? StcsSize15Colour1 { get; set; }
        [Column("stcsSize15Colour2")]
        public double? StcsSize15Colour2 { get; set; }
        [Column("stcsSize15Colour3")]
        public double? StcsSize15Colour3 { get; set; }
        [Column("stcsSize15Colour4")]
        public double? StcsSize15Colour4 { get; set; }
        [Column("stcsSize15Colour5")]
        public double? StcsSize15Colour5 { get; set; }
        [Column("stcsSize15Colour6")]
        public double? StcsSize15Colour6 { get; set; }
        [Column("stcsSize15Colour7")]
        public double? StcsSize15Colour7 { get; set; }
        [Column("stcsSize15Colour8")]
        public double? StcsSize15Colour8 { get; set; }
        [Column("stcsSize15Colour9")]
        public double? StcsSize15Colour9 { get; set; }
        [Column("stcsSize15Colour10")]
        public double? StcsSize15Colour10 { get; set; }
        [Column("stcsSize15Colour11")]
        public double? StcsSize15Colour11 { get; set; }
        [Column("stcsSize15Colour12")]
        public double? StcsSize15Colour12 { get; set; }
        [Column("stcsSize15Colour13")]
        public double? StcsSize15Colour13 { get; set; }
        [Column("stcsSize15Colour14")]
        public double? StcsSize15Colour14 { get; set; }
        [Column("stcsSize15Colour15")]
        public double? StcsSize15Colour15 { get; set; }
        [Column("stcsSize15Colour16")]
        public double? StcsSize15Colour16 { get; set; }
        [Column("stcsSize15Colour17")]
        public double? StcsSize15Colour17 { get; set; }
        [Column("stcsSize15Colour18")]
        public double? StcsSize15Colour18 { get; set; }
        [Column("stcsSize15Colour19")]
        public double? StcsSize15Colour19 { get; set; }
        [Column("stcsSize15Colour20")]
        public double? StcsSize15Colour20 { get; set; }
        [Column("stcsSize15Colour21")]
        public double? StcsSize15Colour21 { get; set; }
        [Column("stcsSize15Colour22")]
        public double? StcsSize15Colour22 { get; set; }
        [Column("stcsSize15Colour23")]
        public double? StcsSize15Colour23 { get; set; }
        [Column("stcsSize15Colour24")]
        public double? StcsSize15Colour24 { get; set; }
        [Column("stcsSize16Colour1")]
        public double? StcsSize16Colour1 { get; set; }
        [Column("stcsSize16Colour2")]
        public double? StcsSize16Colour2 { get; set; }
        [Column("stcsSize16Colour3")]
        public double? StcsSize16Colour3 { get; set; }
        [Column("stcsSize16Colour4")]
        public double? StcsSize16Colour4 { get; set; }
        [Column("stcsSize16Colour5")]
        public double? StcsSize16Colour5 { get; set; }
        [Column("stcsSize16Colour6")]
        public double? StcsSize16Colour6 { get; set; }
        [Column("stcsSize16Colour7")]
        public double? StcsSize16Colour7 { get; set; }
        [Column("stcsSize16Colour8")]
        public double? StcsSize16Colour8 { get; set; }
        [Column("stcsSize16Colour9")]
        public double? StcsSize16Colour9 { get; set; }
        [Column("stcsSize16Colour10")]
        public double? StcsSize16Colour10 { get; set; }
        [Column("stcsSize16Colour11")]
        public double? StcsSize16Colour11 { get; set; }
        [Column("stcsSize16Colour12")]
        public double? StcsSize16Colour12 { get; set; }
        [Column("stcsSize16Colour13")]
        public double? StcsSize16Colour13 { get; set; }
        [Column("stcsSize16Colour14")]
        public double? StcsSize16Colour14 { get; set; }
        [Column("stcsSize16Colour15")]
        public double? StcsSize16Colour15 { get; set; }
        [Column("stcsSize16Colour16")]
        public double? StcsSize16Colour16 { get; set; }
        [Column("stcsSize16Colour17")]
        public double? StcsSize16Colour17 { get; set; }
        [Column("stcsSize16Colour18")]
        public double? StcsSize16Colour18 { get; set; }
        [Column("stcsSize16Colour19")]
        public double? StcsSize16Colour19 { get; set; }
        [Column("stcsSize16Colour20")]
        public double? StcsSize16Colour20 { get; set; }
        [Column("stcsSize16Colour21")]
        public double? StcsSize16Colour21 { get; set; }
        [Column("stcsSize16Colour22")]
        public double? StcsSize16Colour22 { get; set; }
        [Column("stcsSize16Colour23")]
        public double? StcsSize16Colour23 { get; set; }
        [Column("stcsSize16Colour24")]
        public double? StcsSize16Colour24 { get; set; }
        [Column("stcsSize17Colour1")]
        public double? StcsSize17Colour1 { get; set; }
        [Column("stcsSize17Colour2")]
        public double? StcsSize17Colour2 { get; set; }
        [Column("stcsSize17Colour3")]
        public double? StcsSize17Colour3 { get; set; }
        [Column("stcsSize17Colour4")]
        public double? StcsSize17Colour4 { get; set; }
        [Column("stcsSize17Colour5")]
        public double? StcsSize17Colour5 { get; set; }
        [Column("stcsSize17Colour6")]
        public double? StcsSize17Colour6 { get; set; }
        [Column("stcsSize17Colour7")]
        public double? StcsSize17Colour7 { get; set; }
        [Column("stcsSize17Colour8")]
        public double? StcsSize17Colour8 { get; set; }
        [Column("stcsSize17Colour9")]
        public double? StcsSize17Colour9 { get; set; }
        [Column("stcsSize17Colour10")]
        public double? StcsSize17Colour10 { get; set; }
        [Column("stcsSize17Colour11")]
        public double? StcsSize17Colour11 { get; set; }
        [Column("stcsSize17Colour12")]
        public double? StcsSize17Colour12 { get; set; }
        [Column("stcsSize17Colour13")]
        public double? StcsSize17Colour13 { get; set; }
        [Column("stcsSize17Colour14")]
        public double? StcsSize17Colour14 { get; set; }
        [Column("stcsSize17Colour15")]
        public double? StcsSize17Colour15 { get; set; }
        [Column("stcsSize17Colour16")]
        public double? StcsSize17Colour16 { get; set; }
        [Column("stcsSize17Colour17")]
        public double? StcsSize17Colour17 { get; set; }
        [Column("stcsSize17Colour18")]
        public double? StcsSize17Colour18 { get; set; }
        [Column("stcsSize17Colour19")]
        public double? StcsSize17Colour19 { get; set; }
        [Column("stcsSize17Colour20")]
        public double? StcsSize17Colour20 { get; set; }
        [Column("stcsSize17Colour21")]
        public double? StcsSize17Colour21 { get; set; }
        [Column("stcsSize17Colour22")]
        public double? StcsSize17Colour22 { get; set; }
        [Column("stcsSize17Colour23")]
        public double? StcsSize17Colour23 { get; set; }
        [Column("stcsSize17Colour24")]
        public double? StcsSize17Colour24 { get; set; }
        [Column("stcsSize18Colour1")]
        public double? StcsSize18Colour1 { get; set; }
        [Column("stcsSize18Colour2")]
        public double? StcsSize18Colour2 { get; set; }
        [Column("stcsSize18Colour3")]
        public double? StcsSize18Colour3 { get; set; }
        [Column("stcsSize18Colour4")]
        public double? StcsSize18Colour4 { get; set; }
        [Column("stcsSize18Colour5")]
        public double? StcsSize18Colour5 { get; set; }
        [Column("stcsSize18Colour6")]
        public double? StcsSize18Colour6 { get; set; }
        [Column("stcsSize18Colour7")]
        public double? StcsSize18Colour7 { get; set; }
        [Column("stcsSize18Colour8")]
        public double? StcsSize18Colour8 { get; set; }
        [Column("stcsSize18Colour9")]
        public double? StcsSize18Colour9 { get; set; }
        [Column("stcsSize18Colour10")]
        public double? StcsSize18Colour10 { get; set; }
        [Column("stcsSize18Colour11")]
        public double? StcsSize18Colour11 { get; set; }
        [Column("stcsSize18Colour12")]
        public double? StcsSize18Colour12 { get; set; }
        [Column("stcsSize18Colour13")]
        public double? StcsSize18Colour13 { get; set; }
        [Column("stcsSize18Colour14")]
        public double? StcsSize18Colour14 { get; set; }
        [Column("stcsSize18Colour15")]
        public double? StcsSize18Colour15 { get; set; }
        [Column("stcsSize18Colour16")]
        public double? StcsSize18Colour16 { get; set; }
        [Column("stcsSize18Colour17")]
        public double? StcsSize18Colour17 { get; set; }
        [Column("stcsSize18Colour18")]
        public double? StcsSize18Colour18 { get; set; }
        [Column("stcsSize18Colour19")]
        public double? StcsSize18Colour19 { get; set; }
        [Column("stcsSize18Colour20")]
        public double? StcsSize18Colour20 { get; set; }
        [Column("stcsSize18Colour21")]
        public double? StcsSize18Colour21 { get; set; }
        [Column("stcsSize18Colour22")]
        public double? StcsSize18Colour22 { get; set; }
        [Column("stcsSize18Colour23")]
        public double? StcsSize18Colour23 { get; set; }
        [Column("stcsSize18Colour24")]
        public double? StcsSize18Colour24 { get; set; }
        [Column("stcsSize19Colour1")]
        public double? StcsSize19Colour1 { get; set; }
        [Column("stcsSize19Colour2")]
        public double? StcsSize19Colour2 { get; set; }
        [Column("stcsSize19Colour3")]
        public double? StcsSize19Colour3 { get; set; }
        [Column("stcsSize19Colour4")]
        public double? StcsSize19Colour4 { get; set; }
        [Column("stcsSize19Colour5")]
        public double? StcsSize19Colour5 { get; set; }
        [Column("stcsSize19Colour6")]
        public double? StcsSize19Colour6 { get; set; }
        [Column("stcsSize19Colour7")]
        public double? StcsSize19Colour7 { get; set; }
        [Column("stcsSize19Colour8")]
        public double? StcsSize19Colour8 { get; set; }
        [Column("stcsSize19Colour9")]
        public double? StcsSize19Colour9 { get; set; }
        [Column("stcsSize19Colour10")]
        public double? StcsSize19Colour10 { get; set; }
        [Column("stcsSize19Colour11")]
        public double? StcsSize19Colour11 { get; set; }
        [Column("stcsSize19Colour12")]
        public double? StcsSize19Colour12 { get; set; }
        [Column("stcsSize19Colour13")]
        public double? StcsSize19Colour13 { get; set; }
        [Column("stcsSize19Colour14")]
        public double? StcsSize19Colour14 { get; set; }
        [Column("stcsSize19Colour15")]
        public double? StcsSize19Colour15 { get; set; }
        [Column("stcsSize19Colour16")]
        public double? StcsSize19Colour16 { get; set; }
        [Column("stcsSize19Colour17")]
        public double? StcsSize19Colour17 { get; set; }
        [Column("stcsSize19Colour18")]
        public double? StcsSize19Colour18 { get; set; }
        [Column("stcsSize19Colour19")]
        public double? StcsSize19Colour19 { get; set; }
        [Column("stcsSize19Colour20")]
        public double? StcsSize19Colour20 { get; set; }
        [Column("stcsSize19Colour21")]
        public double? StcsSize19Colour21 { get; set; }
        [Column("stcsSize19Colour22")]
        public double? StcsSize19Colour22 { get; set; }
        [Column("stcsSize19Colour23")]
        public double? StcsSize19Colour23 { get; set; }
        [Column("stcsSize19Colour24")]
        public double? StcsSize19Colour24 { get; set; }
        [Column("stcsSize20Colour1")]
        public double? StcsSize20Colour1 { get; set; }
        [Column("stcsSize20Colour2")]
        public double? StcsSize20Colour2 { get; set; }
        [Column("stcsSize20Colour3")]
        public double? StcsSize20Colour3 { get; set; }
        [Column("stcsSize20Colour4")]
        public double? StcsSize20Colour4 { get; set; }
        [Column("stcsSize20Colour5")]
        public double? StcsSize20Colour5 { get; set; }
        [Column("stcsSize20Colour6")]
        public double? StcsSize20Colour6 { get; set; }
        [Column("stcsSize20Colour7")]
        public double? StcsSize20Colour7 { get; set; }
        [Column("stcsSize20Colour8")]
        public double? StcsSize20Colour8 { get; set; }
        [Column("stcsSize20Colour9")]
        public double? StcsSize20Colour9 { get; set; }
        [Column("stcsSize20Colour10")]
        public double? StcsSize20Colour10 { get; set; }
        [Column("stcsSize20Colour11")]
        public double? StcsSize20Colour11 { get; set; }
        [Column("stcsSize20Colour12")]
        public double? StcsSize20Colour12 { get; set; }
        [Column("stcsSize20Colour13")]
        public double? StcsSize20Colour13 { get; set; }
        [Column("stcsSize20Colour14")]
        public double? StcsSize20Colour14 { get; set; }
        [Column("stcsSize20Colour15")]
        public double? StcsSize20Colour15 { get; set; }
        [Column("stcsSize20Colour16")]
        public double? StcsSize20Colour16 { get; set; }
        [Column("stcsSize20Colour17")]
        public double? StcsSize20Colour17 { get; set; }
        [Column("stcsSize20Colour18")]
        public double? StcsSize20Colour18 { get; set; }
        [Column("stcsSize20Colour19")]
        public double? StcsSize20Colour19 { get; set; }
        [Column("stcsSize20Colour20")]
        public double? StcsSize20Colour20 { get; set; }
        [Column("stcsSize20Colour21")]
        public double? StcsSize20Colour21 { get; set; }
        [Column("stcsSize20Colour22")]
        public double? StcsSize20Colour22 { get; set; }
        [Column("stcsSize20Colour23")]
        public double? StcsSize20Colour23 { get; set; }
        [Column("stcsSize20Colour24")]
        public double? StcsSize20Colour24 { get; set; }
    }
}
