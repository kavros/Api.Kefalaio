using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NLCOST")]
    [Index(nameof(ClDocDate), nameof(ClKind), nameof(ClDocPos), Name = "nlcByclDocDate")]
    [Index(nameof(ClKind), nameof(ClDocPos), Name = "nlcByclKind")]
    [Index(nameof(ClMpos), nameof(ClDocPos), nameof(ClStrPos), Name = "nlcByclMPos", IsUnique = true)]
    public partial class Nlcost
    {
        [Key]
        [Column("clFileId")]
        public int ClFileId { get; set; }
        [Column("clMPos")]
        public int ClMpos { get; set; }
        [Column("clKind")]
        public int? ClKind { get; set; }
        [Column("clDocDate", TypeName = "datetime")]
        public DateTime? ClDocDate { get; set; }
        [Column("clDocPos")]
        public int ClDocPos { get; set; }
        [Column("clStrPos")]
        public int ClStrPos { get; set; }
        [Column("clStrAmPos")]
        public int? ClStrAmPos { get; set; }
        [Column("clStrUpd")]
        public short? ClStrUpd { get; set; }
        [Column("clGlUpd")]
        public short? ClGlUpd { get; set; }
    }
}
