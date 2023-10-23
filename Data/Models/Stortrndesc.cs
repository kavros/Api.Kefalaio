using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STORTRNDESC")]
    public partial class Stortrndesc
    {
        public Stortrndesc()
        {
            Strns = new HashSet<Strn>();
        }

        [Key]
        [Column("sTrNo")]
        public int STrNo { get; set; }
        [Column("stDesc")]
        [StringLength(29)]
        public string StDesc { get; set; }
        [Column("stFlags")]
        [StringLength(64)]
        public string StFlags { get; set; }
        [Column("stTrnp1")]
        public int? StTrnp1 { get; set; }
        [Column("stTrnp2")]
        public int? StTrnp2 { get; set; }
        [Column("stTrnp3")]
        public int? StTrnp3 { get; set; }

        [InverseProperty(nameof(Strn.StTransKindNavigation))]
        public virtual ICollection<Strn> Strns { get; set; }
    }
}
