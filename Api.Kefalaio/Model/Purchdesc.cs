using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PURCHDESC")]
    public partial class Purchdesc
    {
        [Key]
        [Column("purFileId")]
        public int PurFileId { get; set; }
        [Column("purDesc")]
        [StringLength(35)]
        public string PurDesc { get; set; }
        [Column("purDintr")]
        [StringLength(3)]
        public string PurDintr { get; set; }
        [Column("purDskind")]
        public int? PurDskind { get; set; }
        [Column("purDckind")]
        public int? PurDckind { get; set; }
        [Column("purDmkind")]
        public int? PurDmkind { get; set; }
        [Column("purDekind")]
        public int? PurDekind { get; set; }
        [Column("purDsort")]
        public int? PurDsort { get; set; }
        [Column("purDthird")]
        public short? PurDthird { get; set; }
        [Column("purDtrKind1")]
        public int? PurDtrKind1 { get; set; }
        [Column("purDtrKind2")]
        public int? PurDtrKind2 { get; set; }
        [Column("purDTrKind3")]
        public int? PurDtrKind3 { get; set; }
        [Column("purDTrKind4")]
        public int? PurDtrKind4 { get; set; }
        [Column("purDPack")]
        public int? PurDpack { get; set; }
        [Column("purAfmDoyReq")]
        public int? PurAfmDoyReq { get; set; }
        [Column("purEInvActive")]
        public short? PurEinvActive { get; set; }
        [Column("purKepyoCode")]
        public int? PurKepyoCode { get; set; }
        [Column("purDPackCheckPrice")]
        public short? PurDpackCheckPrice { get; set; }
    }
}
