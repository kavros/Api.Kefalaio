using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("EXTEXT")]
    public partial class Extext
    {
        [Key]
        [Column("etxFileId")]
        public int EtxFileId { get; set; }
        [Column("etxData", TypeName = "text")]
        public string EtxData { get; set; }
        [Column("sFileId")]
        public int? SFileId { get; set; }
        [Column("stFileId")]
        public int? StFileId { get; set; }
        [Column("cFileId")]
        public int? CFileId { get; set; }
        [Column("ctFileId")]
        public int? CtFileId { get; set; }
        [Column("pFileId")]
        public int? PFileId { get; set; }
        [Column("ptFileId")]
        public int? PtFileId { get; set; }
        [Column("gFileId")]
        public int? GFileId { get; set; }
        [Column("gtFileId")]
        public int? GtFileId { get; set; }
        [Column("gFileId_Old")]
        public int? GFileIdOld { get; set; }
        [Column("gtFileId_Old")]
        public int? GtFileIdOld { get; set; }
        [Column("lFileId")]
        public int? LFileId { get; set; }
        [Column("ltFileId")]
        public int? LtFileId { get; set; }
        [Column("lFileId_Old")]
        public int? LFileIdOld { get; set; }
        [Column("ltFileId_Old")]
        public int? LtFileIdOld { get; set; }
        [Column("sdFileId")]
        public int? SdFileId { get; set; }
        [Column("pdFileId")]
        public int? PdFileId { get; set; }
        [Column("soFileId")]
        public int? SoFileId { get; set; }
        [Column("sloFileId")]
        public int? SloFileId { get; set; }
        [Column("poFileId")]
        public int? PoFileId { get; set; }
        [Column("ploFileId")]
        public int? PloFileId { get; set; }
        [Column("snFileId")]
        public int? SnFileId { get; set; }
        [Column("loFileId")]
        public int? LoFileId { get; set; }
        [Column("mFileId")]
        public int? MFileId { get; set; }

        [ForeignKey(nameof(CFileId))]
        [InverseProperty(nameof(Cmast.Extexts))]
        public virtual Cmast CFile { get; set; }
        [ForeignKey(nameof(CtFileId))]
        [InverseProperty(nameof(Ctrn.Extexts))]
        public virtual Ctrn CtFile { get; set; }
        [ForeignKey(nameof(GFileId))]
        [InverseProperty(nameof(Gmastb.Extexts))]
        public virtual Gmastb GFile { get; set; }
        [ForeignKey(nameof(GFileIdOld))]
        [InverseProperty(nameof(Gmastum.Extexts))]
        public virtual Gmastum GFileIdOldNavigation { get; set; }
        [ForeignKey(nameof(GtFileId))]
        [InverseProperty(nameof(Gtrnb.Extexts))]
        public virtual Gtrnb GtFile { get; set; }
        [ForeignKey(nameof(GtFileIdOld))]
        [InverseProperty(nameof(Gtrna.Extexts))]
        public virtual Gtrna GtFileIdOldNavigation { get; set; }
        [ForeignKey(nameof(LFileId))]
        [InverseProperty(nameof(Lnmast.Extexts))]
        public virtual Lnmast LFile { get; set; }
        [ForeignKey(nameof(LFileIdOld))]
        [InverseProperty(nameof(Lnmastum.Extexts))]
        public virtual Lnmastum LFileIdOldNavigation { get; set; }
        [ForeignKey(nameof(LoFileId))]
        [InverseProperty(nameof(Lotmast.Extexts))]
        public virtual Lotmast LoFile { get; set; }
        [ForeignKey(nameof(LtFileId))]
        [InverseProperty(nameof(Lntrn.Extexts))]
        public virtual Lntrn LtFile { get; set; }
        [ForeignKey(nameof(LtFileIdOld))]
        [InverseProperty(nameof(Lntrna.Extexts))]
        public virtual Lntrna LtFileIdOldNavigation { get; set; }
        [ForeignKey(nameof(MFileId))]
        [InverseProperty(nameof(Mmast.Extexts))]
        public virtual Mmast MFile { get; set; }
        [ForeignKey(nameof(PFileId))]
        [InverseProperty(nameof(Pmast.Extexts))]
        public virtual Pmast PFile { get; set; }
        [ForeignKey(nameof(PdFileId))]
        [InverseProperty(nameof(Bmast1.Extexts))]
        public virtual Bmast1 PdFile { get; set; }
        [ForeignKey(nameof(PloFileId))]
        [InverseProperty(nameof(Bline2.Extexts))]
        public virtual Bline2 PloFile { get; set; }
        [ForeignKey(nameof(PoFileId))]
        [InverseProperty(nameof(Bmast2.Extexts))]
        public virtual Bmast2 PoFile { get; set; }
        [ForeignKey(nameof(PtFileId))]
        [InverseProperty(nameof(Ptrn.Extexts))]
        public virtual Ptrn PtFile { get; set; }
        [ForeignKey(nameof(SFileId))]
        [InverseProperty(nameof(Smast.Extexts))]
        public virtual Smast SFile { get; set; }
        [ForeignKey(nameof(SdFileId))]
        [InverseProperty(nameof(Vmast1.Extexts))]
        public virtual Vmast1 SdFile { get; set; }
        [ForeignKey(nameof(SloFileId))]
        [InverseProperty(nameof(Vline2.Extexts))]
        public virtual Vline2 SloFile { get; set; }
        [ForeignKey(nameof(SnFileId))]
        [InverseProperty(nameof(Serial.Extexts))]
        public virtual Serial SnFile { get; set; }
        [ForeignKey(nameof(SoFileId))]
        [InverseProperty(nameof(Vmast2.Extexts))]
        public virtual Vmast2 SoFile { get; set; }
        [ForeignKey(nameof(StFileId))]
        [InverseProperty(nameof(Strn.Extexts))]
        public virtual Strn StFile { get; set; }
    }
}
