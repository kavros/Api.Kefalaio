using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FORECAST")]
    public partial class Forecast
    {
        [Key]
        [Column("frcFileId")]
        public int FrcFileId { get; set; }
        [Column("frcValue1")]
        public double? FrcValue1 { get; set; }
        [Column("frcValue2")]
        public double? FrcValue2 { get; set; }
        [Column("frcValue3")]
        public double? FrcValue3 { get; set; }
        [Column("frcValue4")]
        public double? FrcValue4 { get; set; }
        [Column("frcValue5")]
        public double? FrcValue5 { get; set; }
        [Column("frcValue6")]
        public double? FrcValue6 { get; set; }
        [Column("frcValue7")]
        public double? FrcValue7 { get; set; }
        [Column("frcValue8")]
        public double? FrcValue8 { get; set; }
        [Column("frcValue9")]
        public double? FrcValue9 { get; set; }
        [Column("frcValue10")]
        public double? FrcValue10 { get; set; }
        [Column("frcValue11")]
        public double? FrcValue11 { get; set; }
        [Column("frcValue12")]
        public double? FrcValue12 { get; set; }
        [Column("frcName")]
        [StringLength(19)]
        public string FrcName { get; set; }
    }
}
