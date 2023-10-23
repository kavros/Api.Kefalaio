using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("AGROPARAMS")]
    public partial class Agroparam
    {
        [Key]
        [Column("agFileId")]
        public int AgFileId { get; set; }
        [Column("agFPAcode")]
        [StringLength(3)]
        public string AgFpacode { get; set; }
        public short? AgCheckRemain { get; set; }
        public int? AgOthExp1 { get; set; }
        public int? AgOthExp2 { get; set; }
        [Column("AgDecsXY")]
        public int? AgDecsXy { get; set; }
        public int? AgDecsPerYg { get; set; }
        public int? AgPckActive { get; set; }
        public int? AgWeightField { get; set; }
        public int? AgPckWeightDecs { get; set; }
        public int? AgCalcMode { get; set; }
        [Column("AgShowAX")]
        public short? AgShowAx { get; set; }
        public short? AgVdetails { get; set; }
        [Column("AgXYEdit")]
        public short? AgXyedit { get; set; }
        public short? AgYgrEdit { get; set; }
        [Column(TypeName = "text")]
        public string AgInvoicesSet { get; set; }
        public int? AgWeightField2 { get; set; }
        public int? AgPckWeightDecs2 { get; set; }
        public int? AgDefaultMesitis { get; set; }
        public int? AgExtraOthExp1 { get; set; }
        public int? AgExtraOthExp2 { get; set; }
        [Column(TypeName = "text")]
        public string AgExtraOthExpTrans { get; set; }
    }
}
