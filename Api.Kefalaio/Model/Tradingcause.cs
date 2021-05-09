using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TRADINGCAUSE")]
    public partial class Tradingcause
    {
        [Key]
        [Column("trcId")]
        public int TrcId { get; set; }
        [Column("trcDescr")]
        [StringLength(25)]
        public string TrcDescr { get; set; }
    }
}
