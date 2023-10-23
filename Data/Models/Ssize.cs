using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SSIZES")]
    public partial class Ssize
    {
        [Key]
        [Column("sszFileId")]
        public int SszFileId { get; set; }
        [Column("sszDescr")]
        [StringLength(17)]
        public string SszDescr { get; set; }
        [Column("sszCode1")]
        [StringLength(3)]
        public string SszCode1 { get; set; }
        [Column("sszCode2")]
        [StringLength(3)]
        public string SszCode2 { get; set; }
        [Column("sszCode3")]
        [StringLength(3)]
        public string SszCode3 { get; set; }
        [Column("sszCode4")]
        [StringLength(3)]
        public string SszCode4 { get; set; }
        [Column("sszCode5")]
        [StringLength(3)]
        public string SszCode5 { get; set; }
        [Column("sszCode6")]
        [StringLength(3)]
        public string SszCode6 { get; set; }
        [Column("sszCode7")]
        [StringLength(3)]
        public string SszCode7 { get; set; }
        [Column("sszCode8")]
        [StringLength(3)]
        public string SszCode8 { get; set; }
        [Column("sszCode9")]
        [StringLength(3)]
        public string SszCode9 { get; set; }
        [Column("sszCode10")]
        [StringLength(3)]
        public string SszCode10 { get; set; }
        [Column("sszCode11")]
        [StringLength(3)]
        public string SszCode11 { get; set; }
        [Column("sszCode12")]
        [StringLength(3)]
        public string SszCode12 { get; set; }
        [Column("sszCode13")]
        [StringLength(3)]
        public string SszCode13 { get; set; }
        [Column("sszCode14")]
        [StringLength(3)]
        public string SszCode14 { get; set; }
        [Column("sszCode15")]
        [StringLength(3)]
        public string SszCode15 { get; set; }
        [Column("sszCode16")]
        [StringLength(3)]
        public string SszCode16 { get; set; }
        [Column("sszCode17")]
        [StringLength(3)]
        public string SszCode17 { get; set; }
        [Column("sszCode18")]
        [StringLength(3)]
        public string SszCode18 { get; set; }
        [Column("sszCode19")]
        [StringLength(3)]
        public string SszCode19 { get; set; }
        [Column("sszCode20")]
        [StringLength(3)]
        public string SszCode20 { get; set; }
    }
}
