using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BGTRN")]
    [Index(nameof(BgtrMpos), nameof(BgtrDim1Code), nameof(BgtrDim2Code), Name = "BGTrByDim1")]
    [Index(nameof(BgtrMpos), nameof(BgtrDim2Code), nameof(BgtrDim1Code), Name = "BGTrByDim2")]
    [Index(nameof(BgtrMpos), Name = "BGTrByMPos")]
    [Index(nameof(BgtrMpos), nameof(BgtrType), Name = "BGTrByType")]
    public partial class Bgtrn
    {
        [Key]
        [Column("BGTrFileId")]
        public int BgtrFileId { get; set; }
        [Column("BGTrMPos")]
        public int BgtrMpos { get; set; }
        [Column("BGTrType")]
        public int? BgtrType { get; set; }
        [Column("BGTrDim1Code")]
        [StringLength(15)]
        public string BgtrDim1Code { get; set; }
        [Column("BGTrDim2Code")]
        [StringLength(15)]
        public string BgtrDim2Code { get; set; }
        [Column("BGTrLinePos")]
        public int? BgtrLinePos { get; set; }
        [Column("BGTrCalcedQt1")]
        public double? BgtrCalcedQt1 { get; set; }
        [Column("BGTrCalcedQt2")]
        public double? BgtrCalcedQt2 { get; set; }
        [Column("BGTrCalcedQt3")]
        public double? BgtrCalcedQt3 { get; set; }
        [Column("BGTrCalcedQt4")]
        public double? BgtrCalcedQt4 { get; set; }
        [Column("BGTrCalcedQt5")]
        public double? BgtrCalcedQt5 { get; set; }
        [Column("BGTrCalcedQt6")]
        public double? BgtrCalcedQt6 { get; set; }
        [Column("BGTrCalcedQt7")]
        public double? BgtrCalcedQt7 { get; set; }
        [Column("BGTrCalcedQt8")]
        public double? BgtrCalcedQt8 { get; set; }
        [Column("BGTrCalcedQt9")]
        public double? BgtrCalcedQt9 { get; set; }
        [Column("BGTrCalcedQt10")]
        public double? BgtrCalcedQt10 { get; set; }
        [Column("BGTrCalcedQt11")]
        public double? BgtrCalcedQt11 { get; set; }
        [Column("BGTrCalcedQt12")]
        public double? BgtrCalcedQt12 { get; set; }
        [Column("BGTrCalcedVal1")]
        public double? BgtrCalcedVal1 { get; set; }
        [Column("BGTrCalcedVal2")]
        public double? BgtrCalcedVal2 { get; set; }
        [Column("BGTrCalcedVal3")]
        public double? BgtrCalcedVal3 { get; set; }
        [Column("BGTrCalcedVal4")]
        public double? BgtrCalcedVal4 { get; set; }
        [Column("BGTrCalcedVal5")]
        public double? BgtrCalcedVal5 { get; set; }
        [Column("BGTrCalcedVal6")]
        public double? BgtrCalcedVal6 { get; set; }
        [Column("BGTrCalcedVal7")]
        public double? BgtrCalcedVal7 { get; set; }
        [Column("BGTrCalcedVal8")]
        public double? BgtrCalcedVal8 { get; set; }
        [Column("BGTrCalcedVal9")]
        public double? BgtrCalcedVal9 { get; set; }
        [Column("BGTrCalcedVal10")]
        public double? BgtrCalcedVal10 { get; set; }
        [Column("BGTrCalcedVal11")]
        public double? BgtrCalcedVal11 { get; set; }
        [Column("BGTrCalcedVal12")]
        public double? BgtrCalcedVal12 { get; set; }
        [Column("BGTrRealQt1")]
        public double? BgtrRealQt1 { get; set; }
        [Column("BGTrRealQt2")]
        public double? BgtrRealQt2 { get; set; }
        [Column("BGTrRealQt3")]
        public double? BgtrRealQt3 { get; set; }
        [Column("BGTrRealQt4")]
        public double? BgtrRealQt4 { get; set; }
        [Column("BGTrRealQt5")]
        public double? BgtrRealQt5 { get; set; }
        [Column("BGTrRealQt6")]
        public double? BgtrRealQt6 { get; set; }
        [Column("BGTrRealQt7")]
        public double? BgtrRealQt7 { get; set; }
        [Column("BGTrRealQt8")]
        public double? BgtrRealQt8 { get; set; }
        [Column("BGTrRealQt9")]
        public double? BgtrRealQt9 { get; set; }
        [Column("BGTrRealQt10")]
        public double? BgtrRealQt10 { get; set; }
        [Column("BGTrRealQt11")]
        public double? BgtrRealQt11 { get; set; }
        [Column("BGTrRealQt12")]
        public double? BgtrRealQt12 { get; set; }
        [Column("BGTrRealVal1")]
        public double? BgtrRealVal1 { get; set; }
        [Column("BGTrRealVal2")]
        public double? BgtrRealVal2 { get; set; }
        [Column("BGTrRealVal3")]
        public double? BgtrRealVal3 { get; set; }
        [Column("BGTrRealVal4")]
        public double? BgtrRealVal4 { get; set; }
        [Column("BGTrRealVal5")]
        public double? BgtrRealVal5 { get; set; }
        [Column("BGTrRealVal6")]
        public double? BgtrRealVal6 { get; set; }
        [Column("BGTrRealVal7")]
        public double? BgtrRealVal7 { get; set; }
        [Column("BGTrRealVal8")]
        public double? BgtrRealVal8 { get; set; }
        [Column("BGTrRealVal9")]
        public double? BgtrRealVal9 { get; set; }
        [Column("BGTrRealVal10")]
        public double? BgtrRealVal10 { get; set; }
        [Column("BGTrRealVal11")]
        public double? BgtrRealVal11 { get; set; }
        [Column("BGTrRealVal12")]
        public double? BgtrRealVal12 { get; set; }
        [Column("BGTrPrevQt1")]
        public double? BgtrPrevQt1 { get; set; }
        [Column("BGTrPrevQt2")]
        public double? BgtrPrevQt2 { get; set; }
        [Column("BGTrPrevQt3")]
        public double? BgtrPrevQt3 { get; set; }
        [Column("BGTrPrevQt4")]
        public double? BgtrPrevQt4 { get; set; }
        [Column("BGTrPrevQt5")]
        public double? BgtrPrevQt5 { get; set; }
        [Column("BGTrPrevQt6")]
        public double? BgtrPrevQt6 { get; set; }
        [Column("BGTrPrevQt7")]
        public double? BgtrPrevQt7 { get; set; }
        [Column("BGTrPrevQt8")]
        public double? BgtrPrevQt8 { get; set; }
        [Column("BGTrPrevQt9")]
        public double? BgtrPrevQt9 { get; set; }
        [Column("BGTrPrevQt10")]
        public double? BgtrPrevQt10 { get; set; }
        [Column("BGTrPrevQt11")]
        public double? BgtrPrevQt11 { get; set; }
        [Column("BGTrPrevQt12")]
        public double? BgtrPrevQt12 { get; set; }
        [Column("BGTrPrevVal1")]
        public double? BgtrPrevVal1 { get; set; }
        [Column("BGTrPrevVal2")]
        public double? BgtrPrevVal2 { get; set; }
        [Column("BGTrPrevVal3")]
        public double? BgtrPrevVal3 { get; set; }
        [Column("BGTrPrevVal4")]
        public double? BgtrPrevVal4 { get; set; }
        [Column("BGTrPrevVal5")]
        public double? BgtrPrevVal5 { get; set; }
        [Column("BGTrPrevVal6")]
        public double? BgtrPrevVal6 { get; set; }
        [Column("BGTrPrevVal7")]
        public double? BgtrPrevVal7 { get; set; }
        [Column("BGTrPrevVal8")]
        public double? BgtrPrevVal8 { get; set; }
        [Column("BGTrPrevVal9")]
        public double? BgtrPrevVal9 { get; set; }
        [Column("BGTrPrevVal10")]
        public double? BgtrPrevVal10 { get; set; }
        [Column("BGTrPrevVal11")]
        public double? BgtrPrevVal11 { get; set; }
        [Column("BGTrPrevVal12")]
        public double? BgtrPrevVal12 { get; set; }
    }
}
