using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CASHTRNPARAMS")]
    public partial class Cashtrnparam
    {
        [Key]
        [Column("ctpFileId")]
        public int CtpFileId { get; set; }
        [Column("ctpData", TypeName = "text")]
        public string CtpData { get; set; }
    }
}
