using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("COLORSSETS")]
    public partial class Colorsset
    {
        [Key]
        [Column("clsetFileId")]
        public int ClsetFileId { get; set; }
        [Column("clSetDescr")]
        [StringLength(17)]
        public string ClSetDescr { get; set; }
        [Column("clSetColorCode1")]
        [StringLength(5)]
        public string ClSetColorCode1 { get; set; }
        [Column("clSetColorCode2")]
        [StringLength(5)]
        public string ClSetColorCode2 { get; set; }
        [Column("clSetColorCode3")]
        [StringLength(5)]
        public string ClSetColorCode3 { get; set; }
        [Column("clSetColorCode4")]
        [StringLength(5)]
        public string ClSetColorCode4 { get; set; }
        [Column("clSetColorCode5")]
        [StringLength(5)]
        public string ClSetColorCode5 { get; set; }
        [Column("clSetColorCode6")]
        [StringLength(5)]
        public string ClSetColorCode6 { get; set; }
        [Column("clSetColorCode7")]
        [StringLength(5)]
        public string ClSetColorCode7 { get; set; }
        [Column("clSetColorCode8")]
        [StringLength(5)]
        public string ClSetColorCode8 { get; set; }
        [Column("clSetColorCode9")]
        [StringLength(5)]
        public string ClSetColorCode9 { get; set; }
        [Column("clSetColorCode10")]
        [StringLength(5)]
        public string ClSetColorCode10 { get; set; }
        [Column("clSetColorCode11")]
        [StringLength(5)]
        public string ClSetColorCode11 { get; set; }
        [Column("clSetColorCode12")]
        [StringLength(5)]
        public string ClSetColorCode12 { get; set; }
        [Column("clSetColorCode13")]
        [StringLength(5)]
        public string ClSetColorCode13 { get; set; }
        [Column("clSetColorCode14")]
        [StringLength(5)]
        public string ClSetColorCode14 { get; set; }
        [Column("clSetColorCode15")]
        [StringLength(5)]
        public string ClSetColorCode15 { get; set; }
        [Column("clSetColorCode16")]
        [StringLength(5)]
        public string ClSetColorCode16 { get; set; }
        [Column("clSetColorCode17")]
        [StringLength(5)]
        public string ClSetColorCode17 { get; set; }
        [Column("clSetColorCode18")]
        [StringLength(5)]
        public string ClSetColorCode18 { get; set; }
        [Column("clSetColorCode19")]
        [StringLength(5)]
        public string ClSetColorCode19 { get; set; }
        [Column("clSetColorCode20")]
        [StringLength(5)]
        public string ClSetColorCode20 { get; set; }
        [Column("clSetColorCode21")]
        [StringLength(5)]
        public string ClSetColorCode21 { get; set; }
        [Column("clSetColorCode22")]
        [StringLength(5)]
        public string ClSetColorCode22 { get; set; }
        [Column("clSetColorCode23")]
        [StringLength(5)]
        public string ClSetColorCode23 { get; set; }
        [Column("clSetColorCode24")]
        [StringLength(5)]
        public string ClSetColorCode24 { get; set; }
    }
}
