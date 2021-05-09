using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRCHORDMIS")]
    public partial class Prchordmi
    {
        [Key]
        [Column("pomFileId")]
        public int PomFileId { get; set; }
        [Column("pomName")]
        [StringLength(39)]
        public string PomName { get; set; }
        [Column("pomTrns")]
        [StringLength(256)]
        public string PomTrns { get; set; }
        [Column("pomDet")]
        [StringLength(64)]
        public string PomDet { get; set; }
        [Column("pomSum")]
        [StringLength(64)]
        public string PomSum { get; set; }
    }
}
