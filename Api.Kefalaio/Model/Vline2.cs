using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VLINE2")]
    [Index(nameof(SloDate), nameof(SFileId), Name = "sloByDate")]
    [Index(nameof(SloDate), nameof(SoFileId), nameof(SloNum), Name = "sloByDateLine", IsUnique = true)]
    [Index(nameof(SFileId), nameof(SloDate), Name = "sloBysFileId")]
    [Index(nameof(SoFileId), nameof(SloNum), Name = "sloBysoFileId", IsUnique = true)]
    public partial class Vline2
    {
        public Vline2()
        {
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("sloFileId")]
        public int SloFileId { get; set; }
        [Column("soFileId")]
        public int SoFileId { get; set; }
        [Column("sloNum")]
        public int SloNum { get; set; }
        [Column("sloDate", TypeName = "datetime")]
        public DateTime SloDate { get; set; }
        [Column("sloDeliveryDate", TypeName = "datetime")]
        public DateTime? SloDeliveryDate { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Column("sloQuant")]
        public double? SloQuant { get; set; }
        [Column("sloQuant2")]
        public double? SloQuant2 { get; set; }
        [Column("sloPrice")]
        public double? SloPrice { get; set; }
        [Column("sloDisc")]
        public double? SloDisc { get; set; }
        [Column("sloFpa")]
        public int? SloFpa { get; set; }
        [Column("sloSpace")]
        public int? SloSpace { get; set; }
        [Column("sloComm")]
        [StringLength(39)]
        public string SloComm { get; set; }
        [Column("sloWeight")]
        public double? SloWeight { get; set; }
        [Column("sloVolume")]
        public double? SloVolume { get; set; }
        [Column("sloDasm")]
        public int? SloDasm { get; set; }
        [Column("sloTax")]
        public double? SloTax { get; set; }
        [Column("sloLot")]
        [StringLength(15)]
        public string SloLot { get; set; }
        [Column("sloLotEnd", TypeName = "datetime")]
        public DateTime? SloLotEnd { get; set; }
        [Column("sloDisc1")]
        public double? SloDisc1 { get; set; }
        [Column("sloDisc2")]
        public double? SloDisc2 { get; set; }
        [Column("sloSearchCode")]
        [StringLength(25)]
        public string SloSearchCode { get; set; }
        [Column("sloTextHandle")]
        public int? SloTextHandle { get; set; }

        [InverseProperty(nameof(Extext.SloFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
