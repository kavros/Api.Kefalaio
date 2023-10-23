using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ASPOSITION")]
    [Index(nameof(ApsCode), Name = "apsByCode", IsUnique = true)]
    public partial class Asposition
    {
        [Key]
        [Column("apsFileId")]
        public int ApsFileId { get; set; }
        [Required]
        [Column("apsCode")]
        [StringLength(3)]
        public string ApsCode { get; set; }
        [Column("apsName")]
        [StringLength(39)]
        public string ApsName { get; set; }
    }
}
