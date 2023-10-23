using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ASTABLE3")]
    public partial class Astable3
    {
        [Key]
        public int AsFileIdNo3 { get; set; }
        [StringLength(29)]
        public string AsDesc3 { get; set; }
    }
}
