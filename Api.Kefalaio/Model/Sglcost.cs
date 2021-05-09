using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SGLCOST")]
    public partial class Sglcost
    {
        [Key]
        [Column("sgcFileId")]
        public int SgcFileId { get; set; }
        [Column("sgcKind")]
        public int? SgcKind { get; set; }
        [Column("sgcLogD")]
        [StringLength(39)]
        public string SgcLogD { get; set; }
        [Column("sgcLogC")]
        [StringLength(39)]
        public string SgcLogC { get; set; }
        [Column("sgcTots")]
        public short? SgcTots { get; set; }
        [Column("sgcMTots")]
        public short? SgcMtots { get; set; }
    }
}
