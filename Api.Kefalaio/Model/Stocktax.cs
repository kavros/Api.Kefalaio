using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STOCKTAX")]
    public partial class Stocktax
    {
        [Key]
        public int DasFileIdNo { get; set; }
        [StringLength(17)]
        public string DasmDescr { get; set; }
        public double? DasmPerc { get; set; }
        [Column("DasmNEP")]
        public double? DasmNep { get; set; }
    }
}
