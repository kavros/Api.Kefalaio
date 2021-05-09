using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BLINE2")]
    [Index(nameof(PloDate), nameof(SFileId), Name = "ploByDate")]
    [Index(nameof(PloDate), nameof(PoFileId), nameof(PloNum), Name = "ploByDateLine", IsUnique = true)]
    [Index(nameof(PoFileId), nameof(PloNum), Name = "ploBypoFileId", IsUnique = true)]
    [Index(nameof(SFileId), nameof(PloDate), Name = "ploBysFileId")]
    public partial class Bline2
    {
        public Bline2()
        {
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("ploFileId")]
        public int PloFileId { get; set; }
        [Column("poFileId")]
        public int PoFileId { get; set; }
        [Column("ploNum")]
        public int PloNum { get; set; }
        [Column("ploDate", TypeName = "datetime")]
        public DateTime PloDate { get; set; }
        [Column("ploDeliveryDate", TypeName = "datetime")]
        public DateTime? PloDeliveryDate { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Column("ploQuant")]
        public double? PloQuant { get; set; }
        [Column("ploQuant2")]
        public double? PloQuant2 { get; set; }
        [Column("ploPrice")]
        public double? PloPrice { get; set; }
        [Column("ploDisc")]
        public double? PloDisc { get; set; }
        [Column("ploFpa")]
        public int? PloFpa { get; set; }
        [Column("ploSpace")]
        public int? PloSpace { get; set; }
        [Column("ploComm")]
        [StringLength(39)]
        public string PloComm { get; set; }
        [Column("ploWeight")]
        public double? PloWeight { get; set; }
        [Column("ploVolume")]
        public double? PloVolume { get; set; }
        [Column("ploDasm")]
        public int? PloDasm { get; set; }
        [Column("ploTax")]
        public double? PloTax { get; set; }
        [Column("ploLot")]
        [StringLength(15)]
        public string PloLot { get; set; }
        [Column("ploLotEnd", TypeName = "datetime")]
        public DateTime? PloLotEnd { get; set; }
        [Column("ploDisc1")]
        public double? PloDisc1 { get; set; }
        [Column("ploDisc2")]
        public double? PloDisc2 { get; set; }
        [Column("ploSearchCode")]
        [StringLength(25)]
        public string PloSearchCode { get; set; }
        [Column("ploTextHandle")]
        public int? PloTextHandle { get; set; }

        [InverseProperty(nameof(Extext.PloFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
