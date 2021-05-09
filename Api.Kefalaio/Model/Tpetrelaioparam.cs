using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TPETRELAIOPARAMS")]
    public partial class Tpetrelaioparam
    {
        [Key]
        [Column("TPetrFileId")]
        public int TpetrFileId { get; set; }
        [Column("DPTNo")]
        [StringLength(15)]
        public string Dptno { get; set; }
        [Column("DEHFldFrom")]
        public int? DehfldFrom { get; set; }
        [StringLength(15)]
        public string ItemCode { get; set; }
        public int? OtherExpCode { get; set; }
        public double? Factor1 { get; set; }
        public double? Factor2 { get; set; }
        [StringLength(3)]
        public string SendMode1 { get; set; }
        [StringLength(3)]
        public string SendMode2 { get; set; }
        [StringLength(3)]
        public string SendMode3 { get; set; }
        [StringLength(3)]
        public string SendMode9 { get; set; }
        public int? TradeAim101 { get; set; }
        public int? TradeAim102 { get; set; }
        public int? TradeAim201 { get; set; }
        public int? TradeAim202 { get; set; }
        public int? TradeAim203 { get; set; }
        public int? TradeAim204 { get; set; }
        public int? TradeAim205 { get; set; }
        public int? TradeAim206 { get; set; }
        public int? TradeAim207 { get; set; }
        public int? TradeAim208 { get; set; }
        public int? TradeAim301 { get; set; }
        public int? TradeAim302 { get; set; }
        public int? TradeAim403 { get; set; }
        public int? TradeAim501 { get; set; }
        public int? TraidAim503 { get; set; }
        [Column("DIPETHECdFrm")]
        public int? DipethecdFrm { get; set; }
        public int? TradeAim502 { get; set; }
        public int? TradeAim901 { get; set; }
        public int? TradeAim902 { get; set; }
        [StringLength(15)]
        public string ItemCodeKin { get; set; }
        [Column("TradeMU2")]
        public short? TradeMu2 { get; set; }
        [Column("TradeMU2Set", TypeName = "text")]
        public string TradeMu2set { get; set; }
    }
}
