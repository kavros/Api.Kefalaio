using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MMAST")]
    [Index(nameof(MCodeBranch), nameof(MMode), nameof(MmFileId), Name = "mmBymCodeBranch", IsUnique = true)]
    [Index(nameof(MMode), nameof(MmFileId), nameof(MCodeBranch), Name = "mmBymmFileId", IsUnique = true)]
    [Index(nameof(MMode), nameof(MmFileId), nameof(MName), Name = "mmBymmName")]
    public partial class Mmast
    {
        public Mmast()
        {
            Contacts = new HashSet<Contact>();
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("mFileId")]
        public int MFileId { get; set; }
        [Required]
        [Column("mCodeBranch")]
        [StringLength(5)]
        public string MCodeBranch { get; set; }
        [Column("mmFileId")]
        public int MmFileId { get; set; }
        [Column("mMode")]
        public int MMode { get; set; }
        [Column("mName")]
        [StringLength(39)]
        public string MName { get; set; }
        [Column("mAddress1")]
        [StringLength(29)]
        public string MAddress1 { get; set; }
        [Column("mAddress2")]
        [StringLength(29)]
        public string MAddress2 { get; set; }
        [Column("mZip")]
        [StringLength(9)]
        public string MZip { get; set; }
        [Column("mArea")]
        [StringLength(29)]
        public string MArea { get; set; }
        [Column("mManager")]
        [StringLength(19)]
        public string MManager { get; set; }
        [Column("mTelef1")]
        [StringLength(19)]
        public string MTelef1 { get; set; }
        [Column("mTelex")]
        [StringLength(19)]
        public string MTelex { get; set; }
        [Column("mSeller")]
        public int? MSeller { get; set; }
        [Column("mCourier")]
        [StringLength(19)]
        public string MCourier { get; set; }
        [Column("mEdiCode")]
        [StringLength(15)]
        public string MEdiCode { get; set; }
        [Column("MNoFpa")]
        public int? MnoFpa { get; set; }
        [Column("mDisc")]
        public double? MDisc { get; set; }
        [Column("mDoy")]
        [StringLength(39)]
        public string MDoy { get; set; }
        [Column("cFileId")]
        public int? CFileId { get; set; }
        [Column("pFileId")]
        public int? PFileId { get; set; }
        [Column("mcpSendWay")]
        [StringLength(3)]
        public string McpSendWay { get; set; }
        [Column("mDOYCode")]
        [StringLength(4)]
        public string MDoycode { get; set; }
        [Column("mtelef2")]
        [StringLength(19)]
        public string Mtelef2 { get; set; }
        [Column("mMobile")]
        [StringLength(19)]
        public string MMobile { get; set; }
        [Column("meMail")]
        [StringLength(59)]
        public string MeMail { get; set; }
        [Column("mComment")]
        [StringLength(39)]
        public string MComment { get; set; }
        [Column("mcpPayWay")]
        [StringLength(3)]
        public string McpPayWay { get; set; }
        [Column("mTextHandle")]
        public int? MTextHandle { get; set; }
        [Column("mDeiCode")]
        [StringLength(15)]
        public string MDeiCode { get; set; }

        [ForeignKey(nameof(CFileId))]
        [InverseProperty(nameof(Cmast.Mmasts))]
        public virtual Cmast CFile { get; set; }
        [ForeignKey(nameof(PFileId))]
        [InverseProperty(nameof(Pmast.Mmasts))]
        public virtual Pmast PFile { get; set; }
        [InverseProperty(nameof(Contact.CnmFile))]
        public virtual ICollection<Contact> Contacts { get; set; }
        [InverseProperty(nameof(Extext.MFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
