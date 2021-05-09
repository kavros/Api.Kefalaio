using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VXGL")]
    public partial class Vxgl
    {
        [Key]
        [Column("vglFileId")]
        public int VglFileId { get; set; }
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
