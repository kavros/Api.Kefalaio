using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("POINTSPARAMETERS")]
    public partial class Pointsparameter
    {
        [Key]
        [Column("ppFileId")]
        public int PpFileId { get; set; }
        [Column("ppPointsCalculation")]
        public int? PpPointsCalculation { get; set; }
        [Column("ppPointsCalcType")]
        public int? PpPointsCalcType { get; set; }
        [Column("ppPointsCalcFactor")]
        public double? PpPointsCalcFactor { get; set; }
        [Column("ppUseCalc")]
        public int? PpUseCalc { get; set; }
        [Column("ppUseCalcFactor")]
        public double? PpUseCalcFactor { get; set; }
        [Column("ppUseWay")]
        public int? PpUseWay { get; set; }
        [Column("ppUseInvLessValue")]
        public short? PpUseInvLessValue { get; set; }
        [Column("ppUseOnNextInvoice")]
        public short? PpUseOnNextInvoice { get; set; }
        [Column("ppCalcPointRetailCustomer")]
        public short? PpCalcPointRetailCustomer { get; set; }
        [Column("ppCheckPayWay")]
        public short? PpCheckPayWay { get; set; }
        [Column("ppPayWay")]
        [StringLength(256)]
        public string PpPayWay { get; set; }
    }
}
