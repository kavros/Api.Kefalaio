using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GTSKELLN")]
    [Index(nameof(GsSkelPos), nameof(GslLineNo), Name = "glsBygSkel", IsUnique = true)]
    public partial class Gtskelln
    {
        [Key]
        [Column("gslFileId")]
        public int GslFileId { get; set; }
        [Column("gsSkelPos")]
        public int GsSkelPos { get; set; }
        [Column("gslLineNo")]
        public int GslLineNo { get; set; }
        [Column("gslgCode")]
        [StringLength(39)]
        public string GslgCode { get; set; }
        [Column("gsldeb_cred")]
        public int? GsldebCred { get; set; }
        [Column("gslCalc")]
        [StringLength(59)]
        public string GslCalc { get; set; }

        [ForeignKey(nameof(GsSkelPos))]
        [InverseProperty(nameof(Gtskel.Gtskellns))]
        public virtual Gtskel GsSkelPosNavigation { get; set; }
    }
}
