using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SELECTORFIELD")]
    public partial class Selectorfield
    {
        [Key]
        public int SelectorIdNo { get; set; }
        [Column("SelectorFileID")]
        public int? SelectorFileId { get; set; }
        [Column(TypeName = "text")]
        public string SelectorColData { get; set; }
    }
}
