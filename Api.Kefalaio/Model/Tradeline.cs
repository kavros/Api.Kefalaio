using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TRADELINES")]
    public partial class Tradeline
    {
        [Key]
        [Column("REC_NO")]
        public int RecNo { get; set; }
        [Key]
        [Column("REC_MASTER")]
        public int RecMaster { get; set; }
        [StringLength(15)]
        public string TrdItemCode { get; set; }
        public double? TrdItemQuant { get; set; }
        public double? TrdItemQuant2 { get; set; }
        public double? TrdItemPrice { get; set; }
        public double? TrdItempDisc { get; set; }
        [StringLength(3)]
        public string TrdItemFpaCode { get; set; }
        public int? TrdItemSpace { get; set; }
        [StringLength(39)]
        public string TrdItemComm { get; set; }
        public double? TrdItemWeight { get; set; }
        public double? TrdItemVolume { get; set; }
        public double? TrdItemTax { get; set; }
        [StringLength(15)]
        public string TrdItemLot { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrdItemLotEnd { get; set; }
        public double? TrdItemDisc1 { get; set; }
        public double? TrdItemDisc2 { get; set; }
        [StringLength(5)]
        public string TrdColorCode { get; set; }
        [StringLength(3)]
        public string TrdSizeCode { get; set; }
        public double? TrdItemAmount { get; set; }
    }
}
