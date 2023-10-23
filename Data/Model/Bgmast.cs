using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BGMAST")]
    [Index(nameof(Bgcode), Name = "BGByCode", IsUnique = true)]
    [Index(nameof(BgdescrSrt), Name = "BGByDescr")]
    [Index(nameof(Bgtype), Name = "BGByType")]
    public partial class Bgmast
    {
        [Key]
        [Column("BGFileId")]
        public int BgfileId { get; set; }
        [Required]
        [Column("BGCode")]
        [StringLength(15)]
        public string Bgcode { get; set; }
        [Column("BGDescr")]
        [StringLength(39)]
        public string Bgdescr { get; set; }
        [Column("BGDescr_srt")]
        [StringLength(39)]
        public string BgdescrSrt { get; set; }
        [Column("BGType")]
        public int? Bgtype { get; set; }
        [Column("BGDim1type")]
        public int? Bgdim1type { get; set; }
        [Column("BGDim2type")]
        public int? Bgdim2type { get; set; }
        [Column("BGMajorDim")]
        public int? BgmajorDim { get; set; }
        [Column("BGDistribCode")]
        public int? BgdistribCode { get; set; }
        [Column("BGTrnCodeSet")]
        [StringLength(256)]
        public string BgtrnCodeSet { get; set; }
        [Column("BGComment")]
        [StringLength(39)]
        public string Bgcomment { get; set; }
        [Column("BGLastDate", TypeName = "datetime")]
        public DateTime? BglastDate { get; set; }
        [Column("BGCalcValType")]
        public int? BgcalcValType { get; set; }
        [Column("BGInclDisc")]
        public short? BginclDisc { get; set; }
    }
}
