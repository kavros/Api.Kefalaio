using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FISCALPRT")]
    public partial class Fiscalprt
    {
        [Key]
        [Column("fprFileId")]
        public int FprFileId { get; set; }
        [Column("fprDriver")]
        [StringLength(20)]
        public string FprDriver { get; set; }
        [Column("fprDescription")]
        [StringLength(20)]
        public string FprDescription { get; set; }
        [Column("fprDefault")]
        public short? FprDefault { get; set; }
        [Column("fprConPayWay")]
        public int? FprConPayWay { get; set; }
        [Column("fprPayWays1")]
        [StringLength(60)]
        public string FprPayWays1 { get; set; }
        [Column("fprPayWays2")]
        [StringLength(60)]
        public string FprPayWays2 { get; set; }
        [Column("fprPayWays3")]
        [StringLength(60)]
        public string FprPayWays3 { get; set; }
        [Column("fprPayWays4")]
        [StringLength(60)]
        public string FprPayWays4 { get; set; }
        [Column("fprMovePayWays1")]
        [StringLength(256)]
        public string FprMovePayWays1 { get; set; }
        [Column("fprMovePayWays2")]
        [StringLength(256)]
        public string FprMovePayWays2 { get; set; }
        [Column("fprMovePayWays3")]
        [StringLength(256)]
        public string FprMovePayWays3 { get; set; }
        [Column("fprMovePayWays4")]
        [StringLength(256)]
        public string FprMovePayWays4 { get; set; }
        [Column("fprHeadLines1")]
        [StringLength(40)]
        public string FprHeadLines1 { get; set; }
        [Column("fprHeadLines2")]
        [StringLength(40)]
        public string FprHeadLines2 { get; set; }
        [Column("fprHeadLines3")]
        [StringLength(40)]
        public string FprHeadLines3 { get; set; }
        [Column("fprHeadLines4")]
        [StringLength(40)]
        public string FprHeadLines4 { get; set; }
        [Column("fprHeadLines5")]
        [StringLength(40)]
        public string FprHeadLines5 { get; set; }
        [Column("fprHeadLines6")]
        [StringLength(40)]
        public string FprHeadLines6 { get; set; }
        [Column("fprHeadLines7")]
        [StringLength(40)]
        public string FprHeadLines7 { get; set; }
        [Column("fprHeadLines8")]
        [StringLength(40)]
        public string FprHeadLines8 { get; set; }
        [Column("fprFootLines1")]
        [StringLength(40)]
        public string FprFootLines1 { get; set; }
        [Column("fprFootLines2")]
        [StringLength(40)]
        public string FprFootLines2 { get; set; }
        [Column("fprFootLines3")]
        [StringLength(40)]
        public string FprFootLines3 { get; set; }
        [Column("fprFootLines4")]
        [StringLength(40)]
        public string FprFootLines4 { get; set; }
        [Column("fprFootLines5")]
        [StringLength(40)]
        public string FprFootLines5 { get; set; }
        [Column("fprComments1")]
        [StringLength(40)]
        public string FprComments1 { get; set; }
        [Column("fprComments2")]
        [StringLength(40)]
        public string FprComments2 { get; set; }
        [Column("fprComments3")]
        [StringLength(40)]
        public string FprComments3 { get; set; }
        [Column("fprComments4")]
        [StringLength(40)]
        public string FprComments4 { get; set; }
        [Column("fprComments5")]
        [StringLength(40)]
        public string FprComments5 { get; set; }
        [Column("fprScrollingMessage1")]
        [StringLength(100)]
        public string FprScrollingMessage1 { get; set; }
        [Column("fprScrollingMessage2")]
        [StringLength(100)]
        public string FprScrollingMessage2 { get; set; }
        [Column("fprVatRatesCodes1")]
        [StringLength(1)]
        public string FprVatRatesCodes1 { get; set; }
        [Column("fprVatRatesCodes2")]
        [StringLength(1)]
        public string FprVatRatesCodes2 { get; set; }
        [Column("fprVatRatesCodes3")]
        [StringLength(1)]
        public string FprVatRatesCodes3 { get; set; }
        [Column("fprVatRatesCodes4")]
        [StringLength(1)]
        public string FprVatRatesCodes4 { get; set; }
        [Column("fprVatRatesCodes5")]
        [StringLength(1)]
        public string FprVatRatesCodes5 { get; set; }
        [Column("fprVatRatesCodes6")]
        [StringLength(1)]
        public string FprVatRatesCodes6 { get; set; }
        [Column("fprVatRatesCodes7")]
        [StringLength(1)]
        public string FprVatRatesCodes7 { get; set; }
        [Column("fprVatRatesCodes8")]
        [StringLength(1)]
        public string FprVatRatesCodes8 { get; set; }
        [Column("fprVatRatesCodes9")]
        [StringLength(1)]
        public string FprVatRatesCodes9 { get; set; }
        [Column("fprVatRatesCodes10")]
        [StringLength(1)]
        public string FprVatRatesCodes10 { get; set; }
        [Column("fprVatRatesCodes11")]
        [StringLength(1)]
        public string FprVatRatesCodes11 { get; set; }
        [Column("fprVatRatesCodes12")]
        [StringLength(1)]
        public string FprVatRatesCodes12 { get; set; }
        [Column("fprVatRatesCodes13")]
        [StringLength(1)]
        public string FprVatRatesCodes13 { get; set; }
        [Column("fprVatRatesCodes14")]
        [StringLength(1)]
        public string FprVatRatesCodes14 { get; set; }
        [Column("fprVatRatesCodes15")]
        [StringLength(1)]
        public string FprVatRatesCodes15 { get; set; }
        [Column("fprVatRatesCodes16")]
        [StringLength(1)]
        public string FprVatRatesCodes16 { get; set; }
        [Column("fprVatRatesCodes17")]
        [StringLength(1)]
        public string FprVatRatesCodes17 { get; set; }
        [Column("fprVatRatesCodes18")]
        [StringLength(1)]
        public string FprVatRatesCodes18 { get; set; }
        [Column("fprVatRatesCodes19")]
        [StringLength(1)]
        public string FprVatRatesCodes19 { get; set; }
        [Column("fprVatRatesCodes20")]
        [StringLength(1)]
        public string FprVatRatesCodes20 { get; set; }
        [Column("fprVatRatesCodes21")]
        [StringLength(1)]
        public string FprVatRatesCodes21 { get; set; }
        [Column("fprVatRatesCodes22")]
        [StringLength(1)]
        public string FprVatRatesCodes22 { get; set; }
        [Column("fprVatRatesCodes23")]
        [StringLength(1)]
        public string FprVatRatesCodes23 { get; set; }
        [Column("fprVatRatesCodes24")]
        [StringLength(1)]
        public string FprVatRatesCodes24 { get; set; }
        [Column("fprVatRatesCodes25")]
        [StringLength(1)]
        public string FprVatRatesCodes25 { get; set; }
        [Column("fprVatRatesCodes26")]
        [StringLength(1)]
        public string FprVatRatesCodes26 { get; set; }
        [Column("fprVatRatesCodes27")]
        [StringLength(1)]
        public string FprVatRatesCodes27 { get; set; }
        [Column("fprVatRatesCodes28")]
        [StringLength(1)]
        public string FprVatRatesCodes28 { get; set; }
        [Column("fprVatRatesCodes29")]
        [StringLength(1)]
        public string FprVatRatesCodes29 { get; set; }
        [Column("fprVatRatesCodes30")]
        [StringLength(1)]
        public string FprVatRatesCodes30 { get; set; }
        [Column("fprVatRatesCodes31")]
        [StringLength(1)]
        public string FprVatRatesCodes31 { get; set; }
        [Column("fprVatRatesCodes32")]
        [StringLength(1)]
        public string FprVatRatesCodes32 { get; set; }
        [Column("fprVatRatesCodes33")]
        [StringLength(1)]
        public string FprVatRatesCodes33 { get; set; }
        [Column("fprVatRatesCodes34")]
        [StringLength(1)]
        public string FprVatRatesCodes34 { get; set; }
        [Column("fprVatRatesCodes35")]
        [StringLength(1)]
        public string FprVatRatesCodes35 { get; set; }
        [Column("fprVatRatesCodes36")]
        [StringLength(1)]
        public string FprVatRatesCodes36 { get; set; }
        [Column("fprVatRatesCodes37")]
        [StringLength(1)]
        public string FprVatRatesCodes37 { get; set; }
        [Column("fprVatRatesCodes38")]
        [StringLength(1)]
        public string FprVatRatesCodes38 { get; set; }
        [Column("fprVatRatesCodes39")]
        [StringLength(1)]
        public string FprVatRatesCodes39 { get; set; }
        [Column("fprVatRatesCodes40")]
        [StringLength(1)]
        public string FprVatRatesCodes40 { get; set; }
        [Column("fprVatRatesCodes41")]
        [StringLength(1)]
        public string FprVatRatesCodes41 { get; set; }
        [Column("fprVatRatesCodes42")]
        [StringLength(1)]
        public string FprVatRatesCodes42 { get; set; }
        [Column("fprVatRatesCodes43")]
        [StringLength(1)]
        public string FprVatRatesCodes43 { get; set; }
        [Column("fprVatRatesCodes44")]
        [StringLength(1)]
        public string FprVatRatesCodes44 { get; set; }
        [Column("fprVatRatesCodes45")]
        [StringLength(1)]
        public string FprVatRatesCodes45 { get; set; }
        [Column("fprVatRatesCodes46")]
        [StringLength(1)]
        public string FprVatRatesCodes46 { get; set; }
        [Column("fprVatRatesCodes47")]
        [StringLength(1)]
        public string FprVatRatesCodes47 { get; set; }
        [Column("fprVatRatesCodes48")]
        [StringLength(1)]
        public string FprVatRatesCodes48 { get; set; }
        [Column("fprVatRatesCodes49")]
        [StringLength(1)]
        public string FprVatRatesCodes49 { get; set; }
        [Column("fprVatRatesCodes50")]
        [StringLength(1)]
        public string FprVatRatesCodes50 { get; set; }
        [Column("fprVatRatesCodes51")]
        [StringLength(1)]
        public string FprVatRatesCodes51 { get; set; }
        [Column("fprVatRatesCodes52")]
        [StringLength(1)]
        public string FprVatRatesCodes52 { get; set; }
        [Column("fprVatRatesCodes53")]
        [StringLength(1)]
        public string FprVatRatesCodes53 { get; set; }
        [Column("fprVatRatesCodes54")]
        [StringLength(1)]
        public string FprVatRatesCodes54 { get; set; }
        [Column("fprVatRatesCodes55")]
        [StringLength(1)]
        public string FprVatRatesCodes55 { get; set; }
        [Column("fprVatRatesCodes56")]
        [StringLength(1)]
        public string FprVatRatesCodes56 { get; set; }
        [Column("fprVatRatesCodes57")]
        [StringLength(1)]
        public string FprVatRatesCodes57 { get; set; }
        [Column("fprVatRatesCodes58")]
        [StringLength(1)]
        public string FprVatRatesCodes58 { get; set; }
        [Column("fprVatRatesCodes59")]
        [StringLength(1)]
        public string FprVatRatesCodes59 { get; set; }
        [Column("fprVatRatesCodes60")]
        [StringLength(1)]
        public string FprVatRatesCodes60 { get; set; }
        [Column("fprVatRatesCodes61")]
        [StringLength(1)]
        public string FprVatRatesCodes61 { get; set; }
        [Column("fprVatRatesCodes62")]
        [StringLength(1)]
        public string FprVatRatesCodes62 { get; set; }
        [Column("fprVatRatesCodes63")]
        [StringLength(1)]
        public string FprVatRatesCodes63 { get; set; }
        [Column("fprVatRatesCodes64")]
        [StringLength(1)]
        public string FprVatRatesCodes64 { get; set; }
        [Column("fprVatRatesCodes65")]
        [StringLength(1)]
        public string FprVatRatesCodes65 { get; set; }
        [Column("fprVatRatesCodes66")]
        [StringLength(1)]
        public string FprVatRatesCodes66 { get; set; }
        [Column("fprVatRatesCodes67")]
        [StringLength(1)]
        public string FprVatRatesCodes67 { get; set; }
        [Column("fprVatRatesCodes68")]
        [StringLength(1)]
        public string FprVatRatesCodes68 { get; set; }
        [Column("fprVatRatesCodes69")]
        [StringLength(1)]
        public string FprVatRatesCodes69 { get; set; }
        [Column("fprVatRatesCodes70")]
        [StringLength(1)]
        public string FprVatRatesCodes70 { get; set; }
        [Column("fprVatRatesCodes71")]
        [StringLength(1)]
        public string FprVatRatesCodes71 { get; set; }
        [Column("fprVatRatesCodes72")]
        [StringLength(1)]
        public string FprVatRatesCodes72 { get; set; }
        [Column("fprVatRatesCodes73")]
        [StringLength(1)]
        public string FprVatRatesCodes73 { get; set; }
        [Column("fprVatRatesCodes74")]
        [StringLength(1)]
        public string FprVatRatesCodes74 { get; set; }
        [Column("fprVatRatesCodes75")]
        [StringLength(1)]
        public string FprVatRatesCodes75 { get; set; }
        [Column("fprVatRatesCodes76")]
        [StringLength(1)]
        public string FprVatRatesCodes76 { get; set; }
        [Column("fprVatRatesCodes77")]
        [StringLength(1)]
        public string FprVatRatesCodes77 { get; set; }
        [Column("fprVatRatesCodes78")]
        [StringLength(1)]
        public string FprVatRatesCodes78 { get; set; }
        [Column("fprVatRatesCodes79")]
        [StringLength(1)]
        public string FprVatRatesCodes79 { get; set; }
        [Column("fprVatRatesCodes80")]
        [StringLength(1)]
        public string FprVatRatesCodes80 { get; set; }
        [Column("fprVatRatesCodes81")]
        [StringLength(1)]
        public string FprVatRatesCodes81 { get; set; }
        [Column("fprVatRatesCodes82")]
        [StringLength(1)]
        public string FprVatRatesCodes82 { get; set; }
        [Column("fprVatRatesCodes83")]
        [StringLength(1)]
        public string FprVatRatesCodes83 { get; set; }
        [Column("fprVatRatesCodes84")]
        [StringLength(1)]
        public string FprVatRatesCodes84 { get; set; }
        [Column("fprVatRatesCodes85")]
        [StringLength(1)]
        public string FprVatRatesCodes85 { get; set; }
        [Column("fprVatRatesCodes86")]
        [StringLength(1)]
        public string FprVatRatesCodes86 { get; set; }
        [Column("fprVatRatesCodes87")]
        [StringLength(1)]
        public string FprVatRatesCodes87 { get; set; }
        [Column("fprVatRatesCodes88")]
        [StringLength(1)]
        public string FprVatRatesCodes88 { get; set; }
        [Column("fprVatRatesCodes89")]
        [StringLength(1)]
        public string FprVatRatesCodes89 { get; set; }
        [Column("fprVatRatesCodes90")]
        [StringLength(1)]
        public string FprVatRatesCodes90 { get; set; }
        [Column("fprVatRatesCodes91")]
        [StringLength(1)]
        public string FprVatRatesCodes91 { get; set; }
        [Column("fprVatRatesCodes92")]
        [StringLength(1)]
        public string FprVatRatesCodes92 { get; set; }
        [Column("fprVatRatesCodes93")]
        [StringLength(1)]
        public string FprVatRatesCodes93 { get; set; }
        [Column("fprVatRatesCodes94")]
        [StringLength(1)]
        public string FprVatRatesCodes94 { get; set; }
        [Column("fprVatRatesCodes95")]
        [StringLength(1)]
        public string FprVatRatesCodes95 { get; set; }
        [Column("fprVatRatesCodes96")]
        [StringLength(1)]
        public string FprVatRatesCodes96 { get; set; }
        [Column("fprVatRatesCodes97")]
        [StringLength(1)]
        public string FprVatRatesCodes97 { get; set; }
        [Column("fprVatRatesCodes98")]
        [StringLength(1)]
        public string FprVatRatesCodes98 { get; set; }
        [Column("fprVatRatesCodes99")]
        [StringLength(1)]
        public string FprVatRatesCodes99 { get; set; }
        [Column("fprVatRatesCodes100")]
        [StringLength(1)]
        public string FprVatRatesCodes100 { get; set; }
        [Column("fprOpenDrawer")]
        public short? FprOpenDrawer { get; set; }
        [Column("fprSearchCode")]
        public int? FprSearchCode { get; set; }
        [Column("fprMonitorData", TypeName = "text")]
        public string FprMonitorData { get; set; }
        [Column("fprAlterDescript")]
        public short? FprAlterDescript { get; set; }
        [Column("fprAlterDescSelec")]
        public int? FprAlterDescSelec { get; set; }
        [Column("fprSP300Active")]
        public short? FprSp300active { get; set; }
        [Column("fprSaveReceiptNo")]
        public short? FprSaveReceiptNo { get; set; }
        [Column("fprSaveReceiptFld")]
        public int? FprSaveReceiptFld { get; set; }
        [Column("fprSaveReceiptPro")]
        [StringLength(5)]
        public string FprSaveReceiptPro { get; set; }
        [Column("fprAdditionalSearchCode")]
        public short? FprAdditionalSearchCode { get; set; }
        [Column("fprSearchCustomerPriceFlag")]
        public short? FprSearchCustomerPriceFlag { get; set; }
        [Column("ftrvDisplayText")]
        public short? FtrvDisplayText { get; set; }
        [Column("fprDeptTable")]
        public int? FprDeptTable { get; set; }
        [Column("fprAdditionalDescript")]
        public short? FprAdditionalDescript { get; set; }
        [Column("fprAdditionalDescSelec")]
        public int? FprAdditionalDescSelec { get; set; }
    }
}
