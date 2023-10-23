using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PWINLABELS")]
    public partial class Pwinlabel
    {
        [Key]
        [Column("pwlFileId")]
        public int PwlFileId { get; set; }
        [Column("pwlDescr")]
        [StringLength(39)]
        public string PwlDescr { get; set; }
        [Column("pwlData", TypeName = "text")]
        public string PwlData { get; set; }
    }
}
