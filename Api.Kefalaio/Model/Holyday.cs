using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("HOLYDAYS")]
    public partial class Holyday
    {
        [Key]
        [Column("hdaFileId")]
        public int HdaFileId { get; set; }
        [Column("hdaDate", TypeName = "datetime")]
        public DateTime? HdaDate { get; set; }
    }
}
