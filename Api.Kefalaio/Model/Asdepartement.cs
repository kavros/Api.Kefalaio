using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ASDEPARTEMENT")]
    [Index(nameof(AdpCode), Name = "apdBycode", IsUnique = true)]
    public partial class Asdepartement
    {
        [Key]
        [Column("adpFileId")]
        public int AdpFileId { get; set; }
        [Required]
        [Column("adpCode")]
        [StringLength(3)]
        public string AdpCode { get; set; }
        [Column("adpName")]
        [StringLength(39)]
        public string AdpName { get; set; }
    }
}
