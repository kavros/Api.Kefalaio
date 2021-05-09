using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLATABLE3")]
    public partial class Glatable3
    {
        [Key]
        [Column("GLFileIdNo3")]
        public int GlfileIdNo3 { get; set; }
        [Column("GLADesc3")]
        [StringLength(29)]
        public string Gladesc3 { get; set; }
    }
}
