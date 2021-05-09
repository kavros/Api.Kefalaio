using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SENDMODES")]
    [Index(nameof(DelivMode), Name = "csmByCode", IsUnique = true)]
    public partial class Sendmode
    {
        [Key]
        [Column("delivModeId")]
        public int DelivModeId { get; set; }
        [Required]
        [Column("delivMode")]
        [StringLength(3)]
        public string DelivMode { get; set; }
        [Column("csmDescr")]
        [StringLength(29)]
        public string CsmDescr { get; set; }
        [Column("csmGCode")]
        [StringLength(15)]
        public string CsmGcode { get; set; }
        [Column("csmDisc")]
        public double? CsmDisc { get; set; }
        [Column("csmTotal")]
        public int? CsmTotal { get; set; }
        [Column("csmSendIntr")]
        [StringLength(3)]
        public string CsmSendIntr { get; set; }
        [Column("csmEdi")]
        [StringLength(3)]
        public string CsmEdi { get; set; }
    }
}
