using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SELLACTRELATIVE")]
    [Index(nameof(RelatCode), Name = "relatByCode", IsUnique = true)]
    public partial class Sellactrelative
    {
        [Key]
        [Column("relatId")]
        public int RelatId { get; set; }
        [Required]
        [Column("relatCode")]
        [StringLength(3)]
        public string RelatCode { get; set; }
        [Column("relatDescr")]
        [StringLength(25)]
        public string RelatDescr { get; set; }
    }
}
