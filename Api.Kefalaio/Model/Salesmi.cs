using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SALESMIS")]
    public partial class Salesmi
    {
        [Key]
        [Column("sdmFileId")]
        public int SdmFileId { get; set; }
        [Column("sdmName")]
        [StringLength(39)]
        public string SdmName { get; set; }
        [Column("sdmTrns")]
        [StringLength(256)]
        public string SdmTrns { get; set; }
        [Column("sdmDet")]
        [StringLength(64)]
        public string SdmDet { get; set; }
        [Column("sdmSum")]
        [StringLength(64)]
        public string SdmSum { get; set; }
    }
}
