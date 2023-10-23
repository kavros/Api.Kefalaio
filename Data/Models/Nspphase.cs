using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSPPHASE")]
    public partial class Nspphase
    {
        [Key]
        [Column("sphFileId")]
        public int SphFileId { get; set; }
        [Column("sphDescr")]
        [StringLength(39)]
        public string SphDescr { get; set; }
    }
}
