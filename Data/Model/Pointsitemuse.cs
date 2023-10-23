using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("POINTSITEMUSE")]
    public partial class Pointsitemuse
    {
        [Key]
        [Column("piuFileId")]
        public int PiuFileId { get; set; }
        [Column("piuItemPotition")]
        public int? PiuItemPotition { get; set; }
        [Column("piuQuantity")]
        public double? PiuQuantity { get; set; }
        [Column("piuPoints")]
        public int? PiuPoints { get; set; }
    }
}
