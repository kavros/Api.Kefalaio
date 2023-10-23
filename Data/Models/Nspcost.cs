using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSPCOST")]
    public partial class Nspcost
    {
        [Key]
        [Column("scoFileId")]
        public int ScoFileId { get; set; }
        [Column("scoDescr")]
        [StringLength(39)]
        public string ScoDescr { get; set; }
        [Column("scoCode")]
        [StringLength(25)]
        public string ScoCode { get; set; }
    }
}
