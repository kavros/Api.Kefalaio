using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NELEDGER")]
    public partial class Neledger
    {
        [Key]
        [Column("elgFileId")]
        public int ElgFileId { get; set; }
        [Column("elgName")]
        [StringLength(39)]
        public string ElgName { get; set; }
        [Column("elgTrns")]
        [StringLength(256)]
        public string ElgTrns { get; set; }
    }
}
