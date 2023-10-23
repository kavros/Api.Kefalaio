using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SALESDESC")]
    public partial class Salesdesc
    {
        [Key]
        [Column("SalDFileId")]
        public int SalDfileId { get; set; }
        [StringLength(35)]
        public string SalDesc { get; set; }
        [StringLength(3)]
        public string SalDintr { get; set; }
        public int? SalDskind { get; set; }
        public int? SalDckind { get; set; }
        public int? SalDmkind { get; set; }
        public int? SalDekind { get; set; }
        public int? SalDsort { get; set; }
        public short? SalDthird { get; set; }
        [Column("SalDTrKind1")]
        public int? SalDtrKind1 { get; set; }
        [Column("SalDTrKind2")]
        public int? SalDtrKind2 { get; set; }
        [Column("SalDTrKind3")]
        public int? SalDtrKind3 { get; set; }
        [Column("SalDTrKind4")]
        public int? SalDtrKind4 { get; set; }
        [Column("SalDPack")]
        public int? SalDpack { get; set; }
        public int? SalAfmDoyReq { get; set; }
        [Column("salEInvActive")]
        public short? SalEinvActive { get; set; }
        public int? SalKepyoCode { get; set; }
        [Column("SalDPackCheckPrice")]
        public short? SalDpackCheckPrice { get; set; }
    }
}
