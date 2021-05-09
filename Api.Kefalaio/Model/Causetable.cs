using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CAUSETABLE")]
    public partial class Causetable
    {
        [Key]
        [Column("cauFileId")]
        public int CauFileId { get; set; }
        [Column("cauName")]
        [StringLength(39)]
        public string CauName { get; set; }
    }
}
