using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("KFSLEDGER")]
    public partial class Kfsledger
    {
        [Key]
        [Column("kflFileId")]
        public int KflFileId { get; set; }
        [Column("kflData")]
        public int? KflData { get; set; }
    }
}
