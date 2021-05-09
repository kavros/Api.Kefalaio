using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CASHDESKTBL")]
    [Index(nameof(CdCode), Name = "CashDeskByCode", IsUnique = true)]
    public partial class Cashdesktbl
    {
        [Key]
        [Column("cdFileId")]
        public int CdFileId { get; set; }
        [Required]
        [Column("cdCode")]
        [StringLength(3)]
        public string CdCode { get; set; }
        [Column("cdDescription")]
        [StringLength(20)]
        public string CdDescription { get; set; }
        [Column("cdSubsId")]
        public int? CdSubsId { get; set; }
    }
}
