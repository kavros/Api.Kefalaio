using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MEDICROP")]
    [Index(nameof(MdcCrop), nameof(MdcMedicine), Name = "mdcByCropMed", IsUnique = true)]
    [Index(nameof(MdcMedicine), nameof(MdcCrop), Name = "mdcByMedCrop", IsUnique = true)]
    public partial class Medicrop
    {
        [Key]
        [Column("mdcFileId")]
        public int MdcFileId { get; set; }
        [Column("mdcMedicine")]
        public int MdcMedicine { get; set; }
        [Required]
        [Column("mdcCrop")]
        [StringLength(5)]
        public string MdcCrop { get; set; }
    }
}
