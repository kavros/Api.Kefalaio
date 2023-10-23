using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("INDEXINGFIELD")]
    public partial class Indexingfield
    {
        [Key]
        public int IndexingIdNo { get; set; }
        [Column("IndexingFileID")]
        public int? IndexingFileId { get; set; }
        [Column(TypeName = "text")]
        public string IndexingColData { get; set; }
    }
}
