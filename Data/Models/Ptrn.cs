using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PTRN")]
    [Index(nameof(PtDiffId), Name = "ptByDiffId")]
    [Index(nameof(PFileId), nameof(PtDate), nameof(PtInsDate), nameof(PtTime), Name = "ptBypFileId")]
    [Index(nameof(PtDate), nameof(PFileId), nameof(PtInsDate), nameof(PtTime), Name = "ptByptDate")]
    public partial class Ptrn
    {
        public Ptrn()
        {
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("ptFileId")]
        public int PtFileId { get; set; }
        [Column("ptDate", TypeName = "datetime")]
        public DateTime PtDate { get; set; }
        [Column("pFileId")]
        public int PFileId { get; set; }
        [Column("ptTransKind")]
        public int PtTransKind { get; set; }
        [Column("ptDoc")]
        [StringLength(9)]
        public string PtDoc { get; set; }
        [Column("ptDueDate", TypeName = "datetime")]
        public DateTime? PtDueDate { get; set; }
        [Column("ptrseller")]
        public int? Ptrseller { get; set; }
        [Column("ptComment")]
        [StringLength(39)]
        public string PtComment { get; set; }
        [Column("ptNetValue")]
        public double? PtNetValue { get; set; }
        [Column("ptVATValue")]
        public double? PtVatvalue { get; set; }
        [Column("ptExpValue")]
        public double? PtExpValue { get; set; }
        [Column("ptSubsCoder")]
        [StringLength(5)]
        public string PtSubsCoder { get; set; }
        [Column("ptForCncy")]
        [StringLength(3)]
        public string PtForCncy { get; set; }
        [Column("ptFCNetVal")]
        public double? PtFcnetVal { get; set; }
        [Column("ptFCFPAVal")]
        public double? PtFcfpaval { get; set; }
        [Column("ptFCExpVal")]
        public double? PtFcexpVal { get; set; }
        [Column("ptFCCovered")]
        public double? PtFccovered { get; set; }
        [Column("ptDraftOrig")]
        public int? PtDraftOrig { get; set; }
        [Column("ptFromFile")]
        public int? PtFromFile { get; set; }
        [Column("ptPrinted")]
        public int? PtPrinted { get; set; }
        [Column("ptGLUpdated")]
        public int? PtGlupdated { get; set; }
        [Column("ptFiller2")]
        public int? PtFiller2 { get; set; }
        [Column("ptDocOrigin")]
        public int? PtDocOrigin { get; set; }
        [Column("ptInsDate", TypeName = "datetime")]
        public DateTime? PtInsDate { get; set; }
        [Column("ptUserId")]
        public int? PtUserId { get; set; }
        [Column("ptPayMode")]
        [StringLength(3)]
        public string PtPayMode { get; set; }
        [Column("ptTime", TypeName = "datetime")]
        public DateTime? PtTime { get; set; }
        [Column("ptDiffId")]
        public int? PtDiffId { get; set; }
        [Column("ptCovered")]
        public double? PtCovered { get; set; }
        [Column("ptOpenItem", TypeName = "datetime")]
        public DateTime? PtOpenItem { get; set; }
        [Column("ptJrnLNo")]
        public int? PtJrnLno { get; set; }
        [Column("ptTransInventDays", TypeName = "datetime")]
        public DateTime? PtTransInventDays { get; set; }
        [Column("ptTextHandle")]
        public int? PtTextHandle { get; set; }
        [Column("ptBM1Origin")]
        public int? PtBm1origin { get; set; }
        [Column("ptBM2Origin")]
        public int? PtBm2origin { get; set; }
        [Column("ptNemOrigin")]
        public int? PtNemOrigin { get; set; }
        [Column("ptCreditFlag")]
        public int? PtCreditFlag { get; set; }
        [Column("ptDebitFlag")]
        public int? PtDebitFlag { get; set; }
        [Column("ptSalesFlag")]
        public int? PtSalesFlag { get; set; }
        [Column("ptCancelledFlag")]
        public int? PtCancelledFlag { get; set; }
        [Column("ptCancelFlag")]
        public int? PtCancelFlag { get; set; }
        [StringLength(64)]
        public string FlagsSet { get; set; }
        [Column("ptKepyoValue")]
        public double? PtKepyoValue { get; set; }
        [Column("ptKepyoVAT")]
        public double? PtKepyoVat { get; set; }
        [Column("ptComment2")]
        [StringLength(39)]
        public string PtComment2 { get; set; }
        [Column("ptPrevUseInvPos")]
        public int? PtPrevUseInvPos { get; set; }
        [Column("ptPrevUseValue")]
        public double? PtPrevUseValue { get; set; }
        [Column("ptKepyoQty")]
        public int? PtKepyoQty { get; set; }
        [Column("ptKepyoUser")]
        public int? PtKepyoUser { get; set; }
        [Column("ptCmpShop")]
        public int? PtCmpShop { get; set; }

        [ForeignKey(nameof(PFileId))]
        [InverseProperty(nameof(Pmast.Ptrns))]
        public virtual Pmast PFile { get; set; }
        [ForeignKey(nameof(PtBm1origin))]
        [InverseProperty(nameof(Bmast1.Ptrns))]
        public virtual Bmast1 PtBm1originNavigation { get; set; }
        [ForeignKey(nameof(PtBm2origin))]
        [InverseProperty(nameof(Bmast2.Ptrns))]
        public virtual Bmast2 PtBm2originNavigation { get; set; }
        [ForeignKey(nameof(PtNemOrigin))]
        [InverseProperty(nameof(Nemast.Ptrns))]
        public virtual Nemast PtNemOriginNavigation { get; set; }
        [ForeignKey(nameof(PtTransKind))]
        [InverseProperty(nameof(Supltrndescr.Ptrns))]
        public virtual Supltrndescr PtTransKindNavigation { get; set; }
        [InverseProperty(nameof(Extext.PtFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
