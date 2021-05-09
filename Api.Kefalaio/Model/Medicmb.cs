using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MEDICMB")]
    [Index(nameof(CmbMedCode), nameof(CmbDrastCode), nameof(CmbKalCode), Name = "cmbByDrast", IsUnique = true)]
    [Index(nameof(CmbMedCode), nameof(CmbKalCode), nameof(CmbDrastCode), Name = "cmbByKal", IsUnique = true)]
    public partial class Medicmb
    {
        [Key]
        [Column("cmbFileId")]
        public int CmbFileId { get; set; }
        [Required]
        [Column("cmbMedCode")]
        [StringLength(15)]
        public string CmbMedCode { get; set; }
        [Required]
        [Column("cmbDrastCode")]
        [StringLength(7)]
        public string CmbDrastCode { get; set; }
        [Required]
        [Column("cmbKalCode")]
        [StringLength(5)]
        public string CmbKalCode { get; set; }
    }
}
