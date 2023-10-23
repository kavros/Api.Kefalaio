using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STOCKTABLE1")]
    public partial class Stocktable1
    {
        [Key]
        public int StFileIdNo1 { get; set; }
        [Column("StockTDe1")]
        [StringLength(29)]
        public string StockTde1 { get; set; }
    }
}
