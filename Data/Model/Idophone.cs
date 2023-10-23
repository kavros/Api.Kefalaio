using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("IDOPHONE")]
    [Index(nameof(CnFileId), nameof(IphnNo), Name = "iphnByCnFileId")]
    [Index(nameof(IphnPhone), Name = "iphnByPhone")]
    [Index(nameof(CFileId), nameof(IphnNo), nameof(Iphnsubsid), Name = "iphnBycFileId")]
    [Index(nameof(GFileId), nameof(IphnNo), Name = "iphnBygFileId")]
    [Index(nameof(PFileId), nameof(IphnNo), nameof(Iphnsubsid), Name = "iphnBypFileId")]
    public partial class Idophone
    {
        [Key]
        [Column("iphnFileId")]
        public int IphnFileId { get; set; }
        [Column("cFileId")]
        public int? CFileId { get; set; }
        [Column("pFileId")]
        public int? PFileId { get; set; }
        [Column("iphnNo")]
        public int? IphnNo { get; set; }
        [Column("iphnPhone")]
        [StringLength(39)]
        public string IphnPhone { get; set; }
        [Column("iphnsubsid")]
        [StringLength(5)]
        public string Iphnsubsid { get; set; }
        [Column("gFileId")]
        public int? GFileId { get; set; }
        [Column("cnFileId")]
        public int? CnFileId { get; set; }
    }
}
