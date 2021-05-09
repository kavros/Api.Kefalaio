using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSPINVTYPES")]
    public partial class Nspinvtype
    {
        [Key]
        [Column("sitFileId")]
        public int SitFileId { get; set; }
        [Column("sitDescr")]
        [StringLength(39)]
        public string SitDescr { get; set; }
        [Column("sitInp_Kind")]
        public int? SitInpKind { get; set; }
        [Column("sitExp_Kind")]
        public int? SitExpKind { get; set; }
        [Column("sitStHouse")]
        public int? SitStHouse { get; set; }
        [Column("sitPhase")]
        public int? SitPhase { get; set; }
        [Column("sitValidTrns")]
        [StringLength(256)]
        public string SitValidTrns { get; set; }
        [Column("sitTrnp1")]
        public int? SitTrnp1 { get; set; }
        [Column("sitTrnp2")]
        public int? SitTrnp2 { get; set; }
        [Column("sitTrnp3")]
        public int? SitTrnp3 { get; set; }
        [Column("sitState")]
        public int? SitState { get; set; }
    }
}
