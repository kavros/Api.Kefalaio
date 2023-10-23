using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SMWEB")]
    [Index(nameof(SmwbsFileId), Name = "smwbBysFileId", IsUnique = true)]
    public partial class Smweb
    {
        [Key]
        [Column("smwbFileId")]
        public int SmwbFileId { get; set; }
        [Column("smwbsFileID")]
        public int SmwbsFileId { get; set; }
        [Column("smwbActive")]
        public short? SmwbActive { get; set; }
        [Column("smwbUsed")]
        public short? SmwbUsed { get; set; }
        [Column("smwbCode")]
        [StringLength(25)]
        public string SmwbCode { get; set; }
        [Column("smwbName")]
        [StringLength(63)]
        public string SmwbName { get; set; }
        [Column("smwbEnName")]
        [StringLength(63)]
        public string SmwbEnName { get; set; }
        [Column("smwbDescr")]
        [StringLength(255)]
        public string SmwbDescr { get; set; }
        [Column("smwbEnDescr")]
        [StringLength(255)]
        public string SmwbEnDescr { get; set; }
        [Column("smwbManufacturer")]
        public int? SmwbManufacturer { get; set; }
        [Column("smwbCategory")]
        public int? SmwbCategory { get; set; }
        [Column("smwbPicture")]
        [StringLength(39)]
        public string SmwbPicture { get; set; }
        [Column("smwbPrice")]
        public double? SmwbPrice { get; set; }
        [Column("smwbDiscPrc")]
        public double? SmwbDiscPrc { get; set; }
        [Column("smwbWeigth")]
        public double? SmwbWeigth { get; set; }
        [Column("smwbMarkUp")]
        public double? SmwbMarkUp { get; set; }
    }
}
