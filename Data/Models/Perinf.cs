using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PERINF")]
    public partial class Perinf
    {
        [Key]
        [Column("piFileId")]
        public int PiFileId { get; set; }
        [Column("piDate", TypeName = "datetime")]
        public DateTime? PiDate { get; set; }
        [Column("piVal1")]
        public double? PiVal1 { get; set; }
        [Column("piVal2")]
        public double? PiVal2 { get; set; }
        [Column("piVal3")]
        public double? PiVal3 { get; set; }
        [Column("piVal4")]
        public double? PiVal4 { get; set; }
        [Column("piVal5")]
        public double? PiVal5 { get; set; }
        [Column("piVal6")]
        public double? PiVal6 { get; set; }
        [Column("piVal7")]
        public double? PiVal7 { get; set; }
        [Column("piVal8")]
        public double? PiVal8 { get; set; }
        [Column("piVal9")]
        public double? PiVal9 { get; set; }
        [Column("piVal10")]
        public double? PiVal10 { get; set; }
    }
}
