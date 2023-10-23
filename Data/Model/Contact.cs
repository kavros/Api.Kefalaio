using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CONTACTS")]
    [Index(nameof(CncFileId), nameof(CnNameSrt), Name = "cnBycName")]
    [Index(nameof(CnmFileId), nameof(CnNameSrt), Name = "cnBymFileId")]
    [Index(nameof(CnpFileId), nameof(CnNameSrt), Name = "cnBypName")]
    public partial class Contact
    {
        [Key]
        [Column("cnFileId")]
        public int CnFileId { get; set; }
        [Column("cncFileId")]
        public int? CncFileId { get; set; }
        [Column("cnpFileId")]
        public int? CnpFileId { get; set; }
        [Column("cnmFileId")]
        public int? CnmFileId { get; set; }
        [Column("cnName")]
        [StringLength(39)]
        public string CnName { get; set; }
        [Column("cnName_srt")]
        [StringLength(39)]
        public string CnNameSrt { get; set; }
        [Column("cnPhone1")]
        [StringLength(19)]
        public string CnPhone1 { get; set; }
        [Column("cnPhone2")]
        [StringLength(19)]
        public string CnPhone2 { get; set; }
        [Column("cnEmail")]
        [StringLength(59)]
        public string CnEmail { get; set; }
        [Column("cnComment")]
        [StringLength(39)]
        public string CnComment { get; set; }
        [Column("cnIsPrimary")]
        public short? CnIsPrimary { get; set; }
        [Column("cnFiller")]
        public int? CnFiller { get; set; }

        [ForeignKey(nameof(CncFileId))]
        [InverseProperty(nameof(Cmast.Contacts))]
        public virtual Cmast CncFile { get; set; }
        [ForeignKey(nameof(CnmFileId))]
        [InverseProperty(nameof(Mmast.Contacts))]
        public virtual Mmast CnmFile { get; set; }
        [ForeignKey(nameof(CnpFileId))]
        [InverseProperty(nameof(Pmast.Contacts))]
        public virtual Pmast CnpFile { get; set; }
    }
}
