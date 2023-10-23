using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRINTREP")]
    [Index(nameof(PrKefJobId), Name = "PrPrintByKefJob")]
    public partial class Printrep
    {
        [Key]
        [Column("prFileId")]
        public int PrFileId { get; set; }
        [Column("prKefJobId")]
        public int PrKefJobId { get; set; }
        [Column("prPrintName")]
        [StringLength(39)]
        public string PrPrintName { get; set; }
        [Column("prPrintMode")]
        public int? PrPrintMode { get; set; }
        [Column("prDesignData", TypeName = "text")]
        public string PrDesignData { get; set; }
    }
}
