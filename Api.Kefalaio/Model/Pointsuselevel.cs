using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("POINTSUSELEVEL")]
    public partial class Pointsuselevel
    {
        [Key]
        [Column("pulFileId")]
        public int PulFileId { get; set; }
        [Column("pulValue")]
        public double? PulValue { get; set; }
        [Column("pulPoints")]
        public int? PulPoints { get; set; }
    }
}
