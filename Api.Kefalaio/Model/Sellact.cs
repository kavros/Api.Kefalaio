using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SELLACT")]
    [Index(nameof(ActCustomerPos), nameof(ActsmStartDt), nameof(ActsmStartTime), Name = "actByCustDT")]
    [Index(nameof(ActsmStartDt), nameof(ActCustomerPos), nameof(ActsmStartTime), Name = "actByDTCust")]
    [Index(nameof(ActSellerPos), nameof(ActCustomerPos), nameof(ActStartDt), Name = "actBySellCust")]
    [Index(nameof(ActSellerPos), nameof(ActCustomerPos), nameof(ActStartDt), nameof(ActEndDt), Name = "actBySellCustUnique")]
    [Index(nameof(ActSellerPos), nameof(ActStartDt), Name = "actBySeller")]
    public partial class Sellact
    {
        [Key]
        [Column("actFileId")]
        public int ActFileId { get; set; }
        [Column("actsmStartDT", TypeName = "datetime")]
        public DateTime? ActsmStartDt { get; set; }
        [Column("actCustomerPos")]
        public int? ActCustomerPos { get; set; }
        [Column("actsmStartTime", TypeName = "datetime")]
        public DateTime? ActsmStartTime { get; set; }
        [Column("actSellerPos")]
        public int ActSellerPos { get; set; }
        [Column("actStartDT", TypeName = "datetime")]
        public DateTime ActStartDt { get; set; }
        [Column("actEndDT", TypeName = "datetime")]
        public DateTime ActEndDt { get; set; }
        [Column("actShop")]
        [StringLength(5)]
        public string ActShop { get; set; }
        [Column("actCustContactStr")]
        [StringLength(39)]
        public string ActCustContactStr { get; set; }
        [Column("actTitle")]
        [StringLength(39)]
        public string ActTitle { get; set; }
        [Column("actLocationType")]
        public int? ActLocationType { get; set; }
        [Column("actLocationStr")]
        [StringLength(39)]
        public string ActLocationStr { get; set; }
        [Column("actActivityType")]
        public int? ActActivityType { get; set; }
        [Column("actStatus")]
        public int? ActStatus { get; set; }
        [Column("actComment")]
        [StringLength(512)]
        public string ActComment { get; set; }
        [Column("actRemindMinsBefore")]
        public int? ActRemindMinsBefore { get; set; }
        [Column("actReminderDate", TypeName = "datetime")]
        public DateTime? ActReminderDate { get; set; }
        [Column("actOptions")]
        public int? ActOptions { get; set; }
        [Column("actEntryID")]
        [StringLength(49)]
        public string ActEntryId { get; set; }
        [Column("actGmailLink")]
        [StringLength(128)]
        public string ActGmailLink { get; set; }
        [Column("actRelativeCode")]
        [StringLength(3)]
        public string ActRelativeCode { get; set; }
        [Column("actUserId")]
        public int? ActUserId { get; set; }
        [Column("actInsDate", TypeName = "datetime")]
        public DateTime? ActInsDate { get; set; }
        [Column("actInsTime", TypeName = "datetime")]
        public DateTime? ActInsTime { get; set; }
        [Column("actUpdDate", TypeName = "datetime")]
        public DateTime? ActUpdDate { get; set; }
        [Column("actUpdTime", TypeName = "datetime")]
        public DateTime? ActUpdTime { get; set; }
    }
}
