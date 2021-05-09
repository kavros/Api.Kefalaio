using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLATABLE2")]
    public partial class Glatable2
    {
        [Key]
        [Column("GLFileIdNo2")]
        public int GlfileIdNo2 { get; set; }
        [Column("GLADesc2")]
        [StringLength(29)]
        public string Gladesc2 { get; set; }
    }
}
