using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VersionInfo")]
    public partial class VersionInfo
    {
        [Key]
        [Column("ATableName")]
        [StringLength(63)]
        public string AtableName { get; set; }
        [Required]
        [Column("AVersion")]
        [StringLength(9)]
        public string Aversion { get; set; }
    }
}
