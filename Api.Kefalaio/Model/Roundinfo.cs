using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ROUNDINFO")]
    public partial class Roundinfo
    {
        [Key]
        [Column("rniFileId")]
        public int RniFileId { get; set; }
        [Column("rniFrom")]
        public double? RniFrom { get; set; }
        [Column("rniUpto")]
        public double? RniUpto { get; set; }
        [Column("rniRound")]
        public double? RniRound { get; set; }
    }
}
