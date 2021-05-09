using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PAYMODES")]
    [Index(nameof(PayMode1), Name = "cpmByCode", IsUnique = true)]
    public partial class Paymode
    {
        [Key]
        [Column("payModeId")]
        public int PayModeId { get; set; }
        [Required]
        [Column("payMode")]
        [StringLength(3)]
        public string PayMode1 { get; set; }
        [Column("cpmDescr")]
        [StringLength(29)]
        public string CpmDescr { get; set; }
        [Column("cpmGCode")]
        [StringLength(15)]
        public string CpmGcode { get; set; }
        [Column("cpmPsDisc")]
        public double? CpmPsDisc { get; set; }
        [Column("cpmPsTotal")]
        public int? CpmPsTotal { get; set; }
        [Column("cpmDiscOn")]
        public short? CpmDiscOn { get; set; }
        [Column("cpmAdvance")]
        public double? CpmAdvance { get; set; }
        [Column("cpmDoses")]
        public int? CpmDoses { get; set; }
        [Column("cpmPayDays")]
        public int? CpmPayDays { get; set; }
        [Column("cpmStartDos")]
        public int? CpmStartDos { get; set; }
        [Column("cpmEdiName")]
        [StringLength(3)]
        public string CpmEdiName { get; set; }
        [Column("cpmCustTrnId")]
        public int? CpmCustTrnId { get; set; }
        [Column("cpmSupplTrnId")]
        public int? CpmSupplTrnId { get; set; }
        [Column("cpmCustTrnIdMinus")]
        public int? CpmCustTrnIdMinus { get; set; }
        [Column("cpmSupplTrnIdMinus")]
        public int? CpmSupplTrnIdMinus { get; set; }
    }
}
