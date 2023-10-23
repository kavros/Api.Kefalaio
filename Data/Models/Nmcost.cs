using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NMCOST")]
    [Index(nameof(CmCloseDate), Name = "mcByCloseDate")]
    [Index(nameof(CmDate), nameof(CmDocument), Name = "mcByDate")]
    [Index(nameof(CmKind), nameof(CmDocument), Name = "mcByKind", IsUnique = true)]
    public partial class Nmcost
    {
        public Nmcost()
        {
            Strns = new HashSet<Strn>();
        }

        [Key]
        [Column("cmFileId")]
        public int CmFileId { get; set; }
        [Required]
        [Column("cmDocument")]
        [StringLength(15)]
        public string CmDocument { get; set; }
        [Column("cmDate", TypeName = "datetime")]
        public DateTime? CmDate { get; set; }
        [Column("cmKind")]
        public int CmKind { get; set; }
        [Column("cmStrUpd")]
        public short? CmStrUpd { get; set; }
        [Column("cmGlupd")]
        public short? CmGlupd { get; set; }
        [Column("cmCloseDate", TypeName = "datetime")]
        public DateTime? CmCloseDate { get; set; }
        [Column("cmSelInv")]
        public short? CmSelInv { get; set; }
        [Column("cmGlCode")]
        [StringLength(25)]
        public string CmGlCode { get; set; }
        [Column("cmDescr")]
        [StringLength(39)]
        public string CmDescr { get; set; }

        [InverseProperty(nameof(Strn.StNmCostOriginNavigation))]
        public virtual ICollection<Strn> Strns { get; set; }
    }
}
