using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SUPLTRNDESCR")]
    public partial class Supltrndescr
    {
        public Supltrndescr()
        {
            Ptrns = new HashSet<Ptrn>();
        }

        [Key]
        [Column("ptTransKind")]
        public int PtTransKind { get; set; }
        [Column("ptDescr")]
        [StringLength(29)]
        public string PtDescr { get; set; }
        [Column("ptTrFlags")]
        [StringLength(64)]
        public string PtTrFlags { get; set; }
        [Column("ptAntikind")]
        public int? PtAntikind { get; set; }
        [Column("ptTrnp1")]
        public int? PtTrnp1 { get; set; }
        [Column("ptTrnp2")]
        public int? PtTrnp2 { get; set; }
        [Column("ptTrnp3")]
        public int? PtTrnp3 { get; set; }
        [Column("ptpGlCode")]
        [StringLength(39)]
        public string PtpGlCode { get; set; }

        [InverseProperty(nameof(Ptrn.PtTransKindNavigation))]
        public virtual ICollection<Ptrn> Ptrns { get; set; }
    }
}
