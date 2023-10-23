using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NEMSCHEDSETTINGS")]
    public partial class Nemschedsetting
    {
        [Key]
        [Column("nschId")]
        public int NschId { get; set; }
        [Column("nschStateSet")]
        [StringLength(256)]
        public string NschStateSet { get; set; }
        [Column("nschKindSet")]
        [StringLength(256)]
        public string NschKindSet { get; set; }
        [Column("nschTitleSet")]
        [StringLength(256)]
        public string NschTitleSet { get; set; }
        [Column("nschEisprColor")]
        public int? NschEisprColor { get; set; }
        [Column("nschPlirotColor")]
        public int? NschPlirotColor { get; set; }
        public int? IsSynoptiki { get; set; }
        [Column("nschReminderOn")]
        public short? NschReminderOn { get; set; }
        [Column("nschRefreshReminder")]
        public int? NschRefreshReminder { get; set; }
        [Column("nschCheckDaysLiksi")]
        public int? NschCheckDaysLiksi { get; set; }
        [Column("nschReminderStateSet")]
        [StringLength(256)]
        public string NschReminderStateSet { get; set; }
    }
}
