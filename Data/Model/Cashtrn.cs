using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CASHTRN")]
    [Index(nameof(CashTrnCashDeskId), nameof(CashTrnStatus), nameof(CashTrnDate), nameof(CashTrnTime), Name = "CahTrnByCashDesk")]
    [Index(nameof(CashTrnDate), nameof(CashTrnTime), Name = "CahTrnByDate")]
    [Index(nameof(CashTrnCashDeskId), nameof(CashTrnDate), nameof(CashTrnTime), Name = "CashTrnByCashIDDate")]
    [Index(nameof(CashTrnOrigin), nameof(CashTrnOriginPos), Name = "CashTrnByOriginPos")]
    [Index(nameof(CashTrnUserId), nameof(CashTrnStatus), nameof(CashTrnDate), nameof(CashTrnTime), Name = "CashTrnByUser")]
    [Index(nameof(CashTrnUserId), nameof(CashTrnDate), nameof(CashTrnTime), Name = "CashTrnByUserDate")]
    public partial class Cashtrn
    {
        [Key]
        public int CashTrnFileId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CashTrnDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CashTrnTime { get; set; }
        [Column("CashTrnUserID")]
        public int? CashTrnUserId { get; set; }
        [Column("CashTrnCashDeskID")]
        public int? CashTrnCashDeskId { get; set; }
        public short? CashTrnStatus { get; set; }
        public int? CashTrnOrigin { get; set; }
        public int? CashTrnOriginPos { get; set; }
        public int? CashTrnType { get; set; }
        public double? CashTrnValue { get; set; }
    }
}
