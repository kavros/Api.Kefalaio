using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MEDIDRAS")]
    [Index(nameof(MddCode), Name = "mddByCode", IsUnique = true)]
    public partial class Medidra
    {
        [Key]
        [Column("mddFileID")]
        public int MddFileId { get; set; }
        [Required]
        [Column("mddCode")]
        [StringLength(7)]
        public string MddCode { get; set; }
        [Column("mddDescr")]
        [StringLength(81)]
        public string MddDescr { get; set; }
        [Column("mddActive")]
        public short? MddActive { get; set; }
    }
}
