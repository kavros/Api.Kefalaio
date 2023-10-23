using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TRACEJOBS")]
    public partial class Tracejob
    {
        [Key]
        [Column("trjFileId")]
        public int TrjFileId { get; set; }
        [Column("trjData", TypeName = "text")]
        public string TrjData { get; set; }
    }
}
