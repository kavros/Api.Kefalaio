using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CTRCUSTCODES")]
    public partial class Ctrcustcode
    {
        [Key]
        [Column("ctcFileId")]
        public int CtcFileId { get; set; }
        [Column("ctcData")]
        [StringLength(256)]
        public string CtcData { get; set; }
    }
}
