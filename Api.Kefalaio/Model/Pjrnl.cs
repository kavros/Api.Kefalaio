using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PJRNLS")]
    public partial class Pjrnl
    {
        [Key]
        [Column("pjrFileId")]
        public int PjrFileId { get; set; }
        [Column("pjrDescr")]
        [StringLength(39)]
        public string PjrDescr { get; set; }
        [Column("pjrPrtType")]
        public int? PjrPrtType { get; set; }
        [Column("pjrLastDate", TypeName = "datetime")]
        public DateTime? PjrLastDate { get; set; }
        [Column("pjrJournalNo")]
        public int? PjrJournalNo { get; set; }
        [Column("pjrTrns")]
        [StringLength(256)]
        public string PjrTrns { get; set; }
    }
}
