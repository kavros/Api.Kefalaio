using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VM2CS")]
    [Index(nameof(Vm2csPos), nameof(Vm2csLine), Name = "vm2csByPos", IsUnique = true)]
    public partial class Vm2c
    {
        [Key]
        [Column("vm2csFileId")]
        public int Vm2csFileId { get; set; }
        [Column("vm2csPos")]
        public int Vm2csPos { get; set; }
        [Column("vm2csLine")]
        public int Vm2csLine { get; set; }
        [Column("vm2csSize1Colour1")]
        public double? Vm2csSize1Colour1 { get; set; }
        [Column("vm2csSize1Colour2")]
        public double? Vm2csSize1Colour2 { get; set; }
        [Column("vm2csSize1Colour3")]
        public double? Vm2csSize1Colour3 { get; set; }
        [Column("vm2csSize1Colour4")]
        public double? Vm2csSize1Colour4 { get; set; }
        [Column("vm2csSize1Colour5")]
        public double? Vm2csSize1Colour5 { get; set; }
        [Column("vm2csSize1Colour6")]
        public double? Vm2csSize1Colour6 { get; set; }
        [Column("vm2csSize1Colour7")]
        public double? Vm2csSize1Colour7 { get; set; }
        [Column("vm2csSize1Colour8")]
        public double? Vm2csSize1Colour8 { get; set; }
        [Column("vm2csSize1Colour9")]
        public double? Vm2csSize1Colour9 { get; set; }
        [Column("vm2csSize1Colour10")]
        public double? Vm2csSize1Colour10 { get; set; }
        [Column("vm2csSize1Colour11")]
        public double? Vm2csSize1Colour11 { get; set; }
        [Column("vm2csSize1Colour12")]
        public double? Vm2csSize1Colour12 { get; set; }
        [Column("vm2csSize1Colour13")]
        public double? Vm2csSize1Colour13 { get; set; }
        [Column("vm2csSize1Colour14")]
        public double? Vm2csSize1Colour14 { get; set; }
        [Column("vm2csSize1Colour15")]
        public double? Vm2csSize1Colour15 { get; set; }
        [Column("vm2csSize1Colour16")]
        public double? Vm2csSize1Colour16 { get; set; }
        [Column("vm2csSize1Colour17")]
        public double? Vm2csSize1Colour17 { get; set; }
        [Column("vm2csSize1Colour18")]
        public double? Vm2csSize1Colour18 { get; set; }
        [Column("vm2csSize1Colour19")]
        public double? Vm2csSize1Colour19 { get; set; }
        [Column("vm2csSize1Colour20")]
        public double? Vm2csSize1Colour20 { get; set; }
        [Column("vm2csSize1Colour21")]
        public double? Vm2csSize1Colour21 { get; set; }
        [Column("vm2csSize1Colour22")]
        public double? Vm2csSize1Colour22 { get; set; }
        [Column("vm2csSize1Colour23")]
        public double? Vm2csSize1Colour23 { get; set; }
        [Column("vm2csSize1Colour24")]
        public double? Vm2csSize1Colour24 { get; set; }
        [Column("vm2csSize2Colour1")]
        public double? Vm2csSize2Colour1 { get; set; }
        [Column("vm2csSize2Colour2")]
        public double? Vm2csSize2Colour2 { get; set; }
        [Column("vm2csSize2Colour3")]
        public double? Vm2csSize2Colour3 { get; set; }
        [Column("vm2csSize2Colour4")]
        public double? Vm2csSize2Colour4 { get; set; }
        [Column("vm2csSize2Colour5")]
        public double? Vm2csSize2Colour5 { get; set; }
        [Column("vm2csSize2Colour6")]
        public double? Vm2csSize2Colour6 { get; set; }
        [Column("vm2csSize2Colour7")]
        public double? Vm2csSize2Colour7 { get; set; }
        [Column("vm2csSize2Colour8")]
        public double? Vm2csSize2Colour8 { get; set; }
        [Column("vm2csSize2Colour9")]
        public double? Vm2csSize2Colour9 { get; set; }
        [Column("vm2csSize2Colour10")]
        public double? Vm2csSize2Colour10 { get; set; }
        [Column("vm2csSize2Colour11")]
        public double? Vm2csSize2Colour11 { get; set; }
        [Column("vm2csSize2Colour12")]
        public double? Vm2csSize2Colour12 { get; set; }
        [Column("vm2csSize2Colour13")]
        public double? Vm2csSize2Colour13 { get; set; }
        [Column("vm2csSize2Colour14")]
        public double? Vm2csSize2Colour14 { get; set; }
        [Column("vm2csSize2Colour15")]
        public double? Vm2csSize2Colour15 { get; set; }
        [Column("vm2csSize2Colour16")]
        public double? Vm2csSize2Colour16 { get; set; }
        [Column("vm2csSize2Colour17")]
        public double? Vm2csSize2Colour17 { get; set; }
        [Column("vm2csSize2Colour18")]
        public double? Vm2csSize2Colour18 { get; set; }
        [Column("vm2csSize2Colour19")]
        public double? Vm2csSize2Colour19 { get; set; }
        [Column("vm2csSize2Colour20")]
        public double? Vm2csSize2Colour20 { get; set; }
        [Column("vm2csSize2Colour21")]
        public double? Vm2csSize2Colour21 { get; set; }
        [Column("vm2csSize2Colour22")]
        public double? Vm2csSize2Colour22 { get; set; }
        [Column("vm2csSize2Colour23")]
        public double? Vm2csSize2Colour23 { get; set; }
        [Column("vm2csSize2Colour24")]
        public double? Vm2csSize2Colour24 { get; set; }
        [Column("vm2csSize3Colour1")]
        public double? Vm2csSize3Colour1 { get; set; }
        [Column("vm2csSize3Colour2")]
        public double? Vm2csSize3Colour2 { get; set; }
        [Column("vm2csSize3Colour3")]
        public double? Vm2csSize3Colour3 { get; set; }
        [Column("vm2csSize3Colour4")]
        public double? Vm2csSize3Colour4 { get; set; }
        [Column("vm2csSize3Colour5")]
        public double? Vm2csSize3Colour5 { get; set; }
        [Column("vm2csSize3Colour6")]
        public double? Vm2csSize3Colour6 { get; set; }
        [Column("vm2csSize3Colour7")]
        public double? Vm2csSize3Colour7 { get; set; }
        [Column("vm2csSize3Colour8")]
        public double? Vm2csSize3Colour8 { get; set; }
        [Column("vm2csSize3Colour9")]
        public double? Vm2csSize3Colour9 { get; set; }
        [Column("vm2csSize3Colour10")]
        public double? Vm2csSize3Colour10 { get; set; }
        [Column("vm2csSize3Colour11")]
        public double? Vm2csSize3Colour11 { get; set; }
        [Column("vm2csSize3Colour12")]
        public double? Vm2csSize3Colour12 { get; set; }
        [Column("vm2csSize3Colour13")]
        public double? Vm2csSize3Colour13 { get; set; }
        [Column("vm2csSize3Colour14")]
        public double? Vm2csSize3Colour14 { get; set; }
        [Column("vm2csSize3Colour15")]
        public double? Vm2csSize3Colour15 { get; set; }
        [Column("vm2csSize3Colour16")]
        public double? Vm2csSize3Colour16 { get; set; }
        [Column("vm2csSize3Colour17")]
        public double? Vm2csSize3Colour17 { get; set; }
        [Column("vm2csSize3Colour18")]
        public double? Vm2csSize3Colour18 { get; set; }
        [Column("vm2csSize3Colour19")]
        public double? Vm2csSize3Colour19 { get; set; }
        [Column("vm2csSize3Colour20")]
        public double? Vm2csSize3Colour20 { get; set; }
        [Column("vm2csSize3Colour21")]
        public double? Vm2csSize3Colour21 { get; set; }
        [Column("vm2csSize3Colour22")]
        public double? Vm2csSize3Colour22 { get; set; }
        [Column("vm2csSize3Colour23")]
        public double? Vm2csSize3Colour23 { get; set; }
        [Column("vm2csSize3Colour24")]
        public double? Vm2csSize3Colour24 { get; set; }
        [Column("vm2csSize4Colour1")]
        public double? Vm2csSize4Colour1 { get; set; }
        [Column("vm2csSize4Colour2")]
        public double? Vm2csSize4Colour2 { get; set; }
        [Column("vm2csSize4Colour3")]
        public double? Vm2csSize4Colour3 { get; set; }
        [Column("vm2csSize4Colour4")]
        public double? Vm2csSize4Colour4 { get; set; }
        [Column("vm2csSize4Colour5")]
        public double? Vm2csSize4Colour5 { get; set; }
        [Column("vm2csSize4Colour6")]
        public double? Vm2csSize4Colour6 { get; set; }
        [Column("vm2csSize4Colour7")]
        public double? Vm2csSize4Colour7 { get; set; }
        [Column("vm2csSize4Colour8")]
        public double? Vm2csSize4Colour8 { get; set; }
        [Column("vm2csSize4Colour9")]
        public double? Vm2csSize4Colour9 { get; set; }
        [Column("vm2csSize4Colour10")]
        public double? Vm2csSize4Colour10 { get; set; }
        [Column("vm2csSize4Colour11")]
        public double? Vm2csSize4Colour11 { get; set; }
        [Column("vm2csSize4Colour12")]
        public double? Vm2csSize4Colour12 { get; set; }
        [Column("vm2csSize4Colour13")]
        public double? Vm2csSize4Colour13 { get; set; }
        [Column("vm2csSize4Colour14")]
        public double? Vm2csSize4Colour14 { get; set; }
        [Column("vm2csSize4Colour15")]
        public double? Vm2csSize4Colour15 { get; set; }
        [Column("vm2csSize4Colour16")]
        public double? Vm2csSize4Colour16 { get; set; }
        [Column("vm2csSize4Colour17")]
        public double? Vm2csSize4Colour17 { get; set; }
        [Column("vm2csSize4Colour18")]
        public double? Vm2csSize4Colour18 { get; set; }
        [Column("vm2csSize4Colour19")]
        public double? Vm2csSize4Colour19 { get; set; }
        [Column("vm2csSize4Colour20")]
        public double? Vm2csSize4Colour20 { get; set; }
        [Column("vm2csSize4Colour21")]
        public double? Vm2csSize4Colour21 { get; set; }
        [Column("vm2csSize4Colour22")]
        public double? Vm2csSize4Colour22 { get; set; }
        [Column("vm2csSize4Colour23")]
        public double? Vm2csSize4Colour23 { get; set; }
        [Column("vm2csSize4Colour24")]
        public double? Vm2csSize4Colour24 { get; set; }
        [Column("vm2csSize5Colour1")]
        public double? Vm2csSize5Colour1 { get; set; }
        [Column("vm2csSize5Colour2")]
        public double? Vm2csSize5Colour2 { get; set; }
        [Column("vm2csSize5Colour3")]
        public double? Vm2csSize5Colour3 { get; set; }
        [Column("vm2csSize5Colour4")]
        public double? Vm2csSize5Colour4 { get; set; }
        [Column("vm2csSize5Colour5")]
        public double? Vm2csSize5Colour5 { get; set; }
        [Column("vm2csSize5Colour6")]
        public double? Vm2csSize5Colour6 { get; set; }
        [Column("vm2csSize5Colour7")]
        public double? Vm2csSize5Colour7 { get; set; }
        [Column("vm2csSize5Colour8")]
        public double? Vm2csSize5Colour8 { get; set; }
        [Column("vm2csSize5Colour9")]
        public double? Vm2csSize5Colour9 { get; set; }
        [Column("vm2csSize5Colour10")]
        public double? Vm2csSize5Colour10 { get; set; }
        [Column("vm2csSize5Colour11")]
        public double? Vm2csSize5Colour11 { get; set; }
        [Column("vm2csSize5Colour12")]
        public double? Vm2csSize5Colour12 { get; set; }
        [Column("vm2csSize5Colour13")]
        public double? Vm2csSize5Colour13 { get; set; }
        [Column("vm2csSize5Colour14")]
        public double? Vm2csSize5Colour14 { get; set; }
        [Column("vm2csSize5Colour15")]
        public double? Vm2csSize5Colour15 { get; set; }
        [Column("vm2csSize5Colour16")]
        public double? Vm2csSize5Colour16 { get; set; }
        [Column("vm2csSize5Colour17")]
        public double? Vm2csSize5Colour17 { get; set; }
        [Column("vm2csSize5Colour18")]
        public double? Vm2csSize5Colour18 { get; set; }
        [Column("vm2csSize5Colour19")]
        public double? Vm2csSize5Colour19 { get; set; }
        [Column("vm2csSize5Colour20")]
        public double? Vm2csSize5Colour20 { get; set; }
        [Column("vm2csSize5Colour21")]
        public double? Vm2csSize5Colour21 { get; set; }
        [Column("vm2csSize5Colour22")]
        public double? Vm2csSize5Colour22 { get; set; }
        [Column("vm2csSize5Colour23")]
        public double? Vm2csSize5Colour23 { get; set; }
        [Column("vm2csSize5Colour24")]
        public double? Vm2csSize5Colour24 { get; set; }
        [Column("vm2csSize6Colour1")]
        public double? Vm2csSize6Colour1 { get; set; }
        [Column("vm2csSize6Colour2")]
        public double? Vm2csSize6Colour2 { get; set; }
        [Column("vm2csSize6Colour3")]
        public double? Vm2csSize6Colour3 { get; set; }
        [Column("vm2csSize6Colour4")]
        public double? Vm2csSize6Colour4 { get; set; }
        [Column("vm2csSize6Colour5")]
        public double? Vm2csSize6Colour5 { get; set; }
        [Column("vm2csSize6Colour6")]
        public double? Vm2csSize6Colour6 { get; set; }
        [Column("vm2csSize6Colour7")]
        public double? Vm2csSize6Colour7 { get; set; }
        [Column("vm2csSize6Colour8")]
        public double? Vm2csSize6Colour8 { get; set; }
        [Column("vm2csSize6Colour9")]
        public double? Vm2csSize6Colour9 { get; set; }
        [Column("vm2csSize6Colour10")]
        public double? Vm2csSize6Colour10 { get; set; }
        [Column("vm2csSize6Colour11")]
        public double? Vm2csSize6Colour11 { get; set; }
        [Column("vm2csSize6Colour12")]
        public double? Vm2csSize6Colour12 { get; set; }
        [Column("vm2csSize6Colour13")]
        public double? Vm2csSize6Colour13 { get; set; }
        [Column("vm2csSize6Colour14")]
        public double? Vm2csSize6Colour14 { get; set; }
        [Column("vm2csSize6Colour15")]
        public double? Vm2csSize6Colour15 { get; set; }
        [Column("vm2csSize6Colour16")]
        public double? Vm2csSize6Colour16 { get; set; }
        [Column("vm2csSize6Colour17")]
        public double? Vm2csSize6Colour17 { get; set; }
        [Column("vm2csSize6Colour18")]
        public double? Vm2csSize6Colour18 { get; set; }
        [Column("vm2csSize6Colour19")]
        public double? Vm2csSize6Colour19 { get; set; }
        [Column("vm2csSize6Colour20")]
        public double? Vm2csSize6Colour20 { get; set; }
        [Column("vm2csSize6Colour21")]
        public double? Vm2csSize6Colour21 { get; set; }
        [Column("vm2csSize6Colour22")]
        public double? Vm2csSize6Colour22 { get; set; }
        [Column("vm2csSize6Colour23")]
        public double? Vm2csSize6Colour23 { get; set; }
        [Column("vm2csSize6Colour24")]
        public double? Vm2csSize6Colour24 { get; set; }
        [Column("vm2csSize7Colour1")]
        public double? Vm2csSize7Colour1 { get; set; }
        [Column("vm2csSize7Colour2")]
        public double? Vm2csSize7Colour2 { get; set; }
        [Column("vm2csSize7Colour3")]
        public double? Vm2csSize7Colour3 { get; set; }
        [Column("vm2csSize7Colour4")]
        public double? Vm2csSize7Colour4 { get; set; }
        [Column("vm2csSize7Colour5")]
        public double? Vm2csSize7Colour5 { get; set; }
        [Column("vm2csSize7Colour6")]
        public double? Vm2csSize7Colour6 { get; set; }
        [Column("vm2csSize7Colour7")]
        public double? Vm2csSize7Colour7 { get; set; }
        [Column("vm2csSize7Colour8")]
        public double? Vm2csSize7Colour8 { get; set; }
        [Column("vm2csSize7Colour9")]
        public double? Vm2csSize7Colour9 { get; set; }
        [Column("vm2csSize7Colour10")]
        public double? Vm2csSize7Colour10 { get; set; }
        [Column("vm2csSize7Colour11")]
        public double? Vm2csSize7Colour11 { get; set; }
        [Column("vm2csSize7Colour12")]
        public double? Vm2csSize7Colour12 { get; set; }
        [Column("vm2csSize7Colour13")]
        public double? Vm2csSize7Colour13 { get; set; }
        [Column("vm2csSize7Colour14")]
        public double? Vm2csSize7Colour14 { get; set; }
        [Column("vm2csSize7Colour15")]
        public double? Vm2csSize7Colour15 { get; set; }
        [Column("vm2csSize7Colour16")]
        public double? Vm2csSize7Colour16 { get; set; }
        [Column("vm2csSize7Colour17")]
        public double? Vm2csSize7Colour17 { get; set; }
        [Column("vm2csSize7Colour18")]
        public double? Vm2csSize7Colour18 { get; set; }
        [Column("vm2csSize7Colour19")]
        public double? Vm2csSize7Colour19 { get; set; }
        [Column("vm2csSize7Colour20")]
        public double? Vm2csSize7Colour20 { get; set; }
        [Column("vm2csSize7Colour21")]
        public double? Vm2csSize7Colour21 { get; set; }
        [Column("vm2csSize7Colour22")]
        public double? Vm2csSize7Colour22 { get; set; }
        [Column("vm2csSize7Colour23")]
        public double? Vm2csSize7Colour23 { get; set; }
        [Column("vm2csSize7Colour24")]
        public double? Vm2csSize7Colour24 { get; set; }
        [Column("vm2csSize8Colour1")]
        public double? Vm2csSize8Colour1 { get; set; }
        [Column("vm2csSize8Colour2")]
        public double? Vm2csSize8Colour2 { get; set; }
        [Column("vm2csSize8Colour3")]
        public double? Vm2csSize8Colour3 { get; set; }
        [Column("vm2csSize8Colour4")]
        public double? Vm2csSize8Colour4 { get; set; }
        [Column("vm2csSize8Colour5")]
        public double? Vm2csSize8Colour5 { get; set; }
        [Column("vm2csSize8Colour6")]
        public double? Vm2csSize8Colour6 { get; set; }
        [Column("vm2csSize8Colour7")]
        public double? Vm2csSize8Colour7 { get; set; }
        [Column("vm2csSize8Colour8")]
        public double? Vm2csSize8Colour8 { get; set; }
        [Column("vm2csSize8Colour9")]
        public double? Vm2csSize8Colour9 { get; set; }
        [Column("vm2csSize8Colour10")]
        public double? Vm2csSize8Colour10 { get; set; }
        [Column("vm2csSize8Colour11")]
        public double? Vm2csSize8Colour11 { get; set; }
        [Column("vm2csSize8Colour12")]
        public double? Vm2csSize8Colour12 { get; set; }
        [Column("vm2csSize8Colour13")]
        public double? Vm2csSize8Colour13 { get; set; }
        [Column("vm2csSize8Colour14")]
        public double? Vm2csSize8Colour14 { get; set; }
        [Column("vm2csSize8Colour15")]
        public double? Vm2csSize8Colour15 { get; set; }
        [Column("vm2csSize8Colour16")]
        public double? Vm2csSize8Colour16 { get; set; }
        [Column("vm2csSize8Colour17")]
        public double? Vm2csSize8Colour17 { get; set; }
        [Column("vm2csSize8Colour18")]
        public double? Vm2csSize8Colour18 { get; set; }
        [Column("vm2csSize8Colour19")]
        public double? Vm2csSize8Colour19 { get; set; }
        [Column("vm2csSize8Colour20")]
        public double? Vm2csSize8Colour20 { get; set; }
        [Column("vm2csSize8Colour21")]
        public double? Vm2csSize8Colour21 { get; set; }
        [Column("vm2csSize8Colour22")]
        public double? Vm2csSize8Colour22 { get; set; }
        [Column("vm2csSize8Colour23")]
        public double? Vm2csSize8Colour23 { get; set; }
        [Column("vm2csSize8Colour24")]
        public double? Vm2csSize8Colour24 { get; set; }
        [Column("vm2csSize9Colour1")]
        public double? Vm2csSize9Colour1 { get; set; }
        [Column("vm2csSize9Colour2")]
        public double? Vm2csSize9Colour2 { get; set; }
        [Column("vm2csSize9Colour3")]
        public double? Vm2csSize9Colour3 { get; set; }
        [Column("vm2csSize9Colour4")]
        public double? Vm2csSize9Colour4 { get; set; }
        [Column("vm2csSize9Colour5")]
        public double? Vm2csSize9Colour5 { get; set; }
        [Column("vm2csSize9Colour6")]
        public double? Vm2csSize9Colour6 { get; set; }
        [Column("vm2csSize9Colour7")]
        public double? Vm2csSize9Colour7 { get; set; }
        [Column("vm2csSize9Colour8")]
        public double? Vm2csSize9Colour8 { get; set; }
        [Column("vm2csSize9Colour9")]
        public double? Vm2csSize9Colour9 { get; set; }
        [Column("vm2csSize9Colour10")]
        public double? Vm2csSize9Colour10 { get; set; }
        [Column("vm2csSize9Colour11")]
        public double? Vm2csSize9Colour11 { get; set; }
        [Column("vm2csSize9Colour12")]
        public double? Vm2csSize9Colour12 { get; set; }
        [Column("vm2csSize9Colour13")]
        public double? Vm2csSize9Colour13 { get; set; }
        [Column("vm2csSize9Colour14")]
        public double? Vm2csSize9Colour14 { get; set; }
        [Column("vm2csSize9Colour15")]
        public double? Vm2csSize9Colour15 { get; set; }
        [Column("vm2csSize9Colour16")]
        public double? Vm2csSize9Colour16 { get; set; }
        [Column("vm2csSize9Colour17")]
        public double? Vm2csSize9Colour17 { get; set; }
        [Column("vm2csSize9Colour18")]
        public double? Vm2csSize9Colour18 { get; set; }
        [Column("vm2csSize9Colour19")]
        public double? Vm2csSize9Colour19 { get; set; }
        [Column("vm2csSize9Colour20")]
        public double? Vm2csSize9Colour20 { get; set; }
        [Column("vm2csSize9Colour21")]
        public double? Vm2csSize9Colour21 { get; set; }
        [Column("vm2csSize9Colour22")]
        public double? Vm2csSize9Colour22 { get; set; }
        [Column("vm2csSize9Colour23")]
        public double? Vm2csSize9Colour23 { get; set; }
        [Column("vm2csSize9Colour24")]
        public double? Vm2csSize9Colour24 { get; set; }
        [Column("vm2csSize10Colour1")]
        public double? Vm2csSize10Colour1 { get; set; }
        [Column("vm2csSize10Colour2")]
        public double? Vm2csSize10Colour2 { get; set; }
        [Column("vm2csSize10Colour3")]
        public double? Vm2csSize10Colour3 { get; set; }
        [Column("vm2csSize10Colour4")]
        public double? Vm2csSize10Colour4 { get; set; }
        [Column("vm2csSize10Colour5")]
        public double? Vm2csSize10Colour5 { get; set; }
        [Column("vm2csSize10Colour6")]
        public double? Vm2csSize10Colour6 { get; set; }
        [Column("vm2csSize10Colour7")]
        public double? Vm2csSize10Colour7 { get; set; }
        [Column("vm2csSize10Colour8")]
        public double? Vm2csSize10Colour8 { get; set; }
        [Column("vm2csSize10Colour9")]
        public double? Vm2csSize10Colour9 { get; set; }
        [Column("vm2csSize10Colour10")]
        public double? Vm2csSize10Colour10 { get; set; }
        [Column("vm2csSize10Colour11")]
        public double? Vm2csSize10Colour11 { get; set; }
        [Column("vm2csSize10Colour12")]
        public double? Vm2csSize10Colour12 { get; set; }
        [Column("vm2csSize10Colour13")]
        public double? Vm2csSize10Colour13 { get; set; }
        [Column("vm2csSize10Colour14")]
        public double? Vm2csSize10Colour14 { get; set; }
        [Column("vm2csSize10Colour15")]
        public double? Vm2csSize10Colour15 { get; set; }
        [Column("vm2csSize10Colour16")]
        public double? Vm2csSize10Colour16 { get; set; }
        [Column("vm2csSize10Colour17")]
        public double? Vm2csSize10Colour17 { get; set; }
        [Column("vm2csSize10Colour18")]
        public double? Vm2csSize10Colour18 { get; set; }
        [Column("vm2csSize10Colour19")]
        public double? Vm2csSize10Colour19 { get; set; }
        [Column("vm2csSize10Colour20")]
        public double? Vm2csSize10Colour20 { get; set; }
        [Column("vm2csSize10Colour21")]
        public double? Vm2csSize10Colour21 { get; set; }
        [Column("vm2csSize10Colour22")]
        public double? Vm2csSize10Colour22 { get; set; }
        [Column("vm2csSize10Colour23")]
        public double? Vm2csSize10Colour23 { get; set; }
        [Column("vm2csSize10Colour24")]
        public double? Vm2csSize10Colour24 { get; set; }
        [Column("vm2csSize11Colour1")]
        public double? Vm2csSize11Colour1 { get; set; }
        [Column("vm2csSize11Colour2")]
        public double? Vm2csSize11Colour2 { get; set; }
        [Column("vm2csSize11Colour3")]
        public double? Vm2csSize11Colour3 { get; set; }
        [Column("vm2csSize11Colour4")]
        public double? Vm2csSize11Colour4 { get; set; }
        [Column("vm2csSize11Colour5")]
        public double? Vm2csSize11Colour5 { get; set; }
        [Column("vm2csSize11Colour6")]
        public double? Vm2csSize11Colour6 { get; set; }
        [Column("vm2csSize11Colour7")]
        public double? Vm2csSize11Colour7 { get; set; }
        [Column("vm2csSize11Colour8")]
        public double? Vm2csSize11Colour8 { get; set; }
        [Column("vm2csSize11Colour9")]
        public double? Vm2csSize11Colour9 { get; set; }
        [Column("vm2csSize11Colour10")]
        public double? Vm2csSize11Colour10 { get; set; }
        [Column("vm2csSize11Colour11")]
        public double? Vm2csSize11Colour11 { get; set; }
        [Column("vm2csSize11Colour12")]
        public double? Vm2csSize11Colour12 { get; set; }
        [Column("vm2csSize11Colour13")]
        public double? Vm2csSize11Colour13 { get; set; }
        [Column("vm2csSize11Colour14")]
        public double? Vm2csSize11Colour14 { get; set; }
        [Column("vm2csSize11Colour15")]
        public double? Vm2csSize11Colour15 { get; set; }
        [Column("vm2csSize11Colour16")]
        public double? Vm2csSize11Colour16 { get; set; }
        [Column("vm2csSize11Colour17")]
        public double? Vm2csSize11Colour17 { get; set; }
        [Column("vm2csSize11Colour18")]
        public double? Vm2csSize11Colour18 { get; set; }
        [Column("vm2csSize11Colour19")]
        public double? Vm2csSize11Colour19 { get; set; }
        [Column("vm2csSize11Colour20")]
        public double? Vm2csSize11Colour20 { get; set; }
        [Column("vm2csSize11Colour21")]
        public double? Vm2csSize11Colour21 { get; set; }
        [Column("vm2csSize11Colour22")]
        public double? Vm2csSize11Colour22 { get; set; }
        [Column("vm2csSize11Colour23")]
        public double? Vm2csSize11Colour23 { get; set; }
        [Column("vm2csSize11Colour24")]
        public double? Vm2csSize11Colour24 { get; set; }
        [Column("vm2csSize12Colour1")]
        public double? Vm2csSize12Colour1 { get; set; }
        [Column("vm2csSize12Colour2")]
        public double? Vm2csSize12Colour2 { get; set; }
        [Column("vm2csSize12Colour3")]
        public double? Vm2csSize12Colour3 { get; set; }
        [Column("vm2csSize12Colour4")]
        public double? Vm2csSize12Colour4 { get; set; }
        [Column("vm2csSize12Colour5")]
        public double? Vm2csSize12Colour5 { get; set; }
        [Column("vm2csSize12Colour6")]
        public double? Vm2csSize12Colour6 { get; set; }
        [Column("vm2csSize12Colour7")]
        public double? Vm2csSize12Colour7 { get; set; }
        [Column("vm2csSize12Colour8")]
        public double? Vm2csSize12Colour8 { get; set; }
        [Column("vm2csSize12Colour9")]
        public double? Vm2csSize12Colour9 { get; set; }
        [Column("vm2csSize12Colour10")]
        public double? Vm2csSize12Colour10 { get; set; }
        [Column("vm2csSize12Colour11")]
        public double? Vm2csSize12Colour11 { get; set; }
        [Column("vm2csSize12Colour12")]
        public double? Vm2csSize12Colour12 { get; set; }
        [Column("vm2csSize12Colour13")]
        public double? Vm2csSize12Colour13 { get; set; }
        [Column("vm2csSize12Colour14")]
        public double? Vm2csSize12Colour14 { get; set; }
        [Column("vm2csSize12Colour15")]
        public double? Vm2csSize12Colour15 { get; set; }
        [Column("vm2csSize12Colour16")]
        public double? Vm2csSize12Colour16 { get; set; }
        [Column("vm2csSize12Colour17")]
        public double? Vm2csSize12Colour17 { get; set; }
        [Column("vm2csSize12Colour18")]
        public double? Vm2csSize12Colour18 { get; set; }
        [Column("vm2csSize12Colour19")]
        public double? Vm2csSize12Colour19 { get; set; }
        [Column("vm2csSize12Colour20")]
        public double? Vm2csSize12Colour20 { get; set; }
        [Column("vm2csSize12Colour21")]
        public double? Vm2csSize12Colour21 { get; set; }
        [Column("vm2csSize12Colour22")]
        public double? Vm2csSize12Colour22 { get; set; }
        [Column("vm2csSize12Colour23")]
        public double? Vm2csSize12Colour23 { get; set; }
        [Column("vm2csSize12Colour24")]
        public double? Vm2csSize12Colour24 { get; set; }
        [Column("vm2csSize13Colour1")]
        public double? Vm2csSize13Colour1 { get; set; }
        [Column("vm2csSize13Colour2")]
        public double? Vm2csSize13Colour2 { get; set; }
        [Column("vm2csSize13Colour3")]
        public double? Vm2csSize13Colour3 { get; set; }
        [Column("vm2csSize13Colour4")]
        public double? Vm2csSize13Colour4 { get; set; }
        [Column("vm2csSize13Colour5")]
        public double? Vm2csSize13Colour5 { get; set; }
        [Column("vm2csSize13Colour6")]
        public double? Vm2csSize13Colour6 { get; set; }
        [Column("vm2csSize13Colour7")]
        public double? Vm2csSize13Colour7 { get; set; }
        [Column("vm2csSize13Colour8")]
        public double? Vm2csSize13Colour8 { get; set; }
        [Column("vm2csSize13Colour9")]
        public double? Vm2csSize13Colour9 { get; set; }
        [Column("vm2csSize13Colour10")]
        public double? Vm2csSize13Colour10 { get; set; }
        [Column("vm2csSize13Colour11")]
        public double? Vm2csSize13Colour11 { get; set; }
        [Column("vm2csSize13Colour12")]
        public double? Vm2csSize13Colour12 { get; set; }
        [Column("vm2csSize13Colour13")]
        public double? Vm2csSize13Colour13 { get; set; }
        [Column("vm2csSize13Colour14")]
        public double? Vm2csSize13Colour14 { get; set; }
        [Column("vm2csSize13Colour15")]
        public double? Vm2csSize13Colour15 { get; set; }
        [Column("vm2csSize13Colour16")]
        public double? Vm2csSize13Colour16 { get; set; }
        [Column("vm2csSize13Colour17")]
        public double? Vm2csSize13Colour17 { get; set; }
        [Column("vm2csSize13Colour18")]
        public double? Vm2csSize13Colour18 { get; set; }
        [Column("vm2csSize13Colour19")]
        public double? Vm2csSize13Colour19 { get; set; }
        [Column("vm2csSize13Colour20")]
        public double? Vm2csSize13Colour20 { get; set; }
        [Column("vm2csSize13Colour21")]
        public double? Vm2csSize13Colour21 { get; set; }
        [Column("vm2csSize13Colour22")]
        public double? Vm2csSize13Colour22 { get; set; }
        [Column("vm2csSize13Colour23")]
        public double? Vm2csSize13Colour23 { get; set; }
        [Column("vm2csSize13Colour24")]
        public double? Vm2csSize13Colour24 { get; set; }
        [Column("vm2csSize14Colour1")]
        public double? Vm2csSize14Colour1 { get; set; }
        [Column("vm2csSize14Colour2")]
        public double? Vm2csSize14Colour2 { get; set; }
        [Column("vm2csSize14Colour3")]
        public double? Vm2csSize14Colour3 { get; set; }
        [Column("vm2csSize14Colour4")]
        public double? Vm2csSize14Colour4 { get; set; }
        [Column("vm2csSize14Colour5")]
        public double? Vm2csSize14Colour5 { get; set; }
        [Column("vm2csSize14Colour6")]
        public double? Vm2csSize14Colour6 { get; set; }
        [Column("vm2csSize14Colour7")]
        public double? Vm2csSize14Colour7 { get; set; }
        [Column("vm2csSize14Colour8")]
        public double? Vm2csSize14Colour8 { get; set; }
        [Column("vm2csSize14Colour9")]
        public double? Vm2csSize14Colour9 { get; set; }
        [Column("vm2csSize14Colour10")]
        public double? Vm2csSize14Colour10 { get; set; }
        [Column("vm2csSize14Colour11")]
        public double? Vm2csSize14Colour11 { get; set; }
        [Column("vm2csSize14Colour12")]
        public double? Vm2csSize14Colour12 { get; set; }
        [Column("vm2csSize14Colour13")]
        public double? Vm2csSize14Colour13 { get; set; }
        [Column("vm2csSize14Colour14")]
        public double? Vm2csSize14Colour14 { get; set; }
        [Column("vm2csSize14Colour15")]
        public double? Vm2csSize14Colour15 { get; set; }
        [Column("vm2csSize14Colour16")]
        public double? Vm2csSize14Colour16 { get; set; }
        [Column("vm2csSize14Colour17")]
        public double? Vm2csSize14Colour17 { get; set; }
        [Column("vm2csSize14Colour18")]
        public double? Vm2csSize14Colour18 { get; set; }
        [Column("vm2csSize14Colour19")]
        public double? Vm2csSize14Colour19 { get; set; }
        [Column("vm2csSize14Colour20")]
        public double? Vm2csSize14Colour20 { get; set; }
        [Column("vm2csSize14Colour21")]
        public double? Vm2csSize14Colour21 { get; set; }
        [Column("vm2csSize14Colour22")]
        public double? Vm2csSize14Colour22 { get; set; }
        [Column("vm2csSize14Colour23")]
        public double? Vm2csSize14Colour23 { get; set; }
        [Column("vm2csSize14Colour24")]
        public double? Vm2csSize14Colour24 { get; set; }
        [Column("vm2csSize15Colour1")]
        public double? Vm2csSize15Colour1 { get; set; }
        [Column("vm2csSize15Colour2")]
        public double? Vm2csSize15Colour2 { get; set; }
        [Column("vm2csSize15Colour3")]
        public double? Vm2csSize15Colour3 { get; set; }
        [Column("vm2csSize15Colour4")]
        public double? Vm2csSize15Colour4 { get; set; }
        [Column("vm2csSize15Colour5")]
        public double? Vm2csSize15Colour5 { get; set; }
        [Column("vm2csSize15Colour6")]
        public double? Vm2csSize15Colour6 { get; set; }
        [Column("vm2csSize15Colour7")]
        public double? Vm2csSize15Colour7 { get; set; }
        [Column("vm2csSize15Colour8")]
        public double? Vm2csSize15Colour8 { get; set; }
        [Column("vm2csSize15Colour9")]
        public double? Vm2csSize15Colour9 { get; set; }
        [Column("vm2csSize15Colour10")]
        public double? Vm2csSize15Colour10 { get; set; }
        [Column("vm2csSize15Colour11")]
        public double? Vm2csSize15Colour11 { get; set; }
        [Column("vm2csSize15Colour12")]
        public double? Vm2csSize15Colour12 { get; set; }
        [Column("vm2csSize15Colour13")]
        public double? Vm2csSize15Colour13 { get; set; }
        [Column("vm2csSize15Colour14")]
        public double? Vm2csSize15Colour14 { get; set; }
        [Column("vm2csSize15Colour15")]
        public double? Vm2csSize15Colour15 { get; set; }
        [Column("vm2csSize15Colour16")]
        public double? Vm2csSize15Colour16 { get; set; }
        [Column("vm2csSize15Colour17")]
        public double? Vm2csSize15Colour17 { get; set; }
        [Column("vm2csSize15Colour18")]
        public double? Vm2csSize15Colour18 { get; set; }
        [Column("vm2csSize15Colour19")]
        public double? Vm2csSize15Colour19 { get; set; }
        [Column("vm2csSize15Colour20")]
        public double? Vm2csSize15Colour20 { get; set; }
        [Column("vm2csSize15Colour21")]
        public double? Vm2csSize15Colour21 { get; set; }
        [Column("vm2csSize15Colour22")]
        public double? Vm2csSize15Colour22 { get; set; }
        [Column("vm2csSize15Colour23")]
        public double? Vm2csSize15Colour23 { get; set; }
        [Column("vm2csSize15Colour24")]
        public double? Vm2csSize15Colour24 { get; set; }
        [Column("vm2csSize16Colour1")]
        public double? Vm2csSize16Colour1 { get; set; }
        [Column("vm2csSize16Colour2")]
        public double? Vm2csSize16Colour2 { get; set; }
        [Column("vm2csSize16Colour3")]
        public double? Vm2csSize16Colour3 { get; set; }
        [Column("vm2csSize16Colour4")]
        public double? Vm2csSize16Colour4 { get; set; }
        [Column("vm2csSize16Colour5")]
        public double? Vm2csSize16Colour5 { get; set; }
        [Column("vm2csSize16Colour6")]
        public double? Vm2csSize16Colour6 { get; set; }
        [Column("vm2csSize16Colour7")]
        public double? Vm2csSize16Colour7 { get; set; }
        [Column("vm2csSize16Colour8")]
        public double? Vm2csSize16Colour8 { get; set; }
        [Column("vm2csSize16Colour9")]
        public double? Vm2csSize16Colour9 { get; set; }
        [Column("vm2csSize16Colour10")]
        public double? Vm2csSize16Colour10 { get; set; }
        [Column("vm2csSize16Colour11")]
        public double? Vm2csSize16Colour11 { get; set; }
        [Column("vm2csSize16Colour12")]
        public double? Vm2csSize16Colour12 { get; set; }
        [Column("vm2csSize16Colour13")]
        public double? Vm2csSize16Colour13 { get; set; }
        [Column("vm2csSize16Colour14")]
        public double? Vm2csSize16Colour14 { get; set; }
        [Column("vm2csSize16Colour15")]
        public double? Vm2csSize16Colour15 { get; set; }
        [Column("vm2csSize16Colour16")]
        public double? Vm2csSize16Colour16 { get; set; }
        [Column("vm2csSize16Colour17")]
        public double? Vm2csSize16Colour17 { get; set; }
        [Column("vm2csSize16Colour18")]
        public double? Vm2csSize16Colour18 { get; set; }
        [Column("vm2csSize16Colour19")]
        public double? Vm2csSize16Colour19 { get; set; }
        [Column("vm2csSize16Colour20")]
        public double? Vm2csSize16Colour20 { get; set; }
        [Column("vm2csSize16Colour21")]
        public double? Vm2csSize16Colour21 { get; set; }
        [Column("vm2csSize16Colour22")]
        public double? Vm2csSize16Colour22 { get; set; }
        [Column("vm2csSize16Colour23")]
        public double? Vm2csSize16Colour23 { get; set; }
        [Column("vm2csSize16Colour24")]
        public double? Vm2csSize16Colour24 { get; set; }
        [Column("vm2csSize17Colour1")]
        public double? Vm2csSize17Colour1 { get; set; }
        [Column("vm2csSize17Colour2")]
        public double? Vm2csSize17Colour2 { get; set; }
        [Column("vm2csSize17Colour3")]
        public double? Vm2csSize17Colour3 { get; set; }
        [Column("vm2csSize17Colour4")]
        public double? Vm2csSize17Colour4 { get; set; }
        [Column("vm2csSize17Colour5")]
        public double? Vm2csSize17Colour5 { get; set; }
        [Column("vm2csSize17Colour6")]
        public double? Vm2csSize17Colour6 { get; set; }
        [Column("vm2csSize17Colour7")]
        public double? Vm2csSize17Colour7 { get; set; }
        [Column("vm2csSize17Colour8")]
        public double? Vm2csSize17Colour8 { get; set; }
        [Column("vm2csSize17Colour9")]
        public double? Vm2csSize17Colour9 { get; set; }
        [Column("vm2csSize17Colour10")]
        public double? Vm2csSize17Colour10 { get; set; }
        [Column("vm2csSize17Colour11")]
        public double? Vm2csSize17Colour11 { get; set; }
        [Column("vm2csSize17Colour12")]
        public double? Vm2csSize17Colour12 { get; set; }
        [Column("vm2csSize17Colour13")]
        public double? Vm2csSize17Colour13 { get; set; }
        [Column("vm2csSize17Colour14")]
        public double? Vm2csSize17Colour14 { get; set; }
        [Column("vm2csSize17Colour15")]
        public double? Vm2csSize17Colour15 { get; set; }
        [Column("vm2csSize17Colour16")]
        public double? Vm2csSize17Colour16 { get; set; }
        [Column("vm2csSize17Colour17")]
        public double? Vm2csSize17Colour17 { get; set; }
        [Column("vm2csSize17Colour18")]
        public double? Vm2csSize17Colour18 { get; set; }
        [Column("vm2csSize17Colour19")]
        public double? Vm2csSize17Colour19 { get; set; }
        [Column("vm2csSize17Colour20")]
        public double? Vm2csSize17Colour20 { get; set; }
        [Column("vm2csSize17Colour21")]
        public double? Vm2csSize17Colour21 { get; set; }
        [Column("vm2csSize17Colour22")]
        public double? Vm2csSize17Colour22 { get; set; }
        [Column("vm2csSize17Colour23")]
        public double? Vm2csSize17Colour23 { get; set; }
        [Column("vm2csSize17Colour24")]
        public double? Vm2csSize17Colour24 { get; set; }
        [Column("vm2csSize18Colour1")]
        public double? Vm2csSize18Colour1 { get; set; }
        [Column("vm2csSize18Colour2")]
        public double? Vm2csSize18Colour2 { get; set; }
        [Column("vm2csSize18Colour3")]
        public double? Vm2csSize18Colour3 { get; set; }
        [Column("vm2csSize18Colour4")]
        public double? Vm2csSize18Colour4 { get; set; }
        [Column("vm2csSize18Colour5")]
        public double? Vm2csSize18Colour5 { get; set; }
        [Column("vm2csSize18Colour6")]
        public double? Vm2csSize18Colour6 { get; set; }
        [Column("vm2csSize18Colour7")]
        public double? Vm2csSize18Colour7 { get; set; }
        [Column("vm2csSize18Colour8")]
        public double? Vm2csSize18Colour8 { get; set; }
        [Column("vm2csSize18Colour9")]
        public double? Vm2csSize18Colour9 { get; set; }
        [Column("vm2csSize18Colour10")]
        public double? Vm2csSize18Colour10 { get; set; }
        [Column("vm2csSize18Colour11")]
        public double? Vm2csSize18Colour11 { get; set; }
        [Column("vm2csSize18Colour12")]
        public double? Vm2csSize18Colour12 { get; set; }
        [Column("vm2csSize18Colour13")]
        public double? Vm2csSize18Colour13 { get; set; }
        [Column("vm2csSize18Colour14")]
        public double? Vm2csSize18Colour14 { get; set; }
        [Column("vm2csSize18Colour15")]
        public double? Vm2csSize18Colour15 { get; set; }
        [Column("vm2csSize18Colour16")]
        public double? Vm2csSize18Colour16 { get; set; }
        [Column("vm2csSize18Colour17")]
        public double? Vm2csSize18Colour17 { get; set; }
        [Column("vm2csSize18Colour18")]
        public double? Vm2csSize18Colour18 { get; set; }
        [Column("vm2csSize18Colour19")]
        public double? Vm2csSize18Colour19 { get; set; }
        [Column("vm2csSize18Colour20")]
        public double? Vm2csSize18Colour20 { get; set; }
        [Column("vm2csSize18Colour21")]
        public double? Vm2csSize18Colour21 { get; set; }
        [Column("vm2csSize18Colour22")]
        public double? Vm2csSize18Colour22 { get; set; }
        [Column("vm2csSize18Colour23")]
        public double? Vm2csSize18Colour23 { get; set; }
        [Column("vm2csSize18Colour24")]
        public double? Vm2csSize18Colour24 { get; set; }
        [Column("vm2csSize19Colour1")]
        public double? Vm2csSize19Colour1 { get; set; }
        [Column("vm2csSize19Colour2")]
        public double? Vm2csSize19Colour2 { get; set; }
        [Column("vm2csSize19Colour3")]
        public double? Vm2csSize19Colour3 { get; set; }
        [Column("vm2csSize19Colour4")]
        public double? Vm2csSize19Colour4 { get; set; }
        [Column("vm2csSize19Colour5")]
        public double? Vm2csSize19Colour5 { get; set; }
        [Column("vm2csSize19Colour6")]
        public double? Vm2csSize19Colour6 { get; set; }
        [Column("vm2csSize19Colour7")]
        public double? Vm2csSize19Colour7 { get; set; }
        [Column("vm2csSize19Colour8")]
        public double? Vm2csSize19Colour8 { get; set; }
        [Column("vm2csSize19Colour9")]
        public double? Vm2csSize19Colour9 { get; set; }
        [Column("vm2csSize19Colour10")]
        public double? Vm2csSize19Colour10 { get; set; }
        [Column("vm2csSize19Colour11")]
        public double? Vm2csSize19Colour11 { get; set; }
        [Column("vm2csSize19Colour12")]
        public double? Vm2csSize19Colour12 { get; set; }
        [Column("vm2csSize19Colour13")]
        public double? Vm2csSize19Colour13 { get; set; }
        [Column("vm2csSize19Colour14")]
        public double? Vm2csSize19Colour14 { get; set; }
        [Column("vm2csSize19Colour15")]
        public double? Vm2csSize19Colour15 { get; set; }
        [Column("vm2csSize19Colour16")]
        public double? Vm2csSize19Colour16 { get; set; }
        [Column("vm2csSize19Colour17")]
        public double? Vm2csSize19Colour17 { get; set; }
        [Column("vm2csSize19Colour18")]
        public double? Vm2csSize19Colour18 { get; set; }
        [Column("vm2csSize19Colour19")]
        public double? Vm2csSize19Colour19 { get; set; }
        [Column("vm2csSize19Colour20")]
        public double? Vm2csSize19Colour20 { get; set; }
        [Column("vm2csSize19Colour21")]
        public double? Vm2csSize19Colour21 { get; set; }
        [Column("vm2csSize19Colour22")]
        public double? Vm2csSize19Colour22 { get; set; }
        [Column("vm2csSize19Colour23")]
        public double? Vm2csSize19Colour23 { get; set; }
        [Column("vm2csSize19Colour24")]
        public double? Vm2csSize19Colour24 { get; set; }
        [Column("vm2csSize20Colour1")]
        public double? Vm2csSize20Colour1 { get; set; }
        [Column("vm2csSize20Colour2")]
        public double? Vm2csSize20Colour2 { get; set; }
        [Column("vm2csSize20Colour3")]
        public double? Vm2csSize20Colour3 { get; set; }
        [Column("vm2csSize20Colour4")]
        public double? Vm2csSize20Colour4 { get; set; }
        [Column("vm2csSize20Colour5")]
        public double? Vm2csSize20Colour5 { get; set; }
        [Column("vm2csSize20Colour6")]
        public double? Vm2csSize20Colour6 { get; set; }
        [Column("vm2csSize20Colour7")]
        public double? Vm2csSize20Colour7 { get; set; }
        [Column("vm2csSize20Colour8")]
        public double? Vm2csSize20Colour8 { get; set; }
        [Column("vm2csSize20Colour9")]
        public double? Vm2csSize20Colour9 { get; set; }
        [Column("vm2csSize20Colour10")]
        public double? Vm2csSize20Colour10 { get; set; }
        [Column("vm2csSize20Colour11")]
        public double? Vm2csSize20Colour11 { get; set; }
        [Column("vm2csSize20Colour12")]
        public double? Vm2csSize20Colour12 { get; set; }
        [Column("vm2csSize20Colour13")]
        public double? Vm2csSize20Colour13 { get; set; }
        [Column("vm2csSize20Colour14")]
        public double? Vm2csSize20Colour14 { get; set; }
        [Column("vm2csSize20Colour15")]
        public double? Vm2csSize20Colour15 { get; set; }
        [Column("vm2csSize20Colour16")]
        public double? Vm2csSize20Colour16 { get; set; }
        [Column("vm2csSize20Colour17")]
        public double? Vm2csSize20Colour17 { get; set; }
        [Column("vm2csSize20Colour18")]
        public double? Vm2csSize20Colour18 { get; set; }
        [Column("vm2csSize20Colour19")]
        public double? Vm2csSize20Colour19 { get; set; }
        [Column("vm2csSize20Colour20")]
        public double? Vm2csSize20Colour20 { get; set; }
        [Column("vm2csSize20Colour21")]
        public double? Vm2csSize20Colour21 { get; set; }
        [Column("vm2csSize20Colour22")]
        public double? Vm2csSize20Colour22 { get; set; }
        [Column("vm2csSize20Colour23")]
        public double? Vm2csSize20Colour23 { get; set; }
        [Column("vm2csSize20Colour24")]
        public double? Vm2csSize20Colour24 { get; set; }
    }
}
