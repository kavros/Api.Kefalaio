using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("REPORT1")]
    [Index(nameof(RepFile), nameof(RepCode), Name = "repByCode")]
    public partial class Report1
    {
        [Key]
        [Column("repFileId")]
        public int RepFileId { get; set; }
        [Column("repCode")]
        [StringLength(15)]
        public string RepCode { get; set; }
        [Column("repFile")]
        public int? RepFile { get; set; }
        [Column("repModify")]
        [StringLength(256)]
        public string RepModify { get; set; }
        [Column("repRun")]
        [StringLength(256)]
        public string RepRun { get; set; }
        [Column("repTitle")]
        [StringLength(49)]
        public string RepTitle { get; set; }
        [Column("repData", TypeName = "text")]
        public string RepData { get; set; }
    }
}
