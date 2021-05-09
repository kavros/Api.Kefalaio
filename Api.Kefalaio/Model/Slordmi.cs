using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SLORDMIS")]
    public partial class Slordmi
    {
        [Key]
        [Column("somFileId")]
        public int SomFileId { get; set; }
        [Column("somName")]
        [StringLength(39)]
        public string SomName { get; set; }
        [Column("somTrns")]
        [StringLength(256)]
        public string SomTrns { get; set; }
        [Column("somDet")]
        [StringLength(64)]
        public string SomDet { get; set; }
        [Column("somSum")]
        [StringLength(64)]
        public string SomSum { get; set; }
    }
}
