using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SELLACTPARAMS")]
    public partial class Sellactparam
    {
        [Key]
        public int SellPrmId { get; set; }
        public short? SellPrmEnableReminder { get; set; }
        public int? SellPrmRefreshMins { get; set; }
        [StringLength(64)]
        public string SellPrmActPrintCols { get; set; }
        [Column(TypeName = "text")]
        public string SellPrmCaptionCols { get; set; }
        public int? SellPrmAppointmentDuration { get; set; }
        [StringLength(64)]
        public string SellActHistoryCols { get; set; }
        [Column("SyncEMail")]
        [StringLength(39)]
        public string SyncEmail { get; set; }
        [Column("SyncEMailPassw")]
        [StringLength(39)]
        public string SyncEmailPassw { get; set; }
        public short? SellActRefreshIsOn { get; set; }
        public short? AppointmentRemind { get; set; }
    }
}
