using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FYTADIMOI")]
    [Index(nameof(DimCode), Name = "dimByCode", IsUnique = true)]
    public partial class Fytadimoi
    {
        [Key]
        [Column("dimFileId")]
        public int DimFileId { get; set; }
        [Required]
        [Column("dimCode")]
        [StringLength(5)]
        public string DimCode { get; set; }
        [Column("dimDescr")]
        [StringLength(39)]
        public string DimDescr { get; set; }
        [Required]
        [Column("dimPerifCode")]
        [StringLength(5)]
        public string DimPerifCode { get; set; }
    }
}
