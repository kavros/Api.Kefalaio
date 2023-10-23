using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("APOTHEMAT")]
    public partial class Apothemat
    {
        [Key]
        [Column("apoFileId")]
        public int ApoFileId { get; set; }
        [Column("apoName")]
        [StringLength(21)]
        public string ApoName { get; set; }
        [Column("apoValue")]
        public double? ApoValue { get; set; }
    }
}
