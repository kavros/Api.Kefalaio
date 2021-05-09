using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SUPPLTAXKIND")]
    [Index(nameof(PTaxNum), Name = "pTaxByNum")]
    public partial class Suppltaxkind
    {
        [Key]
        [Column("pTaxID")]
        public int PTaxId { get; set; }
        [Column("pTaxNum")]
        public int? PTaxNum { get; set; }
        [Column("pTaxLimitVal")]
        public double? PTaxLimitVal { get; set; }
        [Column("pTaxDateStart", TypeName = "datetime")]
        public DateTime? PTaxDateStart { get; set; }
    }
}
