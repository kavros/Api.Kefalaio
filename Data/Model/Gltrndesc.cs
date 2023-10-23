using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLTRNDESC")]
    public partial class Gltrndesc
    {
        public Gltrndesc()
        {
            Gtrnas = new HashSet<Gtrna>();
            Gtrnbs = new HashSet<Gtrnb>();
        }

        [Key]
        [Column("gtTransKind")]
        public int GtTransKind { get; set; }
        [Column("gtblData")]
        [StringLength(19)]
        public string GtblData { get; set; }
        [Column("gtblAnti")]
        [StringLength(25)]
        public string GtblAnti { get; set; }
        [Column("gtblJrnl")]
        public int? GtblJrnl { get; set; }
        [Column("gtFlags")]
        [StringLength(64)]
        public string GtFlags { get; set; }
        [Column("gTrnp_f")]
        public int? GTrnpF { get; set; }
        [Column("gTrnp_p")]
        public int? GTrnpP { get; set; }
        [Column("gTrnp_m")]
        public int? GTrnpM { get; set; }
        [Column("gDetailLineNo")]
        public int? GDetailLineNo { get; set; }

        [InverseProperty(nameof(Gtrna.GtTransKindNavigation))]
        public virtual ICollection<Gtrna> Gtrnas { get; set; }
        [InverseProperty(nameof(Gtrnb.GtTransKindNavigation))]
        public virtual ICollection<Gtrnb> Gtrnbs { get; set; }
    }
}
