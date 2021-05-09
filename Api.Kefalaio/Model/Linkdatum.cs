using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LINKDATA")]
    public partial class Linkdatum
    {
        [Key]
        [Column("lndFileId")]
        public int LndFileId { get; set; }
        [Column("lndData", TypeName = "text")]
        public string LndData { get; set; }
    }
}
