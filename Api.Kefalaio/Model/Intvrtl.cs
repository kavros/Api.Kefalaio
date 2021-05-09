using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("INTVRTL")]
    [Index(nameof(IrCatId), nameof(IrItemOrder), Name = "irByCategory")]
    [Index(nameof(IrItemPos), Name = "irByItem")]
    public partial class Intvrtl
    {
        [Key]
        [Column("irFileId")]
        public int IrFileId { get; set; }
        [Column("irItemPos")]
        public int? IrItemPos { get; set; }
        [Column("irCatId")]
        [StringLength(3)]
        public string IrCatId { get; set; }
        [Column("irItemOrder")]
        public int? IrItemOrder { get; set; }
        [Column("irQuant")]
        public double? IrQuant { get; set; }
        [Column("irColorPos")]
        public int? IrColorPos { get; set; }
        [Column("irSizePos")]
        public int? IrSizePos { get; set; }
        [Column("irColorId")]
        public int? IrColorId { get; set; }
        [Column("irImage")]
        [StringLength(255)]
        public string IrImage { get; set; }
    }
}
