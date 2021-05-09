using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LINKDOCS")]
    [Index(nameof(LdcFile), nameof(LdcMpos), nameof(LdcParent), nameof(LdcCaption), Name = "ldcByLink", IsUnique = true)]
    public partial class Linkdoc
    {
        [Key]
        [Column("ldcFileId")]
        public int LdcFileId { get; set; }
        [Column("ldcFile")]
        public int LdcFile { get; set; }
        [Column("ldcMPos")]
        public int LdcMpos { get; set; }
        [Column("ldcParent")]
        public int LdcParent { get; set; }
        [Required]
        [Column("ldcCaption")]
        [StringLength(39)]
        public string LdcCaption { get; set; }
        [Column("ldcFileName")]
        [StringLength(39)]
        public string LdcFileName { get; set; }
        [Column("ldcLinkType")]
        public int? LdcLinkType { get; set; }
        [Column("ldcPath")]
        [StringLength(255)]
        public string LdcPath { get; set; }
    }
}
