using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PURCHMIS")]
    public partial class Purchmi
    {
        [Key]
        [Column("pdmFileId")]
        public int PdmFileId { get; set; }
        [Column("pdmName")]
        [StringLength(39)]
        public string PdmName { get; set; }
        [Column("pdmTrns")]
        [StringLength(256)]
        public string PdmTrns { get; set; }
        [Column("pdmDet")]
        [StringLength(64)]
        public string PdmDet { get; set; }
        [Column("pdmSum")]
        [StringLength(64)]
        public string PdmSum { get; set; }
    }
}
