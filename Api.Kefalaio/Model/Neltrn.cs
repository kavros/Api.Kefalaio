using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NELTRN")]
    [Index(nameof(NlmFileId), nameof(NltLno), Name = "nltBynlmPos", IsUnique = true)]
    public partial class Neltrn
    {
        [Key]
        [Column("nltFileId")]
        public int NltFileId { get; set; }
        [Column("nlmFileId")]
        public int NlmFileId { get; set; }
        [Column("nltLno")]
        public int NltLno { get; set; }
        [Column("nltKind")]
        public int? NltKind { get; set; }
        [Column("nltOrgPos")]
        public int? NltOrgPos { get; set; }
        [Column("nltDate", TypeName = "datetime")]
        public DateTime? NltDate { get; set; }
        [Column("nltStatus")]
        public int? NltStatus { get; set; }
        [Column("nltMKind")]
        public int? NltMkind { get; set; }
    }
}
