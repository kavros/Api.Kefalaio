using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SLEDGER")]
    public partial class Sledger
    {
        [Key]
        [Column("slgFileId")]
        public int SlgFileId { get; set; }
        [Column("slgName")]
        [StringLength(39)]
        public string SlgName { get; set; }
        [Column("slgTrns")]
        [StringLength(256)]
        public string SlgTrns { get; set; }
    }
}
