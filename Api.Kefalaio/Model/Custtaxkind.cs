using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CUSTTAXKIND")]
    [Index(nameof(CTaxNum), Name = "cTaxByNum")]
    public partial class Custtaxkind
    {
        [Key]
        [Column("cTaxID")]
        public int CTaxId { get; set; }
        [Column("cTaxNum")]
        public int? CTaxNum { get; set; }
        [Column("cTaxLimitVal")]
        public double? CTaxLimitVal { get; set; }
        [Column("cTaxDateStart", TypeName = "datetime")]
        public DateTime? CTaxDateStart { get; set; }
    }
}
