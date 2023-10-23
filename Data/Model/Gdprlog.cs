using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GDPRLOG")]
    public partial class Gdprlog
    {
        [Key]
        [Column("gdlFileId")]
        public int GdlFileId { get; set; }
        [Column("gdlDate", TypeName = "datetime")]
        public DateTime? GdlDate { get; set; }
        [Column("gdlUser")]
        public int? GdlUser { get; set; }
        [Column("gdlJobId")]
        public int? GdlJobId { get; set; }
        [Column("gdlKind")]
        public int? GdlKind { get; set; }
        [Column("cFileId")]
        public int? CFileId { get; set; }
        [Column("pFileId")]
        public int? PFileId { get; set; }
        [Column("gFileId")]
        public int? GFileId { get; set; }
        [Column("gdlName")]
        [StringLength(39)]
        public string GdlName { get; set; }
        [Column("gdlName_srt")]
        [StringLength(39)]
        public string GdlNameSrt { get; set; }
        [Column("gdlData", TypeName = "text")]
        public string GdlData { get; set; }
    }
}
