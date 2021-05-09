using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FILTER")]
    [Index(nameof(FltFile), nameof(FltCode), Name = "fltByCode")]
    public partial class Filter
    {
        [Key]
        [Column("fltFileId")]
        public int FltFileId { get; set; }
        [Column("fltCode")]
        [StringLength(15)]
        public string FltCode { get; set; }
        [Column("fltFile")]
        public int? FltFile { get; set; }
        [Column("fltDescr")]
        [StringLength(35)]
        public string FltDescr { get; set; }
        [Column("fltData", TypeName = "text")]
        public string FltData { get; set; }
    }
}
