using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLATABLE1")]
    public partial class Glatable1
    {
        [Key]
        [Column("GLFileIdNo1")]
        public int GlfileIdNo1 { get; set; }
        [Column("GLADesc1")]
        [StringLength(29)]
        public string Gladesc1 { get; set; }
    }
}
