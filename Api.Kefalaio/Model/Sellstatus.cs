using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SELLSTATUS")]
    public partial class Sellstatus
    {
        [Key]
        [Column("sellStatID")]
        public int SellStatId { get; set; }
        [Column("sellStatDescr")]
        [StringLength(17)]
        public string SellStatDescr { get; set; }
        [Column("sellStatColor")]
        public int? SellStatColor { get; set; }
    }
}
