using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PLABELS")]
    public partial class Plabel
    {
        [Key]
        [Column("plblFileId")]
        public int PlblFileId { get; set; }
        [Column("plblData", TypeName = "text")]
        public string PlblData { get; set; }
    }
}
