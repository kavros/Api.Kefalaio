using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NEMAST")]
    [Index(nameof(NemCode), Name = "NemByCode", IsUnique = true)]
    [Index(nameof(NemDate), Name = "nemByDate")]
    [Index(nameof(NemGetDate), nameof(NemTime), Name = "nemByGetDate")]
    [Index(nameof(NemNumber), Name = "nemByNumber")]
    [Index(nameof(NemowType), nameof(NemowPos), nameof(NemDate), Name = "nemByOwType")]
    public partial class Nemast
    {
        public Nemast()
        {
            Ctrns = new HashSet<Ctrn>();
            Ptrns = new HashSet<Ptrn>();
        }

        [Key]
        [Column("nemFileId")]
        public int NemFileId { get; set; }
        [Column("nemDate", TypeName = "datetime")]
        public DateTime? NemDate { get; set; }
        [Required]
        [Column("nemCode")]
        [StringLength(15)]
        public string NemCode { get; set; }
        [Column("nemKind")]
        public int? NemKind { get; set; }
        [Column("nemState")]
        public int? NemState { get; set; }
        [Column("nemNumber")]
        [StringLength(15)]
        public string NemNumber { get; set; }
        [Column("nemPublDate", TypeName = "datetime")]
        public DateTime? NemPublDate { get; set; }
        [Column("nemGetDate", TypeName = "datetime")]
        public DateTime? NemGetDate { get; set; }
        [Column("nempbKind")]
        public int? NempbKind { get; set; }
        [Column("nemPayDate", TypeName = "datetime")]
        public DateTime? NemPayDate { get; set; }
        [Column("nemgetDoc")]
        [StringLength(9)]
        public string NemgetDoc { get; set; }
        [Column("nemBank")]
        public int? NemBank { get; set; }
        [Column("nembCode")]
        [StringLength(5)]
        public string NembCode { get; set; }
        [Column("nembCity")]
        [StringLength(5)]
        public string NembCity { get; set; }
        [Column("nemacCount")]
        [StringLength(29)]
        public string NemacCount { get; set; }
        [Column("nemAmount")]
        public double? NemAmount { get; set; }
        [Column("nemExn")]
        [StringLength(3)]
        public string NemExn { get; set; }
        [Column("nemExnAmoun")]
        public double? NemExnAmoun { get; set; }
        [Column("nemeAmount1")]
        public double? NemeAmount1 { get; set; }
        [Column("nemPayamt")]
        public double? NemPayamt { get; set; }
        [Column("nempbType")]
        public int? NempbType { get; set; }
        [Column("nempbName")]
        [StringLength(39)]
        public string NempbName { get; set; }
        [Column("nempbAddr")]
        [StringLength(29)]
        public string NempbAddr { get; set; }
        [Column("nempbPos")]
        public int? NempbPos { get; set; }
        [Column("nempbTel")]
        [StringLength(19)]
        public string NempbTel { get; set; }
        [Column("nempbVATNo")]
        [StringLength(15)]
        public string NempbVatno { get; set; }
        [Column("nemowType")]
        public int? NemowType { get; set; }
        [Column("nemowName")]
        [StringLength(39)]
        public string NemowName { get; set; }
        [Column("nemowAddr")]
        [StringLength(29)]
        public string NemowAddr { get; set; }
        [Column("nemowPos")]
        public int? NemowPos { get; set; }
        [Column("nemowTel")]
        [StringLength(19)]
        public string NemowTel { get; set; }
        [Column("nemowVATNo")]
        [StringLength(15)]
        public string NemowVatno { get; set; }
        [Column("nemComment")]
        [StringLength(39)]
        public string NemComment { get; set; }
        [Column("nemComment1")]
        [StringLength(39)]
        public string NemComment1 { get; set; }
        [Column("nemTrnPos")]
        public int? NemTrnPos { get; set; }
        [Column("nemTime", TypeName = "datetime")]
        public DateTime? NemTime { get; set; }
        [Column("nemInsdate", TypeName = "datetime")]
        public DateTime? NemInsdate { get; set; }
        [Column("nemId")]
        public int? NemId { get; set; }
        [Column("nemLtTnpos")]
        public int? NemLtTnpos { get; set; }
        [Column("nemcseller")]
        public int? Nemcseller { get; set; }
        [Column("nembcityDescr")]
        [StringLength(15)]
        public string NembcityDescr { get; set; }
        [Column("nemEuro")]
        public double? NemEuro { get; set; }
        [Column("nemEuroState")]
        public int? NemEuroState { get; set; }
        [Column("nemShop")]
        [StringLength(5)]
        public string NemShop { get; set; }
        [Column("nemXart")]
        public int? NemXart { get; set; }

        [InverseProperty(nameof(Ctrn.CtNemOriginNavigation))]
        public virtual ICollection<Ctrn> Ctrns { get; set; }
        [InverseProperty(nameof(Ptrn.PtNemOriginNavigation))]
        public virtual ICollection<Ptrn> Ptrns { get; set; }
    }
}
