using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BXGL")]
    public partial class Bxgl
    {
        [Key]
        [Column("bglFileId")]
        public int BglFileId { get; set; }
        [Column("xgld")]
        [StringLength(39)]
        public string Xgld { get; set; }
        [Column("xglc")]
        [StringLength(39)]
        public string Xglc { get; set; }
        [Column("neg")]
        public short? Neg { get; set; }
        [StringLength(256)]
        public string InvSet { get; set; }
    }
}
