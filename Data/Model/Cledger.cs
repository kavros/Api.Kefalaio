using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CLEDGER")]
    public partial class Cledger
    {
        [Key]
        [Column("clgFileId")]
        public int ClgFileId { get; set; }
        [Column("clgName")]
        [StringLength(39)]
        public string ClgName { get; set; }
        [Column("clgTrns")]
        [StringLength(256)]
        public string ClgTrns { get; set; }
    }
}
