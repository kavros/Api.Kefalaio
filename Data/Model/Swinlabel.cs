using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SWINLABELS")]
    public partial class Swinlabel
    {
        [Key]
        [Column("swlFileId")]
        public int SwlFileId { get; set; }
        [Column("swlDescr")]
        [StringLength(39)]
        public string SwlDescr { get; set; }
        [Column("swlData", TypeName = "text")]
        public string SwlData { get; set; }
    }
}
