using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("COMPANYINFO")]
    public partial class Companyinfo
    {
        [Key]
        [Column("cmiFileId")]
        public int CmiFileId { get; set; }
        [Column("name1")]
        [StringLength(59)]
        public string Name1 { get; set; }
        [Column("name2")]
        [StringLength(17)]
        public string Name2 { get; set; }
        [Column("name3")]
        [StringLength(15)]
        public string Name3 { get; set; }
        [Column("tname")]
        [StringLength(59)]
        public string Tname { get; set; }
        [Column("telef")]
        [StringLength(15)]
        public string Telef { get; set; }
        [Column("job")]
        [StringLength(17)]
        public string Job { get; set; }
        [Column("addr1")]
        [StringLength(59)]
        public string Addr1 { get; set; }
        [Column("addr2")]
        [StringLength(15)]
        public string Addr2 { get; set; }
        [Column("addr3")]
        [StringLength(15)]
        public string Addr3 { get; set; }
        [Column("afm")]
        [StringLength(9)]
        public string Afm { get; set; }
        [Column("aat")]
        [StringLength(9)]
        public string Aat { get; set; }
        [Column("arec")]
        [StringLength(9)]
        public string Arec { get; set; }
        [Column("startdate", TypeName = "datetime")]
        public DateTime? Startdate { get; set; }
        [Column("doy")]
        [StringLength(15)]
        public string Doy { get; set; }
        [StringLength(7)]
        public string CodeDoy { get; set; }
        [StringLength(15)]
        public string Part { get; set; }
        [StringLength(7)]
        public string CodePart { get; set; }
        [StringLength(15)]
        public string Country { get; set; }
        [StringLength(15)]
        public string City { get; set; }
        [StringLength(15)]
        public string Ccafm { get; set; }
        [StringLength(3)]
        public string Ccountry { get; set; }
        [StringLength(59)]
        public string Trname { get; set; }
        [StringLength(59)]
        public string TrAddr { get; set; }
        [StringLength(15)]
        public string TrCity { get; set; }
        [Column("TrTK")]
        [StringLength(15)]
        public string TrTk { get; set; }
        [StringLength(9)]
        public string TrAfm { get; set; }
        [StringLength(12)]
        public string TrTelef { get; set; }
        [StringLength(12)]
        public string TrFax { get; set; }
        [StringLength(15)]
        public string Customs { get; set; }
        [StringLength(15)]
        public string Trsyn { get; set; }
        public int? AdctCmp { get; set; }
        public short? StatIsActive { get; set; }
        public int? StatMinDaysAlert { get; set; }
        public int? CurrentUseYear { get; set; }
        public int? Customize { get; set; }
        public short? AutoResizeFiles { get; set; }
        [Column("theme")]
        [StringLength(15)]
        public string Theme { get; set; }
        [StringLength(25)]
        public string WallPaper { get; set; }
        [Column("MAENumber")]
        [StringLength(15)]
        public string Maenumber { get; set; }
        [Column("GEMHNumber")]
        [StringLength(15)]
        public string Gemhnumber { get; set; }
        [StringLength(15)]
        public string RpName { get; set; }
        [StringLength(15)]
        public string RpFatherName { get; set; }
        [Column("RpDOY")]
        [StringLength(15)]
        public string RpDoy { get; set; }
        [Column("RpDOYCode")]
        [StringLength(7)]
        public string RpDoycode { get; set; }
        [StringLength(9)]
        public string RdIdNumber { get; set; }
        [Column("xLineUpdate")]
        public short? XLineUpdate { get; set; }
        [Column("HFEFolder")]
        [StringLength(80)]
        public string Hfefolder { get; set; }
        [Column("MAENumber25")]
        [StringLength(25)]
        public string Maenumber25 { get; set; }
        [Column("GEMHNumber50")]
        [StringLength(50)]
        public string Gemhnumber50 { get; set; }
        [Column("stopdate", TypeName = "datetime")]
        public DateTime? Stopdate { get; set; }
        public short? IsVatSpecial { get; set; }
        public int? LegalType { get; set; }
        public int? EntityCategory { get; set; }
    }
}
