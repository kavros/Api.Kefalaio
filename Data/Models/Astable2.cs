using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ASTABLE2")]
    public partial class Astable2
    {
        [Key]
        public int AsFileIdNo2 { get; set; }
        [StringLength(29)]
        public string AsDesc2 { get; set; }
    }
}
