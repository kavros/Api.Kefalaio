using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CUSTTRNDESC")]
    public partial class Custtrndesc
    {
        public Custtrndesc()
        {
            Ctrns = new HashSet<Ctrn>();
        }

        [Key]
        [Column("ctTransKind")]
        public int CtTransKind { get; set; }
        [Column("ctDescr")]
        [StringLength(29)]
        public string CtDescr { get; set; }
        [Column("ctFlags")]
        [StringLength(64)]
        public string CtFlags { get; set; }
        [Column("antikinds")]
        public int? Antikinds { get; set; }
        [Column("ctTrnp1")]
        public int? CtTrnp1 { get; set; }
        [Column("ctTrnp2")]
        public int? CtTrnp2 { get; set; }
        [Column("ctTrnp3")]
        public int? CtTrnp3 { get; set; }
        [Column("ctcGlCode")]
        [StringLength(39)]
        public string CtcGlCode { get; set; }

        [InverseProperty(nameof(Ctrn.CtTransKindNavigation))]
        public virtual ICollection<Ctrn> Ctrns { get; set; }
    }
}
