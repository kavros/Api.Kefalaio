using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("TXTLABELS")]
    public partial class Txtlabel
    {
        [Key]
        [Column("txlFileId")]
        public int TxlFileId { get; set; }
        [Column("txlData", TypeName = "text")]
        public string TxlData { get; set; }
    }
}
