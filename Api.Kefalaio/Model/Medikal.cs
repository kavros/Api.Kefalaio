using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MEDIKAL")]
    [Index(nameof(MdkCode), Name = "mdkByCode", IsUnique = true)]
    public partial class Medikal
    {
        [Key]
        [Column("mdkFileId")]
        public int MdkFileId { get; set; }
        [Required]
        [Column("mdkCode")]
        [StringLength(5)]
        public string MdkCode { get; set; }
        [Column("mdkDescr")]
        [StringLength(81)]
        public string MdkDescr { get; set; }
        [Column("mdkActive")]
        public short? MdkActive { get; set; }
    }
}
