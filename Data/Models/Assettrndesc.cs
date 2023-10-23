using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("ASSETTRNDESC")]
    public partial class Assettrndesc
    {
        public Assettrndesc()
        {
            Lntrnas = new HashSet<Lntrna>();
            Lntrns = new HashSet<Lntrn>();
        }

        [Key]
        [Column("atdFileId")]
        public int AtdFileId { get; set; }
        [Column("atdDescr")]
        [StringLength(29)]
        public string AtdDescr { get; set; }
        [Column("atdTrConf")]
        [StringLength(64)]
        public string AtdTrConf { get; set; }
        [Column("atdTrnp1")]
        public int? AtdTrnp1 { get; set; }
        [Column("atdTrnp2")]
        public int? AtdTrnp2 { get; set; }
        [Column("atdTrnp3")]
        public int? AtdTrnp3 { get; set; }
        [Column("atdGlKind")]
        public int? AtdGlKind { get; set; }
        [Column("atdCpKinds1")]
        public int? AtdCpKinds1 { get; set; }
        [Column("atdCpKinds2")]
        public int? AtdCpKinds2 { get; set; }
        [Column("atdCpKinds3")]
        public int? AtdCpKinds3 { get; set; }
        [Column("atdSeira")]
        [StringLength(3)]
        public string AtdSeira { get; set; }

        [InverseProperty(nameof(Lntrna.LtkindNavigation))]
        public virtual ICollection<Lntrna> Lntrnas { get; set; }
        [InverseProperty(nameof(Lntrn.LtkindNavigation))]
        public virtual ICollection<Lntrn> Lntrns { get; set; }
    }
}
