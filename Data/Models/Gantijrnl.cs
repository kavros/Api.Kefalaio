using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GANTIJRNLS")]
    public partial class Gantijrnl
    {
        [Key]
        [Column("gajFileId")]
        public int GajFileId { get; set; }
        [Column("gajCode1")]
        [StringLength(25)]
        public string GajCode1 { get; set; }
        [Column("gajCode2")]
        [StringLength(25)]
        public string GajCode2 { get; set; }
        [Column("gajCode3")]
        [StringLength(25)]
        public string GajCode3 { get; set; }
        [Column("gajCode4")]
        [StringLength(25)]
        public string GajCode4 { get; set; }
        [Column("gajCode5")]
        [StringLength(25)]
        public string GajCode5 { get; set; }
        [Column("gajCode6")]
        [StringLength(25)]
        public string GajCode6 { get; set; }
        [Column("gajCode7")]
        [StringLength(25)]
        public string GajCode7 { get; set; }
        [Column("gajCode8")]
        [StringLength(25)]
        public string GajCode8 { get; set; }
        [Column("gajCode9")]
        [StringLength(25)]
        public string GajCode9 { get; set; }
        [Column("gajCode10")]
        [StringLength(25)]
        public string GajCode10 { get; set; }
        [Column("gajCode11")]
        [StringLength(25)]
        public string GajCode11 { get; set; }
        [Column("gajCode12")]
        [StringLength(25)]
        public string GajCode12 { get; set; }
        [Column("gajCode13")]
        [StringLength(25)]
        public string GajCode13 { get; set; }
        [Column("gajCode14")]
        [StringLength(25)]
        public string GajCode14 { get; set; }
        [Column("gajCode15")]
        [StringLength(25)]
        public string GajCode15 { get; set; }
        [Column("gajCode16")]
        [StringLength(25)]
        public string GajCode16 { get; set; }
        [Column("gajCode17")]
        [StringLength(25)]
        public string GajCode17 { get; set; }
        [Column("gajCode18")]
        [StringLength(25)]
        public string GajCode18 { get; set; }
        [Column("gajCode19")]
        [StringLength(25)]
        public string GajCode19 { get; set; }
        [Column("gajCode20")]
        [StringLength(25)]
        public string GajCode20 { get; set; }
        [Column("gajDescr1")]
        [StringLength(11)]
        public string GajDescr1 { get; set; }
        [Column("gajDescr2")]
        [StringLength(11)]
        public string GajDescr2 { get; set; }
        [Column("gajDescr3")]
        [StringLength(11)]
        public string GajDescr3 { get; set; }
        [Column("gajDescr4")]
        [StringLength(11)]
        public string GajDescr4 { get; set; }
        [Column("gajDescr5")]
        [StringLength(11)]
        public string GajDescr5 { get; set; }
        [Column("gajDescr6")]
        [StringLength(11)]
        public string GajDescr6 { get; set; }
        [Column("gajDescr7")]
        [StringLength(11)]
        public string GajDescr7 { get; set; }
        [Column("gajDescr8")]
        [StringLength(11)]
        public string GajDescr8 { get; set; }
        [Column("gajDescr9")]
        [StringLength(11)]
        public string GajDescr9 { get; set; }
        [Column("gajDescr10")]
        [StringLength(11)]
        public string GajDescr10 { get; set; }
        [Column("gajDescr11")]
        [StringLength(11)]
        public string GajDescr11 { get; set; }
        [Column("gajDescr12")]
        [StringLength(11)]
        public string GajDescr12 { get; set; }
        [Column("gajDescr13")]
        [StringLength(11)]
        public string GajDescr13 { get; set; }
        [Column("gajDescr14")]
        [StringLength(11)]
        public string GajDescr14 { get; set; }
        [Column("gajDescr15")]
        [StringLength(11)]
        public string GajDescr15 { get; set; }
        [Column("gajDescr16")]
        [StringLength(11)]
        public string GajDescr16 { get; set; }
        [Column("gajDescr17")]
        [StringLength(11)]
        public string GajDescr17 { get; set; }
        [Column("gajDescr18")]
        [StringLength(11)]
        public string GajDescr18 { get; set; }
        [Column("gajDescr19")]
        [StringLength(11)]
        public string GajDescr19 { get; set; }
        [Column("gajDescr20")]
        [StringLength(11)]
        public string GajDescr20 { get; set; }
        [Column("gajSign1")]
        [StringLength(1)]
        public string GajSign1 { get; set; }
        [Column("gajSign2")]
        [StringLength(1)]
        public string GajSign2 { get; set; }
        [Column("gajSign3")]
        [StringLength(1)]
        public string GajSign3 { get; set; }
        [Column("gajSign4")]
        [StringLength(1)]
        public string GajSign4 { get; set; }
        [Column("gajSign5")]
        [StringLength(1)]
        public string GajSign5 { get; set; }
        [Column("gajSign6")]
        [StringLength(1)]
        public string GajSign6 { get; set; }
        [Column("gajSign7")]
        [StringLength(1)]
        public string GajSign7 { get; set; }
        [Column("gajSign8")]
        [StringLength(1)]
        public string GajSign8 { get; set; }
        [Column("gajSign9")]
        [StringLength(1)]
        public string GajSign9 { get; set; }
        [Column("gajSign10")]
        [StringLength(1)]
        public string GajSign10 { get; set; }
        [Column("gajSign11")]
        [StringLength(1)]
        public string GajSign11 { get; set; }
        [Column("gajSign12")]
        [StringLength(1)]
        public string GajSign12 { get; set; }
        [Column("gajSign13")]
        [StringLength(1)]
        public string GajSign13 { get; set; }
        [Column("gajSign14")]
        [StringLength(1)]
        public string GajSign14 { get; set; }
        [Column("gajSign15")]
        [StringLength(1)]
        public string GajSign15 { get; set; }
        [Column("gajSign16")]
        [StringLength(1)]
        public string GajSign16 { get; set; }
        [Column("gajSign17")]
        [StringLength(1)]
        public string GajSign17 { get; set; }
        [Column("gajSign18")]
        [StringLength(1)]
        public string GajSign18 { get; set; }
        [Column("gajSign19")]
        [StringLength(1)]
        public string GajSign19 { get; set; }
        [Column("gajSign20")]
        [StringLength(1)]
        public string GajSign20 { get; set; }
        [Column("gajSwith1")]
        public int? GajSwith1 { get; set; }
        [Column("gajSwith2")]
        public int? GajSwith2 { get; set; }
        [Column("gajSwith3")]
        public int? GajSwith3 { get; set; }
        [Column("gajSwith4")]
        public int? GajSwith4 { get; set; }
        [Column("gajSwith5")]
        public int? GajSwith5 { get; set; }
        [Column("gajSwith6")]
        public int? GajSwith6 { get; set; }
        [Column("gajSwith7")]
        public int? GajSwith7 { get; set; }
        [Column("gajSwith8")]
        public int? GajSwith8 { get; set; }
        [Column("gajSwith9")]
        public int? GajSwith9 { get; set; }
        [Column("gajSwith10")]
        public int? GajSwith10 { get; set; }
        [Column("gajSwith11")]
        public int? GajSwith11 { get; set; }
        [Column("gajSwith12")]
        public int? GajSwith12 { get; set; }
        [Column("gajSwith13")]
        public int? GajSwith13 { get; set; }
        [Column("gajSwith14")]
        public int? GajSwith14 { get; set; }
        [Column("gajSwith15")]
        public int? GajSwith15 { get; set; }
        [Column("gajSwith16")]
        public int? GajSwith16 { get; set; }
        [Column("gajSwith17")]
        public int? GajSwith17 { get; set; }
        [Column("gajSwith18")]
        public int? GajSwith18 { get; set; }
        [Column("gajSwith19")]
        public int? GajSwith19 { get; set; }
        [Column("gajSwith20")]
        public int? GajSwith20 { get; set; }
    }
}
