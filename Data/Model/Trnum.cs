using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TRNUMS")]
    [Index(nameof(TrnFile), nameof(TrnCode), Name = "TrnumByCode", IsUnique = true)]
    [Index(nameof(TrnFile), nameof(TrnKind), nameof(TrnCode), Name = "TrnumByKind", IsUnique = true)]
    [Index(nameof(TrnFile), nameof(TrnSubsId), nameof(TrnKind), nameof(TrnCode), Name = "TrnumBySubsId", IsUnique = true)]
    public partial class Trnum
    {
        public Trnum()
        {
            Bmast1s = new HashSet<Bmast1>();
            Bmast2s = new HashSet<Bmast2>();
            Nelmasts = new HashSet<Nelmast>();
            Nspminvs = new HashSet<Nspminv>();
            Vmast1s = new HashSet<Vmast1>();
            Vmast2s = new HashSet<Vmast2>();
        }

        [Key]
        [Column("trnFileId")]
        public int TrnFileId { get; set; }
        [Required]
        [Column("trnCode")]
        [StringLength(3)]
        public string TrnCode { get; set; }
        [Column("trnFile")]
        public int TrnFile { get; set; }
        [Column("trnSubsId")]
        public int TrnSubsId { get; set; }
        [Column("trnKind")]
        public int TrnKind { get; set; }
        [Column("trnDescr")]
        [StringLength(35)]
        public string TrnDescr { get; set; }
        [Column("trnNum")]
        public int? TrnNum { get; set; }
        [Column("trnSame")]
        public int? TrnSame { get; set; }
        [Column("trnPrtid")]
        public int? TrnPrtid { get; set; }
        [Column("trnPrtMode")]
        public int? TrnPrtMode { get; set; }
        [Column("trnFont")]
        public int? TrnFont { get; set; }
        [Column("trnPlace")]
        public int? TrnPlace { get; set; }
        [Column("trnAuto")]
        public short? TrnAuto { get; set; }
        [Column("trnFaxMode")]
        public int? TrnFaxMode { get; set; }
        [Column("trnFaxFont")]
        public int? TrnFaxFont { get; set; }
        [Column("trnActPos")]
        public int? TrnActPos { get; set; }
        [Column("trnFiscalNo")]
        public int? TrnFiscalNo { get; set; }
        [Column("trnCopies")]
        public int? TrnCopies { get; set; }
        [Column("trnStrictNum")]
        public short? TrnStrictNum { get; set; }
        [Column("tnDesc2")]
        [StringLength(35)]
        public string TnDesc2 { get; set; }
        [Column("trnTradeC")]
        public int? TrnTradeC { get; set; }
        [Column("trnKEkind1")]
        public int? TrnKekind1 { get; set; }
        [Column("trnKEkind2")]
        public int? TrnKekind2 { get; set; }
        [Column("trnKEkind3")]
        public int? TrnKekind3 { get; set; }
        [Column("trnKEkind4")]
        public int? TrnKekind4 { get; set; }
        [Column("trnPrintMode2")]
        public int? TrnPrintMode2 { get; set; }
        [Column("trnPrtId2")]
        public int? TrnPrtId2 { get; set; }
        [Column("trnEmailType")]
        public int? TrnEmailType { get; set; }
        [Column("trnCopies2")]
        public int? TrnCopies2 { get; set; }
        [Column("trnGlCode")]
        [StringLength(25)]
        public string TrnGlCode { get; set; }
        [Column("tnIsInactive")]
        public short? TnIsInactive { get; set; }
        [Column("tnCancelCode")]
        [StringLength(3)]
        public string TnCancelCode { get; set; }
        [Column("trnKepyoCode")]
        public int? TrnKepyoCode { get; set; }
        [Column("tnCashRegID")]
        public int? TnCashRegId { get; set; }
        [Column("tnOtherExp1")]
        public int? TnOtherExp1 { get; set; }
        [Column("tnOtherExp2")]
        public int? TnOtherExp2 { get; set; }
        [Column("tnTaxAgent")]
        public short? TnTaxAgent { get; set; }
        [Column("tnTaxAgentCopies")]
        public short? TnTaxAgentCopies { get; set; }

        [InverseProperty(nameof(Bmast1.PdTrNums))]
        public virtual ICollection<Bmast1> Bmast1s { get; set; }
        [InverseProperty(nameof(Bmast2.PoTrNums))]
        public virtual ICollection<Bmast2> Bmast2s { get; set; }
        [InverseProperty(nameof(Nelmast.NlmTrNums))]
        public virtual ICollection<Nelmast> Nelmasts { get; set; }
        [InverseProperty(nameof(Nspminv.PrmTrNums))]
        public virtual ICollection<Nspminv> Nspminvs { get; set; }
        [InverseProperty(nameof(Vmast1.SdTrNums))]
        public virtual ICollection<Vmast1> Vmast1s { get; set; }
        [InverseProperty(nameof(Vmast2.SoTrNums))]
        public virtual ICollection<Vmast2> Vmast2s { get; set; }
    }
}
