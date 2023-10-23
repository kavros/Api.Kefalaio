using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CTRCASHCODES")]
    public partial class Ctrcashcode
    {
        [Key]
        [Column("ctcFileId")]
        public int CtcFileId { get; set; }
        [Column("ctcTrns")]
        [StringLength(256)]
        public string CtcTrns { get; set; }
    }
}
