using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSPMINV")]
    [Index(nameof(PrmDate), nameof(PrmSmPos), Name = "prmByDate")]
    [Index(nameof(PrmDoc), Name = "prmByDoc", IsUnique = true)]
    [Index(nameof(PrmExecDate), Name = "prmByExecDate")]
    [Index(nameof(PrmSmPos), nameof(PrmDate), Name = "prmBySmPos")]
    [Index(nameof(PrmSpPos), nameof(PrmDate), Name = "prmBySpPos")]
    public partial class Nspminv
    {
        public Nspminv()
        {
            Strns = new HashSet<Strn>();
        }

        [Key]
        [Column("prmFileId")]
        public int PrmFileId { get; set; }
        [Column("prmDate", TypeName = "datetime")]
        public DateTime PrmDate { get; set; }
        [Required]
        [Column("prmDoc")]
        [StringLength(15)]
        public string PrmDoc { get; set; }
        [Column("prmKind")]
        public int? PrmKind { get; set; }
        [Column("prmTrNumsId")]
        public int? PrmTrNumsId { get; set; }
        [Column("prmSpPos")]
        public int? PrmSpPos { get; set; }
        [Column("prmSmPos")]
        public int? PrmSmPos { get; set; }
        [Column("prmExecDate", TypeName = "datetime")]
        public DateTime? PrmExecDate { get; set; }
        [Column("prmstKind")]
        public int? PrmstKind { get; set; }
        [Column("prmFyra")]
        public double? PrmFyra { get; set; }
        [Column("prmQuant")]
        public double? PrmQuant { get; set; }
        [Column("prmQuant2")]
        public double? PrmQuant2 { get; set; }
        [Column("prmHouse")]
        public int? PrmHouse { get; set; }
        [Column("prmStatus")]
        public int? PrmStatus { get; set; }
        [Column("prmComment")]
        [StringLength(39)]
        public string PrmComment { get; set; }
        [Column("prmComment2")]
        [StringLength(39)]
        public string PrmComment2 { get; set; }
        [Column("prmStrPos")]
        public int? PrmStrPos { get; set; }
        [Column("prmAprLabCost")]
        public double? PrmAprLabCost { get; set; }
        [Column("prmAprOthCost")]
        public double? PrmAprOthCost { get; set; }
        [Column("prmUpdLabCost")]
        public double? PrmUpdLabCost { get; set; }
        [Column("prmUpdOthCost")]
        public double? PrmUpdOthCost { get; set; }
        [Column("prmFlags1")]
        public int? PrmFlags1 { get; set; }
        [Column("prmFlags2")]
        public int? PrmFlags2 { get; set; }
        [Column("prmFlags3")]
        public int? PrmFlags3 { get; set; }
        [Column("prmFlags4")]
        public int? PrmFlags4 { get; set; }
        [Column("prmInsDate", TypeName = "datetime")]
        public DateTime? PrmInsDate { get; set; }
        [Column("prmID")]
        public int? PrmId { get; set; }
        [Column("prmPrinted")]
        public short? PrmPrinted { get; set; }
        [Column("prmLotCode")]
        [StringLength(15)]
        public string PrmLotCode { get; set; }
        [Column("prmLotDate", TypeName = "datetime")]
        public DateTime? PrmLotDate { get; set; }
        [Column("prmWeight")]
        public double? PrmWeight { get; set; }
        [Column("prmVolume")]
        public double? PrmVolume { get; set; }

        [ForeignKey(nameof(PrmTrNumsId))]
        [InverseProperty(nameof(Trnum.Nspminvs))]
        public virtual Trnum PrmTrNums { get; set; }
        [InverseProperty(nameof(Strn.StNmSpInvOriginNavigation))]
        public virtual ICollection<Strn> Strns { get; set; }
    }
}
