using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SLABELS")]
    public partial class Slabel
    {
        [Key]
        [Column("slblFileId")]
        public int SlblFileId { get; set; }
        [Column("slblData", TypeName = "text")]
        public string SlblData { get; set; }
    }
}
