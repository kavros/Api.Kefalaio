using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSALSCALE")]
    public partial class Nsalscale
    {
        [Key]
        [Column("sscFileId")]
        public int SscFileId { get; set; }
        [Column("sscLimit0")]
        public double? SscLimit0 { get; set; }
        [Column("sscLimit1")]
        public double? SscLimit1 { get; set; }
        [Column("sscPerc0")]
        public double? SscPerc0 { get; set; }
        [Column("sscPerc1")]
        public double? SscPerc1 { get; set; }
    }
}
