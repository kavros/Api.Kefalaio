using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NEPRT")]
    public partial class Neprt
    {
        [Key]
        [Column("nelgFileId")]
        public int NelgFileId { get; set; }
        [Column("nelgName")]
        [StringLength(39)]
        public string NelgName { get; set; }
        [Column("nelgTrns")]
        [StringLength(256)]
        public string NelgTrns { get; set; }
    }
}
