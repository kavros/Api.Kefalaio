using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ABCANALYSISSTOCK")]
    public partial class Abcanalysisstock
    {
        [Key]
        [Column("abcFileId")]
        public int AbcFileId { get; set; }
        [Column("abcName")]
        [StringLength(19)]
        public string AbcName { get; set; }
        [Column("abcRate")]
        public int? AbcRate { get; set; }
        public int? FilterId { get; set; }
    }
}
