using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ASTABLE1")]
    public partial class Astable1
    {
        [Key]
        public int AsFileIdNo1 { get; set; }
        [StringLength(29)]
        public string AsDesc1 { get; set; }
    }
}
