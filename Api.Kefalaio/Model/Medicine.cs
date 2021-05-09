using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MEDICINE")]
    [Index(nameof(MedCode), Name = "medByCode", IsUnique = true)]
    [Index(nameof(MedNameSrt), Name = "medByName")]
    public partial class Medicine
    {
        [Key]
        [Column("medFileId")]
        public int MedFileId { get; set; }
        [Required]
        [Column("medCode")]
        [StringLength(15)]
        public string MedCode { get; set; }
        [Column("medName")]
        [StringLength(39)]
        public string MedName { get; set; }
        [Column("medName_srt")]
        [StringLength(39)]
        public string MedNameSrt { get; set; }
        [Column("medActive")]
        public short? MedActive { get; set; }
        [Column("medFullName")]
        [StringLength(81)]
        public string MedFullName { get; set; }
    }
}
