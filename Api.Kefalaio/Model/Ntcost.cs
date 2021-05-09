using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NTCOST")]
    [Index(nameof(CtDate), nameof(CtMpos), Name = "ntcByctDate")]
    [Index(nameof(CtMpos), nameof(CtLine), Name = "ntcByctMPos", IsUnique = true)]
    public partial class Ntcost
    {
        [Key]
        [Column("ctFileId")]
        public int CtFileId { get; set; }
        [Column("ctMPos")]
        public int CtMpos { get; set; }
        [Column("ctDate", TypeName = "datetime")]
        public DateTime? CtDate { get; set; }
        [Column("ctLine")]
        public int CtLine { get; set; }
        [Column("ctCost")]
        public int? CtCost { get; set; }
        [Column("ctPPos")]
        public int? CtPpos { get; set; }
        [Column("ctDocument")]
        [StringLength(9)]
        public string CtDocument { get; set; }
        [Column("ctStrUpd")]
        public short? CtStrUpd { get; set; }
        [Column("ctGlUpd")]
        public short? CtGlUpd { get; set; }
        [Column("ctValue")]
        public double? CtValue { get; set; }
        [Column("ctFPAval")]
        public double? CtFpaval { get; set; }
        [Column("ctXnCode")]
        [StringLength(3)]
        public string CtXnCode { get; set; }
        [Column("ctCurr")]
        public double? CtCurr { get; set; }
        [Column("ctXnValue")]
        public double? CtXnValue { get; set; }
        [Column("ctXnFPAval")]
        public double? CtXnFpaval { get; set; }
        [Column("ctGlCode")]
        [StringLength(25)]
        public string CtGlCode { get; set; }
        [Column("ctGlFPA")]
        [StringLength(25)]
        public string CtGlFpa { get; set; }
        [Column("ctCGlCode")]
        [StringLength(25)]
        public string CtCglCode { get; set; }
        [Column("ctTrnCPos")]
        public int? CtTrnCpos { get; set; }
        [Column("ctTrnDPos")]
        public int? CtTrnDpos { get; set; }
    }
}
