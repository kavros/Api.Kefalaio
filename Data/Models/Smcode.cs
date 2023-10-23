using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SMCODES")]
    [Index(nameof(SmcpFileId), nameof(SmcCode), Name = "smcByCode_Suppl", IsUnique = true)]
    [Index(nameof(SmcpFileId), nameof(SmcsFileId), nameof(SmcCode), Name = "smcBypFileId")]
    [Index(nameof(SmcsFileId), nameof(SmcpFileId), nameof(SmcCode), Name = "smcBysFileId")]
    public partial class Smcode
    {
        [Key]
        [Column("smcPos")]
        public int SmcPos { get; set; }
        [Column("smcsFileId")]
        public int SmcsFileId { get; set; }
        [Column("smcpFileId")]
        public int SmcpFileId { get; set; }
        [Required]
        [Column("smcCode")]
        [StringLength(25)]
        public string SmcCode { get; set; }
        [Column("smcComment")]
        [StringLength(39)]
        public string SmcComment { get; set; }

        [ForeignKey(nameof(SmcpFileId))]
        [InverseProperty(nameof(Pmast.Smcodes))]
        public virtual Pmast SmcpFile { get; set; }
        [ForeignKey(nameof(SmcsFileId))]
        [InverseProperty(nameof(Smast.Smcodes))]
        public virtual Smast SmcsFile { get; set; }
    }
}
