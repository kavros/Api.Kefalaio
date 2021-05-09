using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLVATRECORDSPARAMS")]
    public partial class Glvatrecordsparam
    {
        [Key]
        [Column("rFileId")]
        public int RFileId { get; set; }
        [Column("ledgerTransCode")]
        public int? LedgerTransCode { get; set; }
        [Column(TypeName = "text")]
        public string CustCollTransSet { get; set; }
        [Column(TypeName = "text")]
        public string CustInvTransSet { get; set; }
        [Column(TypeName = "text")]
        public string SuplPayTransSet { get; set; }
        [Column(TypeName = "text")]
        public string SuplInvTransSet { get; set; }
        [Column("fromDate", TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column("todate", TypeName = "datetime")]
        public DateTime? Todate { get; set; }
        public int? Days { get; set; }
    }
}
