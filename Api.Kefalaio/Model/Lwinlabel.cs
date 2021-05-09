using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LWINLABELS")]
    public partial class Lwinlabel
    {
        [Key]
        [Column("lwlFileId")]
        public int LwlFileId { get; set; }
        [Column("lwlDescr")]
        [StringLength(39)]
        public string LwlDescr { get; set; }
        [Column("lwlData", TypeName = "text")]
        public string LwlData { get; set; }
    }
}
