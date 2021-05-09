using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PLEDGER")]
    public partial class Pledger
    {
        [Key]
        [Column("plgFileId")]
        public int PlgFileId { get; set; }
        [Column("plgName")]
        [StringLength(39)]
        public string PlgName { get; set; }
        [Column("plgTrns")]
        [StringLength(256)]
        public string PlgTrns { get; set; }
    }
}
