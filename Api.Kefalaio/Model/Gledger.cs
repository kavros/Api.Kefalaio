using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLEDGER")]
    public partial class Gledger
    {
        [Key]
        [Column("glgFileId")]
        public int GlgFileId { get; set; }
        [Column("glgName")]
        [StringLength(39)]
        public string GlgName { get; set; }
        [Column("glgTrns")]
        [StringLength(256)]
        public string GlgTrns { get; set; }
    }
}
