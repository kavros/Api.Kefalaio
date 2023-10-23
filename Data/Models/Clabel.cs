using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CLABELS")]
    public partial class Clabel
    {
        [Key]
        [Column("clblFileId")]
        public int ClblFileId { get; set; }
        [Column("clblData", TypeName = "text")]
        public string ClblData { get; set; }
    }
}
