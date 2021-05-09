using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STOCKSPACE")]
    public partial class Stockspace
    {
        public Stockspace()
        {
            Strninvs = new HashSet<Strninv>();
            Strns = new HashSet<Strn>();
        }

        [Key]
        public int SpaFileIdNo { get; set; }
        [StringLength(9)]
        public string SpaceName { get; set; }
        [Column("SpaceGLAcc")]
        [StringLength(15)]
        public string SpaceGlacc { get; set; }
        [StringLength(17)]
        public string SpaceEdiCd { get; set; }
        [StringLength(39)]
        public string SpaceInfo { get; set; }
        public int? SpaceActive { get; set; }

        [InverseProperty(nameof(Strninv.SivSpace))]
        public virtual ICollection<Strninv> Strninvs { get; set; }
        [InverseProperty(nameof(Strn.StLocationNavigation))]
        public virtual ICollection<Strn> Strns { get; set; }
    }
}
