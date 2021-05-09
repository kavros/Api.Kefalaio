using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSALGROUP")]
    public partial class Nsalgroup
    {
        [Key]
        [Column("sgpFileId")]
        public int SgpFileId { get; set; }
        [Column("sgpDescr")]
        [StringLength(39)]
        public string SgpDescr { get; set; }
        [Column("sgpPerc0")]
        public double? SgpPerc0 { get; set; }
        [Column("sgpPerc1")]
        public double? SgpPerc1 { get; set; }
    }
}
