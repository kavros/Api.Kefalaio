using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LOTMAST")]
    [Index(nameof(SlCode), nameof(SFileId), nameof(SlEndDate), nameof(SlId), Name = "loByCode", IsUnique = true)]
    [Index(nameof(SFileId), nameof(SlInDate), nameof(SlCode), nameof(SlId), Name = "loByInDate")]
    [Index(nameof(SFileId), nameof(SlCode), Name = "loByItemCode")]
    [Index(nameof(SFileId), nameof(SlEndDate), nameof(SlCode), nameof(SlId), Name = "loByStockId", IsUnique = true)]
    public partial class Lotmast
    {
        public Lotmast()
        {
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("loFileId")]
        public int LoFileId { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Required]
        [Column("slCode")]
        [StringLength(15)]
        public string SlCode { get; set; }
        [Column("pFileId")]
        public int? PFileId { get; set; }
        [Column("slInvoice")]
        [StringLength(9)]
        public string SlInvoice { get; set; }
        [Column("slInDate", TypeName = "datetime")]
        public DateTime? SlInDate { get; set; }
        [Column("slEndDate", TypeName = "datetime")]
        public DateTime? SlEndDate { get; set; }
        [Column("slId")]
        public int SlId { get; set; }
        [Column("slPlace")]
        [StringLength(9)]
        public string SlPlace { get; set; }
        [Column("slApogr1")]
        public double? SlApogr1 { get; set; }
        [Column("slApogr2")]
        public double? SlApogr2 { get; set; }
        [Column("slRemain1")]
        public double? SlRemain1 { get; set; }
        [Column("slRemain2")]
        public double? SlRemain2 { get; set; }
        [Column("slValApog")]
        public double? SlValApog { get; set; }
        [Column("slQ1In")]
        public double? SlQ1in { get; set; }
        [Column("slQ2In")]
        public double? SlQ2in { get; set; }
        [Column("slPin")]
        public double? SlPin { get; set; }
        [Column("slVin")]
        public double? SlVin { get; set; }
        [Column("slQ1out")]
        public double? SlQ1out { get; set; }
        [Column("slQ2out")]
        public double? SlQ2out { get; set; }
        [Column("slVout")]
        public double? SlVout { get; set; }
        [Column("slLtrDate", TypeName = "datetime")]
        public DateTime? SlLtrDate { get; set; }
        [Column("slLtrKind")]
        public int? SlLtrKind { get; set; }
        [Column("sLotwait")]
        public double? SLotwait { get; set; }
        [Column("sLotorder")]
        public double? SLotorder { get; set; }
        [Column("slFiller")]
        public int? SlFiller { get; set; }
        [Column("slBPos")]
        public int? SlBpos { get; set; }
        [Column("sLotComment")]
        [StringLength(39)]
        public string SLotComment { get; set; }
        [Column("sloTextHandle")]
        public int? SloTextHandle { get; set; }
        [Column("slTraceID")]
        public int? SlTraceId { get; set; }
        [Column("slTraceDate", TypeName = "datetime")]
        public DateTime? SlTraceDate { get; set; }
        [Column("slProdID")]
        public int? SlProdId { get; set; }
        [Column("slQualityClass")]
        [StringLength(25)]
        public string SlQualityClass { get; set; }
        [Column("slVariety")]
        [StringLength(25)]
        public string SlVariety { get; set; }
        [Column("slOrigin")]
        [StringLength(25)]
        public string SlOrigin { get; set; }
        [Column("slCountry")]
        [StringLength(25)]
        public string SlCountry { get; set; }
        [Column("slOtherInfo")]
        [StringLength(39)]
        public string SlOtherInfo { get; set; }

        [InverseProperty(nameof(Extext.LoFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
