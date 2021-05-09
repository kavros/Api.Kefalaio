using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CWINLABELS")]
    public partial class Cwinlabel
    {
        [Key]
        [Column("cwlFileId")]
        public int CwlFileId { get; set; }
        [Column("cwlDescr")]
        [StringLength(39)]
        public string CwlDescr { get; set; }
        [Column("cwlData", TypeName = "text")]
        public string CwlData { get; set; }
    }
}
