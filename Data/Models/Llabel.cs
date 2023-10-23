using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LLABELS")]
    public partial class Llabel
    {
        [Key]
        [Column("llblFileId")]
        public int LlblFileId { get; set; }
        [Column("llblData", TypeName = "text")]
        public string LlblData { get; set; }
    }
}
