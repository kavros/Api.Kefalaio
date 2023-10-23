using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GTRNB")]
    [Index(nameof(GtDocNum), nameof(GtLine), Name = "gtByDoc")]
    [Index(nameof(GtJournalId), nameof(GtTransNum), nameof(GtDate), nameof(GtLine), Name = "gtByJournalId")]
    [Index(nameof(GtrFromFile), nameof(GtrOrigin), Name = "gtByOrigin")]
    [Index(nameof(GtTransId), nameof(GtLine), Name = "gtByTransId")]
    [Index(nameof(GmFileId), nameof(GtDate), Name = "gtBygmFileId")]
    [Index(nameof(GtDate), nameof(GtGroupNo), nameof(GtLine), Name = "gtBygtDate", IsUnique = true)]
    public partial class Gtrnb
    {
        public Gtrnb()
        {
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("gtFileId")]
        public int GtFileId { get; set; }
        [Column("gtDate", TypeName = "datetime")]
        public DateTime GtDate { get; set; }
        [Column("gmFileId")]
        public int GmFileId { get; set; }
        [Column("gtGroupNo")]
        public int? GtGroupNo { get; set; }
        [Column("gtLine")]
        public int? GtLine { get; set; }
        [Column("gtGLFileid")]
        public int? GtGlfileid { get; set; }
        [Column("gtTransId")]
        public int? GtTransId { get; set; }
        [Column("gtTransKind")]
        public int GtTransKind { get; set; }
        [Column("gtDocNum")]
        [StringLength(9)]
        public string GtDocNum { get; set; }
        [Column("gtDueDate", TypeName = "datetime")]
        public DateTime? GtDueDate { get; set; }
        [Column("gtDebit")]
        public double? GtDebit { get; set; }
        [Column("gtCredit")]
        public double? GtCredit { get; set; }
        [Column("gtFrom")]
        public int? GtFrom { get; set; }
        [Column("gtPeriod")]
        public int? GtPeriod { get; set; }
        [Column("gtUpdated0")]
        public int? GtUpdated0 { get; set; }
        [Column("gtFiller1")]
        public int? GtFiller1 { get; set; }
        [Column("gtComment")]
        [StringLength(39)]
        public string GtComment { get; set; }
        [Column("gtForCrncy")]
        [StringLength(3)]
        public string GtForCrncy { get; set; }
        [Column("gtFcDebit")]
        public double? GtFcDebit { get; set; }
        [Column("gtFCCredit")]
        public double? GtFccredit { get; set; }
        [Column("gtJournalId")]
        public int? GtJournalId { get; set; }
        [Column("gtTransNum")]
        public int? GtTransNum { get; set; }
        [Column("gtInsDate", TypeName = "datetime")]
        public DateTime? GtInsDate { get; set; }
        [Column("gtUserId")]
        public int? GtUserId { get; set; }
        [Column("gtCurrency")]
        public double? GtCurrency { get; set; }
        [Column("gtCanceled")]
        public int? GtCanceled { get; set; }
        [Column("gtPrinted")]
        public int? GtPrinted { get; set; }
        [Column("gtFiller2")]
        public int? GtFiller2 { get; set; }
        [Column("gtFiller3")]
        public int? GtFiller3 { get; set; }
        [Column("gtTime", TypeName = "datetime")]
        public DateTime? GtTime { get; set; }
        [Column("gtComment2")]
        [StringLength(39)]
        public string GtComment2 { get; set; }
        [Column("gtMYFVal")]
        public double? GtMyfval { get; set; }
        [Column("gtrMYFQty")]
        public int? GtrMyfqty { get; set; }
        [Column("gtrMYFUser")]
        public int? GtrMyfuser { get; set; }
        [Column("gtrAlign1")]
        public int? GtrAlign1 { get; set; }
        [Column("gtrFromFile")]
        public int? GtrFromFile { get; set; }
        [Column("gtrOrigin")]
        public int? GtrOrigin { get; set; }
        [Column("gtTextHandle")]
        public int? GtTextHandle { get; set; }
        [StringLength(64)]
        public string FlagsSet { get; set; }
        [Column("gtReformCateg")]
        [StringLength(3)]
        public string GtReformCateg { get; set; }
        [Column("gtReformValue")]
        public double? GtReformValue { get; set; }
        [Column("gtReformPos")]
        public int? GtReformPos { get; set; }
        [Column("gtIsReform")]
        public int? GtIsReform { get; set; }
        [Column("gtrMyfVatVal")]
        public double? GtrMyfVatVal { get; set; }
        [Column("gtrCashregID")]
        public int? GtrCashregId { get; set; }
        [Column("gtCmpShop")]
        public int? GtCmpShop { get; set; }

        [ForeignKey(nameof(GmFileId))]
        [InverseProperty(nameof(Gmastb.Gtrnbs))]
        public virtual Gmastb GmFile { get; set; }
        [ForeignKey(nameof(GtTransKind))]
        [InverseProperty(nameof(Gltrndesc.Gtrnbs))]
        public virtual Gltrndesc GtTransKindNavigation { get; set; }
        [InverseProperty(nameof(Extext.GtFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
