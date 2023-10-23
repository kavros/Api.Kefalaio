using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STOCKTABLE2")]
    public partial class Stocktable2
    {
        [Key]
        public int StFileIdNo2 { get; set; }
        [Column("StockTDe2")]
        [StringLength(29)]
        public string StockTde2 { get; set; }
    }
}
