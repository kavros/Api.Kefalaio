using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSPTINV")]
    [Index(nameof(PrmFileId), nameof(PrtLno), Name = "prtByMpos", IsUnique = true)]
    [Index(nameof(PrtsFileId), nameof(PrmFileId), Name = "prtBysFileId")]
    public partial class Nsptinv
    {
        [Key]
        [Column("prtFileId")]
        public int PrtFileId { get; set; }
        [Column("prmFileId")]
        public int PrmFileId { get; set; }
        [Column("prtLNo")]
        public int PrtLno { get; set; }
        [Column("prtKind")]
        public int? PrtKind { get; set; }
        [Column("prtsFileId")]
        public int? PrtsFileId { get; set; }
        [Column("prtHouse")]
        public int? PrtHouse { get; set; }
        [Column("prtQuant")]
        public double? PrtQuant { get; set; }
        [Column("prtQuant2")]
        public double? PrtQuant2 { get; set; }
        [Column("prtFyra")]
        public double? PrtFyra { get; set; }
        [Column("prtLotcode")]
        [StringLength(15)]
        public string PrtLotcode { get; set; }
        [Column("prtLotDate", TypeName = "datetime")]
        public DateTime? PrtLotDate { get; set; }
        [Column("prtWeigth")]
        public double? PrtWeigth { get; set; }
        [Column("prtVolume")]
        public double? PrtVolume { get; set; }
        [Column("prtComment")]
        [StringLength(39)]
        public string PrtComment { get; set; }
        [Column("prtComment2")]
        [StringLength(39)]
        public string PrtComment2 { get; set; }
        [Column("prtstFileId")]
        public int? PrtstFileId { get; set; }
        [Column("prtOrgPos")]
        public int? PrtOrgPos { get; set; }
        [Column("prtCost")]
        public double? PrtCost { get; set; }
        [Column("prtDiffCost")]
        public double? PrtDiffCost { get; set; }
        [Column("prtPrDiffCost")]
        public double? PrtPrDiffCost { get; set; }
        [Column("prtPhInvPerc")]
        public double? PrtPhInvPerc { get; set; }
        [Column("prtYpop")]
        public short? PrtYpop { get; set; }
    }
}
