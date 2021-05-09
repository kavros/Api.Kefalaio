using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STOCKTABLE3")]
    public partial class Stocktable3
    {
        [Key]
        public int StFileIdNo3 { get; set; }
        [Column("StockTDe3")]
        [StringLength(29)]
        public string StockTde3 { get; set; }
    }
}
