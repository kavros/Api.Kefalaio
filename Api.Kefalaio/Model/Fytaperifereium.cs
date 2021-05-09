using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FYTAPERIFEREIA")]
    [Index(nameof(PerifCode), Name = "perifByCode", IsUnique = true)]
    public partial class Fytaperifereium
    {
        [Key]
        [Column("perifFileId")]
        public int PerifFileId { get; set; }
        [Required]
        [Column("perifCode")]
        [StringLength(5)]
        public string PerifCode { get; set; }
        [Column("perifDescr")]
        [StringLength(39)]
        public string PerifDescr { get; set; }
    }
}
