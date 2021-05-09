using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CJRNLS")]
    public partial class Cjrnl
    {
        [Key]
        [Column("cjrFileId")]
        public int CjrFileId { get; set; }
        [Column("cjrDesc")]
        [StringLength(39)]
        public string CjrDesc { get; set; }
        [Column("cjrPrtType")]
        public int? CjrPrtType { get; set; }
        [Column("cjrLastDate", TypeName = "datetime")]
        public DateTime? CjrLastDate { get; set; }
        [Column("cjrJournalNo")]
        public int? CjrJournalNo { get; set; }
        [Column("cjrTrns")]
        [StringLength(256)]
        public string CjrTrns { get; set; }
    }
}
