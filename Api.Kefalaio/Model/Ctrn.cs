using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CTRN")]
    [Index(nameof(CtDate), nameof(CFileId), nameof(CtInsDate), nameof(CtTime), Name = "ctByDate")]
    [Index(nameof(CtDiffId), Name = "ctByDiffId")]
    [Index(nameof(CFileId), nameof(CtDate), nameof(CtInsDate), nameof(CtTime), Name = "ctBycFileId")]
    public partial class Ctrn
    {
        public Ctrn()
        {
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("ctFileId")]
        public int CtFileId { get; set; }
        [Column("ctDate", TypeName = "datetime")]
        public DateTime CtDate { get; set; }
        [Column("cFileId")]
        public int CFileId { get; set; }
        [Column("ctTransKind")]
        public int CtTransKind { get; set; }
        [Column("ctDoc")]
        [StringLength(9)]
        public string CtDoc { get; set; }
        [Column("ctDueDate", TypeName = "datetime")]
        public DateTime? CtDueDate { get; set; }
        [Column("ctSalesman")]
        public int? CtSalesman { get; set; }
        [Column("ctComment")]
        [StringLength(39)]
        public string CtComment { get; set; }
        [Column("ctNetValue")]
        public double? CtNetValue { get; set; }
        [Column("ctVATValue")]
        public double? CtVatvalue { get; set; }
        [Column("ctExpValue")]
        public double? CtExpValue { get; set; }
        [Column("ctSubsCoder")]
        [StringLength(5)]
        public string CtSubsCoder { get; set; }
        [Column("ctForCncy")]
        [StringLength(3)]
        public string CtForCncy { get; set; }
        [Column("ctFCNetVal")]
        public double? CtFcnetVal { get; set; }
        [Column("ctFCFPAVal")]
        public double? CtFcfpaval { get; set; }
        [Column("ctFCExpVal")]
        public double? CtFcexpVal { get; set; }
        [Column("ctFCCovered")]
        public double? CtFccovered { get; set; }
        [Column("ctDraftOrig")]
        public int? CtDraftOrig { get; set; }
        [Column("ctFromFile")]
        public int? CtFromFile { get; set; }
        [Column("ctPrinted")]
        public int? CtPrinted { get; set; }
        [Column("ctGLUpdated")]
        public int? CtGlupdated { get; set; }
        [Column("ctFlagNull")]
        public int? CtFlagNull { get; set; }
        [Column("ctDocOrigin")]
        public int? CtDocOrigin { get; set; }
        [Column("ctInsDate", TypeName = "datetime")]
        public DateTime? CtInsDate { get; set; }
        [Column("ctUserId")]
        public int? CtUserId { get; set; }
        [Column("ctPayMode")]
        [StringLength(3)]
        public string CtPayMode { get; set; }
        [Column("ctTime", TypeName = "datetime")]
        public DateTime? CtTime { get; set; }
        [Column("ctDiffId")]
        public int? CtDiffId { get; set; }
        [Column("ctCovered")]
        public double? CtCovered { get; set; }
        [Column("ctOpenItem", TypeName = "datetime")]
        public DateTime? CtOpenItem { get; set; }
        [Column("ctJrnLNo")]
        public int? CtJrnLno { get; set; }
        [Column("ctTransInventDays", TypeName = "datetime")]
        public DateTime? CtTransInventDays { get; set; }
        [Column("ctTextHandle")]
        public int? CtTextHandle { get; set; }
        [Column("ctVM1Origin")]
        public int? CtVm1origin { get; set; }
        [Column("ctVM2Origin")]
        public int? CtVm2origin { get; set; }
        [Column("ctNemOrigin")]
        public int? CtNemOrigin { get; set; }
        [Column("ctCreditFlag")]
        public int? CtCreditFlag { get; set; }
        [Column("ctDebitFlag")]
        public int? CtDebitFlag { get; set; }
        [Column("ctSalesFlag")]
        public int? CtSalesFlag { get; set; }
        [Column("ctCancelledFlag")]
        public int? CtCancelledFlag { get; set; }
        [Column("ctCancelFlag")]
        public int? CtCancelFlag { get; set; }
        [StringLength(64)]
        public string FlagsSet { get; set; }
        [Column("ctKepyoValue")]
        public double? CtKepyoValue { get; set; }
        [Column("ctKepyoVAT")]
        public double? CtKepyoVat { get; set; }
        [Column("ctPointsEarned")]
        public int? CtPointsEarned { get; set; }
        [Column("ctPointsUsed")]
        public int? CtPointsUsed { get; set; }
        [Column("ctPointsUsedValue")]
        public double? CtPointsUsedValue { get; set; }
        [Column("ctComment2")]
        [StringLength(39)]
        public string CtComment2 { get; set; }
        [Column("ctPrevUsePos")]
        public int? CtPrevUsePos { get; set; }
        [Column("ctPrevUseValue")]
        public double? CtPrevUseValue { get; set; }
        [Column("ctKepyoQty")]
        public int? CtKepyoQty { get; set; }
        [Column("ctKepyoUser")]
        public int? CtKepyoUser { get; set; }
        [Column("ctCmpShop")]
        public int? CtCmpShop { get; set; }

        [ForeignKey(nameof(CFileId))]
        [InverseProperty(nameof(Cmast.Ctrns))]
        public virtual Cmast CFile { get; set; }
        [ForeignKey(nameof(CtNemOrigin))]
        [InverseProperty(nameof(Nemast.Ctrns))]
        public virtual Nemast CtNemOriginNavigation { get; set; }
        [ForeignKey(nameof(CtTransKind))]
        [InverseProperty(nameof(Custtrndesc.Ctrns))]
        public virtual Custtrndesc CtTransKindNavigation { get; set; }
        [ForeignKey(nameof(CtVm1origin))]
        [InverseProperty(nameof(Vmast1.Ctrns))]
        public virtual Vmast1 CtVm1originNavigation { get; set; }
        [ForeignKey(nameof(CtVm2origin))]
        [InverseProperty(nameof(Vmast2.Ctrns))]
        public virtual Vmast2 CtVm2originNavigation { get; set; }
        [InverseProperty(nameof(Extext.CtFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
