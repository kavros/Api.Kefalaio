using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STOCKUNIT")]
    [Index(nameof(SunCode), Name = "sunByCode", IsUnique = true)]
    public partial class Stockunit
    {
        [Key]
        [Column("sunFileId")]
        public int SunFileId { get; set; }
        [Required]
        [Column("sunCode")]
        [StringLength(3)]
        public string SunCode { get; set; }
        [Column("sunDescr")]
        [StringLength(13)]
        public string SunDescr { get; set; }
        [Column("suEdiName")]
        [StringLength(3)]
        public string SuEdiName { get; set; }
    }
}
