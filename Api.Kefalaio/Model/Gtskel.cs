using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GTSKEL")]
    public partial class Gtskel
    {
        public Gtskel()
        {
            Gtskellns = new HashSet<Gtskelln>();
        }

        [Key]
        [Column("gsFileId")]
        public int GsFileId { get; set; }
        [Column("gsTitle")]
        [StringLength(39)]
        public string GsTitle { get; set; }
        [Column("gsKind")]
        public int? GsKind { get; set; }
        [Column("gsComm")]
        [StringLength(39)]
        public string GsComm { get; set; }
        [Column("gsComm2")]
        [StringLength(39)]
        public string GsComm2 { get; set; }

        [InverseProperty(nameof(Gtskelln.GsSkelPosNavigation))]
        public virtual ICollection<Gtskelln> Gtskellns { get; set; }
    }
}
