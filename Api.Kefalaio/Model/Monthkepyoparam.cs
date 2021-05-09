using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MONTHKEPYOPARAMS")]
    public partial class Monthkepyoparam
    {
        [Key]
        [Column("mKFileId")]
        public int MKfileId { get; set; }
        [Column("mKSiteUser")]
        [StringLength(29)]
        public string MKsiteUser { get; set; }
        [Column("mkSitePass")]
        [StringLength(29)]
        public string MkSitePass { get; set; }
        [Column("mKUseBranch")]
        public short? MKuseBranch { get; set; }
        [Column("mkBranch")]
        [StringLength(9)]
        public string MkBranch { get; set; }
        [Column("mKMoveFiles")]
        public short? MKmoveFiles { get; set; }
        [Column("mKFolder")]
        [StringLength(81)]
        public string MKfolder { get; set; }
        [Column("mKZipFiles")]
        public short? MKzipFiles { get; set; }
        [Column("mKWSUser")]
        [StringLength(29)]
        public string MKwsuser { get; set; }
        [Column("mkWSPass")]
        [StringLength(29)]
        public string MkWspass { get; set; }
        [Column("mkWSActive")]
        public short? MkWsactive { get; set; }
        [Column("mKepyoMode")]
        public int? MKepyoMode { get; set; }
    }
}
